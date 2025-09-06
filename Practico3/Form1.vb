Public Class PequeñoFormulario
    Private Sub TDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDni.KeyPress
        'Solo permite numeros'
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

    Private Sub TNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombre.KeyPress
        'solo permite letras'
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TApellido.KeyPress
        'solo permite letras'
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click


        ' Valida si algún campo está vacío usando el operador lógico 'Or'
        If TDni.Text = "" Or TApellido.Text = "" Or TNombre.Text = "" Or TTelefono.Text = "" Then
            ' Muestra el mensaje de error crítico si algún campo está incompleto
            MsgBox("Debe Completar todos los campos", vbCritical, "Error")
        Else
            ' Si todos los campos están completos, muestra un mensaje de consulta
            Dim ask As MsgBoxResult = MsgBox("Seguro que desea insertar un nuevo Cliente?", vbQuestion + vbYesNo, "Confirmar Insercion")

            ' Verifica si el usuario presionó "Sí" en el mensaje de consulta
            If ask = MsgBoxResult.Yes Then
                ' Concatena el nombre y apellido para el label y el mensaje final
                LModificar.Text = TNombre.Text & " " & TApellido.Text

                ' Muestra el mensaje de información con el nombre completo
                MsgBox("El Cliente: " & LModificar.Text & " se insertó Correctamente", vbInformation, "Guardar")
            End If
        End If

    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        ' Validación de campos vacíos antes de eliminar
        If TDni.Text = "" Or TNombre.Text = "" Or TApellido.Text = "" Or TTelefono.Text = "" Then
            MsgBox("Debe haber un cliente cargado para eliminar", MsgBoxStyle.Exclamation, "Advertencia")
            Exit Sub
        End If
        ' Mensaje de confirmación con foco en NO
        Dim ask As MsgBoxResult
        ask = MsgBox("Está a punto de eliminar el Cliente: " & TNombre.Text & " " & TApellido.Text,
                     MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton2,
                     "Confirmar Eliminación")

        If ask = MsgBoxResult.Yes Then
            ' Limpia los campos
            TDni.Clear()
            TNombre.Clear()
            TApellido.Clear()

            LModificar.Text = ""

            ' Mensaje de confirmación
            MsgBox("El Cliente se eliminó correctamente", MsgBoxStyle.Information, "Eliminar")
        End If
    End Sub
    Private Sub RBVaron_CheckedChanged(sender As Object, e As EventArgs) Handles RBVaron.CheckedChanged
        If RBVaron.Checked Then
            ' Asigna la imagen del varón si está seleccionado
            PictureBox1.Image = My.Resources.hombre

        End If
    End Sub

    Private Sub RBMujer_CheckedChanged(sender As Object, e As EventArgs) Handles RBMujer.CheckedChanged
        If RBMujer.Checked Then
            ' Asigna la imagen de la mujer si está seleccionada
            PictureBox1.Image = My.Resources.mujer
        End If
    End Sub
    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub

    Private Sub PequeñoSistema_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim form As New PequeñoSistema()

        ' Asigna el formulario MDI padre
        PequeñoSistema.MdiParent = Me.MdiParent

        ' Muestra el formulario
        PequeñoSistema.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        PequeñoSistema.IsMdiContainer = True
    End Sub

    Private Sub TDni_TextChanged(sender As Object, e As EventArgs) Handles TDni.TextChanged

    End Sub

    Private Sub TTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TTelefono.KeyPress
        'solo permite numeros'
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub



    Private Sub CBNaranja_CheckedChanged(sender As Object, e As EventArgs) Handles CBNaranja.CheckedChanged

    End Sub

    Private Sub CBMastercard_CheckedChanged(sender As Object, e As EventArgs) Handles CBMastercard.CheckedChanged

    End Sub

    Private Sub CBVisa_CheckedChanged(sender As Object, e As EventArgs) Handles CBVisa.CheckedChanged

    End Sub
End Class
