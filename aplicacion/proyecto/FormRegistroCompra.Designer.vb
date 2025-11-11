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
        BtnCerrar = New Button()
        BtnEliminardetalle = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        CType(DgvDetalleCompra, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbProveedor
        ' 
        cmbProveedor.FormattingEnabled = True
        cmbProveedor.Location = New Point(204, 50)
        cmbProveedor.Margin = New Padding(3, 4, 3, 4)
        cmbProveedor.Name = "cmbProveedor"
        cmbProveedor.Size = New Size(138, 28)
        cmbProveedor.TabIndex = 0
        ' 
        ' cmbProductos
        ' 
        cmbProductos.FormattingEnabled = True
        cmbProductos.Location = New Point(663, 53)
        cmbProductos.Margin = New Padding(3, 4, 3, 4)
        cmbProductos.Name = "cmbProductos"
        cmbProductos.Size = New Size(138, 28)
        cmbProductos.TabIndex = 1
        ' 
        ' DgvDetalleCompra
        ' 
        DgvDetalleCompra.BackgroundColor = Color.Firebrick
        DgvDetalleCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvDetalleCompra.Location = New Point(94, 292)
        DgvDetalleCompra.Margin = New Padding(3, 4, 3, 4)
        DgvDetalleCompra.Name = "DgvDetalleCompra"
        DgvDetalleCompra.RowHeadersWidth = 51
        DgvDetalleCompra.Size = New Size(735, 200)
        DgvDetalleCompra.TabIndex = 2
        ' 
        ' txtCantidad
        ' 
        txtCantidad.Location = New Point(663, 108)
        txtCantidad.Margin = New Padding(3, 4, 3, 4)
        txtCantidad.Name = "txtCantidad"
        txtCantidad.Size = New Size(138, 27)
        txtCantidad.TabIndex = 3
        ' 
        ' txtPrecioCosto
        ' 
        txtPrecioCosto.Location = New Point(663, 161)
        txtPrecioCosto.Margin = New Padding(3, 4, 3, 4)
        txtPrecioCosto.Name = "txtPrecioCosto"
        txtPrecioCosto.Size = New Size(138, 27)
        txtPrecioCosto.TabIndex = 4
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotal.Location = New Point(69, 248)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(69, 27)
        lblTotal.TabIndex = 5
        lblTotal.Text = "Label1"
        ' 
        ' lblUsuarioRegistro
        ' 
        lblUsuarioRegistro.AutoSize = True
        lblUsuarioRegistro.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUsuarioRegistro.Location = New Point(69, 158)
        lblUsuarioRegistro.Name = "lblUsuarioRegistro"
        lblUsuarioRegistro.Size = New Size(69, 27)
        lblUsuarioRegistro.TabIndex = 6
        lblUsuarioRegistro.Text = "Label2"
        ' 
        ' btnAgregarDetalle
        ' 
        btnAgregarDetalle.Location = New Point(643, 248)
        btnAgregarDetalle.Margin = New Padding(3, 4, 3, 4)
        btnAgregarDetalle.Name = "btnAgregarDetalle"
        btnAgregarDetalle.Size = New Size(158, 31)
        btnAgregarDetalle.TabIndex = 7
        btnAgregarDetalle.Text = "Agregar Detalle"
        btnAgregarDetalle.UseVisualStyleBackColor = True
        ' 
        ' btnConfirmarCompra
        ' 
        btnConfirmarCompra.Location = New Point(157, 518)
        btnConfirmarCompra.Margin = New Padding(3, 4, 3, 4)
        btnConfirmarCompra.Name = "btnConfirmarCompra"
        btnConfirmarCompra.Size = New Size(145, 42)
        btnConfirmarCompra.TabIndex = 8
        btnConfirmarCompra.Text = "Confirmar Compra"
        btnConfirmarCompra.UseVisualStyleBackColor = True
        ' 
        ' BtnCerrar
        ' 
        BtnCerrar.Location = New Point(686, 518)
        BtnCerrar.Name = "BtnCerrar"
        BtnCerrar.Size = New Size(105, 42)
        BtnCerrar.TabIndex = 9
        BtnCerrar.Text = "Cerrar"
        BtnCerrar.UseVisualStyleBackColor = True
        ' 
        ' BtnEliminardetalle
        ' 
        BtnEliminardetalle.Location = New Point(448, 250)
        BtnEliminardetalle.Name = "BtnEliminardetalle"
        BtnEliminardetalle.Size = New Size(145, 29)
        BtnEliminardetalle.TabIndex = 10
        BtnEliminardetalle.Text = "Eliminar Detalle"
        BtnEliminardetalle.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(60, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 31)
        Label1.TabIndex = 11
        Label1.Text = "Proveedor"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(501, 102)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 31)
        Label2.TabIndex = 12
        Label2.Text = "Cantidad"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(501, 161)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 31)
        Label3.TabIndex = 13
        Label3.Text = "Precio"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(501, 50)
        Label4.Name = "Label4"
        Label4.Size = New Size(117, 31)
        Label4.TabIndex = 14
        Label4.Text = "Productos"
        ' 
        ' FormRegistroCompra
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.vendedor
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(914, 600)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnEliminardetalle)
        Controls.Add(BtnCerrar)
        Controls.Add(btnConfirmarCompra)
        Controls.Add(btnAgregarDetalle)
        Controls.Add(lblUsuarioRegistro)
        Controls.Add(lblTotal)
        Controls.Add(txtPrecioCosto)
        Controls.Add(txtCantidad)
        Controls.Add(DgvDetalleCompra)
        Controls.Add(cmbProductos)
        Controls.Add(cmbProveedor)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormRegistroCompra"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registro Compra"
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
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnEliminardetalle As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
