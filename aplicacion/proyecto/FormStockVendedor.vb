Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms ' Necesario para MessageBox

Public Class FormStockVendedor

    Private gestor As New GestorBD()
    ' Asumimos que el TextBox de búsqueda se llama txtBuscarProd

    Private Sub FormStockVendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Carga inicial (sin filtro)
        CargarStockDisponible()
    End Sub
    Private Sub FormClientes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Volver al formulario según el perfil
        Select Case MdlSesion.PerfilUsuario
            Case "administrador"
                Dim frmAdmin As New FormAdministrador()
                frmAdmin.Show()
            Case "gerente"
                Dim frmGerente As New FormGerente()
                frmGerente.Show()
            Case "vendedor"
                Dim frmVendedor As New FormVendedor()
                frmVendedor.Show()
        End Select
    End Sub
    ' ----------------------------------------------------
    ' FUNCIÓN PRINCIPAL DE CARGA Y FILTRADO (ÚNICA)
    ' ----------------------------------------------------
    Public Sub CargarStockDisponible(Optional ByVal filtro As String = "")

        Dim dtProductos As DataTable

        Try
            If String.IsNullOrEmpty(filtro) Then
                ' Si el campo de búsqueda está vacío, carga todo el stock disponible
                ' ⚠️ Revisa que CargarProductosEnStock exista en GestorBD.
                dtProductos = gestor.CargarProductosActivos()
            Else
                ' 🔑 Si hay filtro, usa la función de búsqueda de productos
                ' ⚠️ Revisa que BuscarStockParaVendedor exista en GestorBD.
                dtProductos = gestor.BuscarStockParaVendedor(filtro)
            End If

            DgvStock.DataSource = dtProductos

            ' Configuración de la grilla
            If DgvStock.Columns.Contains("Precio") Then
                DgvStock.Columns("Precio").DefaultCellStyle.Format = "C2"
            End If

            DgvStock.ReadOnly = True

            ' ❌ ELIMINAMOS EL MENSAJE DE "NO ENCONTRADO" AQUÍ. 
            ' El TextChanged no debe mostrar mensajes para no interrumpir la escritura.

        Catch ex As Exception
            MessageBox.Show("Error al cargar el stock disponible: " & ex.Message, "Error BD")
        End Try
    End Sub

    ' ----------------------------------------------------
    ' 🔑 MANEJADOR 1: BÚSQUEDA AUTOMÁTICA (TextChanged)
    ' ----------------------------------------------------
    Private Sub txtBuscarProd_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarProd.TextChanged
        ' Esto mantiene el DGV filtrado mientras el vendedor escribe.
        CargarStockDisponible(txtBuscarProd.Text.Trim())
    End Sub


    ' ----------------------------------------------------
    ' 🔑 MANEJADOR 2: BOTÓN BUSCAR (MUESTRA MENSAJE)
    ' ----------------------------------------------------
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim filtro = txtBuscarProd.Text.Trim

        ' 1. Verificación para evitar buscar en vacío
        If String.IsNullOrEmpty(filtro) Then
            MessageBox.Show("Por favor, ingrese un código o descripción para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ' Recargamos la grilla completa si está vacía
            CargarStockDisponible
            Return
        End If

        ' 2. Llamamos a la función de carga/búsqueda
        CargarStockDisponible(filtro)

        ' 3. 🔑 VERIFICACIÓN Y MENSAJE DE "NO ENCONTRADO" (solo después de una búsqueda válida)
        If DgvStock.Rows.Count = 0 Then
            MessageBox.Show($"Búsqueda completada. No se encontraron productos que coincidan con '{filtro}'.", "Búsqueda Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show($"Búsqueda completada. {DgvStock.Rows.Count} producto(s) encontrado(s).", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class