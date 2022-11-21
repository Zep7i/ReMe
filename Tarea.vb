Imports MySql.Data.MySqlClient
#Disable Warning CA1822 ' Marcar miembros como static
#Disable Warning IDE0017 ' Simplificar la inicialización de objetos
Public Class Tarea
    Dim db As ReMe_DB
    Private categ_adc As Integer = 1
    Public categ As Integer = 1
    Public estado As Integer = 1
    Public panel_tarea As New Panel()
    Public funcion_tarea As New PictureBox()
    Public desaprobar_tarea As New Button()
    Public eliminar_tarea As New PictureBox()
    Public fecha_tarea As New Label()
    Public aprobar_tarea As New Button()
    Public fecha_label_tarea As New Label()
    Public nombre_tarea As New Label()
    Public tarea_vencimiento As New Label()
    Private Shared c As Integer = 0
    Private estado_notif As Integer = 0
    Private Shared rentrega As Integer = 0
    Public Property Rt As Integer
        Get
            Return rentrega
        End Get
        Set(value As Integer)
            rentrega = value
        End Set
    End Property
    Public Property Ctg As Integer
        Get
            Return categ
        End Get
        Set(value As Integer)
            categ = value
        End Set
    End Property
    Public Property CAdc As Integer
        Get
            Return categ_adc
        End Get
        Set(value As Integer)
            categ_adc = value
        End Set
    End Property

    Public ReadOnly Property Id_increment As Integer
        Get
            Return c
        End Get
    End Property

    Public ReadOnly Property Efn As Integer
        Get
            Return estado_notif
        End Get
    End Property
    Public Sub Crear_Tarea(Nombre As String, Finalizacion As Date, IdUsuario As Integer, venc As Date)
        Try
            db = New ReMe_DB
            db.miComando.CommandText = "Crear_Tarea"
            db.miComando.CommandType = CommandType.StoredProcedure

            Dim param1 As New MySqlParameter("n1", MySqlDbType.VarChar)
            Dim param2 As New MySqlParameter("n2", MySqlDbType.Int32)
            Dim param3 As New MySqlParameter("n3", MySqlDbType.Int32)
            Dim param4 As New MySqlParameter("n4", MySqlDbType.Int32)
            Dim param5 As New MySqlParameter("n5", MySqlDbType.Date)
            Dim param6 As New MySqlParameter("n6", MySqlDbType.Date)
            Dim param7 As New MySqlParameter("n7", MySqlDbType.Int32)
            Dim param8 As New MySqlParameter("n8", MySqlDbType.Date)

            param1.Direction = ParameterDirection.Input
            param2.Direction = ParameterDirection.Input
            param3.Direction = ParameterDirection.Input
            param4.Direction = ParameterDirection.Input
            param5.Direction = ParameterDirection.Input
            param6.Direction = ParameterDirection.Input
            param7.Direction = ParameterDirection.Input
            param8.Direction = ParameterDirection.Input

            param1.Value = Nombre
            If rt <> 0 Then
                categ = 2
            End If
            param2.Value = categ
            param3.Value = estado
            param4.Value = categ_adc
            param5.Value = Now()
            param6.Value = Finalizacion
            param7.Value = IdUsuario
            param8.Value = venc

            db.miComando.Parameters.Add(param1)
            db.miComando.Parameters.Add(param2)
            db.miComando.Parameters.Add(param3)
            db.miComando.Parameters.Add(param4)
            db.miComando.Parameters.Add(param5)
            db.miComando.Parameters.Add(param6)
            db.miComando.Parameters.Add(param7)
            db.miComando.Parameters.Add(param8)

            Dim rd As MySqlDataReader = db.miComando.ExecuteReader
            If rd.Read() Then
                c = rd.GetInt32(0)
                estado_notif = rd.GetInt32(1)
            End If

            panel_tarea.BorderStyle = BorderStyle.FixedSingle
            panel_tarea.Controls.Add(eliminar_tarea)
            panel_tarea.Controls.Add(funcion_tarea)
            panel_tarea.Controls.Add(desaprobar_tarea)
            panel_tarea.Controls.Add(aprobar_tarea)
            panel_tarea.Controls.Add(fecha_tarea)
            panel_tarea.Controls.Add(fecha_label_tarea)
            panel_tarea.Controls.Add(nombre_tarea)
            panel_tarea.Controls.Add(tarea_vencimiento)
            panel_tarea.Location = New Point(3, 94)
            panel_tarea.Name = "Tarea_" & c
            panel_tarea.Size = New Size(504, 85)
            panel_tarea.TabIndex = 1
            panel_tarea.Visible = True

            eliminar_tarea.Cursor = Cursors.Hand
            eliminar_tarea.Image = My.Resources.Resource1.cerrar_tarea
            eliminar_tarea.Location = New Point(458, 29)
            eliminar_tarea.Name = "BtnEliminar_" & c
            eliminar_tarea.Size = New Size(35, 31)
            eliminar_tarea.SizeMode = PictureBoxSizeMode.StretchImage
            eliminar_tarea.TabIndex = 14
            eliminar_tarea.TabStop = False
            eliminar_tarea.Visible = False

            funcion_tarea.Cursor = Cursors.Hand
            funcion_tarea.Image = My.Resources.Resource1.plus_img
            funcion_tarea.Location = New Point(458, 29)
            funcion_tarea.Name = "BtnFunciones_" & c
            funcion_tarea.Size = New Size(34, 30)
            funcion_tarea.SizeMode = PictureBoxSizeMode.StretchImage
            funcion_tarea.TabIndex = 14
            funcion_tarea.TabStop = False

            desaprobar_tarea.AccessibleDescription = "Marcar tarea como desaprobada"
            desaprobar_tarea.AccessibleName = "Desaprobado"
            desaprobar_tarea.Cursor = Cursors.Hand
            desaprobar_tarea.FlatStyle = FlatStyle.Flat
            desaprobar_tarea.Font = New Font("Segoe UI", 9.0!, FontStyle.Regular, GraphicsUnit.Point)
            desaprobar_tarea.ForeColor = Color.White
            desaprobar_tarea.Location = New Point(378, 29)
            desaprobar_tarea.Name = "BtnDesaprobado_" & c
            desaprobar_tarea.Size = New Size(34, 30)
            desaprobar_tarea.TabIndex = 14
            desaprobar_tarea.TabStop = False
            desaprobar_tarea.Text = "Dp"
            desaprobar_tarea.UseVisualStyleBackColor = True
            desaprobar_tarea.Visible = False

            aprobar_tarea.AccessibleDescription = "Marcar tarea como aprobada"
            aprobar_tarea.AccessibleName = "Aprobado"
            aprobar_tarea.Cursor = Cursors.Hand
            aprobar_tarea.FlatStyle = FlatStyle.Flat
            aprobar_tarea.Font = New Font("Segoe UI", 9.0!, FontStyle.Regular, GraphicsUnit.Point)
            aprobar_tarea.ForeColor = Color.White
            aprobar_tarea.Location = New Point(418, 29)
            aprobar_tarea.Name = "BtnAprobado_" & c
            aprobar_tarea.Size = New Size(34, 30)
            aprobar_tarea.TabIndex = 12
            aprobar_tarea.TabStop = False
            aprobar_tarea.Text = "Ap"
            aprobar_tarea.UseVisualStyleBackColor = True
            aprobar_tarea.Visible = False

            fecha_tarea.AutoSize = True
            fecha_tarea.Font = New Font("Segoe UI", 11.0!, FontStyle.Regular, GraphicsUnit.Point)
            fecha_tarea.ForeColor = Color.White
            fecha_tarea.Location = New Point(160, 39)
            fecha_tarea.Name = "FechaTarea_" & c
            fecha_tarea.Size = New Size(69, 20)
            fecha_tarea.TabIndex = 3
            fecha_tarea.Text = Finalizacion

            fecha_label_tarea.AutoSize = True
            fecha_label_tarea.Font = New Font("Segoe UI", 11.0!, FontStyle.Regular, GraphicsUnit.Point)
            fecha_label_tarea.ForeColor = Color.White
            fecha_label_tarea.Location = New Point(10, 39)
            fecha_label_tarea.Name = "FechaLabelTarea_" & c
            fecha_label_tarea.Size = New Size(151, 20)
            fecha_label_tarea.TabIndex = 2
            fecha_label_tarea.Text = "Fecha de finalización:"

            nombre_tarea.AutoSize = True
            nombre_tarea.Font = New Font("Segoe UI", 13.0!, FontStyle.Regular, GraphicsUnit.Point)
            nombre_tarea.ForeColor = Color.White
            nombre_tarea.Location = New Point(10, 11)
            nombre_tarea.Name = "NombreTarea_" & c
            nombre_tarea.Size = New Size(80, 25)
            nombre_tarea.TabIndex = 1
            nombre_tarea.Text = Nombre

            tarea_vencimiento.AutoSize = True
            tarea_vencimiento.Font = New Font("Segoe UI", 13.0!, FontStyle.Regular, GraphicsUnit.Point)
            tarea_vencimiento.ForeColor = Color.White
            tarea_vencimiento.Location = New Point(150, 11)
            tarea_vencimiento.Name = "Vencimiento_" & c
            tarea_vencimiento.Size = New Size(80, 25)
            tarea_vencimiento.TabIndex = 1
            tarea_vencimiento.Text = venc
            tarea_vencimiento.Visible = False

            If categ = 1 Then
                Form2.contenedor_tareas.Controls.Add(panel_tarea)
            Else
                Form3.contenedor_tareas.Controls.Add(panel_tarea)
            End If

            AddHandler funcion_tarea.Click, AddressOf Funcion_tarea_Click
            AddHandler aprobar_tarea.Click, AddressOf Aprobar_tarea_Click
            AddHandler desaprobar_tarea.Click, AddressOf Desaprobar_tarea_Click
            AddHandler eliminar_tarea.Click, AddressOf Eliminar_tarea_Click

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub Eliminar_tarea_Click(sender As Object, e As EventArgs)
        Try
            If Form2.contenedor_tareas.Controls.Count > 0 And Form1.Contenedor_tareas.Controls.ContainsKey("Form2") Then
                Form1.Notif_Globales_Timer.Enabled = False
                Form1.Vencimiento_Globales_Timer.Enabled = False
            End If
            If Form3.contenedor_tareas.Controls.Count > 0 And Form1.Contenedor_tareas.Controls.ContainsKey("Form3") Then
                Form1.Notif_Importantes_Timer.Enabled = False
                Form1.Vencimiento_Importantes_Timer.Enabled = False
            End If
            If Form4.contenedor_tareas.Controls.Count > 0 And Form1.Contenedor_tareas.Controls.ContainsKey("Form3") Then
                Form1.Vencimiento_Olvidadas_Timer.Enabled = False
            End If

            db = New ReMe_DB
            db.miComando.CommandText = "Eliminar_Tarea"
            db.miComando.CommandType = CommandType.StoredProcedure
            Dim p1 As New MySqlParameter("n1", MySqlDbType.Int32)
            p1.Direction = ParameterDirection.Input
            p1.Value = CType(sender, PictureBox).Name.Split("_")(1)
            db.miComando.Parameters.Add(p1)
            db.miComando.ExecuteNonQuery()
            db.Dispose()

            Dim notif_eliminada As New NotifyIcon With {
                .Icon = My.Resources.Resource1.notificacion,
                .Text = "ReMe",
                .BalloonTipTitle = $"[ReMe] La tarea fué borrada con éxito",
                .BalloonTipText = $"La tarea se eliminó definitivamente del sistema.",
                .Visible = True
            }
            notif_eliminada.ShowBalloonTip(5000)

            If Form2.contenedor_tareas.Controls.Count > 0 And Form1.Contenedor_tareas.Controls.ContainsKey("Form2") Then
                Dim indx_notif As Integer = Form1.ids_globales_notif.IndexOf(Convert.ToInt32(CType(sender, PictureBox).Name.Split("_")(1)))
                Form1.ids_globales_notif_estado.RemoveAt(Convert.ToInt32(indx_notif))
                Form1.ids_globales_notif.Remove(Convert.ToInt32(CType(sender, PictureBox).Name.Split("_")(1)))
                Form1.ids_globales_venc.Remove(Convert.ToInt32(CType(sender, PictureBox).Name.Split("_")(1)))
                Form2.contenedor_tareas.Controls.RemoveByKey("Tarea_" & CType(sender, PictureBox).Name.Split("_")(1))
                If Form2.contenedor_tareas.Controls.Count >= 1 Then
                    Form1.Notif_Globales_Timer.Enabled = True
                    Form1.Vencimiento_Globales_Timer.Enabled = True
                End If
            End If
            If Form3.contenedor_tareas.Controls.Count > 0 And Form1.Contenedor_tareas.Controls.ContainsKey("Form3") Then
                Dim indx_notif As Integer = Form1.ids_importantes_notif.IndexOf(Convert.ToInt32(CType(sender, PictureBox).Name.Split("_")(1)))
                Form1.ids_importantes_notif_estado.RemoveAt(Convert.ToInt32(indx_notif))
                Form1.ids_importantes_notif.Remove(Convert.ToInt32(CType(sender, PictureBox).Name.Split("_")(1)))
                Form1.ids_importantes_venc.Remove(Convert.ToInt32(CType(sender, PictureBox).Name.Split("_")(1)))
                Form3.contenedor_tareas.Controls.RemoveByKey("Tarea_" & CType(sender, PictureBox).Name.Split("_")(1))
                If Form3.contenedor_tareas.Controls.Count >= 1 Then
                    Form1.Notif_Importantes_Timer.Enabled = True
                    Form1.Vencimiento_Importantes_Timer.Enabled = True
                End If
            End If
            If Form4.contenedor_tareas.Controls.Count > 0 And Form1.Contenedor_tareas.Controls.ContainsKey("Form4") Then
                Form1.ids_olvidadas_venc.Remove(Convert.ToInt32(CType(sender, PictureBox).Name.Split("_")(1)))
                Form4.contenedor_tareas.Controls.RemoveByKey("Tarea_" & CType(sender, PictureBox).Name.Split("_")(1))
                If Form4.contenedor_tareas.Controls.Count >= 1 Then
                    Form1.Vencimiento_Olvidadas_Timer.Enabled = True
                End If
            End If
            If Form5.contenedor_tareas.Controls.Count > 0 And Form1.Contenedor_tareas.Controls.ContainsKey("Form5") Then
                Form5.contenedor_tareas.Controls.RemoveByKey("Tarea_" & CType(sender, PictureBox).Name.Split("_")(1))
            End If

            Actualizar_Tareas()
        Catch ex As Exception
            MsgBox("Se produjo un error al intentar eliminar la tarea..", vbCritical, "ERROR")
        End Try
    End Sub
    Public Sub Desaprobar_tarea_Click(sender As Object, e As EventArgs)
        Try
            If Form2.contenedor_tareas.Controls.Count > 0 Then
                Form1.Notif_Globales_Timer.Enabled = False
                Form1.Vencimiento_Globales_Timer.Enabled = False
            End If
            If Form3.contenedor_tareas.Controls.Count > 0 Then
                Form1.Notif_Importantes_Timer.Enabled = False
                Form1.Vencimiento_Importantes_Timer.Enabled = False
            End If
            If Form4.contenedor_tareas.Controls.Count > 0 Then
                Form1.Vencimiento_Olvidadas_Timer.Enabled = False
            End If

            db = New ReMe_DB
            db.miComando.CommandText = "Actualizar_Estado"
            db.miComando.CommandType = CommandType.StoredProcedure
            Dim param1 As New MySqlParameter("n1", MySqlDbType.Int32)
            Dim param2 As New MySqlParameter("n2", MySqlDbType.Int32)
            param1.Direction = ParameterDirection.Input
            param2.Direction = ParameterDirection.Input
            param1.Value = 3
            param2.Value = Convert.ToInt32(CType(sender, Button).Name.Split("_")(1))
            db.miComando.Parameters.Add(param1)
            db.miComando.Parameters.Add(param2)
            db.miComando.ExecuteNonQuery()
            db.Dispose()

            If Form2.contenedor_tareas.Controls.ContainsKey($"{"Tarea_" & CType(sender, Button).Name.Split("_")(1)}") Then
                Dim indx_notif As Integer = Form1.ids_globales_notif.IndexOf(Convert.ToInt32(CType(sender, Button).Name.Split("_")(1)))
                Form1.ids_globales_notif_estado.RemoveAt(Convert.ToInt32(indx_notif))
                Form1.ids_globales_notif.Remove(Convert.ToInt32(CType(sender, Button).Name.Split("_")(1)))
                Form1.ids_globales_venc.Remove(Convert.ToInt32(CType(sender, Button).Name.Split("_")(1)))
                Form2.contenedor_tareas.Controls.RemoveByKey("Tarea_" & CType(sender, Button).Name.Split("_")(1))
                If Form2.contenedor_tareas.Controls.Count >= 1 Then
                    Form1.Notif_Globales_Timer.Enabled = True
                    Form1.Vencimiento_Globales_Timer.Enabled = True
                End If
            End If

            If Form3.contenedor_tareas.Controls.ContainsKey($"{"Tarea_" & CType(sender, Button).Name.Split("_")(1)}") Then
                Dim indx_notif As Integer = Form1.ids_importantes_notif.IndexOf(Convert.ToInt32(CType(sender, Button).Name.Split("_")(1)))
                Form1.ids_importantes_notif_estado.RemoveAt(indx_notif)
                Form1.ids_importantes_notif.Remove(Convert.ToInt32(CType(sender, Button).Name.Split("_")(1)))
                Form1.ids_importantes_venc.Remove(Convert.ToInt32(CType(sender, Button).Name.Split("_")(1)))
                Form3.contenedor_tareas.Controls.RemoveByKey("Tarea_" & CType(sender, Button).Name.Split("_")(1))
                If Form3.contenedor_tareas.Controls.Count >= 1 Then
                    Form1.Notif_Importantes_Timer.Enabled = True
                    Form1.Vencimiento_Importantes_Timer.Enabled = True
                End If
            End If

            If Form4.contenedor_tareas.Controls.ContainsKey($"{"Tarea_" & CType(sender, Button).Name.Split("_")(1)}") Then
                Form1.ids_olvidadas_venc.Remove(Convert.ToInt32(CType(sender, Button).Name.Split("_")(1)))
                Form4.contenedor_tareas.Controls.RemoveByKey("Tarea_" & CType(sender, Button).Name.Split("_")(1))
                Form1.Vencimiento_Olvidadas_Timer.Enabled = True
            End If

            Actualizar_Tareas()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error")
        End Try
    End Sub

    Public Sub Funcion_tarea_Click(sender As Object, e As EventArgs)
        Dim ap_tarea As Button
        Dim dp_tarea As Button
        Dim re_tarea As Button
        If Form1.Contenedor_tareas.Controls.ContainsKey("Form2") Then
            ap_tarea = Form2.contenedor_tareas.Controls.Find("BtnAprobado_" & CType(sender, PictureBox).Name.Split("_")(1), True)(0)
            dp_tarea = Form2.contenedor_tareas.Controls.Find("BtnDesaprobado_" & CType(sender, PictureBox).Name.Split("_")(1), True)(0)
        ElseIf Form1.Contenedor_tareas.Controls.ContainsKey("Form3") Then
            ap_tarea = Form3.contenedor_tareas.Controls.Find("BtnAprobado_" & CType(sender, PictureBox).Name.Split("_")(1), True)(0)
            dp_tarea = Form3.contenedor_tareas.Controls.Find("BtnDesaprobado_" & CType(sender, PictureBox).Name.Split("_")(1), True)(0)
        Else
            ap_tarea = Form4.contenedor_tareas.Controls.Find("BtnAprobado_" & CType(sender, PictureBox).Name.Split("_")(1), True)(0)
            dp_tarea = Form4.contenedor_tareas.Controls.Find("BtnDesaprobado_" & CType(sender, PictureBox).Name.Split("_")(1), True)(0)
            re_tarea = Form4.contenedor_tareas.Controls.Find("BtnRentrega_" & CType(sender, PictureBox).Name.Split("_")(1), True)(0)
            If ap_tarea.Visible = False Then
                re_tarea.Visible = True
            Else
                re_tarea.Visible = False
            End If
        End If
        If ap_tarea.Visible = False Then
            ap_tarea.Visible = True
            dp_tarea.Visible = True
            sender.Image = My.Resources.Resource1.minus_recurso
        ElseIf ap_tarea.Visible = True Then
            ap_tarea.Visible = False
            dp_tarea.Visible = False
            sender.Image = My.Resources.Resource1.plus_img
        End If

    End Sub

    Public Sub Aprobar_tarea_Click(sender As Object, e As EventArgs)
        Try
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

            db = New ReMe_DB
            db.miComando.CommandText = "Actualizar_Estado"
            db.miComando.CommandType = CommandType.StoredProcedure
            Dim p1 As New MySqlParameter("n1", MySqlDbType.Int32)
            Dim p2 As New MySqlParameter("n2", MySqlDbType.Int32)
            p1.Direction = ParameterDirection.Input
            p2.Direction = ParameterDirection.Input
            p1.Value = 2
            p2.Value = CInt(CType(sender, Button).Name.Split("_")(1))
            db.miComando.Parameters.Add(p1)
            db.miComando.Parameters.Add(p2)
            db.miComando.ExecuteNonQuery()
            db.Dispose()

            Dim Nombre_Tarea As Label

            If Form2.contenedor_tareas.Controls.ContainsKey("Tarea_" & CType(sender, Button).Name.Split("_")(1)) Then
                Nombre_Tarea = Form2.Controls.Find("NombreTarea_" & CType(sender, Button).Name.Split("_")(1), True)(0)
            ElseIf Form3.contenedor_tareas.Controls.ContainsKey("Tarea_" & CType(sender, Button).Name.Split("_")(1)) Then
                Nombre_Tarea = Form3.Controls.Find("NombreTarea_" & CType(sender, Button).Name.Split("_")(1), True)(0)
            Else
                Nombre_Tarea = Form4.Controls.Find("NombreTarea_" & CType(sender, Button).Name.Split("_")(1), True)(0)
            End If

            Generar_Aprobadas(CType(sender, Button).Name.Split("_")(1), Nombre_Tarea.Text, Now().Date)

            If Form2.contenedor_tareas.Controls.ContainsKey($"{"Tarea_" & CType(sender, Button).Name.Split("_")(1)}") Then
                Dim indx_notif As Integer = Form1.ids_globales_notif.IndexOf(Convert.ToInt32(CType(sender, Button).Name.Split("_")(1)))
                Form1.ids_globales_notif_estado.RemoveAt(indx_notif)
                Form1.ids_globales_notif.Remove(Convert.ToInt32(CType(sender, Button).Name.Split("_")(1)))
                Form1.ids_globales_venc.Remove(Convert.ToInt32(CType(sender, Button).Name.Split("_")(1)))
                Form2.contenedor_tareas.Controls.RemoveByKey("Tarea_" & CType(sender, Button).Name.Split("_")(1))
                If Form2.contenedor_tareas.Controls.Count >= 1 Then
                    Form1.Notif_Globales_Timer.Enabled = True
                    Form1.Vencimiento_Globales_Timer.Enabled = True
                End If
            End If

            If Form3.contenedor_tareas.Controls.ContainsKey($"{"Tarea_" & CType(sender, Button).Name.Split("_")(1)}") Then
                MsgBox(Form1.ids_importantes_notif.Count & " - " & Form1.ids_importantes_notif_estado.Count)
                Dim indx_notif As Integer = Form1.ids_importantes_notif.IndexOf(Convert.ToInt32(CType(sender, Button).Name.Split("_")(1)))
                Form1.ids_importantes_notif_estado.RemoveAt(indx_notif)
                Form1.ids_importantes_notif.Remove(Convert.ToInt32(CType(sender, Button).Name.Split("_")(1)))
                Form1.ids_importantes_venc.Remove(Convert.ToInt32(CType(sender, Button).Name.Split("_")(1)))
                Form3.contenedor_tareas.Controls.RemoveByKey("Tarea_" & CType(sender, Button).Name.Split("_")(1))
                If Form3.contenedor_tareas.Controls.Count >= 1 Then
                    Form1.Notif_Importantes_Timer.Enabled = True
                    Form1.Vencimiento_Importantes_Timer.Enabled = True
                End If
            End If

            If Form4.contenedor_tareas.Controls.ContainsKey($"{"Tarea_" & CType(sender, Button).Name.Split("_")(1)}") Then
                Form1.ids_olvidadas_venc.Remove(Convert.ToInt32(CType(sender, Button).Name.Split("_")(1)))
                Form4.contenedor_tareas.Controls.RemoveByKey("Tarea_" & CType(sender, Button).Name.Split("_")(1))
                Form1.Vencimiento_Olvidadas_Timer.Enabled = True
            End If

            Actualizar_Tareas()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Generar_Aprobadas(id As Integer, nombre As String, fecha As DateTime)
        Dim aprobar_panel As New Panel() With {
           .Name = "Tarea_" & id,
           .Size = New Size(504, 85),
           .BorderStyle = BorderStyle.FixedSingle,
           .Font = New Font("Segoe UI", 13.0!, FontStyle.Regular, GraphicsUnit.Point),
           .Visible = True
        }

        Dim aprobar_nombre As New Label() With {
            .AutoSize = True,
            .Name = "AprobadaNombre_" & id,
            .Location = New Point(10, 11),
            .Font = New Font("Segoe UI", 13.0!, FontStyle.Regular, GraphicsUnit.Point),
            .ForeColor = Color.White,
            .Text = nombre,
            .Visible = True
        }

        Dim aprobar_texto_fecha_aprobada As New Label() With {
            .AutoSize = True,
            .Name = "AprobadaTextoFechaAprobada_" & id,
            .Font = New Font("Segoe UI", 11.0!, FontStyle.Regular, GraphicsUnit.Point),
            .ForeColor = Color.White,
            .Location = New Point(10, 39),
            .Text = "Fecha Aprobada:",
            .Visible = True
        }

        Dim aprobar_fecha_aprobada As New Label() With {
            .AutoSize = True,
            .Name = "Aprobada-Fecha-Aprobada_" & id,
            .Font = New Font("Segoe UI", 11.0!, FontStyle.Regular, GraphicsUnit.Point),
            .ForeColor = Color.White,
            .Location = New Point(130, 39),
            .Text = fecha,
            .Visible = True
        }

        Dim aprobar_eliminar_aprobada As New PictureBox() With {
            .Cursor = Cursors.Hand,
            .Image = My.Resources.Resource1.cerrar_tarea,
            .Location = New Point(458, 29),
            .Name = "BtnEliminar_" & id,
            .Size = New Size(35, 31),
            .SizeMode = PictureBoxSizeMode.StretchImage,
            .TabIndex = 14,
            .TabStop = False,
            .Visible = False
        }

        aprobar_panel.Controls.Add(aprobar_eliminar_aprobada)
        aprobar_panel.Controls.Add(aprobar_nombre)
        aprobar_panel.Controls.Add(aprobar_texto_fecha_aprobada)
        aprobar_panel.Controls.Add(aprobar_fecha_aprobada)
        Form5.contenedor_tareas.Controls.Add(aprobar_panel)

        AddHandler aprobar_eliminar_aprobada.Click, AddressOf Eliminar_tarea_Click

    End Sub

    Public Sub Generar_Globales(id As Integer, nombre As String, finalizacion As DateTime, Notif As DateTime)
        Dim panel_tarea As New Panel()
        Dim eliminar_tarea As New PictureBox()
        Dim funcion_tarea As New PictureBox()
        Dim desaprobar_tarea As New Button()
        Dim aprobar_tarea As New Button()
        Dim fecha_tarea As New Label()
        Dim fecha_label_tarea As New Label()
        Dim nombre_tarea As New Label()
        Dim tarea_vencimiento As New Label()

        panel_tarea.BorderStyle = BorderStyle.FixedSingle
        panel_tarea.Controls.Add(eliminar_tarea)
        panel_tarea.Controls.Add(funcion_tarea)
        panel_tarea.Controls.Add(desaprobar_tarea)
        panel_tarea.Controls.Add(aprobar_tarea)
        panel_tarea.Controls.Add(fecha_tarea)
        panel_tarea.Controls.Add(fecha_label_tarea)
        panel_tarea.Controls.Add(nombre_tarea)
        panel_tarea.Controls.Add(tarea_vencimiento)
        panel_tarea.Location = New Point(3, 94)
        panel_tarea.Name = "Tarea_" & id
        panel_tarea.Size = New Size(504, 85)
        panel_tarea.TabIndex = 1
        panel_tarea.Visible = True

        eliminar_tarea.Cursor = Cursors.Hand
        eliminar_tarea.Image = My.Resources.Resource1.cerrar_tarea
        eliminar_tarea.Location = New Point(458, 29)
        eliminar_tarea.Name = "BtnEliminar_" & id
        eliminar_tarea.Size = New Size(35, 31)
        eliminar_tarea.SizeMode = PictureBoxSizeMode.StretchImage
        eliminar_tarea.TabIndex = 14
        eliminar_tarea.TabStop = False
        eliminar_tarea.Visible = False

        funcion_tarea.Cursor = Cursors.Hand
        funcion_tarea.Image = My.Resources.Resource1.plus_img
        funcion_tarea.Location = New Point(458, 29)
        funcion_tarea.Name = "BtnFunciones_" & id
        funcion_tarea.Size = New Size(34, 30)
        funcion_tarea.SizeMode = PictureBoxSizeMode.StretchImage
        funcion_tarea.TabIndex = 14
        funcion_tarea.TabStop = False

        desaprobar_tarea.Cursor = Cursors.Hand
        desaprobar_tarea.FlatStyle = FlatStyle.Flat
        desaprobar_tarea.Font = New Font("Segoe UI", 9.0!, FontStyle.Regular, GraphicsUnit.Point)
        desaprobar_tarea.ForeColor = Color.White
        desaprobar_tarea.Location = New Point(378, 29)
        desaprobar_tarea.Name = "BtnDesaprobado_" & id
        desaprobar_tarea.Size = New Size(34, 30)
        desaprobar_tarea.TabIndex = 14
        desaprobar_tarea.TabStop = False
        desaprobar_tarea.Text = "Dp"
        desaprobar_tarea.UseVisualStyleBackColor = True
        desaprobar_tarea.Visible = False

        aprobar_tarea.Cursor = Cursors.Hand
        aprobar_tarea.FlatStyle = FlatStyle.Flat
        aprobar_tarea.Font = New Font("Segoe UI", 9.0!, FontStyle.Regular, GraphicsUnit.Point)
        aprobar_tarea.ForeColor = Color.White
        aprobar_tarea.Location = New Point(418, 29)
        aprobar_tarea.Name = "BtnAprobado_" & id
        aprobar_tarea.Size = New Size(34, 30)
        aprobar_tarea.TabIndex = 12
        aprobar_tarea.TabStop = False
        aprobar_tarea.Text = "Ap"
        aprobar_tarea.UseVisualStyleBackColor = True
        aprobar_tarea.Visible = False

        fecha_tarea.AutoSize = True
        fecha_tarea.Font = New Font("Segoe UI", 11.0!, FontStyle.Regular, GraphicsUnit.Point)
        fecha_tarea.ForeColor = Color.White
        fecha_tarea.Location = New Point(160, 39)
        fecha_tarea.Name = "FechaTarea_" & id
        fecha_tarea.Size = New Size(69, 20)
        fecha_tarea.TabIndex = 3
        fecha_tarea.Text = finalizacion

        fecha_label_tarea.AutoSize = True
        fecha_label_tarea.Font = New Font("Segoe UI", 11.0!, FontStyle.Regular, GraphicsUnit.Point)
        fecha_label_tarea.ForeColor = Color.White
        fecha_label_tarea.Location = New Point(10, 39)
        fecha_label_tarea.Name = "FechaLabelTarea_" & id
        fecha_label_tarea.Size = New Size(151, 20)
        fecha_label_tarea.TabIndex = 2
        fecha_label_tarea.Text = "Fecha de finalización:"

        nombre_tarea.AutoSize = True
        nombre_tarea.Font = New Font("Segoe UI", 13.0!, FontStyle.Regular, GraphicsUnit.Point)
        nombre_tarea.ForeColor = Color.White
        nombre_tarea.Location = New Point(10, 11)
        nombre_tarea.Name = "NombreTarea_" & id
        nombre_tarea.Size = New Size(80, 25)
        nombre_tarea.TabIndex = 1
        nombre_tarea.Text = nombre

        tarea_vencimiento.AutoSize = True
        tarea_vencimiento.Font = New Font("Segoe UI", 13.0!, FontStyle.Regular, GraphicsUnit.Point)
        tarea_vencimiento.ForeColor = Color.White
        tarea_vencimiento.Location = New Point(150, 11)
        tarea_vencimiento.Name = "Vencimiento_" & id
        tarea_vencimiento.Size = New Size(80, 25)
        tarea_vencimiento.TabIndex = 1
        tarea_vencimiento.Text = Notif
        tarea_vencimiento.Visible = False

        Form2.contenedor_tareas.Controls.Add(panel_tarea)

        AddHandler funcion_tarea.Click, AddressOf Funcion_tarea_Click
        AddHandler aprobar_tarea.Click, AddressOf Aprobar_tarea_Click
        AddHandler desaprobar_tarea.Click, AddressOf Desaprobar_tarea_Click
        AddHandler eliminar_tarea.Click, AddressOf Eliminar_tarea_Click

    End Sub

    Public Sub Generar_Importantes(id As Integer, nombre As String, finalizacion As DateTime, Notif As DateTime)
        Dim panel_tarea As New Panel()
        Dim eliminar_tarea As New PictureBox()
        Dim funcion_tarea As New PictureBox()
        Dim desaprobar_tarea As New Button()
        Dim aprobar_tarea As New Button()
        Dim fecha_tarea As New Label()
        Dim fecha_label_tarea As New Label()
        Dim nombre_tarea As New Label()
        Dim tarea_vencimiento As New Label()

        panel_tarea.BorderStyle = BorderStyle.FixedSingle
        panel_tarea.Controls.Add(eliminar_tarea)
        panel_tarea.Controls.Add(funcion_tarea)
        panel_tarea.Controls.Add(desaprobar_tarea)
        panel_tarea.Controls.Add(aprobar_tarea)
        panel_tarea.Controls.Add(fecha_tarea)
        panel_tarea.Controls.Add(fecha_label_tarea)
        panel_tarea.Controls.Add(nombre_tarea)
        panel_tarea.Controls.Add(tarea_vencimiento)
        panel_tarea.Location = New Point(3, 94)
        panel_tarea.Name = "Tarea_" & id
        panel_tarea.Size = New Size(504, 85)
        panel_tarea.TabIndex = 1
        panel_tarea.Visible = True

        eliminar_tarea.Cursor = Cursors.Hand
        eliminar_tarea.Image = My.Resources.Resource1.cerrar_tarea
        eliminar_tarea.Location = New Point(458, 29)
        eliminar_tarea.Name = "BtnEliminar_" & id
        eliminar_tarea.Size = New Size(35, 31)
        eliminar_tarea.SizeMode = PictureBoxSizeMode.StretchImage
        eliminar_tarea.TabIndex = 14
        eliminar_tarea.TabStop = False
        eliminar_tarea.Visible = False

        funcion_tarea.Cursor = Cursors.Hand
        funcion_tarea.Image = My.Resources.Resource1.plus_img
        funcion_tarea.Location = New Point(458, 29)
        funcion_tarea.Name = "BtnFunciones_" & id
        funcion_tarea.Size = New Size(34, 30)
        funcion_tarea.SizeMode = PictureBoxSizeMode.StretchImage
        funcion_tarea.TabIndex = 14
        funcion_tarea.TabStop = False

        desaprobar_tarea.Cursor = Cursors.Hand
        desaprobar_tarea.FlatStyle = FlatStyle.Flat
        desaprobar_tarea.Font = New Font("Segoe UI", 9.0!, FontStyle.Regular, GraphicsUnit.Point)
        desaprobar_tarea.ForeColor = Color.White
        desaprobar_tarea.Location = New Point(378, 29)
        desaprobar_tarea.Name = "BtnDesaprobado_" & id
        desaprobar_tarea.Size = New Size(34, 30)
        desaprobar_tarea.TabIndex = 14
        desaprobar_tarea.TabStop = False
        desaprobar_tarea.Text = "Dp"
        desaprobar_tarea.UseVisualStyleBackColor = True
        desaprobar_tarea.Visible = False

        aprobar_tarea.Cursor = Cursors.Hand
        aprobar_tarea.FlatStyle = FlatStyle.Flat
        aprobar_tarea.Font = New Font("Segoe UI", 9.0!, FontStyle.Regular, GraphicsUnit.Point)
        aprobar_tarea.ForeColor = Color.White
        aprobar_tarea.Location = New Point(418, 29)
        aprobar_tarea.Name = "BtnAprobado_" & id
        aprobar_tarea.Size = New Size(34, 30)
        aprobar_tarea.TabIndex = 12
        aprobar_tarea.TabStop = False
        aprobar_tarea.Text = "Ap"
        aprobar_tarea.UseVisualStyleBackColor = True
        aprobar_tarea.Visible = False

        fecha_tarea.AutoSize = True
        fecha_tarea.Font = New Font("Segoe UI", 11.0!, FontStyle.Regular, GraphicsUnit.Point)
        fecha_tarea.ForeColor = Color.White
        fecha_tarea.Location = New Point(160, 39)
        fecha_tarea.Name = "FechaTarea_" & id
        fecha_tarea.Size = New Size(69, 20)
        fecha_tarea.TabIndex = 3
        fecha_tarea.Text = finalizacion

        fecha_label_tarea.AutoSize = True
        fecha_label_tarea.Font = New Font("Segoe UI", 11.0!, FontStyle.Regular, GraphicsUnit.Point)
        fecha_label_tarea.ForeColor = Color.White
        fecha_label_tarea.Location = New Point(10, 39)
        fecha_label_tarea.Name = "FechaLabelTarea_" & id
        fecha_label_tarea.Size = New Size(151, 20)
        fecha_label_tarea.TabIndex = 2
        fecha_label_tarea.Text = "Fecha de finalización:"

        nombre_tarea.AutoSize = True
        nombre_tarea.Font = New Font("Segoe UI", 13.0!, FontStyle.Regular, GraphicsUnit.Point)
        nombre_tarea.ForeColor = Color.White
        nombre_tarea.Location = New Point(10, 11)
        nombre_tarea.Name = "NombreTarea_" & id
        nombre_tarea.Size = New Size(80, 25)
        nombre_tarea.TabIndex = 1
        nombre_tarea.Text = nombre

        tarea_vencimiento.AutoSize = True
        tarea_vencimiento.Font = New Font("Segoe UI", 13.0!, FontStyle.Regular, GraphicsUnit.Point)
        tarea_vencimiento.ForeColor = Color.White
        tarea_vencimiento.Location = New Point(150, 11)
        tarea_vencimiento.Name = "Vencimiento_" & id
        tarea_vencimiento.Size = New Size(80, 25)
        tarea_vencimiento.TabIndex = 1
        tarea_vencimiento.Text = Notif
        tarea_vencimiento.Visible = False

        Form3.contenedor_tareas.Controls.Add(panel_tarea)

        AddHandler funcion_tarea.Click, AddressOf Funcion_tarea_Click
        AddHandler aprobar_tarea.Click, AddressOf Aprobar_tarea_Click
        AddHandler desaprobar_tarea.Click, AddressOf Desaprobar_tarea_Click
        AddHandler eliminar_tarea.Click, AddressOf Eliminar_tarea_Click

    End Sub
    Public Sub Generar_Olvidadas(id As Integer, nombre As String, finalizacion As DateTime, Notif As DateTime)
        Dim panel_tarea As New Panel()
        Dim eliminar_tarea As New PictureBox()
        Dim funcion_tarea As New PictureBox()
        Dim desaprobar_tarea As New Button()
        Dim aprobar_tarea As New Button()
        Dim fecha_tarea As New Label()
        Dim fecha_label_tarea As New Label()
        Dim nombre_tarea As New Label()
        Dim tarea_vencimiento As New Label()
        Dim reentregar_tarea As New Button()

        panel_tarea.BorderStyle = BorderStyle.FixedSingle
        panel_tarea.Controls.Add(eliminar_tarea)
        panel_tarea.Controls.Add(funcion_tarea)
        panel_tarea.Controls.Add(desaprobar_tarea)
        panel_tarea.Controls.Add(reentregar_tarea)
        panel_tarea.Controls.Add(aprobar_tarea)
        panel_tarea.Controls.Add(fecha_tarea)
        panel_tarea.Controls.Add(fecha_label_tarea)
        panel_tarea.Controls.Add(nombre_tarea)
        panel_tarea.Controls.Add(tarea_vencimiento)
        panel_tarea.Location = New Point(3, 94)
        panel_tarea.Name = "Tarea_" & id
        panel_tarea.Size = New Size(504, 85)
        panel_tarea.TabIndex = 1
        panel_tarea.Visible = True

        eliminar_tarea.Cursor = Cursors.Hand
        eliminar_tarea.Image = My.Resources.Resource1.cerrar_tarea
        eliminar_tarea.Location = New Point(458, 29)
        eliminar_tarea.Name = "BtnEliminar_" & id
        eliminar_tarea.Size = New Size(35, 31)
        eliminar_tarea.SizeMode = PictureBoxSizeMode.StretchImage
        eliminar_tarea.TabIndex = 14
        eliminar_tarea.TabStop = False
        eliminar_tarea.Visible = False

        funcion_tarea.Cursor = Cursors.Hand
        funcion_tarea.Image = My.Resources.Resource1.plus_img
        funcion_tarea.Location = New Point(458, 29)
        funcion_tarea.Name = "BtnFunciones_" & id
        funcion_tarea.Size = New Size(34, 30)
        funcion_tarea.SizeMode = PictureBoxSizeMode.StretchImage
        funcion_tarea.TabIndex = 14
        funcion_tarea.TabStop = False

        desaprobar_tarea.Cursor = Cursors.Hand
        desaprobar_tarea.FlatStyle = FlatStyle.Flat
        desaprobar_tarea.Font = New Font("Segoe UI", 9.0!, FontStyle.Regular, GraphicsUnit.Point)
        desaprobar_tarea.ForeColor = Color.White
        desaprobar_tarea.Location = New Point(378, 29)
        desaprobar_tarea.Name = "BtnDesaprobado_" & id
        desaprobar_tarea.Size = New Size(34, 30)
        desaprobar_tarea.TabIndex = 14
        desaprobar_tarea.TabStop = False
        desaprobar_tarea.Text = "Dp"
        desaprobar_tarea.UseVisualStyleBackColor = True
        desaprobar_tarea.Visible = False

        aprobar_tarea.Cursor = Cursors.Hand
        aprobar_tarea.FlatStyle = FlatStyle.Flat
        aprobar_tarea.Font = New Font("Segoe UI", 9.0!, FontStyle.Regular, GraphicsUnit.Point)
        aprobar_tarea.ForeColor = Color.White
        aprobar_tarea.Location = New Point(418, 29)
        aprobar_tarea.Name = "BtnAprobado_" & id
        aprobar_tarea.Size = New Size(34, 30)
        aprobar_tarea.TabIndex = 12
        aprobar_tarea.TabStop = False
        aprobar_tarea.Text = "Ap"
        aprobar_tarea.UseVisualStyleBackColor = True
        aprobar_tarea.Visible = False

        fecha_tarea.AutoSize = True
        fecha_tarea.Font = New Font("Segoe UI", 11.0!, FontStyle.Regular, GraphicsUnit.Point)
        fecha_tarea.ForeColor = Color.White
        fecha_tarea.Location = New Point(160, 39)
        fecha_tarea.Name = "FechaTarea_" & id
        fecha_tarea.Size = New Size(69, 20)
        fecha_tarea.TabIndex = 3
        fecha_tarea.Text = finalizacion

        fecha_label_tarea.AutoSize = True
        fecha_label_tarea.Font = New Font("Segoe UI", 11.0!, FontStyle.Regular, GraphicsUnit.Point)
        fecha_label_tarea.ForeColor = Color.White
        fecha_label_tarea.Location = New Point(10, 39)
        fecha_label_tarea.Name = "FechaLabelTarea_" & id
        fecha_label_tarea.Size = New Size(151, 20)
        fecha_label_tarea.TabIndex = 2
        fecha_label_tarea.Text = "Fecha de finalización:"

        nombre_tarea.AutoSize = True
        nombre_tarea.Font = New Font("Segoe UI", 13.0!, FontStyle.Regular, GraphicsUnit.Point)
        nombre_tarea.ForeColor = Color.White
        nombre_tarea.Location = New Point(10, 11)
        nombre_tarea.Name = "NombreTarea_" & id
        nombre_tarea.Size = New Size(80, 25)
        nombre_tarea.TabIndex = 1
        nombre_tarea.Text = nombre

        tarea_vencimiento.AutoSize = True
        tarea_vencimiento.Font = New Font("Segoe UI", 13.0!, FontStyle.Regular, GraphicsUnit.Point)
        tarea_vencimiento.ForeColor = Color.White
        tarea_vencimiento.Location = New Point(150, 11)
        tarea_vencimiento.Name = "Vencimiento_" & id
        tarea_vencimiento.Size = New Size(80, 25)
        tarea_vencimiento.TabIndex = 1
        tarea_vencimiento.Text = Notif
        tarea_vencimiento.Visible = False

        reentregar_tarea.Cursor = Cursors.Hand
        reentregar_tarea.FlatStyle = FlatStyle.Flat
        reentregar_tarea.Font = New Font("Segoe UI", 9.0!, FontStyle.Regular, GraphicsUnit.Point)
        reentregar_tarea.ForeColor = Color.White
        reentregar_tarea.Location = New Point(337, 29)
        reentregar_tarea.Name = "BtnRentrega_" & id
        reentregar_tarea.Size = New Size(34, 30)
        reentregar_tarea.TabIndex = 1
        reentregar_tarea.Text = "Rt"
        reentregar_tarea.TabStop = False
        reentregar_tarea.UseVisualStyleBackColor = True
        reentregar_tarea.Visible = False

        Form4.contenedor_tareas.Controls.Add(panel_tarea)

        AddHandler funcion_tarea.Click, AddressOf Funcion_tarea_Click
        AddHandler aprobar_tarea.Click, AddressOf Aprobar_tarea_Click
        AddHandler desaprobar_tarea.Click, AddressOf Desaprobar_tarea_Click
        AddHandler reentregar_tarea.Click, AddressOf Reentregar_Tarea_Click
        AddHandler eliminar_tarea.Click, AddressOf Eliminar_tarea_Click

    End Sub
    Private Sub Reentregar_Tarea_Click(sender As Object, e As EventArgs)
        Form1.Hide()
        rt = CType(sender, Button).Name.Split("_")(1)
        Form6.txt_nombre_tarea.Visible = False
        Form6.txt_decorador.Visible = False
        Form6.box_nombre_tarea.Visible = False
        Form6.opc_categoria_adc.Text = "Trabajo Practico"
        Form6.opc_categoria_adc.Visible = False
        Form6.txt_categoria.Visible = False
        Form6.txt_fecha.Location = New Point(257, 161)
        Form6.date_finalizacion.Location = New Point(241, 194)
        Form6.txt_plazo.Location = New Point(266, 253)
        Form6.opc_plazo_fecha.Location = New Point(283, 287)
        Form6.Show()
    End Sub

    Public Sub Ordenar_Tareas(categoria As Integer, modo As Integer, id As Integer)
        Try
            db = New ReMe_DB
            db.miComando.CommandText = "Ordenar_Tareas"
            db.miComando.CommandType = CommandType.StoredProcedure

            Dim pa1 As New MySqlParameter("n1", MySqlDbType.Int32)
            Dim pa2 As New MySqlParameter("n2", MySqlDbType.Int32)
            Dim pa3 As New MySqlParameter("n3", MySqlDbType.Int32)

            pa1.Direction = ParameterDirection.Input
            pa2.Direction = ParameterDirection.Input
            pa3.Direction = ParameterDirection.Input

            pa1.Value = categoria
            pa2.Value = modo
            pa3.Value = id

            db.miComando.Parameters.Add(pa1)
            db.miComando.Parameters.Add(pa2)
            db.miComando.Parameters.Add(pa3)

            Dim rd As MySqlDataReader = db.miComando.ExecuteReader
            Dim idTarea As Integer
            Dim nombreTarea As String
            Dim finalizaTarea As DateTime
            Dim notifTarea As DateTime
            Dim aprobadaTarea As DateTime

            If categoria = 1 Then
                Form2.contenedor_tareas.Controls.Clear()
            ElseIf categoria = 2 Then
                Form3.contenedor_tareas.Controls.Clear()
            ElseIf categoria = 3 Then
                Form4.contenedor_tareas.Controls.Clear()
            ElseIf categoria = 4 Then
                Form5.contenedor_tareas.Controls.Clear()
            End If

            Dim cantidad As Integer = 0
            If rd.HasRows Then
                While rd.Read()
                    If categoria = 1 Then
                        idTarea = rd.GetInt32(0)
                        nombreTarea = rd.GetString(1)
                        finalizaTarea = rd.GetDateTime(2)
                        notifTarea = rd.GetDateTime(3)
                        Generar_Globales(idTarea, nombreTarea, finalizaTarea.Date, notifTarea.Date)
                        cantidad += 1
                        Form2.Cantidad.Text = "Cantidad: " & cantidad
                    ElseIf categoria = 2 Then
                        idTarea = rd.GetInt32(0)
                        nombreTarea = rd.GetString(1)
                        finalizaTarea = rd.GetDateTime(2)
                        notifTarea = rd.GetDateTime(3)
                        Generar_Importantes(idTarea, nombreTarea, finalizaTarea.Date, notifTarea.Date)
                        cantidad += 1
                        Form3.Cantidad.Text = "Cantidad: " & cantidad
                    ElseIf categoria = 3 Then
                        idTarea = rd.GetInt32(0)
                        nombreTarea = rd.GetString(1)
                        finalizaTarea = rd.GetDateTime(2)
                        notifTarea = rd.GetDateTime(3)
                        Generar_Olvidadas(idTarea, nombreTarea, finalizaTarea.Date, notifTarea.Date)
                        cantidad += 1
                        Form4.Cantidad.Text = "Cantidad: " & cantidad
                    ElseIf categoria = 4 Then
                        idTarea = rd.GetInt32(0)
                        nombreTarea = rd.GetString(1)
                        aprobadaTarea = rd.GetDateTime(2)
                        Generar_Aprobadas(idTarea, nombreTarea, aprobadaTarea.Date)
                        cantidad += 1
                        Form5.Cantidad.Text = "Cantidad: " & cantidad
                    End If
                End While
                rd.NextResult()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Actualizar_Tareas()
        If Form1.Contenedor_tareas.Controls.ContainsKey("Form2") Then
            Form2.Cantidad.Text = "Cantidad: " & Str(Form2.contenedor_tareas.Controls.Count())
        ElseIf Form1.Contenedor_tareas.Controls.ContainsKey("Form3") Then
            Form3.Cantidad.Text = "Cantidad: " & Str(Form3.contenedor_tareas.Controls.Count())
        ElseIf Form1.Contenedor_tareas.Controls.ContainsKey("Form4") Then
            Form4.Cantidad.Text = "Cantidad: " & Str(Form4.contenedor_tareas.Controls.Count())
        ElseIf Form1.Contenedor_tareas.Controls.ContainsKey("Form5") Then
            Form5.Cantidad.Text = "Cantidad: " & Str(Form5.contenedor_tareas.Controls.Count())
        End If
    End Sub

    Public Sub Actualizar_Categoria(id As Integer, idcateg As Integer)
        Try
            db = New ReMe_DB
            db.miComando.CommandText = "Actualizar_Categoria"
            db.miComando.CommandType = CommandType.StoredProcedure
            Dim param1 As New MySqlParameter("n1", MySqlDbType.Int32)
            Dim param2 As New MySqlParameter("n2", MySqlDbType.Int32)
            param1.Direction = ParameterDirection.Input
            param2.Direction = ParameterDirection.Input
            param1.Value = id
            param2.Value = idcateg
            db.miComando.Parameters.Add(param1)
            db.miComando.Parameters.Add(param2)
            db.miComando.ExecuteNonQuery()
            db.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Eliminar_T(id As Integer)
        Try
            db = New ReMe_DB
            db.miComando.CommandText = "Eliminar_Tarea"
            db.miComando.CommandType = CommandType.StoredProcedure
            Dim param1 As New MySqlParameter("n1", MySqlDbType.Int32)
            param1.Direction = ParameterDirection.Input
            param1.Value = id
            db.miComando.Parameters.Add(param1)
            db.miComando.ExecuteNonQuery()
            db.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Actualizar_EstadoNotif(id As Integer)
        Try
            db = New ReMe_DB
            db.miComando.CommandText = "Actualizar_EstadoNotif"
            db.miComando.CommandType = CommandType.StoredProcedure
            Dim param1 As New MySqlParameter("n1", MySqlDbType.Int32)
            param1.Direction = ParameterDirection.Input
            param1.Value = id
            db.miComando.Parameters.Add(param1)
            db.miComando.ExecuteNonQuery()
            db.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Olvidada_Importante(FechaInicio As Date, FechaFinaliza As Date, FechaNotif As Date)
        Try
            db = New ReMe_DB
            db.miComando.CommandText = "Olvidadas_Importantes"
            db.miComando.CommandType = CommandType.StoredProcedure
            Dim param1 As New MySqlParameter("n1", MySqlDbType.Int32)
            Dim param2 As New MySqlParameter("n2", MySqlDbType.Date)
            Dim param3 As New MySqlParameter("n3", MySqlDbType.Date)
            Dim param4 As New MySqlParameter("n4", MySqlDbType.Date)
            param1.Direction = ParameterDirection.Input
            param2.Direction = ParameterDirection.Input
            param3.Direction = ParameterDirection.Input
            param4.Direction = ParameterDirection.Input
            param1.Value = Rt
            param2.Value = FechaInicio
            param3.Value = FechaFinaliza
            param4.Value = FechaNotif
            db.miComando.Parameters.Add(param1)
            db.miComando.Parameters.Add(param2)
            db.miComando.Parameters.Add(param3)
            db.miComando.Parameters.Add(param4)
            db.miComando.ExecuteNonQuery()
            db.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#Enable Warning CA1822 ' Marcar miembros como static
#Enable Warning IDE0017 ' Simplificar la inicialización de objetos
End Class
