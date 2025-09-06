<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        DgvClientes = New DataGridView()
        RbMasculino = New RadioButton()
        RbFemenino = New RadioButton()
        PictureBox1 = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        Panel = New Panel()
        Label1 = New Label()
        LSexo = New Label()
        Label4 = New Label()
        DateTimePicker2 = New DateTimePicker()
        TxApellido = New TextBox()
        BtnFoto = New Button()
        BtnGuardar = New Button()
        Label5 = New Label()
        TxNombre = New TextBox()
        Label6 = New Label()
        TxSaldo = New TextBox()
        TxFoto = New TextBox()
        CType(DgvClientes, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel.SuspendLayout()
        SuspendLayout()
        ' 
        ' DgvClientes
        ' 
        DgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvClientes.Location = New Point(30, 310)
        DgvClientes.Name = "DgvClientes"
        DgvClientes.Size = New Size(817, 140)
        DgvClientes.TabIndex = 0
        ' 
        ' RbMasculino
        ' 
        RbMasculino.AutoSize = True
        RbMasculino.BackColor = Color.Black
        RbMasculino.ForeColor = Color.White
        RbMasculino.Location = New Point(212, 154)
        RbMasculino.Name = "RbMasculino"
        RbMasculino.Size = New Size(126, 34)
        RbMasculino.TabIndex = 9
        RbMasculino.TabStop = True
        RbMasculino.Text = "Masculino"
        RbMasculino.UseVisualStyleBackColor = False
        ' 
        ' RbFemenino
        ' 
        RbFemenino.AutoSize = True
        RbFemenino.BackColor = Color.Black
        RbFemenino.ForeColor = Color.White
        RbFemenino.Location = New Point(379, 154)
        RbFemenino.Name = "RbFemenino"
        RbFemenino.Size = New Size(122, 34)
        RbFemenino.TabIndex = 10
        RbFemenino.TabStop = True
        RbFemenino.Text = "Femenino"
        RbFemenino.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ControlDark
        PictureBox1.Location = New Point(613, 24)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(212, 218)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Panel
        ' 
        Panel.BackColor = SystemColors.ActiveCaptionText
        Panel.Controls.Add(Label1)
        Panel.Controls.Add(LSexo)
        Panel.Controls.Add(Label4)
        Panel.Controls.Add(RbFemenino)
        Panel.Controls.Add(DateTimePicker2)
        Panel.Controls.Add(RbMasculino)
        Panel.Controls.Add(TxApellido)
        Panel.Controls.Add(BtnFoto)
        Panel.Controls.Add(BtnGuardar)
        Panel.Controls.Add(Label5)
        Panel.Controls.Add(TxNombre)
        Panel.Controls.Add(Label6)
        Panel.Controls.Add(TxSaldo)
        Panel.Controls.Add(TxFoto)
        Panel.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel.Location = New Point(30, 12)
        Panel.Name = "Panel"
        Panel.Size = New Size(553, 281)
        Panel.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Black
        Label1.ForeColor = Color.White
        Label1.Location = New Point(25, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(209, 30)
        Label1.TabIndex = 16
        Label1.Text = "Fecha de Nacimiento"
        ' 
        ' LSexo
        ' 
        LSexo.AutoSize = True
        LSexo.BackColor = Color.Black
        LSexo.ForeColor = Color.White
        LSexo.Location = New Point(25, 160)
        LSexo.Name = "LSexo"
        LSexo.Size = New Size(55, 30)
        LSexo.TabIndex = 15
        LSexo.Text = "sexo"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Black
        Label4.Font = New Font("Segoe Script", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(25, 12)
        Label4.Name = "Label4"
        Label4.Size = New Size(107, 33)
        Label4.TabIndex = 5
        Label4.Text = "Nombre:"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Format = DateTimePickerFormat.Short
        DateTimePicker2.Location = New Point(291, 81)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(169, 35)
        DateTimePicker2.TabIndex = 14
        ' 
        ' TxApellido
        ' 
        TxApellido.Location = New Point(282, 44)
        TxApellido.Name = "TxApellido"
        TxApellido.Size = New Size(200, 35)
        TxApellido.TabIndex = 1
        ' 
        ' BtnFoto
        ' 
        BtnFoto.BackColor = SystemColors.ActiveBorder
        BtnFoto.ForeColor = SystemColors.ControlText
        BtnFoto.Location = New Point(25, 193)
        BtnFoto.Name = "BtnFoto"
        BtnFoto.Size = New Size(75, 39)
        BtnFoto.TabIndex = 12
        BtnFoto.Text = "Foto..."
        BtnFoto.TextAlign = ContentAlignment.MiddleRight
        BtnFoto.UseVisualStyleBackColor = False
        ' 
        ' BtnGuardar
        ' 
        BtnGuardar.Image = My.Resources.Resources.ahorrar
        BtnGuardar.ImageAlign = ContentAlignment.MiddleLeft
        BtnGuardar.Location = New Point(139, 235)
        BtnGuardar.Name = "BtnGuardar"
        BtnGuardar.Size = New Size(127, 43)
        BtnGuardar.TabIndex = 13
        BtnGuardar.Text = "Guardar"
        BtnGuardar.TextAlign = ContentAlignment.MiddleRight
        BtnGuardar.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Black
        Label5.Font = New Font("Segoe Script", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(25, 44)
        Label5.Name = "Label5"
        Label5.Size = New Size(116, 33)
        Label5.TabIndex = 6
        Label5.Text = "Apellido:"
        ' 
        ' TxNombre
        ' 
        TxNombre.Location = New Point(282, 3)
        TxNombre.Name = "TxNombre"
        TxNombre.Size = New Size(200, 35)
        TxNombre.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Black
        Label6.ForeColor = Color.White
        Label6.Location = New Point(31, 122)
        Label6.Name = "Label6"
        Label6.Size = New Size(69, 30)
        Label6.TabIndex = 7
        Label6.Text = "Saldo:"
        ' 
        ' TxSaldo
        ' 
        TxSaldo.Location = New Point(301, 122)
        TxSaldo.Name = "TxSaldo"
        TxSaldo.Size = New Size(200, 35)
        TxSaldo.TabIndex = 3
        ' 
        ' TxFoto
        ' 
        TxFoto.Location = New Point(291, 194)
        TxFoto.Name = "TxFoto"
        TxFoto.Size = New Size(200, 35)
        TxFoto.TabIndex = 4
        ' 
        ' Form1
        ' 
        BackgroundImage = My.Resources.Resources.walpaper_1
        ClientSize = New Size(881, 480)
        Controls.Add(Panel)
        Controls.Add(PictureBox1)
        Controls.Add(DgvClientes)
        Name = "Form1"
        Text = "Formulario con Grid"
        CType(DgvClientes, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel.ResumeLayout(False)
        Panel.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents DgvClientes As DataGridView
    Friend WithEvents RbMasculino As RadioButton
    Friend WithEvents RbFemenino As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Panel As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents TxApellido As TextBox
    Friend WithEvents BtnFoto As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TxNombre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxSaldo As TextBox
    Friend WithEvents TxFoto As TextBox
    Friend WithEvents LSexo As Label
    Friend WithEvents Label1 As Label
End Class
