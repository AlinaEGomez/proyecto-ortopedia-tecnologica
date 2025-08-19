<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private Const V As String = "Mi primer Formulario"

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        BGuardar = New Button()
        BEliminar = New Button()
        LApellido = New Label()
        LNombre = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        BSalir = New Button()
        SuspendLayout()
        ' 
        ' BGuardar
        ' 
        BGuardar.Location = New Point(66, 222)
        BGuardar.Name = "BGuardar"
        BGuardar.Size = New Size(75, 23)
        BGuardar.TabIndex = 0
        BGuardar.Text = "Guardar" & vbCrLf
        BGuardar.UseVisualStyleBackColor = True
        ' 
        ' BEliminar
        ' 
        BEliminar.Location = New Point(177, 222)
        BEliminar.Name = "BEliminar"
        BEliminar.Size = New Size(75, 23)
        BEliminar.TabIndex = 1
        BEliminar.Text = "Eliminar" & vbCrLf
        BEliminar.UseVisualStyleBackColor = True
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.Location = New Point(66, 73)
        LApellido.Name = "LApellido"
        LApellido.Size = New Size(51, 15)
        LApellido.TabIndex = 2
        LApellido.Text = "Apellido" & vbCrLf
        ' 
        ' LNombre
        ' 
        LNombre.AutoSize = True
        LNombre.Location = New Point(66, 150)
        LNombre.Name = "LNombre"
        LNombre.Size = New Size(51, 15)
        LNombre.TabIndex = 3
        LNombre.Text = "Nombre" & vbCrLf
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(271, 55)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(200, 200)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(152, 142)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(152, 65)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 6
        ' 
        ' BSalir
        ' 
        BSalir.DialogResult = DialogResult.Cancel
        BSalir.Location = New Point(363, 26)
        BSalir.Name = "BSalir"
        BSalir.Size = New Size(75, 23)
        BSalir.TabIndex = 7
        BSalir.Text = "Salir"
        BSalir.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(484, 261)
        Controls.Add(BSalir)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(LNombre)
        Controls.Add(LApellido)
        Controls.Add(BEliminar)
        Controls.Add(BGuardar)
        KeyPreview = True
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mi primer Forms"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BGuardar As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents LApellido As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents BSalir As Button

End Class
