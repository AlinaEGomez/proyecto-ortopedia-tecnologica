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
        dtpFechaInicio = New DateTimePicker()
        dtpFechaFin = New DateTimePicker()
        DgvReporte = New DataGridView()
        btnGenerarReporte = New Button()
        Label1 = New Label()
        Label2 = New Label()
        CType(DgvReporte, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dtpFechaInicio
        ' 
        dtpFechaInicio.Location = New Point(413, 74)
        dtpFechaInicio.Name = "dtpFechaInicio"
        dtpFechaInicio.Size = New Size(200, 23)
        dtpFechaInicio.TabIndex = 0
        ' 
        ' dtpFechaFin
        ' 
        dtpFechaFin.Location = New Point(413, 138)
        dtpFechaFin.Name = "dtpFechaFin"
        dtpFechaFin.Size = New Size(200, 23)
        dtpFechaFin.TabIndex = 1
        ' 
        ' DgvReporte
        ' 
        DgvReporte.BackgroundColor = Color.IndianRed
        DgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvReporte.Location = New Point(33, 219)
        DgvReporte.Name = "DgvReporte"
        DgvReporte.Size = New Size(399, 150)
        DgvReporte.TabIndex = 2
        ' 
        ' btnGenerarReporte
        ' 
        btnGenerarReporte.Location = New Point(446, 219)
        btnGenerarReporte.Name = "btnGenerarReporte"
        btnGenerarReporte.Size = New Size(134, 39)
        btnGenerarReporte.TabIndex = 3
        btnGenerarReporte.Text = "Generar Reporte"
        btnGenerarReporte.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(289, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 26)
        Label1.TabIndex = 4
        Label1.Text = "Desde :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(289, 135)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 26)
        Label2.TabIndex = 5
        Label2.Text = "Hasta :"
        ' 
        ' FormReporteVentas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSlateGray
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnGenerarReporte)
        Controls.Add(DgvReporte)
        Controls.Add(dtpFechaFin)
        Controls.Add(dtpFechaInicio)
        Name = "FormReporteVentas"
        Text = "FReporte de Ventas"
        CType(DgvReporte, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents DgvReporte As DataGridView
    Friend WithEvents btnGenerarReporte As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
