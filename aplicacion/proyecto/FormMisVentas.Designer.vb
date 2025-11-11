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
        Button1 = New Button()
        Label1 = New Label()
        CType(DgvMisVentas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DgvMisVentas
        ' 
        DgvMisVentas.AllowUserToOrderColumns = True
        DgvMisVentas.BackgroundColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        DgvMisVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvMisVentas.Location = New Point(72, 149)
        DgvMisVentas.Margin = New Padding(3, 4, 3, 4)
        DgvMisVentas.Name = "DgvMisVentas"
        DgvMisVentas.RowHeadersWidth = 51
        DgvMisVentas.Size = New Size(821, 200)
        DgvMisVentas.TabIndex = 0
        ' 
        ' btnActualizar
        ' 
        btnActualizar.BackColor = Color.SlateGray
        btnActualizar.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnActualizar.ForeColor = SystemColors.ControlLightLight
        btnActualizar.Location = New Point(226, 437)
        btnActualizar.Margin = New Padding(3, 4, 3, 4)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(203, 65)
        btnActualizar.TabIndex = 1
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.SlateGray
        Button1.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(581, 437)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(203, 65)
        Button1.TabIndex = 2
        Button1.Text = "Cerrar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ButtonHighlight
        Label1.Font = New Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(72, 93)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 31)
        Label1.TabIndex = 3
        Label1.Text = "Mis Ventas"
        ' 
        ' FormMisVentas
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SlateBlue
        BackgroundImage = My.Resources.Resources.vendedor
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(969, 600)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(btnActualizar)
        Controls.Add(DgvMisVentas)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormMisVentas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mis Ventas"
        CType(DgvMisVentas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DgvMisVentas As DataGridView
    Friend WithEvents btnActualizar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
