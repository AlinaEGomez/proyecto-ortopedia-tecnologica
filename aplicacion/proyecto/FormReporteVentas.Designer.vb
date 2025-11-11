Imports System.Windows.Forms.DataVisualization
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.ComponentModel


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormReporteVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        dtpFechaInicio = New DateTimePicker()
        dtpFechaFin = New DateTimePicker()
        DgvReporte = New DataGridView()
        btnGenerarReporte = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        CType(DgvReporte, ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dtpFechaInicio
        ' 
        dtpFechaInicio.Location = New Point(194, 99)
        dtpFechaInicio.Margin = New Padding(3, 4, 3, 4)
        dtpFechaInicio.Name = "dtpFechaInicio"
        dtpFechaInicio.Size = New Size(228, 27)
        dtpFechaInicio.TabIndex = 0
        ' 
        ' dtpFechaFin
        ' 
        dtpFechaFin.Location = New Point(194, 169)
        dtpFechaFin.Margin = New Padding(3, 4, 3, 4)
        dtpFechaFin.Name = "dtpFechaFin"
        dtpFechaFin.Size = New Size(228, 27)
        dtpFechaFin.TabIndex = 1
        ' 
        ' DgvReporte
        ' 
        DgvReporte.BackgroundColor = Color.IndianRed
        DgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvReporte.Location = New Point(38, 292)
        DgvReporte.Margin = New Padding(3, 4, 3, 4)
        DgvReporte.Name = "DgvReporte"
        DgvReporte.RowHeadersWidth = 51
        DgvReporte.Size = New Size(456, 200)
        DgvReporte.TabIndex = 2
        ' 
        ' btnGenerarReporte
        ' 
        btnGenerarReporte.Location = New Point(167, 523)
        btnGenerarReporte.Margin = New Padding(3, 4, 3, 4)
        btnGenerarReporte.Name = "btnGenerarReporte"
        btnGenerarReporte.Size = New Size(153, 52)
        btnGenerarReporte.TabIndex = 3
        btnGenerarReporte.Text = "Generar Reporte"
        btnGenerarReporte.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ButtonHighlight
        Label1.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(48, 94)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 32)
        Label1.TabIndex = 4
        Label1.Text = "Desde :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ButtonHighlight
        Label2.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(48, 169)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 32)
        Label2.TabIndex = 5
        Label2.Text = "Hasta :"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(600, 523)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(153, 52)
        Button1.TabIndex = 6
        Button1.Text = "Cerrar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' FormReporteVentas
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSlateGray
        BackgroundImage = My.Resources.Resources.silla
        ClientSize = New Size(914, 600)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnGenerarReporte)
        Controls.Add(DgvReporte)
        Controls.Add(dtpFechaFin)
        Controls.Add(dtpFechaInicio)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormReporteVentas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Reporte de Ventas"
        CType(DgvReporte, ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub



    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents DgvReporte As DataGridView
    Friend WithEvents btnGenerarReporte As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
