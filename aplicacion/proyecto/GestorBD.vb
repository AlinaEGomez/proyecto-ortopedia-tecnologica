
Imports Microsoft.Data.SqlClient
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms ' Necesario para Throw New Exception

Public Class GestorBD
    ' ⚠️ ASUME que CadenaConexion está definida aquí o en un módulo global
    Private Const CadenaConexion As String = "Server=localhost\SQLEXPRESS01;Database=ortopedicTecnologi_taller;Trusted_Connection=True;TrustServerCertificate=True;"

    ' ----------------------------------------------------------------------
    ' LEER (Cargar todo el inventario ACTIVO - FUNCIÓN PRINCIPAL)
    ' ----------------------------------------------------------------------
    Public Function CargarProductosActivos() As DataTable
        Dim dt As New DataTable()
        Dim consulta As String = "SELECT ProductoID, Codigo, Descripcion, Stock, Precio, RutaImagen, EstadoLogico FROM Productos WHERE EstadoLogico = 1 ORDER BY ProductoID DESC"

        Using conexion As New SqlConnection(CadenaConexion), cmd As New SqlCommand(consulta, conexion)
            Using adapter As New SqlDataAdapter(cmd)
                Try
                    adapter.Fill(dt)
                Catch ex As Exception
                    Throw New Exception("Fallo al cargar productos activos desde BD: " & ex.Message, ex)
                End Try
            End Using
        End Using
        Return dt
    End Function

    ' ----------------------------------------------------------------------
    ' CREAR (Alta de nuevo producto)
    ' ----------------------------------------------------------------------
    Public Sub InsertarProducto(ByVal codigo As String, ByVal descripcion As String, ByVal stock As Integer, ByVal precio As Decimal, ByVal rutaImagen As String)
        Dim consulta As String = "INSERT INTO Productos (Codigo, Descripcion, Stock, Precio, RutaImagen, EstadoLogico) VALUES (@cod, @desc, @stock, @precio, @ruta, 1)"

        Using conexion As New SqlConnection(CadenaConexion), cmd As New SqlCommand(consulta, conexion)
            cmd.Parameters.AddWithValue("@cod", codigo)
            cmd.Parameters.AddWithValue("@desc", descripcion)
            cmd.Parameters.AddWithValue("@stock", stock)
            cmd.Parameters.AddWithValue("@precio", precio)
            cmd.Parameters.AddWithValue("@ruta", rutaImagen)
            Try
                conexion.Open()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Throw New Exception("Fallo al insertar producto: " & ex.Message, ex)
            End Try
        End Using
    End Sub

    ' ----------------------------------------------------------------------
    ' MODIFICAR (Actualizar producto existente)
    ' ----------------------------------------------------------------------
    Public Sub ModificarProducto(ByVal id As Integer, ByVal codigo As String, ByVal descripcion As String, ByVal stock As Integer, ByVal precio As Decimal, ByVal rutaImagen As String)
        Dim consulta As String = "UPDATE Productos SET Codigo = @cod, Descripcion = @desc, Stock = @stock, Precio = @precio, RutaImagen = @ruta WHERE ProductoID = @id"

        Using conexion As New SqlConnection(CadenaConexion), cmd As New SqlCommand(consulta, conexion)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@cod", codigo)
            cmd.Parameters.AddWithValue("@desc", descripcion)
            cmd.Parameters.AddWithValue("@stock", stock)
            cmd.Parameters.AddWithValue("@precio", precio)
            cmd.Parameters.AddWithValue("@ruta", rutaImagen)
            Try
                conexion.Open()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Throw New Exception("Fallo al modificar el producto: " & ex.Message, ex)
            End Try
        End Using
    End Sub

    ' ----------------------------------------------------------------------
    ' BAJA LÓGICA / REACTIVACIÓN (Gestión de Estado)
    ' ----------------------------------------------------------------------
    Public Sub GestionarEstadoLogicoProducto(id As Integer, nuevoEstado As Integer)
        Dim consulta As String = "UPDATE Productos SET EstadoLogico = @NuevoEstado WHERE ProductoID = @ID"

        Using conexion As New SqlConnection(CadenaConexion), cmd As New SqlCommand(consulta, conexion)
            cmd.Parameters.AddWithValue("@ID", id)
            cmd.Parameters.AddWithValue("@NuevoEstado", nuevoEstado) ' 0 o 1

            Try
                conexion.Open()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Throw New Exception("Fallo al cambiar estado lógico del producto: " & ex.Message, ex)
            End Try
        End Using
    End Sub

    ' ----------------------------------------------------------------------
    ' OTRAS FUNCIONES (Ej. Agregar Stock)
    ' ----------------------------------------------------------------------
    Public Sub AgregarStock(productoID As Integer, cantidadAAgregar As Integer)
        Dim consulta As String = "UPDATE Productos SET Stock = Stock + @Cantidad WHERE ProductoID = @ID"

        Using conexion As New SqlConnection(CadenaConexion), cmd As New SqlCommand(consulta, conexion)
            cmd.Parameters.AddWithValue("@Cantidad", cantidadAAgregar)
            cmd.Parameters.AddWithValue("@ID", productoID)

            Try
                conexion.Open()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Throw New Exception("Fallo al agregar stock: " & ex.Message, ex)
            End Try
        End Using
    End Sub

    ' --- En tu CLASE GestorBD.vb ---
    '---------------------------------------------------------------------------------
    '                              GESTION DE CLIENTES
    '---------------------------------------------------------------------------------
    ' --- En GestorBD.vb ---

    ' LECTURA: Clientes Activos
    Public Function CargarClientes() As DataTable
        Dim dt As New DataTable()
        Dim consulta As String = "SELECT ClienteID, RazonSocial, CUIT, Telefono, Email FROM Clientes WHERE EstadoLogico = 1 ORDER BY RazonSocial ASC"

        Using conexion As New SqlConnection(CadenaConexion), adaptador As New SqlDataAdapter(consulta, conexion)
            Try
                adaptador.Fill(dt)
            Catch ex As Exception
                Throw New Exception("Fallo al cargar clientes activos.", ex)
            End Try
        End Using
        Return dt
    End Function

    ' ESCRITURA: Insertar Cliente
    Public Sub InsertarCliente(razonSocial As String, cuit As String, telefono As String, email As String)
        Dim consulta As String = "INSERT INTO Clientes (RazonSocial, CUIT, Telefono, Email) VALUES (@RS, @CUIT, @Tel, @Email)"

        Using conexion As New SqlConnection(CadenaConexion), cmd As New SqlCommand(consulta, conexion)
            cmd.Parameters.AddWithValue("@RS", razonSocial)
            cmd.Parameters.AddWithValue("@CUIT", cuit)
            ' Manejo de NULLs
            cmd.Parameters.AddWithValue("@Tel", If(String.IsNullOrWhiteSpace(telefono), CType(DBNull.Value, Object), telefono))
            cmd.Parameters.AddWithValue("@Email", If(String.IsNullOrWhiteSpace(email), CType(DBNull.Value, Object), email))

            Try
                conexion.Open()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Throw New Exception("Fallo al insertar cliente: " & ex.Message, ex)
            End Try
        End Using
    End Sub

    ' ESCRITURA: Modificar Cliente
    Public Sub ModificarCliente(idCliente As Integer, razonSocial As String, cuit As String, telefono As String, email As String)
        Dim consulta As String = "UPDATE Clientes SET RazonSocial = @RS, CUIT = @CUIT, Telefono = @Tel, Email = @Email WHERE ClienteID = @ID"

        Using conexion As New SqlConnection(CadenaConexion), cmd As New SqlCommand(consulta, conexion)
            cmd.Parameters.AddWithValue("@ID", idCliente)
            cmd.Parameters.AddWithValue("@RS", razonSocial)
            cmd.Parameters.AddWithValue("@CUIT", cuit)
            cmd.Parameters.AddWithValue("@Tel", If(String.IsNullOrWhiteSpace(telefono), CType(DBNull.Value, Object), telefono))
            cmd.Parameters.AddWithValue("@Email", If(String.IsNullOrWhiteSpace(email), CType(DBNull.Value, Object), email))

            Try
                conexion.Open()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Throw New Exception("Fallo al modificar el cliente: " & ex.Message, ex)
            End Try
        End Using
    End Sub

    ' ESCRITURA: Baja/Alta Lógica
    Public Sub GestionarEstadoLogicoCliente(idCliente As Integer, nuevoEstado As Integer)
        Dim consulta As String = "UPDATE Clientes SET EstadoLogico = @NuevoEstado WHERE ClienteID = @ID"

        Using conexion As New SqlConnection(CadenaConexion), cmd As New SqlCommand(consulta, conexion)
            cmd.Parameters.AddWithValue("@ID", idCliente)
            cmd.Parameters.AddWithValue("@NuevoEstado", nuevoEstado) ' 0 o 1

            Try
                conexion.Open()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Throw New Exception("Fallo al cambiar estado lógico del cliente: " & ex.Message, ex)
            End Try
        End Using
    End Sub
End Class
