<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBackup
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        BtnIniciarBackup = New Button()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnIniciarBackup
        ' 
        BtnIniciarBackup.BackColor = Color.LightCoral
        BtnIniciarBackup.FlatStyle = FlatStyle.Popup
        BtnIniciarBackup.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        BtnIniciarBackup.Location = New Point(59, 220)
        BtnIniciarBackup.Margin = New Padding(2)
        BtnIniciarBackup.Name = "BtnIniciarBackup"
        BtnIniciarBackup.Size = New Size(154, 47)
        BtnIniciarBackup.TabIndex = 0
        BtnIniciarBackup.Text = "Backup"
        BtnIniciarBackup.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(BtnIniciarBackup)
        Panel1.Location = New Point(277, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(255, 295)
        Panel1.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(0, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(249, 212)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' FormBackup
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(799, 401)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "FormBackup"
        RightToLeftLayout = True
        StartPosition = FormStartPosition.CenterScreen
        Text = "Backup"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnIniciarBackup As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
