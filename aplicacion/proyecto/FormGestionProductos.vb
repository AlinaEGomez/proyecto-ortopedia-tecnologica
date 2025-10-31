Imports Microsoft.Data.SqlClient
Imports System.Data.SqlClient
Imports System.Data
Public Class FormGestionProductos
    ' Asegúrate de que coincida con el nombre del archivo
    ' ... todo el código de FormInventario.vb va aquí ...

    ' ⚠️ DECLARACIONES CLAVE
    Private gestor As New GestorBD() ' Instancia del Gestor de Base de Datos
    Private rutaArchivoTemporal As String = "" ' Ruta de la imagen seleccionada para guardar
    Private ProductoID_Actual As Integer = 0    ' 0 = Alta | > 0 = Modificación (ID del producto)


    Private Sub FormInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarDataGrid()
    End Sub

    ' =========================================================================
    ' 1. FUNCIÓN DE ACTUALIZACIÓN DEL DATAGRID Y CONFIGURACIÓN
    ' =========================================================================

    Private Sub ActualizarDataGrid()
        ' 1. Carga los datos desde la BD y los asigna al DataGridView
        dgvProductos.DataSource = gestor.CargarProductosActivos()

        ' 2. Llama a la nueva función de configuración después de que los datos se cargaron
        ConfigurarDataGridColumns()

        LimpiarCampos()
    End Sub

    ' 🔑 FUNCIÓN PARA CONFIGURAR COLUMNAS (Llamada DESPUÉS de asignar el DataSource)
    Private Sub ConfigurarDataGridColumns()
        ' CONFIGURAR COLUMNA DE IMAGEN Y FORMATO

        ' 1. Formato y ocultamiento de columnas de la BD
        If dgvProductos.Columns.Contains("ProductoID") Then
            dgvProductos.Columns("ProductoID").Visible = False
            dgvProductos.Columns("RutaImagen").Visible = False
            dgvProductos.Columns("Precio").DefaultCellStyle.Format = "N2"
        End If

        ' 2. Añadir la Columna de Imagen
        ' Si la columna de imagen no se ha agregado, agregarla para el CellFormatting
        If Not dgvProductos.Columns.Contains("ColImagen") Then
            Dim colImagen As New DataGridViewImageColumn()
            colImagen.Name = "ColImagen"
            colImagen.HeaderText = "Imagen"
            colImagen.Width = 80
            colImagen.ImageLayout = DataGridViewImageCellLayout.Zoom

            ' ⚠️ Insertamos la columna en una posición lógica (ej. después de Codigo)
            Dim columnIndex As Integer = -1
            If dgvProductos.Columns.Contains("Codigo") Then
                columnIndex = dgvProductos.Columns("Codigo").Index + 1
            End If

            If columnIndex >= 0 And columnIndex < dgvProductos.Columns.Count Then
                dgvProductos.Columns.Insert(columnIndex, colImagen)
            Else
                dgvProductos.Columns.Add(colImagen)
            End If
        End If
    End Sub

    Private Sub LimpiarCampos()
        ' 🔑 Nuevos campos: Código y Descripción
        TxtCodigo.Clear()
        TxtDescripcion.Clear()
        TxtStock.Text = "0"
        TxtPrecio.Text = "0.00"
        pbImagenProducto.Image = Nothing
        rutaArchivoTemporal = ""
        ProductoID_Actual = 0 ' Resetear a modo ALTA
        ' Actualizar texto del botón a "Guardar" si es necesario
        BtnGuardar.Text = "Guardar Nuevo"
    End Sub

    ' =========================================================================
    ' 2. BUSCAR IMAGEN Y VISTA PREVIA
    ' =========================================================================

    Private Sub btnBuscarImagen_Click(sender As Object, e As EventArgs) Handles BtnBuscarImagen.Click
        Using openFile As New OpenFileDialog()
            openFile.Title = "Seleccionar Imagen del Producto"
            openFile.Filter = "Imágenes (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png"

            If openFile.ShowDialog() = DialogResult.OK Then
                rutaArchivoTemporal = openFile.FileName
                pbImagenProducto.Image = Image.FromFile(rutaArchivoTemporal)
                pbImagenProducto.SizeMode = PictureBoxSizeMode.Zoom
            End If
        End Using
    End Sub

    ' =========================================================================
    ' 3. GUARDAR PRODUCTO (ALTA o MODIFICACIÓN)
    ' =========================================================================

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            If Not ValidarCampos() Then Return


            Dim codigo As String = TxtCodigo.Text
            Dim descripcion As String = TxtDescripcion.Text
            Dim stock As Integer = Integer.Parse(TxtStock.Text)
            Dim precio As Decimal = Decimal.Parse(TxtPrecio.Text)
            Dim rutaFinalImagen As String = ""

            ' 1. GESTIÓN DEL ARCHIVO DE IMAGEN
            If Not String.IsNullOrEmpty(rutaArchivoTemporal) Then
                ' Define la carpeta de destino y asegura que exista
                Dim directorioDestino As String = Application.StartupPath & "\ImagenesProductos\"
                If Not System.IO.Directory.Exists(directorioDestino) Then
                    System.IO.Directory.CreateDirectory(directorioDestino)
                End If

                ' Crea un nombre único para el archivo
                Dim nombreArchivo As String = Guid.NewGuid().ToString() & System.IO.Path.GetExtension(rutaArchivoTemporal)
                rutaFinalImagen = System.IO.Path.Combine(directorioDestino, nombreArchivo)

                ' Copia el archivo al destino
                System.IO.File.Copy(rutaArchivoTemporal, rutaFinalImagen, True)
            Else
                ' Si no se seleccionó una nueva imagen, conservamos la ruta existente (solo en modo modificación)
                If ProductoID_Actual > 0 Then
                    ' Carga la ruta actual desde el DataGridView para no perderla
                    rutaFinalImagen = dgvProductos.CurrentRow.Cells("RutaImagen").Value.ToString()
                End If
            End If

            ' 2. GESTIÓN DE BD (INSERTAR O MODIFICAR)
            If ProductoID_Actual = 0 Then
                ' ALTA
                gestor.InsertarProducto(codigo, descripcion, stock, precio, rutaFinalImagen)
                MessageBox.Show("Producto guardado con éxito.", "Guardado")
            Else
                ' MODIFICACIÓN
                gestor.ModificarProducto(ProductoID_Actual, codigo, descripcion, stock, precio, rutaFinalImagen)
                MessageBox.Show("Producto modificado con éxito.", "Modificado")
            End If

            ActualizarDataGrid()

        Catch ex As FormatException
            MessageBox.Show("Verifique que Stock y Precio sean números válidos.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al guardar/modificar: " & ex.Message, "Error")
        End Try
    End Sub

    ' =========================================================================
    ' 4. ELIMINAR PRODUCTO (Baja Lógica)
    ' =========================================================================
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If ProductoID_Actual = 0 Then
            MessageBox.Show("Seleccione un producto de la lista primero.", "Advertencia")
            Return
        End If

        If MessageBox.Show("¿Está seguro de eliminar (Baja Lógica) el producto seleccionado?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                ' ✅ CÓDIGO CORREGIDO (En el BtnEliminar_Click)
                gestor.GestionarEstadoLogicoProducto(ProductoID_Actual, 0)
                MessageBox.Show("Producto eliminado (Baja Lógica) con éxito.", "Eliminado")
                ActualizarDataGrid()
            Catch ex As Exception
                MessageBox.Show("Error al eliminar: " & ex.Message, "Error BD")
            End Try
        End If
    End Sub

    ' =========================================================================
    ' 5. CARGAR DATOS PARA MODIFICACIÓN (Clic en DataGrid)
    ' =========================================================================

    Private Sub dgvProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dgvProductos.Rows(e.RowIndex)

            ' 1. Cargar ID y Rutas Clave
            ProductoID_Actual = CInt(fila.Cells("ProductoID").Value)
            ' Es importante cargar la ruta guardada para evitar perderla si el usuario modifica otros campos sin cambiar la imagen
            rutaArchivoTemporal = fila.Cells("RutaImagen").Value.ToString()

            ' 2. Llenar campos
            TxtCodigo.Text = fila.Cells("Codigo").Value.ToString()

            TxtDescripcion.Text = fila.Cells("Descripcion").Value.ToString()
            TxtStock.Text = fila.Cells("Stock").Value.ToString()
            TxtPrecio.Text = fila.Cells("Precio").Value.ToString()

            ' 3. Mostrar imagen y cambiar botón
            If System.IO.File.Exists(rutaArchivoTemporal) Then
                pbImagenProducto.Image = Image.FromFile(rutaArchivoTemporal)
                pbImagenProducto.SizeMode = PictureBoxSizeMode.Zoom
            Else
                pbImagenProducto.Image = Nothing
            End If

            BtnGuardar.Text = "Modificar Producto" ' Indica al usuario que está en modo UPDATE
        End If
    End Sub


    ' =========================================================================
    ' 6. EVENTO PARA MOSTRAR IMAGEN EN LA CELDA (FORMATTING)
    ' =========================================================================

    Private Sub dgvProductos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvProductos.CellFormatting

        If dgvProductos.Columns(e.ColumnIndex).Name = "ColImagen" AndAlso e.RowIndex >= 0 Then

            ' 1. Evitar procesar la fila de nueva entrada (si existe)
            If dgvProductos.AllowUserToAddRows AndAlso e.RowIndex = dgvProductos.NewRowIndex Then
                Return
            End If

            ' 2. Obtener el objeto Value de la celda de la ruta
            ' 🔑 NUEVA LÍNEA DE SEGURIDAD
            Dim rutaObjeto As Object = dgvProductos.Rows(e.RowIndex).Cells("RutaImagen").Value

            ' 3. COMPROBACIÓN EXHAUSTIVA DE NULOS
            If rutaObjeto IsNot Nothing AndAlso Not DBNull.Value.Equals(rutaObjeto) Then

                Dim ruta As String = rutaObjeto.ToString()

                If Not String.IsNullOrWhiteSpace(ruta) AndAlso System.IO.File.Exists(ruta) Then
                    Try
                        e.Value = Image.FromFile(ruta)
                    Catch
                        ' Ignorar errores si el archivo existe pero no se puede leer (permisos, etc.)
                        e.Value = Nothing
                    End Try
                Else
                    e.Value = Nothing
                End If

                e.FormattingApplied = True
            End If
        End If
    End Sub

    ' =========================================================================
    ' 7. VALIDACIÓN
    ' =========================================================================
    Private Function ValidarCampos() As Boolean
        If String.IsNullOrWhiteSpace(TxtCodigo.Text) OrElse String.IsNullOrWhiteSpace(TxtPrecio.Text) OrElse String.IsNullOrWhiteSpace(TxtStock.Text) Then
            MessageBox.Show("El Código, Stock y Precio son obligatorios.", "Validación")
            Return False
        End If

        Dim stockValor As Integer
        Dim precioValor As Decimal

        If Not Integer.TryParse(TxtStock.Text, stockValor) OrElse Not Decimal.TryParse(TxtPrecio.Text, precioValor) Then
            MessageBox.Show("Stock y Precio deben ser números válidos.", "Validación")
            Return False
        End If
        Return True
    End Function

    ' Dentro de Public Class FormGestionProductos

    ' ⚠️ El 'Handles MyBase.Load' que venía de FormInventario_Load debe ser ELIMINADO.
    '    Ahora la carga inicial y la de las pestañas se hará aquí.

    Private Sub FormGestionProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Opcional: Cargar la primera pestaña por defecto al iniciar el formulario
        TabControlProductos_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub TabControlProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControlProductos.SelectedIndexChanged
        Select Case TabControlProductos.SelectedIndex
            Case 0 ' Pestaña 1: CRUD General
                ' La función que ya tenías para cargar el DGV general
                ActualizarDataGrid()
            Case 1 ' Pestaña 2: Productos con Stock (función que definimos antes)
                CargarProductosConStock()
            Case 2 ' Pestaña 3: Productos sin Stock (función que definimos antes)
                CargarProductosSinStock()
            Case 3 ' Pestaña 4: Productos Dados de Baja (Asumiendo índice 3)
                CargarProductosDeBaja()
        End Select
    End Sub
    Private Sub CargarProductosConStock()
        Dim dtProductos As New DataTable()
        Dim conexion As New SqlConnection("Server=localhost\SQLEXPRESS01;Database=ortopedicTecnologi_taller;Trusted_Connection=True;Encrypt=False;")

        ' Consulta: Trae productos activos (EstadoLogico=1) Y con Stock positivo
        Dim consulta As String = "SELECT ProductoID, Codigo, Descripcion, Stock, Precio " &
                                 "FROM Productos " &
                                 "WHERE EstadoLogico = 1 AND Stock > 0 " &
                                 "ORDER BY Descripcion ASC"

        Try
            conexion.Open()

            Dim adaptador As New SqlDataAdapter(consulta, conexion)
            adaptador.Fill(dtProductos)

            ' Asignar los datos al DataGridView de la pestaña de stock
            DgvProductosConStock.DataSource = dtProductos

        Catch ex As Exception
            MessageBox.Show("Error al cargar productos CON stock: " & ex.Message, "Error de Base de Datos")

        Finally
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub

    ' Dentro de Public Class FormGestionProductos

    Private Sub CargarProductosSinStock()
        Dim dtProductos As New DataTable()
        Dim conexion As New SqlConnection("Server=localhost\SQLEXPRESS01;Database=ortopedicTecnologi_taller;Trusted_Connection=True;Encrypt=False;")

        ' Consulta: Trae productos activos (EstadoLogico=1) Y con Stock igual a cero
        Dim consulta As String = "SELECT ProductoID, Codigo, Descripcion, Stock, Precio " &
                                 "FROM Productos " &
                                 "WHERE EstadoLogico = 1 AND Stock = 0 " &
                                 "ORDER BY Descripcion ASC"

        Try
            conexion.Open()

            Dim adaptador As New SqlDataAdapter(consulta, conexion)
            adaptador.Fill(dtProductos)

            ' Asignar los datos al DataGridView de la pestaña sin stock
            DgvProductosSinStock.DataSource = dtProductos

        Catch ex As Exception
            MessageBox.Show("Error al cargar productos SIN stock: " & ex.Message, "Error de Base de Datos")

        Finally
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub

    ' ... (El resto de tus funciones como ActualizarDataGrid, CargarProductosConStock, CargarProductosSinStock, LimpiarCampos, etc.)
    ' ... (Botones BtnBuscarImagen_Click, BtnGuardar_Click, BtnEliminar_Click)
    ' ... (Eventos dgvProductos_CellClick, dgvProductos_CellFormatting)
    ' ... (Función ValidarCampos)

    ' --- En el formulario (donde está el DgvProductosDeBaja) ---

    Private Sub BtnDarAlta_Click(sender As Object, e As EventArgs) Handles BtnDarAlta.Click
        ' Asegúrate de tener la fila seleccionada
        If DgvProductosDeBaja.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione el producto que desea volver a dar de alta.", "Advertencia")
            Return
        End If

        ' Obtener el ID del producto
        Dim idProducto As Integer = CInt(DgvProductosDeBaja.CurrentRow.Cells("ProductoID").Value)

        If MessageBox.Show("¿Está seguro de reactivar este producto y volver a darlo de ALTA?", "Confirmar Alta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                ' 🔑 Llama a la función del gestor
                gestor.GestionarEstadoLogicoProducto(ProductoID_Actual, 1)
                MessageBox.Show("Producto reactivado con éxito.", "Éxito")

                ' Refrescar la lista de productos dados de baja (el DGV actual)
                CargarProductosDeBaja()

                ' Opcional: Refrescar la vista general o con stock
                ' CargarProductosGeneral() 

            Catch ex As Exception
                MessageBox.Show("Error al reactivar el producto: " & ex.Message, "Error BD")
            End Try
        End If
    End Sub
    Private Sub CargarProductosDeBaja()
        Dim dtProductosBaja As New DataTable()
        Dim conexion As New SqlConnection("Server=localhost\SQLEXPRESS01;Database=ortopedicTecnologi_taller;Trusted_Connection=True;Encrypt=False;")
        ' Consulta: Trae productos que tienen EstadoLogico = 0
        Dim consulta As String = "SELECT ProductoID, Codigo, Descripcion, Stock, Precio " &
                                 "FROM Productos " &
                                 "WHERE EstadoLogico = 0 " &
                                 "ORDER BY Descripcion ASC"

        Try
            conexion.Open()

            Dim adaptador As New SqlDataAdapter(consulta, conexion)
            adaptador.Fill(dtProductosBaja)

            ' 🔑 Asegúrate de que este DataGridView sea el de tu pestaña "De Baja"
            DgvProductosDeBaja.DataSource = dtProductosBaja

        Catch ex As Exception
            MessageBox.Show("Error al cargar productos dados de baja: " & ex.Message, "Error de BD")

        Finally
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub

    Private Sub Tipo3_Click(sender As Object, e As EventArgs) Handles Tipo3.Click

    End Sub


    ' --- En el FormGestionProductos.vb (Pestaña Sin Stock) ---
    Private Sub BtnAgregarStock_Click(sender As Object, e As EventArgs) Handles btnAgregarStock.Click

        ' 1. Validar selección
        If DgvProductosSinStock.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione el producto al que desea agregar stock.", "Advertencia")
            Return
        End If

        ' 2. Obtener datos clave
        Dim idProducto As Integer = CInt(DgvProductosSinStock.CurrentRow.Cells("ProductoID").Value)
        Dim descripcion As String = DgvProductosSinStock.CurrentRow.Cells("Descripcion").Value.ToString()
        Dim cantidadNueva As Integer

        ' 3. Pedir la cantidad a agregar (Usando InputBox simple)
        Dim input As String = Microsoft.VisualBasic.Interaction.InputBox(
        "Ingrese la cantidad de unidades a agregar para: " & descripcion,
        "Añadir Stock", "1")

        ' 4. Validar la entrada
        If Not Integer.TryParse(input, cantidadNueva) OrElse cantidadNueva <= 0 Then
            MessageBox.Show("Debe ingresar una cantidad válida y positiva.", "Error de Entrada")
            Return
        End If

        Try
            ' 5. Ejecutar la actualización en la BD
            gestor.AgregarStock(idProducto, cantidadNueva)
            MessageBox.Show($"Se agregaron {cantidadNueva} unidades a {descripcion}.", "Stock Actualizado")

            ' 6. Refrescar la vista actual (Productos sin Stock)
            CargarProductosSinStock()

        Catch ex As Exception
            MessageBox.Show("Error al actualizar stock: " & ex.Message, "Error BD")
        End Try

    End Sub
    ' ✅ CÓDIGO CORREGIDO (En el BtnEliminar_Click)


End Class