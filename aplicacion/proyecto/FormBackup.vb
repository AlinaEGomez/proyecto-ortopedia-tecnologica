' --- En tu Formulario de Administrador (donde está el Menú Strip) ---
Public Class FormBackup
    Private gestor As New GestorBD()
    Private nombreBaseDatos As String = "ortopedicTecnologi_taller" ' Nombre exacto de tu BD
    Private Sub btnIniciarBackup_Click(sender As Object, e As EventArgs) Handles btnIniciarBackup.Click

        ' 1. Confirmación de inicio
        If MessageBox.Show("¿Está seguro de iniciar la Copia de Seguridad?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        Dim rutaBackup As String = ""

        ' =================================================================
        ' 2. ABRIR DIÁLOGO PARA GUARDAR EL ARCHIVO (.bak)
        ' =================================================================
        Using sfdBackup As New SaveFileDialog()
            sfdBackup.Filter = "Archivos de Backup SQL (*.bak)|*.bak"
            sfdBackup.Title = "Seleccione la ubicación para guardar la COPIA DE SEGURIDAD (.bak)"
            sfdBackup.FileName = nombreBaseDatos & "_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".bak"

            If sfdBackup.ShowDialog() = DialogResult.OK Then
                rutaBackup = sfdBackup.FileName

                Try
                    ' 🔑 LLAMAMOS A LA FUNCIÓN QUE DEVUELVE UN STRING (NO LANZA ERROR)
                    Dim mensajeExito As String = gestor.EjecutarBackup(nombreBaseDatos, rutaBackup)

                    ' 🔑 MOSTRAMOS EL MENSAJE DE ÉXITO FINAL
                    MessageBox.Show(mensajeExito, "Backup Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception
                    ' Solo entramos aquí si hay un fallo real de SQL/Permisos
                    MessageBox.Show("⛔ Error al realizar el Backup: " & ex.Message, "Fallo SQL/Permisos", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End Try

            Else
                MessageBox.Show("Operación de Backup cancelada.", "Cancelado")

            End If
        End Using
    End Sub


End Class