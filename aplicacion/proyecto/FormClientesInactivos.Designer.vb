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
        Button1 = New Button()
        Label1 = New Label()
        CType(DgvClientesInactivos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DgvClientesInactivos
        ' 
        DgvClientesInactivos.BackgroundColor = Color.IndianRed
        DgvClientesInactivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvClientesInactivos.Location = New Point(114, 149)
        DgvClientesInactivos.Margin = New Padding(3, 4, 3, 4)
        DgvClientesInactivos.Name = "DgvClientesInactivos"
        DgvClientesInactivos.RowHeadersWidth = 51
        DgvClientesInactivos.Size = New Size(691, 200)
        DgvClientesInactivos.TabIndex = 0
        ' 
        ' btnReactivar
        ' 
        btnReactivar.BackColor = Color.IndianRed
        btnReactivar.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnReactivar.Location = New Point(131, 383)
        btnReactivar.Margin = New Padding(3, 4, 3, 4)
        btnReactivar.Name = "btnReactivar"
        btnReactivar.Size = New Size(237, 60)
        btnReactivar.TabIndex = 1
        btnReactivar.Text = "Reactivar Cliente"
        btnReactivar.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.IndianRed
        Button1.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(673, 383)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(109, 60)
        Button1.TabIndex = 2
        Button1.Text = "Cerrar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(126, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(191, 31)
        Label1.TabIndex = 3
        Label1.Text = "Clientes Inactivos"
        ' 
        ' FormClientesInactivos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.vendedor
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(914, 600)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(btnReactivar)
        Controls.Add(DgvClientesInactivos)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormClientesInactivos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Clientes Inactivos"
        CType(DgvClientesInactivos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DgvClientesInactivos As DataGridView
    Friend WithEvents btnReactivar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
