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
        BtnAtras = New Button()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {VentasToolStripMenuItem, ClientesToolStripMenuItem, ProductosToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 39)
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
        RgistrarVentasToolStripMenuItem.Size = New Size(151, 22)
        RgistrarVentasToolStripMenuItem.Text = "Rgistrar ventas"
        ' 
        ' VerVentasToolStripMenuItem
        ' 
        VerVentasToolStripMenuItem.Name = "VerVentasToolStripMenuItem"
        VerVentasToolStripMenuItem.Size = New Size(151, 22)
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
        AltaToolStripMenuItem.Size = New Size(180, 22)
        AltaToolStripMenuItem.Text = "Alta"
        ' 
        ' EditarToolStripMenuItem
        ' 
        EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        EditarToolStripMenuItem.Size = New Size(180, 22)
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
        CategoriaToolStripMenuItem.Size = New Size(180, 22)
        CategoriaToolStripMenuItem.Text = "categoria"
        ' 
        ' SensorialToolStripMenuItem
        ' 
        SensorialToolStripMenuItem.Name = "SensorialToolStripMenuItem"
        SensorialToolStripMenuItem.Size = New Size(180, 22)
        SensorialToolStripMenuItem.Text = "sensorial"
        ' 
        ' MovilidadToolStripMenuItem
        ' 
        MovilidadToolStripMenuItem.Name = "MovilidadToolStripMenuItem"
        MovilidadToolStripMenuItem.Size = New Size(180, 22)
        MovilidadToolStripMenuItem.Text = "movilidad"
        ' 
        ' ComunicacionToolStripMenuItem
        ' 
        ComunicacionToolStripMenuItem.Name = "ComunicacionToolStripMenuItem"
        ComunicacionToolStripMenuItem.Size = New Size(180, 22)
        ComunicacionToolStripMenuItem.Text = "comunicacion"
        ' 
        ' VerTodoToolStripMenuItem
        ' 
        VerTodoToolStripMenuItem.Name = "VerTodoToolStripMenuItem"
        VerTodoToolStripMenuItem.Size = New Size(180, 22)
        VerTodoToolStripMenuItem.Text = "Ver Todo"
        ' 
        ' BtnAtras
        ' 
        BtnAtras.Location = New Point(569, 90)
        BtnAtras.Name = "BtnAtras"
        BtnAtras.Size = New Size(75, 23)
        BtnAtras.TabIndex = 1
        BtnAtras.Text = "Atras"
        BtnAtras.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.inicio_sesion1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(BtnAtras)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form3"
        Text = "perfil vendedor"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
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
    Friend WithEvents BtnAtras As Button
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SensorialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovilidadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComunicacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerTodoToolStripMenuItem As ToolStripMenuItem
End Class
