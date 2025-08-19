Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load, BSalir.KeyDown

    End Sub


    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        ' Asumiendo que los textbox se llaman TextBox1 y TextBox2, y el tercer textbox se llama TextBox3
        TextBox1.Text = TextBox3.Text & " " & TextBox2.Text

    End Sub


    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        ' Borra el texto de todos los TextBox
        ' Asegúrate de usar los nombres de tus TextBox si son diferentes
        TextBox1.Clear()
    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        End ' Opcional: Si solo quieres cerrar el formulario actual, usa
        Me.Close()
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Verifica si se presionó la tecla 'S' junto con la tecla 'Control'
        If e.Control AndAlso e.KeyCode = Keys.S Then
            End
        End If
    End Sub

End Class
