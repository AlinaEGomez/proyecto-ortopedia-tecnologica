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
        Button1 = New Button()
        CType(DgvMisVentasGerente, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DgvMisVentasGerente
        ' 
        DgvMisVentasGerente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvMisVentasGerente.Location = New Point(83, 125)
        DgvMisVentasGerente.Margin = New Padding(3, 4, 3, 4)
        DgvMisVentasGerente.Name = "DgvMisVentasGerente"
        DgvMisVentasGerente.RowHeadersWidth = 51
        DgvMisVentasGerente.Size = New Size(758, 278)
        DgvMisVentasGerente.TabIndex = 0
        ' 
        ' btnActualizar
        ' 
        btnActualizar.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        btnActualizar.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnActualizar.Location = New Point(150, 460)
        btnActualizar.Margin = New Padding(3, 4, 3, 4)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(187, 61)
        btnActualizar.TabIndex = 1
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        Button1.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(563, 460)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(187, 61)
        Button1.TabIndex = 2
        Button1.Text = "Cerrar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' FormMisVentasGerente
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.vendedor
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(914, 600)
        Controls.Add(Button1)
        Controls.Add(btnActualizar)
        Controls.Add(DgvMisVentasGerente)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormMisVentasGerente"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Ventas Gerente"
        CType(DgvMisVentasGerente, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DgvMisVentasGerente As DataGridView
    Friend WithEvents btnActualizar As Button
    Friend WithEvents Button1 As Button
End Class
