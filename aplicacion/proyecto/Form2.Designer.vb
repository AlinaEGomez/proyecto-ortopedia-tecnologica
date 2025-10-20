<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        MenuStrip1 = New MenuStrip()
        RolToolStripMenuItem = New ToolStripMenuItem()
        VendedorToolStripMenuItem = New ToolStripMenuItem()
        AltaToolStripMenuItem = New ToolStripMenuItem()
        UsuariosToolStripMenuItem = New ToolStripMenuItem()
        MantenimientoToolStripMenuItem = New ToolStripMenuItem()
        ProductosToolStripMenuItem = New ToolStripMenuItem()
        AltaToolStripMenuItem1 = New ToolStripMenuItem()
        ProductosActivosToolStripMenuItem = New ToolStripMenuItem()
        ProductosSinStockToolStripMenuItem = New ToolStripMenuItem()
        ClientesToolStripMenuItem = New ToolStripMenuItem()
        ClientesToolStripMenuItem1 = New ToolStripMenuItem()
        ActivosToolStripMenuItem = New ToolStripMenuItem()
        InactivosToolStripMenuItem = New ToolStripMenuItem()
        GreToolStripMenuItem = New ToolStripMenuItem()
        ActivosToolStripMenuItem1 = New ToolStripMenuItem()
        InactivosToolStripMenuItem1 = New ToolStripMenuItem()
        VendedoresToolStripMenuItem = New ToolStripMenuItem()
        ActivosToolStripMenuItem2 = New ToolStripMenuItem()
        InactivosToolStripMenuItem2 = New ToolStripMenuItem()
        ProveedorToolStripMenuItem = New ToolStripMenuItem()
        ProductosToolStripMenuItem1 = New ToolStripMenuItem()
        NegocioToolStripMenuItem = New ToolStripMenuItem()
        ReporteDeComprasToolStripMenuItem = New ToolStripMenuItem()
        ReportesDeVentasToolStripMenuItem = New ToolStripMenuItem()
        BackToolStripMenuItem = New ToolStripMenuItem()
        CopiaDeSeguridadToolStripMenuItem = New ToolStripMenuItem()
        ToolStrip1 = New ToolStrip()
        TSalir = New ToolStripButton()
        LblBienvenido = New ToolStripLabel()
        MenuStrip1.SuspendLayout()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.GripStyle = ToolStripGripStyle.Visible
        MenuStrip1.Items.AddRange(New ToolStripItem() {RolToolStripMenuItem, MantenimientoToolStripMenuItem, ClientesToolStripMenuItem, ProveedorToolStripMenuItem, NegocioToolStripMenuItem, BackToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.RenderMode = ToolStripRenderMode.Professional
        MenuStrip1.Size = New Size(928, 39)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' RolToolStripMenuItem
        ' 
        RolToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {VendedorToolStripMenuItem, UsuariosToolStripMenuItem})
        RolToolStripMenuItem.Image = My.Resources.Resources.datos_del_usuario
        RolToolStripMenuItem.Name = "RolToolStripMenuItem"
        RolToolStripMenuItem.Size = New Size(64, 35)
        RolToolStripMenuItem.Text = "Usuarios"
        RolToolStripMenuItem.TextAlign = ContentAlignment.BottomCenter
        RolToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' VendedorToolStripMenuItem
        ' 
        VendedorToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AltaToolStripMenuItem})
        VendedorToolStripMenuItem.Name = "VendedorToolStripMenuItem"
        VendedorToolStripMenuItem.Size = New Size(143, 22)
        VendedorToolStripMenuItem.Text = "Crud Usuario"
        VendedorToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' AltaToolStripMenuItem
        ' 
        AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        AltaToolStripMenuItem.Size = New Size(95, 22)
        AltaToolStripMenuItem.Text = "Alta"
        ' 
        ' UsuariosToolStripMenuItem
        ' 
        UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        UsuariosToolStripMenuItem.Size = New Size(143, 22)
        UsuariosToolStripMenuItem.Text = "Usuarios"
        ' 
        ' MantenimientoToolStripMenuItem
        ' 
        MantenimientoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ProductosToolStripMenuItem})
        MantenimientoToolStripMenuItem.Image = My.Resources.Resources.equipo
        MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        MantenimientoToolStripMenuItem.Size = New Size(101, 35)
        MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        MantenimientoToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' ProductosToolStripMenuItem
        ' 
        ProductosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AltaToolStripMenuItem1, ProductosActivosToolStripMenuItem, ProductosSinStockToolStripMenuItem})
        ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        ProductosToolStripMenuItem.Size = New Size(128, 22)
        ProductosToolStripMenuItem.Text = "Productos"
        ' 
        ' AltaToolStripMenuItem1
        ' 
        AltaToolStripMenuItem1.Name = "AltaToolStripMenuItem1"
        AltaToolStripMenuItem1.Size = New Size(209, 22)
        AltaToolStripMenuItem1.Text = "Crud Producto"
        ' 
        ' ProductosActivosToolStripMenuItem
        ' 
        ProductosActivosToolStripMenuItem.Name = "ProductosActivosToolStripMenuItem"
        ProductosActivosToolStripMenuItem.Size = New Size(209, 22)
        ProductosActivosToolStripMenuItem.Text = "Productos Activos (stock)"
        ' 
        ' ProductosSinStockToolStripMenuItem
        ' 
        ProductosSinStockToolStripMenuItem.Name = "ProductosSinStockToolStripMenuItem"
        ProductosSinStockToolStripMenuItem.Size = New Size(209, 22)
        ProductosSinStockToolStripMenuItem.Text = "Productos sinStock"
        ' 
        ' ClientesToolStripMenuItem
        ' 
        ClientesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ClientesToolStripMenuItem1, GreToolStripMenuItem, VendedoresToolStripMenuItem})
        ClientesToolStripMenuItem.Image = My.Resources.Resources.mercado
        ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        ClientesToolStripMenuItem.Size = New Size(106, 35)
        ClientesToolStripMenuItem.Text = "Admin. Usuarios"
        ClientesToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' ClientesToolStripMenuItem1
        ' 
        ClientesToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {ActivosToolStripMenuItem, InactivosToolStripMenuItem})
        ClientesToolStripMenuItem1.Name = "ClientesToolStripMenuItem1"
        ClientesToolStripMenuItem1.Size = New Size(135, 22)
        ClientesToolStripMenuItem1.Text = "Clientes"
        ' 
        ' ActivosToolStripMenuItem
        ' 
        ActivosToolStripMenuItem.Name = "ActivosToolStripMenuItem"
        ActivosToolStripMenuItem.Size = New Size(121, 22)
        ActivosToolStripMenuItem.Text = "Activos"
        ' 
        ' InactivosToolStripMenuItem
        ' 
        InactivosToolStripMenuItem.Name = "InactivosToolStripMenuItem"
        InactivosToolStripMenuItem.Size = New Size(121, 22)
        InactivosToolStripMenuItem.Text = "Inactivos"
        ' 
        ' GreToolStripMenuItem
        ' 
        GreToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ActivosToolStripMenuItem1, InactivosToolStripMenuItem1})
        GreToolStripMenuItem.Name = "GreToolStripMenuItem"
        GreToolStripMenuItem.Size = New Size(135, 22)
        GreToolStripMenuItem.Text = "Gerentes"
        ' 
        ' ActivosToolStripMenuItem1
        ' 
        ActivosToolStripMenuItem1.Name = "ActivosToolStripMenuItem1"
        ActivosToolStripMenuItem1.Size = New Size(121, 22)
        ActivosToolStripMenuItem1.Text = "Activos"
        ' 
        ' InactivosToolStripMenuItem1
        ' 
        InactivosToolStripMenuItem1.Name = "InactivosToolStripMenuItem1"
        InactivosToolStripMenuItem1.Size = New Size(121, 22)
        InactivosToolStripMenuItem1.Text = "Inactivos"
        ' 
        ' VendedoresToolStripMenuItem
        ' 
        VendedoresToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ActivosToolStripMenuItem2, InactivosToolStripMenuItem2})
        VendedoresToolStripMenuItem.Name = "VendedoresToolStripMenuItem"
        VendedoresToolStripMenuItem.Size = New Size(135, 22)
        VendedoresToolStripMenuItem.Text = "Vendedores"
        ' 
        ' ActivosToolStripMenuItem2
        ' 
        ActivosToolStripMenuItem2.Name = "ActivosToolStripMenuItem2"
        ActivosToolStripMenuItem2.Size = New Size(121, 22)
        ActivosToolStripMenuItem2.Text = "Activos"
        ' 
        ' InactivosToolStripMenuItem2
        ' 
        InactivosToolStripMenuItem2.Name = "InactivosToolStripMenuItem2"
        InactivosToolStripMenuItem2.Size = New Size(121, 22)
        InactivosToolStripMenuItem2.Text = "Inactivos"
        ' 
        ' ProveedorToolStripMenuItem
        ' 
        ProveedorToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ProductosToolStripMenuItem1})
        ProveedorToolStripMenuItem.Image = My.Resources.Resources.proveedor
        ProveedorToolStripMenuItem.Name = "ProveedorToolStripMenuItem"
        ProveedorToolStripMenuItem.Size = New Size(81, 35)
        ProveedorToolStripMenuItem.Text = "Suministros"
        ProveedorToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' ProductosToolStripMenuItem1
        ' 
        ProductosToolStripMenuItem1.Name = "ProductosToolStripMenuItem1"
        ProductosToolStripMenuItem1.Size = New Size(128, 22)
        ProductosToolStripMenuItem1.Text = "Proveedor"
        ' 
        ' NegocioToolStripMenuItem
        ' 
        NegocioToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ReporteDeComprasToolStripMenuItem, ReportesDeVentasToolStripMenuItem})
        NegocioToolStripMenuItem.Image = My.Resources.Resources.grafico_de_barras
        NegocioToolStripMenuItem.Name = "NegocioToolStripMenuItem"
        NegocioToolStripMenuItem.Size = New Size(60, 35)
        NegocioToolStripMenuItem.Text = "Reporte"
        NegocioToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' ReporteDeComprasToolStripMenuItem
        ' 
        ReporteDeComprasToolStripMenuItem.Name = "ReporteDeComprasToolStripMenuItem"
        ReporteDeComprasToolStripMenuItem.Size = New Size(180, 22)
        ReporteDeComprasToolStripMenuItem.Text = "Reporte de compras"
        ' 
        ' ReportesDeVentasToolStripMenuItem
        ' 
        ReportesDeVentasToolStripMenuItem.Name = "ReportesDeVentasToolStripMenuItem"
        ReportesDeVentasToolStripMenuItem.Size = New Size(180, 22)
        ReportesDeVentasToolStripMenuItem.Text = "Reportes de ventas"
        ' 
        ' BackToolStripMenuItem
        ' 
        BackToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CopiaDeSeguridadToolStripMenuItem})
        BackToolStripMenuItem.Image = My.Resources.Resources.transferir_datos
        BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        BackToolStripMenuItem.Size = New Size(58, 35)
        BackToolStripMenuItem.Text = "Backup"
        BackToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' CopiaDeSeguridadToolStripMenuItem
        ' 
        CopiaDeSeguridadToolStripMenuItem.Name = "CopiaDeSeguridadToolStripMenuItem"
        CopiaDeSeguridadToolStripMenuItem.Size = New Size(174, 22)
        CopiaDeSeguridadToolStripMenuItem.Text = "copia de seguridad"
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Items.AddRange(New ToolStripItem() {TSalir, LblBienvenido})
        ToolStrip1.Location = New Point(0, 39)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(928, 25)
        ToolStrip1.TabIndex = 2
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' TSalir
        ' 
        TSalir.Alignment = ToolStripItemAlignment.Right
        TSalir.DisplayStyle = ToolStripItemDisplayStyle.Image
        TSalir.Image = My.Resources.Resources.borrar
        TSalir.ImageAlign = ContentAlignment.MiddleRight
        TSalir.ImageTransparentColor = Color.Magenta
        TSalir.Name = "TSalir"
        TSalir.Size = New Size(23, 22)
        TSalir.Text = "ToolStripButton1"
        ' 
        ' LblBienvenido
        ' 
        LblBienvenido.Font = New Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblBienvenido.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        LblBienvenido.Name = "LblBienvenido"
        LblBienvenido.Size = New Size(0, 22)
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.inicio_sesion
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(928, 450)
        Controls.Add(ToolStrip1)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "Form2"
        Text = "Administrador"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RolToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NegocioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesDeVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TSalir As ToolStripButton
    Friend WithEvents LblBienvenido As ToolStripLabel
    Friend WithEvents AltaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActivosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InactivosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActivosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InactivosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ActivosToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents InactivosToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProductosActivosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosSinStockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiaDeSeguridadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
End Class
