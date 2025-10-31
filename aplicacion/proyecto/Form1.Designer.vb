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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        BtnIngresar = New Button()
        BtnCancelar = New Button()
        LUsuario = New Label()
        TxtEmail = New TextBox()
        LContraseña = New Label()
        TxtContraseña = New TextBox()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnIngresar
        ' 
        BtnIngresar.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        BtnIngresar.Image = My.Resources.Resources.ingresar_sesion
        BtnIngresar.ImageAlign = ContentAlignment.MiddleLeft
        BtnIngresar.Location = New Point(530, 382)
        BtnIngresar.Name = "BtnIngresar"
        BtnIngresar.Size = New Size(94, 37)
        BtnIngresar.TabIndex = 0
        BtnIngresar.Text = "Ingresar"
        BtnIngresar.TextAlign = ContentAlignment.MiddleRight
        BtnIngresar.UseVisualStyleBackColor = False
        ' 
        ' BtnCancelar
        ' 
        BtnCancelar.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        BtnCancelar.Image = My.Resources.Resources.borrar
        BtnCancelar.ImageAlign = ContentAlignment.MiddleLeft
        BtnCancelar.Location = New Point(646, 382)
        BtnCancelar.Name = "BtnCancelar"
        BtnCancelar.Size = New Size(88, 37)
        BtnCancelar.TabIndex = 1
        BtnCancelar.Text = "Cancelar"
        BtnCancelar.TextAlign = ContentAlignment.MiddleRight
        BtnCancelar.UseVisualStyleBackColor = False
        ' 
        ' LUsuario
        ' 
        LUsuario.Anchor = AnchorStyles.None
        LUsuario.AutoSize = True
        LUsuario.BackColor = Color.Transparent
        LUsuario.CausesValidation = False
        LUsuario.Font = New Font("Segoe UI Symbol", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LUsuario.ForeColor = Color.White
        LUsuario.Location = New Point(548, 56)
        LUsuario.Name = "LUsuario"
        LUsuario.Size = New Size(90, 32)
        LUsuario.TabIndex = 2
        LUsuario.Text = "Email :"
        ' 
        ' TxtEmail
        ' 
        TxtEmail.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtEmail.Location = New Point(475, 103)
        TxtEmail.Multiline = True
        TxtEmail.Name = "TxtEmail"
        TxtEmail.Size = New Size(290, 35)
        TxtEmail.TabIndex = 3
        ' 
        ' LContraseña
        ' 
        LContraseña.Anchor = AnchorStyles.None
        LContraseña.AutoSize = True
        LContraseña.BackColor = Color.Transparent
        LContraseña.Font = New Font("Segoe UI Symbol", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LContraseña.ForeColor = Color.White
        LContraseña.Location = New Point(548, 168)
        LContraseña.Name = "LContraseña"
        LContraseña.Size = New Size(158, 32)
        LContraseña.TabIndex = 4
        LContraseña.Text = "Contraseña :"
        ' 
        ' TxtContraseña
        ' 
        TxtContraseña.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtContraseña.Location = New Point(475, 234)
        TxtContraseña.Multiline = True
        TxtContraseña.Name = "TxtContraseña"
        TxtContraseña.PasswordChar = "*"c
        TxtContraseña.Size = New Size(290, 35)
        TxtContraseña.TabIndex = 5
        TxtContraseña.TextAlign = HorizontalAlignment.Center
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.ErrorImage = My.Resources.Resources.images
        PictureBox1.InitialImage = My.Resources.Resources.images
        PictureBox1.Location = New Point(35, -3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(419, 452)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.PowderBlue
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(TxtContraseña)
        Controls.Add(LContraseña)
        Controls.Add(TxtEmail)
        Controls.Add(LUsuario)
        Controls.Add(BtnCancelar)
        Controls.Add(BtnIngresar)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Iniciar sesion"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnIngresar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents LUsuario As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents LContraseña As Label
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents PictureBox1 As PictureBox

End Class
