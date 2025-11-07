' --- En FormRegistroCompra.vb ---
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports MdlSesion ' Asume que tu módulo de sesión se llama MdlSesion

Public Class FormRegistroCompra

    Private gestor As New GestorBD()
    Private totalCompra As Decimal = 0D

    ' DataTable temporal para el detalle de la compra (debe ser una variable de clase)
    Private dtDetalleCompra As New DataTable()

    Private Sub FormRegistroCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarInicial()
        ConfigurarDetalleCompra()
    End Sub

    Private Sub CargarInicial()
        ' Cargar ComboBox de Proveedores y Productos
        cmbProveedor.DataSource = gestor.CargarProveedores()
        cmbProveedor.DisplayMember = "RazonSocial"
        cmbProveedor.ValueMember = "ProveedorID"

        cmbProductos.DataSource = gestor.CargarProductosActivos() ' Reutilizar función de productos
        cmbProductos.DisplayMember = "Descripcion"
        cmbProductos.ValueMember = "ProductoID"

        ' Mostrar usuario logueado
        lblUsuarioRegistro.Text = MdlSesion.NombreCompleto
    End Sub

    Private Sub ConfigurarDetalleCompra()
        ' Definir la estructura del DataTable temporal si no está definido en el diseñador
        dtDetalleCompra.Columns.Add("ProductoID", GetType(Integer))
        dtDetalleCompra.Columns.Add("Descripcion", GetType(String))
        dtDetalleCompra.Columns.Add("Cantidad", GetType(Integer))
        dtDetalleCompra.Columns.Add("PrecioCosto", GetType(Decimal))
        dtDetalleCompra.Columns.Add("Subtotal", GetType(Decimal))

        DgvDetalleCompra.DataSource = dtDetalleCompra

        ' Opcional: Ocultar el ProductoID en la grilla para el usuario
        If DgvDetalleCompra.Columns.Contains("ProductoID") Then
            DgvDetalleCompra.Columns("ProductoID").Visible = False
        End If
    End Sub

    Private Sub btnAgregarDetalle_Click(sender As Object, e As EventArgs) Handles btnAgregarDetalle.Click
        ' 1. Validación
        If cmbProductos.SelectedValue Is Nothing OrElse String.IsNullOrWhiteSpace(txtCantidad.Text) OrElse String.IsNullOrWhiteSpace(txtPrecioCosto.Text) Then
            MessageBox.Show("Seleccione producto, cantidad y precio de costo.")
            Return
        End If

        Dim cantidad As Integer
        Dim precioCosto As Decimal

        If Not Integer.TryParse(txtCantidad.Text, cantidad) OrElse Not Decimal.TryParse(txtPrecioCosto.Text, precioCosto) OrElse cantidad <= 0 OrElse precioCosto < 0 Then
            MessageBox.Show("Cantidad y Precio de Costo deben ser valores numéricos válidos.", "Error de Formato")
            Return
        End If

        ' 2. Agregar a la tabla temporal
        Dim subtotal As Decimal = cantidad * precioCosto

        dtDetalleCompra.Rows.Add(
            CInt(cmbProductos.SelectedValue),
            cmbProductos.Text,
            cantidad,
            precioCosto,
            subtotal
        )

        ' 3. Actualizar totales
        totalCompra += subtotal
        lblTotal.Text = totalCompra.ToString("N2")

        ' Limpiar campos
        txtCantidad.Clear()
        txtPrecioCosto.Clear()
    End Sub

    Private Sub btnConfirmarCompra_Click(sender As Object, e As EventArgs) Handles btnConfirmarCompra.Click
        If dtDetalleCompra.Rows.Count = 0 Then
            MessageBox.Show("Debe añadir productos a la compra.", "Advertencia")
            Return
        End If

        Dim idProveedor As Integer = CInt(cmbProveedor.SelectedValue)
        Dim idUsuario As Integer = MdlSesion.VendedorID ' 🔑 ID del usuario logueado

        Try
            ' Llamada al método de transacción del GestorBD
            Dim idCompra As Integer = gestor.RegistrarCompra(
                idProveedor,
                idUsuario,
                totalCompra,
                dtDetalleCompra
            )

            MessageBox.Show($"Compra N° {idCompra} registrada y Stock actualizado con éxito.", "Éxito")

            ' Limpieza general después de la transacción
            dtDetalleCompra.Rows.Clear()
            totalCompra = 0D
            lblTotal.Text = "0.00"
            CargarInicial() ' Recargar para refrescar productos

        Catch ex As Exception
            MessageBox.Show("Error al registrar la compra: " & ex.Message, "Error Crítico de Transacción")
        End Try
    End Sub
End Class