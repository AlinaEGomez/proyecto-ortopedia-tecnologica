Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Text
Imports Microsoft.Data.SqlClient

Public Class FormRegistarVentas

    ' 🔗 Conexión SQL segura
    Private conexion As New SqlConnection("Server=localhost\SQLEXPRESS;Database=ortopedicTecnologi_taller;Trusted_Connection=True;TrustServerCertificate=True;")

    Private totalVenta As Decimal = 0D
    Private cargando As Boolean = True

    ' ------------------- SEGURIDAD Y SESIÓN --------------------
    Private Sub AplicarRestriccionRol()
        If MdlSesion.PerfilUsuario = "Administrador" Then
            btnConfirmarVenta.Enabled = False
        End If
    End Sub

    Private Sub FormClientes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Select Case MdlSesion.PerfilUsuario.ToLower()
            Case "administrador"
                Dim frm As New FormAdministrador()
                frm.Show()
            Case "gerente"
                Dim frm As New FormGerente()
                frm.Show()
            Case "vendedor"
                Dim frm As New FormVendedor()
                frm.Show()
        End Select
    End Sub

    ' ----------------------------------------------------------
    Private Sub FormRegistrarVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargando = True
        CargarProductos()
        ConfigurarDataGridView()
        CargarClientes()
        cargando = False
    End Sub

    ' ------------------- CARGAR PRODUCTOS --------------------
    Private Sub CargarProductos()
        Dim dt As New DataTable()

        Try
            Using cn As New SqlConnection(conexion.ConnectionString)
                cn.Open()

                Dim consulta As String = "
                    SELECT ProductoID, Codigo, Descripcion, Precio, Stock
                    FROM Productos
                    WHERE EstadoLogico = 1 AND Stock > 0
                "

                Using cmd As New SqlCommand(consulta, cn)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using
                End Using
            End Using

            cmbProductos.DataSource = dt
            cmbProductos.DisplayMember = "Descripcion"
            cmbProductos.ValueMember = "ProductoID"

        Catch ex As Exception
            MessageBox.Show("⚠️ Error al cargar los productos: " & ex.Message, "Error al cargar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ------------------- CONFIGURAR DGV --------------------
    Private Sub ConfigurarDataGridView()
        With DgvDetalle
            .Columns.Clear()
            .Columns.Add("ProductoID", "ID Producto")
            .Columns.Add("Descripcion", "Producto")
            .Columns.Add("Cantidad", "Cantidad")
            .Columns.Add("PrecioUnitario", "Precio Unitario")
            .Columns.Add("Subtotal", "Subtotal")
            .ReadOnly = True
            .AllowUserToAddRows = False
        End With
    End Sub

    ' ------------------- MOSTRAR PRECIO --------------------
    Private Sub cmbProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductos.SelectedIndexChanged
        If cargando OrElse cmbProductos.SelectedIndex = -1 Then Exit Sub

        Try
            Using cn As New SqlConnection(conexion.ConnectionString)
                cn.Open()
                Dim cmd As New SqlCommand("SELECT Precio FROM Productos WHERE ProductoID = @ProductoID", cn)
                cmd.Parameters.AddWithValue("@ProductoID", CInt(cmbProductos.SelectedValue))

                Dim precio = cmd.ExecuteScalar()
                txtPrecio.Text = If(precio IsNot Nothing, Convert.ToDecimal(precio).ToString("0.00"), "0.00")
            End Using

        Catch ex As Exception
            MessageBox.Show("⚠️ Error al obtener el precio: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ------------------- AGREGAR PRODUCTO --------------------
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If cmbProductos.SelectedValue Is Nothing OrElse Not IsNumeric(txtCantidad.Text) OrElse CInt(txtCantidad.Text) <= 0 Then
            MessageBox.Show("Seleccione un producto válido y una cantidad mayor que 0.")
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

    ' ------------------- CARGAR CLIENTES EXISTENTES --------------------
    Private Sub CargarClientes()
        Try
            Using cn As New SqlConnection(conexion.ConnectionString)
                cn.Open()
                Dim cmd As New SqlCommand("SELECT ClienteID, RazonSocial, CUIT FROM Clientes WHERE EstadoLogico = 1", cn)
                Dim dt As New DataTable()
                dt.Load(cmd.ExecuteReader())

                CmbRazonSocial.DataSource = dt.Copy()
                CmbRazonSocial.DisplayMember = "RazonSocial"
                CmbRazonSocial.ValueMember = "ClienteID"
                CmbRazonSocial.SelectedIndex = -1

                Cmbcuil.DataSource = dt.Copy()
                Cmbcuil.DisplayMember = "CUIT"
                Cmbcuil.ValueMember = "ClienteID"
                Cmbcuil.SelectedIndex = -1
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cargar clientes: " & ex.Message)
        End Try
    End Sub

    ' ------------------- SINCRONIZAR COMBOS --------------------
    Private Sub CmbRazonSocial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbRazonSocial.SelectedIndexChanged
        If cargando Then Return
        If CmbRazonSocial.SelectedIndex <> -1 AndAlso TypeOf CmbRazonSocial.SelectedValue Is Integer Then
            Cmbcuil.SelectedValue = CmbRazonSocial.SelectedValue
        Else
            Cmbcuil.SelectedIndex = -1
        End If
    End Sub

    Private Sub CmbCuil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmbcuil.SelectedIndexChanged
        If cargando Then Return
        If Cmbcuil.SelectedIndex <> -1 AndAlso TypeOf Cmbcuil.SelectedValue Is Integer Then
            CmbRazonSocial.SelectedValue = Cmbcuil.SelectedValue
        Else
            CmbRazonSocial.SelectedIndex = -1
        End If
    End Sub

    ' ------------------- QUITAR PRODUCTO --------------------
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If DgvDetalle.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione una fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim subtotal As Decimal = CDec(DgvDetalle.CurrentRow.Cells("Subtotal").Value)
        totalVenta -= subtotal
        lblTotal.Text = totalVenta.ToString("0.00")
        DgvDetalle.Rows.Remove(DgvDetalle.CurrentRow)
    End Sub

    ' ------------------- CONFIRMAR VENTA --------------------
    Private Sub btnConfirmarVenta_Click(sender As Object, e As EventArgs) Handles btnConfirmarVenta.Click
        If Not ValidarVenta() Then Return
        If MdlSesion.PerfilUsuario <> "vendedor" AndAlso MdlSesion.PerfilUsuario <> "gerente" Then
            MessageBox.Show("Solo Vendedores o Gerentes pueden confirmar ventas.")
            Return
        End If

        Dim idVentaRegistrada As Integer = 0
        Dim idCliente As Object = DBNull.Value

        Try
            Using cn As New SqlConnection(conexion.ConnectionString)
                cn.Open()
                Dim trans = cn.BeginTransaction()

                If Not ChkOcasional.Checked Then
                    If CmbRazonSocial.SelectedIndex = -1 Then
                        MessageBox.Show("Seleccione un cliente o marque 'Cliente Ocasional'.")
                        Return
                    End If
                    idCliente = CmbRazonSocial.SelectedValue
                End If

                Using cmdVenta As New SqlCommand("
                    INSERT INTO Ventas (Fecha, IdVendedor, IdCliente, Total)
                    OUTPUT INSERTED.VentaID
                    VALUES (GETDATE(), @idVendedor, @idCliente, @total)", cn, trans)
                    cmdVenta.Parameters.AddWithValue("@idVendedor", MdlSesion.VendedorID)
                    cmdVenta.Parameters.AddWithValue("@idCliente", idCliente)
                    cmdVenta.Parameters.AddWithValue("@total", totalVenta)
                    idVentaRegistrada = CInt(cmdVenta.ExecuteScalar())
                End Using

                For Each fila As DataGridViewRow In DgvDetalle.Rows
                    Using cmdDet As New SqlCommand("
                        INSERT INTO DetalleVenta (VentaID, ProductoID, Cantidad, PrecioUnitario)
                        VALUES (@v, @p, @c, @pu)", cn, trans)
                        cmdDet.Parameters.AddWithValue("@v", idVentaRegistrada)
                        cmdDet.Parameters.AddWithValue("@p", CInt(fila.Cells("ProductoID").Value))
                        cmdDet.Parameters.AddWithValue("@c", CInt(fila.Cells("Cantidad").Value))
                        cmdDet.Parameters.AddWithValue("@pu", CDec(fila.Cells("PrecioUnitario").Value))
                        cmdDet.ExecuteNonQuery()
                    End Using

                    Using cmdStock As New SqlCommand("UPDATE Productos SET Stock = Stock - @c WHERE ProductoID = @p", cn, trans)
                        cmdStock.Parameters.AddWithValue("@c", CInt(fila.Cells("Cantidad").Value))
                        cmdStock.Parameters.AddWithValue("@p", CInt(fila.Cells("ProductoID").Value))
                        cmdStock.ExecuteNonQuery()
                    End Using
                Next

                trans.Commit()
            End Using

            Dim cuilMostrar As String = If(ChkOcasional.Checked, "Ocasional", Cmbcuil.Text)
            GenerarComprobante(idVentaRegistrada, DgvDetalle, cuilMostrar)
            MessageBox.Show("✅ Venta registrada correctamente.", "Éxito")

            ' Limpiar formulario
            DgvDetalle.Rows.Clear()
            lblTotal.Text = "0.00"
            totalVenta = 0D
            CmbRazonSocial.SelectedIndex = -1
            Cmbcuil.SelectedIndex = -1
            ChkOcasional.Checked = False
            CargarProductos()

        Catch ex As Exception
            MessageBox.Show("Error al guardar venta: " & ex.Message)
        End Try
    End Sub

    ' ------------------- VALIDAR --------------------
    Private Function ValidarVenta() As Boolean
        If MdlSesion.VendedorID <= 0 Then
            MessageBox.Show("Error de sesión. No se ha detectado un vendedor válido.")
            Return False
        End If
        If DgvDetalle.Rows.Count = 0 Then
            MessageBox.Show("Debe agregar al menos un producto.")
            Return False
        End If
        If totalVenta <= 0 Then
            MessageBox.Show("El total de la venta no puede ser 0.")
            Return False
        End If
        Return True
    End Function

    ' ------------------- GENERAR COMPROBANTE --------------------
    Private Sub GenerarComprobante(ByVal idVenta As Integer, ByVal detalle As DataGridView, ByVal cuil As String)
        Dim sb As New StringBuilder()
        sb.AppendLine("     ORTOPEDIA TECNOLÓGICA")
        sb.AppendLine("       COMPROBANTE DE VENTA")
        sb.AppendLine("==================================")
        sb.AppendLine($"TICKET N°: {idVenta}")
        sb.AppendLine($"FECHA: {DateTime.Now:dd/MM/yyyy HH:mm}")
        sb.AppendLine($"CLIENTE: {cuil}")
        sb.AppendLine("----------------------------------")
        sb.AppendLine("CANT | PRODUCTO             | IMPORTE")
        sb.AppendLine("----------------------------------")

        For Each fila As DataGridViewRow In detalle.Rows
            Dim nombre As String = fila.Cells("Descripcion").Value.ToString()
            Dim cant As Integer = CInt(fila.Cells("Cantidad").Value)
            Dim subTot As Decimal = CDec(fila.Cells("Subtotal").Value)
            sb.AppendLine($"{cant,-4}| {nombre,-20}| {subTot,7:N2}")
        Next

        sb.AppendLine("----------------------------------")
        sb.AppendLine($"TOTAL A PAGAR:{totalVenta,21:N2}")
        sb.AppendLine("==================================")
        sb.AppendLine(vbCrLf & "GRACIAS POR SU COMPRA")

        Try
            Dim pd As New PrintDocument()
            Dim printFont As New Font("Courier New", 10)
            AddHandler pd.PrintPage, Sub(s, ev)
                                         ev.Graphics.DrawString(sb.ToString(), printFont, Brushes.Black, 0, 0)
                                         ev.HasMorePages = False
                                     End Sub
            pd.Print()
        Catch ex As Exception
            MessageBox.Show("Error al imprimir comprobante: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
