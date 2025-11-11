Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class FormAdmnUsuario

    Private conexion As New SqlConnection("Server=localhost\SQLEXPRESS;Database=ortopedicTecnologi_taller;Trusted_Connection=True;TrustServerCertificate=True;")

    Private Sub FormAdmnUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llenar ComboBox con opciones
        CmbPerfil.Items.AddRange(New String() {"Cliente", "Vendedor", "Gerente"})
        CmbEstado.Items.AddRange(New String() {"Activo", "Inactivo"})

        ' Cargar todos los usuarios al iniciar
        CargarUsuarios()
    End Sub

    ' ===============================
    ' Cargar Usuarios
    ' ===============================
    Private Sub CargarUsuarios(Optional perfil As String = "", Optional estado As String = "")
        Try
            conexion.Open()

            Dim consulta As String = "
                SELECT 
                    Id,
                    Nombre_Apellido AS Nombre,
                    Perfil,
                    CASE WHEN Activo = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado,
                    DNI,
                    Email
                FROM Usuarios
                WHERE 1=1
            "

            If perfil <> "" AndAlso perfil <> "Cliente" Then
                consulta &= " AND Perfil = @perfil"
            End If

            If estado <> "" Then
                consulta &= If(estado = "Activo", " AND Activo = 1", " AND Activo = 0")
            End If

            Dim cmd As New SqlCommand(consulta, conexion)
            If perfil <> "" AndAlso perfil <> "Cliente" Then cmd.Parameters.AddWithValue("@perfil", perfil)

            Dim adaptador As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)

            DgvUsuarios.DataSource = tabla

        Catch ex As Exception
            MessageBox.Show("Error al cargar usuarios: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    ' ===============================
    ' Cargar Clientes
    ' ===============================
    Private Sub CargarClientes(Optional estado As String = "")
        Try
            conexion.Open()

            Dim consulta As String = "
                SELECT 
                    ClienteID AS Id,
                    RazonSocial AS Nombre,
                    CUIT,
                    Telefono,
                    Email,
                    CASE WHEN EstadoLogico = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado
                FROM Clientes
                WHERE 1=1
            "

            If estado <> "" Then
                consulta &= If(estado = "Activo", " AND EstadoLogico = 1", " AND EstadoLogico = 0")
            End If

            Dim cmd As New SqlCommand(consulta, conexion)
            Dim adaptador As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)

            DgvUsuarios.DataSource = tabla

        Catch ex As Exception
            MessageBox.Show("Error al cargar clientes: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    ' ===============================
    ' Botón Buscar
    ' ===============================
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim perfil As String = CmbPerfil.Text
        Dim estado As String = CmbEstado.Text

        If perfil = "Cliente" Then
            CargarClientes(estado)
        Else
            CargarUsuarios(perfil, estado)
        End If
    End Sub

    ' ===============================
    ' Botón Mostrar Todos
    ' ===============================
    Private Sub BtnMostrarTodos_Click(sender As Object, e As EventArgs) Handles BtnMostrarTodos.Click
        Dim perfil As String = CmbPerfil.Text

        If perfil = "Cliente" Then
            CargarClientes()
        Else
            CargarUsuarios()
        End If
    End Sub

    ' ===============================
    ' Botón Cerrar
    ' ===============================
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
        FormAdministrador.Show()
    End Sub

End Class

