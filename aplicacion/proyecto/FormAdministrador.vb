Imports System.Data.SqlClient
Imports System.IO
Imports System.Numerics
Imports System.Text
Imports System.Windows.Forms ' Necesario para MessageBox
Imports ClosedXML.Excel
Public Class FormAdministrador


    Private Sub GerenteToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormGerente.Show()
    End Sub



    Private Sub MantenimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoToolStripMenuItem.Click

    End Sub

    Private Sub RolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RolToolStripMenuItem.Click

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs)


    End Sub
    Private Sub FormAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' ... otro código de inicialización ...
    End Sub
    Private Sub TSalir_Click(sender As Object, e As EventArgs) Handles TSalir.Click
        ' Cierra el formulario de login actual
        Me.Close()

        ' Muestra el formulario de inicio
        Dim formInicio As New FormLogin()
        FormLogin.Show()
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

    End Sub

    Private Sub InactivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InactivosToolStripMenuItem.Click
        FormClientesInactivos.MdiParent = Me
        FormClientesInactivos.Show()
    End Sub

    Private Sub ActivosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ActivosToolStripMenuItem1.Click
        FormGerenteActivo.MdiParent = Me
        FormGerenteActivo.Show()
    End Sub

    Private Sub InactivosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InactivosToolStripMenuItem1.Click
        FormGerenteInactivo.MdiParent = Me
        FormGerenteInactivo.Show()
    End Sub

    Private Sub ActivosToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ActivosToolStripMenuItem2.Click
        FormVendedorActivo.MdiParent = Me
        FormVendedorActivo.Show()
    End Sub

    Private Sub InactivosToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles InactivosToolStripMenuItem2.Click
        FormVendedorInactivo.MdiParent = Me
        FormVendedorInactivo.Show()
    End Sub

    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click
        FormCrudUsuarios.Show()
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

    Private Sub ProductosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem1.Click
        FormProveedores.Show()
    End Sub

    Private Sub ReporteDeComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeComprasToolStripMenuItem.Click
        FormReporteCompras.Show()
    End Sub



    Private Sub BackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupToolStripMenuItem.Click

    End Sub

    Private Sub CopiaDeSeguridadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiaDeSeguridadToolStripMenuItem.Click
        FormBackup.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        FormClientes.MdiParent = Me
        FormClientes.Show()
    End Sub


End Class