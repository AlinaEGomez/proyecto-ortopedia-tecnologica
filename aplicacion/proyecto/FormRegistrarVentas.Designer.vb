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
        Button1 = New Button()
        Label5 = New Label()
        ChkOcasional = New CheckBox()
        Label6 = New Label()
        CmbRazonSocial = New ComboBox()
        Cmbcuil = New ComboBox()
        CType(DgvDetalle, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbProductos
        ' 
        cmbProductos.FormattingEnabled = True
        cmbProductos.Location = New Point(207, 51)
        cmbProductos.Margin = New Padding(3, 4, 3, 4)
        cmbProductos.Name = "cmbProductos"
        cmbProductos.Size = New Size(138, 28)
        cmbProductos.TabIndex = 0
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(207, 100)
        txtPrecio.Margin = New Padding(3, 4, 3, 4)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(114, 27)
        txtPrecio.TabIndex = 1
        ' 
        ' txtCantidad
        ' 
        txtCantidad.Location = New Point(207, 160)
        txtCantidad.Margin = New Padding(3, 4, 3, 4)
        txtCantidad.Name = "txtCantidad"
        txtCantidad.Size = New Size(114, 27)
        txtCantidad.TabIndex = 2
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackgroundImageLayout = ImageLayout.None
        btnAgregar.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAgregar.ImageAlign = ContentAlignment.MiddleRight
        btnAgregar.Location = New Point(378, 215)
        btnAgregar.Margin = New Padding(3, 4, 3, 4)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(123, 53)
        btnAgregar.TabIndex = 3
        btnAgregar.Text = "Agregar"
        btnAgregar.TextAlign = ContentAlignment.MiddleRight
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' btnQuitar
        ' 
        btnQuitar.BackgroundImageLayout = ImageLayout.None
        btnQuitar.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnQuitar.ImageAlign = ContentAlignment.MiddleLeft
        btnQuitar.Location = New Point(532, 215)
        btnQuitar.Margin = New Padding(3, 4, 3, 4)
        btnQuitar.Name = "btnQuitar"
        btnQuitar.Size = New Size(121, 53)
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
        DgvDetalle.Location = New Point(53, 298)
        DgvDetalle.Margin = New Padding(3, 4, 3, 4)
        DgvDetalle.Name = "DgvDetalle"
        DgvDetalle.RowHeadersWidth = 51
        DgvDetalle.Size = New Size(804, 221)
        DgvDetalle.TabIndex = 5
        ' 
        ' btnConfirmarVenta
        ' 
        btnConfirmarVenta.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnConfirmarVenta.ImageAlign = ContentAlignment.MiddleLeft
        btnConfirmarVenta.Location = New Point(65, 527)
        btnConfirmarVenta.Margin = New Padding(3, 4, 3, 4)
        btnConfirmarVenta.Name = "btnConfirmarVenta"
        btnConfirmarVenta.Size = New Size(214, 49)
        btnConfirmarVenta.TabIndex = 6
        btnConfirmarVenta.Text = "Confirmar Ventas"
        btnConfirmarVenta.TextAlign = ContentAlignment.MiddleRight
        btnConfirmarVenta.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancelar.ImageAlign = ContentAlignment.MiddleLeft
        btnCancelar.Location = New Point(353, 526)
        btnCancelar.Margin = New Padding(3, 4, 3, 4)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(216, 48)
        btnCancelar.TabIndex = 7
        btnCancelar.Text = "Cancelar Venta"
        btnCancelar.TextAlign = ContentAlignment.MiddleRight
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotal.Location = New Point(53, 232)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(75, 36)
        lblTotal.TabIndex = 8
        lblTotal.Text = "Total"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(53, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 36)
        Label1.TabIndex = 9
        Label1.Text = "Producto: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(53, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 36)
        Label2.TabIndex = 10
        Label2.Text = "Precio"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(53, 160)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 36)
        Label3.TabIndex = 11
        Label3.Text = "Cantidad"
        ' 
        ' Button1
        ' 
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(710, 532)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(108, 42)
        Button1.TabIndex = 12
        Button1.Text = "Cerrar"
        Button1.TextAlign = ContentAlignment.MiddleRight
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(395, 100)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 36)
        Label5.TabIndex = 16
        Label5.Text = "Cuil: "
        ' 
        ' ChkOcasional
        ' 
        ChkOcasional.AutoSize = True
        ChkOcasional.Location = New Point(395, 163)
        ChkOcasional.Name = "ChkOcasional"
        ChkOcasional.Size = New Size(146, 24)
        ChkOcasional.TabIndex = 17
        ChkOcasional.Text = "Cliente Ocasional"
        ChkOcasional.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(395, 44)
        Label6.Name = "Label6"
        Label6.Size = New Size(111, 36)
        Label6.TabIndex = 18
        Label6.Text = "Cliente: "
        ' 
        ' CmbRazonSocial
        ' 
        CmbRazonSocial.FormattingEnabled = True
        CmbRazonSocial.Location = New Point(577, 53)
        CmbRazonSocial.Name = "CmbRazonSocial"
        CmbRazonSocial.Size = New Size(151, 28)
        CmbRazonSocial.TabIndex = 19
        ' 
        ' Cmbcuil
        ' 
        Cmbcuil.FormattingEnabled = True
        Cmbcuil.Location = New Point(577, 109)
        Cmbcuil.Name = "Cmbcuil"
        Cmbcuil.Size = New Size(151, 28)
        Cmbcuil.TabIndex = 20
        ' 
        ' FormRegistarVentas
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.vendedor
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(914, 600)
        Controls.Add(Cmbcuil)
        Controls.Add(CmbRazonSocial)
        Controls.Add(Label6)
        Controls.Add(ChkOcasional)
        Controls.Add(Label5)
        Controls.Add(Button1)
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
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormRegistarVentas"
        StartPosition = FormStartPosition.CenterScreen
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents ChkOcasional As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CmbRazonSocial As ComboBox
    Friend WithEvents Cmbcuil As ComboBox
End Class
