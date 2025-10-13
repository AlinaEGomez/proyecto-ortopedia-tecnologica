Imports Microsoft.Data.SqlClient

Public Class FormUsuarios
    Dim conexion As New SqlConnection("Server=localhost\SQLEXPRESS01;Database=ortopedia_taller;Trusted_Connection=True;TrustServerCertificate=True;")

    Public Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarUsuarios()
    End Sub

    ' 🔹 Cargar todos los usuarios
    Public Sub CargarUsuarios()
        Try
            conexion.Open()
            Dim consulta As String = "SELECT * FROM Usuarios"
            Dim adaptador As New SqlDataAdapter(consulta, conexion)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)
            DgvUsuarios.DataSource = tabla

            AgregarBotones()
        Catch ex As Exception
            MessageBox.Show("Error al cargar usuarios: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    ' 🔹 Agregar columna de botones si no existen
    Private Sub AgregarBotones()
        ' Botón de acción (Dar de Baja / Reactivar)
        If Not DgvUsuarios.Columns.Contains("btnAccion") Then
            Dim btnAccion As New DataGridViewButtonColumn()
            btnAccion.HeaderText = "Acción"
            btnAccion.Name = "btnAccion"
            btnAccion.UseColumnTextForButtonValue = False ' Cambiamos el texto dinámicamente
            btnAccion.DefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
            DgvUsuarios.Columns.Add(btnAccion)
        End If
    End Sub

    ' 🔹 Cambiar texto y color del botón según el estado
    Private Sub DgvUsuarios_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvUsuarios.CellFormatting
        If DgvUsuarios.Columns(e.ColumnIndex).Name = "btnAccion" AndAlso e.RowIndex >= 0 Then
            Dim activo As Boolean = Convert.ToBoolean(DgvUsuarios.Rows(e.RowIndex).Cells("Activo").Value)
            If activo Then
                e.Value = "Dar de Baja"
                DgvUsuarios.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = Color.LightCoral
                DgvUsuarios.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.ForeColor = Color.White
            Else
                e.Value = "Reactivar"
                DgvUsuarios.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = Color.LightGreen
                DgvUsuarios.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.ForeColor = Color.Black
            End If
        End If
    End Sub

    ' 🔹 Detectar clic en el botón
    Private Sub DgvUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvUsuarios.CellContentClick
        If e.RowIndex >= 0 AndAlso DgvUsuarios.Columns(e.ColumnIndex).Name = "btnAccion" Then
            Dim idUsuario As Integer = Convert.ToInt32(DgvUsuarios.Rows(e.RowIndex).Cells("Id").Value)
            Dim activo As Boolean = Convert.ToBoolean(DgvUsuarios.Rows(e.RowIndex).Cells("Activo").Value)

            If activo Then
                CambiarEstadoUsuario(idUsuario, False) ' Dar de baja
            Else
                CambiarEstadoUsuario(idUsuario, True)  ' Reactivar
            End If
        End If
    End Sub

    ' 🔹 Cambiar estado del usuario (Activo = 1 o 0)
    Private Sub CambiarEstadoUsuario(idUsuario As Integer, nuevoEstado As Boolean)
        Try
            conexion.Open()
            Dim consulta As String = "UPDATE Usuarios SET Activo = @Activo WHERE Id = @Id"
            Using comando As New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@Activo", If(nuevoEstado, 1, 0))
                comando.Parameters.AddWithValue("@Id", idUsuario)
                comando.ExecuteNonQuery()
            End Using
            MessageBox.Show(If(nuevoEstado, "Usuario reactivado.", "Usuario dado de baja."))
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conexion.Close()
            CargarUsuarios() ' Refrescar DataGridView
        End Try
    End Sub

End Class
