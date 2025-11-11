' --- En FormMisVentasGerente.vb ---
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports MdlSesion ' Importa tu módulo global

Public Class FormMisVentasGerente ' 🔑 Nuevo nombre de formulario

    Private gestor As New GestorBD()

    Private Sub FormMisVentasGerente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarMisVentas()
    End Sub

    Public Sub CargarMisVentas()

        ' 1. Obtener el ID del gerente logueado (Se usa la misma variable que el vendedor)
        Dim idGerenteActual As Integer = MdlSesion.VendedorID

        If idGerenteActual <= 0 Then
            MessageBox.Show("Error de sesión: No se detectó un ID de usuario válido.", "Error")
            Return
        End If

        Try
            ' 2. Llamar a la misma función del gestor (CargarVentasPorVendedor)
            ' El gestor usa el ID para filtrar las ventas de ese usuario, sin importar su perfil.
            DgvMisVentasGerente.DataSource = gestor.CargarVentasPorVendedor(idGerenteActual) ' 🔑 Asume un DataGridView llamado DgvMisVentasGerente

            ' 3. Configuración de la grilla
            DgvMisVentasGerente.Columns("VentaID").Visible = False
            DgvMisVentasGerente.Columns("Total").DefaultCellStyle.Format = "C2" ' Formato moneda

            Me.Text = $"Mis Ventas ({MdlSesion.NombreCompleto})"

        Catch ex As Exception
            MessageBox.Show("Error al cargar mis ventas: " & ex.Message, "Error BD")
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        CargarMisVentas
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        FormGerente.Show()
    End Sub
End Class