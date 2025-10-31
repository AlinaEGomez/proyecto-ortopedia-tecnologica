
Imports System.Data.SqlClient
Imports System.Data
    Imports System.IO
    Imports System.Drawing

    Public Class FormInventario

        ' 🔑 VARIABLES DE CLASE
        Private gestor As New GestorBD()
        Private rutaArchivoTemporal As String = "" ' Ruta de la imagen seleccionada
        Private ProductoID_Actual As Integer = 0 ' 0 = Alta | > 0 = Modificación

        Private Sub FormInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ActualizarDataGrid()
        End Sub

        ' ----------------------------------------------------
        ' 1. MANTENIMIENTO Y CARGA DE LA GRILLA
        ' ----------------------------------------------------
        Public Sub ActualizarDataGrid()
            Try
                dgvProductos.DataSource = gestor.CargarProductosActivos()

                ' Asegúrate de que las columnas de RutaImagen y ID estén ocultas o configuradas
                If dgvProductos.Columns.Contains("ProductoID") Then dgvProductos.Columns("ProductoID").Visible = False
                If dgvProductos.Columns.Contains("RutaImagen") Then dgvProductos.Columns("RutaImagen").Visible = False

                LimpiarCampos()
            Catch ex As Exception
                MessageBox.Show("Error al cargar la lista de productos: " & ex.Message, "Error BD")
            End Try
        End Sub

        Private Sub LimpiarCampos()
            TxtCodigo.Clear()
            TxtDescripcion.Clear()
            TxtStock.Text = "0"
            TxtPrecio.Text = "0.00"
            pbImagenProducto.Image = Nothing
            rutaArchivoTemporal = ""
            ProductoID_Actual = 0
            BtnGuardar.Text = "Guardar Nuevo"
        End Sub

        ' ----------------------------------------------------
        ' 2. GESTIÓN DE IMAGEN
        ' ----------------------------------------------------
        Private Sub BtnBuscarImagen_Click(sender As Object, e As EventArgs) Handles BtnBuscarImagen.Click
            Using openFile As New OpenFileDialog()
                openFile.Filter = "Imágenes (*.jpg;*.png)|*.jpg;*.*.png"
                If openFile.ShowDialog() = DialogResult.OK Then
                    rutaArchivoTemporal = openFile.FileName
                    pbImagenProducto.Image = Image.FromFile(rutaArchivoTemporal)
                    pbImagenProducto.SizeMode = PictureBoxSizeMode.Zoom
                End If
            End Using
        End Sub

        ' ----------------------------------------------------
        ' 3. GUARDAR / MODIFICAR / ELIMINAR
        ' ----------------------------------------------------
        Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
            If Not ValidarCampos() Then Return

            Dim codigo As String = TxtCodigo.Text
            Dim descripcion As String = TxtDescripcion.Text
            Dim stock As Integer = Integer.Parse(TxtStock.Text)
            Dim precio As Decimal = Decimal.Parse(TxtPrecio.Text)
            Dim rutaFinalImagen As String = ""

            Try
                ' 3.1 GESTIÓN Y COPIA DEL ARCHIVO DE IMAGEN
                If Not String.IsNullOrEmpty(rutaArchivoTemporal) AndAlso System.IO.File.Exists(rutaArchivoTemporal) Then
                    Dim directorioDestino As String = Application.StartupPath & "\ImagenesProductos\"
                    If Not System.IO.Directory.Exists(directorioDestino) Then System.IO.Directory.CreateDirectory(directorioDestino)

                    Dim nombreArchivo As String = Guid.NewGuid().ToString() & System.IO.Path.GetExtension(rutaArchivoTemporal)
                    rutaFinalImagen = System.IO.Path.Combine(directorioDestino, nombreArchivo)
                    System.IO.File.Copy(rutaArchivoTemporal, rutaFinalImagen, True)
                ElseIf ProductoID_Actual > 0 Then
                    ' Conservar la ruta existente en la BD si no se seleccionó una nueva
                    rutaFinalImagen = dgvProductos.CurrentRow.Cells("RutaImagen").Value.ToString()
                End If

                ' 3.2 GESTIÓN DE BD (INSERTAR O MODIFICAR)
                If ProductoID_Actual = 0 Then
                    gestor.InsertarProducto(codigo, descripcion, stock, precio, rutaFinalImagen)
                    MessageBox.Show("Producto guardado con éxito.", "Guardado")
                Else
                    gestor.ModificarProducto(ProductoID_Actual, codigo, descripcion, stock, precio, rutaFinalImagen)
                    MessageBox.Show("Producto modificado con éxito.", "Modificado")
                End If

                ActualizarDataGrid()

            Catch ex As Exception
                MessageBox.Show("Error al guardar: " & ex.Message, "Error")
            End Try
        End Sub

        Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
            If ProductoID_Actual = 0 Then Return

            If MessageBox.Show("¿Está seguro de eliminar (Baja Lógica) el producto seleccionado?", "Confirmar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    gestor.GestionarEstadoLogicoProducto(ProductoID_Actual, 0) ' Baja Lógica
                    MessageBox.Show("Producto eliminado (Baja Lógica) con éxito.", "Eliminado")
                    ActualizarDataGrid()
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar: " & ex.Message, "Error BD")
                End Try
            End If
        End Sub

        ' ----------------------------------------------------
        ' 4. VALIDACIÓN Y CARGA DE GRILLA
        ' ----------------------------------------------------
        Private Function ValidarCampos() As Boolean
            If String.IsNullOrWhiteSpace(TxtCodigo.Text) OrElse Not Integer.TryParse(TxtStock.Text, Nothing) OrElse Not Decimal.TryParse(TxtPrecio.Text, Nothing) Then
                MessageBox.Show("Código, Stock y Precio son obligatorios y deben ser válidos.", "Validación")
                Return False
            End If
            Return True
        End Function

        Private Sub DgvProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvProductos.CellClick
            If e.RowIndex >= 0 AndAlso e.RowIndex < dgvProductos.Rows.Count - 1 Then
                Dim fila As DataGridViewRow = dgvProductos.Rows(e.RowIndex)

                ProductoID_Actual = CInt(fila.Cells("ProductoID").Value)
                rutaArchivoTemporal = If(fila.Cells("RutaImagen").Value Is DBNull.Value, "", fila.Cells("RutaImagen").Value.ToString())

                TxtCodigo.Text = fila.Cells("Codigo").Value.ToString()
                TxtDescripcion.Text = If(fila.Cells("Descripcion").Value Is DBNull.Value, "", fila.Cells("Descripcion").Value.ToString())
                TxtStock.Text = fila.Cells("Stock").Value.ToString()
                TxtPrecio.Text = fila.Cells("Precio").Value.ToString()

                If System.IO.File.Exists(rutaArchivoTemporal) Then
                    pbImagenProducto.Image = Image.FromFile(rutaArchivoTemporal)
                    pbImagenProducto.SizeMode = PictureBoxSizeMode.Zoom
                Else
                    pbImagenProducto.Image = Nothing
                End If

                BtnGuardar.Text = "Modificar Producto"
            End If
        End Sub

    End Class
