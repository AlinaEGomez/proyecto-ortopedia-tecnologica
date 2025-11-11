Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports MdlSesion  ' Módulo con datos del usuario logueado

Public Class FormRegistroCompra

    Private gestor As New GestorBD()
    Private totalCompra As Decimal = 0D
    Private dtDetalleCompra As New DataTable()

    Private Sub Form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Volver al formulario según el perfil
        Select Case MdlSesion.PerfilUsuario
            Case "administrador"
                Dim frmAdmin As New FormAdministrador()
                frmAdmin.Show()
            Case "gerente"
                Dim frmGerente As New FormGerente()
                frmGerente.Show()
            Case "vendedor"
                Dim frmVendedor As New FormVendedor()
                frmVendedor.Show()
        End Select
    End Sub
    '============================
    ' EVENTO: Al cargar el formulario
    '============================
    Private Sub FormRegistroCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGrillaDetalle()
        CargarCombos()
        lblUsuarioRegistro.Text = MdlSesion.NombreCompleto
        lblTotal.Text = "0.00"
    End Sub

    '============================
    ' CONFIGURAR GRILLA DETALLE
    '============================
    Private Sub ConfigurarGrillaDetalle()
        ' Estructura de la tabla temporal para los detalles
        dtDetalleCompra.Columns.Clear()
        dtDetalleCompra.Columns.Add("ProductoID", GetType(Integer))
        dtDetalleCompra.Columns.Add("Descripcion", GetType(String))
        dtDetalleCompra.Columns.Add("Cantidad", GetType(Integer))
        dtDetalleCompra.Columns.Add("PrecioCosto", GetType(Decimal))
        dtDetalleCompra.Columns.Add("Subtotal", GetType(Decimal))

        DgvDetalleCompra.DataSource = dtDetalleCompra
        DgvDetalleCompra.Columns("ProductoID").Visible = False
    End Sub

    '============================
    ' CARGAR COMBOS DE PROVEEDOR Y PRODUCTO
    '============================
    Private Sub CargarCombos()
        Try
            cmbProveedor.DataSource = gestor.CargarProveedores()
            cmbProveedor.DisplayMember = "RazonSocial"
            cmbProveedor.ValueMember = "ProveedorID"
            cmbProveedor.SelectedIndex = -1

            cmbProductos.DataSource = gestor.CargarProductosActivos()
            cmbProductos.DisplayMember = "Descripcion"
            cmbProductos.ValueMember = "ProductoID"
            cmbProductos.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("Error al cargar proveedores o productos: " & ex.Message)
        End Try
    End Sub

    '============================
    ' BOTÓN AGREGAR DETALLE
    '============================
    Private Sub btnAgregarDetalle_Click(sender As Object, e As EventArgs) Handles btnAgregarDetalle.Click
        If cmbProductos.SelectedValue Is Nothing OrElse String.IsNullOrWhiteSpace(txtCantidad.Text) OrElse String.IsNullOrWhiteSpace(txtPrecioCosto.Text) Then
            MessageBox.Show("Debe seleccionar un producto y completar cantidad y precio.")
            Return
        End If

        Dim cantidad As Integer
        Dim precioCosto As Decimal

        If Not Integer.TryParse(txtCantidad.Text, cantidad) OrElse cantidad <= 0 Then
            MessageBox.Show("La cantidad debe ser un número mayor a 0.")
            Return
        End If

        If Not Decimal.TryParse(txtPrecioCosto.Text, precioCosto) OrElse precioCosto < 0 Then
            MessageBox.Show("El precio de costo no es válido.")
            Return
        End If

        ' Calcular subtotal
        Dim subtotal As Decimal = cantidad * precioCosto

        ' Agregar fila al detalle
        dtDetalleCompra.Rows.Add(
            CInt(cmbProductos.SelectedValue),
            cmbProductos.Text,
            cantidad,
            precioCosto,
            subtotal
        )

        ' Actualizar total general
        totalCompra += subtotal
        lblTotal.Text = totalCompra.ToString("N2")

        ' Limpiar campos de carga
        txtCantidad.Clear()
        txtPrecioCosto.Clear()
        cmbProductos.SelectedIndex = -1
    End Sub

    '============================
    ' BOTÓN ELIMINAR DETALLE
    '============================
    Private Sub btnEliminarDetalle_Click(sender As Object, e As EventArgs) Handles btnEliminarDetalle.Click
        If DgvDetalleCompra.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione una fila para eliminar.")
            Return
        End If

        Dim subtotal As Decimal = CDec(DgvDetalleCompra.CurrentRow.Cells("Subtotal").Value)
        totalCompra -= subtotal
        lblTotal.Text = totalCompra.ToString("N2")

        DgvDetalleCompra.Rows.Remove(DgvDetalleCompra.CurrentRow)
    End Sub

    '============================
    ' BOTÓN CONFIRMAR COMPRA
    '============================
    Private Sub btnConfirmarCompra_Click(sender As Object, e As EventArgs) Handles btnConfirmarCompra.Click
        If cmbProveedor.SelectedValue Is Nothing Then
            MessageBox.Show("Debe seleccionar un proveedor.", "Advertencia")
            Return
        End If

        If dtDetalleCompra.Rows.Count = 0 Then
            MessageBox.Show("Debe agregar al menos un producto a la compra.", "Advertencia")
            Return
        End If

        Dim idProveedor As Integer = CInt(cmbProveedor.SelectedValue)
        Dim idUsuario As Integer = MdlSesion.VendedorID

        Try
            Dim idCompra As Integer = gestor.RegistrarCompra(idProveedor, idUsuario, totalCompra, dtDetalleCompra)
            MessageBox.Show($"Compra N° {idCompra} registrada correctamente.", "Éxito")

            ' Reiniciar todo
            dtDetalleCompra.Rows.Clear()
            totalCompra = 0D
            lblTotal.Text = "0.00"
            cmbProveedor.SelectedIndex = -1
            cmbProductos.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("Error al registrar la compra: " & ex.Message)
        End Try
    End Sub
    ' ===============================
    ' CUANDO SE CAMBIA DE PRODUCTO
    ' ===============================
    Private Sub cmbProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductos.SelectedIndexChanged
        Try
            ' Si no hay producto seleccionado, salir
            If cmbProductos.SelectedValue Is Nothing OrElse TypeOf cmbProductos.SelectedValue Is DataRowView Then Exit Sub

            Dim idProducto As Integer = CInt(cmbProductos.SelectedValue)
            Dim precio As Decimal = gestor.ObtenerPrecioProducto(idProducto)

            ' Mostrar precio automáticamente
            txtPrecioCosto.Text = precio.ToString("N2")

        Catch ex As Exception
            ' Ignoramos errores cuando cambia el ComboBox durante la carga
        End Try
    End Sub

    '============================
    ' BOTÓN CERRAR FORMULARIO
    '============================
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()


    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged

    End Sub

    Private Sub BtnCerrar_Click_1(sender As Object, e As EventArgs) Handles BtnCerrar.Click

    End Sub
End Class
