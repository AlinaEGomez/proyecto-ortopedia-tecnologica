Public Class Form2
    Private Sub VendedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendedorToolStripMenuItem.Click
        Form5.Show()
    End Sub

    Private Sub GerenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerenteToolStripMenuItem.Click
        Form6.Show()
    End Sub



    Private Sub MantenimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoToolStripMenuItem.Click

    End Sub

    Private Sub RolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RolToolStripMenuItem.Click

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        ' Cierra el formulario de login actual
        Me.Close()

        ' Muestra el formulario de inicio
        Dim formInicio As New Form1()
        Form1.Show()
    End Sub

End Class