Imports MySql.Data.MySqlClient
Public Class AdminForm
    Dim adm As Admin
    Dim db As ReMe_DB
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
        LoginForm.LimpiarLogin()
        Form1.CerrarSesion()
    End Sub

    Private Sub Btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            db = New ReMe_DB
            db.miComando.CommandText = "Login"
            db.miComando.CommandType = CommandType.StoredProcedure
            Dim pa1 As New MySqlParameter("n1", MySqlDbType.VarChar)
            Dim pa2 As New MySqlParameter("n2", MySqlDbType.VarChar)
            pa1.Direction = ParameterDirection.Input
            pa2.Direction = ParameterDirection.Input
            pa1.Value = LoginForm.box_usuario.Text
            pa2.Value = LoginForm.box_clave.Text
            db.miComando.Parameters.Add(pa1)
            db.miComando.Parameters.Add(pa2)
            Dim rd As MySqlDataReader = db.miComando.ExecuteReader
            Dim email As String = ""
            If rd.HasRows Then
                While rd.Read()
                    adm = New Admin(LoginForm.box_usuario.Text, LoginForm.box_clave.Text)
                    adm.ObtenerReporte()
                    registrados.Text = adm.Reg
                End While
                rd.NextResult()
            Else
                contenedor_reportes.Visible = False
                For Each cntrl As Control In Controls
                    If cntrl.Tag = "header" Then
                        cntrl.Visible = False
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox("Ocurrió un error inesperado :/", vbCritical, "ERROR")
        End Try
        CargarReportes()
    End Sub

    Private Sub CargarReportes()
        Dim c As Integer = 0
        For i = 0 To (adm.nombres.Count - 1)
            Dim txt_nombre As New Label With {
                .FlatStyle = FlatStyle.Flat,
                .Font = New Font("Microsoft Sans Serif", 15.0!),
                .Location = New Point(3, 0),
                .Name = "Nombre_" & c,
                .Padding = New Padding(41, 5, 41, 5),
                .Size = New Size(167, 38),
                .Text = adm.nombres(i)
            }
            contenedor_reportes.Controls.Add(txt_nombre)
            Dim txt_aprobada As New Label With {
            .FlatStyle = FlatStyle.Flat,
            .Font = New Font("Microsoft Sans Serif", 15.0!),
            .Location = New Point(155, 0),
            .Name = "Aprobada_" & c,
            .Padding = New Padding(25, 5, 25, 5),
            .Size = New Size(87, 38),
            .Text = adm.aprobadas(i)
            }
            contenedor_reportes.Controls.Add(txt_aprobada)
            Dim txt_desaprobada As New Label With {
            .FlatStyle = FlatStyle.Flat,
            .Font = New Font("Microsoft Sans Serif", 15.0!),
            .Location = New Point(155, 0),
            .Name = "Desaprobada_" & c,
            .Padding = New Padding(25, 5, 25, 5),
            .Size = New Size(88, 38),
            .Text = adm.desaprobadas(i)
            }
            contenedor_reportes.Controls.Add(txt_desaprobada)
            Dim txt_importante As New Label With {
            .FlatStyle = FlatStyle.Flat,
            .Font = New Font("Microsoft Sans Serif", 15.0!),
            .Location = New Point(155, 0),
            .Name = "Importante_" & c,
            .Padding = New Padding(25, 5, 25, 5),
            .Size = New Size(96, 38),
            .Text = adm.importantes(i)
            }
            contenedor_reportes.Controls.Add(txt_importante)
            Dim txt_olvidada As New Label With {
            .FlatStyle = FlatStyle.Flat,
            .Font = New Font("Microsoft Sans Serif", 15.0!),
            .Location = New Point(155, 0),
            .Name = "Olvidada_" & c,
            .Padding = New Padding(25, 5, 25, 5),
            .Size = New Size(92, 38),
            .Text = adm.olvidadas(i)
            }
            contenedor_reportes.Controls.Add(txt_olvidada)
            Dim txt_global As New Label With {
            .FlatStyle = FlatStyle.Flat,
            .Font = New Font("Microsoft Sans Serif", 15.0!),
            .Location = New Point(155, 0),
            .Name = "Global_" & c,
            .Padding = New Padding(25, 5, 25, 5),
            .Size = New Size(93, 38),
            .Text = adm.globales(i)
            }
            contenedor_reportes.Controls.Add(txt_global)
            c += 1
        Next
    End Sub
End Class