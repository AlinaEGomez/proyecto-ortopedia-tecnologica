<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        MenuStrip1 = New MenuStrip()
        RolToolStripMenuItem = New ToolStripMenuItem()
        VendedorToolStripMenuItem = New ToolStripMenuItem()
        GerenteToolStripMenuItem = New ToolStripMenuItem()
        AdministradorToolStripMenuItem = New ToolStripMenuItem()
        MantenimientoToolStripMenuItem = New ToolStripMenuItem()
        VentasToolStripMenuItem = New ToolStripMenuItem()
        ComprasToolStripMenuItem = New ToolStripMenuItem()
        ClientesToolStripMenuItem = New ToolStripMenuItem()
        ProveedorToolStripMenuItem = New ToolStripMenuItem()
        NegocioToolStripMenuItem = New ToolStripMenuItem()
        BackToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.GripStyle = ToolStripGripStyle.Visible
        MenuStrip1.Items.AddRange(New ToolStripItem() {RolToolStripMenuItem, MantenimientoToolStripMenuItem, VentasToolStripMenuItem, ComprasToolStripMenuItem, ClientesToolStripMenuItem, ProveedorToolStripMenuItem, NegocioToolStripMenuItem, BackToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.RenderMode = ToolStripRenderMode.Professional
        MenuStrip1.Size = New Size(928, 39)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' RolToolStripMenuItem
        ' 
        RolToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {VendedorToolStripMenuItem, GerenteToolStripMenuItem, AdministradorToolStripMenuItem})
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
        ' AdministradorToolStripMenuItem
        ' 
        AdministradorToolStripMenuItem.Name = "AdministradorToolStripMenuItem"
        AdministradorToolStripMenuItem.Size = New Size(180, 22)
        AdministradorToolStripMenuItem.Text = "Administrador"
        ' 
        ' MantenimientoToolStripMenuItem
        ' 
        MantenimientoToolStripMenuItem.Image = My.Resources.Resources.equipo
        MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        MantenimientoToolStripMenuItem.Size = New Size(101, 35)
        MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        MantenimientoToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' VentasToolStripMenuItem
        ' 
        VentasToolStripMenuItem.Image = My.Resources.Resources.analisis
        VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        VentasToolStripMenuItem.Size = New Size(53, 35)
        VentasToolStripMenuItem.Text = "Ventas"
        VentasToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' ComprasToolStripMenuItem
        ' 
        ComprasToolStripMenuItem.Image = My.Resources.Resources.carrito_de_compras
        ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        ComprasToolStripMenuItem.Size = New Size(67, 35)
        ComprasToolStripMenuItem.Text = "Compras"
        ComprasToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText
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
        ProveedorToolStripMenuItem.Image = My.Resources.Resources.proveedor
        ProveedorToolStripMenuItem.Name = "ProveedorToolStripMenuItem"
        ProveedorToolStripMenuItem.Size = New Size(73, 35)
        ProveedorToolStripMenuItem.Text = "Proveedor"
        ProveedorToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' NegocioToolStripMenuItem
        ' 
        NegocioToolStripMenuItem.Image = My.Resources.Resources.grafico_de_barras
        NegocioToolStripMenuItem.Name = "NegocioToolStripMenuItem"
        NegocioToolStripMenuItem.Size = New Size(60, 35)
        NegocioToolStripMenuItem.Text = "Reporte"
        NegocioToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' BackToolStripMenuItem
        ' 
        BackToolStripMenuItem.Image = My.Resources.Resources.transferir_datos
        BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        BackToolStripMenuItem.Size = New Size(58, 35)
        BackToolStripMenuItem.Text = "Backup"
        BackToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.inicio_sesion
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(928, 450)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form2"
        Text = "Bienvenido al Sistema"
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
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NegocioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents AdministradorToolStripMenuItem As ToolStripMenuItem
End Class
