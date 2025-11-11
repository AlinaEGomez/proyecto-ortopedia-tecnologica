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
        LblTotalGrupal = New Label()
        Button1 = New Button()
        LblTotalGlobal = New Label()
        CType(dgvReporte, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dtpFechaInicio
        ' 
        dtpFechaInicio.Location = New Point(80, 88)
        dtpFechaInicio.Margin = New Padding(3, 4, 3, 4)
        dtpFechaInicio.Name = "dtpFechaInicio"
        dtpFechaInicio.Size = New Size(228, 27)
        dtpFechaInicio.TabIndex = 0
        ' 
        ' dtpFechaFin
        ' 
        dtpFechaFin.Location = New Point(80, 157)
        dtpFechaFin.Margin = New Padding(3, 4, 3, 4)
        dtpFechaFin.Name = "dtpFechaFin"
        dtpFechaFin.Size = New Size(228, 27)
        dtpFechaFin.TabIndex = 1
        ' 
        ' dgvReporte
        ' 
        dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReporte.Location = New Point(69, 220)
        dgvReporte.Margin = New Padding(3, 4, 3, 4)
        dgvReporte.Name = "dgvReporte"
        dgvReporte.RowHeadersWidth = 51
        dgvReporte.Size = New Size(758, 234)
        dgvReporte.TabIndex = 2
        ' 
        ' btnGenerarReporteCompras
        ' 
        btnGenerarReporteCompras.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnGenerarReporteCompras.Location = New Point(569, 99)
        btnGenerarReporteCompras.Margin = New Padding(3, 4, 3, 4)
        btnGenerarReporteCompras.Name = "btnGenerarReporteCompras"
        btnGenerarReporteCompras.Size = New Size(230, 51)
        btnGenerarReporteCompras.TabIndex = 3
        btnGenerarReporteCompras.Text = "Generar Reporte"
        btnGenerarReporteCompras.UseVisualStyleBackColor = True
        ' 
        ' LblTotalGrupal
        ' 
        LblTotalGrupal.AutoSize = True
        LblTotalGrupal.Font = New Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblTotalGrupal.Location = New Point(87, 500)
        LblTotalGrupal.Name = "LblTotalGrupal"
        LblTotalGrupal.Size = New Size(0, 31)
        LblTotalGrupal.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(703, 490)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(124, 51)
        Button1.TabIndex = 5
        Button1.Text = "Cerrar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' LblTotalGlobal
        ' 
        LblTotalGlobal.AutoSize = True
        LblTotalGlobal.Font = New Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblTotalGlobal.Location = New Point(125, 519)
        LblTotalGlobal.Name = "LblTotalGlobal"
        LblTotalGlobal.Size = New Size(0, 31)
        LblTotalGlobal.TabIndex = 6
        ' 
        ' FormReporteCompras
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.vendedor
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(914, 600)
        Controls.Add(LblTotalGlobal)
        Controls.Add(Button1)
        Controls.Add(LblTotalGrupal)
        Controls.Add(btnGenerarReporteCompras)
        Controls.Add(dgvReporte)
        Controls.Add(dtpFechaFin)
        Controls.Add(dtpFechaInicio)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormReporteCompras"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Reporte de compras"
        CType(dgvReporte, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents dgvReporte As DataGridView
    Friend WithEvents btnGenerarReporteCompras As Button
    Friend WithEvents LblTotalGrupal As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LblTotalGlobal As Label
End Class
