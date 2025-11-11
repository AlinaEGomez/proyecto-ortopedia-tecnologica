<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCrudUsuarios
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
        Panel1 = New Panel()
        GroupBoxSexo = New GroupBox()
        Label5 = New Label()
        rbtnMujer = New RadioButton()
        rbtnHombre = New RadioButton()
        BtnLimpiar = New Button()
        BtnBuscar = New Button()
        TxtContrasena = New TextBox()
        Contraseña = New Label()
        CmbPuesto = New ComboBox()
        BtnModificar = New Button()
        BtnCerrar = New Button()
        Label6 = New Label()
        Label4 = New Label()
        TxtDni = New TextBox()
        Label3 = New Label()
        TxtEmail = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        TxtNombre = New TextBox()
        RbtInactivo = New RadioButton()
        RbtActivo = New RadioButton()
        Label8 = New Label()
        DgvUsuarios = New DataGridView()
        GroupBox1 = New GroupBox()
        Panel1.SuspendLayout()
        GroupBoxSexo.SuspendLayout()
        CType(DgvUsuarios, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(GroupBoxSexo)
        Panel1.Controls.Add(BtnLimpiar)
        Panel1.Controls.Add(BtnBuscar)
        Panel1.Controls.Add(TxtContrasena)
        Panel1.Controls.Add(Contraseña)
        Panel1.Controls.Add(CmbPuesto)
        Panel1.Controls.Add(BtnModificar)
        Panel1.Controls.Add(BtnCerrar)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(TxtDni)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(TxtEmail)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(TxtNombre)
        Panel1.Font = New Font("Segoe UI Emoji", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel1.Location = New Point(481, 29)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(513, 573)
        Panel1.TabIndex = 1
        ' 
        ' GroupBoxSexo
        ' 
        GroupBoxSexo.Controls.Add(Label5)
        GroupBoxSexo.Controls.Add(rbtnMujer)
        GroupBoxSexo.Controls.Add(rbtnHombre)
        GroupBoxSexo.Location = New Point(3, 219)
        GroupBoxSexo.Name = "GroupBoxSexo"
        GroupBoxSexo.Size = New Size(504, 68)
        GroupBoxSexo.TabIndex = 24
        GroupBoxSexo.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(15, 20)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 36)
        Label5.TabIndex = 7
        Label5.Text = "Sexo :"
        ' 
        ' rbtnMujer
        ' 
        rbtnMujer.AutoSize = True
        rbtnMujer.Checked = True
        rbtnMujer.Location = New Point(240, 24)
        rbtnMujer.Margin = New Padding(3, 4, 3, 4)
        rbtnMujer.Name = "rbtnMujer"
        rbtnMujer.Size = New Size(84, 31)
        rbtnMujer.TabIndex = 8
        rbtnMujer.TabStop = True
        rbtnMujer.Text = "Mujer"
        rbtnMujer.UseVisualStyleBackColor = True
        ' 
        ' rbtnHombre
        ' 
        rbtnHombre.AutoSize = True
        rbtnHombre.Location = New Point(344, 25)
        rbtnHombre.Margin = New Padding(3, 4, 3, 4)
        rbtnHombre.Name = "rbtnHombre"
        rbtnHombre.Size = New Size(105, 31)
        rbtnHombre.TabIndex = 9
        rbtnHombre.Text = "Hombre"
        rbtnHombre.UseVisualStyleBackColor = True
        ' 
        ' BtnLimpiar
        ' 
        BtnLimpiar.BackgroundImageLayout = ImageLayout.Stretch
        BtnLimpiar.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnLimpiar.ImageAlign = ContentAlignment.MiddleLeft
        BtnLimpiar.Location = New Point(60, 496)
        BtnLimpiar.Margin = New Padding(3, 4, 3, 4)
        BtnLimpiar.Name = "BtnLimpiar"
        BtnLimpiar.Size = New Size(115, 39)
        BtnLimpiar.TabIndex = 23
        BtnLimpiar.Text = "Limpiar"
        BtnLimpiar.TextAlign = ContentAlignment.MiddleRight
        BtnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' BtnBuscar
        ' 
        BtnBuscar.BackgroundImageLayout = ImageLayout.Stretch
        BtnBuscar.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnBuscar.ImageAlign = ContentAlignment.MiddleLeft
        BtnBuscar.Location = New Point(212, 496)
        BtnBuscar.Margin = New Padding(3, 4, 3, 4)
        BtnBuscar.Name = "BtnBuscar"
        BtnBuscar.Size = New Size(115, 39)
        BtnBuscar.TabIndex = 19
        BtnBuscar.Text = "Buscar"
        BtnBuscar.TextAlign = ContentAlignment.MiddleRight
        BtnBuscar.UseVisualStyleBackColor = True
        ' 
        ' TxtContrasena
        ' 
        TxtContrasena.Location = New Point(258, 134)
        TxtContrasena.Margin = New Padding(3, 4, 3, 4)
        TxtContrasena.Name = "TxtContrasena"
        TxtContrasena.Size = New Size(180, 34)
        TxtContrasena.TabIndex = 18
        ' 
        ' Contraseña
        ' 
        Contraseña.AutoSize = True
        Contraseña.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Contraseña.Location = New Point(18, 131)
        Contraseña.Name = "Contraseña"
        Contraseña.Size = New Size(157, 36)
        Contraseña.TabIndex = 17
        Contraseña.Text = "contraseña :"
        ' 
        ' CmbPuesto
        ' 
        CmbPuesto.FormattingEnabled = True
        CmbPuesto.Items.AddRange(New Object() {"Vendedor", "Gerente", "Administrador"})
        CmbPuesto.Location = New Point(257, 294)
        CmbPuesto.Margin = New Padding(3, 4, 3, 4)
        CmbPuesto.Name = "CmbPuesto"
        CmbPuesto.Size = New Size(180, 35)
        CmbPuesto.TabIndex = 14
        ' 
        ' BtnModificar
        ' 
        BtnModificar.Image = My.Resources.Resources.modificacion
        BtnModificar.ImageAlign = ContentAlignment.MiddleLeft
        BtnModificar.Location = New Point(319, 420)
        BtnModificar.Margin = New Padding(3, 4, 3, 4)
        BtnModificar.Name = "BtnModificar"
        BtnModificar.Size = New Size(143, 43)
        BtnModificar.TabIndex = 13
        BtnModificar.Text = "Modificar"
        BtnModificar.TextAlign = ContentAlignment.MiddleRight
        BtnModificar.UseVisualStyleBackColor = True
        ' 
        ' BtnCerrar
        ' 
        BtnCerrar.Image = My.Resources.Resources.formulario_de_firma
        BtnCerrar.ImageAlign = ContentAlignment.MiddleLeft
        BtnCerrar.Location = New Point(360, 492)
        BtnCerrar.Margin = New Padding(3, 4, 3, 4)
        BtnCerrar.Name = "BtnCerrar"
        BtnCerrar.Size = New Size(113, 43)
        BtnCerrar.TabIndex = 12
        BtnCerrar.Text = "Cerrar"
        BtnCerrar.TextAlign = ContentAlignment.MiddleRight
        BtnCerrar.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(18, 291)
        Label6.Name = "Label6"
        Label6.Size = New Size(108, 36)
        Label6.TabIndex = 10
        Label6.Text = "Puesto :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(45, 327)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 36)
        Label4.TabIndex = 6
        ' 
        ' TxtDni
        ' 
        TxtDni.Location = New Point(257, 182)
        TxtDni.Margin = New Padding(3, 4, 3, 4)
        TxtDni.Name = "TxtDni"
        TxtDni.Size = New Size(181, 34)
        TxtDni.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(18, 184)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 32)
        Label3.TabIndex = 4
        Label3.Text = "D.N.I :"
        ' 
        ' TxtEmail
        ' 
        TxtEmail.Location = New Point(257, 83)
        TxtEmail.Margin = New Padding(3, 4, 3, 4)
        TxtEmail.Name = "TxtEmail"
        TxtEmail.Size = New Size(181, 34)
        TxtEmail.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(18, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(216, 32)
        Label2.TabIndex = 2
        Label2.Text = "Correo electronico:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(18, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(216, 32)
        Label1.TabIndex = 1
        Label1.Text = "Nombre y Apellido"
        ' 
        ' TxtNombre
        ' 
        TxtNombre.Location = New Point(257, 24)
        TxtNombre.Margin = New Padding(3, 4, 3, 4)
        TxtNombre.Name = "TxtNombre"
        TxtNombre.Size = New Size(181, 34)
        TxtNombre.TabIndex = 0
        ' 
        ' RbtInactivo
        ' 
        RbtInactivo.AutoSize = True
        RbtInactivo.Location = New Point(347, 26)
        RbtInactivo.Name = "RbtInactivo"
        RbtInactivo.Size = New Size(82, 24)
        RbtInactivo.TabIndex = 22
        RbtInactivo.TabStop = True
        RbtInactivo.Text = "Inactivo"
        RbtInactivo.UseVisualStyleBackColor = True
        ' 
        ' RbtActivo
        ' 
        RbtActivo.AutoSize = True
        RbtActivo.Location = New Point(238, 27)
        RbtActivo.Name = "RbtActivo"
        RbtActivo.Size = New Size(72, 24)
        RbtActivo.TabIndex = 21
        RbtActivo.TabStop = True
        RbtActivo.Text = "Activo"
        RbtActivo.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(0, 23)
        Label8.Name = "Label8"
        Label8.Size = New Size(108, 36)
        Label8.TabIndex = 20
        Label8.Text = "Estado :"
        ' 
        ' DgvUsuarios
        ' 
        DgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvUsuarios.Location = New Point(26, 34)
        DgvUsuarios.Name = "DgvUsuarios"
        DgvUsuarios.RowHeadersWidth = 51
        DgvUsuarios.Size = New Size(431, 547)
        DgvUsuarios.TabIndex = 2
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(RbtActivo)
        GroupBox1.Controls.Add(RbtInactivo)
        GroupBox1.Location = New Point(481, 356)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(507, 68)
        GroupBox1.TabIndex = 25
        GroupBox1.TabStop = False
        ' 
        ' FormCrudUsuarios
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1008, 600)
        Controls.Add(GroupBox1)
        Controls.Add(DgvUsuarios)
        Controls.Add(Panel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormCrudUsuarios"
        StartPosition = FormStartPosition.CenterScreen
        Text = "crud Usuarios"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBoxSexo.ResumeLayout(False)
        GroupBoxSexo.PerformLayout()
        CType(DgvUsuarios, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub
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
    Friend WithEvents BtnCerrar As Button
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
    Friend WithEvents DgvUsuarios As DataGridView
    Friend WithEvents RbtActivo As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents RbtInactivo As RadioButton
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents GroupBoxSexo As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
