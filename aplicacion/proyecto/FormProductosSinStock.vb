Imports Microsoft.Data.SqlClient
Imports System.Data.SqlClient
Public Class FormProducActiv
    Private conexion As New SqlConnection("Server=localhost\SQLEXPRESS;Database=ortopedicTecnologi_taller;Trusted_Connection=True;TrustServerCertificate=True;")


    ' Asegúrate de que tu objeto de conexión (conexion) esté accesible
    Private Sub CargarProductosConStock()
        Dim dtProductos As New DataTable()

        ' 🔑 CONSULTA CLAVE: Filtra por EstadoLogico=1 y Stock > 0
        Dim consulta As String = "SELECT ProductoID, Codigo, Descripcion, Stock, Precio " &
                             "FROM Productos " &
                             "WHERE EstadoLogico = 1 AND Stock > 0 " &
                             "ORDER BY Descripcion ASC"

        Try
            conexion.Open()

            Dim adaptador As New SqlDataAdapter(consulta, conexion)
            adaptador.Fill(dtProductos)

            ' Asignar los datos al DataGridView de la pestaña
            DgvProductosConStock.DataSource = dtProductos

        Catch ex As Exception
            MessageBox.Show("Error al cargar productos con stock: " & ex.Message, "Error de Base de Datos")

        Finally
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub


    Private Sub FormProducActiv_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class