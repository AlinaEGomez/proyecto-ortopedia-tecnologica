Imports System.Drawing
Imports System.Drawing.Printing
Imports System.IO ' Aunque solo es texto, es buena práctica
Imports System.Text
Imports Microsoft.Data.SqlClient

Public Class FormregistarVentas
    ' Dentro de FormVentas.vb (Ej: Control de seguridad)

    Private Sub AplicarRestriccionRol()
        ' Lees el valor del módulo
        If MdlSesion.PerfilUsuario = "Administrador" Then
            btnConfirmarVenta.Enabled = False
        End If
    End Sub

    Private Sub AlgunaFuncionBD()
        ' Usas la cadena de conexión global
        Dim conexion As New SqlConnection(MdlSesion.CadenaConexion)
        Dim consulta As String = "SELECT Id, Contrasena, Perfil, Nombre_Apellido, Activo FROM Usuarios WHERE Email = @Email"
        Dim cmd As New SqlCommand(consulta, conexion)
        ' Usas el ID global
        cmd.Parameters.AddWithValue("@idVendedor", MdlSesion.VendedorID)
    End Sub
    ' Variable global para el ID del usuario logueado
    Public Shared VendedorID_Actual As Integer = 2
    Public Shared NombreVendedor_Actual As String = "Vendedor"
    Public Shared GlobalData = "Administrador"
    ' 🔗 Cambia estos datos según tu configuración local
    Private conexion As New SqlConnection("Server=localhost\SQLEXPRESS01;Database=ortopedicTecnologi_taller;Trusted_Connection=True;TrustServerCertificate=True;")

    Private totalVenta As Decimal = 0D


    ' 📦 Cargar productos en el ComboBox
    Private Sub FormRegistarVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarProductos()
        ConfigurarDataGridView()
    End Sub

    Private Sub CargarProductos()
        Try
            conexion.Open()
            Dim consulta As String = "SELECT ProductoID, descripcion,Precio, Stock FROM Productos WHERE EstadoLogico = 1 AND Stock > 0"
            Dim cmd As New SqlCommand(consulta, conexion)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            Dim dt As New DataTable()
            dt.Load(reader)

            cmbProductos.DataSource = dt
            cmbProductos.DisplayMember = "Descripcion"
            cmbProductos.ValueMember = "ProductoID"

        Catch ex As Exception
            MessageBox.Show("Error al cargar los productos: " & ex.Message)
        Finally
            conexion.Close()
        End Try


    End Sub

    ' ⚙️ Configurar columnas del DataGridView
    Private Sub ConfigurarDataGridView()
        DgvDetalle.Columns.Add("ProductoID", "ID Producto")
        DgvDetalle.Columns.Add("Descripcion", "Producto")
        DgvDetalle.Columns.Add("Cantidad", "Cantidad")
        DgvDetalle.Columns.Add("PrecioUnitario", "Precio Unitario")
        DgvDetalle.Columns.Add("Subtotal", "Subtotal")

        DgvDetalle.ReadOnly = True
        DgvDetalle.AllowUserToAddRows = False
    End Sub

    ' 🔍 Mostrar precio del producto seleccionado

    Private Sub cmbProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductos.SelectedIndexChanged

        ' 1. Verificación Inicial: Si no hay un elemento seleccionado o el DataSource está reiniciándose, salir.
        If cmbProductos.SelectedIndex = -1 Then Return

        ' 🔑 VERIFICACIÓN CRÍTICA: Asegurarse de que SelectedValue NO sea Nothing o DBNull.
        If cmbProductos.SelectedValue Is Nothing OrElse cmbProductos.SelectedValue Is DBNull.Value Then
            txtPrecio.Text = "00.00" ' Limpiar si no hay valor
            Return
        End If

        ' Si llegamos aquí, SelectedValue contiene un valor válido (el ProductoID)
        Try
            ' 2. Obtener el ID del producto (Conversión segura)
            Dim productoID As Integer = CInt(cmbProductos.SelectedValue)

            ' 3. Abrir la conexión y ejecutar la consulta
            conexion.Open()

            Dim consulta As String = "SELECT Precio FROM Productos WHERE ProductoID = @id"
            Dim cmd As New SqlCommand(consulta, conexion)
            cmd.Parameters.AddWithValue("@id", productoID)

            Dim precio = cmd.ExecuteScalar()

            ' 4. Mostrar el precio si es válido
            If precio IsNot DBNull.Value AndAlso precio IsNot Nothing Then
                txtPrecio.Text = Convert.ToDecimal(precio).ToString("0.00")
            Else
                txtPrecio.Text = "00.00"
            End If

        Catch ex As Exception
            MessageBox.Show("Error al obtener precio: " & ex.Message, "Error BD")

        Finally
            ' 5. Asegurar el cierre de la conexión (Esto ya está bien implementado)
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try

    End Sub

    ' ➕ Agregar producto al detalle
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If cmbProductos.SelectedValue Is Nothing OrElse txtCantidad.Text = "" Then
            MessageBox.Show("Seleccione un producto y cantidad.")
            Return
        End If

        Dim idProducto As Integer = CInt(cmbProductos.SelectedValue)
        Dim descripcion As String = cmbProductos.Text
        Dim cantidad As Integer = CInt(txtCantidad.Text)
        Dim precioUnitario As Decimal = Decimal.Parse(txtPrecio.Text)
        Dim subtotal As Decimal = cantidad * precioUnitario

        DgvDetalle.Rows.Add(idProducto, descripcion, cantidad, precioUnitario.ToString("0.00"), subtotal.ToString("0.00"))
        totalVenta += subtotal
        lblTotal.Text = totalVenta.ToString("0.00")

        txtCantidad.Clear()
    End Sub

    ' 🗑️ Quitar producto del detalle
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        ' 1. Verificar si hay filas y si hay alguna fila seleccionada (CurrentRow)
        If DgvDetalle.CurrentRow IsNot Nothing AndAlso DgvDetalle.Rows.Count > 0 Then

            Dim filaActual As DataGridViewRow = DgvDetalle.CurrentRow

            Try
                ' 2. Obtener el Subtotal de la celda de forma segura
                ' Usamos CDec para conversión y verificamos el valor de la celda.

                Dim valorCelda As Object = filaActual.Cells("Subtotal").Value

                ' Aseguramos que el valor no sea DBNull antes de convertir
                If valorCelda IsNot Nothing AndAlso valorCelda IsNot DBNull.Value Then

                    Dim subtotal As Decimal = CDec(valorCelda)

                    ' 3. Actualizar el Total y la Etiqueta
                    totalVenta -= subtotal
                    lblTotal.Text = totalVenta.ToString("0.00")

                    ' 4. Eliminar la Fila
                    DgvDetalle.Rows.Remove(filaActual)

                Else
                    MessageBox.Show("No se pudo obtener el subtotal. La fila puede estar vacía o dañada.", "Error Interno", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            Catch ex As Exception
                MessageBox.Show("Error al quitar el producto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Else
            ' Mensaje útil si el usuario presiona sin seleccionar
            MessageBox.Show("Debe seleccionar una fila del detalle para poder quitar el producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' 💾 Confirmar venta (guardar en SQL)

    Private Sub btnConfirmarVenta_Click(sender As Object, e As EventArgs) Handles btnConfirmarVenta.Click

        ' 🔑 PASO 1: VALIDACIÓN COMPLETA - Si falla, no abrimos la conexión
        If Not ValidarVenta() Then
            Return
        End If

        ' 🔑 CONTROL DE SEGURIDAD DE ROL (Aseguramos que solo vendan los autorizados)
        If MdlSesion.PerfilUsuario <> "vendedor" AndAlso MdlSesion.PerfilUsuario <> "gerente" Then
            MessageBox.Show("Solo Vendedores y Gerentes pueden confirmar ventas.", "Permiso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim idVentaRegistrada As Integer = 0
        Dim transaccion As SqlTransaction = Nothing

        Try
            conexion.Open()
            transaccion = conexion.BeginTransaction()

            ' 3. Insertar venta (Cabecera)
            Using cmdVenta As New SqlCommand("INSERT INTO Ventas (Fecha, IdVendedor, Total) OUTPUT INSERTED.VentaID VALUES (GETDATE(), @idVendedor, @total)", conexion, transaccion)
                ' ⚠️ Usamos MdlSesion.VendedorID para el ID real
                cmdVenta.Parameters.AddWithValue("@idVendedor", MdlSesion.VendedorID)
                cmdVenta.Parameters.AddWithValue("@total", totalVenta)
                idVentaRegistrada = CInt(cmdVenta.ExecuteScalar())
            End Using

            ' 4. Bucle For Each para Detalle y Stock
            Dim insertDetalleSQL As String = "INSERT INTO DetalleVenta (VentaID, ProductoID, Cantidad, PrecioUnitario) VALUES (@vID, @pID, @cant, @precioU)"
            Dim updateStockSQL As String = "UPDATE Productos SET Stock = Stock - @cant WHERE ProductoID = @pID" ' 🔑 DESCUENTO DE STOCK

            For Each fila As DataGridViewRow In DgvDetalle.Rows
                Dim pID As Integer = CInt(fila.Cells("ProductoID").Value)
                Dim cantidadVendida As Integer = CInt(fila.Cells("Cantidad").Value)
                Dim precioUnitario As Decimal = Decimal.Parse(fila.Cells("PrecioUnitario").Value.ToString())

                ' 4a. Insertar Detalle
                Using cmdDetalle As New SqlCommand(insertDetalleSQL, conexion, transaccion)
                    cmdDetalle.Parameters.AddWithValue("@vID", idVentaRegistrada)
                    cmdDetalle.Parameters.AddWithValue("@pID", pID)
                    cmdDetalle.Parameters.AddWithValue("@cant", cantidadVendida)
                    cmdDetalle.Parameters.AddWithValue("@precioU", precioUnitario)
                    cmdDetalle.ExecuteNonQuery()
                End Using

                ' 4b. Actualizar Stock
                Using cmdStock As New SqlCommand(updateStockSQL, conexion, transaccion)
                    cmdStock.Parameters.AddWithValue("@cant", cantidadVendida)
                    cmdStock.Parameters.AddWithValue("@pID", pID)
                    cmdStock.ExecuteNonQuery()
                End Using

            Next ' FIN DEL BUCLE

            ' 5. COMMIT
            transaccion.Commit()
            GenerarComprobante(idVentaRegistrada, DgvDetalle)
            MessageBox.Show("✅ Venta N° " & idVentaRegistrada & " registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' 6. Limpieza post-venta
            DgvDetalle.Rows.Clear()
            totalVenta = 0D
            lblTotal.Text = "0.00"
            CargarProductos() ' Recarga el ComboBox de productos para actualizar el stock visible

        Catch ex As Exception
            MessageBox.Show("Error al guardar la venta: " & ex.Message & vbCrLf & "Se ha revertido la transacción.", "Error")

            ' 7. ROLLBACK SEGURO
            If transaccion IsNot Nothing Then
                Try
                    transaccion.Rollback()
                Catch rollEx As Exception
                    MessageBox.Show("Error al intentar revertir la transacción: " & rollEx.Message, "Error Crítico")
                End Try
            End If

        Finally
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub

    ' ----------------------------------------------------
    ' 🔑 FUNCIÓN DE VALIDACIÓN (Añadir al formulario)
    ' ----------------------------------------------------
    Private Function ValidarVenta() As Boolean

        ' 1. Verificar Vendedor/Usuario Logueado (ID de Vendedor)
        If MdlSesion.VendedorID <= 0 Then
            MessageBox.Show("Error de sesión: No se ha detectado un vendedor válido.", "Error de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' 2. Verificar si hay productos en el detalle
        If DgvDetalle.Rows.Count = 0 Then
            MessageBox.Show("No puede confirmar una venta sin productos en el detalle.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' 3. Verificar que el total de la venta no sea cero
        If totalVenta <= 0 Then
            MessageBox.Show("El total de la venta es cero. Agregue productos o verifique los precios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' 4. (Opcional) Validación de stock insuficiente (Se podría hacer un chequeo final aquí o en SQL)
        '    Por ahora, confiamos en que el SQL UPDATE falle si el stock es bajo (Stock - Cantidad < 0)

        Return True
    End Function

    Private Sub GenerarComprobante(ByVal idVenta As Integer, ByVal detalleVenta As DataGridView)

        ' 1. CONSTRUIR EL CONTENIDO DEL TEXTO
        Dim sb As New StringBuilder()

        ' --- ENCABEZADO ---
        sb.AppendLine("    ORTOPEDIA TECNOLOGICA")
        sb.AppendLine("    COMPROBANTE DE VENTA")
        sb.AppendLine("==================================")
        sb.AppendLine($"TICKET NO: {idVenta}")

        sb.AppendLine($"FECHA: {DateTime.Now.ToString("dd/MM/yyyy HH:mm")}")
        sb.AppendLine("----------------------------------")
        sb.AppendLine("CANT | PRODUCTO             | IMPORTE")
        sb.AppendLine("----------------------------------")

        ' --- DETALLE DE PRODUCTOS ---
        For Each fila As DataGridViewRow In detalleVenta.Rows
            Dim nombreProd As String = fila.Cells("Descripcion").Value.ToString()
            Dim cantidad As Integer = CInt(fila.Cells("Cantidad").Value)
            Dim subtotal As Decimal = CDec(fila.Cells("Subtotal").Value)

            ' Formato de texto con alineación para simular tabla
            Dim nombreRecortado As String = If(nombreProd.Length > 20, nombreProd.Substring(0, 20), nombreProd)

            sb.Append(String.Format("{0,-4}", cantidad.ToString()))
            sb.Append(String.Format("| {0,-21}", nombreRecortado))
            sb.AppendLine(String.Format("| {0,7:N2}", subtotal))
        Next

        ' --- TOTAL Y PIE DE PÁGINA ---
        sb.AppendLine("----------------------------------")
        sb.AppendLine(String.Format("TOTAL A PAGAR: {0,21:N2}", totalVenta))
        sb.AppendLine("==================================")
        sb.AppendLine(vbCrLf)
        sb.AppendLine("       GRACIAS POR SU COMPRA")

        Dim TextoCompleto As String = sb.ToString()

        ' 2. ENVIAR EL TEXTO A IMPRESIÓN
        Try
            Dim pd As New PrintDocument()

            ' Asignar la fuente, generalmente monoespaciada para alineación
            Dim printFont As New Font("Courier New", 10)

            ' Abrir el diálogo de impresión para que el usuario elija la impresora
            Using pDialog As New PrintDialog()
                pDialog.Document = pd

                If pDialog.ShowDialog() = DialogResult.OK Then
                    ' El usuario seleccionará "Microsoft Print to PDF" o similar

                    AddHandler pd.PrintPage, Sub(s, ev)
                                                 ev.Graphics.DrawString(TextoCompleto, printFont, Brushes.Black, 0, 0)
                                                 ev.HasMorePages = False ' Solo una página
                                             End Sub

                    pd.Print()
                Else
                    MessageBox.Show("Impresión cancelada por el usuario.", "Aviso")
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al generar el PDF/Imprimir: " & ex.Message, "Error")
        End Try

    End Sub




End Class
