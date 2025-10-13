Imports Microsoft.Data.SqlClient

Public Class Form6

    Private Sub BtnAlta_Click(sender As Object, e As EventArgs) Handles BtnAlta.Click
        Dim conexion As New SqlConnection("Server=localhost\SQLEXPRESS01;Database=ortopedia_taller;Trusted_Connection=True;TrustServerCertificate=True;")
        Dim sexo As String = If(rbtnMujer.Checked, "Mujer", "Hombre")

        Dim consulta As String = "INSERT INTO Usuarios (Nombre, Apellido, Email, Contrasena, DNI, Sexo, Perfil, Activo) 
                              VALUES (@Nombre, @Apellido, @Email, @Contrasena, @DNI, @Sexo, @Perfil, 1)"

        Try
            conexion.Open()
            Dim comando As New SqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@Nombre", TxtNombre.Text)
            comando.Parameters.AddWithValue("@Apellido", TxtApellido.Text)
            comando.Parameters.AddWithValue("@Email", TxtEmail.Text)
            comando.Parameters.AddWithValue("@Contrasena", TxtContrasena.Text)
            comando.Parameters.AddWithValue("@DNI", TxtDni.Text)
            comando.Parameters.AddWithValue("@Sexo", sexo)
            comando.Parameters.AddWithValue("@Perfil", CmbPuesto.Text)

            comando.ExecuteNonQuery()
            MessageBox.Show("Usuario agregado correctamente", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information)

            FormUsuarios.Show()  ' Mostrar Form7 solo si todo salió bien

        Catch ex As Exception
            MessageBox.Show("Error al insertar: " & ex.Message)
        Finally
            conexion.Close()
        End Try


    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        Dim conexion As New SqlConnection("Server=localhost\SQLEXPRESS01;Database=ortopedia_taller;Trusted_Connection=True;TrustServerCertificate=True;")
        Dim sexo As String = If(rbtnMujer.Checked, "Mujer", "Hombre")

        Dim consulta As String = "UPDATE Usuarios
                                  SET Nombre=@Nombre, Apellido=@Apellido, Email=@Email, Contrasena=@Contrasena, Sexo=@Sexo, Perfil=@Perfil
                                  WHERE DNI=@DNI"

        Try
            conexion.Open()
            Dim comando As New SqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@Nombre", TxtNombre.Text)
            comando.Parameters.AddWithValue("@Apellido", TxtApellido.Text)
            comando.Parameters.AddWithValue("@Email", TxtEmail.Text)
            comando.Parameters.AddWithValue("@Contrasena", TxtContrasena.Text)
            comando.Parameters.AddWithValue("@Sexo", sexo)
            comando.Parameters.AddWithValue("@Perfil", CmbPuesto.Text)
            comando.Parameters.AddWithValue("@DNI", TxtDni.Text)

            Dim filas As Integer = comando.ExecuteNonQuery()

            If filas > 0 Then
                MessageBox.Show("Usuario modificado correctamente", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FormUsuarios.CargarUsuarios() ' 🔹 Refrescar el DataGridView
            Else
                MessageBox.Show("No se encontró un Usuario con ese DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al modificar: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

End Class