<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClientesInactivos
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
        DgvClientesInactivos = New DataGridView()
        btnReactivar = New Button()
        CType(DgvClientesInactivos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DgvClientesInactivos
        ' 
        DgvClientesInactivos.BackgroundColor = Color.IndianRed
        DgvClientesInactivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvClientesInactivos.Location = New Point(109, 179)
        DgvClientesInactivos.Name = "DgvClientesInactivos"
        DgvClientesInactivos.Size = New Size(605, 150)
        DgvClientesInactivos.TabIndex = 0
        ' 
        ' btnReactivar
        ' 
        btnReactivar.BackColor = Color.IndianRed
        btnReactivar.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnReactivar.Location = New Point(304, 364)
        btnReactivar.Name = "btnReactivar"
        btnReactivar.Size = New Size(207, 45)
        btnReactivar.TabIndex = 1
        btnReactivar.Text = "Reactivar Cliente"
        btnReactivar.UseVisualStyleBackColor = False
        ' 
        ' FormClientesInactivos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.clientes_crud1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(btnReactivar)
        Controls.Add(DgvClientesInactivos)
        Name = "FormClientesInactivos"
        Text = "Clientes Inactivos"
        CType(DgvClientesInactivos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DgvClientesInactivos As DataGridView
    Friend WithEvents btnReactivar As Button
End Class
