<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProveedoresInactivos
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
        DgvProveedoresInactivos = New DataGridView()
        btnReactivar = New Button()
        Button1 = New Button()
        Label1 = New Label()
        CType(DgvProveedoresInactivos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DgvProveedoresInactivos
        ' 
        DgvProveedoresInactivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvProveedoresInactivos.Location = New Point(67, 129)
        DgvProveedoresInactivos.Margin = New Padding(3, 4, 3, 4)
        DgvProveedoresInactivos.Name = "DgvProveedoresInactivos"
        DgvProveedoresInactivos.RowHeadersWidth = 51
        DgvProveedoresInactivos.Size = New Size(772, 255)
        DgvProveedoresInactivos.TabIndex = 0
        ' 
        ' btnReactivar
        ' 
        btnReactivar.BackColor = Color.Purple
        btnReactivar.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnReactivar.ForeColor = Color.White
        btnReactivar.Location = New Point(149, 435)
        btnReactivar.Margin = New Padding(3, 4, 3, 4)
        btnReactivar.Name = "btnReactivar"
        btnReactivar.Size = New Size(159, 69)
        btnReactivar.TabIndex = 1
        btnReactivar.Text = "Reactivar"
        btnReactivar.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Purple
        Button1.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(611, 435)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(159, 69)
        Button1.TabIndex = 2
        Button1.Text = "Cerrar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(66, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(242, 31)
        Label1.TabIndex = 3
        Label1.Text = "Proveedores Inactivos "
        ' 
        ' FormProveedoresInactivos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.vendedor
        ClientSize = New Size(914, 600)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(btnReactivar)
        Controls.Add(DgvProveedoresInactivos)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormProveedoresInactivos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Proveedores Inactivos"
        CType(DgvProveedoresInactivos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DgvProveedoresInactivos As DataGridView
    Friend WithEvents btnReactivar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
