<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClientes
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtRazonSocial = New TextBox()
        txtCuit = New TextBox()
        txtTelefono = New TextBox()
        txtEmail = New TextBox()
        DgvClientes = New DataGridView()
        btnGuardar = New Button()
        btnEliminar = New Button()
        btnLimpiar = New Button()
        btnClientesInactivos = New Button()
        CType(DgvClientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(88, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 15)
        Label1.TabIndex = 0
        Label1.Text = "Razon  Social:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(88, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 15)
        Label2.TabIndex = 1
        Label2.Text = "Cuit/Cuil"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(88, 131)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 15)
        Label3.TabIndex = 2
        Label3.Text = "Telefono"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(88, 177)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 15)
        Label4.TabIndex = 3
        Label4.Text = "Email"
        ' 
        ' txtRazonSocial
        ' 
        txtRazonSocial.Location = New Point(191, 36)
        txtRazonSocial.Name = "txtRazonSocial"
        txtRazonSocial.Size = New Size(100, 23)
        txtRazonSocial.TabIndex = 4
        ' 
        ' txtCuit
        ' 
        txtCuit.Location = New Point(191, 79)
        txtCuit.Name = "txtCuit"
        txtCuit.Size = New Size(100, 23)
        txtCuit.TabIndex = 5
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(191, 123)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(100, 23)
        txtTelefono.TabIndex = 6
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(191, 177)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(100, 23)
        txtEmail.TabIndex = 7
        ' 
        ' DgvClientes
        ' 
        DgvClientes.BackgroundColor = Color.RosyBrown
        DgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvClientes.Location = New Point(88, 255)
        DgvClientes.Name = "DgvClientes"
        DgvClientes.Size = New Size(599, 150)
        DgvClientes.TabIndex = 8
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.White
        btnGuardar.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnGuardar.ForeColor = Color.RosyBrown
        btnGuardar.Location = New Point(453, 36)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(97, 36)
        btnGuardar.TabIndex = 9
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.White
        btnEliminar.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEliminar.ForeColor = Color.RosyBrown
        btnEliminar.Location = New Point(605, 39)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(100, 33)
        btnEliminar.TabIndex = 10
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.BackColor = Color.White
        btnLimpiar.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLimpiar.ForeColor = Color.RosyBrown
        btnLimpiar.Location = New Point(453, 78)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(97, 37)
        btnLimpiar.TabIndex = 11
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = False
        ' 
        ' btnClientesInactivos
        ' 
        btnClientesInactivos.BackColor = Color.White
        btnClientesInactivos.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClientesInactivos.ForeColor = Color.RosyBrown
        btnClientesInactivos.Location = New Point(588, 82)
        btnClientesInactivos.Name = "btnClientesInactivos"
        btnClientesInactivos.Size = New Size(174, 33)
        btnClientesInactivos.TabIndex = 12
        btnClientesInactivos.Text = "Clientes Inactivos"
        btnClientesInactivos.UseVisualStyleBackColor = False
        ' 
        ' FormClientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.clientes22
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(btnClientesInactivos)
        Controls.Add(btnLimpiar)
        Controls.Add(btnEliminar)
        Controls.Add(btnGuardar)
        Controls.Add(DgvClientes)
        Controls.Add(txtEmail)
        Controls.Add(txtTelefono)
        Controls.Add(txtCuit)
        Controls.Add(txtRazonSocial)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FormClientes"
        Text = "Clientes"
        CType(DgvClientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRazonSocial As TextBox
    Friend WithEvents txtCuit As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents DgvClientes As DataGridView
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnClientesInactivos As Button
End Class
