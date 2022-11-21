Imports MySql.Data.MySqlClient
Public Class AjustesForm
    Dim db As ReMe_DB
    Dim pers As Persona
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
    Private Sub Btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Close()
        Form1.CerrarSesion()
    End Sub
    Private Sub Btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_regresar_ajustes_Click(sender As Object, e As EventArgs) Handles btn_regresar_ajustes.Click
        Close()
        Form1.Show()
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        Dim pw As String = ""
        Try
            db = New ReMe_DB
            db.miComando.CommandText = "Obtener_Clave"
            db.miComando.CommandType = CommandType.StoredProcedure
            Dim pa1 As New MySqlParameter("n1", MySqlDbType.Int32)
            pa1.Direction = ParameterDirection.Input
            pa1.Value = Form1.id_usr
            db.miComando.Parameters.Add(pa1)
            Dim rd As MySqlDataReader = db.miComando.ExecuteReader
            If rd.HasRows Then
                While rd.Read
                    pw = rd.GetValue(0)
                End While
                rd.NextResult()
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error fatal.", vbCritical, "ERROR")
        End Try
        pers = New Persona(Form1.txt_usuario.Text, pw)
        If txt_nombre_usuario.Text = "Nuevo nombre de usuario" Then
            pers.CambiarNombre(box_usuario_nuevo.Text, Form1.id_usr)
        Else
            pers.CambiarClave(box_usuario_nuevo.Text, box_contraseña.Text, Form1.id_usr)
        End If
    End Sub

    Private Sub btn_cambiar_contraseña_Click(sender As Object, e As EventArgs) Handles btn_cambiar_contraseña.Click
        Limpiar()
        btn_cambiar_usuario.BackColor = Color.FromArgb(68, 70, 90)
        btn_cambiar_contraseña.BackColor = Color.FromArgb(81, 84, 108)
        txt_nombre_usuario.Text = "Contraseña actual"
        txt_nombre_usuario.Location = New Point(363, 152)
        txt_contraseña.Text = "Nueva contraseña"
        txt_contraseña.Location = New Point(349, 221)

        box_usuario_nuevo.MaxLength = 12
        box_usuario_nuevo.PasswordChar = "●"
        box_contraseña.MaxLength = 12
        box_contraseña.PasswordChar = "●"
    End Sub

    Private Sub btn_cambiar_usuario_Click(sender As Object, e As EventArgs) Handles btn_cambiar_usuario.Click
        Limpiar()
        btn_cambiar_usuario.BackColor = Color.FromArgb(81, 84, 108)
        btn_cambiar_contraseña.BackColor = Color.FromArgb(68, 70, 90)
        txt_nombre_usuario.Text = "Nuevo nombre de usuario"
        txt_nombre_usuario.Location = New Point(336, 152)
        txt_contraseña.Text = "Contraseña"
        txt_contraseña.Location = New Point(375, 221)

        box_usuario_nuevo.MaxLength = 15
        box_usuario_nuevo.PasswordChar = ""
        box_contraseña.MaxLength = 12
        box_contraseña.PasswordChar = "●"
    End Sub

    Private Sub AjustesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_cambiar_usuario.BackColor = Color.FromArgb(81, 84, 108)
        btn_cambiar_contraseña.BackColor = Color.FromArgb(68, 70, 90)
    End Sub

    Private Sub Limpiar()
        box_usuario_nuevo.Text = ""
        box_contraseña.Text = ""
        txt_error_ajustes.Visible = False
    End Sub
End Class