Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
End Class