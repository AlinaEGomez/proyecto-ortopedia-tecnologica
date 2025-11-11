Imports System.Data
Imports Microsoft.Data.SqlClient
Imports System.Drawing

Public Class FormReporteCompras

    ' Instancia de GestorBD
    Private gestor As New GestorBD()

    Private Sub FormReporteCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializamos controles
        dtpFechaInicio.Value = DateTime.Now.AddMonths(-1)
        dtpFechaFin.Value = DateTime.Now

        dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvReporte.RowHeadersVisible = False
        dgvReporte.ReadOnly = True
    End Sub

    ' ===========================
    ' BOTÓN GENERAR REPORTE
    ' ===========================
    Private Sub btnGenerarReporteCompras_Click(sender As Object, e As EventArgs) Handles btnGenerarReporteCompras.Click
        CargarReporte()
    End Sub

    ' ===========================
    ' MÉTODO CARGAR REPORTE
    ' ===========================
    Private Sub CargarReporte()
        Dim fechaInicio As DateTime = dtpFechaInicio.Value.Date
        Dim fechaFin As DateTime = dtpFechaFin.Value.Date.AddDays(1).AddSeconds(-1)

        Try
            Dim dtReporte As DataTable = gestor.ObtenerReporteCompras(fechaInicio, fechaFin)

            If dtReporte.Rows.Count = 0 Then
                MessageBox.Show("No se encontraron compras en el rango de fechas seleccionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            ' Mostrar en DataGridView
            dgvReporte.DataSource = dtReporte

            ' Total global
            Dim totalGlobal As Decimal = 0
            If dtReporte.Rows.Count > 0 Then
                totalGlobal = CDec(dtReporte.Compute("SUM(Monto_Total_Comprado)", String.Empty))
            End If
            lblTotalGlobal.Text = $"Total Compra: {totalGlobal:C2}"

        Catch ex As Exception
            MessageBox.Show("Error al generar el reporte: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ===========================
    ' BOTÓN CERRAR FORM
    ' ===========================


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        FormAdministrador.Show()
    End Sub
End Class
