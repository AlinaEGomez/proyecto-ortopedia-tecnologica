<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        VentasToolStripMenuItem = New ToolStripMenuItem()
        RgistrarVentasToolStripMenuItem = New ToolStripMenuItem()
        VerVentasToolStripMenuItem = New ToolStripMenuItem()
        ClientesToolStripMenuItem = New ToolStripMenuItem()
        AltaToolStripMenuItem = New ToolStripMenuItem()
        EditarToolStripMenuItem = New ToolStripMenuItem()
        ProductosToolStripMenuItem = New ToolStripMenuItem()
        CategoriaToolStripMenuItem = New ToolStripMenuItem()
        SensorialToolStripMenuItem = New ToolStripMenuItem()
        MovilidadToolStripMenuItem = New ToolStripMenuItem()
        ComunicacionToolStripMenuItem = New ToolStripMenuItem()
        VerTodoToolStripMenuItem = New ToolStripMenuItem()
        ToolStrip1 = New ToolStrip()
        ToolStripButton1 = New ToolStripButton()
        LblBienvenido = New ToolStripLabel()
        MenuStrip1.SuspendLayout()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {VentasToolStripMenuItem, ClientesToolStripMenuItem, ProductosToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(834, 39)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' VentasToolStripMenuItem
        ' 
        VentasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RgistrarVentasToolStripMenuItem, VerVentasToolStripMenuItem})
        VentasToolStripMenuItem.Image = My.Resources.Resources.analisis1
        VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        VentasToolStripMenuItem.Size = New Size(53, 35)
        VentasToolStripMenuItem.Text = "Ventas"
        VentasToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' RgistrarVentasToolStripMenuItem
        ' 
        RgistrarVentasToolStripMenuItem.Name = "RgistrarVentasToolStripMenuItem"
        RgistrarVentasToolStripMenuItem.Size = New Size(180, 22)
        RgistrarVentasToolStripMenuItem.Text = "Registrar ventas"
        ' 
        ' VerVentasToolStripMenuItem
        ' 
        VerVentasToolStripMenuItem.Name = "VerVentasToolStripMenuItem"
        VerVentasToolStripMenuItem.Size = New Size(180, 22)
        VerVentasToolStripMenuItem.Text = "Ver ventas"
        ' 
        ' ClientesToolStripMenuItem
        ' 
        ClientesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AltaToolStripMenuItem, EditarToolStripMenuItem})
        ClientesToolStripMenuItem.Image = My.Resources.Resources.mercado1
        ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        ClientesToolStripMenuItem.Size = New Size(61, 35)
        ClientesToolStripMenuItem.Text = "Clientes"
        ClientesToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' AltaToolStripMenuItem
        ' 
        AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        AltaToolStripMenuItem.Size = New Size(104, 22)
        AltaToolStripMenuItem.Text = "Alta"
        ' 
        ' EditarToolStripMenuItem
        ' 
        EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        EditarToolStripMenuItem.Size = New Size(104, 22)
        EditarToolStripMenuItem.Text = "Editar"
        ' 
        ' ProductosToolStripMenuItem
        ' 
        ProductosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CategoriaToolStripMenuItem, VerTodoToolStripMenuItem})
        ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        ProductosToolStripMenuItem.Size = New Size(73, 35)
        ProductosToolStripMenuItem.Text = "productos"
        ' 
        ' CategoriaToolStripMenuItem
        ' 
        CategoriaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SensorialToolStripMenuItem, MovilidadToolStripMenuItem, ComunicacionToolStripMenuItem})
        CategoriaToolStripMenuItem.Name = "CategoriaToolStripMenuItem"
        CategoriaToolStripMenuItem.Size = New Size(123, 22)
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
        ' ComunicacionToolStripMenuItem
        ' 
        ComunicacionToolStripMenuItem.Name = "ComunicacionToolStripMenuItem"
        ComunicacionToolStripMenuItem.Size = New Size(150, 22)
        ComunicacionToolStripMenuItem.Text = "comunicacion"
        ' 
        ' VerTodoToolStripMenuItem
        ' 
        VerTodoToolStripMenuItem.Name = "VerTodoToolStripMenuItem"
        VerTodoToolStripMenuItem.Size = New Size(123, 22)
        VerTodoToolStripMenuItem.Text = "Ver Todo"
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripButton1, LblBienvenido})
        ToolStrip1.Location = New Point(0, 39)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(834, 25)
        ToolStrip1.TabIndex = 2
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ToolStripButton1
        ' 
        ToolStripButton1.Alignment = ToolStripItemAlignment.Right
        ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton1.Image = My.Resources.Resources.borrar
        ToolStripButton1.ImageTransparentColor = Color.Magenta
        ToolStripButton1.Name = "ToolStripButton1"
        ToolStripButton1.Size = New Size(23, 22)
        ToolStripButton1.Text = "ToolStripButton1"
        ' 
        ' LblBienvenido
        ' 
        LblBienvenido.Font = New Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblBienvenido.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        LblBienvenido.Name = "LblBienvenido"
        LblBienvenido.Size = New Size(0, 22)
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.inicio_sesion1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(834, 450)
        Controls.Add(ToolStrip1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form3"
        Text = "perfil vendedor"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RgistrarVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SensorialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovilidadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComunicacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents LblBienvenido As ToolStripLabel
End Class
