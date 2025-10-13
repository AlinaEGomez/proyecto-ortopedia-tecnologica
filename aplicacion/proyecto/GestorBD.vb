Imports Microsoft.Data.SqlClient

Public Class GestorBD

    ' **IMPORTANTE:** Cambia esta cadena de conexión con tus propios datos de servidor.
    Private Shared ReadOnly ConnectionString As String =
        "Server=localhost\SQLEXPRESS01;Database=ortopedia_taller;Trusted_Connection=True;Encrypt=False;"
    ' O usa User ID=TU_USUARIO;Password=TU_PASSWORD si no usas autenticación de Windows

    ' =========================================================================
    ' 1. CONEXIÓN
    ' =========================================================================

    Private Function ObtenerConexion() As SqlConnection
        Return New SqlConnection(ConnectionString)
    End Function

    ' =========================================================================
    ' 2. CRUD: CREAR (INSERTAR)
    ' =========================================================================

    Public Sub InsertarProducto(nombre As String, stock As Integer, precio As Decimal, rutaImagen As String)
        Dim sql As String = "INSERT INTO Productos (Nombre, Stock, Precio, RutaImagen) " &
                            "VALUES (@nom, @stk, @pre, @ruta)"

        Using con As SqlConnection = ObtenerConexion()
            Using cmd As New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@nom", nombre)
                cmd.Parameters.AddWithValue("@stk", stock)
                cmd.Parameters.AddWithValue("@pre", precio)

                ' Maneja si la ruta es nula o vacía (guarda NULL en la BD)
                cmd.Parameters.AddWithValue("@ruta", If(String.IsNullOrEmpty(rutaImagen), CType(DBNull.Value, Object), rutaImagen))

                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' =========================================================================
    ' 3. CRUD: LEER (OBTENER TODOS LOS PRODUCTOS)
    ' =========================================================================

    Public Function CargarProductos() As DataTable
        Dim tabla As New DataTable()
        Dim sql As String = "SELECT ProductoID, Nombre, Stock, Precio, RutaImagen FROM Productos ORDER BY Nombre"

        Using con As SqlConnection = ObtenerConexion()
            Using da As New SqlDataAdapter(sql, con)
                da.Fill(tabla)
            End Using
        End Using

        Return tabla
    End Function

    ' Puedes agregar aquí las funciones para Actualizar (UPDATE) y Eliminar (DELETE)
    ' =========================================================================
    ' 4. CRUD: ACTUALIZAR (MODIFICAR)
    ' =========================================================================

    ''' <summary>
    ''' Modifica los datos de un producto existente.
    ''' </summary>
    ''' <param name="idProducto">El ID del producto a modificar.</param>
    Public Sub ActualizarProducto(idProducto As Integer, nombre As String, stock As Integer, precio As Decimal, rutaImagen As String)
        Dim sql As String = "UPDATE Productos SET " &
                            "Nombre = @nom, " &
                            "Stock = @stk, " &
                            "Precio = @pre, " &
                            "RutaImagen = @ruta " &
                            "WHERE ProductoID = @id"

        Using con As SqlConnection = ObtenerConexion()
            Using cmd As New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@id", idProducto)
                cmd.Parameters.AddWithValue("@nom", nombre)
                cmd.Parameters.AddWithValue("@stk", stock)
                cmd.Parameters.AddWithValue("@pre", precio)

                ' Maneja si la ruta es nula o vacía
                cmd.Parameters.AddWithValue("@ruta", If(String.IsNullOrEmpty(rutaImagen), CType(DBNull.Value, Object), rutaImagen))

                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' =========================================================================
    ' 5. CRUD: ELIMINAR (LÓGICO)
    ' =========================================================================

    ''' <summary>
    ''' Realiza una eliminación lógica estableciendo EstadoLogico a 0 (Inactivo).
    ''' </summary>
    ''' <param name="idProducto">El ID del producto a eliminar lógicamente.</param>
    Public Sub EliminarProductoLogico(idProducto As Integer)
        ' El comando SQL solo cambia el estado de 1 (Activo) a 0 (Inactivo)
        Dim sql As String = "UPDATE Productos SET EstadoLogico = 0 WHERE ProductoID = @id"

        Using con As SqlConnection = ObtenerConexion()
            Using cmd As New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@id", idProducto)

                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub


End Class
