
'Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;
Public Class Form1

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        ' Diccionario para simular una base de datos de usuarios (Email, Contraseña, Perfil)
        Dim usuarios As New Dictionary(Of String, Tuple(Of String, String))
        usuarios.Add("admin@gmail.com", New Tuple(Of String, String)("1234", "administrador"))
        usuarios.Add("vendedor@gmail.com", New Tuple(Of String, String)("5678", "vendedor"))
        usuarios.Add("gerente@gmail.com", New Tuple(Of String, String)("9012", "gerente"))

        ' Obtiene el email y contraseña del formulario
        Dim emailIngresado As String = TxtEmail.Text
        Dim contrasenaIngresada As String = TxtContraseña.Text

        ' Comprueba si el email existe en el "diccionario"
        If usuarios.ContainsKey(emailIngresado) Then
            Dim datosUsuario = usuarios(emailIngresado)
            Dim contrasenaCorrecta As String = datosUsuario.Item1
            Dim perfil As String = datosUsuario.Item2

            ' Comprueba si la contraseña es correcta
            If contrasenaIngresada = contrasenaCorrecta Then
                MessageBox.Show($"¡Bienvenido {perfil}!", "Acceso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide() ' Oculta el formulario de login

                ' Redirige según el perfil
                Select Case perfil
                    Case "administrador"
                        Dim formAdmin As New Form2()
                        Form2.Show()
                    Case "vendedor"
                        Dim formVendedor As New Form3()
                        Form3.Show()
                    Case "gerente"
                        Dim formGerente As New Form4()
                        Form4.Show()
                End Select
            Else
                ' Contraseña incorrecta
                MessageBox.Show("Email o contraseña incorrectos.", "Error de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtContraseña.Clear()
                TxtContraseña.Focus()
            End If
        Else
            ' Email no encontrado
            MessageBox.Show("Email o contraseña incorrectos.", "Error de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtEmail.Clear()
            TxtContraseña.Clear()
            TxtEmail.Focus()
        End If
    End Sub
    ' Función para validar el formato de un email (simple)
    Private Function EsEmailValido(email As String) As Boolean
        Try
            Dim addr As New System.Net.Mail.MailAddress(email)
            Return True
        Catch
            Return False
        End Try
    End Function
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        Close() ' Cierra la aplicación
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TxtEmail_TextChanged(sender As Object, e As EventArgs) Handles TxtEmail.TextChanged

    End Sub
End Class
