Imports Microsoft.Data.SqlClient
Public Class FormReporteVentas





    Private conexion As New SqlConnection("Server=localhost\SQLEXPRESS01;Database=ortopedia_taller;Trusted_Connection=True;TrustServerCertificate=True;")

    Private Sub FormReporteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar el reporte inicial al abrir el formulario
        CargarReporte()
    End Sub

    Public Sub CargarReporte()
        Try
            conexion.Open()

            ' La consulta SQL que obtuvimos arriba
            Dim consulta As String = "
            SELECT 
                V.VentaID, 
                V.Fecha, 
                U.Nombre + ' ' + U.Apellido AS Vendedor, 
                V.Total
            FROM 
                Ventas V
            INNER JOIN 
                Usuarios U ON V.Usuario = U.Id -- ⬅️ Asumiendo V.Usuario = U.Id
            ORDER BY 
                V.Fecha DESC"

            Using cmd As New SqlCommand(consulta, conexion)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim dtReporte As New DataTable()
                adapter.Fill(dtReporte)

                DgvReporte.DataSource = dtReporte

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cargar el reporte de ventas: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub
    Private Sub DgvReporte_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvReporte.CellContentClick

    End Sub

End Class