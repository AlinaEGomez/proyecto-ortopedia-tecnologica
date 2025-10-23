Imports System.Transactions
Imports Microsoft.Data.SqlClient
Public Class FormReporteVentas





    Private conexion As New SqlConnection("Server=localhost\SQLEXPRESS01;Database=ortopedia_taller;Trusted_Connection=True;TrustServerCertificate=True;")





    Private Sub DgvReporte_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvReporte.CellContentClick

    End Sub

End Class