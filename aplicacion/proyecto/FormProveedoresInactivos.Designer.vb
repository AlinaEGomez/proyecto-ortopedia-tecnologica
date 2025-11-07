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
        CType(DgvProveedoresInactivos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DgvProveedoresInactivos
        ' 
        DgvProveedoresInactivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvProveedoresInactivos.Location = New Point(113, 139)
        DgvProveedoresInactivos.Name = "DgvProveedoresInactivos"
        DgvProveedoresInactivos.Size = New Size(443, 150)
        DgvProveedoresInactivos.TabIndex = 0
        ' 
        ' btnReactivar
        ' 
        btnReactivar.BackColor = Color.Purple
        btnReactivar.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnReactivar.ForeColor = Color.White
        btnReactivar.Location = New Point(598, 183)
        btnReactivar.Name = "btnReactivar"
        btnReactivar.Size = New Size(139, 52)
        btnReactivar.TabIndex = 1
        btnReactivar.Text = "Reactivar"
        btnReactivar.UseVisualStyleBackColor = False
        ' 
        ' FormProveedoresInactivos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.proveedor2
        ClientSize = New Size(800, 450)
        Controls.Add(btnReactivar)
        Controls.Add(DgvProveedoresInactivos)
        Name = "FormProveedoresInactivos"
        Text = "Proveedores Inactivos"
        CType(DgvProveedoresInactivos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DgvProveedoresInactivos As DataGridView
    Friend WithEvents btnReactivar As Button
End Class
