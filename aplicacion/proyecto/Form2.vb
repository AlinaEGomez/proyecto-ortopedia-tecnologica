Public Class Form2
    Private Sub VendedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendedorToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub GerenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerenteToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub AdministradorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministradorToolStripMenuItem.Click
        Form5.Show()
    End Sub
End Class