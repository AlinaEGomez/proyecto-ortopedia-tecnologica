<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInventario
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
        dgvProductos = New DataGridView()
        TxtNombre = New TextBox()
        TxtStock = New TextBox()
        TxtPrecio = New TextBox()
        BtnBuscarImagen = New Button()
        BtnGuardar = New Button()
        pbImagenProducto = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        CType(dgvProductos, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbImagenProducto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvProductos
        ' 
        dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProductos.Location = New Point(12, 213)
        dgvProductos.Name = "dgvProductos"
        dgvProductos.Size = New Size(759, 198)
        dgvProductos.TabIndex = 0
        ' 
        ' TxtNombre
        ' 
        TxtNombre.Location = New Point(194, 20)
        TxtNombre.Name = "TxtNombre"
        TxtNombre.Size = New Size(100, 23)
        TxtNombre.TabIndex = 1
        ' 
        ' TxtStock
        ' 
        TxtStock.Location = New Point(194, 70)
        TxtStock.Name = "TxtStock"
        TxtStock.Size = New Size(100, 23)
        TxtStock.TabIndex = 2
        ' 
        ' TxtPrecio
        ' 
        TxtPrecio.Location = New Point(460, 23)
        TxtPrecio.Name = "TxtPrecio"
        TxtPrecio.Size = New Size(100, 23)
        TxtPrecio.TabIndex = 3
        ' 
        ' BtnBuscarImagen
        ' 
        BtnBuscarImagen.Image = My.Resources.Resources.buscarImagen
        BtnBuscarImagen.ImageAlign = ContentAlignment.MiddleLeft
        BtnBuscarImagen.Location = New Point(12, 134)
        BtnBuscarImagen.Name = "BtnBuscarImagen"
        BtnBuscarImagen.Size = New Size(122, 40)
        BtnBuscarImagen.TabIndex = 4
        BtnBuscarImagen.Text = "Buscar Imagen"
        BtnBuscarImagen.TextAlign = ContentAlignment.MiddleRight
        BtnBuscarImagen.UseVisualStyleBackColor = True
        ' 
        ' BtnGuardar
        ' 
        BtnGuardar.Image = My.Resources.Resources.carpeta
        BtnGuardar.ImageAlign = ContentAlignment.MiddleLeft
        BtnGuardar.Location = New Point(378, 144)
        BtnGuardar.Name = "BtnGuardar"
        BtnGuardar.Size = New Size(135, 40)
        BtnGuardar.TabIndex = 5
        BtnGuardar.Text = "Guardar Producto"
        BtnGuardar.TextAlign = ContentAlignment.MiddleRight
        BtnGuardar.UseVisualStyleBackColor = True
        ' 
        ' pbImagenProducto
        ' 
        pbImagenProducto.Location = New Point(194, 116)
        pbImagenProducto.Name = "pbImagenProducto"
        pbImagenProducto.Size = New Size(127, 91)
        pbImagenProducto.TabIndex = 6
        pbImagenProducto.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(167, 26)
        Label1.TabIndex = 7
        Label1.Text = "Nombre Producto:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(151, 26)
        Label2.TabIndex = 8
        Label2.Text = "Stock Productos:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(378, 20)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 26)
        Label3.TabIndex = 9
        Label3.Text = "Precio:"
        ' 
        ' FormInventario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        BackgroundImage = My.Resources.Resources.fondoProd
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(pbImagenProducto)
        Controls.Add(BtnGuardar)
        Controls.Add(BtnBuscarImagen)
        Controls.Add(TxtPrecio)
        Controls.Add(TxtStock)
        Controls.Add(TxtNombre)
        Controls.Add(dgvProductos)
        Name = "FormInventario"
        Text = "Crud Productos"
        CType(dgvProductos, ComponentModel.ISupportInitialize).EndInit()
        CType(pbImagenProducto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents BtnBuscarImagen As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents pbImagenProducto As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
