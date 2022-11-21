Imports MySql.Data.MySqlClient
Public Class VerificacionReg
    Inherits Verificacion
    Private Email As String
    Dim db As ReMe_DB
    Dim pers As Persona

    Public Sub New(usr As String, clv As String, email As String)
        MyBase.New(usr, clv)
        Me.Email = email
    End Sub
    Public Sub VerificacionRegistro()
        Try
            db = New ReMe_DB
            db.miComando.CommandText = "Verificar_Registro"
            db.miComando.CommandType = CommandType.StoredProcedure

            Dim pa1 As New MySqlParameter("n1", MySqlDbType.VarChar)
            Dim pa2 As New MySqlParameter("n2", MySqlDbType.VarChar)

            pa1.Direction = ParameterDirection.Input
            pa2.Direction = ParameterDirection.Input

            pa1.Value = Usr
            pa2.Value = Email

            db.miComando.Parameters.Add(pa1)
            db.miComando.Parameters.Add(pa2)
            Dim rd As MySqlDataReader = db.miComando.ExecuteReader
            If rd.HasRows Then
                While rd.Read()
                    If rd.GetValue(0).ToString = "correcto" Then
                        Try
                            db = New ReMe_DB
                            db.miComando.CommandText = "Registro"
                            db.miComando.CommandType = CommandType.StoredProcedure

                            Dim p1 As New MySqlParameter("n1", MySqlDbType.VarChar)
                            Dim p2 As New MySqlParameter("n2", MySqlDbType.VarChar)
                            Dim p3 As New MySqlParameter("n3", MySqlDbType.VarChar)

                            p1.Direction = ParameterDirection.Input
                            p2.Direction = ParameterDirection.Input
                            p3.Direction = ParameterDirection.Input

                            p1.Value = Usr
                            p2.Value = Email
                            p3.Value = Clv

                            db.miComando.Parameters.Add(p1)
                            db.miComando.Parameters.Add(p2)
                            db.miComando.Parameters.Add(p3)

                            Dim rd2 As MySqlDataReader = db.miComando.ExecuteReader
                            If rd2.HasRows Then
                                While rd2.Read()
                                    Id = rd2.GetValue(0)
                                    LoginForm.Hide()
                                    Form1.Show()
                                    LoginForm.LimpiarLogin()
                                End While
                                rd2.NextResult()
                            End If
                            db.Dispose()
                        Catch ex As Exception
                            LoginForm.txt_error_login.Location = New Point(151, 337)
                            LoginForm.txt_error_login.Text = "* No es posible realizar el registro con las credenciales introducidas"
                            LoginForm.txt_error_login.Visible = True
                        End Try
                    ElseIf rd.GetValue(0).ToString = "existente" Then
                        LoginForm.txt_error_login.Location = New Point(151, 337)
                        LoginForm.txt_error_login.Text = "* No es posible realizar el registro con las credenciales introducidas"
                        LoginForm.txt_error_login.Visible = True
                    End If
                End While
                rd.NextResult()
            End If
        Catch ex As Exception
            ComprobarFormato()
        End Try
    End Sub

    Public Overrides Sub ComprobarFormato()
        If LoginForm.box_usuario.Text = "" Then
            LoginForm.txt_error_login.Location = New Point(265, 288)
            LoginForm.txt_error_login.Text = "* Campo de usuario inválido"
            LoginForm.txt_error_login.Visible = True
        ElseIf LoginForm.box_clave.Text = "" Then
            LoginForm.txt_error_login.Location = New Point(273, 288)
            LoginForm.txt_error_login.Text = "* Campo de clave inválido"
            LoginForm.txt_error_login.Visible = True
        ElseIf LoginForm.box_usuario.Text = "" And LoginForm.box_clave.Text = "" Then
            LoginForm.txt_error_login.Location = New Point(242, 288)
            LoginForm.txt_error_login.Text = "* Campo de usuario y clave inválido"
            LoginForm.txt_error_login.Visible = True
        ElseIf LoginForm.txt_email.Text = "" Then
            LoginForm.txt_error_login.Location = New Point(215, 288)
            LoginForm.txt_error_login.Text = "* Campo de email inválido"
            LoginForm.txt_error_login.Visible = True
        End If
    End Sub

End Class
