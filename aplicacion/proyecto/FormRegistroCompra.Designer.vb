<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistroCompra
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
        cmbProveedor = New ComboBox()
        cmbProductos = New ComboBox()
        DgvDetalleCompra = New DataGridView()
        txtCantidad = New TextBox()
        txtPrecioCosto = New TextBox()
        lblTotal = New Label()
        lblUsuarioRegistro = New Label()
        btnAgregarDetalle = New Button()
        btnConfirmarCompra = New Button()
        CType(DgvDetalleCompra, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbProveedor
        ' 
        cmbProveedor.FormattingEnabled = True
        cmbProveedor.Location = New Point(509, 35)
        cmbProveedor.Name = "cmbProveedor"
        cmbProveedor.Size = New Size(121, 23)
        cmbProveedor.TabIndex = 0
        ' 
        ' cmbProductos
        ' 
        cmbProductos.FormattingEnabled = True
        cmbProductos.Location = New Point(509, 121)
        cmbProductos.Name = "cmbProductos"
        cmbProductos.Size = New Size(121, 23)
        cmbProductos.TabIndex = 1
        ' 
        ' DgvDetalleCompra
        ' 
        DgvDetalleCompra.BackgroundColor = Color.Firebrick
        DgvDetalleCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvDetalleCompra.Location = New Point(129, 219)
        DgvDetalleCompra.Name = "DgvDetalleCompra"
        DgvDetalleCompra.Size = New Size(567, 150)
        DgvDetalleCompra.TabIndex = 2
        ' 
        ' txtCantidad
        ' 
        txtCantidad.Location = New Point(161, 35)
        txtCantidad.Name = "txtCantidad"
        txtCantidad.Size = New Size(100, 23)
        txtCantidad.TabIndex = 3
        ' 
        ' txtPrecioCosto
        ' 
        txtPrecioCosto.Location = New Point(161, 121)
        txtPrecioCosto.Name = "txtPrecioCosto"
        txtPrecioCosto.Size = New Size(100, 23)
        txtPrecioCosto.TabIndex = 4
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(366, 35)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(41, 15)
        lblTotal.TabIndex = 5
        lblTotal.Text = "Label1"
        ' 
        ' lblUsuarioRegistro
        ' 
        lblUsuarioRegistro.AutoSize = True
        lblUsuarioRegistro.Location = New Point(355, 121)
        lblUsuarioRegistro.Name = "lblUsuarioRegistro"
        lblUsuarioRegistro.Size = New Size(41, 15)
        lblUsuarioRegistro.TabIndex = 6
        lblUsuarioRegistro.Text = "Label2"
        ' 
        ' btnAgregarDetalle
        ' 
        btnAgregarDetalle.Location = New Point(492, 190)
        btnAgregarDetalle.Name = "btnAgregarDetalle"
        btnAgregarDetalle.Size = New Size(138, 23)
        btnAgregarDetalle.TabIndex = 7
        btnAgregarDetalle.Text = "Agregar Detalle"
        btnAgregarDetalle.UseVisualStyleBackColor = True
        ' 
        ' btnConfirmarCompra
        ' 
        btnConfirmarCompra.Location = New Point(139, 173)
        btnConfirmarCompra.Name = "btnConfirmarCompra"
        btnConfirmarCompra.Size = New Size(122, 23)
        btnConfirmarCompra.TabIndex = 8
        btnConfirmarCompra.Text = "Confirmar Compra"
        btnConfirmarCompra.UseVisualStyleBackColor = True
        ' 
        ' FormRegistroCompra
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.nueva
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(btnConfirmarCompra)
        Controls.Add(btnAgregarDetalle)
        Controls.Add(lblUsuarioRegistro)
        Controls.Add(lblTotal)
        Controls.Add(txtPrecioCosto)
        Controls.Add(txtCantidad)
        Controls.Add(DgvDetalleCompra)
        Controls.Add(cmbProductos)
        Controls.Add(cmbProveedor)
        Name = "FormRegistroCompra"
        Text = "FormRegistroCompra"
        CType(DgvDetalleCompra, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbProveedor As ComboBox
    Friend WithEvents cmbProductos As ComboBox
    Friend WithEvents DgvDetalleCompra As DataGridView
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtPrecioCosto As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblUsuarioRegistro As Label
    Friend WithEvents btnAgregarDetalle As Button
    Friend WithEvents btnConfirmarCompra As Button
End Class
