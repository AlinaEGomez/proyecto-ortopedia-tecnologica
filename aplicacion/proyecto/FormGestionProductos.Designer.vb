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
        btnAgregarStock = New Button()
        DgvProductosSinStock = New DataGridView()
        TabPage2 = New TabPage()
        DgvProductosConStock = New DataGridView()
        TabControlProductos = New TabControl()
        TabPage1 = New TabPage()
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
        Tipo3.BackgroundImage = My.Resources.Resources.fondo_Activ
        Tipo3.Controls.Add(btnAgregarStock)
        Tipo3.Controls.Add(DgvProductosSinStock)
        Tipo3.Location = New Point(4, 35)
        Tipo3.Name = "Tipo3"
        Tipo3.Padding = New Padding(3)
        Tipo3.Size = New Size(768, 388)
        Tipo3.TabIndex = 2
        Tipo3.Text = "Productos sin Stock"
        Tipo3.UseVisualStyleBackColor = True
        ' 
        ' btnAgregarStock
        ' 
        btnAgregarStock.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        btnAgregarStock.Image = My.Resources.Resources.agregar
        btnAgregarStock.ImageAlign = ContentAlignment.MiddleLeft
        btnAgregarStock.Location = New Point(335, 266)
        btnAgregarStock.Name = "btnAgregarStock"
        btnAgregarStock.Size = New Size(184, 39)
        btnAgregarStock.TabIndex = 1
        btnAgregarStock.Text = "Agragar Stock"
        btnAgregarStock.TextAlign = ContentAlignment.MiddleRight
        btnAgregarStock.UseVisualStyleBackColor = False
        ' 
        ' DgvProductosSinStock
        ' 
        DgvProductosSinStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvProductosSinStock.Location = New Point(155, 69)
        DgvProductosSinStock.Name = "DgvProductosSinStock"
        DgvProductosSinStock.Size = New Size(474, 150)
        DgvProductosSinStock.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.BackgroundImage = My.Resources.Resources.fondo_Activ1
        TabPage2.Controls.Add(DgvProductosConStock)
        TabPage2.Location = New Point(4, 35)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(768, 388)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Productos con Stock"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' DgvProductosConStock
        ' 
        DgvProductosConStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvProductosConStock.Location = New Point(130, 177)
        DgvProductosConStock.Name = "DgvProductosConStock"
        DgvProductosConStock.Size = New Size(465, 150)
        DgvProductosConStock.TabIndex = 0
        ' 
        ' TabControlProductos
        ' 
        TabControlProductos.Controls.Add(TabPage1)
        TabControlProductos.Controls.Add(TabPage2)
        TabControlProductos.Controls.Add(Tipo3)
        TabControlProductos.Controls.Add(TabPage3)
        TabControlProductos.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabControlProductos.Location = New Point(12, 30)
        TabControlProductos.Name = "TabControlProductos"
        TabControlProductos.SelectedIndex = 0
        TabControlProductos.Size = New Size(776, 427)
        TabControlProductos.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.BackgroundImage = My.Resources.Resources.AltaProd
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
        TabPage1.Location = New Point(4, 35)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(768, 388)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Agregar Productos"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label8.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(307, 24)
        Label8.Name = "Label8"
        Label8.Size = New Size(69, 26)
        Label8.TabIndex = 26
        Label8.Text = "Precio:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label7.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(12, 115)
        Label7.Name = "Label7"
        Label7.Size = New Size(151, 26)
        Label7.TabIndex = 25
        Label7.Text = "Stock Productos:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label6.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(12, 61)
        Label6.Name = "Label6"
        Label6.Size = New Size(120, 28)
        Label6.TabIndex = 24
        Label6.Text = "Descripción"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label5.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(12, 24)
        Label5.Name = "Label5"
        Label5.Size = New Size(159, 26)
        Label5.TabIndex = 23
        Label5.Text = "Código Producto:"
        ' 
        ' dgvProductos
        ' 
        dgvProductos.AllowUserToOrderColumns = True
        dgvProductos.Anchor = AnchorStyles.None
        dgvProductos.CausesValidation = False
        dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvProductos.Location = New Point(38, 188)
        dgvProductos.Name = "dgvProductos"
        dgvProductos.Size = New Size(690, 213)
        dgvProductos.TabIndex = 22
        ' 
        ' TxtPrecio
        ' 
        TxtPrecio.Location = New Point(395, 14)
        TxtPrecio.Name = "TxtPrecio"
        TxtPrecio.Size = New Size(100, 33)
        TxtPrecio.TabIndex = 21
        ' 
        ' TxtStock
        ' 
        TxtStock.Location = New Point(171, 108)
        TxtStock.Name = "TxtStock"
        TxtStock.Size = New Size(100, 33)
        TxtStock.TabIndex = 20
        ' 
        ' TxtDescripcion
        ' 
        TxtDescripcion.Location = New Point(171, 60)
        TxtDescripcion.Name = "TxtDescripcion"
        TxtDescripcion.Size = New Size(100, 33)
        TxtDescripcion.TabIndex = 19
        ' 
        ' TxtCodigo
        ' 
        TxtCodigo.Location = New Point(191, 21)
        TxtCodigo.Name = "TxtCodigo"
        TxtCodigo.Size = New Size(100, 33)
        TxtCodigo.TabIndex = 18
        ' 
        ' BtnEliminar
        ' 
        BtnEliminar.Image = My.Resources.Resources.quitar1
        BtnEliminar.ImageAlign = ContentAlignment.MiddleLeft
        BtnEliminar.Location = New Point(570, 70)
        BtnEliminar.Name = "BtnEliminar"
        BtnEliminar.Size = New Size(115, 40)
        BtnEliminar.TabIndex = 17
        BtnEliminar.Text = "Eliminar"
        BtnEliminar.TextAlign = ContentAlignment.MiddleRight
        BtnEliminar.UseVisualStyleBackColor = True
        ' 
        ' BtnGuardar
        ' 
        BtnGuardar.Image = My.Resources.Resources.carpeta
        BtnGuardar.ImageAlign = ContentAlignment.MiddleLeft
        BtnGuardar.Location = New Point(563, 10)
        BtnGuardar.Name = "BtnGuardar"
        BtnGuardar.Size = New Size(122, 40)
        BtnGuardar.TabIndex = 16
        BtnGuardar.Text = "Guardar Producto"
        BtnGuardar.TextAlign = ContentAlignment.MiddleRight
        BtnGuardar.UseVisualStyleBackColor = True
        ' 
        ' pbImagenProducto
        ' 
        pbImagenProducto.BackColor = Color.Gray
        pbImagenProducto.Location = New Point(420, 60)
        pbImagenProducto.Name = "pbImagenProducto"
        pbImagenProducto.Size = New Size(127, 91)
        pbImagenProducto.TabIndex = 15
        pbImagenProducto.TabStop = False
        ' 
        ' BtnBuscarImagen
        ' 
        BtnBuscarImagen.Image = My.Resources.Resources.buscarImagen
        BtnBuscarImagen.ImageAlign = ContentAlignment.MiddleLeft
        BtnBuscarImagen.Location = New Point(292, 70)
        BtnBuscarImagen.Name = "BtnBuscarImagen"
        BtnBuscarImagen.Size = New Size(113, 40)
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
        Label3.Location = New Point(316, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 26)
        Label3.TabIndex = 13
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label2.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(6, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 26)
        Label2.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label4.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(6, 60)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 28)
        Label4.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label1.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(6, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 26)
        Label1.TabIndex = 8
        ' 
        ' TabPage3
        ' 
        TabPage3.BackgroundImage = My.Resources.Resources.fondo_Activ
        TabPage3.BackgroundImageLayout = ImageLayout.Stretch
        TabPage3.Controls.Add(BtnDarAlta)
        TabPage3.Controls.Add(DgvProductosDeBaja)
        TabPage3.Location = New Point(4, 35)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(768, 388)
        TabPage3.TabIndex = 3
        TabPage3.Text = "Productos Eliminados"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' BtnDarAlta
        ' 
        BtnDarAlta.Location = New Point(410, 96)
        BtnDarAlta.Name = "BtnDarAlta"
        BtnDarAlta.Size = New Size(160, 46)
        BtnDarAlta.TabIndex = 1
        BtnDarAlta.Text = "Alta"
        BtnDarAlta.UseVisualStyleBackColor = True
        ' 
        ' DgvProductosDeBaja
        ' 
        DgvProductosDeBaja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvProductosDeBaja.Location = New Point(142, 148)
        DgvProductosDeBaja.Name = "DgvProductosDeBaja"
        DgvProductosDeBaja.Size = New Size(502, 184)
        DgvProductosDeBaja.TabIndex = 0
        ' 
        ' FormGestionProductos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TabControlProductos)
        Name = "FormGestionProductos"
        Text = "FormGestionProductos"
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
End Class
