Imports Microsoft.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Text

Public Class FormVentas

    ' 🔗 Cambia estos datos según tu configuración local
    Private conexion As New SqlConnection("Server=localhost\SQLEXPRESS01;Database=ortopedia_taller;Trusted_Connection=True;TrustServerCertificate=True;")

    Private totalVenta As Decimal = 0D

    ' 📦 Cargar productos en el ComboBox
    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarProductos()
        ConfigurarDataGridView()
    End Sub

    Private Sub CargarProductos()
        Try
            conexion.Open()
            Dim consulta As String = "SELECT ProductoID, Nombre, Precio, Stock FROM Productos WHERE EstadoLogico = 1 AND Stock > 0"
            Dim cmd As New SqlCommand(consulta, conexion)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            Dim dt As New DataTable()
            dt.Load(reader)

            cmbProductos.DataSource = dt
            cmbProductos.DisplayMember = "Nombre"
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
        DgvDetalle.Columns.Add("Nombre", "Producto")
        DgvDetalle.Columns.Add("Cantidad", "Cantidad")
        DgvDetalle.Columns.Add("PrecioUnitario", "Precio Unitario")
        DgvDetalle.Columns.Add("Subtotal", "Subtotal")

        DgvDetalle.ReadOnly = True
        DgvDetalle.AllowUserToAddRows = False
    End Sub

    ' 🔍 Mostrar precio del producto seleccionado
    Private Sub cmbProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductos.SelectedIndexChanged
        If cmbProductos.SelectedValue IsNot Nothing Then
            Try
                conexion.Open()
                Dim consulta As String = "SELECT Precio FROM Productos WHERE ProductoID = @id"
                Dim cmd As New SqlCommand(consulta, conexion)
                cmd.Parameters.AddWithValue("@id", cmbProductos.SelectedValue)
                Dim precio = Convert.ToDecimal(cmd.ExecuteScalar())
                txtPrecio.Text = precio.ToString("0.00")
            Catch ex As Exception
                MessageBox.Show("Error al obtener precio: " & ex.Message)
            Finally
                conexion.Close()
            End Try
        End If
    End Sub

    ' ➕ Agregar producto al detalle
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If cmbProductos.SelectedValue Is Nothing OrElse txtCantidad.Text = "" Then
            MessageBox.Show("Seleccione un producto y cantidad.")
            Return
        End If

        Dim idProducto As Integer = CInt(cmbProductos.SelectedValue)
        Dim nombre As String = cmbProductos.Text
        Dim cantidad As Integer = CInt(txtCantidad.Text)
        Dim precioUnitario As Decimal = Decimal.Parse(txtPrecio.Text)
        Dim subtotal As Decimal = cantidad * precioUnitario

        DgvDetalle.Rows.Add(idProducto, nombre, cantidad, precioUnitario.ToString("0.00"), subtotal.ToString("0.00"))
        totalVenta += subtotal
        lblTotal.Text = totalVenta.ToString("0.00")

        txtCantidad.Clear()
    End Sub

    ' 🗑️ Quitar producto del detalle
    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        If DgvDetalle.CurrentRow IsNot Nothing Then
            Dim subtotal As Decimal = Decimal.Parse(DgvDetalle.CurrentRow.Cells("Subtotal").Value)
            totalVenta -= subtotal
            lblTotal.Text = totalVenta.ToString("0.00")
            DgvDetalle.Rows.Remove(DgvDetalle.CurrentRow)
        End If
    End Sub

    ' 💾 Confirmar venta (guardar en SQL)
    ' 💾 Confirmar venta (guardar en SQL)
    Private Sub btnConfirmarVenta_Click(sender As Object, e As EventArgs) Handles btnConfirmarVenta.Click
        If DgvDetalle.Rows.Count = 0 Then
            MessageBox.Show("Debe agregar al menos un producto.")
            Return
        End If

        Dim idVentaRegistrada As Integer ' Variable para guardar el ID de la venta

        Try
            conexion.Open()
            Dim transaccion As SqlTransaction = conexion.BeginTransaction()

            ' Insertar venta y obtener ID
            Dim cmdVenta As New SqlCommand("INSERT INTO Ventas (Fecha, Usuario, Total) OUTPUT INSERTED.VentaID VALUES (GETDATE(), @usuario, @total)", conexion, transaccion)
            cmdVenta.Parameters.AddWithValue("@usuario", Environment.UserName)
            cmdVenta.Parameters.AddWithValue("@total", totalVenta)
            idVentaRegistrada = CInt(cmdVenta.ExecuteScalar()) ' <-- Aquí obtenemos el ID

            ' ... (El resto del código de DetalleVenta y Stock sigue igual) ...
            For Each fila As DataGridViewRow In DgvDetalle.Rows
                Dim idProducto As Integer = CInt(fila.Cells("ProductoID").Value)
                Dim cantidad As Integer = CInt(fila.Cells("Cantidad").Value)
                Dim precioUnitario As Decimal = CDec(fila.Cells("PrecioUnitario").Value)

                ' Insertar detalle
                Dim cmdDetalle As New SqlCommand("INSERT INTO DetalleVenta (VentaID, ProductoID, Cantidad, PrecioUnitario) VALUES (@venta, @prod, @cant, @precio)", conexion, transaccion)
                cmdDetalle.Parameters.AddWithValue("@venta", idVentaRegistrada) ' Usamos el ID de la venta
                cmdDetalle.Parameters.AddWithValue("@prod", idProducto)
                cmdDetalle.Parameters.AddWithValue("@cant", cantidad)
                cmdDetalle.Parameters.AddWithValue("@precio", precioUnitario)
                cmdDetalle.ExecuteNonQuery()

                ' Actualizar stock
                Dim cmdStock As New SqlCommand("UPDATE Productos SET Stock = Stock - @cant WHERE ProductoID = @id", conexion, transaccion)
                cmdStock.Parameters.AddWithValue("@cant", cantidad)
                cmdStock.Parameters.AddWithValue("@id", idProducto)
                cmdStock.ExecuteNonQuery()
            Next

            transaccion.Commit()

            ' ----------------------------------------------------
            ' 🚀 NUEVO PASO: IMPRIMIR TICKET
            ImprimirTicket(idVentaRegistrada, DgvDetalle)
            ' ----------------------------------------------------

            MessageBox.Show("✅ Venta registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Limpiar la interfaz después de la impresión
            DgvDetalle.Rows.Clear()
            lblTotal.Text = "0.00"
            totalVenta = 0
            CargarProductos() ' Recargar productos para actualizar stock

        Catch ex As Exception
            ' Manejo de errores de la Transacción o SQL
            MessageBox.Show("Error al guardar la venta: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub ImprimirTicket(ByVal idVenta As Integer, ByVal detalleVenta As DataGridView)

        ' 📝 Construir el contenido del Ticket
        Dim sb As New StringBuilder()

        ' --- ENCABEZADO ---
        sb.AppendLine(String.Empty.PadRight(32, "="))
        sb.AppendLine("    ORTOPEDIA EL TALLER") ' Centrado manual para 32 caracteres
        sb.AppendLine("   ¡Gracias por su compra!")
        sb.AppendLine(String.Empty.PadRight(32, "="))
        sb.AppendLine($"TICKET NO: {idVenta}")
        sb.AppendLine($"FECHA: {DateTime.Now.ToString("dd/MM/yyyy HH:mm")}")
        sb.AppendLine(String.Empty.PadRight(32, "-"))
        sb.AppendLine("CANT | PRODUCTO        | IMPORTE")
        sb.AppendLine(String.Empty.PadRight(32, "-"))

        ' --- DETALLE DE PRODUCTOS ---
        For Each fila As DataGridViewRow In detalleVenta.Rows
            Dim nombreProd As String = fila.Cells("Nombre").Value.ToString()
            Dim cantidad As Integer = CInt(fila.Cells("Cantidad").Value)
            Dim subtotal As Decimal = CDec(fila.Cells("Subtotal").Value)

            ' Formateo de la línea: Cantidad | Nombre (acortado) | Subtotal
            Dim nombreRecortado As String = If(nombreProd.Length > 16, nombreProd.Substring(0, 16), nombreProd)

            sb.Append(String.Format("{0,-4}", cantidad.ToString()))
            sb.Append(String.Format("| {0,-16}", nombreRecortado))
            sb.AppendLine(String.Format("| {0,7:N2}", subtotal))
        Next

        ' --- TOTAL Y PIE DE PÁGINA ---
        sb.AppendLine(String.Empty.PadRight(32, "="))
        sb.AppendLine(String.Format("TOTAL A PAGAR: {0,17:N2}", totalVenta))
        sb.AppendLine(String.Empty.PadRight(32, "="))

        ' Agregar saltos de línea extra para que el papel salga del cortador
        sb.AppendLine(vbCrLf)
        sb.AppendLine(vbCrLf)

        Dim textoCompleto As String = sb.ToString()


        ' 🖨️ Enviar a la impresora
        Try
            Dim pd As New PrintDocument()

            ' ⚠️ IMPORTANTE: Reemplaza "Nombre de tu Impresora" con el nombre EXACTO
            ' que tiene tu impresora de tickets instalada en Windows.
            pd.PrinterSettings.PrinterName = "hp"

            ' Si usas una impresora térmica, usa una fuente monoespaciada como "Courier New"
            Dim printFont As New Font("Courier New", 10)

            AddHandler pd.PrintPage, Sub(s, ev)
                                         ev.Graphics.DrawString(textoCompleto, printFont, Brushes.Black, 0, 0)
                                         ' ev.Graphics.DrawString(textoCompleto, printFont, Brushes.Black, New PointF(0, 0)) ' Alternativa para PointF
                                     End Sub

            pd.Print()

        Catch ex As Exception
            MessageBox.Show("Error de impresión: " & ex.Message, "Impresora", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class
