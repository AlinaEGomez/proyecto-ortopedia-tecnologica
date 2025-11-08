
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms ' Necesario para Throw New Exception
Imports Microsoft.Data.SqlClient
Imports Microsoft.Identity.Client.Platforms.Shared

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
    '--------------------------------------------------------------------------------------
    '            BUSCAR PRODUCTO
    '-------------------------------------------------------------------------------------

    ' --- En GestorBD.vb ---

    Public Function BuscarProductos(ByVal textoFiltro As String) As DataTable
        Dim dt As New DataTable()

        ' Usamos el comodín % para buscar coincidencias parciales en Codigo o Descripcion
        ' La clave es la cláusula LIKE:
        Dim consulta As String = "SELECT Codigo, Descripcion, Stock, Precio " &
                         "FROM Productos " &
                         "WHERE EstadoLogico = 1 AND Stock > 0 AND " &
                         "(Codigo LIKE @Filtro OR Descripcion LIKE @Filtro) " &
                         "ORDER BY Descripcion ASC"

        Using conexion As New SqlConnection(CadenaConexion), cmd As New SqlCommand(consulta, conexion)
            ' 🔑 IMPORTANTE: Añadimos % a la variable para que SQL funcione con LIKE
            cmd.Parameters.AddWithValue("@Filtro", "%" & textoFiltro & "%")

            Using adaptador As New SqlDataAdapter(cmd)
                Try
                    adaptador.Fill(dt)
                Catch ex As Exception
                    Throw New Exception("Fallo al ejecutar la búsqueda: " & ex.Message, ex)
                End Try
            End Using
        End Using
        Return dt
    End Function

    ' --- En GestorBD.vb ---

    Public Function BuscarStockParaVendedor(ByVal textoFiltro As String) As DataTable
        Dim dt As New DataTable()

        ' 🔑 Paso 1: Si el filtro es nulo o solo espacios, devuelves la lista completa
        If String.IsNullOrWhiteSpace(textoFiltro) Then
            ' Esto debería llamar a CargarProductosEnStock() si la quieres completa
            ' Pero si la queremos filtrada, seguimos con el LIKE.
        End If

        ' Paso 2: Ejecución de la consulta
        Dim consulta As String = "SELECT Codigo, Descripcion, Stock, Precio " &
                                 "FROM Productos " &
                                 "WHERE EstadoLogico = 1 AND Stock > 0 AND " &
                                 "(Codigo LIKE @Filtro OR Descripcion LIKE @Filtro) " &
                                 "ORDER BY Descripcion ASC"

        Using conexion As New SqlConnection(CadenaConexion), cmd As New SqlCommand(consulta, conexion)
            ' El comodín es crucial: '%xyz%'
            cmd.Parameters.AddWithValue("@Filtro", "%" & textoFiltro & "%")

            Using adaptador As New SqlDataAdapter(cmd)
                Try
                    adaptador.Fill(dt)
                Catch ex As Exception
                    Throw New Exception("Fallo al ejecutar la búsqueda: " & ex.Message, ex)
                End Try
            End Using
        End Using
        Return dt

    End Function
    '---------------------------------------------------------------------------------
    '                              GESTION DE CLIENTES
    '---------------------------------------------------------------------------------


    Public Sub InsertarCliente(razonSocial As String, cuit As String, telefono As String, email As String)
        Dim consulta As String = "INSERT INTO Clientes (RazonSocial, CUIT, Telefono, Email) VALUES (@RS, @CUIT, @Tel, @Email)"

        Using conexion As New SqlConnection(CadenaConexion), cmd As New SqlCommand(consulta, conexion)
            cmd.Parameters.AddWithValue("@RS", razonSocial)
            cmd.Parameters.AddWithValue("@CUIT", cuit)
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


    ' ----------------------------------------------------
    '   TRANSACCIÓN CLAVE: Registrar Compra y Sumar Stock
    ' ----------------------------------------------------
    Public Function RegistrarCompra(
        proveedorID As Integer,
        idUsuario As Integer,
        total As Decimal,
        detalle As DataTable) As Integer

        Dim idCompraRegistrada As Integer = 0
        Dim transaccion As SqlTransaction = Nothing

        ' CONSULTAS SQL para la transacción
        Dim insertCompraSQL As String = "INSERT INTO Compras (FechaCompra, ProveedorID, IdUsuarioRegistro, TotalCompra) OUTPUT INSERTED.CompraID VALUES (GETDATE(), @provID, @userID, @total)"
        Dim insertDetalleSQL As String = "INSERT INTO DetalleCompra (CompraID, ProductoID, Cantidad, PrecioCosto) VALUES (@cID, @pID, @cant, @precioCosto)"
        Dim updateStockSQL As String = "UPDATE Productos SET Stock = Stock + @cant WHERE ProductoID = @pID" ' 🔑 SUMA STOCK

        Using conexion As New SqlConnection(CadenaConexion)
            Try
                conexion.Open()
                transaccion = conexion.BeginTransaction()

                ' 1. Insertar Cabecera de Compra
                Using cmdCompra As New SqlCommand(insertCompraSQL, conexion, transaccion)
                    cmdCompra.Parameters.AddWithValue("@provID", proveedorID)
                    cmdCompra.Parameters.AddWithValue("@userID", idUsuario)
                    cmdCompra.Parameters.AddWithValue("@total", total)
                    idCompraRegistrada = CInt(cmdCompra.ExecuteScalar())
                End Using

                ' 2. Insertar Detalle y Actualizar Stock (Bucle)
                For Each fila As DataRow In detalle.Rows
                    Dim pID As Integer = CInt(fila("ProductoID"))
                    Dim cantidadComprada As Integer = CInt(fila("Cantidad"))
                    Dim precioCosto As Decimal = CDec(fila("PrecioCosto"))

                    ' 2a. Insertar Detalle
                    Using cmdDetalle As New SqlCommand(insertDetalleSQL, conexion, transaccion)
                        cmdDetalle.Parameters.AddWithValue("@cID", idCompraRegistrada)
                        cmdDetalle.Parameters.AddWithValue("@pID", pID)
                        cmdDetalle.Parameters.AddWithValue("@cant", cantidadComprada)
                        cmdDetalle.Parameters.AddWithValue("@precioCosto", precioCosto)
                        cmdDetalle.ExecuteNonQuery()
                    End Using

                    ' 2b. Actualizar Stock
                    Using cmdStock As New SqlCommand(updateStockSQL, conexion, transaccion)
                        cmdStock.Parameters.AddWithValue("@cant", cantidadComprada)
                        cmdStock.Parameters.AddWithValue("@pID", pID)
                        cmdStock.ExecuteNonQuery()
                    End Using
                Next

                ' 3. Confirmar Transacción
                transaccion.Commit()
                Return idCompraRegistrada

            Catch ex As Exception
                ' 4. Rollback en caso de error
                If transaccion IsNot Nothing Then transaccion.Rollback()
                Throw New Exception("Fallo en la transacción de compra: " & ex.Message, ex)
            End Try
        End Using
    End Function

    ' --- PROVEEDOR ---

    ' ----------------------------------------------------
    ' LECTURA
    ' ----------------------------------------------------
    Public Function CargarProveedores() As DataTable
        Dim dt As New DataTable()
        Dim consulta As String = "SELECT ProveedorID, RazonSocial, CUIT, ContactoNombre, Telefono, Email, EstadoLogico FROM Proveedores WHERE EstadoLogico = 1 ORDER BY RazonSocial ASC"

        Using conexion As New SqlConnection(CadenaConexion), adaptador As New SqlDataAdapter(consulta, conexion)
            Try
                adaptador.Fill(dt)
            Catch ex As Exception
                Throw New Exception("Fallo al cargar proveedores activos.", ex)
            End Try
        End Using
        Return dt
    End Function

    ' ----------------------------------------------------
    ' ESCRITURA: Insertar Proveedor (ALTA)
    ' ----------------------------------------------------
    Public Sub InsertarProveedor(razonSocial As String, cuit As String, contacto As String, telefono As String, email As String)
        Dim consulta As String = "INSERT INTO Proveedores (RazonSocial, CUIT, ContactoNombre, Telefono, Email) VALUES (@RS, @CUIT, @Contacto, @Tel, @Email)"

        Using conexion As New SqlConnection(CadenaConexion), cmd As New SqlCommand(consulta, conexion)
            cmd.Parameters.AddWithValue("@RS", razonSocial)
            cmd.Parameters.AddWithValue("@CUIT", cuit)
            cmd.Parameters.AddWithValue("@Contacto", If(String.IsNullOrWhiteSpace(contacto), CType(DBNull.Value, Object), contacto))
            cmd.Parameters.AddWithValue("@Tel", If(String.IsNullOrWhiteSpace(telefono), CType(DBNull.Value, Object), telefono))
            cmd.Parameters.AddWithValue("@Email", If(String.IsNullOrWhiteSpace(email), CType(DBNull.Value, Object), email))

            Try
                conexion.Open()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Throw New Exception("Fallo al insertar proveedor: " & ex.Message, ex)
            End Try
        End Using
    End Sub

    ' ----------------------------------------------------
    ' ESCRITURA: Modificar Proveedor (UPDATE)
    ' ----------------------------------------------------
    Public Sub ModificarProveedor(idProveedor As Integer, razonSocial As String, cuit As String, contacto As String, telefono As String, email As String)
        Dim consulta As String = "UPDATE Proveedores SET RazonSocial = @RS, CUIT = @CUIT, ContactoNombre = @Contacto, Telefono = @Tel, Email = @Email WHERE ProveedorID = @ID"

        Using conexion As New SqlConnection(CadenaConexion), cmd As New SqlCommand(consulta, conexion)
            cmd.Parameters.AddWithValue("@ID", idProveedor)
            cmd.Parameters.AddWithValue("@RS", razonSocial)
            cmd.Parameters.AddWithValue("@CUIT", cuit)
            cmd.Parameters.AddWithValue("@Contacto", If(String.IsNullOrWhiteSpace(contacto), CType(DBNull.Value, Object), contacto))
            cmd.Parameters.AddWithValue("@Tel", If(String.IsNullOrWhiteSpace(telefono), CType(DBNull.Value, Object), telefono))
            cmd.Parameters.AddWithValue("@Email", If(String.IsNullOrWhiteSpace(email), CType(DBNull.Value, Object), email))

            Try
                conexion.Open()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Throw New Exception("Fallo al modificar el proveedor: " & ex.Message, ex)
            End Try
        End Using
    End Sub

    ' ----------------------------------------------------
    ' BAJA/ALTA LÓGICA
    ' ----------------------------------------------------
    Public Sub GestionarEstadoLogicoProveedor(idProveedor As Integer, nuevoEstado As Integer)
        Dim consulta As String = "UPDATE Proveedores SET EstadoLogico = @NuevoEstado WHERE ProveedorID = @ID"

        Using conexion As New SqlConnection(CadenaConexion), cmd As New SqlCommand(consulta, conexion)
            cmd.Parameters.AddWithValue("@ID", idProveedor)
            cmd.Parameters.AddWithValue("@NuevoEstado", nuevoEstado)

            Try
                conexion.Open()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Throw New Exception("Fallo al cambiar estado lógico del proveedor: " & ex.Message, ex)
            End Try
        End Using
    End Sub

    Public Function CargarProveedoresInactivos() As DataTable
        Dim dt As New DataTable()
        ' 🔑 CONSULTA CLAVE: Trae solo proveedores inactivos
        Dim consulta As String = "SELECT ProveedorID, RazonSocial, CUIT, ContactoNombre, Telefono, Email " &
                                 "FROM Proveedores WHERE EstadoLogico = 0 ORDER BY RazonSocial ASC"

        Using conexion As New SqlConnection(CadenaConexion), adaptador As New SqlDataAdapter(consulta, conexion)
            Try
                adaptador.Fill(dt)
            Catch ex As Exception
                Throw New Exception("Fallo al cargar proveedores inactivos.", ex)
            End Try
        End Using
        Return dt
    End Function
    Public Function ObtenerReporteCompras(fechaInicio As DateTime, fechaFin As DateTime) As DataTable
        Dim dt As New DataTable()
        Dim consulta As String = "SELECT P.RazonSocial AS Proveedor, U.Nombre_Apellido AS Usuario_Registro, COUNT(C.CompraID) AS Total_Ordenes, SUM(C.TotalCompra) AS Monto_Total_Comprado FROM Compras C JOIN Proveedores P ON C.ProveedorID = P.ProveedorID JOIN Usuarios U ON C.IdUsuarioRegistro = U.Id WHERE C.FechaCompra BETWEEN @FechaInicio AND @FechaFin GROUP BY P.RazonSocial, U.Nombre_Apellido ORDER BY Monto_Total_Comprado DESC"

        Using conexion As New SqlConnection(CadenaConexion)
            Using cmd As New SqlCommand(consulta, conexion)
                ' 🔑 Añadir Parámetros de Fecha
                cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio)
                cmd.Parameters.AddWithValue("@FechaFin", fechaFin)

                Using adaptador As New SqlDataAdapter(cmd)
                    Try
                        adaptador.Fill(dt)
                    Catch ex As Exception
                        Throw New Exception("Fallo al generar el reporte de compras: " & ex.Message, ex)
                    End Try
                End Using
            End Using
        End Using
        Return dt
    End Function
    '----------------------------------------------------------------------------
    '                      BACKUP DE DATOS
    '--------------------------------------------------------------------------

    Public Function EjecutarBackup(nombreBD As String, rutaCompleta As String) As String ' <-- Ahora devuelve un String

        Dim consulta As String = $"BACKUP DATABASE [{nombreBD}] TO DISK = N'{rutaCompleta}' WITH NOINIT, NAME = N'Backup_{nombreBD}'"

        Using conexion As New SqlConnection(CadenaConexion)
            Using cmd As New SqlCommand(consulta, conexion)
                Try
                    conexion.Open()
                    cmd.ExecuteNonQuery()

                    ' 🔑 CORRECCIÓN: Retornamos el éxito y la ruta
                    Return "Backup completado. Ruta: " & rutaCompleta
                Catch ex As Exception
                    ' Si hay un fallo real (permisos/conexión), aún lanzamos el error
                    Throw New Exception("Fallo al ejecutar el backup: " & ex.Message, ex)
                Finally
                    If conexion.State = ConnectionState.Open Then conexion.Close()
                End Try
            End Using
        End Using
        ' Esta línea no debería alcanzarse, pero la incluimos
        Return "Fallo al iniciar el proceso."
    End Function

    ' -------------------------------------------------------------------------
    ' NUEVA FUNCIÓN: Obtener datos para Excel (Ejemplo: Reporte de Ventas por Vendedor)
    ' -------------------------------------------------------------------------
    Public Function ObtenerReporteVentas(fechaInicio As DateTime, fechaFin As DateTime) As DataTable
        Dim dt As New DataTable()
        Dim consulta As String = "SELECT U.Nombre_Apellido AS Vendedor, SUM(V.Total) AS Monto_Total_Vendido " &
                                 "FROM Ventas V JOIN Usuarios U ON V.IdVendedor = U.Id " &
                                 "WHERE V.Fecha BETWEEN @FechaInicio AND @FechaFin " &
                                 "GROUP BY U.Nombre_Apellido, U.Id ORDER BY Monto_Total_Vendido DESC"

        Using conexion As New SqlConnection(CadenaConexion)
            Using cmd As New SqlCommand(consulta, conexion)
                cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio)
                cmd.Parameters.AddWithValue("@FechaFin", fechaFin)

                Using adaptador As New SqlDataAdapter(cmd)
                    Try
                        adaptador.Fill(dt)
                    Catch ex As Exception
                        Throw New Exception("Fallo al obtener datos para reporte: " & ex.Message, ex)
                    End Try
                End Using
            End Using
        End Using
        Return dt
    End Function
    '-------------------------------------------------------------------------------------
    '                   Muestra las ventas de cada vendedor 
    '------------------------------------------------------------------------------------
    Public Function CargarVentasPorVendedor(ByVal idVendedor As Integer) As DataTable
        Dim dt As New DataTable()

        ' 🔑 CONSULTA CLAVE: Filtra por el IdVendedor
        Dim consulta As String = "SELECT VentaID, Fecha, Total " &
                             "FROM Ventas " &
                             "WHERE IdVendedor = @ID " &
                             "ORDER BY Fecha DESC"

        Using conexion As New SqlConnection(CadenaConexion), cmd As New SqlCommand(consulta, conexion)
            ' Usamos parámetros para seguridad
            cmd.Parameters.AddWithValue("@ID", idVendedor)

            Using adaptador As New SqlDataAdapter(cmd)
                Try
                    adaptador.Fill(dt)
                Catch ex As Exception
                    Throw New Exception("Fallo al cargar las ventas del vendedor: " & ex.Message, ex)
                End Try
            End Using
        End Using
        Return dt
    End Function

    ' --- En GestorBD.vb ---

    Public Function CargarClientes() As DataTable
        Dim dt As New DataTable()
        ' Filtro: EstadoLogico = 1 (Activos)
        Dim consulta As String = "SELECT ClienteID, RazonSocial, CUIT, Telefono, Email, EstadoLogico FROM Clientes WHERE EstadoLogico = 1 ORDER BY RazonSocial ASC"

        Using conexion As New SqlConnection(CadenaConexion), adaptador As New SqlDataAdapter(consulta, conexion)
            Try
                adaptador.Fill(dt)
            Catch ex As Exception
                Throw New Exception("Fallo al cargar clientes activos.", ex)
            End Try
        End Using
        Return dt
    End Function

    ' --- En GestorBD.vb ---

    Public Function CargarClientesInactivos() As DataTable
        Dim dt As New DataTable()
        ' Filtro: EstadoLogico = 0 (Inactivos)
        Dim consulta As String = "SELECT ClienteID, RazonSocial, CUIT, Telefono, Email FROM Clientes WHERE EstadoLogico = 0 ORDER BY RazonSocial ASC"

        Using conexion As New SqlConnection(CadenaConexion), adaptador As New SqlDataAdapter(consulta, conexion)
            Try
                adaptador.Fill(dt)
            Catch ex As Exception
                Throw New Exception("Fallo al cargar clientes inactivos.", ex)
            End Try
        End Using
        Return dt
    End Function
    Public Function ObtenerReporteVentasParaGrafico() As DataTable
        Dim dt As New DataTable()

        ' Consulta que agrupa el TOTAL vendido por el nombre del usuario
        Dim consulta As String = "SELECT U.Nombre_Apellido AS Vendedor, SUM(V.Total) AS Monto_Vendido " &
                                 "FROM Ventas V " &
                                 "JOIN Usuarios U ON V.IdVendedor = U.Id " &
                                 "WHERE U.Perfil IN ('vendedor', 'gerente') " &
                                 "GROUP BY U.Nombre_Apellido " &
                                 "ORDER BY Monto_Vendido DESC"

        Using conexion As New SqlConnection(CadenaConexion), adaptador As New SqlDataAdapter(consulta, conexion)
            Try
                adaptador.Fill(dt)
            Catch ex As Exception
                Throw New Exception("Fallo al obtener datos para el gráfico de ventas: " & ex.Message, ex)
            End Try
        End Using
        Return dt
    End Function

End Class
