<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStockVendedor
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
        DgvStock = New DataGridView()
        btnBuscar = New Button()
        txtBuscarProd = New TextBox()
        CType(DgvStock, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DgvStock
        ' 
        DgvStock.BackgroundColor = Color.IndianRed
        DgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvStock.Location = New Point(196, 192)
        DgvStock.Name = "DgvStock"
        DgvStock.Size = New Size(405, 150)
        DgvStock.TabIndex = 0
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = Color.DodgerBlue
        btnBuscar.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBuscar.Location = New Point(363, 376)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(214, 47)
        btnBuscar.TabIndex = 1
        btnBuscar.Text = "Buscar Producto"
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' txtBuscarProd
        ' 
        txtBuscarProd.Location = New Point(187, 393)
        txtBuscarProd.Name = "txtBuscarProd"
        txtBuscarProd.Size = New Size(100, 23)
        txtBuscarProd.TabIndex = 2
        ' 
        ' FormStockVendedor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = My.Resources.Resources.buscarProducto
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(800, 450)
        Controls.Add(txtBuscarProd)
        Controls.Add(btnBuscar)
        Controls.Add(DgvStock)
        Name = "FormStockVendedor"
        Text = "Stock Vendedor"
        CType(DgvStock, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DgvStock As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBuscarProd As TextBox
End Class
