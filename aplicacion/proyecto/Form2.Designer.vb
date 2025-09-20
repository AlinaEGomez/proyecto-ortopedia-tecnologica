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
        GerenteToolStripMenuItem = New ToolStripMenuItem()
        MantenimientoToolStripMenuItem = New ToolStripMenuItem()
        ProductosToolStripMenuItem = New ToolStripMenuItem()
        CategoriaToolStripMenuItem = New ToolStripMenuItem()
        SensorialToolStripMenuItem = New ToolStripMenuItem()
        MovilidadToolStripMenuItem = New ToolStripMenuItem()
        CominucacionToolStripMenuItem = New ToolStripMenuItem()
        AgregarMasToolStripMenuItem = New ToolStripMenuItem()
        NegocioToolStripMenuItem1 = New ToolStripMenuItem()
        ClientesToolStripMenuItem = New ToolStripMenuItem()
        ProveedorToolStripMenuItem = New ToolStripMenuItem()
        ProductosToolStripMenuItem1 = New ToolStripMenuItem()
        NegocioToolStripMenuItem = New ToolStripMenuItem()
        ReporteDeComprasToolStripMenuItem = New ToolStripMenuItem()
        ReportesDeVentasToolStripMenuItem = New ToolStripMenuItem()
        BackToolStripMenuItem = New ToolStripMenuItem()
        BtnSalir = New Button()
        MenuStrip1.SuspendLayout()
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
        RolToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {VendedorToolStripMenuItem, GerenteToolStripMenuItem})
        RolToolStripMenuItem.Image = My.Resources.Resources.datos_del_usuario
        RolToolStripMenuItem.Name = "RolToolStripMenuItem"
        RolToolStripMenuItem.Size = New Size(64, 35)
        RolToolStripMenuItem.Text = "Usuarios"
        RolToolStripMenuItem.TextAlign = ContentAlignment.BottomCenter
        RolToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' VendedorToolStripMenuItem
        ' 
        VendedorToolStripMenuItem.Name = "VendedorToolStripMenuItem"
        VendedorToolStripMenuItem.Size = New Size(180, 22)
        VendedorToolStripMenuItem.Text = "Vendedor"
        VendedorToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' GerenteToolStripMenuItem
        ' 
        GerenteToolStripMenuItem.Name = "GerenteToolStripMenuItem"
        GerenteToolStripMenuItem.Size = New Size(180, 22)
        GerenteToolStripMenuItem.Text = "Gerente"
        ' 
        ' MantenimientoToolStripMenuItem
        ' 
        MantenimientoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ProductosToolStripMenuItem, CategoriaToolStripMenuItem, NegocioToolStripMenuItem1})
        MantenimientoToolStripMenuItem.Image = My.Resources.Resources.equipo
        MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        MantenimientoToolStripMenuItem.Size = New Size(101, 35)
        MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        MantenimientoToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' ProductosToolStripMenuItem
        ' 
        ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        ProductosToolStripMenuItem.Size = New Size(128, 22)
        ProductosToolStripMenuItem.Text = "Productos"
        ' 
        ' CategoriaToolStripMenuItem
        ' 
        CategoriaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SensorialToolStripMenuItem, MovilidadToolStripMenuItem, CominucacionToolStripMenuItem, AgregarMasToolStripMenuItem})
        CategoriaToolStripMenuItem.Name = "CategoriaToolStripMenuItem"
        CategoriaToolStripMenuItem.Size = New Size(128, 22)
        CategoriaToolStripMenuItem.Text = "categoria"
        ' 
        ' SensorialToolStripMenuItem
        ' 
        SensorialToolStripMenuItem.Name = "SensorialToolStripMenuItem"
        SensorialToolStripMenuItem.Size = New Size(150, 22)
        SensorialToolStripMenuItem.Text = "sensorial"
        ' 
        ' MovilidadToolStripMenuItem
        ' 
        MovilidadToolStripMenuItem.Name = "MovilidadToolStripMenuItem"
        MovilidadToolStripMenuItem.Size = New Size(150, 22)
        MovilidadToolStripMenuItem.Text = "movilidad"
        ' 
        ' CominucacionToolStripMenuItem
        ' 
        CominucacionToolStripMenuItem.Name = "CominucacionToolStripMenuItem"
        CominucacionToolStripMenuItem.Size = New Size(150, 22)
        CominucacionToolStripMenuItem.Text = "cominucacion"
        ' 
        ' AgregarMasToolStripMenuItem
        ' 
        AgregarMasToolStripMenuItem.Name = "AgregarMasToolStripMenuItem"
        AgregarMasToolStripMenuItem.Size = New Size(150, 22)
        AgregarMasToolStripMenuItem.Text = "agregar mas"
        ' 
        ' NegocioToolStripMenuItem1
        ' 
        NegocioToolStripMenuItem1.Name = "NegocioToolStripMenuItem1"
        NegocioToolStripMenuItem1.Size = New Size(128, 22)
        NegocioToolStripMenuItem1.Text = "Negocio"
        ' 
        ' ClientesToolStripMenuItem
        ' 
        ClientesToolStripMenuItem.Image = My.Resources.Resources.mercado
        ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        ClientesToolStripMenuItem.Size = New Size(61, 35)
        ClientesToolStripMenuItem.Text = "Clientes"
        ClientesToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText
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
        ProductosToolStripMenuItem1.Size = New Size(114, 22)
        ProductosToolStripMenuItem1.Text = "Entidad"
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
        BackToolStripMenuItem.Image = My.Resources.Resources.transferir_datos
        BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        BackToolStripMenuItem.Size = New Size(58, 35)
        BackToolStripMenuItem.Text = "Backup"
        BackToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' BtnSalir
        ' 
        BtnSalir.Location = New Point(657, 111)
        BtnSalir.Name = "BtnSalir"
        BtnSalir.Size = New Size(75, 23)
        BtnSalir.TabIndex = 1
        BtnSalir.Text = "salir"
        BtnSalir.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.inicio_sesion
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(928, 450)
        Controls.Add(BtnSalir)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form2"
        Text = "Administrador"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RolToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GerenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NegocioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NegocioToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ReporteDeComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesDeVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnSalir As Button
    Friend WithEvents SensorialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MovilidadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CominucacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarMasToolStripMenuItem As ToolStripMenuItem
End Class
