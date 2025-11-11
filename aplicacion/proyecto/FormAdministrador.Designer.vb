<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdministrador
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
        UsuariosToolStripMenuItem = New ToolStripMenuItem()
        MantenimientoToolStripMenuItem = New ToolStripMenuItem()
        ProductosToolStripMenuItem = New ToolStripMenuItem()
        AltaToolStripMenuItem1 = New ToolStripMenuItem()
        ClientesToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        ProveedorToolStripMenuItem = New ToolStripMenuItem()
        ProductosToolStripMenuItem1 = New ToolStripMenuItem()
        NegocioToolStripMenuItem = New ToolStripMenuItem()
        ReporteDeComprasToolStripMenuItem = New ToolStripMenuItem()
        ReportesDeVentasToolStripMenuItem = New ToolStripMenuItem()
        BackToolStripMenuItem = New ToolStripMenuItem()
        CopiaDeSeguridadToolStripMenuItem = New ToolStripMenuItem()
        ExcelDeBackupToolStripMenuItem = New ToolStripMenuItem()
        ToolStrip1 = New ToolStrip()
        TSalir = New ToolStripButton()
        LblBienvenido = New ToolStripLabel()
        RegistroDeComprasToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.GripStyle = ToolStripGripStyle.Visible
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {RolToolStripMenuItem, MantenimientoToolStripMenuItem, ClientesToolStripMenuItem, ToolStripMenuItem1, ProveedorToolStripMenuItem, NegocioToolStripMenuItem, BackToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(3, 3, 0, 3)
        MenuStrip1.RenderMode = ToolStripRenderMode.Professional
        MenuStrip1.Size = New Size(1061, 50)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' RolToolStripMenuItem
        ' 
        RolToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {VendedorToolStripMenuItem, UsuariosToolStripMenuItem})
        RolToolStripMenuItem.Image = My.Resources.Resources.datos_del_usuario
        RolToolStripMenuItem.Name = "RolToolStripMenuItem"
        RolToolStripMenuItem.Size = New Size(79, 44)
        RolToolStripMenuItem.Text = "Usuarios"
        RolToolStripMenuItem.TextAlign = ContentAlignment.BottomCenter
        RolToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' VendedorToolStripMenuItem
        ' 
        VendedorToolStripMenuItem.Name = "VendedorToolStripMenuItem"
        VendedorToolStripMenuItem.Size = New Size(177, 26)
        VendedorToolStripMenuItem.Text = "Crud Usuario"
        VendedorToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' UsuariosToolStripMenuItem
        ' 
        UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        UsuariosToolStripMenuItem.Size = New Size(177, 26)
        UsuariosToolStripMenuItem.Text = "Usuarios"
        ' 
        ' MantenimientoToolStripMenuItem
        ' 
        MantenimientoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ProductosToolStripMenuItem})
        MantenimientoToolStripMenuItem.Image = My.Resources.Resources.equipo
        MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        MantenimientoToolStripMenuItem.Size = New Size(124, 44)
        MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        MantenimientoToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' ProductosToolStripMenuItem
        ' 
        ProductosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AltaToolStripMenuItem1})
        ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        ProductosToolStripMenuItem.Size = New Size(224, 26)
        ProductosToolStripMenuItem.Text = "Productos"
        ' 
        ' AltaToolStripMenuItem1
        ' 
        AltaToolStripMenuItem1.Name = "AltaToolStripMenuItem1"
        AltaToolStripMenuItem1.Size = New Size(158, 26)
        AltaToolStripMenuItem1.Text = "Inventario"
        ' 
        ' ClientesToolStripMenuItem
        ' 
        ClientesToolStripMenuItem.Image = My.Resources.Resources.mercado
        ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        ClientesToolStripMenuItem.Size = New Size(126, 44)
        ClientesToolStripMenuItem.Text = "Admin. Clientes"
        ClientesToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Image = My.Resources.Resources.mercado
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(130, 44)
        ToolStripMenuItem1.Text = "Admin. Usuarios"
        ToolStripMenuItem1.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' ProveedorToolStripMenuItem
        ' 
        ProveedorToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ProductosToolStripMenuItem1, RegistroDeComprasToolStripMenuItem})
        ProveedorToolStripMenuItem.Image = My.Resources.Resources.proveedor
        ProveedorToolStripMenuItem.Name = "ProveedorToolStripMenuItem"
        ProveedorToolStripMenuItem.Size = New Size(99, 44)
        ProveedorToolStripMenuItem.Text = "Suministros"
        ProveedorToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' ProductosToolStripMenuItem1
        ' 
        ProductosToolStripMenuItem1.Name = "ProductosToolStripMenuItem1"
        ProductosToolStripMenuItem1.Size = New Size(224, 26)
        ProductosToolStripMenuItem1.Text = "Proveedor"
        ' 
        ' NegocioToolStripMenuItem
        ' 
        NegocioToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ReporteDeComprasToolStripMenuItem, ReportesDeVentasToolStripMenuItem})
        NegocioToolStripMenuItem.Image = My.Resources.Resources.grafico_de_barras
        NegocioToolStripMenuItem.Name = "NegocioToolStripMenuItem"
        NegocioToolStripMenuItem.Size = New Size(76, 44)
        NegocioToolStripMenuItem.Text = "Reporte"
        NegocioToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' ReporteDeComprasToolStripMenuItem
        ' 
        ReporteDeComprasToolStripMenuItem.Name = "ReporteDeComprasToolStripMenuItem"
        ReporteDeComprasToolStripMenuItem.Size = New Size(227, 26)
        ReporteDeComprasToolStripMenuItem.Text = "Reporte de compras"
        ' 
        ' ReportesDeVentasToolStripMenuItem
        ' 
        ReportesDeVentasToolStripMenuItem.Name = "ReportesDeVentasToolStripMenuItem"
        ReportesDeVentasToolStripMenuItem.Size = New Size(227, 26)
        ReportesDeVentasToolStripMenuItem.Text = "Reportes de ventas"
        ' 
        ' BackToolStripMenuItem
        ' 
        BackToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CopiaDeSeguridadToolStripMenuItem, ExcelDeBackupToolStripMenuItem})
        BackToolStripMenuItem.Image = My.Resources.Resources.transferir_datos
        BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        BackToolStripMenuItem.Size = New Size(71, 44)
        BackToolStripMenuItem.Text = "Backup"
        BackToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' CopiaDeSeguridadToolStripMenuItem
        ' 
        CopiaDeSeguridadToolStripMenuItem.Name = "CopiaDeSeguridadToolStripMenuItem"
        CopiaDeSeguridadToolStripMenuItem.Size = New Size(224, 26)
        CopiaDeSeguridadToolStripMenuItem.Text = "copia de seguridad"
        ' 
        ' ExcelDeBackupToolStripMenuItem
        ' 
        ExcelDeBackupToolStripMenuItem.Name = "ExcelDeBackupToolStripMenuItem"
        ExcelDeBackupToolStripMenuItem.Size = New Size(224, 26)
        ExcelDeBackupToolStripMenuItem.Text = "excel de backup"
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.ImageScalingSize = New Size(20, 20)
        ToolStrip1.Items.AddRange(New ToolStripItem() {TSalir, LblBienvenido})
        ToolStrip1.Location = New Point(0, 50)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(1061, 27)
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
        TSalir.Size = New Size(29, 24)
        TSalir.Text = "ToolStripButton1"
        ' 
        ' LblBienvenido
        ' 
        LblBienvenido.Font = New Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblBienvenido.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        LblBienvenido.Name = "LblBienvenido"
        LblBienvenido.Size = New Size(0, 24)
        ' 
        ' RegistroDeComprasToolStripMenuItem
        ' 
        RegistroDeComprasToolStripMenuItem.Name = "RegistroDeComprasToolStripMenuItem"
        RegistroDeComprasToolStripMenuItem.Size = New Size(231, 26)
        RegistroDeComprasToolStripMenuItem.Text = "Registro de Compras"
        ' 
        ' FormAdministrador
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.inicio_sesion
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1061, 600)
        Controls.Add(ToolStrip1)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormAdministrador"
        StartPosition = FormStartPosition.CenterScreen
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
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopiaDeSeguridadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExcelDeBackupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RegistroDeComprasToolStripMenuItem As ToolStripMenuItem
End Class
