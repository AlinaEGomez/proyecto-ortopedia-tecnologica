<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        ToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripMenuItem6 = New ToolStripMenuItem()
        MenuStrip2 = New MenuStrip()
        VentaToolStripMenuItem = New ToolStripMenuItem()
        ClientesToolStripMenuItem = New ToolStripMenuItem()
        ProveedoresToolStripMenuItem = New ToolStripMenuItem()
        ReportesToolStripMenuItem = New ToolStripMenuItem()
        ProductosToolStripMenuItem = New ToolStripMenuItem()
        CategoriaToolStripMenuItem = New ToolStripMenuItem()
        InsumosToolStripMenuItem = New ToolStripMenuItem()
        ProtesisToolStripMenuItem = New ToolStripMenuItem()
        CounicacionToolStripMenuItem = New ToolStripMenuItem()
        FiltrarToolStripMenuItem = New ToolStripMenuItem()
        LBienvenido = New ToolStrip()
        TSalir = New ToolStripButton()
        ToolStripLabel1 = New ToolStripLabel()
        LblBienvenido = New ToolStripLabel()
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
        ToolStripMenuItem6.Size = New Size(67, 22)
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.Items.AddRange(New ToolStripItem() {VentaToolStripMenuItem, ClientesToolStripMenuItem, ProveedoresToolStripMenuItem, ReportesToolStripMenuItem, ProductosToolStripMenuItem})
        MenuStrip2.Location = New Point(0, 0)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.Size = New Size(800, 24)
        MenuStrip2.TabIndex = 0
        MenuStrip2.Text = "MenuStrip2"
        ' 
        ' VentaToolStripMenuItem
        ' 
        VentaToolStripMenuItem.Image = My.Resources.Resources.analisis1
        VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
        VentaToolStripMenuItem.Size = New Size(64, 20)
        VentaToolStripMenuItem.Text = "Venta"
        ' 
        ' ClientesToolStripMenuItem
        ' 
        ClientesToolStripMenuItem.Image = My.Resources.Resources.mercado
        ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        ClientesToolStripMenuItem.Size = New Size(77, 20)
        ClientesToolStripMenuItem.Text = "Clientes"
        ' 
        ' ProveedoresToolStripMenuItem
        ' 
        ProveedoresToolStripMenuItem.Image = My.Resources.Resources.proveedor
        ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        ProveedoresToolStripMenuItem.Size = New Size(92, 20)
        ProveedoresToolStripMenuItem.Text = "Suministro"
        ' 
        ' ReportesToolStripMenuItem
        ' 
        ReportesToolStripMenuItem.Image = My.Resources.Resources.grafico_de_barras
        ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        ReportesToolStripMenuItem.Size = New Size(81, 20)
        ReportesToolStripMenuItem.Text = "Reportes"
        ' 
        ' ProductosToolStripMenuItem
        ' 
        ProductosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CategoriaToolStripMenuItem, FiltrarToolStripMenuItem})
        ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        ProductosToolStripMenuItem.Size = New Size(73, 20)
        ProductosToolStripMenuItem.Text = "Productos"
        ' 
        ' CategoriaToolStripMenuItem
        ' 
        CategoriaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {InsumosToolStripMenuItem, ProtesisToolStripMenuItem, CounicacionToolStripMenuItem})
        CategoriaToolStripMenuItem.Name = "CategoriaToolStripMenuItem"
        CategoriaToolStripMenuItem.Size = New Size(123, 22)
        CategoriaToolStripMenuItem.Text = "categoria"
        ' 
        ' InsumosToolStripMenuItem
        ' 
        InsumosToolStripMenuItem.Name = "InsumosToolStripMenuItem"
        InsumosToolStripMenuItem.Size = New Size(139, 22)
        InsumosToolStripMenuItem.Text = "sensorial"
        ' 
        ' ProtesisToolStripMenuItem
        ' 
        ProtesisToolStripMenuItem.Name = "ProtesisToolStripMenuItem"
        ProtesisToolStripMenuItem.Size = New Size(139, 22)
        ProtesisToolStripMenuItem.Text = "movilidad"
        ' 
        ' CounicacionToolStripMenuItem
        ' 
        CounicacionToolStripMenuItem.Name = "CounicacionToolStripMenuItem"
        CounicacionToolStripMenuItem.Size = New Size(139, 22)
        CounicacionToolStripMenuItem.Text = "counicacion"
        ' 
        ' FiltrarToolStripMenuItem
        ' 
        FiltrarToolStripMenuItem.Name = "FiltrarToolStripMenuItem"
        FiltrarToolStripMenuItem.Size = New Size(123, 22)
        FiltrarToolStripMenuItem.Text = "Ver Todo"
        ' 
        ' LBienvenido
        ' 
        LBienvenido.Font = New Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBienvenido.Items.AddRange(New ToolStripItem() {TSalir, ToolStripLabel1, LblBienvenido})
        LBienvenido.Location = New Point(0, 24)
        LBienvenido.Name = "LBienvenido"
        LBienvenido.Size = New Size(800, 25)
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
        TSalir.Size = New Size(23, 22)
        ' 
        ' ToolStripLabel1
        ' 
        ToolStripLabel1.Name = "ToolStripLabel1"
        ToolStripLabel1.Size = New Size(0, 22)
        ' 
        ' LblBienvenido
        ' 
        LblBienvenido.ForeColor = Color.Red
        LblBienvenido.Name = "LblBienvenido"
        LblBienvenido.Size = New Size(0, 22)
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.inicio_sesion1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(LBienvenido)
        Controls.Add(MenuStrip2)
        MainMenuStrip = MenuStrip2
        MdiChildrenMinimizedAnchorBottom = False
        Name = "Form4"
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
    Friend WithEvents InsumosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProtesisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CounicacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FiltrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TSalir As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents LBienvenido As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents LblBienvenido As ToolStripLabel
End Class
