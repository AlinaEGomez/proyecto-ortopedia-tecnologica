<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TDni = New TextBox()
        TApellido = New TextBox()
        TNombre = New TextBox()
        BGuardar = New Button()
        BEliminar = New Button()
        LModificar = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(105, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nombre  y Apellido:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(105, 122)
        Label2.Name = "Label2"
        Label2.Size = New Size(25, 15)
        Label2.TabIndex = 1
        Label2.Text = "Dni"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(105, 182)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 2
        Label3.Text = "Apellido"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(105, 231)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 15)
        Label4.TabIndex = 3
        Label4.Text = "Nombre"
        ' 
        ' TDni
        ' 
        TDni.Location = New Point(236, 114)
        TDni.Name = "TDni"
        TDni.Size = New Size(100, 23)
        TDni.TabIndex = 5
        ' 
        ' TApellido
        ' 
        TApellido.Location = New Point(236, 174)
        TApellido.Name = "TApellido"
        TApellido.Size = New Size(100, 23)
        TApellido.TabIndex = 6
        ' 
        ' TNombre
        ' 
        TNombre.Location = New Point(236, 223)
        TNombre.Name = "TNombre"
        TNombre.Size = New Size(100, 23)
        TNombre.TabIndex = 7
        ' 
        ' BGuardar
        ' 
        BGuardar.Location = New Point(105, 349)
        BGuardar.Name = "BGuardar"
        BGuardar.Size = New Size(75, 23)
        BGuardar.TabIndex = 8
        BGuardar.Text = "Guardar"
        BGuardar.UseVisualStyleBackColor = True
        ' 
        ' BEliminar
        ' 
        BEliminar.Location = New Point(217, 349)
        BEliminar.Name = "BEliminar"
        BEliminar.Size = New Size(75, 23)
        BEliminar.TabIndex = 9
        BEliminar.Text = "Eliminar"
        BEliminar.UseVisualStyleBackColor = True
        ' 
        ' LModificar
        ' 
        LModificar.AutoSize = True
        LModificar.ForeColor = Color.Red
        LModificar.Location = New Point(254, 76)
        LModificar.Name = "LModificar"
        LModificar.Size = New Size(58, 15)
        LModificar.TabIndex = 10
        LModificar.Text = "Modificar"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(443, 450)
        Controls.Add(LModificar)
        Controls.Add(BEliminar)
        Controls.Add(BGuardar)
        Controls.Add(TNombre)
        Controls.Add(TApellido)
        Controls.Add(TDni)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TDni As TextBox
    Friend WithEvents TApellido As TextBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents BGuardar As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents LModificar As Label

End Class
