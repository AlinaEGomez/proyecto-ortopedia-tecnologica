<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUsuarios
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
        DgvUsuarios = New DataGridView()
        Label1 = New Label()
        BtnCerrar = New Button()
        CType(DgvUsuarios, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DgvUsuarios
        ' 
        DgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvUsuarios.Location = New Point(65, 134)
        DgvUsuarios.Margin = New Padding(3, 4, 3, 4)
        DgvUsuarios.Name = "DgvUsuarios"
        DgvUsuarios.RowHeadersWidth = 51
        DgvUsuarios.Size = New Size(775, 383)
        DgvUsuarios.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(65, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(142, 32)
        Label1.TabIndex = 2
        Label1.Text = "Usuarios BD"
        ' 
        ' BtnCerrar
        ' 
        BtnCerrar.Location = New Point(718, 533)
        BtnCerrar.Name = "BtnCerrar"
        BtnCerrar.Size = New Size(94, 29)
        BtnCerrar.TabIndex = 3
        BtnCerrar.Text = "Cerrar"
        BtnCerrar.UseVisualStyleBackColor = True
        ' 
        ' FormUsuarios
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(914, 600)
        Controls.Add(BtnCerrar)
        Controls.Add(Label1)
        Controls.Add(DgvUsuarios)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormUsuarios"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Usuarios"
        CType(DgvUsuarios, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub


    Friend WithEvents DgvUsuarios As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCerrar As Button
End Class
