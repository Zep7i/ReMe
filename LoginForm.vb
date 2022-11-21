Imports MySql.Data.MySqlClient
Public Class LoginForm
    Public db As ReMe_DB
    Dim verif As Verificacion
    Dim verif_reg As VerificacionReg
    Dim pers As Persona
    Dim usr As Usuario
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

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db = New ReMe_DB()
        db.EjecutarSQL($"USE reme;")
        db.Dispose()
    End Sub
    Private Sub Btn_iniciar_sesion_Click(sender As Object, e As EventArgs) Handles btn_iniciar_sesion.Click
        txt_error_login.Location = New Point(242, 284)
        Dim email As String = ""
        Try
            db = New ReMe_DB
            db.miComando.CommandText = "Obtener_Email"
            db.miComando.CommandType = CommandType.StoredProcedure
            Dim pa1 As New MySqlParameter("n1", MySqlDbType.VarChar)
            Dim pa2 As New MySqlParameter("n2", MySqlDbType.VarChar)
            pa1.Direction = ParameterDirection.Input
            pa2.Direction = ParameterDirection.Input
            pa1.Value = box_usuario.Text
            pa2.Value = box_clave.Text
            db.miComando.Parameters.Add(pa1)
            db.miComando.Parameters.Add(pa2)
            Dim rd As MySqlDataReader = db.miComando.ExecuteReader
            If rd.HasRows Then
                While rd.Read()
                    email = rd.GetValue(0)
                End While
                rd.NextResult()
            End If
        Catch ex As Exception
            txt_error_login.Location = New Point(293, 331)
            txt_error_login.Text = "* Error inesperado :/"
            txt_error_login.Visible = True
        End Try

        Try
            pers = New Persona(box_usuario.Text, box_clave.Text)
            usr = New Usuario(pers.Usr, pers.Clv, email)
            verif = New Verificacion(pers.Usr, pers.Clv)
            verif.VerificarLogin(pers.Clv)
        Catch ex As Exception
            txt_error_login.Location = New Point(293, 331)
            txt_error_login.Text = "* Error inesperado :/"
            txt_error_login.Visible = True
        End Try
    End Sub

    Private Sub Btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Close()
    End Sub

    Private Sub Btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        btn_registrar.Visible = False
        btn_iniciar_sesion.Visible = False
        btn_atras.Visible = True
        btn_registrarse.Visible = True

        titulo.Text = "ReMe -> Registrarse"
        txt_error_login.Visible = False
        txt_email.Visible = True
        box_email.Visible = True
        txt_decorador_email.Visible = True
        opc_mail.Visible = True
        txt_com.Visible = True

        txt_nombre_usuario.Location = New Point(266, 124)
        box_usuario.Location = New Point(239, 162)
        txt_decorador_usuario.Location = New Point(239, 168)

        txt_clave.Location = New Point(299, 214)
        box_clave.Location = New Point(239, 242)
        txt_decorador_clave.Location = New Point(239, 248)

        txt_email.Location = New Point(325, 277)
        box_email.Location = New Point(177, 305)
        txt_decorador_email.Location = New Point(173, 311)
        opc_mail.Location = New Point(370, 305)
        txt_com.Location = New Point(494, 307)

        txt_error_login.Location = New Point(293, 337)
        txt_error_login.Visible = False
    End Sub

    Private Sub Btn_atras_Click(sender As Object, e As EventArgs) Handles btn_atras.Click
        btn_registrar.Visible = True
        btn_iniciar_sesion.Visible = True
        btn_atras.Visible = False
        btn_registrarse.Visible = False
        txt_error_login.Visible = False

        titulo.Text = "ReMe -> Loguearse"
        txt_email.Visible = False
        box_email.Visible = False
        txt_decorador_email.Visible = False
        opc_mail.Visible = False
        txt_com.Visible = False

        txt_nombre_usuario.Location = New Point(266, 129)
        box_usuario.Location = New Point(239, 167)
        txt_decorador_usuario.Location = New Point(239, 173)

        txt_clave.Location = New Point(299, 219)
        box_clave.Location = New Point(239, 247)
        txt_decorador_clave.Location = New Point(239, 253)

        txt_error_login.Location = New Point(242, 284)
    End Sub
    Private Sub Btn_registrarse_Click(sender As Object, e As EventArgs) Handles btn_registrarse.Click
        Dim ver As Boolean = True
        For Each itm In opc_mail.Items
            If itm = opc_mail.Text Then
                ver = False
                Exit For
            End If
        Next
        If ver = True Then
            opc_mail.Text = "gmail"
        End If
        txt_error_login.Location = New Point(293, 337)
        Try
            Dim email As String = $"{box_email.Text & "@" & opc_mail.Text & txt_com.Text}"
            pers = New Persona(box_usuario.Text, box_clave.Text)
            usr = New Usuario(pers.Usr, pers.Clv, email)
            verif_reg = New VerificacionReg(pers.Usr, pers.Clv, email)
            verif_reg.VerificacionRegistro()
        Catch ex As Exception
            txt_error_login.Location = New Point(293, 331)
            txt_error_login.Text = "* Error inesperado :/"
            txt_error_login.Visible = True
        End Try
    End Sub
    Private Sub Box_usuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles box_usuario.KeyPress
        If Not Char.IsLetter(e.KeyChar) _
                     AndAlso Not Char.IsControl(e.KeyChar) _
                     AndAlso Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub Box_clave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles box_clave.KeyPress
        If Not Char.IsLetter(e.KeyChar) _
                     AndAlso Not Char.IsControl(e.KeyChar) _
                     AndAlso Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub Box_email_KeyPress(sender As Object, e As KeyPressEventArgs) Handles box_email.KeyPress
        If Not Char.IsLetter(e.KeyChar) _
                     AndAlso Not Char.IsControl(e.KeyChar) _
                     AndAlso Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Public Sub LimpiarLogin()
        box_usuario.Text = ""
        box_clave.Text = ""
        box_email.Text = ""
        opc_mail.Text = "gmail"

        btn_registrar.Visible = True
        btn_iniciar_sesion.Visible = True
        btn_atras.Visible = False
        btn_registrarse.Visible = False
        txt_error_login.Visible = False

        titulo.Text = "ReMe -> Loguearse"
        txt_email.Visible = False
        box_email.Visible = False
        txt_decorador_email.Visible = False
        opc_mail.Visible = False
        txt_com.Visible = False

        txt_nombre_usuario.Location = New Point(266, 129)
        box_usuario.Location = New Point(239, 167)
        txt_decorador_usuario.Location = New Point(239, 173)

        txt_clave.Location = New Point(299, 219)
        box_clave.Location = New Point(239, 247)
        txt_decorador_clave.Location = New Point(239, 253)

        txt_error_login.Location = New Point(242, 284)
    End Sub
End Class
