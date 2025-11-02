' --- En FormClientesInactivos.vb ---
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class FormClientesInactivos

    Private gestor As New GestorBD()

    Private Sub FormClientesInactivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarListaInactivos()
    End Sub

    ' 🔑 FUNCIÓN PARA CARGAR LA GRILLA DE INACTIVOS
    Public Sub CargarListaInactivos()
        Try
            DgvClientesInactivos.DataSource = gestor.CargarClientesInactivos()
            ' [ ... Configuración de DGVClientesInactivos ... ]
        Catch ex As Exception
            MessageBox.Show("Error al cargar la vista de clientes inactivos: " & ex.Message)
        End Try
    End Sub

    ' --- BOTÓN REACTIVAR ---
    Private Sub BtnReactivar_Click(sender As Object, e As EventArgs) Handles btnReactivar.Click
        If DgvClientesInactivos.CurrentRow Is Nothing Then Return

        Dim idCliente As Integer = CInt(DgvClientesInactivos.CurrentRow.Cells("ClienteID").Value)
        Dim razonSocial As String = DgvClientesInactivos.CurrentRow.Cells("RazonSocial").Value.ToString()

        If MessageBox.Show($"¿Desea reactivar al cliente: {razonSocial}?", "Confirmar Alta", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                ' 1. Ejecutar la reactivación (EstadoLogico = 1)
                gestor.GestionarEstadoLogicoCliente(idCliente, 1)

                ' 2. Refrescar la vista actual (el cliente desaparecerá)
                CargarListaInactivos()

                ' 3. 🔑 RECARGAR EL FORMULARIO PRINCIPAL
                Dim frmActivos As FormClientes = Application.OpenForms.OfType(Of FormClientes)().FirstOrDefault()

                If frmActivos IsNot Nothing Then
                    frmActivos.CargarClientes()
                End If

                MessageBox.Show("Cliente reactivado con éxito.", "Éxito")

            Catch ex As Exception
                MessageBox.Show("Error al reactivar el cliente: " & ex.Message, "Error BD")
            End Try
        End If
    End Sub
End Class