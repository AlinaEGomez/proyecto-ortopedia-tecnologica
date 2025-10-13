Imports System.Data.SqlClient
Imports System.Data

Public Class FormInventario

    ' Variable para guardar temporalmente la ruta local de la imagen seleccionada
    Private rutaArchivoTemporal As String = ""

    ' Instancia de la clase de gestión de datos
    Private gestor As New GestorBD()

    ' =========================================================================
    ' 1. EVENTO LOAD (Al iniciar el formulario)
    ' =========================================================================

    Private Sub FormInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarDataGrid()
    End Sub

    ' =========================================================================
    ' 2. FUNCIÓN DE ACTUALIZACIÓN DEL DATAGRID
    ' =========================================================================

    Private Sub ActualizarDataGrid()
        ' Carga los datos desde la BD y los asigna al DataGridView
        dgvProductos.DataSource = gestor.CargarProductos()

        ' Limpia los campos de texto
        LimpiarCampos()
    End Sub

    Private Sub LimpiarCampos()
        TxtNombre.Clear()
        TxtStock.Clear()
        TxtPrecio.Clear()
        pbImagenProducto.Image = Nothing ' Limpia la imagen
        rutaArchivoTemporal = ""
    End Sub

    ' =========================================================================
    ' 3. BUSCAR IMAGEN (Manejo del OpenFileDialog)
    ' =========================================================================

    Private Sub btnBuscarImagen_Click(sender As Object, e As EventArgs) Handles BtnBuscarImagen.Click
        Using openFile As New OpenFileDialog()
            openFile.Title = "Seleccionar Imagen del Producto"
            openFile.Filter = "Imágenes (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png"

            If openFile.ShowDialog() = DialogResult.OK Then
                ' 1. Guarda la ruta seleccionada por el usuario
                rutaArchivoTemporal = openFile.FileName

                ' 2. Muestra la vista previa
                pbImagenProducto.Image = Image.FromFile(rutaArchivoTemporal)
                pbImagenProducto.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        End Using
    End Sub

    ' =========================================================================
    ' 4. GUARDAR PRODUCTO (Copia de archivo e inserción en BD)
    ' =========================================================================

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            ' Validaciones básicas (puedes agregar más)
            If TxtNombre.Text = "" Or TxtStock.Text = "" Or TxtPrecio.Text = "" Then
                MessageBox.Show("Por favor, complete todos los campos.", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim nombre As String = TxtNombre.Text
            Dim stock As Integer = Integer.Parse(TxtStock.Text)
            Dim precio As Decimal = Decimal.Parse(TxtPrecio.Text)
            Dim rutaFinalImagen As String = ""

            ' Lógica para copiar y guardar la imagen SOLO si se seleccionó una
            If Not String.IsNullOrEmpty(rutaArchivoTemporal) Then

                ' Define la carpeta de destino (dentro de la carpeta de ejecución de tu app)
                Dim directorioDestino As String = Application.StartupPath & "\ImagenesProductos\"

                ' Asegura que la carpeta exista
                If Not System.IO.Directory.Exists(directorioDestino) Then
                    System.IO.Directory.CreateDirectory(directorioDestino)
                End If

                ' Crea un nombre único (usando GUID) para el archivo y evita colisiones
                Dim nombreArchivo As String = Guid.NewGuid().ToString() & System.IO.Path.GetExtension(rutaArchivoTemporal)
                rutaFinalImagen = System.IO.Path.Combine(directorioDestino, nombreArchivo)

                ' Copia el archivo al destino
                System.IO.File.Copy(rutaArchivoTemporal, rutaFinalImagen, True)
            End If

            ' Inserta los datos, incluyendo la ruta de la imagen, en la base de datos
            gestor.InsertarProducto(nombre, stock, precio, rutaFinalImagen)

            MessageBox.Show("Producto guardado con éxito.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ActualizarDataGrid()

        Catch ex As FormatException
            MessageBox.Show("Verifique que Stock y Precio sean números válidos.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al guardar el producto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' =========================================================================
    ' 5. MOSTRAR IMAGEN EN EL DATAGRID (Opcional pero muy útil)
    ' =========================================================================

    ' Este evento se dispara cuando el usuario hace clic en una fila del DataGridView
    Private Sub dgvProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellClick
        ' Asegúrate de que no es la fila de encabezado y que la columna RutaImagen existe
        If e.RowIndex >= 0 And dgvProductos.Columns.Contains("RutaImagen") Then

            Dim rutaGuardada As String = dgvProductos.Rows(e.RowIndex).Cells("RutaImagen").Value.ToString()

            If System.IO.File.Exists(rutaGuardada) Then
                pbImagenProducto.Image = Image.FromFile(rutaGuardada)
                pbImagenProducto.SizeMode = PictureBoxSizeMode.StretchImage
            Else
                ' Si el archivo no existe o la ruta está vacía, limpia el PictureBox
                pbImagenProducto.Image = Nothing
            End If
        End If
    End Sub

End Class