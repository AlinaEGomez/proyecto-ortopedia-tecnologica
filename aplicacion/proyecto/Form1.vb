Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        ' Define el usuario y contraseña correctos (puedes cambiarlos)
        Dim usuarioCorrecto As String = "admin"
        Dim contrasenaCorrecta As String = "1234"

        ' Comprueba si las credenciales son correctas
        If TxtUsuario.Text = usuarioCorrecto And TxtContraseña.Text = contrasenaCorrecta Then
            MessageBox.Show("¡Bienvenido al sistema!", "Acceso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Oculta el formulario actual y muestra otro (ej. Form2)
            Me.Hide() ' O Form1.Hide() si es el formulario principal
            Form2.Show() ' Muestra el segundo formulario (puedes crear uno llamado Form2)
        Else
            ' Muestra un mensaje de error
            MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Limpia los campos
            TxtUsuario.Clear()
            TxtContraseña.Clear()
            TxtUsuario.Focus() ' Establece el foco en el campo de usuario
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        Close() ' Cierra la aplicación
    End Sub

    Private Sub LContraseña_Click(sender As Object, e As EventArgs) Handles LContraseña.Click

    End Sub

    Private Sub TxtContraseña_TextChanged(sender As Object, e As EventArgs) Handles TxtContraseña.TextChanged

    End Sub
End Class
