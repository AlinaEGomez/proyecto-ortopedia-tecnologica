Public Class Form2
    Private Sub VendedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendedorToolStripMenuItem.Click

    End Sub

    Private Sub GerenteToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form6.Show()
    End Sub



    Private Sub MantenimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoToolStripMenuItem.Click

    End Sub

    Private Sub RolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RolToolStripMenuItem.Click

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs)


    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub
    Private Sub TSalir_Click(sender As Object, e As EventArgs) Handles TSalir.Click
        ' Cierra el formulario de login actual
        Me.Close()

        ' Muestra el formulario de inicio
        Dim formInicio As New Form1()
        Form1.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        ' Supongamos que después del login obtenés el rol


        ' Mostrar saludo en el ToolStripLabel
        LblBienvenido.Text = "¡Bienvenido " & "perfil" & "!"
        LblBienvenido.ForeColor = Color.DarkGreen

    End Sub

    Private Sub AltaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem1.Click
        FormGestionProductos.Show()


    End Sub

    Private Sub ActivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActivosToolStripMenuItem.Click
        Form8.MdiParent = Me
        Form8.Show()
    End Sub

    Private Sub InactivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InactivosToolStripMenuItem.Click
        Form9.MdiParent = Me
        Form9.Show()
    End Sub

    Private Sub ActivosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ActivosToolStripMenuItem1.Click
        Form10.MdiParent = Me
        Form10.Show()
    End Sub

    Private Sub InactivosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InactivosToolStripMenuItem1.Click
        Form11.MdiParent = Me
        Form11.Show()
    End Sub

    Private Sub ActivosToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ActivosToolStripMenuItem2.Click
        Form12.MdiParent = Me
        Form12.Show()
    End Sub

    Private Sub InactivosToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles InactivosToolStripMenuItem2.Click
        Form13.MdiParent = Me
        Form13.Show()
    End Sub

    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click
        Form6.Show()
    End Sub



    Private Sub UsuariosToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        FormUsuarios.Show()
    End Sub

    Private Sub ReportesDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesDeVentasToolStripMenuItem.Click
        FormReporteVentas.Show()
    End Sub

    Private Sub ProductosActivosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormProducActiv.Show()
    End Sub
End Class