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
        BtnIngresar = New Button()
        BtnCancelar = New Button()
        LUsuario = New Label()
        TxtUsuario = New TextBox()
        LContraseña = New Label()
        TxtContraseña = New TextBox()
        SuspendLayout()
        ' 
        ' BtnIngresar
        ' 
        BtnIngresar.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        BtnIngresar.Image = My.Resources.Resources.ingresar_sesion
        BtnIngresar.ImageAlign = ContentAlignment.MiddleLeft
        BtnIngresar.Location = New Point(427, 382)
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
        BtnCancelar.Location = New Point(604, 382)
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
        LUsuario.Font = New Font("Segoe UI Symbol", 18.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LUsuario.ForeColor = Color.White
        LUsuario.Location = New Point(548, 56)
        LUsuario.Name = "LUsuario"
        LUsuario.Size = New Size(115, 32)
        LUsuario.TabIndex = 2
        LUsuario.Text = "Usuario :"
        ' 
        ' TxtUsuario
        ' 
        TxtUsuario.Font = New Font("MingLiU-ExtB", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TxtUsuario.Location = New Point(548, 103)
        TxtUsuario.Multiline = True
        TxtUsuario.Name = "TxtUsuario"
        TxtUsuario.Size = New Size(195, 42)
        TxtUsuario.TabIndex = 3
        ' 
        ' LContraseña
        ' 
        LContraseña.Anchor = AnchorStyles.None
        LContraseña.AutoSize = True
        LContraseña.BackColor = Color.Transparent
        LContraseña.Font = New Font("Segoe UI Symbol", 18.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LContraseña.ForeColor = Color.White
        LContraseña.Location = New Point(548, 168)
        LContraseña.Name = "LContraseña"
        LContraseña.Size = New Size(158, 32)
        LContraseña.TabIndex = 4
        LContraseña.Text = "Contraseña :"
        ' 
        ' TxtContraseña
        ' 
        TxtContraseña.Font = New Font("MV Boli", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TxtContraseña.Location = New Point(548, 234)
        TxtContraseña.Multiline = True
        TxtContraseña.Name = "TxtContraseña"
        TxtContraseña.PasswordChar = "*"c
        TxtContraseña.Size = New Size(195, 38)
        TxtContraseña.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.PowderBlue
        BackgroundImage = My.Resources.Resources.inicio_sesion
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(TxtContraseña)
        Controls.Add(LContraseña)
        Controls.Add(TxtUsuario)
        Controls.Add(LUsuario)
        Controls.Add(BtnCancelar)
        Controls.Add(BtnIngresar)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Iniciar sesion"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnIngresar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents LUsuario As Label
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents LContraseña As Label
    Friend WithEvents TxtContraseña As TextBox

End Class
