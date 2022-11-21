Imports MySql.Data.MySqlClient
Public Class Form1
    ' Size original de los forms: 522; 390
    ' Size original del menu: 378; 23
    ' Location original del label Cantidad: 286; 3
    ' 515; 366
    ' Permitir Nombre tareas hasta 20 caracteres
    Dim db As ReMe_DB
    Dim t As Tarea
    Dim v As Verificacion
    Public id_usr As Integer = 0

    Public ids_globales_notif As New List(Of Integer)
    Public ids_globales_venc As New List(Of Integer)
    Public ids_globales_notif_estado As New List(Of Integer)

    Public ids_importantes_notif As New List(Of Integer)
    Public ids_importantes_venc As New List(Of Integer)
    Public ids_importantes_notif_estado As New List(Of Integer)

    Public ids_olvidadas_venc As New List(Of Integer)

    Private Sub Nueva_tarea_Click(sender As Object, e As EventArgs) Handles nueva_tarea.Click
        Hide()
        Form6.Show()
    End Sub
    Private Sub Menu_MouseMove(sender As Object, e As MouseEventArgs) Handles menu.MouseMove
        If e.Button = MouseButtons.Left Then
            Left += e.X - LastPoint.X
            Top += e.Y - LastPoint.Y
        End If
    End Sub
    Dim LastPoint As Point
    Private Sub Menu_MouseDown(sender As Object, e As MouseEventArgs) Handles menu.MouseDown
        LastPoint = New Point(e.X, e.Y)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Focus()
        v = New Verificacion(LoginForm.box_usuario.Text, LoginForm.box_clave.Text)
        t = New Tarea
        txt_usuario.Text = v.Usr
        id_usr = v.Id
        AbrirTareas.BackColor = Color.FromArgb(81, 84, 108)
        Form2.TopLevel = False
        Form2.Show()
        Contenedor_tareas.Controls.Add(Form2)
        If Form2.contenedor_tareas.Controls.Count > 0 Then
            Notif_Globales_Timer.Enabled = True
            Vencimiento_Globales_Timer.Enabled = True
            Consultar_Ids_Globales()
        End If
        Cargar_Importantes()
        If Form3.contenedor_tareas.Controls.Count > 0 Then
            Notif_Importantes_Timer.Enabled = True
            Vencimiento_Importantes_Timer.Enabled = True
            Consultar_Ids_Importantes()
        End If
        Cargar_Olvidadas()
        If Form4.contenedor_tareas.Controls.Count >= 0 Then
            Vencimiento_Olvidadas_Timer.Enabled = True
            Consultar_Ids_Olvidadas()
        End If
    End Sub

    Public Sub Cargar_Aprobadas()
        Try
            db = New ReMe_DB
            db.miComando.CommandText = "Buscar_Aprobadas"
            db.miComando.CommandType = CommandType.StoredProcedure
            Dim pa1 As New MySqlParameter("n1", MySqlDbType.Int32)
            pa1.Direction = ParameterDirection.Input
            pa1.Value = id_usr ' Cambiar a ID de usuario
            db.miComando.Parameters.Add(pa1)
            Dim rd As MySqlDataReader = db.miComando.ExecuteReader
            Dim id As Integer
            Dim nombre As String
            Dim fecha As DateTime
            Dim cantidad As Integer = 0
            If rd.HasRows Then
                While rd.Read()
                    id = rd.GetInt32(0)
                    nombre = rd.GetString(1)
                    fecha = rd.GetDateTime(2)
                    t.Generar_Aprobadas(id, nombre, fecha.Date)
                    cantidad += 1
                End While
                rd.NextResult()
            End If
            Form5.Cantidad.Text = "Cantidad: " & cantidad
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Cargar_Globales()
        Try
            db = New ReMe_DB
            db.miComando.CommandText = "Buscar_Globales"
            db.miComando.CommandType = CommandType.StoredProcedure
            Dim pa1 As New MySqlParameter("n1", MySqlDbType.Int32)
            pa1.Direction = ParameterDirection.Input
            pa1.Value = id_usr ' Cambiar a ID de usuario
            db.miComando.Parameters.Add(pa1)
            Dim rd As MySqlDataReader = db.miComando.ExecuteReader
            Dim id As Integer
            Dim nombre As String
            Dim finalizacion As DateTime
            Dim notif As DateTime
            Dim cantidad As Integer = 0
            If rd.HasRows Then
                While rd.Read()
                    id = rd.GetInt32(0)
                    nombre = rd.GetString(1)
                    finalizacion = rd.GetDateTime(2)
                    notif = rd.GetDateTime(3)
                    t.Generar_Globales(id, nombre, finalizacion.Date, notif.Date)
                    cantidad += 1
                End While
                rd.NextResult()
            End If
            Form2.Cantidad.Text = "Cantidad: " & cantidad
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Cargar_Importantes()
        Try
            db = New ReMe_DB
            db.miComando.CommandText = "Buscar_Importantes"
            db.miComando.CommandType = CommandType.StoredProcedure
            Dim pa1 As New MySqlParameter("n1", MySqlDbType.Int32)
            pa1.Direction = ParameterDirection.Input
            pa1.Value = id_usr ' Cambiar a ID de usuario
            db.miComando.Parameters.Add(pa1)
            Dim rd As MySqlDataReader = db.miComando.ExecuteReader
            Dim id As Integer
            Dim nombre As String
            Dim finalizacion As DateTime
            Dim notif As DateTime
            Dim cantidad As Integer = 0
            If rd.HasRows Then
                While rd.Read()
                    id = rd.GetInt32(0)
                    nombre = rd.GetString(1)
                    finalizacion = rd.GetDateTime(2)
                    notif = rd.GetDateTime(3)
                    t.Generar_Importantes(id, nombre, finalizacion.Date, notif.Date)
                    cantidad += 1
                End While
                rd.NextResult()
            End If
            Form3.Cantidad.Text = "Cantidad: " & cantidad
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Consultar_Ids_Globales()
        Try
            db = New ReMe_DB
            db.miComando.CommandText = "Buscar_Globales"
            db.miComando.CommandType = CommandType.StoredProcedure
            Dim pa1 As New MySqlParameter("n1", MySqlDbType.Int32)
            pa1.Direction = ParameterDirection.Input
            pa1.Value = id_usr ' Cambiar a ID de usuario
            db.miComando.Parameters.Add(pa1)
            Dim rd As MySqlDataReader = db.miComando.ExecuteReader
            Dim id As Integer
            Dim estado_notif As Integer
            If rd.HasRows Then
                While rd.Read()
                    id = rd.GetInt32(0)
                    estado_notif = rd.GetInt32(4)
                    ids_globales_notif.Add(id)
                    ids_globales_notif_estado.Add(estado_notif)
                    ids_globales_venc.Add(id)
                End While
                rd.NextResult()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Consultar_Ids_Importantes()
        Try
            db = New ReMe_DB
            db.miComando.CommandText = "Buscar_Importantes"
            db.miComando.CommandType = CommandType.StoredProcedure
            Dim pa1 As New MySqlParameter("n1", MySqlDbType.Int32)
            pa1.Direction = ParameterDirection.Input
            pa1.Value = id_usr ' Cambiar a ID de usuario
            db.miComando.Parameters.Add(pa1)
            Dim rd As MySqlDataReader = db.miComando.ExecuteReader
            Dim id As Integer
            Dim estado_notif As Integer
            If rd.HasRows Then
                While rd.Read()
                    id = rd.GetInt32(0)
                    estado_notif = rd.GetInt32(4)
                    ids_importantes_notif.Add(id)
                    ids_importantes_notif_estado.Add(estado_notif)
                    ids_importantes_venc.Add(id)
                End While
                rd.NextResult()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Consultar_Ids_Olvidadas()
        Try
            db = New ReMe_DB
            db.miComando.CommandText = "Buscar_Olvidadas"
            db.miComando.CommandType = CommandType.StoredProcedure
            Dim pa1 As New MySqlParameter("n1", MySqlDbType.Int32)
            pa1.Direction = ParameterDirection.Input
            pa1.Value = id_usr ' Cambiar a ID de usuario
            db.miComando.Parameters.Add(pa1)
            Dim rd As MySqlDataReader = db.miComando.ExecuteReader
            Dim id As Integer
            If rd.HasRows Then
                While rd.Read()
                    id = rd.GetInt32(0)
                    ids_olvidadas_venc.Add(id)
                End While
                rd.NextResult()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Cargar_Olvidadas()
        Try
            db = New ReMe_DB
            db.miComando.CommandText = "Buscar_Olvidadas"
            db.miComando.CommandType = CommandType.StoredProcedure
            Dim pa1 As New MySqlParameter("n1", MySqlDbType.Int32)
            pa1.Direction = ParameterDirection.Input
            pa1.Value = id_usr ' Cambiar a ID de usuario
            db.miComando.Parameters.Add(pa1)
            Dim rd As MySqlDataReader = db.miComando.ExecuteReader
            Dim id As Integer
            Dim nombre As String
            Dim finalizacion As DateTime
            Dim notif As DateTime
            Dim cantidad As Integer = 0
            If rd.HasRows Then
                While rd.Read()
                    id = rd.GetInt32(0)
                    nombre = rd.GetString(1)
                    finalizacion = rd.GetDateTime(2)
                    notif = rd.GetDateTime(3)
                    t.Generar_Olvidadas(id, nombre, finalizacion.Date, notif.Date)
                    cantidad += 1
                End While
                rd.NextResult()
            End If
            Form4.Cantidad.Text = "Cantidad: " & cantidad
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Btn_ajuste_Click(sender As Object, e As EventArgs)
        Hide()
        AjustesForm.Show()
    End Sub

    Public Sub CerrarSesion()
        Form2.Close()
        Form3.Close()
        Form4.Close()
        Form5.Close()
        Form6.Close()
        AjustesForm.Close()
        LoginForm.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_cerrar_sesion.Click
        Close()
        CerrarSesion()
    End Sub
    Private Sub Abrir_Aprobadas_Click(sender As Object, e As EventArgs) Handles Abrir_Aprobadas.Click
        Abrir_Aprobadas.BackColor = Color.FromArgb(81, 84, 108)
        AbrirTareas.BackColor = Color.FromArgb(68, 70, 90)
        Abrir_Importantes.BackColor = Color.FromArgb(68, 70, 90)
        Abrir_Olvidadas.BackColor = Color.FromArgb(68, 70, 90)
        Form5.TopLevel = False
        Form5.Show()
        Contenedor_tareas.Controls.Clear()
        Form5.contenedor_tareas.Controls.Clear()
        Form5.opc_ordenar.Text = "Ordenar por..."
        Cargar_Aprobadas()
        Contenedor_tareas.Controls.Add(Form5)
    End Sub
    Private Sub Abrir_Olvidadas_Click(sender As Object, e As EventArgs) Handles Abrir_Olvidadas.Click
        Abrir_Olvidadas.BackColor = Color.FromArgb(81, 84, 108)
        AbrirTareas.BackColor = Color.FromArgb(68, 70, 90)
        Abrir_Aprobadas.BackColor = Color.FromArgb(68, 70, 90)
        Abrir_Importantes.BackColor = Color.FromArgb(68, 70, 90)
        Form4.TopLevel = False
        Form4.Show()
        Contenedor_tareas.Controls.Clear()
        Form4.contenedor_tareas.Controls.Clear()
        Form4.opc_ordenar.Text = "Ordenar por..."
        Cargar_Olvidadas()
        Contenedor_tareas.Controls.Add(Form4)
    End Sub
    Private Sub Abrir_Importantes_Click(sender As Object, e As EventArgs) Handles Abrir_Importantes.Click
        Abrir_Importantes.BackColor = Color.FromArgb(81, 84, 108)
        AbrirTareas.BackColor = Color.FromArgb(68, 70, 90)
        Abrir_Aprobadas.BackColor = Color.FromArgb(68, 70, 90)
        Abrir_Olvidadas.BackColor = Color.FromArgb(68, 70, 90)
        Form3.TopLevel = False
        Form3.Show()
        Contenedor_tareas.Controls.Clear()
        Form3.contenedor_tareas.Controls.Clear()
        Form3.opc_ordenar.Text = "Ordenar por..."
        Cargar_Importantes()
        Contenedor_tareas.Controls.Add(Form3)
    End Sub
    Private Sub AbrirTareas_Click(sender As Object, e As EventArgs) Handles AbrirTareas.Click
        AbrirTareas.BackColor = Color.FromArgb(81, 84, 108)
        Abrir_Aprobadas.BackColor = Color.FromArgb(68, 70, 90)
        Abrir_Olvidadas.BackColor = Color.FromArgb(68, 70, 90)
        Abrir_Importantes.BackColor = Color.FromArgb(68, 70, 90)
        Form2.TopLevel = False
        Form2.Show()
        Contenedor_tareas.Controls.Clear()
        Form2.contenedor_tareas.Controls.Clear()
        Form2.opc_ordenar.Text = "Ordenar por..."
        Cargar_Globales()
        Contenedor_tareas.Controls.Add(Form2)
    End Sub

    Private Sub Eliminar_tarea_Click(sender As Object, e As EventArgs) Handles eliminar_tareas.Click
        If Contenedor_tareas.Controls.ContainsKey("Form2") Then
            For Each cntrl As Control In Form2.contenedor_tareas.Controls
                Dim d As Button = Form2.contenedor_tareas.Controls.Find("BtnDesaprobado_" & cntrl.Name.Split("_")(1), True)(0)
                Dim a As Button = Form2.contenedor_tareas.Controls.Find("BtnAprobado_" & cntrl.Name.Split("_")(1), True)(0)
                Dim f As PictureBox = Form2.contenedor_tareas.Controls.Find("BtnFunciones_" & cntrl.Name.Split("_")(1), True)(0)
                Dim del As PictureBox = Form2.contenedor_tareas.Controls.Find("BtnEliminar_" & cntrl.Name.Split("_")(1), True)(0)
                If del.Visible = True Then
                    del.Visible = False
                Else
                    d.Visible = False
                    a.Visible = False
                    f.Image = My.Resources.Resource1.plus_img
                    del.Visible = True
                End If
            Next
        ElseIf Contenedor_tareas.Controls.ContainsKey("Form3") Then
            For Each cntrl As Control In Form3.contenedor_tareas.Controls
                Dim d As Button = Form3.contenedor_tareas.Controls.Find("BtnDesaprobado_" & cntrl.Name.Split("_")(1), True)(0)
                Dim a As Button = Form3.contenedor_tareas.Controls.Find("BtnAprobado_" & cntrl.Name.Split("_")(1), True)(0)
                Dim f As PictureBox = Form3.contenedor_tareas.Controls.Find("BtnFunciones_" & cntrl.Name.Split("_")(1), True)(0)
                Dim del As PictureBox = Form3.contenedor_tareas.Controls.Find("BtnEliminar_" & cntrl.Name.Split("_")(1), True)(0)
                If del.Visible = True Then
                    del.Visible = False
                Else
                    d.Visible = False
                    a.Visible = False
                    f.Image = My.Resources.Resource1.plus_img
                    del.Visible = True
                End If
            Next
        ElseIf Contenedor_tareas.Controls.ContainsKey("Form4") Then
            For Each cntrl As Control In Form4.contenedor_tareas.Controls
                Dim d As Button = Form4.contenedor_tareas.Controls.Find("BtnDesaprobado_" & cntrl.Name.Split("_")(1), True)(0)
                Dim a As Button = Form4.contenedor_tareas.Controls.Find("BtnAprobado_" & cntrl.Name.Split("_")(1), True)(0)
                Dim f As PictureBox = Form4.contenedor_tareas.Controls.Find("BtnFunciones_" & cntrl.Name.Split("_")(1), True)(0)
                Dim r As Button = Form4.contenedor_tareas.Controls.Find("BtnRentrega_" & cntrl.Name.Split("_")(1), True)(0)
                Dim del As PictureBox = Form4.contenedor_tareas.Controls.Find("BtnEliminar_" & cntrl.Name.Split("_")(1), True)(0)
                If del.Visible = True Then
                    del.Visible = False
                Else
                    d.Visible = False
                    a.Visible = False
                    r.Visible = False
                    f.Image = My.Resources.Resource1.plus_img
                    del.Visible = True
                End If
            Next
        ElseIf Contenedor_tareas.Controls.ContainsKey("Form5") Then
            For Each cntrl As Control In Form5.contenedor_tareas.Controls
                Dim del As PictureBox = Form5.contenedor_tareas.Controls.Find("BtnEliminar_" & cntrl.Name.Split("_")(1), True)(0)
                If del.Visible = True Then
                    del.Visible = False
                Else
                    del.Visible = True
                End If
            Next
        End If
    End Sub

    Private Sub Btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Close()
        CerrarSesion()
    End Sub
    Private Sub Btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Notif_Globales_Timer_Tick(sender As Object, e As EventArgs) Handles Notif_Globales_Timer.Tick
        Dim notif As Label
        Dim remove_list_notif_globales As New List(Of Integer)
        Dim c As Integer

        If ids_globales_notif.Count() > 0 Then
            For Each id In ids_globales_notif
                notif = Form2.contenedor_tareas.Controls.Find("Vencimiento_" & id, True)(0)
                Dim nombre_tarea As Label
                Dim notif_Date As Date
                nombre_tarea = Form2.contenedor_tareas.Controls.Find("NombreTarea_" & id, True)(0)

                ' Notificacion
                Dim cv_nt_text As String = notif.Text
                Dim dia_n As String = ""
                Dim mes_n As String = ""
                Dim año_n As String = ""

                For j = 0 To cv_nt_text.Length - 1
                    If Not cv_nt_text(j) = "/" Then
                        dia_n += cv_nt_text(j)
                    Else
                        Exit For
                    End If
                Next
                cv_nt_text = notif.Text.Split("/")(1)
                For j = 0 To cv_nt_text.Length - 1
                    If Not cv_nt_text(j) = "/" Then
                        mes_n += cv_nt_text(j)
                    End If
                Next
                cv_nt_text = notif.Text.Split("/")(2)
                For j = 0 To cv_nt_text.Length - 1
                    If Not cv_nt_text(j) = "/" Then
                        año_n += cv_nt_text(j)
                    End If
                Next

                Dim dia_Int_n As Integer = Convert.ToInt32(dia_n)
                Dim mes_Int_n As Integer = Convert.ToInt32(mes_n)

                If dia_Int_n < 10 And mes_Int_n < 10 Then
                    notif_Date = Date.ParseExact("0" & dia_n & "/0" & mes_n & "/" & año_n, "dd/MM/yyyy", Globalization.DateTimeFormatInfo.InvariantInfo)
                ElseIf dia_Int_n < 10 And mes_Int_n >= 10 Then
                    notif_Date = Date.ParseExact("0" & notif.Text, "dd/MM/yyyy", Globalization.DateTimeFormatInfo.InvariantInfo)
                ElseIf dia_Int_n >= 10 And mes_Int_n < 10 Then
                    notif_Date = Date.ParseExact(dia_n & "/0" & mes_n & "/" & año_n, "dd/MM/yyyy", Globalization.DateTimeFormatInfo.InvariantInfo)
                Else
                    notif_Date = Date.ParseExact(notif.Text, "dd/MM/yyyy", Globalization.DateTimeFormatInfo.InvariantInfo)
                End If

                If notif_Date.Date = Now().Date And ids_globales_notif_estado(c) = 0 Then
                    Dim Notificaciones_Globales1 As New NotifyIcon With {
                        .Icon = My.Resources.Resource1.notificacion,
                        .Text = "ReMe",
                        .BalloonTipTitle = $"[Globales] No te olvides! La tarea: '{nombre_tarea.Text}'",
                        .BalloonTipText = $"Esta es una notificación previa para que marques como aprobada/desaprobada tu tarea antes del vencimiento",
                        .Visible = True
                    }
                    Notificaciones_Globales1.ShowBalloonTip(5000)
                    remove_list_notif_globales.Add(id)
                    t.Actualizar_EstadoNotif(id)
                ElseIf notif_Date.Date < Now().Date And ids_globales_notif_estado(c) = 0 Then
                    Dim Notificaciones_Globales2 As New NotifyIcon With {
                        .Icon = My.Resources.Resource1.notificacion,
                        .Text = "ReMe",
                        .BalloonTipTitle = $"[Globales] Te notificamos tu tarea: '{nombre_tarea.Text}' pero...",
                        .BalloonTipText = $"Parece que no estabas presente cuando te notificamos." & vbCrLf & "No pasa nada, tu tarea aún puede marcarse como aprobada/desaprobada, no te olvides!",
                        .Visible = True
                    }
                    Notificaciones_Globales2.ShowBalloonTip(5000)
                    remove_list_notif_globales.Add(id)
                    t.Actualizar_EstadoNotif(id)
                End If
                c += 1
            Next
        Else
            'MsgBox("Deshabilitamos el notif globales!")
            Notif_Globales_Timer.Enabled = False
        End If
        If remove_list_notif_globales.Count > 0 Then
            For Each remover In remove_list_notif_globales
                ids_globales_notif.Remove(remover)
                'MsgBox("Se removió la tarea ID: " & remover)
            Next
        End If
    End Sub

    Private Sub Vencimiento_Globales_Timer_Tick(sender As Object, e As EventArgs) Handles Vencimiento_Globales_Timer.Tick
        Dim notif As Label
        Dim remove_list_venc_globales As New List(Of Integer)
        Dim remove_list_notif_globales As New List(Of Integer)

        If ids_globales_venc.Count > 0 Then
            For Each id In ids_globales_venc
                'MsgBox("[Venc] Evaluando ID: " & id)
                Dim notif_Date As Date

                ' Vencimiento
                Dim finaliz_tarea As Label
                Dim finaliz_Date As Date
                finaliz_tarea = Form2.contenedor_tareas.Controls.Find("FechaTarea_" & id, True)(0)
                Dim cv_ft_text As String = finaliz_tarea.Text
                Dim dia As String = ""
                Dim mes As String = ""
                Dim año As String = ""

                For c = 0 To cv_ft_text.Length - 1
                    If Not cv_ft_text(c) = "/" Then
                        dia += cv_ft_text(c)
                    Else
                        Exit For
                    End If
                Next
                cv_ft_text = finaliz_tarea.Text.Split("/")(1)
                For j = 0 To cv_ft_text.Length - 1
                    If Not cv_ft_text(j) = "/" Then
                        mes += cv_ft_text(j)
                    End If
                Next
                cv_ft_text = finaliz_tarea.Text.Split("/")(2)
                For j = 0 To cv_ft_text.Length - 1
                    If Not cv_ft_text(j) = "/" Then
                        año += cv_ft_text(j)
                    End If
                Next

                Dim dia_Int As Integer = Convert.ToInt32(dia)
                Dim mes_Int As Integer = Convert.ToInt32(mes)
                Dim año_Int As Integer = Convert.ToInt32(año)

                If dia_Int < 10 And mes_Int < 10 Then
                    finaliz_Date = Date.ParseExact("0" & dia & "/0" & mes & "/" & año, "dd/MM/yyyy", Globalization.DateTimeFormatInfo.InvariantInfo)
                ElseIf dia_Int < 10 And mes_Int >= 10 Then
                    finaliz_Date = Date.ParseExact("0" & finaliz_tarea.Text, "dd/MM/yyyy", Globalization.DateTimeFormatInfo.InvariantInfo)
                ElseIf dia_Int >= 10 And mes_Int < 10 Then
                    finaliz_Date = Date.ParseExact(dia & "/0" & mes & "/" & año, "dd/MM/yyyy", Globalization.DateTimeFormatInfo.InvariantInfo)
                Else
                    finaliz_Date = Date.ParseExact(finaliz_tarea.Text, "dd/MM/yyyy", Globalization.DateTimeFormatInfo.InvariantInfo)
                End If

                ' Notificaciones
                notif = Form2.contenedor_tareas.Controls.Find("Vencimiento_" & id, True)(0)
                Dim cv_nt_text As String = notif.Text
                Dim dia_n As String = ""
                Dim mes_n As String = ""
                Dim año_n As String = ""

                For j = 0 To cv_nt_text.Length - 1
                    If Not cv_nt_text(j) = "/" Then
                        dia_n += cv_nt_text(j)
                    Else
                        Exit For
                    End If
                Next
                cv_nt_text = notif.Text.Split("/")(1)
                For j = 0 To cv_nt_text.Length - 1
                    If Not cv_nt_text(j) = "/" Then
                        mes_n += cv_nt_text(j)
                    End If
                Next
                cv_nt_text = notif.Text.Split("/")(2)
                For j = 0 To cv_nt_text.Length - 1
                    If Not cv_nt_text(j) = "/" Then
                        año_n += cv_nt_text(j)
                    End If
                Next

                Dim dia_Int_n As Integer = Convert.ToInt32(dia_n)
                Dim mes_Int_n As Integer = Convert.ToInt32(mes_n)

                If dia_Int_n < 10 And mes_Int_n < 10 Then
                    notif_Date = Date.ParseExact("0" & dia_n & "/0" & mes_n & "/" & año_n, "dd/MM/yyyy", Globalization.DateTimeFormatInfo.InvariantInfo)
                ElseIf dia_Int_n < 10 And mes_Int_n >= 10 Then
                    notif_Date = Date.ParseExact("0" & notif.Text, "dd/MM/yyyy", Globalization.DateTimeFormatInfo.InvariantInfo)
                ElseIf dia_Int_n >= 10 And mes_Int_n < 10 Then
                    notif_Date = Date.ParseExact(dia_n & "/0" & mes_n & "/" & año_n, "dd/MM/yyyy", Globalization.DateTimeFormatInfo.InvariantInfo)
                Else
                    notif_Date = Date.ParseExact(notif.Text, "dd/MM/yyyy", Globalization.DateTimeFormatInfo.InvariantInfo)
                End If

                Dim nombre_tarea As Label = Form2.contenedor_tareas.Controls.Find("NombreTarea_" & id, True)(0)

                If finaliz_Date.Date = Now().Date Then
                    Dim Notificaciones_Vencimiento_Globales1 = New NotifyIcon With {
                        .Icon = My.Resources.Resource1.notificacion,
                        .Text = "ReMe",
                        .BalloonTipTitle = $"[Globales] Venció tu tarea '{nombre_tarea.Text}' la cuál fué movida",
                        .BalloonTipText = $"Tu tarea fué movida a la sección 'Olvidadas' para que puedas gestionar una re-entrega de ser necesario.",
                        .Visible = True
                    }
                    Notificaciones_Vencimiento_Globales1.ShowBalloonTip(5000)
                    remove_list_venc_globales.Add(id)
                    remove_list_notif_globales.Add(id)
                    t.Actualizar_EstadoNotif(id)
                    t.Actualizar_Categoria(id, 3)
                    t.Generar_Olvidadas(id, nombre_tarea.Text, finaliz_Date.Date, notif_Date.Date)
                    Form2.contenedor_tareas.Controls.RemoveByKey("Tarea_" & id)
                    t.Actualizar_Tareas()
                ElseIf finaliz_Date.Date < Now().Date Then
                    Dim Notificaciones_Vencimiento_Globales2 = New NotifyIcon With {
                        .Icon = My.Resources.Resource1.notificacion,
                        .Text = "ReMe",
                        .BalloonTipTitle = $"[Globales] Movimos tu tarea '{nombre_tarea.Text}' la cuál expiró",
                        .BalloonTipText = $"Tu tarea fué movida a la sección 'Olvidadas' mientras no estabas para que puedas gestionar una re-entrega de ser necesario.",
                        .Visible = True
                    }
                    Notificaciones_Vencimiento_Globales2.ShowBalloonTip(5000)
                    remove_list_venc_globales.Add(id)
                    remove_list_notif_globales.Add(id)
                    t.Actualizar_EstadoNotif(id)
                    t.Actualizar_Categoria(id, 3)
                    t.Generar_Olvidadas(id, nombre_tarea.Text, finaliz_Date.Date, notif_Date.Date)
                    Form2.contenedor_tareas.Controls.RemoveByKey("Tarea_" & id)
                    t.Actualizar_Tareas()
                End If
            Next
        Else
            'MsgBox("Deshabilitamos el venc globales!")
            Vencimiento_Globales_Timer.Enabled = False
        End If
        If remove_list_venc_globales.Count > 0 Then
            For Each remover In remove_list_venc_globales
                ids_globales_venc.Remove(remover)
                'MsgBox("[Venc] Se removió la tarea ID: " & remover)
            Next
            'MsgBox("Cantidad ids_globales_venc: " & ids_globales_venc.Count)
        End If
        If remove_list_notif_globales.Count > 0 Then
            For Each remover In remove_list_notif_globales
                ids_globales_notif.Remove(remover)
                'MsgBox("[Notif-Venc] Se removió la tarea ID: " & remover)
            Next
            'MsgBox("Cantidad ids_globales_notif: " & ids_globales_notif.Count)
        End If
    End Sub

    Private Sub Notif_Importantes_Timer_Tick(sender As Object, e As EventArgs) Handles Notif_Importantes_Timer.Tick
        Dim notif As Label
        Dim remove_list_notif_importantes As New List(Of Integer)
        Dim c As Integer = 0

        If ids_importantes_notif.Count > 0 Then
            For Each id In ids_importantes_notif
                notif = Form3.contenedor_tareas.Controls.Find("Vencimiento_" & id, True)(0)
                Dim nombre_tarea As Label
                Dim notif_Date As Date
                nombre_tarea = Form3.contenedor_tareas.Controls.Find("NombreTarea_" & id, True)(0)

                ' Notificacion
                Dim cv_nt_text As String = notif.Text
                Dim dia_n As String = ""
                Dim mes_n As String = ""
                Dim año_n As String = ""

                For j = 0 To cv_nt_text.Length - 1
                    If Not cv_nt_text(j) = "/" Then
                        dia_n += cv_nt_text(j)
                    Else
                        Exit For
                    End If
                Next
                cv_nt_text = notif.Text.Split("/")(1)
                For j = 0 To cv_nt_text.Length - 1
                    If Not cv_nt_text(j) = "/" Then
                        mes_n += cv_nt_text(j)
                    End If
                Next
                cv_nt_text = notif.Text.Split("/")(2)
                For j = 0 To cv_nt_text.Length - 1
                    If Not cv_nt_text(j) = "/" Then
                        año_n += cv_nt_text(j)
                    End If
                Next

                Dim dia_Int_n As Integer = Convert.ToInt32(dia_n)
                Dim mes_Int_n As Integer = Convert.ToInt32(mes_n)

                If dia_Int_n < 10 And mes_Int_n < 10 Then
                    notif_Date = Date.ParseExact("0" & dia_n & "/0" & mes_n & "/" & año_n, "dd/MM/yyyy", Globalization.DateTimeFormatInfo.InvariantInfo)
                ElseIf dia_Int_n < 10 And mes_Int_n >= 10 Then
                    notif_Date = Date.ParseExact("0" & notif.Text, "dd/MM/yyyy", Globalization.DateTimeFormatInfo.InvariantInfo)
                ElseIf dia_Int_n >= 10 And mes_Int_n < 10 Then
                    notif_Date = Date.ParseExact(dia_n & "/0" & mes_n & "/" & año_n, "dd/MM/yyyy", Globalization.DateTimeFormatInfo.InvariantInfo)
                Else
                    notif_Date = Date.ParseExact(notif.Text, "dd/MM/yyyy", Globalization.DateTimeFormatInfo.InvariantInfo)
                End If

                If notif_Date.Date = Now().Date And ids_importantes_notif_estado(c) = 0 Then
                    Dim Notificaciones_Importantes1 As New NotifyIcon With {
                        .Icon = My.Resources.Resource1.notificacion,
                        .Text = "ReMe",
                        .BalloonTipTitle = $"[Importante] No te olvides! La tarea: '{nombre_tarea.Text}'",
                        .BalloonTipText = $"Esta es una notificación previa para que marques como aprobada/desaprobada tu tarea antes del vencimiento",
                        .Visible = True
                    }
                    Notificaciones_Importantes1.ShowBalloonTip(5000)
                    remove_list_notif_importantes.Add(id)
                    t.Actualizar_EstadoNotif(id)
                ElseIf notif_Date.Date < Now().Date And ids_importantes_notif_estado(c) = 0 Then
                    Dim Notificaciones_Importantes2 As New NotifyIcon With {
                        .Icon = My.Resources.Resource1.notificacion,
                        .Text = "ReMe",
                        .BalloonTipTitle = $"[Importante] Te notificamos tu tarea: '{nombre_tarea.Text}' pero...",
                        .BalloonTipText = $"Parece que no estabas presente cuando te notificamos." & vbCrLf & "No pasa nada, tu tarea aún puede marcarse como aprobada/desaprobada, no te olvides!",
                        .Visible = True
                    }
                    Notificaciones_Importantes2.ShowBalloonTip(5000)
                    remove_list_notif_importantes.Add(id)
                    t.Actualizar_EstadoNotif(id)
                End If
                c += 1
            Next
        Else
            'MsgBox("Deshabilitamos el notif globales!")
            Notif_Importantes_Timer.Enabled = False
        End If
        If remove_list_notif_importantes.Count > 0 Then
            For Each remover In remove_list_notif_importantes
                ids_importantes_notif.Remove(remover)
                'MsgBox("Se removió la tarea ID: " & remover)
            Next
        End If
    End Sub

    Private Sub Vencimiento_Importantes_Timer_Tick(sender As Object, e As EventArgs) Handles Vencimiento_Importantes_Timer.Tick
        Dim notif As Label
        Dim remove_list_venc_importantes As New List(Of Integer)
        Dim remove_list_notif_importantes As New List(Of Integer)

        If ids_importantes_venc.Count > 0 Then
            For Each id In ids_importantes_venc
                'MsgBox("[Venc] Evaluando ID: " & id)
                Dim finaliz_tarea As Label
                Dim finaliz_Date As Date
                Dim notif_Date As Date
                finaliz_tarea = Form3.contenedor_tareas.Controls.Find("FechaTarea_" & id, True)(0)
                Dim cv_ft_text As String = finaliz_tarea.Text
                Dim dia As String = ""
                Dim mes As String = ""
                Dim año As String = ""

                For c = 0 To cv_ft_text.Length - 1
                    If Not cv_ft_text(c) = "/" Then
                        dia += cv_ft_text(c)
                    Else
                        Exit For
                    End If
                Next
                cv_ft_text = finaliz_tarea.Text.Split("/")(1)
                For j = 0 To cv_ft_text.Length - 1
                    If Not cv_ft_text(j) = "/" Then
                        mes += cv_ft_text(j)
                    End If
                Next
                cv_ft_text = finaliz_tarea.Text.Split("/")(2)
                For j = 0 To cv_ft_text.Length - 1
                    If Not cv_ft_text(j) = "/" Then
                        año += cv_ft_text(j)
                    End If
                Next

                Dim dia_Int As Integer = Convert.ToInt32(dia)
                Dim mes_Int As Integer = Convert.ToInt32(mes)
                Dim año_Int As Integer = Convert.ToInt32(año)

                If dia_Int < 10 And mes_Int < 10 Then
                    finaliz_Date = Date.ParseExact("0" & dia & "/0" & mes & "/" & año, "dd/MM/yyyy", Globalization.DateTimeFormatInfo.InvariantInfo)
                ElseIf dia_Int < 10 And mes_Int >= 10 Then
                    finaliz_Date = Date.ParseExact("0" & finaliz_tarea.Text, "dd/MM/yyyy", Globalization.DateTimeFormatInfo.InvariantInfo)
                ElseIf dia_Int >= 10 And mes_Int < 10 Then
                    finaliz_Date = Date.ParseExact(dia & "/0" & mes & "/" & año, "dd/MM/yyyy", Globalization.DateTimeFormatInfo.InvariantInfo)
                Else
                    finaliz_Date = Date.ParseExact(finaliz_tarea.Text, "dd/MM/yyyy", Globalization.DateTimeFormatInfo.InvariantInfo)
                End If

                ' Notificaciones
                notif = Form3.contenedor_tareas.Controls.Find("Vencimiento_" & id, True)(0)
                Dim cv_nt_text As String = notif.Text
                Dim dia_n As String = ""
                Dim mes_n As String = ""
                Dim año_n As String = ""

                For j = 0 To cv_nt_text.Length - 1
                    If Not cv_nt_text(j) = "/" Then
                        dia_n += cv_nt_text(j)
                    Else
                        Exit For
                    End If
                Next
                cv_nt_text = notif.Text.Split("/")(1)
                For j = 0 To cv_nt_text.Length - 1
                    If Not cv_nt_text(j) = "/" Then
                        mes_n += cv_nt_text(j)
                    End If
                Next
                cv_nt_text = notif.Text.Split("/")(2)
                For j = 0 To cv_nt_text.Length - 1
                    If Not cv_nt_text(j) = "/" Then
                        año_n += cv_nt_text(j)
                    End If
                Next

                Dim dia_Int_n As Integer = Convert.ToInt32(dia_n)
                Dim mes_Int_n As Integer = Convert.ToInt32(mes_n)

                If dia_Int_n < 10 And mes_Int_n < 10 Then
                    notif_Date = Date.ParseExact("0" & dia_n & "/0" & mes_n & "/" & año_n, "dd/MM/yyyy", Globalization.DateTimeFormatInfo.InvariantInfo)
                ElseIf dia_Int_n < 10 And mes_Int_n >= 10 Then
                    notif_Date = Date.ParseExact("0" & notif.Text, "dd/MM/yyyy", Globalization.DateTimeFormatInfo.InvariantInfo)
                ElseIf dia_Int_n >= 10 And mes_Int_n < 10 Then
                    notif_Date = Date.ParseExact(dia_n & "/0" & mes_n & "/" & año_n, "dd/MM/yyyy", Globalization.DateTimeFormatInfo.InvariantInfo)
                Else
                    notif_Date = Date.ParseExact(notif.Text, "dd/MM/yyyy", Globalization.DateTimeFormatInfo.InvariantInfo)
                End If

                Dim nombre_tarea As Label = Form3.contenedor_tareas.Controls.Find("NombreTarea_" & id, True)(0)

                If finaliz_Date.Date = Now().Date Then
                    Dim Notificaciones_Vencimiento_Importantes1 = New NotifyIcon With {
                        .Icon = My.Resources.Resource1.notificacion,
                        .Text = "ReMe",
                        .BalloonTipTitle = $"[Importante] Venció tu tarea '{nombre_tarea.Text}' la cuál fué movida",
                        .BalloonTipText = $"Tu tarea fué movida a la sección 'Olvidadas' para que puedas gestionar una re-entrega de ser necesario.",
                        .Visible = True
                    }
                    Notificaciones_Vencimiento_Importantes1.ShowBalloonTip(5000)
                    remove_list_venc_importantes.Add(id)
                    remove_list_notif_importantes.Add(id)
                    t.Actualizar_EstadoNotif(id)
                    t.Actualizar_Categoria(id, 3)
                    t.Generar_Olvidadas(id, nombre_tarea.Text, finaliz_Date.Date, notif_Date.Date)
                    Form3.contenedor_tareas.Controls.RemoveByKey("Tarea_" & id)
                    t.Actualizar_Tareas()
                ElseIf finaliz_Date.Date < Now().Date Then
                    Dim Notificaciones_Vencimiento_Importantes2 = New NotifyIcon With {
                        .Icon = My.Resources.Resource1.notificacion,
                        .Text = "ReMe",
                        .BalloonTipTitle = $"[Importante] Movimos tu tarea '{nombre_tarea.Text}' la cuál expiró",
                        .BalloonTipText = $"Tu tarea fué movida a la sección 'Olvidadas' mientras no estabas para que puedas gestionar una re-entrega de ser necesario.",
                        .Visible = True
                    }
                    Notificaciones_Vencimiento_Importantes2.ShowBalloonTip(5000)
                    remove_list_venc_importantes.Add(id)
                    remove_list_notif_importantes.Add(id)
                    t.Actualizar_EstadoNotif(id)
                    t.Actualizar_Categoria(id, 3)
                    t.Generar_Olvidadas(id, nombre_tarea.Text, finaliz_Date.Date, notif_Date.Date)
                    Form3.contenedor_tareas.Controls.RemoveByKey("Tarea_" & id)
                    t.Actualizar_Tareas()
                End If
            Next
        Else
            'MsgBox("Deshabilitamos el venc globales!")
            Vencimiento_Importantes_Timer.Enabled = False
        End If
        If remove_list_venc_importantes.Count > 0 Then
            For Each remover In remove_list_venc_importantes
                ids_importantes_venc.Remove(remover)
                'MsgBox("[Venc] Se removió la tarea ID: " & remover)
            Next
            'MsgBox("Cantidad ids_globales_venc: " & ids_globales_venc.Count)
        End If
        If remove_list_notif_importantes.Count > 0 Then
            For Each remover In remove_list_notif_importantes
                ids_importantes_notif.Remove(remover)
                'MsgBox("[Notif-Venc] Se removió la tarea ID: " & remover)
            Next
            'MsgBox("Cantidad ids_globales_notif: " & ids_globales_notif.Count)
        End If
    End Sub

    Private Sub Vencimiento_Olvidadas_Timer_Tick(sender As Object, e As EventArgs) Handles Vencimiento_Olvidadas_Timer.Tick
        Dim finaliz_tarea As Label
        Dim remove_list_venc_olvidadas As New List(Of Integer)

        If ids_olvidadas_venc.Count() > 0 Then
            For Each id In ids_olvidadas_venc
                Dim finaliz_Date As Date
                finaliz_tarea = Form4.contenedor_tareas.Controls.Find("FechaTarea_" & id, True)(0)
                Dim cv_ft_text As String = finaliz_tarea.Text
                Dim dia As String = ""
                Dim mes As String = ""
                Dim año As String = ""

                For c = 0 To cv_ft_text.Length - 1
                    If Not cv_ft_text(c) = "/" Then
                        dia += cv_ft_text(c)
                    Else
                        Exit For
                    End If
                Next
                cv_ft_text = finaliz_tarea.Text.Split("/")(1)
                For j = 0 To cv_ft_text.Length - 1
                    If Not cv_ft_text(j) = "/" Then
                        mes += cv_ft_text(j)
                    End If
                Next
                cv_ft_text = finaliz_tarea.Text.Split("/")(2)
                For j = 0 To cv_ft_text.Length - 1
                    If Not cv_ft_text(j) = "/" Then
                        año += cv_ft_text(j)
                    End If
                Next

                Dim dia_Int As Integer = Convert.ToInt32(dia)
                Dim mes_Int As Integer = Convert.ToInt32(mes)
                Dim año_Int As Integer = Convert.ToInt32(año)

                If dia_Int < 10 And mes_Int < 10 Then
                    finaliz_Date = Date.ParseExact("0" & dia & "/0" & mes & "/" & año, "dd/MM/yyyy", Globalization.DateTimeFormatInfo.InvariantInfo)
                ElseIf dia_Int < 10 And mes_Int >= 10 Then
                    finaliz_Date = Date.ParseExact("0" & finaliz_tarea.Text, "dd/MM/yyyy", Globalization.DateTimeFormatInfo.InvariantInfo)
                ElseIf dia_Int >= 10 And mes_Int < 10 Then
                    finaliz_Date = Date.ParseExact(dia & "/0" & mes & "/" & año, "dd/MM/yyyy", Globalization.DateTimeFormatInfo.InvariantInfo)
                Else
                    finaliz_Date = Date.ParseExact(finaliz_tarea.Text, "dd/MM/yyyy", Globalization.DateTimeFormatInfo.InvariantInfo)
                End If

                Dim nombre_tarea As Label
                nombre_tarea = Form4.contenedor_tareas.Controls.Find("NombreTarea_" & id, True)(0)
                'MsgBox($"ID {id} se borra el {finaliz_Date.AddDays(7).Date}")
                If finaliz_Date.AddDays(7).Date = Now().Date Then
                    Dim Notificaciones_Vencimiento_Olvidadas1 As New NotifyIcon With {
                        .Icon = My.Resources.Resource1.notificacion,
                        .Text = "ReMe",
                        .BalloonTipTitle = $"[Olvidadas] Borramos tu tarea: '{nombre_tarea.Text}' permanentemente",
                        .BalloonTipText = $"Tu tarea fué eliminada debido a la inactividad en la cuál no clasificaste la tarea durante 1 semana.",
                        .Visible = True
                    }
                    Notificaciones_Vencimiento_Olvidadas1.ShowBalloonTip(5000)
                    remove_list_venc_olvidadas.Add(id)
                    t.Eliminar_T(id)
                    Form4.contenedor_tareas.Controls.RemoveByKey("Tarea_" & id)
                ElseIf finaliz_Date.AddDays(7).Date < Now().Date Then
                    Dim Notificaciones_Vencimiento_Olvidadas2 As New NotifyIcon With {
                        .Icon = My.Resources.Resource1.notificacion,
                        .Text = "ReMe",
                        .BalloonTipTitle = $"[Olvidadas] Borramos tu tarea: '{nombre_tarea.Text}' permanentemente",
                        .BalloonTipText = $"Tu tarea fué eliminada durante no estabas debido a la inactividad en la cuál no clasificaste la tarea durante 1 semana.",
                        .Visible = True
                    }
                    Notificaciones_Vencimiento_Olvidadas2.ShowBalloonTip(5000)
                    remove_list_venc_olvidadas.Add(id)
                    t.Eliminar_T(id)
                    Form4.contenedor_tareas.Controls.RemoveByKey("Tarea_" & id)
                End If
            Next
        Else
            'MsgBox("Deshabilitamos el venc olvidadas!")
            Vencimiento_Olvidadas_Timer.Enabled = False
        End If
        If remove_list_venc_olvidadas.Count > 0 Then
            For Each remover In remove_list_venc_olvidadas
                ids_olvidadas_venc.Remove(remover)
                'MsgBox("Se removió la tarea ID: " & remover)
            Next
        End If
    End Sub

    Private Sub btn_ajustes_Click(sender As Object, e As EventArgs) Handles btn_ajustes.Click
        Hide()
        AjustesForm.Show()
    End Sub
End Class