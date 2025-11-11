<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormGerente
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
        ToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripMenuItem6 = New ToolStripMenuItem()
        MenuStrip2 = New MenuStrip()
        VentaToolStripMenuItem = New ToolStripMenuItem()
        RegistrarVentasToolStripMenuItem = New ToolStripMenuItem()
        VerVentasToolStripMenuItem = New ToolStripMenuItem()
        ClientesToolStripMenuItem = New ToolStripMenuItem()
        AltaToolStripMenuItem = New ToolStripMenuItem()
        ProveedoresToolStripMenuItem = New ToolStripMenuItem()
        ProveedoresToolStripMenuItem1 = New ToolStripMenuItem()
        ReportesToolStripMenuItem = New ToolStripMenuItem()
        VentasToolStripMenuItem = New ToolStripMenuItem()
        ProductosToolStripMenuItem = New ToolStripMenuItem()
        CategoriaToolStripMenuItem = New ToolStripMenuItem()
        VerTodosToolStripMenuItem = New ToolStripMenuItem()
        LBienvenido = New ToolStrip()
        TSalir = New ToolStripButton()
        ToolStripLabel1 = New ToolStripLabel()
        LblBienvenido = New ToolStripLabel()
        RegistroDeComprasToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip2.SuspendLayout()
        LBienvenido.SuspendLayout()
        SuspendLayout()
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItem6})
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(12, 20)
        ' 
        ' ToolStripMenuItem6
        ' 
        ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        ToolStripMenuItem6.Size = New Size(83, 26)
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.ImageScalingSize = New Size(20, 20)
        MenuStrip2.Items.AddRange(New ToolStripItem() {VentaToolStripMenuItem, ClientesToolStripMenuItem, ProveedoresToolStripMenuItem, ReportesToolStripMenuItem, ProductosToolStripMenuItem})
        MenuStrip2.Location = New Point(0, 0)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.Padding = New Padding(7, 3, 0, 3)
        MenuStrip2.Size = New Size(914, 30)
        MenuStrip2.TabIndex = 0
        MenuStrip2.Text = "MenuStrip2"
        ' 
        ' VentaToolStripMenuItem
        ' 
        VentaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RegistrarVentasToolStripMenuItem, VerVentasToolStripMenuItem})
        VentaToolStripMenuItem.Image = My.Resources.Resources.analisis1
        VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
        VentaToolStripMenuItem.Size = New Size(80, 24)
        VentaToolStripMenuItem.Text = "Venta"
        ' 
        ' RegistrarVentasToolStripMenuItem
        ' 
        RegistrarVentasToolStripMenuItem.Name = "RegistrarVentasToolStripMenuItem"
        RegistrarVentasToolStripMenuItem.Size = New Size(198, 26)
        RegistrarVentasToolStripMenuItem.Text = "Registrar Ventas"
        ' 
        ' VerVentasToolStripMenuItem
        ' 
        VerVentasToolStripMenuItem.Name = "VerVentasToolStripMenuItem"
        VerVentasToolStripMenuItem.Size = New Size(198, 26)
        VerVentasToolStripMenuItem.Text = "Ver Ventas"
        ' 
        ' ClientesToolStripMenuItem
        ' 
        ClientesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AltaToolStripMenuItem})
        ClientesToolStripMenuItem.Image = My.Resources.Resources.mercado
        ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        ClientesToolStripMenuItem.Size = New Size(95, 24)
        ClientesToolStripMenuItem.Text = "Clientes"
        ' 
        ' AltaToolStripMenuItem
        ' 
        AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        AltaToolStripMenuItem.Size = New Size(119, 26)
        AltaToolStripMenuItem.Text = "Alta"
        ' 
        ' ProveedoresToolStripMenuItem
        ' 
        ProveedoresToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ProveedoresToolStripMenuItem1, RegistroDeComprasToolStripMenuItem})
        ProveedoresToolStripMenuItem.Image = My.Resources.Resources.proveedor
        ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        ProveedoresToolStripMenuItem.Size = New Size(113, 24)
        ProveedoresToolStripMenuItem.Text = "Suministro"
        ' 
        ' ProveedoresToolStripMenuItem1
        ' 
        ProveedoresToolStripMenuItem1.Name = "ProveedoresToolStripMenuItem1"
        ProveedoresToolStripMenuItem1.Size = New Size(231, 26)
        ProveedoresToolStripMenuItem1.Text = "Proveedores"
        ' 
        ' ReportesToolStripMenuItem
        ' 
        ReportesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {VentasToolStripMenuItem})
        ReportesToolStripMenuItem.Image = My.Resources.Resources.grafico_de_barras
        ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        ReportesToolStripMenuItem.Size = New Size(102, 24)
        ReportesToolStripMenuItem.Text = "Reportes"
        ' 
        ' VentasToolStripMenuItem
        ' 
        VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        VentasToolStripMenuItem.Size = New Size(213, 26)
        VentasToolStripMenuItem.Text = "Reporte de Ventas"
        ' 
        ' ProductosToolStripMenuItem
        ' 
        ProductosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CategoriaToolStripMenuItem, VerTodosToolStripMenuItem})
        ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        ProductosToolStripMenuItem.Size = New Size(89, 24)
        ProductosToolStripMenuItem.Text = "Productos"
        ' 
        ' CategoriaToolStripMenuItem
        ' 
        CategoriaToolStripMenuItem.Name = "CategoriaToolStripMenuItem"
        CategoriaToolStripMenuItem.Size = New Size(158, 26)
        CategoriaToolStripMenuItem.Text = "Inventario"
        ' 
        ' VerTodosToolStripMenuItem
        ' 
        VerTodosToolStripMenuItem.Name = "VerTodosToolStripMenuItem"
        VerTodosToolStripMenuItem.Size = New Size(158, 26)
        VerTodosToolStripMenuItem.Text = "Ver Todos"
        ' 
        ' LBienvenido
        ' 
        LBienvenido.Font = New Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBienvenido.ImageScalingSize = New Size(20, 20)
        LBienvenido.Items.AddRange(New ToolStripItem() {TSalir, ToolStripLabel1, LblBienvenido})
        LBienvenido.Location = New Point(0, 30)
        LBienvenido.Name = "LBienvenido"
        LBienvenido.Size = New Size(914, 27)
        LBienvenido.TabIndex = 2
        ' 
        ' TSalir
        ' 
        TSalir.Alignment = ToolStripItemAlignment.Right
        TSalir.DisplayStyle = ToolStripItemDisplayStyle.Image
        TSalir.Font = New Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TSalir.ForeColor = Color.Red
        TSalir.Image = My.Resources.Resources.borrar
        TSalir.ImageTransparentColor = Color.Magenta
        TSalir.Name = "TSalir"
        TSalir.Size = New Size(29, 24)
        ' 
        ' ToolStripLabel1
        ' 
        ToolStripLabel1.Name = "ToolStripLabel1"
        ToolStripLabel1.Size = New Size(0, 24)
        ' 
        ' LblBienvenido
        ' 
        LblBienvenido.ForeColor = Color.Red
        LblBienvenido.Name = "LblBienvenido"
        LblBienvenido.Size = New Size(0, 24)
        ' 
        ' RegistroDeComprasToolStripMenuItem
        ' 
        RegistroDeComprasToolStripMenuItem.Name = "RegistroDeComprasToolStripMenuItem"
        RegistroDeComprasToolStripMenuItem.Size = New Size(231, 26)
        RegistroDeComprasToolStripMenuItem.Text = "Registro de Compras"
        ' 
        ' FormGerente
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.inicio_sesion1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(914, 600)
        Controls.Add(LBienvenido)
        Controls.Add(MenuStrip2)
        MainMenuStrip = MenuStrip2
        Margin = New Padding(3, 4, 3, 4)
        MdiChildrenMinimizedAnchorBottom = False
        Name = "FormGerente"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Perfil  Gerente"
        MenuStrip2.ResumeLayout(False)
        MenuStrip2.PerformLayout()
        LBienvenido.ResumeLayout(False)
        LBienvenido.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents VentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TSalir As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents LBienvenido As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents LblBienvenido As ToolStripLabel
    Friend WithEvents RegistrarVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerTodosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroDeComprasToolStripMenuItem As ToolStripMenuItem
End Class
