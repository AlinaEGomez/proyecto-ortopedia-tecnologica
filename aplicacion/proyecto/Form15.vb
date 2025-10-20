Imports System.Drawing
Imports System.Drawing.Printing
Imports System.IO ' Aunque solo es texto, es buena práctica
Imports System.Text
Imports Microsoft.Data.SqlClient

Public Class FormVentas

    ' Variable global para el ID del usuario logueado
    Public Shared VendedorID_Actual As Integer = 0
    Public Shared NombreVendedor_Actual As String = "Vendedor"

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
        ' ... (validaciones iniciales) ...

        Dim idVentaRegistrada As Integer
        ' 1. 🔑 DECLARACIÓN FUERA DEL TRY
        Dim transaccion As SqlTransaction = Nothing

        Try
            conexion.Open()
            ' 2. 🔑 ASIGNACIÓN DENTRO DEL TRY
            transaccion = conexion.BeginTransaction()

            ' 3. Insertar venta y obtener ID
            ' Insertar venta
            ' ⚠️ Revisa que el nombre del campo en tu BD sea IdUsuario
            Using cmdVenta As New SqlCommand("INSERT INTO Ventas (Fecha, Usuario, Total) OUTPUT INSERTED.VentaID VALUES (GETDATE(), @usuario, @total)", conexion, transaccion)
                cmdVenta.Parameters.AddWithValue("@usuario", VendedorID_Actual)
                cmdVenta.Parameters.AddWithValue("@total", totalVenta)
                idVentaRegistrada = CInt(cmdVenta.ExecuteScalar())
            End Using

            ' 4. Bucle For Each para Detalle y Stock (USANDO transaccion)
            ' ... (tu código de detalle y stock con Using) ...

            transaccion.Commit()
            GenerarComprobante(idVentaRegistrada, DgvDetalle)
            MessageBox.Show("✅ Venta registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error al guardar la venta: " & ex.Message)

            ' 5. ⚠️ ROLLBACK SEGURO
            If transaccion IsNot Nothing Then
                Try
                    ' Intentar hacer Rollback si la transacción existe y la conexión está abierta
                    transaccion.Rollback()
                Catch rollEx As Exception
                    ' Si el Rollback falla, solo notificar (la conexión puede haber fallado antes)
                    MessageBox.Show("Error al intentar revertir la transacción: " & rollEx.Message, "Error Crítico")
                End Try
            End If

        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub GenerarComprobante(ByVal idVenta As Integer, ByVal detalleVenta As DataGridView)

        ' 1. CONSTRUIR EL CONTENIDO DEL TEXTO
        Dim sb As New StringBuilder()

        ' --- ENCABEZADO ---
        sb.AppendLine("    ORTOPEDIA EL TALLER")
        sb.AppendLine("    COMPROBANTE DE VENTA")
        sb.AppendLine("==================================")
        sb.AppendLine($"TICKET NO: {idVenta}")
        sb.AppendLine($"FECHA: {DateTime.Now.ToString("dd/MM/yyyy HH:mm")}")
        sb.AppendLine("----------------------------------")
        sb.AppendLine("CANT | PRODUCTO             | IMPORTE")
        sb.AppendLine("----------------------------------")

        ' --- DETALLE DE PRODUCTOS ---
        For Each fila As DataGridViewRow In detalleVenta.Rows
            Dim nombreProd As String = fila.Cells("Nombre").Value.ToString()
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
