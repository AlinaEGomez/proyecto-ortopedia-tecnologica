
Imports System.Data.SqlClient
    Imports System.Data
    Imports System.Windows.Forms

    Public Class FormClientes

        ' 🔑 Variables de Clase y Gestor
        Private gestor As New GestorBD()
        Private ClienteID_Actual As Integer = 0

        Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            CargarClientes()
        End Sub

        ' 🔑 FUNCIONES PRINCIPALES
        Public Sub CargarClientes()
            Try
                DgvClientes.DataSource = gestor.CargarClientes()
                DgvClientes.Columns("ClienteID").Visible = False
                DgvClientes.Columns("EstadoLogico").Visible = False
                LimpiarCampos()
            Catch ex As Exception
                MessageBox.Show("Error al cargar la lista de clientes: " & ex.Message, "Error BD")
            End Try
        End Sub

        Private Function ValidarCampos() As Boolean
            If String.IsNullOrWhiteSpace(txtRazonSocial.Text) OrElse String.IsNullOrWhiteSpace(txtCuit.Text) Then
                MessageBox.Show("Razón Social y CUIT son obligatorios.", "Validación")
                Return False
            End If
            If txtCuit.Text.Length < 11 Then
                MessageBox.Show("El CUIT parece ser inválido o incompleto (mínimo 11 caracteres).", "Validación")
                Return False
            End If
            Return True
        End Function

        Private Sub LimpiarCampos()
            txtRazonSocial.Clear()
            txtCuit.Clear()
            txtTelefono.Clear()
            txtEmail.Clear()
            ClienteID_Actual = 0
            btnGuardar.Text = "Guardar Nuevo Cliente"
            txtRazonSocial.Focus()
        End Sub

        ' ----------------------------------------------------
        ' MANEJADORES DE EVENTOS
        ' ----------------------------------------------------
        Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
            If Not ValidarCampos() Then Return

            Dim id As Integer = ClienteID_Actual
            Dim razonSocial As String = txtRazonSocial.Text
            Dim cuit As String = txtCuit.Text
            Dim telefono As String = txtTelefono.Text
            Dim email As String = txtEmail.Text

            Try
                If id = 0 Then
                    gestor.InsertarCliente(razonSocial, cuit, telefono, email)
                    MessageBox.Show("Cliente registrado con éxito.", "Éxito")
                Else
                    gestor.ModificarCliente(id, razonSocial, cuit, telefono, email)
                    MessageBox.Show("Cliente modificado con éxito.", "Éxito")
                End If

                CargarClientes()

            Catch ex As Exception
                MessageBox.Show("Error al guardar: Verifique que el CUIT no esté duplicado. Detalle: " & ex.Message, "Error de BD")
            End Try
        End Sub

        Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
            If ClienteID_Actual = 0 Then Return

            If MessageBox.Show("¿Está seguro de eliminar (Baja Lógica) el cliente seleccionado?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Try
                    gestor.GestionarEstadoLogicoCliente(ClienteID_Actual, 0) ' Baja Lógica (0)
                    MessageBox.Show("Cliente eliminado (Baja Lógica) con éxito.", "Eliminado")
                    CargarClientes()
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar: " & ex.Message, "Error BD")
                End Try
            End If
        End Sub

        Private Sub DgvClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvClientes.CellClick
            If e.RowIndex >= 0 Then
                Dim fila As DataGridViewRow = DgvClientes.Rows(e.RowIndex)

                ClienteID_Actual = CInt(fila.Cells("ClienteID").Value)
                txtRazonSocial.Text = fila.Cells("RazonSocial").Value.ToString()
                txtCuit.Text = fila.Cells("CUIT").Value.ToString()

                txtTelefono.Text = If(fila.Cells("Telefono").Value Is DBNull.Value, "", fila.Cells("Telefono").Value.ToString())
                txtEmail.Text = If(fila.Cells("Email").Value Is DBNull.Value, "", fila.Cells("Email").Value.ToString())

                btnGuardar.Text = "Modificar Cliente"
            End If
        End Sub

        Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
            LimpiarCampos()
        End Sub

    End Class



