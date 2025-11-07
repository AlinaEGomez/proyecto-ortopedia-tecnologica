Public Class FormReporteCompras
    ' --- En FormReporteCompras.vb o FormPrincipal.vb ---

    Private gestor As New GestorBD() ' Asumimos que el gestor está accesible

    Private Sub btnGenerarReporteCompras_Click(sender As Object, e As EventArgs) Handles btnGenerarReporteCompras.Click

        ' 1. Obtener el rango de fechas
        Dim fechaInicio As DateTime = dtpFechaInicio.Value.Date
        ' Para incluir todo el día de fin, sumamos casi 24 horas.
        Dim fechaFin As DateTime = dtpFechaFin.Value.Date.AddDays(1).AddSeconds(-1)

        Try
            ' 2. Llamar al GestorBD para obtener los datos
            Dim dtReporte As DataTable = gestor.ObtenerReporteCompras(fechaInicio, fechaFin)

            ' 3. Mostrar el resultado
            dgvReporte.DataSource = dtReporte

            If dtReporte.Rows.Count = 0 Then
                MessageBox.Show("No se encontraron compras en el rango de fechas seleccionado.", "Aviso")
            End If

            ' 4. Calcular y mostrar el total global (Opcional)
            Dim totalGlobal As Decimal = CDec(dtReporte.Compute("SUM(Monto_Total_Comprado)", String.Empty))
            lblTotalGlobal.Text = $"Total Compra: {totalGlobal:C2}" ' Muestra el total formateado como moneda

        Catch ex As Exception
            MessageBox.Show("Error al procesar el reporte: " & ex.Message, "Error")
        End Try

    End Sub
End Class