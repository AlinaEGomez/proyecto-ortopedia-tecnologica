<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGestionProductos
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
        Tipo3 = New TabPage()
        Button2 = New Button()
        btnAgregarStock = New Button()
        DgvProductosSinStock = New DataGridView()
        TabPage2 = New TabPage()
        Button1 = New Button()
        DgvProductosConStock = New DataGridView()
        TabControlProductos = New TabControl()
        TabPage1 = New TabPage()
        BtnCerrar = New Button()
        txtBuscarProd = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        dgvProductos = New DataGridView()
        TxtPrecio = New TextBox()
        TxtStock = New TextBox()
        TxtDescripcion = New TextBox()
        TxtCodigo = New TextBox()
        BtnEliminar = New Button()
        BtnGuardar = New Button()
        pbImagenProducto = New PictureBox()
        BtnBuscarImagen = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label1 = New Label()
        TabPage3 = New TabPage()
        Button3 = New Button()
        BtnDarAlta = New Button()
        DgvProductosDeBaja = New DataGridView()
        Tipo3.SuspendLayout()
        CType(DgvProductosSinStock, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(DgvProductosConStock, ComponentModel.ISupportInitialize).BeginInit()
        TabControlProductos.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(dgvProductos, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbImagenProducto, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        CType(DgvProductosDeBaja, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Tipo3
        ' 
        Tipo3.Controls.Add(Button2)
        Tipo3.Controls.Add(btnAgregarStock)
        Tipo3.Controls.Add(DgvProductosSinStock)
        Tipo3.Location = New Point(4, 41)
        Tipo3.Margin = New Padding(3, 4, 3, 4)
        Tipo3.Name = "Tipo3"
        Tipo3.Padding = New Padding(3, 4, 3, 4)
        Tipo3.Size = New Size(879, 524)
        Tipo3.TabIndex = 2
        Tipo3.Text = "Productos sin Stock"
        Tipo3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(724, 448)
        Button2.Name = "Button2"
        Button2.Size = New Size(100, 43)
        Button2.TabIndex = 30
        Button2.Text = "Cerrar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' btnAgregarStock
        ' 
        btnAgregarStock.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        btnAgregarStock.ImageAlign = ContentAlignment.MiddleLeft
        btnAgregarStock.Location = New Point(383, 355)
        btnAgregarStock.Margin = New Padding(3, 4, 3, 4)
        btnAgregarStock.Name = "btnAgregarStock"
        btnAgregarStock.Size = New Size(210, 52)
        btnAgregarStock.TabIndex = 1
        btnAgregarStock.Text = "Agragar Stock"
        btnAgregarStock.TextAlign = ContentAlignment.MiddleRight
        btnAgregarStock.UseVisualStyleBackColor = False
        ' 
        ' DgvProductosSinStock
        ' 
        DgvProductosSinStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvProductosSinStock.Location = New Point(110, 41)
        DgvProductosSinStock.Margin = New Padding(3, 4, 3, 4)
        DgvProductosSinStock.Name = "DgvProductosSinStock"
        DgvProductosSinStock.RowHeadersWidth = 51
        DgvProductosSinStock.Size = New Size(656, 251)
        DgvProductosSinStock.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Button1)
        TabPage2.Controls.Add(DgvProductosConStock)
        TabPage2.Location = New Point(4, 41)
        TabPage2.Margin = New Padding(3, 4, 3, 4)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3, 4, 3, 4)
        TabPage2.Size = New Size(879, 524)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Productos con Stock"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(729, 454)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 43)
        Button1.TabIndex = 30
        Button1.Text = "Cerrar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DgvProductosConStock
        ' 
        DgvProductosConStock.BackgroundColor = Color.RosyBrown
        DgvProductosConStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvProductosConStock.Location = New Point(149, 236)
        DgvProductosConStock.Margin = New Padding(3, 4, 3, 4)
        DgvProductosConStock.Name = "DgvProductosConStock"
        DgvProductosConStock.RowHeadersWidth = 51
        DgvProductosConStock.Size = New Size(531, 200)
        DgvProductosConStock.TabIndex = 0
        ' 
        ' TabControlProductos
        ' 
        TabControlProductos.Controls.Add(TabPage1)
        TabControlProductos.Controls.Add(TabPage2)
        TabControlProductos.Controls.Add(Tipo3)
        TabControlProductos.Controls.Add(TabPage3)
        TabControlProductos.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabControlProductos.Location = New Point(14, 40)
        TabControlProductos.Margin = New Padding(3, 4, 3, 4)
        TabControlProductos.Name = "TabControlProductos"
        TabControlProductos.SelectedIndex = 0
        TabControlProductos.Size = New Size(887, 569)
        TabControlProductos.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.BackgroundImage = My.Resources.Resources.AltaProd2
        TabPage1.Controls.Add(BtnCerrar)
        TabPage1.Controls.Add(txtBuscarProd)
        TabPage1.Controls.Add(Label9)
        TabPage1.Controls.Add(Label8)
        TabPage1.Controls.Add(Label7)
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(dgvProductos)
        TabPage1.Controls.Add(TxtPrecio)
        TabPage1.Controls.Add(TxtStock)
        TabPage1.Controls.Add(TxtDescripcion)
        TabPage1.Controls.Add(TxtCodigo)
        TabPage1.Controls.Add(BtnEliminar)
        TabPage1.Controls.Add(BtnGuardar)
        TabPage1.Controls.Add(pbImagenProducto)
        TabPage1.Controls.Add(BtnBuscarImagen)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(Label1)
        TabPage1.Location = New Point(4, 41)
        TabPage1.Margin = New Padding(3, 4, 3, 4)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3, 4, 3, 4)
        TabPage1.Size = New Size(879, 524)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Agregar Productos"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' BtnCerrar
        ' 
        BtnCerrar.Location = New Point(720, 474)
        BtnCerrar.Name = "BtnCerrar"
        BtnCerrar.Size = New Size(100, 43)
        BtnCerrar.TabIndex = 29
        BtnCerrar.Text = "Cerrar"
        BtnCerrar.UseVisualStyleBackColor = True
        ' 
        ' txtBuscarProd
        ' 
        txtBuscarProd.Location = New Point(218, 213)
        txtBuscarProd.Margin = New Padding(3, 4, 3, 4)
        txtBuscarProd.Name = "txtBuscarProd"
        txtBuscarProd.Size = New Size(114, 39)
        txtBuscarProd.TabIndex = 28
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label9.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(14, 217)
        Label9.Name = "Label9"
        Label9.Size = New Size(201, 32)
        Label9.TabIndex = 27
        Label9.Text = "Buscar Productos:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label8.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(351, 32)
        Label8.Name = "Label8"
        Label8.Size = New Size(84, 32)
        Label8.TabIndex = 26
        Label8.Text = "Precio:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label7.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(14, 153)
        Label7.Name = "Label7"
        Label7.Size = New Size(190, 32)
        Label7.TabIndex = 25
        Label7.Text = "Stock Productos:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label6.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(14, 81)
        Label6.Name = "Label6"
        Label6.Size = New Size(153, 36)
        Label6.TabIndex = 24
        Label6.Text = "Descripción"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label5.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(14, 32)
        Label5.Name = "Label5"
        Label5.Size = New Size(199, 32)
        Label5.TabIndex = 23
        Label5.Text = "Código Producto:"
        ' 
        ' dgvProductos
        ' 
        dgvProductos.AllowUserToOrderColumns = True
        dgvProductos.Anchor = AnchorStyles.None
        dgvProductos.CausesValidation = False
        dgvProductos.ColumnHeadersHeight = 29
        dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvProductos.Location = New Point(49, 253)
        dgvProductos.Margin = New Padding(3, 4, 3, 4)
        dgvProductos.Name = "dgvProductos"
        dgvProductos.RowHeadersWidth = 51
        dgvProductos.Size = New Size(789, 218)
        dgvProductos.TabIndex = 22
        ' 
        ' TxtPrecio
        ' 
        TxtPrecio.Location = New Point(451, 19)
        TxtPrecio.Margin = New Padding(3, 4, 3, 4)
        TxtPrecio.Name = "TxtPrecio"
        TxtPrecio.Size = New Size(114, 39)
        TxtPrecio.TabIndex = 21
        ' 
        ' TxtStock
        ' 
        TxtStock.Location = New Point(210, 150)
        TxtStock.Margin = New Padding(3, 4, 3, 4)
        TxtStock.Name = "TxtStock"
        TxtStock.Size = New Size(114, 39)
        TxtStock.TabIndex = 20
        ' 
        ' TxtDescripcion
        ' 
        TxtDescripcion.Location = New Point(195, 80)
        TxtDescripcion.Margin = New Padding(3, 4, 3, 4)
        TxtDescripcion.Name = "TxtDescripcion"
        TxtDescripcion.Size = New Size(114, 39)
        TxtDescripcion.TabIndex = 19
        ' 
        ' TxtCodigo
        ' 
        TxtCodigo.Location = New Point(218, 28)
        TxtCodigo.Margin = New Padding(3, 4, 3, 4)
        TxtCodigo.Name = "TxtCodigo"
        TxtCodigo.Size = New Size(114, 39)
        TxtCodigo.TabIndex = 18
        ' 
        ' BtnEliminar
        ' 
        BtnEliminar.ImageAlign = ContentAlignment.MiddleLeft
        BtnEliminar.Location = New Point(651, 93)
        BtnEliminar.Margin = New Padding(3, 4, 3, 4)
        BtnEliminar.Name = "BtnEliminar"
        BtnEliminar.Size = New Size(131, 53)
        BtnEliminar.TabIndex = 17
        BtnEliminar.Text = "Eliminar"
        BtnEliminar.TextAlign = ContentAlignment.MiddleRight
        BtnEliminar.UseVisualStyleBackColor = True
        ' 
        ' BtnGuardar
        ' 
        BtnGuardar.Image = My.Resources.Resources.carpeta
        BtnGuardar.ImageAlign = ContentAlignment.MiddleLeft
        BtnGuardar.Location = New Point(643, 13)
        BtnGuardar.Margin = New Padding(3, 4, 3, 4)
        BtnGuardar.Name = "BtnGuardar"
        BtnGuardar.Size = New Size(139, 53)
        BtnGuardar.TabIndex = 16
        BtnGuardar.Text = "Guardar Producto"
        BtnGuardar.TextAlign = ContentAlignment.MiddleRight
        BtnGuardar.UseVisualStyleBackColor = True
        ' 
        ' pbImagenProducto
        ' 
        pbImagenProducto.BackColor = Color.Gray
        pbImagenProducto.Location = New Point(480, 80)
        pbImagenProducto.Margin = New Padding(3, 4, 3, 4)
        pbImagenProducto.Name = "pbImagenProducto"
        pbImagenProducto.Size = New Size(145, 121)
        pbImagenProducto.TabIndex = 15
        pbImagenProducto.TabStop = False
        ' 
        ' BtnBuscarImagen
        ' 
        BtnBuscarImagen.Image = My.Resources.Resources.buscarImagen
        BtnBuscarImagen.ImageAlign = ContentAlignment.MiddleLeft
        BtnBuscarImagen.Location = New Point(334, 93)
        BtnBuscarImagen.Margin = New Padding(3, 4, 3, 4)
        BtnBuscarImagen.Name = "BtnBuscarImagen"
        BtnBuscarImagen.Size = New Size(129, 53)
        BtnBuscarImagen.TabIndex = 14
        BtnBuscarImagen.Text = "Buscar Imagen"
        BtnBuscarImagen.TextAlign = ContentAlignment.MiddleRight
        BtnBuscarImagen.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label3.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(361, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 32)
        Label3.TabIndex = 13
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label2.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(7, 147)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 32)
        Label2.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label4.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(7, 80)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 36)
        Label4.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label1.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(7, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 32)
        Label1.TabIndex = 8
        ' 
        ' TabPage3
        ' 
        TabPage3.BackgroundImageLayout = ImageLayout.Stretch
        TabPage3.Controls.Add(Button3)
        TabPage3.Controls.Add(BtnDarAlta)
        TabPage3.Controls.Add(DgvProductosDeBaja)
        TabPage3.Location = New Point(4, 41)
        TabPage3.Margin = New Padding(3, 4, 3, 4)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3, 4, 3, 4)
        TabPage3.Size = New Size(879, 524)
        TabPage3.TabIndex = 3
        TabPage3.Text = "Productos Eliminados"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(734, 463)
        Button3.Name = "Button3"
        Button3.Size = New Size(100, 43)
        Button3.TabIndex = 30
        Button3.Text = "Cerrar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' BtnDarAlta
        ' 
        BtnDarAlta.BackColor = Color.LightCoral
        BtnDarAlta.Location = New Point(354, 103)
        BtnDarAlta.Margin = New Padding(3, 4, 3, 4)
        BtnDarAlta.Name = "BtnDarAlta"
        BtnDarAlta.Size = New Size(183, 61)
        BtnDarAlta.TabIndex = 1
        BtnDarAlta.Text = "Alta"
        BtnDarAlta.UseVisualStyleBackColor = False
        ' 
        ' DgvProductosDeBaja
        ' 
        DgvProductosDeBaja.BackgroundColor = Color.RosyBrown
        DgvProductosDeBaja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvProductosDeBaja.Location = New Point(162, 197)
        DgvProductosDeBaja.Margin = New Padding(3, 4, 3, 4)
        DgvProductosDeBaja.Name = "DgvProductosDeBaja"
        DgvProductosDeBaja.RowHeadersWidth = 51
        DgvProductosDeBaja.Size = New Size(574, 245)
        DgvProductosDeBaja.TabIndex = 0
        ' 
        ' FormGestionProductos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(914, 638)
        Controls.Add(TabControlProductos)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormGestionProductos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Gestion Productos"
        Tipo3.ResumeLayout(False)
        CType(DgvProductosSinStock, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        CType(DgvProductosConStock, ComponentModel.ISupportInitialize).EndInit()
        TabControlProductos.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(dgvProductos, ComponentModel.ISupportInitialize).EndInit()
        CType(pbImagenProducto, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        CType(DgvProductosDeBaja, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Tipo3 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabControlProductos As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents pbImagenProducto As PictureBox
    Friend WithEvents BtnBuscarImagen As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvProductosSinStock As DataGridView
    Friend WithEvents DgvProductosConStock As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DgvProductosDeBaja As DataGridView
    Friend WithEvents BtnDarAlta As Button
    Friend WithEvents btnAgregarStock As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtBuscarProd As TextBox
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
