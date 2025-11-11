' --- En FormProveedores.vb ---
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class FormProveedores

    Private gestor As New GestorBD()
    Private ProveedorID_Actual As Integer = 0 ' 0 = Alta

    Private Sub FormProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarProveedores()
    End Sub
    Private Sub FormClientes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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
    ' 🔑 FUNCIÓN PRINCIPAL DE CARGA
    Public Sub CargarProveedores()
        Try
            DgvProveedores.DataSource = gestor.CargarProveedores()
            DgvProveedores.Columns("ProveedorID").Visible = False
            DgvProveedores.Columns("EstadoLogico").Visible = False
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show("Error al cargar la lista de proveedores: " & ex.Message, "Error BD")
        End Try
    End Sub

    ' ----------------------------------------------------
    ' LÓGICA DE INTERFAZ Y VALIDACIÓN
    ' ----------------------------------------------------
    Private Sub LimpiarCampos()
        txtRazonSocial.Clear()
        txtCuit.Clear()
        txtContactoNombre.Clear()
        txtTelefono.Clear()
        txtEmail.Clear()
        ProveedorID_Actual = 0
        btnGuardar.Text = "Guardar Nuevo Proveedor"
        txtRazonSocial.Focus()
    End Sub

    Private Function ValidarCampos() As Boolean
        If String.IsNullOrWhiteSpace(txtRazonSocial.Text) OrElse String.IsNullOrWhiteSpace(txtCuit.Text) Then
            MessageBox.Show("Razón Social y CUIT son obligatorios.", "Validación")
            Return False
        End If
        ' (Añadir aquí validación de CUIT.Length >= 11, etc.)
        Return True
    End Function

    ' ----------------------------------------------------
    ' MANEJADORES DE EVENTOS
    ' ----------------------------------------------------
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Not ValidarCampos() Then Return

        Dim id As Integer = ProveedorID_Actual
        Dim razonSocial As String = txtRazonSocial.Text
        Dim cuit As String = txtCuit.Text
        Dim contacto As String = txtContactoNombre.Text
        Dim telefono As String = txtTelefono.Text
        Dim email As String = txtEmail.Text

        Try
            If id = 0 Then
                gestor.InsertarProveedor(razonSocial, cuit, contacto, telefono, email)
                MessageBox.Show("Proveedor registrado con éxito.", "Éxito")
            Else
                gestor.ModificarProveedor(id, razonSocial, cuit, contacto, telefono, email)
                MessageBox.Show("Proveedor modificado con éxito.", "Éxito")
            End If

            CargarProveedores()

        Catch ex As Exception
            MessageBox.Show("Error al guardar: Verifique que el CUIT no esté duplicado. Detalle: " & ex.Message, "Error de BD")
        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If ProveedorID_Actual = 0 Then Return

        If MessageBox.Show("¿Está seguro de eliminar (Baja Lógica) el proveedor seleccionado?", "Confirmar Eliminación", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                gestor.GestionarEstadoLogicoProveedor(ProveedorID_Actual, 0) ' Baja Lógica (0)
                MessageBox.Show("Proveedor eliminado (Baja Lógica) con éxito.", "Eliminado")
                CargarProveedores()
            Catch ex As Exception
                MessageBox.Show("Error al eliminar: " & ex.Message, "Error BD")
            End Try
        End If
    End Sub

    Private Sub DgvProveedores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvProveedores.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = DgvProveedores.Rows(e.RowIndex)

            ProveedorID_Actual = CInt(fila.Cells("ProveedorID").Value)
            txtRazonSocial.Text = fila.Cells("RazonSocial").Value.ToString()
            txtCuit.Text = fila.Cells("CUIT").Value.ToString()
            txtContactoNombre.Text = If(fila.Cells("ContactoNombre").Value Is DBNull.Value, "", fila.Cells("ContactoNombre").Value.ToString())
            txtTelefono.Text = If(fila.Cells("Telefono").Value Is DBNull.Value, "", fila.Cells("Telefono").Value.ToString())
            txtEmail.Text = If(fila.Cells("Email").Value Is DBNull.Value, "", fila.Cells("Email").Value.ToString())

            btnGuardar.Text = "Modificar Proveedor"
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    ' --- En FormProveedores.vb ---

    Private Sub btnProveedoresInactivos_Click(sender As Object, e As EventArgs) Handles btnProveedoresInactivos.Click

        ' 1. Busca si el formulario de inactivos ya está abierto
        Dim frm As FormProveedoresInactivos = Application.OpenForms.OfType(Of FormProveedoresInactivos)().FirstOrDefault()

        If frm Is Nothing Then
            ' Si no está abierto, crea una nueva instancia
            frm = New FormProveedoresInactivos()
        End If

        ' 2. Muestra el formulario y lo trae al frente
        frm.Show()
        frm.BringToFront()

        ' 3. Llama a la función de carga del formulario secundario para refrescar los datos
        ' (Esta función debe existir en FormProveedoresInactivos.vb)
        frm.CargarListaInactivos()

    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()

    End Sub
End Class