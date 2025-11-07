<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMisVentas
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
        DgvMisVentas = New DataGridView()
        btnActualizar = New Button()
        CType(DgvMisVentas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DgvMisVentas
        ' 
        DgvMisVentas.AllowUserToOrderColumns = True
        DgvMisVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvMisVentas.Location = New Point(210, 31)
        DgvMisVentas.Name = "DgvMisVentas"
        DgvMisVentas.Size = New Size(368, 150)
        DgvMisVentas.TabIndex = 0
        ' 
        ' btnActualizar
        ' 
        btnActualizar.BackColor = Color.Honeydew
        btnActualizar.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnActualizar.Location = New Point(287, 243)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(178, 49)
        btnActualizar.TabIndex = 1
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = False
        ' 
        ' FormMisVentas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Green
        BackgroundImage = My.Resources.Resources.ventasMias2
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(848, 450)
        Controls.Add(btnActualizar)
        Controls.Add(DgvMisVentas)
        Name = "FormMisVentas"
        Text = "FormMisVentas"
        CType(DgvMisVentas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DgvMisVentas As DataGridView
    Friend WithEvents btnActualizar As Button
End Class
