<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteVentas
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
        DgvReporte = New DataGridView()
        DateTimePicker1 = New DateTimePicker()
        CType(DgvReporte, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DgvReporte
        ' 
        DgvReporte.AllowUserToOrderColumns = True
        DgvReporte.BackgroundColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        DgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvReporte.Location = New Point(301, 165)
        DgvReporte.Name = "DgvReporte"
        DgvReporte.Size = New Size(240, 150)
        DgvReporte.TabIndex = 0
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(223, 38)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(335, 33)
        DateTimePicker1.TabIndex = 1
        ' 
        ' FormReporteVentas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.AltaProd
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(DateTimePicker1)
        Controls.Add(DgvReporte)
        Name = "FormReporteVentas"
        Text = "Reporte de Ventas"
        CType(DgvReporte, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DgvReporte As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
