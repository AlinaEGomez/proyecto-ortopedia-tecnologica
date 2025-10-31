Imports System.Transactions
Imports Microsoft.Data.SqlClient

Public Class FormReporteVentas

    Private conexion As New SqlConnection("Server=localhost\SQLEXPRESS01;Database=ortopedicTecnologi_taller;Trusted_Connection=True;TrustServerCertificate=True;")

    Private Sub CargarReporte()

        ' 1. Obtener las fechas desde la interfaz
        Dim fechaInicio As DateTime = dtpFechaInicio.Value.Date
        ' Para incluir todo el día final, sumamos 1 día y restamos 1 milisegundo
        Dim fechaFin As DateTime = dtpFechaFin.Value.Date.AddDays(1).AddMilliseconds(-1)

        ' La consulta SQL (la que definimos arriba)
        Dim consulta As String = "SELECT U.Nombre_Apellido AS Vendedor, COUNT(V.VentaID) AS Cantidad_Tickets, SUM(V.Total) AS Total_Vendido " &
                             "FROM Ventas V JOIN Usuarios U ON V.IdVendedor = U.Id " &
                             "WHERE V.Fecha BETWEEN @FechaInicio AND @FechaFin " &
                             "GROUP BY U.Nombre_Apellido, U.Id ORDER BY Total_Vendido DESC"

        Try
            conexion.Open()

            Dim adaptador As New SqlDataAdapter(consulta, conexion)

            ' 2. Añadir Parámetros (Importante para las fechas)
            adaptador.SelectCommand.Parameters.AddWithValue("@FechaInicio", fechaInicio)
            adaptador.SelectCommand.Parameters.AddWithValue("@FechaFin", fechaFin)

            ' 3. Llenar el DataTable y el DataGridView
            Dim dtReporte As New DataTable()
            adaptador.Fill(dtReporte)

            DgvReporte.DataSource = dtReporte

            ' 4. Mostrar Resumen Global
            If dtReporte.Rows.Count > 0 Then
                Dim totalGlobal As Decimal = CDec(dtReporte.Compute("SUM(Total_Vendido)", String.Empty))
                MessageBox.Show($"Reporte generado con éxito. Total vendido en el período: ${totalGlobal:N2}")
            End If

        Catch ex As Exception
            MessageBox.Show("Error al generar el reporte: " & ex.Message)

        Finally
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub

    Private Sub btnGenerarReporte_Click(sender As Object, e As EventArgs) Handles btnGenerarReporte.Click
        CargarReporte()
    End Sub
End Class