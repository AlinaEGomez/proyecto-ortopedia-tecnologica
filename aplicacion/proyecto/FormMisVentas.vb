
' --- En FormMisVentas.vb ---
Imports System.Data.SqlClient
Imports MdlSesion ' Importa tu módulo global

Public Class FormMisVentas

    Private gestor As New GestorBD()

    Private Sub FormMisVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarMisVentas()
    End Sub

    Public Sub CargarMisVentas()

        ' 1. Obtener el ID del vendedor logueado
        Dim idVendedorActual As Integer = MdlSesion.VendedorID

        If idVendedorActual <= 0 Then
            MessageBox.Show("Error de sesión: No se detectó un Vendedor ID válido.", "Error")
            Return
        End If

        Try
            ' 2. Llamar a la función del gestor
            DgvMisVentas.DataSource = gestor.CargarVentasPorVendedor(idVendedorActual)

            ' 3. Configuración de la grilla
            DgvMisVentas.Columns("VentaID").Visible = False
            DgvMisVentas.Columns("Total").DefaultCellStyle.Format = "C2" ' Formato moneda

            Me.Text = $"Mis Ventas ({MdlSesion.NombreCompleto})"

        Catch ex As Exception
            MessageBox.Show("Error al cargar mis ventas: " & ex.Message, "Error BD")
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        CargarMisVentas()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        FormVendedor.Show()
    End Sub
End Class