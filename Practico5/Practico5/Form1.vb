Public Class Form1

    ' Variables globales
    Dim archivo As String
    Dim Source As String
    Dim Destination As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configuración inicial del DataGridView
        DgvClientes.ColumnCount = 8
        DgvClientes.Columns(0).Name = "Nombre"
        DgvClientes.Columns(1).Name = "Apellido"
        DgvClientes.Columns(2).Name = "Sexo"
        DgvClientes.Columns(3).Name = "Fecha nacimiento"
        DgvClientes.Columns(4).Name = "Saldo"
        DgvClientes.Columns(5).Name = "Foto"
        DgvClientes.Columns(6).Name = "Ruta"

        ' Columna de botón eliminar
        Dim btnCol As New DataGridViewButtonColumn()
        btnCol.Name = "Eliminar"
        btnCol.HeaderText = "Eliminar"
        btnCol.Text = "Eliminar"
        btnCol.UseColumnTextForButtonValue = True
        DgvClientes.Columns.Add(btnCol)

        ' Ajustes estéticos
        DgvClientes.RowTemplate.Height = 60
        DgvClientes.AllowUserToAddRows = False

        ' Fuentes personalizadas
        DgvClientes.Columns("Nombre").DefaultCellStyle.Font = New Font("Arial", 12, FontStyle.Bold)
        DgvClientes.Columns("Apellido").DefaultCellStyle.Font = New Font("Times New Roman", 12, FontStyle.Italic)

        ' Imagen por defecto

    End Sub

    Private Function filaname() As String
        Throw New NotImplementedException()
    End Function

    ' Botón para seleccionar foto con OpenFileDialog
    Private Sub BtnFoto_Click(sender As Object, e As EventArgs) Handles BtnFoto.Click
        OpenFileDialog1.Filter = "Archivos Imagenes|*.jpg;*.bmp;*.png"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            TxFoto.Text = OpenFileDialog1.FileName

            ' Copiar la imagen a la carpeta Fotos
            Source = OpenFileDialog1.FileName
        End If
        archivo = IO.Path.GetFileName(Source)
        Destination = Application.StartupPath & "\Fotos\" & archivo
        IO.File.Copy(Source, Destination, True)
        TxFoto.Text = Destination
    End Sub

    ' Convertir nombre y apellido a formato correcto
    Private Sub TxNombre_Leave(sender As Object, e As EventArgs) Handles TxNombre.Leave
        If TxNombre.Text.Length > 0 Then

            TxNombre.Text = TxNombre.Text.Substring(0, 1).ToUpper &
                        TxNombre.Text.Substring(1).ToLower
        End If
    End Sub

    Private Sub TxApellido_Leave(sender As Object, e As EventArgs) Handles TxApellido.Leave

        If TxApellido.Text.Length > 0 Then
            TxApellido.Text = TxApellido.Text.Substring(0, 1).ToUpper &
                          TxApellido.Text.Substring(1).ToLower
        End If
    End Sub

    ' Botón Guardar
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim sexo = ""
        If RbMasculino.Checked Then
            sexo = "Masculino"
        ElseIf RbFemenino.Checked Then
            sexo = "Femenino"
        End If

        Dim saldo As Decimal
        Decimal.TryParse(TxSaldo.Text, saldo)



        ' Imagen por defecto si no se seleccionó ninguna
        If PictureBox1.Image Is Nothing Then
            PictureBox1.Image = Image.FromFile("Fotos\avatar.jpg")
            TxFoto.Text = Application.StartupPath & "\Fotos\avatar.jpg"
        End If

        ' Agregar fila al DataGridView
        DgvClientes.Rows.Add(TxNombre.Text, TxApellido.Text, sexo, saldo)
        'columna fecha de nacimiento
        Dim colFecha As New DataGridViewTextBoxColumn
        colFecha.Name = "Fecha nacimiento"
        colFecha.HeaderText = "Fecha Nacimiento"
        'Agregar columna sexo
        Dim colSexo As New DataGridViewTextBoxColumn
        colSexo.Name = "Sexo"
        colSexo.HeaderText = "Sexo"
        ' Marcar en rojo si saldo < 50
        Dim row = DgvClientes.Rows(DgvClientes.Rows.Count - 1)
        If saldo < 50 Then
            row.DefaultCellStyle.BackColor = Color.Red
        End If
    End Sub

    ' Evento para eliminar fila
    Private Sub DgvClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvClientes.CellContentClick
        If e.ColumnIndex = DgvClientes.Columns("Eliminar").Index AndAlso e.RowIndex >= 0 Then
            Dim respuesta As DialogResult = MessageBox.Show("¿Desea eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If respuesta = DialogResult.Yes Then
                DgvClientes.Rows.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub
    'Columna foto
    Dim colFoto As New DataGridViewImageColumn

    ' Cuando selecciono fila, marcar RadioButton correspondiente
    Private Sub DgvClientes_SelectionChanged(sender As Object, e As EventArgs) Handles DgvClientes.SelectionChanged
        If DgvClientes.CurrentRow IsNot Nothing Then
            Dim sexo As String = DgvClientes.CurrentRow.Cells("Sexo").Value.ToString()
            If sexo = "Masculino" Then
                RbMasculino.Checked = True
            ElseIf sexo = "Femenino" Then
                RbFemenino.Checked = True
            End If
        End If
    End Sub




End Class
