<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProducActiv
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
        DgvProductosConStock = New DataGridView()
        Button1 = New Button()
        CType(DgvProductosConStock, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DgvProductosConStock
        ' 
        DgvProductosConStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvProductosConStock.Location = New Point(77, 149)
        DgvProductosConStock.Margin = New Padding(3, 4, 3, 4)
        DgvProductosConStock.Name = "DgvProductosConStock"
        DgvProductosConStock.RowHeadersWidth = 51
        DgvProductosConStock.Size = New Size(755, 258)
        DgvProductosConStock.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        Button1.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(645, 461)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(187, 48)
        Button1.TabIndex = 3
        Button1.Text = "Cerrar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' FormProducActiv
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.silla
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(914, 600)
        Controls.Add(Button1)
        Controls.Add(DgvProductosConStock)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormProducActiv"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Productos Sin Stock"
        CType(DgvProductosConStock, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DgvProductosConStock As DataGridView
    Friend WithEvents Button1 As Button
End Class
