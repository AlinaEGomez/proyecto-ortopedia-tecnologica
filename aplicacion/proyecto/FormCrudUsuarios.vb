Imports Microsoft.Data.SqlClient

Public Class FormCrudUsuarios

    ' 🔹 Cadena de conexión
    Private ReadOnly CadenaConexion As String = "Server=localhost\SQLEXPRESS;Database=ortopedicTecnologi_taller;Trusted_Connection=True;Encrypt=False;"

    ' =====================================================
    ' CARGAR USUARIOS AL INICIAR EL FORMULARIO
    ' =====================================================
    Private Sub FormCrudUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarUsuarios()
    End Sub

    Private Sub CargarUsuarios()
        Try
            Using conexion As New SqlConnection(CadenaConexion)
                conexion.Open()

                Dim consulta As String = "
                    SELECT 
                        Nombre_Apellido, 
                        Email, 
                        DNI, 
                        Sexo, 
                        Perfil,
                        CASE WHEN Activo = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado
                    FROM Usuarios"

                Dim adaptador As New SqlDataAdapter(consulta, conexion)
                Dim tabla As New DataTable()
                adaptador.Fill(tabla)
                DgvUsuarios.DataSource = tabla
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cargar usuarios: " & ex.Message)
        End Try
    End Sub

    ' =====================================================
    ' LIMPIAR CAMPOS
    ' =====================================================
    Private Sub LimpiarCampos()
        TxtNombre.Clear()
        TxtEmail.Clear()
        TxtContrasena.Clear()
        TxtDni.Clear()
        CmbPuesto.SelectedIndex = -1
        rbtnHombre.Checked = False
        rbtnMujer.Checked = False
        RbtActivo.Checked = False
        RbtInactivo.Checked = False
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        LimpiarCampos()
    End Sub

    ' =====================================================
    ' BOTÓN MODIFICAR
    ' =====================================================
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If TxtDni.Text = "" Then
            MessageBox.Show("Ingrese el DNI del usuario a modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using conexion As New SqlConnection(CadenaConexion)
                conexion.Open()

                Dim sexo As String = If(rbtnMujer.Checked, "Mujer", "Hombre")
                Dim activo As Boolean = RbtActivo.Checked ' si está activo o no

                Dim consulta As String = "
                    UPDATE Usuarios 
                    SET 
                        Nombre_Apellido = @Nombre, 
                        Email = @Email, 
                        Contrasena = @Contrasena, 
                        Sexo = @Sexo, 
                        Perfil = @Perfil,
                        Activo = @Activo
                    WHERE DNI = @DNI"

                Using cmd As New SqlCommand(consulta, conexion)
                    cmd.Parameters.AddWithValue("@Nombre", TxtNombre.Text)
                    cmd.Parameters.AddWithValue("@Email", TxtEmail.Text)
                    cmd.Parameters.AddWithValue("@Contrasena", TxtContrasena.Text)
                    cmd.Parameters.AddWithValue("@Sexo", sexo)
                    cmd.Parameters.AddWithValue("@Perfil", CmbPuesto.Text)
                    cmd.Parameters.AddWithValue("@Activo", activo)
                    cmd.Parameters.AddWithValue("@DNI", TxtDni.Text)

                    Dim filas = cmd.ExecuteNonQuery()

                    If filas > 0 Then
                        MessageBox.Show("Usuario modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No se encontró un usuario con ese DNI.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al modificar usuario: " & ex.Message)
        Finally
            CargarUsuarios()
            LimpiarCampos()
        End Try
    End Sub

    ' =====================================================
    ' BOTÓN BUSCAR (por DNI)
    ' =====================================================
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If TxtDni.Text = "" Then
            MessageBox.Show("Ingrese el DNI del usuario a buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using conexion As New SqlConnection(CadenaConexion)
                conexion.Open()

                Dim consulta As String = "
                    SELECT Nombre_Apellido, Email, Sexo, Perfil, Activo
                    FROM Usuarios WHERE DNI = @DNI"

                Using cmd As New SqlCommand(consulta, conexion)
                    cmd.Parameters.AddWithValue("@DNI", TxtDni.Text)

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            TxtNombre.Text = reader("Nombre_Apellido").ToString()
                            TxtEmail.Text = reader("Email").ToString()
                            CmbPuesto.Text = reader("Perfil").ToString()

                            ' Sexo
                            Dim sexo As String = reader("Sexo").ToString()
                            rbtnMujer.Checked = (sexo = "Mujer")
                            rbtnHombre.Checked = (sexo = "Hombre")

                            ' Activo / Inactivo
                            Dim activo As Boolean = Convert.ToBoolean(reader("Activo"))
                            RbtActivo.Checked = activo
                            RbtInactivo.Checked = Not activo
                        Else
                            MessageBox.Show("No se encontró un usuario con ese DNI.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            LimpiarCampos()
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al buscar usuario: " & ex.Message)
        End Try
    End Sub

    ' =====================================================
    ' HACER CLICK EN EL DATAGRIDVIEW
    ' =====================================================
    Private Sub DgvUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvUsuarios.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = DgvUsuarios.Rows(e.RowIndex)

            TxtNombre.Text = fila.Cells("Nombre_Apellido").Value.ToString()
            TxtEmail.Text = fila.Cells("Email").Value.ToString()
            TxtDni.Text = fila.Cells("DNI").Value.ToString()
            CmbPuesto.Text = fila.Cells("Perfil").Value.ToString()

            ' Sexo
            Dim sexo As String = fila.Cells("Sexo").Value.ToString()
            rbtnMujer.Checked = (sexo = "Mujer")
            rbtnHombre.Checked = (sexo = "Hombre")

            ' Estado (Activo/Inactivo)
            Dim estado As String = fila.Cells("Estado").Value.ToString()
            RbtActivo.Checked = (estado = "Activo")
            RbtInactivo.Checked = (estado = "Inactivo")
        End If
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
        FormAdministrador.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub rbtnMujer_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnMujer.CheckedChanged

    End Sub

    Private Sub rbtnHombre_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnHombre.CheckedChanged

    End Sub
End Class

