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
        dtpFechaInicio = New DateTimePicker()
        btnGenerarReporte = New Button()
        dtpFechaFin = New DateTimePicker()
        CType(DgvReporte, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DgvReporte
        ' 
        DgvReporte.AllowUserToOrderColumns = True
        DgvReporte.BackgroundColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        DgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvReporte.Location = New Point(99, 165)
        DgvReporte.Name = "DgvReporte"
        DgvReporte.Size = New Size(408, 150)
        DgvReporte.TabIndex = 0
        ' 
        ' dtpFechaInicio
        ' 
        dtpFechaInicio.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpFechaInicio.Location = New Point(223, 38)
        dtpFechaInicio.Name = "dtpFechaInicio"
        dtpFechaInicio.Size = New Size(335, 33)
        dtpFechaInicio.TabIndex = 1
        ' 
        ' btnGenerarReporte
        ' 
        btnGenerarReporte.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        btnGenerarReporte.BackgroundImageLayout = ImageLayout.None
        btnGenerarReporte.Image = My.Resources.Resources.gen_Ventas
        btnGenerarReporte.ImageAlign = ContentAlignment.MiddleLeft
        btnGenerarReporte.Location = New Point(313, 367)
        btnGenerarReporte.Name = "btnGenerarReporte"
        btnGenerarReporte.Size = New Size(149, 37)
        btnGenerarReporte.TabIndex = 2
        btnGenerarReporte.Text = "Generar Reporte"
        btnGenerarReporte.TextAlign = ContentAlignment.MiddleRight
        btnGenerarReporte.UseVisualStyleBackColor = False
        ' 
        ' dtpFechaFin
        ' 
        dtpFechaFin.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpFechaFin.Location = New Point(223, 87)
        dtpFechaFin.Name = "dtpFechaFin"
        dtpFechaFin.Size = New Size(335, 33)
        dtpFechaFin.TabIndex = 3
        ' 
        ' FormReporteVentas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.AltaProd
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(dtpFechaFin)
        Controls.Add(btnGenerarReporte)
        Controls.Add(dtpFechaInicio)
        Controls.Add(DgvReporte)
        Name = "FormReporteVentas"
        Text = "Reporte de Ventas"
        CType(DgvReporte, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DgvReporte As DataGridView
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents btnGenerarReporte As Button
    Friend WithEvents dtpFechaFin As DateTimePicker
End Class
