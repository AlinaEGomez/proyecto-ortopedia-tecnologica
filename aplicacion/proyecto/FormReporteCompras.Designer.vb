<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteCompras
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
        dgvReporte = New DataGridView()
        btnGenerarReporteCompras = New Button()
        lblTotalGlobal = New Label()
        CType(dgvReporte, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dtpFechaInicio
        ' 
        dtpFechaInicio.Location = New Point(302, 62)
        dtpFechaInicio.Name = "dtpFechaInicio"
        dtpFechaInicio.Size = New Size(200, 23)
        dtpFechaInicio.TabIndex = 0
        ' 
        ' dtpFechaFin
        ' 
        dtpFechaFin.Location = New Point(308, 109)
        dtpFechaFin.Name = "dtpFechaFin"
        dtpFechaFin.Size = New Size(200, 23)
        dtpFechaFin.TabIndex = 1
        ' 
        ' dgvReporte
        ' 
        dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReporte.Location = New Point(126, 235)
        dgvReporte.Name = "dgvReporte"
        dgvReporte.Size = New Size(562, 150)
        dgvReporte.TabIndex = 2
        ' 
        ' btnGenerarReporteCompras
        ' 
        btnGenerarReporteCompras.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnGenerarReporteCompras.Location = New Point(345, 400)
        btnGenerarReporteCompras.Name = "btnGenerarReporteCompras"
        btnGenerarReporteCompras.Size = New Size(163, 38)
        btnGenerarReporteCompras.TabIndex = 3
        btnGenerarReporteCompras.Text = "Generar Reporte"
        btnGenerarReporteCompras.UseVisualStyleBackColor = True
        ' 
        ' lblTotalGlobal
        ' 
        lblTotalGlobal.AutoSize = True
        lblTotalGlobal.BackColor = Color.MediumPurple
        lblTotalGlobal.Font = New Font("Segoe UI Emoji", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotalGlobal.Location = New Point(208, 404)
        lblTotalGlobal.Name = "lblTotalGlobal"
        lblTotalGlobal.Size = New Size(88, 36)
        lblTotalGlobal.TabIndex = 4
        lblTotalGlobal.Text = "label1"
        ' 
        ' FormReporteCompras
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.reporte_ventas
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(lblTotalGlobal)
        Controls.Add(btnGenerarReporteCompras)
        Controls.Add(dgvReporte)
        Controls.Add(dtpFechaFin)
        Controls.Add(dtpFechaInicio)
        Name = "FormReporteCompras"
        Text = "Reporte de compras"
        CType(dgvReporte, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents dgvReporte As DataGridView
    Friend WithEvents btnGenerarReporteCompras As Button
    Friend WithEvents lblTotalGlobal As Label
End Class
