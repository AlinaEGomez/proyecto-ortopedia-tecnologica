<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMisVentasGerente
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
        DgvMisVentasGerente = New DataGridView()
        btnActualizar = New Button()
        CType(DgvMisVentasGerente, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DgvMisVentasGerente
        ' 
        DgvMisVentasGerente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvMisVentasGerente.Location = New Point(187, 94)
        DgvMisVentasGerente.Name = "DgvMisVentasGerente"
        DgvMisVentasGerente.Size = New Size(419, 150)
        DgvMisVentasGerente.TabIndex = 0
        ' 
        ' btnActualizar
        ' 
        btnActualizar.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        btnActualizar.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnActualizar.Location = New Point(334, 298)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(164, 46)
        btnActualizar.TabIndex = 1
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = False
        ' 
        ' FormMisVentasGerente
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Misventas
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(btnActualizar)
        Controls.Add(DgvMisVentasGerente)
        Name = "FormMisVentasGerente"
        Text = "Ventas Gerente"
        CType(DgvMisVentasGerente, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DgvMisVentasGerente As DataGridView
    Friend WithEvents btnActualizar As Button
End Class
