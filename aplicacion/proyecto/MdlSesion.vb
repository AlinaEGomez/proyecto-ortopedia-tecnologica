Module MdlSesion
    ' --- MdlSesion.vb ---

    ' El nombre del módulo que definiste

    ' 1. Variables de Sesión (Accesibles desde cualquier formulario)
    Public PerfilUsuario As String = "Invitado"
        Public VendedorID As Integer = 0
        Public NombreCompleto As String = ""

    ' 2. Variable para la Cadena de Conexión (Opcional, pero útil)
    Public CadenaConexion As String = "Server=localhost\SQLEXPRESS;Database=ortopedicTecnologi_taller;Trusted_Connection=True;Encrypt=False;"

    ' 3. Función Global (Ejemplo: Obtener la fecha formateada)
    Public Function ObtenerFechaFormateada() As String
            Return DateTime.Now.ToString("dd/MM/yyyy")
        End Function


End Module
