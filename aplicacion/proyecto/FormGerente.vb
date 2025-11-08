Public Class FormGerente
    Private Sub FormGerente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub LblBienvenido_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        ' Supongamos que después del login obtenés el rol


        ' Mostrar saludo en el ToolStripLabel
        TSalir.Text = "¡Bienvenido " & "perfil" & "!"
        TSalir.ForeColor = Color.DarkViolet

    End Sub

    Private Sub LblBienvenido_Click_1(sender As Object, e As EventArgs) Handles LblBienvenido.Click

    End Sub

    Private Sub TSalir_Click(sender As Object, e As EventArgs) Handles TSalir.Click
        ' Cierra el formulario de login actual
        Me.Close()

        ' Muestra el formulario de inicio
        Dim formInicio As New FormLogin()
        FormLogin.Show()
    End Sub

    Private Sub RegistrarVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarVentasToolStripMenuItem.Click
        FormRegistarVentas.Show()
    End Sub

    Private Sub VerVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerVentasToolStripMenuItem.Click
        FormMisVentasGerente.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click

    End Sub

    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click
        FormClientes.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem1.Click
        FormProveedores.Show()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        FormRegistarVentas.Show()
    End Sub

    Private Sub CategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriaToolStripMenuItem.Click
        FormGestionProductos.Show()
    End Sub

    Private Sub VerTodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerTodosToolStripMenuItem.Click
        FormStockVendedor.Show()
    End Sub
End Class