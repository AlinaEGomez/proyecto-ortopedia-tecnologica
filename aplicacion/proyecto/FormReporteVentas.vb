Imports Microsoft.Data.SqlClient
Imports System.Drawing

Public Class FormReporteVentas

    Private conexion As New SqlConnection("Server=localhost\SQLEXPRESS;Database=ortopedicTecnologi_taller;Trusted_Connection=True;TrustServerCertificate=True;")
    Private Sub FormReporteVentas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Verificamos el perfil desde el módulo global
        Select Case MdlSesion.PerfilUsuario
            Case "administrador"
                Dim frmAdmin As New FormAdministrador()
                frmAdmin.Show()
            Case "gerente"
                Dim frmGerente As New FormGerente()
                frmGerente.Show()
            Case "vendedor"
                Dim frmVendedor As New FormVendedor()
                frmVendedor.Show()
        End Select
    End Sub

    ' ===========================
    ' BOTÓN GENERAR REPORTE
    ' ===========================
    Private Sub btnGenerarReporte_Click(sender As Object, e As EventArgs) Handles btnGenerarReporte.Click
        CargarReporte()
    End Sub

    ' ===========================
    ' 1️⃣ CARGAR DATOS
    ' ===========================
    Private Sub CargarReporte()
        Dim fechaInicio As DateTime = dtpFechaInicio.Value.Date
        Dim fechaFin As DateTime = dtpFechaFin.Value.Date.AddDays(1).AddMilliseconds(-1)

        Dim consulta As String =
            "SELECT U.Nombre_Apellido AS Vendedor,
                    SUM(V.Total) AS Total_Vendido
             FROM Ventas V
             JOIN Usuarios U ON V.IdVendedor = U.Id
             WHERE V.Fecha BETWEEN @FechaInicio AND @FechaFin
             GROUP BY U.Nombre_Apellido
             ORDER BY Total_Vendido DESC"

        Try
            conexion.Open()
            Dim adaptador As New SqlDataAdapter(consulta, conexion)
            adaptador.SelectCommand.Parameters.AddWithValue("@FechaInicio", fechaInicio)
            adaptador.SelectCommand.Parameters.AddWithValue("@FechaFin", fechaFin)

            Dim dt As New DataTable()
            adaptador.Fill(dt)

            ' Mostrar tabla completa en DgvReporte
            DgvReporte.DataSource = dt

            ' Mostrar gráfico en DgvGrafico
            ' MostrarGraficoEnOtroDGV(dt)

        Catch ex As Exception
            MessageBox.Show("Error al generar el reporte: " & ex.Message)
        Finally
            If conexion.State = ConnectionState.Open Then conexion.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class


