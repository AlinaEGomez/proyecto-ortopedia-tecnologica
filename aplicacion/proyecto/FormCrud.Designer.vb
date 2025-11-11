<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCrud
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
        DgvClientes = New DataGridView()
        CType(DgvClientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DgvClientes
        ' 
        DgvClientes.BackgroundColor = SystemColors.ButtonFace
        DgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvClientes.Location = New Point(74, 143)
        DgvClientes.Margin = New Padding(3, 4, 3, 4)
        DgvClientes.Name = "DgvClientes"
        DgvClientes.RowHeadersWidth = 51
        DgvClientes.Size = New Size(714, 296)
        DgvClientes.TabIndex = 0
        ' 
        ' FormCrud
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.nueva
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(914, 600)
        Controls.Add(DgvClientes)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormCrud"
        StartPosition = FormStartPosition.CenterScreen
        Text = "crud"
        CType(DgvClientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents DgvClientes As DataGridView
End Class
