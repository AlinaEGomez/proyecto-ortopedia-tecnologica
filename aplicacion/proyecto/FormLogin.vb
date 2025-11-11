Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Imports System.Drawing ' Necesario para Color.Dark...
'Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;

Public Class FormLogin
    Public Shared perfilUsuario As String


    ' Diccionario para simular una base de datos de usuarios (Email, Contraseña, Perfil)

    ' ❌ ELIMINAR ESTA LÍNEA: La variable se mueve al módulo MdlSesion.
    ' Public Shared perfilUsuario As String 

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
            Dim correoIngresado As String = TxtEmail.Text.Trim()
            Dim contraseñaIngresada As String = TxtContraseña.Text.Trim()

            If correoIngresado = "" Or contraseñaIngresada = "" Then
                MessageBox.Show("Debe ingresar el correo y la contraseña.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

        Dim conexion As New SqlConnection("Server=localhost\SQLEXPRESS;Database=ortopedicTecnologi_taller;Trusted_Connection=True;Encrypt=False;")

        ' 🔑 CORRECCIÓN: Seleccionar también el ID para la tabla Ventas
        Dim consulta As String = "SELECT Id, Contrasena, Perfil, Nombre_Apellido, Activo FROM Usuarios WHERE Email = @Email"

            Dim comando As New SqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@Email", correoIngresado)

            Try
                conexion.Open()
                Dim lector As SqlDataReader = comando.ExecuteReader()

                If lector.Read() Then

                    ' 🔑 CAPTURAR DATOS ESENCIALES
                    Dim idUsuario As Integer = CInt(lector("Id"))
                    Dim nombreCompleto As String = lector("Nombre_Apellido").ToString()
                    Dim contraseñaCorrecta As String = lector("Contrasena").ToString()
                    Dim perfil As String = lector("perfil").ToString().ToLower()
                    Dim activo As Boolean = Convert.ToBoolean(lector("Activo"))

                    If Not activo Then
                        MessageBox.Show("El usuario está inactivo.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                    If contraseñaIngresada = contraseñaCorrecta Then

                        If perfil = "administrador" Or perfil = "vendedor" Or perfil = "gerente" Then

                            ' 🔑 ASIGNAR DATOS AL MÓDULO GLOBAL (SOLUCIÓN DEL PROBLEMA)
                            MdlSesion.VendedorID = idUsuario       ' El ID es vital para la tabla Ventas
                            MdlSesion.NombreCompleto = nombreCompleto
                            MdlSesion.PerfilUsuario = perfil

                            MessageBox.Show($"¡Bienvenido, {perfil}!", "Acceso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Hide()

                            ' El código de Select Case para navegación es correcto.
                            Select Case perfil
                                Case "administrador"
                                    Dim formAdmin As New FormAdministrador()
                                    formAdmin.LblBienvenido.Text = $"¡Bienvenido {nombreCompleto} ({perfil})!" ' Usar nombre real
                                    formAdmin.LblBienvenido.ForeColor = Color.DarkBlue
                                    formAdmin.Show()

                                Case "vendedor"
                                    Dim formVendedor As New FormVendedor()
                                    formVendedor.LblBienvenido.Text = $"¡Bienvenido {nombreCompleto} ({perfil})!"
                                    formVendedor.LblBienvenido.ForeColor = Color.DarkGreen
                                    formVendedor.Show()

                                Case "gerente"
                                Dim formGerente As New FormGerente()
                                formGerente.LblBienvenido.Text = $"¡Bienvenido {nombreCompleto} ({perfil})!"
                                    formGerente.LblBienvenido.ForeColor = Color.DarkRed
                                    formGerente.Show()
                            End Select

                        Else
                            MessageBox.Show("Este usuario no tiene permisos para acceder al sistema.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    Else
                        MessageBox.Show("Contraseña incorrecta.", "Error de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        TxtContraseña.Clear()
                    End If
                Else
                    MessageBox.Show("Correo no encontrado.", "Error de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TxtEmail.Clear()
                    TxtContraseña.Clear()
                End If

                lector.Close()
            Catch ex As Exception
                MessageBox.Show("Error al conectar con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conexion.Close()
            End Try
        End Sub

    ' ... (Resto del código) ...







    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        Close() ' Cierra la aplicación
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TxtEmail_TextChanged(sender As Object, e As EventArgs) Handles TxtEmail.TextChanged

    End Sub
End Class

