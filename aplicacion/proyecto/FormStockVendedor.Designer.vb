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
        Button1 = New Button()
        Label1 = New Label()
        CType(DgvStock, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DgvStock
        ' 
        DgvStock.BackgroundColor = Color.IndianRed
        DgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvStock.Location = New Point(80, 241)
        DgvStock.Margin = New Padding(3, 4, 3, 4)
        DgvStock.Name = "DgvStock"
        DgvStock.RowHeadersWidth = 51
        DgvStock.Size = New Size(734, 200)
        DgvStock.TabIndex = 0
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = Color.DodgerBlue
        btnBuscar.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBuscar.Location = New Point(541, 99)
        btnBuscar.Margin = New Padding(3, 4, 3, 4)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(237, 50)
        btnBuscar.TabIndex = 1
        btnBuscar.Text = "Buscar Producto"
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' txtBuscarProd
        ' 
        txtBuscarProd.Location = New Point(247, 122)
        txtBuscarProd.Margin = New Padding(3, 4, 3, 4)
        txtBuscarProd.Name = "txtBuscarProd"
        txtBuscarProd.Size = New Size(151, 27)
        txtBuscarProd.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DodgerBlue
        Button1.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(690, 482)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(124, 63)
        Button1.TabIndex = 3
        Button1.Text = "Cerrar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Emoji", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(90, 112)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 37)
        Label1.TabIndex = 4
        Label1.Text = "Producto"
        ' 
        ' FormStockVendedor
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = My.Resources.Resources.silla
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(914, 600)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(txtBuscarProd)
        Controls.Add(btnBuscar)
        Controls.Add(DgvStock)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormStockVendedor"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Stock Vendedor"
        CType(DgvStock, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DgvStock As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBuscarProd As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
