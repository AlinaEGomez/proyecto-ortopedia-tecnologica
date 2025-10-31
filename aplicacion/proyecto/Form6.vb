Imports Microsoft.Data.SqlClient
Imports System.Data

Public Class Form6

    ' 🔑 CORRECCIÓN 1: DECLARACIÓN DE LA CADENA DE CONEXIÓN A NIVEL DE CLASE
    ' Esto hace que sea accesible para TODOS los botones (Alta, Modificar, etc.)
    ' ⚠️ Por favor, verifica si la base de datos se llama ortopedicTecnologi_taller o solo ortopedia_taller
    Private Const CadenaConexion As String = "Server=localhost\SQLEXPRESS01;Database=ortopedicTecnologi_taller;Trusted_Connection=True;TrustServerCertificate=True;"


    '----------------------------------------------------------------------
    ' BOTÓN ALTA (INSERT)
    '----------------------------------------------------------------------
    Public Sub BtnAlta_Click(sender As Object, e As EventArgs) Handles BtnAlta.Click

        Dim sexo As String = If(rbtnMujer.Checked, "Mujer", "Hombre")

        ' 🔑 CORRECCIÓN 2: Eliminar la declaración local de 'conexion'
        Dim consulta As String = "INSERT INTO Usuarios (Nombre_Apellido, Email, Contrasena, DNI, Sexo, Perfil, Activo) 
                                 VALUES (@Nombre_Apellido, @Email, @Contrasena, @DNI, @Sexo, @Perfil, 1)"

        Try
            ' 🔑 USAR LA CADENA DECLARADA ARRIBA
            Using conexion As New SqlConnection(CadenaConexion)
                conexion.Open()
                Using comando As New SqlCommand(consulta, conexion)

                    comando.Parameters.AddWithValue("@Nombre_Apellido", TxtNombre.Text)
                    comando.Parameters.AddWithValue("@Email", TxtEmail.Text)
                    comando.Parameters.AddWithValue("@Contrasena", TxtContrasena.Text)
                    comando.Parameters.AddWithValue("@DNI", TxtDni.Text)
                    comando.Parameters.AddWithValue("@Sexo", sexo)
                    comando.Parameters.AddWithValue("@Perfil", CmbPuesto.Text)

                    comando.ExecuteNonQuery()
                    MessageBox.Show("Usuario agregado correctamente", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End Using
            End Using

            ' 🔑 CORRECCIÓN 3: Si FormUsuarios.CargarUsuarios() existe, llámalo después de mostrar
            If FormUsuarios IsNot Nothing Then
                FormUsuarios.CargarUsuarios()
            End If
            ' FormUsuarios.Show() se puede llamar aquí si el formulario ya no está visible

        Catch ex As Exception
            MessageBox.Show("Error al insertar: " & ex.Message)
        End Try
    End Sub

    '----------------------------------------------------------------------
    ' BOTÓN MODIFICAR (UPDATE)
    '----------------------------------------------------------------------
    Public Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        Dim sexo As String = If(rbtnMujer.Checked, "Mujer", "Hombre")

        Dim actualizarContrasena As Boolean = Not String.IsNullOrWhiteSpace(TxtContrasena.Text)
        Dim consulta As String = ""

        If actualizarContrasena Then
            consulta = "UPDATE Usuarios 
                         SET Nombre_Apellido = @Nombre_Apellido, Email = @Email, Contrasena = @Contrasena, Sexo = @Sexo, Perfil = @Perfil 
                         WHERE DNI = @DNI"
        Else
            consulta = "UPDATE Usuarios 
                         SET Nombre_Apellido = @Nombre_Apellido, Email = @Email, Sexo = @Sexo, Perfil = @Perfil 
                         WHERE DNI = @DNI"
        End If

        Try
            ' 🔑 USAR LA CADENA DECLARADA ARRIBA
            Using conexion As New SqlConnection(CadenaConexion)
                conexion.Open()
                Using comando As New SqlCommand(consulta, conexion)

                    comando.Parameters.AddWithValue("@Nombre_Apellido", TxtNombre.Text)
                    comando.Parameters.AddWithValue("@Email", TxtEmail.Text)
                    comando.Parameters.AddWithValue("@Sexo", sexo)
                    comando.Parameters.AddWithValue("@Perfil", CmbPuesto.Text)
                    comando.Parameters.AddWithValue("@DNI", TxtDni.Text)

                    If actualizarContrasena Then
                        comando.Parameters.AddWithValue("@Contrasena", TxtContrasena.Text)
                    End If

                    Dim filas As Integer = comando.ExecuteNonQuery()

                    If filas > 0 Then
                        MessageBox.Show("Usuario modificado correctamente", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        FormUsuarios.CargarUsuarios()
                    Else
                        MessageBox.Show("No se encontró un Usuario con ese DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al modificar: " & ex.Message)
        End Try
    End Sub
    Private UsuarioID_Actual As Integer = 0

    '----------------------------------------------------------------------
    ' FUNCIÓN DE BÚSQUEDA Y CARGA (LECTURA)
    ' Trae los datos del usuario por DNI y los carga en los campos de la vista
    '----------------------------------------------------------------------
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        If String.IsNullOrWhiteSpace(TxtDni.Text) Then
            MessageBox.Show("Ingrese el DNI del usuario a buscar.", "Advertencia")
            Return
        End If

        Try
            ' 1. Consulta que busca todos los campos editables por DNI
            Dim consulta As String = "SELECT Id, Nombre_Apellido, Email, DNI, Sexo, Perfil, Activo FROM Usuarios WHERE DNI = @dni"

            Using conexion As New SqlConnection(CadenaConexion)
                conexion.Open()

                Using cmd As New SqlCommand(consulta, conexion)
                    cmd.Parameters.AddWithValue("@dni", TxtDni.Text)

                    Using reader As SqlDataReader = cmd.ExecuteReader()

                        If reader.Read() Then
                            ' 2. Almacena el ID (PK) para usarlo en el botón Modificar/Guardar
                            UsuarioID_Actual = reader.GetInt32(0)

                            ' 3. LLENAR LOS CAMPOS con los datos de la BD
                            TxtNombre.Text = reader.GetString(1)    ' Nombre_Apellido
                            TxtEmail.Text = reader.GetString(2)
                            ' TxtContrasena.Text se deja vacío por seguridad

                            ' Manejo del RadioButton (Sexo)
                            If reader.GetString(4) = "Mujer" Then
                                rbtnMujer.Checked = True
                                rbtnHombre.Checked = False
                            Else
                                rbtnMujer.Checked = False
                                rbtnHombre.Checked = True
                            End If

                            CmbPuesto.Text = reader.GetString(5)  ' Puesto (Perfil)

                            ' ⚠️ Si tienes un CheckBox de Activo, se carga aquí:
                            ' chkActivo.Checked = reader.GetBoolean(6) 

                            MessageBox.Show($"Usuario {TxtNombre.Text} cargado. Modifique los campos y presione Modificar.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("No se encontró ningún usuario con ese DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            UsuarioID_Actual = 0 ' Resetear ID si no se encuentra
                            LimpiarCampos() ' Limpia los campos si el usuario no existe
                        End If
                    End Using
                End Using
            End Using ' Cierra la conexión automáticamente

        Catch ex As Exception
            MessageBox.Show("Error al buscar usuario: " & ex.Message, "Error de SQL")
        End Try
    End Sub

    ' ⚠️ NECESITAS ESTA FUNCIÓN AUXILIAR PARA LIMPIAR LOS CAMPOS
    Private Sub LimpiarCampos()
        ' Asegúrate de que los nombres de los controles coincidan con tu formulario
        TxtDni.Clear()
        TxtNombre.Clear()
        TxtEmail.Clear()
        TxtContrasena.Clear()
        If CmbPuesto.Items.Count > 0 Then CmbPuesto.SelectedIndex = -1
        rbtnHombre.Checked = True
        UsuarioID_Actual = 0
    End Sub

    Private Sub rbtnHombre_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnHombre.CheckedChanged

    End Sub
End Class