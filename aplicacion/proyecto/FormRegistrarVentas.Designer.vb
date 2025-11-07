<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegistarVentas

    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        cmbProductos = New ComboBox()
        txtPrecio = New TextBox()
        txtCantidad = New TextBox()
        btnAgregar = New Button()
        btnQuitar = New Button()
        DgvDetalle = New DataGridView()
        btnConfirmarVenta = New Button()
        btnCancelar = New Button()
        lblTotal = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        CType(DgvDetalle, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbProductos
        ' 
        cmbProductos.FormattingEnabled = True
        cmbProductos.Location = New Point(181, 38)
        cmbProductos.Name = "cmbProductos"
        cmbProductos.Size = New Size(121, 23)
        cmbProductos.TabIndex = 0
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(202, 82)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(100, 23)
        txtPrecio.TabIndex = 1
        ' 
        ' txtCantidad
        ' 
        txtCantidad.Location = New Point(202, 140)
        txtCantidad.Name = "txtCantidad"
        txtCantidad.Size = New Size(100, 23)
        txtCantidad.TabIndex = 2
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackgroundImage = My.Resources.Resources.agregar
        btnAgregar.BackgroundImageLayout = ImageLayout.None
        btnAgregar.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAgregar.ImageAlign = ContentAlignment.MiddleRight
        btnAgregar.Location = New Point(453, 21)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(130, 40)
        btnAgregar.TabIndex = 3
        btnAgregar.Text = "Agregar"
        btnAgregar.TextAlign = ContentAlignment.MiddleRight
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' btnQuitar
        ' 
        btnQuitar.BackgroundImage = My.Resources.Resources.quitar
        btnQuitar.BackgroundImageLayout = ImageLayout.None
        btnQuitar.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnQuitar.Image = My.Resources.Resources.quitar1
        btnQuitar.ImageAlign = ContentAlignment.MiddleLeft
        btnQuitar.Location = New Point(614, 21)
        btnQuitar.Name = "btnQuitar"
        btnQuitar.Size = New Size(124, 44)
        btnQuitar.TabIndex = 4
        btnQuitar.Text = "Eliminar"
        btnQuitar.TextAlign = ContentAlignment.MiddleRight
        btnQuitar.UseVisualStyleBackColor = True
        ' 
        ' DgvDetalle
        ' 
        DgvDetalle.AllowUserToOrderColumns = True
        DgvDetalle.BackgroundColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        DgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvDetalle.Location = New Point(111, 232)
        DgvDetalle.Name = "DgvDetalle"
        DgvDetalle.Size = New Size(560, 166)
        DgvDetalle.TabIndex = 5
        ' 
        ' btnConfirmarVenta
        ' 
        btnConfirmarVenta.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnConfirmarVenta.Image = My.Resources.Resources.confirmar
        btnConfirmarVenta.ImageAlign = ContentAlignment.MiddleLeft
        btnConfirmarVenta.Location = New Point(145, 404)
        btnConfirmarVenta.Name = "btnConfirmarVenta"
        btnConfirmarVenta.Size = New Size(203, 44)
        btnConfirmarVenta.TabIndex = 6
        btnConfirmarVenta.Text = "Confirmar Ventas"
        btnConfirmarVenta.TextAlign = ContentAlignment.MiddleRight
        btnConfirmarVenta.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancelar.Image = My.Resources.Resources.cancelar
        btnCancelar.ImageAlign = ContentAlignment.MiddleLeft
        btnCancelar.Location = New Point(453, 404)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(198, 44)
        btnCancelar.TabIndex = 7
        btnCancelar.Text = "Cancelar Venta"
        btnCancelar.TextAlign = ContentAlignment.MiddleRight
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotal.Location = New Point(46, 199)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(58, 28)
        lblTotal.TabIndex = 8
        lblTotal.Text = "Total"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(46, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(107, 28)
        Label1.TabIndex = 9
        Label1.Text = "Producto: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(46, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 28)
        Label2.TabIndex = 10
        Label2.Text = "Precio"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(46, 140)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 28)
        Label3.TabIndex = 11
        Label3.Text = "Cantidad"
        ' 
        ' FormVentas
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.ventas
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblTotal)
        Controls.Add(btnCancelar)
        Controls.Add(btnConfirmarVenta)
        Controls.Add(DgvDetalle)
        Controls.Add(btnQuitar)
        Controls.Add(btnAgregar)
        Controls.Add(txtCantidad)
        Controls.Add(txtPrecio)
        Controls.Add(cmbProductos)
        Name = "FormVentas"
        Text = "Registrar ventas"
        CType(DgvDetalle, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbProductos As ComboBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnQuitar As Button
    Friend WithEvents DgvDetalle As DataGridView
    Friend WithEvents btnConfirmarVenta As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
