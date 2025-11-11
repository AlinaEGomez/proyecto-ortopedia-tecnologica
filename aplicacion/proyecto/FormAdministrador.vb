Imports System.Data.SqlClient
Imports System.IO
Imports System.Numerics
Imports System.Text
Imports System.Windows.Forms ' Necesario para MessageBox
Imports ClosedXML.Excel
Imports Microsoft.Data.SqlClient
Imports Microsoft.Office.Interop
Public Class FormAdministrador


    Private Sub GerenteToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormGerente.Show()
    End Sub



    Private Sub MantenimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoToolStripMenuItem.Click

    End Sub

    Private Sub RolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RolToolStripMenuItem.Click

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs)


    End Sub
    Private Sub FormAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' ... otro código de inicialización ...
    End Sub
    Private Sub TSalir_Click(sender As Object, e As EventArgs) Handles TSalir.Click
        ' Cierra el formulario de login actual
        Me.Close()

        ' Muestra el formulario de inicio
        Dim formInicio As New FormLogin()
        FormLogin.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        ' Supongamos que después del login obtenés el rol


        ' Mostrar saludo en el ToolStripLabel
        LblBienvenido.Text = "¡Bienvenido " & "perfil" & "!"
        LblBienvenido.ForeColor = Color.DarkGreen

    End Sub

    Private Sub AltaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem1.Click
        Me.Close()
        FormGestionProductos.Show()
    End Sub

    Private Sub ActivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActivosToolStripMenuItem.Click

    End Sub

    Private Sub InactivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InactivosToolStripMenuItem.Click
        FormClientesInactivos.MdiParent = Me
        FormClientesInactivos.Show()
    End Sub

    Private Sub ActivosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ActivosToolStripMenuItem1.Click
        FormGerenteActivo.MdiParent = Me
        FormGerenteActivo.Show()
    End Sub

    Private Sub InactivosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InactivosToolStripMenuItem1.Click
        FormGerenteInactivo.MdiParent = Me
        FormGerenteInactivo.Show()
    End Sub

    Private Sub ActivosToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ActivosToolStripMenuItem2.Click
        FormVendedorActivo.MdiParent = Me
        FormVendedorActivo.Show()
    End Sub

    Private Sub InactivosToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles InactivosToolStripMenuItem2.Click
        FormVendedorInactivo.MdiParent = Me
        FormVendedorInactivo.Show()
    End Sub

    'Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click
    'Me.Close()
    '   FormCrudUsuarios.Show()
    'End Sub



    Private Sub UsuariosToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Me.Close()
        FormUsuarios.Show()
    End Sub

    Private Sub ReportesDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesDeVentasToolStripMenuItem.Click
        FormReporteVentas.Show()
        Me.Hide()
    End Sub

    Private Sub ProductosActivosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormProducActiv.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem1.Click
        Me.Close()
        FormProveedores.Show()
    End Sub

    Private Sub ReporteDeComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeComprasToolStripMenuItem.Click
        Me.Close()
        FormReporteCompras.Show()
    End Sub



    Private Sub BackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupToolStripMenuItem.Click

    End Sub

    Private Sub CopiaDeSeguridadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiaDeSeguridadToolStripMenuItem.Click
        FormBackup.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        'FormClientes.MdiParent = Me
        Me.Close()
        FormClientes.Show()
    End Sub

    Private Sub VendedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendedorToolStripMenuItem.Click
        Me.Close()
        FormCrudUsuarios.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.Close()
        FormAdmnUsuario.Show()
    End Sub

    Private Sub ExcelDeBackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcelDeBackupToolStripMenuItem.Click
        Try
            ' 🔹 Conexión a SQL Server
            Dim conexion As New SqlConnection("Server=localhost\SQLEXPRESS;Database=ortopedicTecnologi_taller;Trusted_Connection=True;TrustServerCertificate=True;")
            conexion.Open()

            ' 🔹 Consultas base
            Dim consultas As New Dictionary(Of String, String) From {
                {"Ventas", "SELECT V.Fecha, U.Nombre_Apellido AS Vendedor, V.Total FROM Ventas V JOIN Usuarios U ON V.IdVendedor=U.Id"},
                {"Compras", "SELECT C.FechaCompra, P.RazonSocial AS Proveedor, C.TotalCompra FROM Compras C JOIN Proveedores P ON C.ProveedorID=P.ProveedorID"},
                {"Clientes", "SELECT ClienteID, RazonSocial, CUIT, Telefono, Email, FechaRegistro FROM Clientes"},
                {"Productos", "SELECT ProductoID, Codigo, Stock, Precio, Stock FROM Productos"},
                {"DetalleVentas", "SELECT DV.DetalleID, V.VentaID, P.Descripcion AS Producto, DV.Cantidad, DV.PrecioUnitario, DV.Subtotal FROM DetalleVenta DV JOIN Ventas V ON DV.VentaID = V.VentaID JOIN Productos P ON DV.ProductoID = P.ProductoID"},
               {"DetalleCompras", "SELECT DC.DetalleCompraID, C.CompraID, P.Descripcion AS Producto, DC.Cantidad, DC.PrecioCosto, DC.Subtotal FROM DetalleCompra DC JOIN Compras C ON DC.CompraID = C.CompraID JOIN Productos P ON DC.ProductoID = P.ProductoID"},
               {"Proveedores", "SELECT ProveedorID, RazonSocial, CUIT, ContactoNombre, Telefono, Email, EstadoLogico FROM Proveedores"},
                {"Usuarios", "SELECT Id, Nombre_Apellido, Email, DNI, Sexo, Perfil, FechaAlta, Activo FROM Usuarios"}
            }

            ' 🔹 Consultas especiales para gráficos
            Dim consultaProductosMasVendidos As String = "
            SELECT P.Descripcion AS Producto, SUM(DV.Cantidad) AS TotalVendido
            FROM DetalleVenta DV
            JOIN Productos P ON DV.ProductoID = P.ProductoID
            GROUP BY P.Descripcion
            ORDER BY TotalVendido DESC
        "

            Dim consultaVentasPorVendedor As String = "
            SELECT U.Nombre_Apellido AS Vendedor, SUM(V.Total) AS TotalVendido
            FROM Ventas V
            JOIN Usuarios U ON V.IdVendedor = U.Id
            GROUP BY U.Nombre_Apellido
            ORDER BY TotalVendido DESC
        "

            ' 🔹 Crear Excel
            Dim xlApp As New Microsoft.Office.Interop.Excel.Application
            Dim xlWorkbook As Microsoft.Office.Interop.Excel.Workbook = xlApp.Workbooks.Add()
            Dim hojaIndex As Integer = 1

            ' 🔹 Llenar las hojas con los datos
            For Each kvp In consultas
                Dim nombreHoja As String = kvp.Key
                Dim sql As String = kvp.Value

                Dim adaptador As New SqlDataAdapter(sql, conexion)
                Dim tabla As New DataTable()
                adaptador.Fill(tabla)

                Dim xlWorksheet As Microsoft.Office.Interop.Excel.Worksheet
                If hojaIndex <= xlWorkbook.Sheets.Count Then
                    xlWorksheet = CType(xlWorkbook.Sheets(hojaIndex), Microsoft.Office.Interop.Excel.Worksheet)
                Else
                    xlWorksheet = CType(xlWorkbook.Sheets.Add(), Microsoft.Office.Interop.Excel.Worksheet)
                End If

                xlWorksheet.Name = nombreHoja

                ' Escribir encabezados
                For col As Integer = 0 To tabla.Columns.Count - 1
                    xlWorksheet.Cells(1, col + 1) = tabla.Columns(col).ColumnName
                Next

                ' Escribir filas
                For fila As Integer = 0 To tabla.Rows.Count - 1
                    For col As Integer = 0 To tabla.Columns.Count - 1
                        xlWorksheet.Cells(fila + 2, col + 1) = tabla.Rows(fila)(col).ToString()
                    Next
                Next

                hojaIndex += 1
            Next

            ' 🔹 Crear hoja de gráficos
            Dim xlGraficoHoja As Microsoft.Office.Interop.Excel.Worksheet = xlWorkbook.Sheets.Add()
            xlGraficoHoja.Name = "Gráficos"

            ' === 📊 PRODUCTOS MÁS VENDIDOS ===
            Dim adaptProd As New SqlDataAdapter(consultaProductosMasVendidos, conexion)
            Dim tablaProd As New DataTable()
            adaptProd.Fill(tablaProd)

            xlGraficoHoja.Range("A1").Value = "Producto"
            xlGraficoHoja.Range("B1").Value = "Total Vendido"

            For i As Integer = 0 To tablaProd.Rows.Count - 1
                xlGraficoHoja.Cells(i + 2, 1).Value = tablaProd.Rows(i)("Producto")
                xlGraficoHoja.Cells(i + 2, 2).Value = tablaProd.Rows(i)("TotalVendido")
            Next

            Dim chartProd As Microsoft.Office.Interop.Excel.ChartObject = xlGraficoHoja.ChartObjects().Add(50, 50, 400, 300)
            chartProd.Chart.SetSourceData(xlGraficoHoja.Range("A1:B" & tablaProd.Rows.Count + 1))
            chartProd.Chart.ChartType = Microsoft.Office.Interop.Excel.XlChartType.xlColumnClustered
            chartProd.Chart.HasTitle = True
            chartProd.Chart.ChartTitle.Text = "Productos más vendidos"

            ' === 📈 VENTAS POR VENDEDOR ===
            Dim adaptVend As New SqlDataAdapter(consultaVentasPorVendedor, conexion)
            Dim tablaVend As New DataTable()
            adaptVend.Fill(tablaVend)

            xlGraficoHoja.Range("D1").Value = "Vendedor"
            xlGraficoHoja.Range("E1").Value = "Total Vendido"

            For i As Integer = 0 To tablaVend.Rows.Count - 1
                xlGraficoHoja.Cells(i + 2, 4).Value = tablaVend.Rows(i)("Vendedor")
                xlGraficoHoja.Cells(i + 2, 5).Value = tablaVend.Rows(i)("TotalVendido")
            Next

            Dim chartVend As Microsoft.Office.Interop.Excel.ChartObject = xlGraficoHoja.ChartObjects().Add(500, 50, 400, 300)
            chartVend.Chart.SetSourceData(xlGraficoHoja.Range("D1:E" & tablaVend.Rows.Count + 1))
            chartVend.Chart.ChartType = Microsoft.Office.Interop.Excel.XlChartType.xlColumnClustered
            chartVend.Chart.HasTitle = True
            chartVend.Chart.ChartTitle.Text = "Ventas por vendedor"

            ' ✅ Finalizar
            conexion.Close()
            xlApp.Visible = True

            MessageBox.Show("Excel exportado correctamente con gráficos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error al exportar a Excel: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RegistroDeComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeComprasToolStripMenuItem.Click
        Me.Close()
        FormRegistroCompra.Show()

    End Sub
End Class