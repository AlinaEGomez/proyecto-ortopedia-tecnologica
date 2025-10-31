<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        TxtContrasena = New TextBox()
        Contraseña = New Label()
        CmbPuesto = New ComboBox()
        BtnModificar = New Button()
        BtnAlta = New Button()
        Label6 = New Label()
        rbtnHombre = New RadioButton()
        rbtnMujer = New RadioButton()
        Label5 = New Label()
        Label4 = New Label()
        TxtDni = New TextBox()
        Label3 = New Label()
        TxtEmail = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        TxtNombre = New TextBox()
        BtnBuscar = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.protesis
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(403, 426)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(BtnBuscar)
        Panel1.Controls.Add(TxtContrasena)
        Panel1.Controls.Add(Contraseña)
        Panel1.Controls.Add(CmbPuesto)
        Panel1.Controls.Add(BtnModificar)
        Panel1.Controls.Add(BtnAlta)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(rbtnHombre)
        Panel1.Controls.Add(rbtnMujer)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(TxtDni)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(TxtEmail)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(TxtNombre)
        Panel1.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0)
        Panel1.Location = New Point(421, 22)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(449, 430)
        Panel1.TabIndex = 1
        ' 
        ' TxtContrasena
        ' 
        TxtContrasena.Location = New Point(226, 159)
        TxtContrasena.Name = "TxtContrasena"
        TxtContrasena.Size = New Size(158, 29)
        TxtContrasena.TabIndex = 18
        ' 
        ' Contraseña
        ' 
        Contraseña.AutoSize = True
        Contraseña.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
        Contraseña.Location = New Point(26, 160)
        Contraseña.Name = "Contraseña"
        Contraseña.Size = New Size(125, 28)
        Contraseña.TabIndex = 17
        Contraseña.Text = "contraseña :"
        ' 
        ' CmbPuesto
        ' 
        CmbPuesto.FormattingEnabled = True
        CmbPuesto.Items.AddRange(New Object() {"Vendedor", "Gerente", "Administrador"})
        CmbPuesto.Location = New Point(227, 323)
        CmbPuesto.Name = "CmbPuesto"
        CmbPuesto.Size = New Size(158, 29)
        CmbPuesto.TabIndex = 14
        ' 
        ' BtnModificar
        ' 
        BtnModificar.Image = My.Resources.Resources.modificacion
        BtnModificar.ImageAlign = ContentAlignment.MiddleLeft
        BtnModificar.Location = New Point(161, 369)
        BtnModificar.Name = "BtnModificar"
        BtnModificar.Size = New Size(125, 44)
        BtnModificar.TabIndex = 13
        BtnModificar.Text = "Modificar"
        BtnModificar.TextAlign = ContentAlignment.MiddleRight
        BtnModificar.UseVisualStyleBackColor = True
        ' 
        ' BtnAlta
        ' 
        BtnAlta.Image = My.Resources.Resources.formulario_de_firma
        BtnAlta.ImageAlign = ContentAlignment.MiddleLeft
        BtnAlta.Location = New Point(33, 369)
        BtnAlta.Name = "BtnAlta"
        BtnAlta.Size = New Size(99, 44)
        BtnAlta.TabIndex = 12
        BtnAlta.Text = "Alta"
        BtnAlta.TextAlign = ContentAlignment.MiddleRight
        BtnAlta.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
        Label6.Location = New Point(23, 322)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 28)
        Label6.TabIndex = 10
        Label6.Text = "Puesto :"
        ' 
        ' rbtnHombre
        ' 
        rbtnHombre.AutoSize = True
        rbtnHombre.Location = New Point(315, 277)
        rbtnHombre.Name = "rbtnHombre"
        rbtnHombre.Size = New Size(85, 25)
        rbtnHombre.TabIndex = 9
        rbtnHombre.Text = "Hombre"
        rbtnHombre.UseVisualStyleBackColor = True
        ' 
        ' rbtnMujer
        ' 
        rbtnMujer.AutoSize = True
        rbtnMujer.Checked = True
        rbtnMujer.Location = New Point(226, 277)
        rbtnMujer.Name = "rbtnMujer"
        rbtnMujer.Size = New Size(69, 25)
        rbtnMujer.TabIndex = 8
        rbtnMujer.TabStop = True
        rbtnMujer.Text = "Mujer"
        rbtnMujer.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
        Label5.Location = New Point(26, 273)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 28)
        Label5.TabIndex = 7
        Label5.Text = "Sexo :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
        Label4.Location = New Point(39, 245)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 28)
        Label4.TabIndex = 6
        ' 
        ' TxtDni
        ' 
        TxtDni.Location = New Point(225, 216)
        TxtDni.Name = "TxtDni"
        TxtDni.Size = New Size(159, 29)
        TxtDni.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
        Label3.Location = New Point(32, 219)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 26)
        Label3.TabIndex = 4
        Label3.Text = "D.N.I :"
        ' 
        ' TxtEmail
        ' 
        TxtEmail.Location = New Point(226, 103)
        TxtEmail.Name = "TxtEmail"
        TxtEmail.Size = New Size(159, 29)
        TxtEmail.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
        Label2.Location = New Point(16, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(173, 26)
        Label2.TabIndex = 2
        Label2.Text = "Correo electronico:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
        Label1.Location = New Point(16, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(170, 26)
        Label1.TabIndex = 1
        Label1.Text = "Nombre y Apellido"
        ' 
        ' TxtNombre
        ' 
        TxtNombre.Location = New Point(226, 52)
        TxtNombre.Name = "TxtNombre"
        TxtNombre.Size = New Size(159, 29)
        TxtNombre.TabIndex = 0
        ' 
        ' BtnBuscar
        ' 
        BtnBuscar.BackgroundImageLayout = ImageLayout.Stretch
        BtnBuscar.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
        BtnBuscar.Image = My.Resources.Resources.buscarUsuario1
        BtnBuscar.ImageAlign = ContentAlignment.MiddleLeft
        BtnBuscar.Location = New Point(315, 369)
        BtnBuscar.Name = "BtnBuscar"
        BtnBuscar.Size = New Size(118, 45)
        BtnBuscar.TabIndex = 19
        BtnBuscar.Text = "Buscar"
        BtnBuscar.TextAlign = ContentAlignment.MiddleRight
        BtnBuscar.UseVisualStyleBackColor = True
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(128, 128, 255)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(882, 450)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Name = "Form6"
        Text = "crud Usuarios"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtDni As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnAlta As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents rbtnMujer As RadioButton
    Friend WithEvents CmbPuesto As ComboBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Contraseña As Label
    Friend WithEvents TxtContrasena As TextBox
    Friend WithEvents R As RadioButton
    Friend WithEvents rbtnHombre As RadioButton
    Friend WithEvents BtnBuscar As Button
End Class
