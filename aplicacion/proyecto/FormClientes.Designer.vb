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
        Button1 = New Button()
        CType(DgvClientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(80, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(153, 31)
        Label1.TabIndex = 0
        Label1.Text = "Razon  Social:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(456, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 31)
        Label2.TabIndex = 1
        Label2.Text = "Cuit/Cuil"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(81, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 31)
        Label3.TabIndex = 2
        Label3.Text = "Telefono"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(456, 107)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 31)
        Label4.TabIndex = 3
        Label4.Text = "Email"
        ' 
        ' txtRazonSocial
        ' 
        txtRazonSocial.Location = New Point(266, 57)
        txtRazonSocial.Margin = New Padding(3, 4, 3, 4)
        txtRazonSocial.Name = "txtRazonSocial"
        txtRazonSocial.Size = New Size(114, 27)
        txtRazonSocial.TabIndex = 4
        ' 
        ' txtCuit
        ' 
        txtCuit.Location = New Point(611, 61)
        txtCuit.Margin = New Padding(3, 4, 3, 4)
        txtCuit.Name = "txtCuit"
        txtCuit.Size = New Size(114, 27)
        txtCuit.TabIndex = 5
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(266, 113)
        txtTelefono.Margin = New Padding(3, 4, 3, 4)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(114, 27)
        txtTelefono.TabIndex = 6
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(611, 107)
        txtEmail.Margin = New Padding(3, 4, 3, 4)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(114, 27)
        txtEmail.TabIndex = 7
        ' 
        ' DgvClientes
        ' 
        DgvClientes.BackgroundColor = Color.RosyBrown
        DgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvClientes.Location = New Point(101, 307)
        DgvClientes.Margin = New Padding(3, 4, 3, 4)
        DgvClientes.Name = "DgvClientes"
        DgvClientes.RowHeadersWidth = 51
        DgvClientes.Size = New Size(685, 200)
        DgvClientes.TabIndex = 8
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.White
        btnGuardar.Font = New Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnGuardar.ForeColor = Color.Black
        btnGuardar.Location = New Point(651, 211)
        btnGuardar.Margin = New Padding(3, 4, 3, 4)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(111, 48)
        btnGuardar.TabIndex = 9
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.White
        btnEliminar.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEliminar.ForeColor = Color.Black
        btnEliminar.Location = New Point(395, 215)
        btnEliminar.Margin = New Padding(3, 4, 3, 4)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(114, 44)
        btnEliminar.TabIndex = 10
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.BackColor = Color.White
        btnLimpiar.Font = New Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLimpiar.ForeColor = Color.Black
        btnLimpiar.Location = New Point(122, 215)
        btnLimpiar.Margin = New Padding(3, 4, 3, 4)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(111, 49)
        btnLimpiar.TabIndex = 11
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = False
        ' 
        ' btnClientesInactivos
        ' 
        btnClientesInactivos.BackColor = Color.White
        btnClientesInactivos.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClientesInactivos.ForeColor = Color.Black
        btnClientesInactivos.Location = New Point(134, 530)
        btnClientesInactivos.Margin = New Padding(3, 4, 3, 4)
        btnClientesInactivos.Name = "btnClientesInactivos"
        btnClientesInactivos.Size = New Size(236, 44)
        btnClientesInactivos.TabIndex = 12
        btnClientesInactivos.Text = "Clientes Inactivos"
        btnClientesInactivos.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(633, 525)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(111, 49)
        Button1.TabIndex = 13
        Button1.Text = "Cerrar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' FormClientes
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.vendedor
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(914, 600)
        Controls.Add(Button1)
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
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormClientes"
        StartPosition = FormStartPosition.CenterScreen
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
    Friend WithEvents Button1 As Button
End Class
