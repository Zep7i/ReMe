Public Class Form6
    Public t As Tarea
    Public vt As New VerificacionTarea
    Private Sub Nueva_tarea_Click(sender As Object, e As EventArgs) Handles nueva_tarea.Click
        t = New Tarea()

        If opc_plazo_fecha.Text <> "Plazo" Then
            vt.TFecha = "Plazo"
            vt.Plazo = opc_plazo_fecha.Text
        ElseIf opc_plazo_fecha.Text = "Plazo" Then
            vt.TFecha = "Normal"
        End If
#Disable Warning BC42025 ' Acceso del miembro compartido, el miembro de constante, el miembro de enumeración o el tipo anidado a través de una instancia
        If vt.ComprobarFormato() = False Or t.rt <> 0 Then
            If Form2.contenedor_tareas.Controls.Count > 0 And Form1.Contenedor_tareas.Controls.ContainsKey("Form2") Then
                Form1.Notif_Globales_Timer.Enabled = False
                Form1.Vencimiento_Globales_Timer.Enabled = False
            End If
            If Form3.contenedor_tareas.Controls.Count > 0 And Form1.Contenedor_tareas.Controls.ContainsKey("Form3") Then
                Form1.Notif_Importantes_Timer.Enabled = False
                Form1.Vencimiento_Importantes_Timer.Enabled = False
            End If
            If Form4.contenedor_tareas.Controls.Count > 0 And Form1.Contenedor_tareas.Controls.ContainsKey("Form4") Then
                Form1.Vencimiento_Olvidadas_Timer.Enabled = False
            End If

            If t.Rt = 0 Then
                t.CAdc = vt.cadc
                t.Ctg = vt.categoria

                t.Crear_Tarea(box_nombre_tarea.Text, vt.finalizacion, Form1.id_usr, vt.fecha_notif.Date)

                If t.Ctg = 1 Then
                    Form1.ids_globales_notif.Add(t.Id_increment)
                    Form1.ids_globales_notif_estado.Add(t.Efn)
                    Form1.ids_globales_venc.Add(t.Id_increment)
                    Form1.Notif_Globales_Timer.Enabled = True
                    Form1.Vencimiento_Globales_Timer.Enabled = True
                ElseIf t.Ctg = 2 Then
                    Form1.ids_importantes_notif.Add(t.Id_increment)
                    Form1.ids_importantes_notif_estado.Add(t.Efn)
                    Form1.ids_importantes_venc.Add(t.Id_increment)
                    Form1.Notif_Importantes_Timer.Enabled = True
                    Form1.Vencimiento_Importantes_Timer.Enabled = True
                End If
            Else
                Dim nombre_tarea As Label = Form4.contenedor_tareas.Controls.Find("NombreTarea_" & t.Rt, True)(0)
                Dim Notificacion_Reentrega As New NotifyIcon With {
                        .Icon = My.Resources.Resource1.notificacion,
                        .Text = "ReMe",
                        .BalloonTipTitle = $"[ReMe] Se establceció la reentrega de: '{nombre_tarea.Text}'",
                        .BalloonTipText = $"Tu tarea fué aplazada a una nueva fecha y se encuentra en la categoria IMPORTANTES",
                        .Visible = True
                }
                Notificacion_Reentrega.ShowBalloonTip(5000)
                Form1.ids_olvidadas_venc.Remove(t.Rt)
                t.Olvidada_Importante(Now.Date, vt.finalizacion.Date, vt.fecha_notif.Date)
                Form4.contenedor_tareas.Controls.RemoveByKey("Tarea_" & t.Rt)

                Form1.ids_importantes_notif.Add(t.Rt)
                Form1.ids_importantes_notif_estado.Add(0)
                Form1.ids_importantes_venc.Add(t.Rt)

                Form3.contenedor_tareas.Controls.Clear()
                Form1.Cargar_Importantes()

                Form1.Notif_Importantes_Timer.Enabled = True
                Form1.Vencimiento_Importantes_Timer.Enabled = True
                Form1.Vencimiento_Olvidadas_Timer.Enabled = True
            End If

            Form1.Show()
            t.Actualizar_Tareas()
            t.rt = 0
#Enable Warning BC42025 ' Acceso del miembro compartido, el miembro de constante, el miembro de enumeración o el tipo anidado a través de una instancia
            Close()
        End If
    End Sub

    Private Sub Btn_regresar_Click(sender As Object, e As EventArgs) Handles btn_regresar.Click
        t = New Tarea()
        t.Rt = 0
        Close()
        Form1.Show()
    End Sub
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        date_finalizacion.MinDate = Now().AddDays(7)
        date_finalizacion.Value = Now().AddDays(7)
    End Sub
    Private Sub Btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        t.Rt = 0
        Close()
        Form1.CerrarSesion()
    End Sub
    Private Sub Btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class