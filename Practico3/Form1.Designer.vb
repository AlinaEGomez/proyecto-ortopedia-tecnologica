<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PequeñoFormulario
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
        LNombreyApellido = New Label()
        LModificar = New Label()
        LDni = New Label()
        LApellido = New Label()
        LNombre = New Label()
        BGuardar = New Button()
        BEliminar = New Button()
        TDni = New TextBox()
        TApellido = New TextBox()
        TNombre = New TextBox()
        Panel1 = New Panel()
        CBVisa = New CheckBox()
        CBMastercard = New CheckBox()
        CBNaranja = New CheckBox()
        Label2 = New Label()
        TTelefono = New TextBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        RBVaron = New RadioButton()
        RBMujer = New RadioButton()
        BSalir = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LNombreyApellido
        ' 
        LNombreyApellido.AutoSize = True
        LNombreyApellido.Location = New Point(19, 25)
        LNombreyApellido.Name = "LNombreyApellido"
        LNombreyApellido.Size = New Size(107, 15)
        LNombreyApellido.TabIndex = 0
        LNombreyApellido.Text = "Nombre y Apellido"
        ' 
        ' LModificar
        ' 
        LModificar.AutoSize = True
        LModificar.ForeColor = Color.Red
        LModificar.Location = New Point(158, 25)
        LModificar.Name = "LModificar"
        LModificar.Size = New Size(58, 15)
        LModificar.TabIndex = 1
        LModificar.Text = "Modificar"
        ' 
        ' LDni
        ' 
        LDni.AutoSize = True
        LDni.Location = New Point(19, 65)
        LDni.Name = "LDni"
        LDni.Size = New Size(27, 15)
        LDni.TabIndex = 2
        LDni.Text = "DNI"
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.Location = New Point(17, 113)
        LApellido.Name = "LApellido"
        LApellido.Size = New Size(51, 15)
        LApellido.TabIndex = 3
        LApellido.Text = "Apellido"
        ' 
        ' LNombre
        ' 
        LNombre.AutoSize = True
        LNombre.Location = New Point(17, 172)
        LNombre.Name = "LNombre"
        LNombre.Size = New Size(51, 15)
        LNombre.TabIndex = 4
        LNombre.Text = "Nombre"
        ' 
        ' BGuardar
        ' 
        BGuardar.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        BGuardar.Image = My.Resources.Resources.carpeta
        BGuardar.ImageAlign = ContentAlignment.MiddleLeft
        BGuardar.Location = New Point(30, 385)
        BGuardar.Name = "BGuardar"
        BGuardar.Size = New Size(98, 37)
        BGuardar.TabIndex = 5
        BGuardar.Text = "Guardar"
        BGuardar.TextAlign = ContentAlignment.MiddleRight
        BGuardar.UseVisualStyleBackColor = False
        ' 
        ' BEliminar
        ' 
        BEliminar.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        BEliminar.Image = My.Resources.Resources.basura
        BEliminar.ImageAlign = ContentAlignment.MiddleLeft
        BEliminar.Location = New Point(164, 385)
        BEliminar.Name = "BEliminar"
        BEliminar.Size = New Size(96, 37)
        BEliminar.TabIndex = 6
        BEliminar.Text = "Eliminar"
        BEliminar.TextAlign = ContentAlignment.MiddleRight
        BEliminar.UseVisualStyleBackColor = False
        ' 
        ' TDni
        ' 
        TDni.Location = New Point(116, 62)
        TDni.Name = "TDni"
        TDni.Size = New Size(100, 23)
        TDni.TabIndex = 7
        ' 
        ' TApellido
        ' 
        TApellido.Location = New Point(116, 110)
        TApellido.Name = "TApellido"
        TApellido.Size = New Size(100, 23)
        TApellido.TabIndex = 8
        ' 
        ' TNombre
        ' 
        TNombre.Location = New Point(116, 172)
        TNombre.Name = "TNombre"
        TNombre.Size = New Size(100, 23)
        TNombre.TabIndex = 9
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(CBVisa)
        Panel1.Controls.Add(CBMastercard)
        Panel1.Controls.Add(CBNaranja)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(TTelefono)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(LNombreyApellido)
        Panel1.Controls.Add(TNombre)
        Panel1.Controls.Add(LModificar)
        Panel1.Controls.Add(LNombre)
        Panel1.Controls.Add(TApellido)
        Panel1.Controls.Add(LDni)
        Panel1.Controls.Add(TDni)
        Panel1.Controls.Add(LApellido)
        Panel1.Location = New Point(27, 31)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(271, 348)
        Panel1.TabIndex = 10
        ' 
        ' CBVisa
        ' 
        CBVisa.AutoSize = True
        CBVisa.Location = New Point(141, 305)
        CBVisa.Name = "CBVisa"
        CBVisa.Size = New Size(47, 19)
        CBVisa.TabIndex = 15
        CBVisa.Text = "Visa"
        CBVisa.UseVisualStyleBackColor = True
        ' 
        ' CBMastercard
        ' 
        CBMastercard.AutoSize = True
        CBMastercard.Location = New Point(141, 280)
        CBMastercard.Name = "CBMastercard"
        CBMastercard.Size = New Size(85, 19)
        CBMastercard.TabIndex = 14
        CBMastercard.Text = "Mastercard"
        CBMastercard.UseVisualStyleBackColor = True
        ' 
        ' CBNaranja
        ' 
        CBNaranja.AutoSize = True
        CBNaranja.Location = New Point(142, 258)
        CBNaranja.Name = "CBNaranja"
        CBNaranja.Size = New Size(67, 19)
        CBNaranja.TabIndex = 13
        CBNaranja.Text = "Naranja"
        CBNaranja.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(19, 275)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 15)
        Label2.TabIndex = 12
        Label2.Text = "Tarjetas de credito"
        ' 
        ' TTelefono
        ' 
        TTelefono.Location = New Point(116, 220)
        TTelefono.Name = "TTelefono"
        TTelefono.Size = New Size(100, 23)
        TTelefono.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(17, 228)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 15)
        Label1.TabIndex = 10
        Label1.Text = "Telefono"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        PictureBox1.Image = My.Resources.Resources.hombre
        PictureBox1.Location = New Point(369, 31)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 69)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' RBVaron
        ' 
        RBVaron.AutoSize = True
        RBVaron.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        RBVaron.Location = New Point(369, 140)
        RBVaron.Name = "RBVaron"
        RBVaron.Size = New Size(55, 19)
        RBVaron.TabIndex = 12
        RBVaron.TabStop = True
        RBVaron.Text = "Varon"
        RBVaron.UseVisualStyleBackColor = False
        ' 
        ' RBMujer
        ' 
        RBMujer.AutoSize = True
        RBMujer.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        RBMujer.Location = New Point(369, 184)
        RBMujer.Name = "RBMujer"
        RBMujer.Size = New Size(56, 19)
        RBMujer.TabIndex = 13
        RBMujer.TabStop = True
        RBMujer.Text = "Mujer"
        RBMujer.UseVisualStyleBackColor = False
        ' 
        ' BSalir
        ' 
        BSalir.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        BSalir.Image = My.Resources.Resources.salida
        BSalir.ImageAlign = ContentAlignment.MiddleLeft
        BSalir.Location = New Point(369, 385)
        BSalir.Name = "BSalir"
        BSalir.Size = New Size(92, 37)
        BSalir.TabIndex = 14
        BSalir.Text = "Salir"
        BSalir.UseVisualStyleBackColor = False
        ' 
        ' PequeñoFormulario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        ClientSize = New Size(508, 450)
        Controls.Add(BSalir)
        Controls.Add(RBMujer)
        Controls.Add(RBVaron)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Controls.Add(BEliminar)
        Controls.Add(BGuardar)
        Name = "PequeñoFormulario"
        Text = "Pequeño Formulario"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LNombreyApellido As Label
    Friend WithEvents LModificar As Label
    Friend WithEvents LDni As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents BGuardar As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents TDni As TextBox
    Friend WithEvents TApellido As TextBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TTelefono As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CBVisa As CheckBox
    Friend WithEvents CBMastercard As CheckBox
    Friend WithEvents C As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RBVaron As RadioButton
    Friend WithEvents RBMujer As RadioButton
    Friend WithEvents BSalir As Button
    Friend WithEvents CBNaranja As CheckBox

End Class
