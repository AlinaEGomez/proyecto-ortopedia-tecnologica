<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProveedores
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
        txtRazonSocial = New TextBox()
        txtCuit = New TextBox()
        txtContactoNombre = New TextBox()
        txtTelefono = New TextBox()
        txtEmail = New TextBox()
        btnGuardar = New Button()
        btnEliminar = New Button()
        btnLimpiar = New Button()
        DgvProveedores = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btnProveedoresInactivos = New Button()
        CType(DgvProveedores, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtRazonSocial
        ' 
        txtRazonSocial.Location = New Point(197, 36)
        txtRazonSocial.Name = "txtRazonSocial"
        txtRazonSocial.Size = New Size(100, 23)
        txtRazonSocial.TabIndex = 0
        ' 
        ' txtCuit
        ' 
        txtCuit.Location = New Point(161, 102)
        txtCuit.Name = "txtCuit"
        txtCuit.Size = New Size(100, 23)
        txtCuit.TabIndex = 1
        ' 
        ' txtContactoNombre
        ' 
        txtContactoNombre.Location = New Point(188, 186)
        txtContactoNombre.Name = "txtContactoNombre"
        txtContactoNombre.Size = New Size(100, 23)
        txtContactoNombre.TabIndex = 2
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(487, 33)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(100, 23)
        txtTelefono.TabIndex = 3
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(487, 145)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(100, 23)
        txtEmail.TabIndex = 4
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnGuardar.Location = New Point(634, 24)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(119, 35)
        btnGuardar.TabIndex = 5
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEliminar.Location = New Point(639, 81)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(119, 35)
        btnEliminar.TabIndex = 6
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLimpiar.Location = New Point(639, 130)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(119, 38)
        btnLimpiar.TabIndex = 7
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' DgvProveedores
        ' 
        DgvProveedores.BackgroundColor = Color.Firebrick
        DgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvProveedores.GridColor = Color.White
        DgvProveedores.Location = New Point(46, 245)
        DgvProveedores.Name = "DgvProveedores"
        DgvProveedores.Size = New Size(707, 150)
        DgvProveedores.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(23, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(135, 28)
        Label1.TabIndex = 9
        Label1.Text = "Razon Social:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(23, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 28)
        Label2.TabIndex = 10
        Label2.Text = "Cuil/Cuit"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(23, 186)
        Label3.Name = "Label3"
        Label3.Size = New Size(135, 28)
        Label3.TabIndex = 11
        Label3.Text = "Nombre Prov"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(354, 31)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 28)
        Label4.TabIndex = 12
        Label4.Text = "Telefono"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(354, 154)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 28)
        Label5.TabIndex = 13
        Label5.Text = "Email"
        ' 
        ' btnProveedoresInactivos
        ' 
        btnProveedoresInactivos.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnProveedoresInactivos.Location = New Point(639, 188)
        btnProveedoresInactivos.Name = "btnProveedoresInactivos"
        btnProveedoresInactivos.Size = New Size(119, 43)
        btnProveedoresInactivos.TabIndex = 14
        btnProveedoresInactivos.Text = "Inactivos"
        btnProveedoresInactivos.UseVisualStyleBackColor = True
        ' 
        ' FormProveedores
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.proveedor2
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(btnProveedoresInactivos)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DgvProveedores)
        Controls.Add(btnLimpiar)
        Controls.Add(btnEliminar)
        Controls.Add(btnGuardar)
        Controls.Add(txtEmail)
        Controls.Add(txtTelefono)
        Controls.Add(txtContactoNombre)
        Controls.Add(txtCuit)
        Controls.Add(txtRazonSocial)
        Name = "FormProveedores"
        Text = "Proveedores"
        CType(DgvProveedores, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtRazonSocial As TextBox
    Friend WithEvents txtCuit As TextBox
    Friend WithEvents txtContactoNombre As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents DgvProveedores As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnProveedoresInactivos As Button
End Class
