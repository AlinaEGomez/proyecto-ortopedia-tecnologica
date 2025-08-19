Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TDni.TextChanged
    End Sub
    Private Sub TDni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TDni.KeyPress
        ' Permite solo números, la tecla de retroceso (Backspace) y el punto decimal
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Evita que se ingrese el carácter
        End If
    End Sub
    Private Sub TApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TApellido.KeyPress
        ' Permite solo letras, la tecla de retroceso (Backspace) y el espacio
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TNombre.KeyPress
        ' Permite solo letras, la tecla de retroceso (Backspace) y el espacio
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'Private Sub BGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BGuardar.Click
    ' Modifica el texto de la etiqueta Lmodificar


    ' Aquí iría el resto del código para guardar los datos
    'End Sub 
    Private Sub BGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BGuardar.Click
        ' Verifica si alguno de los campos está incompleto
        LModificar.Text = "Datos guardados correctamente"
        If TDni.Text = "" Or TApellido.Text = "" Or TNombre.Text = "" Then
            ' Muestra un mensaje de error si los campos están vacíos
            ' El título del mensaje es "Error" y el ícono es crítico
            MsgBox("Debe Completar todos los campos", MsgBoxStyle.Critical, "Error")
        Else
            ' Si todos los campos están completos, se ejecuta este bloque
            ' Modifica el texto de la etiqueta LModificar
            LModificar.Text = "Datos guardados correctamente"

            ' Aquí puedes agregar el código para guardar los datos en una base de datos o archivo
        End If
        ' Validaciones de entrada de texto (el código anterior sigue igual)

        ' Lógica del botón BGuardar

        ' Verifica si algún campo está vacío usando el operador lógico OR
        If String.IsNullOrWhiteSpace(TDni.Text) Or String.IsNullOrWhiteSpace(TApellido.Text) Or String.IsNullOrWhiteSpace(TNombre.Text) Then
            ' Si algún campo está vacío, muestra un mensaje de error crítico
            MsgBox("Debe Completar todos los campos", MsgBoxStyle.Critical, "Error")
        Else
            ' Si todos los campos están completos, se ejecuta este bloque

            ' 8) Crear una variable dentro del botón guardar con el nombre "ask"
            Dim ask As MsgBoxResult

            ' 9) Mostrar un mensaje de consulta y asignar el resultado a la variable "ask"
            ' Se usa MsgBoxStyle.Question para el icono y el focus en el botón 'Sí' es el comportamiento por defecto
            ask = MsgBox("¿Seguro que desea insertar un nuevo Cliente?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Confirmar Inserción")

            ' Utilizar una sentencia IF para verificar el resultado del MsgBox
            If ask = MsgBoxResult.Yes Then
                ' Si el usuario hace clic en "Sí", se ejecuta la siguiente instrucción
                LModificar.Text = "Datos modificados correctamente"
                ' Aquí es donde iría el código para insertar el nuevo cliente

            Else
                ' El usuario ha seleccionado "No"
                ' Puedes añadir cualquier otra acción aquí, como un mensaje de cancelación
                LModificar.Text = "Acción cancelada por el usuario"
            End If
            ' Utilizar una sentencia IF para verificar el resultado del MsgBox
            If ask = MsgBoxResult.Yes Then
                ' Si el usuario hace clic en "Sí", se ejecuta la siguiente instrucción
                LModificar.Text = "Datos modificados correctamente"

                ' Crear el mensaje de confirmación con el nombre completo
                Dim mensajeConfirmacion As String = "El Cliente: " & TNombre.Text & " " & TApellido.Text & " se insertó correctamente."

                ' Mostrar el mensaje de información
                MsgBox(mensajeConfirmacion, MsgBoxStyle.Information, "Guardar")

            Else
                ' El usuario ha seleccionado "No"
                ' Puedes añadir cualquier otra acción aquí, como un mensaje de cancelación
                LModificar.Text = "Acción cancelada por el usuario"
            End If
        End If
    End Sub
    ' Lógica del botón BEliminar
    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        ' Creamos una variable para almacenar la respuesta del MsgBox
        Dim ask As MsgBoxResult

        ' Creamos un mensaje dinámico con el nombre del cliente
        Dim mensajeEliminacion As String = "Está apunto de eliminar el Cliente: " & TNombre.Text & " " & TApellido.Text & "."

        ' Mostramos un mensaje de advertencia con el foco en "NO" (DefaultButton2)
        ask = MsgBox(mensajeEliminacion, MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation Or MsgBoxStyle.DefaultButton2, "Confirmar Eliminación")

        ' Mostramos un mensaje de advertencia con el foco en "NO" (DefaultButton2)
        ask = MsgBox(mensajeEliminacion, MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation Or MsgBoxStyle.DefaultButton2, "Confirmar Eliminación")

        ' Verificamos si el usuario confirmó la eliminación
        If ask = MsgBoxResult.Yes Then
            ' Si el usuario hace clic en "Sí", se ejecuta este bloque

            ' Creamos el mensaje de confirmación de eliminación
            Dim mensajeConfirmacion As String = "El Cliente: " & TNombre.Text & " " & TApellido.Text & " se eliminó correctamente."

            ' Mostramos el mensaje de información
            MsgBox(mensajeConfirmacion, MsgBoxStyle.Information, "Eliminar")

            ' Limpiamos todos los campos de texto
            TDni.Clear()
            TApellido.Clear()
            TNombre.Clear()

            ' Limpiamos el label LModificar
            LModificar.Text = ""
        End If
    End Sub

End Class
