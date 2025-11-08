Public Class FormVendedor
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LblBienvenido_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        ' Cierra el formulario de login actual
        Me.Close()

        ' Muestra el formulario de inicio
        Dim formInicio As New FormLogin()
        FormLogin.Show()
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles LblBienvenido.Click
        ' Mostrar saludo en el ToolStripLabel
        LblBienvenido.Text = "¡Bienvenido " & "perfil" & "!"
        LblBienvenido.ForeColor = Color.DarkGreen
    End Sub

    Private Sub RgistrarVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RgistrarVentasToolStripMenuItem.Click
        FormRegistarVentas.Show()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        FormClientes.Show()
    End Sub


    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockDisponibleToolStripMenuItem.Click
        Dim frm As New FormStockVendedor()
        frm.Show()
    End Sub

    Private Sub VerVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerVentasToolStripMenuItem.Click
        Dim frm As New FormMisVentas()
        frm.Show()
    End Sub
End Class