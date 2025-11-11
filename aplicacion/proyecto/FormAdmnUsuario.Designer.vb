<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdmnUsuario
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
        Label1 = New Label()
        Label2 = New Label()
        BtnBuscar = New Button()
        BtnMostrarTodos = New Button()
        CmbPerfil = New ComboBox()
        CmbEstado = New ComboBox()
        DgvUsuarios = New DataGridView()
        BtnCerrar = New Button()
        CType(DgvUsuarios, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(59, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 36)
        Label1.TabIndex = 10
        Label1.Text = "Perfiles:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(59, 127)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 36)
        Label2.TabIndex = 11
        Label2.Text = "Estado:"
        ' 
        ' BtnBuscar
        ' 
        BtnBuscar.BackColor = Color.IndianRed
        BtnBuscar.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnBuscar.Location = New Point(547, 118)
        BtnBuscar.Name = "BtnBuscar"
        BtnBuscar.Size = New Size(94, 46)
        BtnBuscar.TabIndex = 12
        BtnBuscar.Text = "Buscar"
        BtnBuscar.UseVisualStyleBackColor = False
        ' 
        ' BtnMostrarTodos
        ' 
        BtnMostrarTodos.BackColor = Color.IndianRed
        BtnMostrarTodos.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnMostrarTodos.Location = New Point(707, 118)
        BtnMostrarTodos.Name = "BtnMostrarTodos"
        BtnMostrarTodos.Size = New Size(142, 46)
        BtnMostrarTodos.TabIndex = 13
        BtnMostrarTodos.Text = "Mostrar Todos"
        BtnMostrarTodos.UseVisualStyleBackColor = False
        ' 
        ' CmbPerfil
        ' 
        CmbPerfil.FormattingEnabled = True
        CmbPerfil.Location = New Point(226, 78)
        CmbPerfil.Name = "CmbPerfil"
        CmbPerfil.Size = New Size(151, 28)
        CmbPerfil.TabIndex = 14
        ' 
        ' CmbEstado
        ' 
        CmbEstado.FormattingEnabled = True
        CmbEstado.Location = New Point(226, 135)
        CmbEstado.Name = "CmbEstado"
        CmbEstado.Size = New Size(151, 28)
        CmbEstado.TabIndex = 15
        ' 
        ' DgvUsuarios
        ' 
        DgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvUsuarios.Location = New Point(55, 213)
        DgvUsuarios.Name = "DgvUsuarios"
        DgvUsuarios.RowHeadersWidth = 51
        DgvUsuarios.Size = New Size(834, 255)
        DgvUsuarios.TabIndex = 16
        ' 
        ' BtnCerrar
        ' 
        BtnCerrar.BackColor = Color.IndianRed
        BtnCerrar.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnCerrar.Location = New Point(770, 486)
        BtnCerrar.Margin = New Padding(3, 4, 3, 4)
        BtnCerrar.Name = "BtnCerrar"
        BtnCerrar.Size = New Size(109, 60)
        BtnCerrar.TabIndex = 18
        BtnCerrar.Text = "Cerrar"
        BtnCerrar.UseVisualStyleBackColor = False
        ' 
        ' FormAdmnUsuario
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.silla
        ClientSize = New Size(963, 569)
        Controls.Add(BtnCerrar)
        Controls.Add(DgvUsuarios)
        Controls.Add(CmbEstado)
        Controls.Add(CmbPerfil)
        Controls.Add(BtnMostrarTodos)
        Controls.Add(BtnBuscar)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FormAdmnUsuario"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Administrar Usuarios"
        CType(DgvUsuarios, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnMostrarTodos As Button
    Friend WithEvents CmbPerfil As ComboBox
    Friend WithEvents CmbEstado As ComboBox
    Friend WithEvents DgvUsuarios As DataGridView
    Friend WithEvents BtnCerrar As Button
End Class
