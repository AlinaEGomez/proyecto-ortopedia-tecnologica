
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class FormProveedoresInactivos

    Private gestor As New GestorBD()

    Private Sub FormProveedoresInactivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarListaInactivos()
    End Sub

    ' --- FUNCIÓN PARA CARGAR LA GRILLA DE INACTIVOS ---
    Public Sub CargarListaInactivos()
        Try
            ' Requiere que GestorBD.CargarProveedoresInactivos() exista
            DgvProveedoresInactivos.DataSource = gestor.CargarProveedoresInactivos()

            ' Ocultar el ID y otros campos si es necesario
            If DgvProveedoresInactivos.Columns.Contains("ProveedorID") Then
                DgvProveedoresInactivos.Columns("ProveedorID").Visible = False
            End If

        Catch ex As Exception
            MessageBox.Show("Error al cargar la vista de proveedores inactivos: " & ex.Message)
        End Try
    End Sub

    ' --- BOTÓN REACTIVAR (Dar Alta Lógica) ---
    Private Sub BtnReactivar_Click(sender As Object, e As EventArgs) Handles btnReactivar.Click
        If DgvProveedoresInactivos.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione el proveedor que desea reactivar.", "Advertencia")
            Return
        End If

        Dim idProveedor As Integer = DgvProveedoresInactivos.CurrentRow.Cells("ProveedorID").Value
        Dim razonSocial = DgvProveedoresInactivos.CurrentRow.Cells("RazonSocial").Value.ToString

        If MessageBox.Show($"¿Desea reactivar al proveedor: {razonSocial}?", "Confirmar Alta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                ' 1. Ejecutar la reactivación (EstadoLogico = 1)
                gestor.GestionarEstadoLogicoProveedor(idProveedor, 1)

                MessageBox.Show($"El proveedor {razonSocial} ha sido reactivado con éxito.", "Éxito")

                ' 2. Refrescar la vista actual (el proveedor desaparecerá de esta lista)
                CargarListaInactivos

                ' 3. 🔑 LLAMAR AL FORMULARIO PRINCIPAL Y RECARGAR ACTIVOS (CLAVE)
                RefrescarProveedoresActivos

            Catch ex As Exception
                MessageBox.Show("Error al reactivar el proveedor: " & ex.Message, "Error BD")
            End Try
        End If
    End Sub

    ' --- FUNCIÓN PARA ENCONTRAR Y REFRESCAR EL FORMULARIO PRINCIPAL ---
    Private Sub RefrescarProveedoresActivos()
        ' Buscamos la instancia del formulario principal (FormProveedores)
        Dim frmActivos As FormProveedores = Application.OpenForms.OfType(Of FormProveedores)().FirstOrDefault()

        If frmActivos IsNot Nothing Then
            ' 🔑 Llamamos al método público CargarProveedores()
            frmActivos.CargarProveedores()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        FormProveedores.Show()
    End Sub
End Class