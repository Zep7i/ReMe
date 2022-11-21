Imports MySql.Data.MySqlClient
Public Class Verificacion
    Inherits Persona
    Private Shared Usuario As String
    Private Clave As String
    Private Shared identify As Integer
    Dim db As ReMe_DB
    Dim adm As Admin
    Public Sub New(usr As String, clv As String)
        MyBase.New(usr, clv)
        Usuario = MyBase.Usr
        Clave = MyBase.Clv
    End Sub

    Public ReadOnly Property User As String
        Get
            Return Usuario
        End Get
    End Property

    Public Property Id As Integer
        Get
            Return identify
        End Get
        Set(value As Integer)
            identify = value
        End Set
    End Property

    Public ReadOnly Property Pw As String
        Get
            Return Clave
        End Get
    End Property

    Public Sub VerificarLogin(clv As String)
        Try
            db = New ReMe_DB
            db.miComando.CommandText = "Login"
            db.miComando.CommandType = CommandType.StoredProcedure

            Dim pa1 As New MySqlParameter("n1", MySqlDbType.VarChar)
            Dim pa2 As New MySqlParameter("n2", MySqlDbType.VarChar)

            pa1.Direction = ParameterDirection.Input
            pa2.Direction = ParameterDirection.Input

            pa1.Value = User
            pa2.Value = clv

            db.miComando.Parameters.Add(pa1)
            db.miComando.Parameters.Add(pa2)
            Dim rd As MySqlDataReader = db.miComando.ExecuteReader
            If rd.HasRows Then
                While rd.Read()
                    If rd.GetValue(0).ToString = "correcto" Then
                        LoginForm.Hide()
                        identify = rd.GetValue(1)
                        If rd.GetValue(2).ToString = "1" Then
                            Form1.Show()
                            LoginForm.LimpiarLogin()
                        Else
                            adm = New Admin(User, clv)
                            AdminForm.Show()
                        End If
                    Else
                        ComprobarFormato()
                    End If
                End While
                rd.NextResult()
            End If
            db.Dispose()
        Catch ex As Exception
            LoginForm.txt_error_login.Location = New Point(293, 331)
            LoginForm.txt_error_login.Text = "* Error inesperado :/"
            LoginForm.txt_error_login.Visible = True
        End Try
    End Sub

    Public Overridable Sub ComprobarFormato()
        If LoginForm.box_usuario.Text = "" And LoginForm.box_clave.Text <> "" Then
            LoginForm.txt_error_login.Location = New Point(265, 288)
            LoginForm.txt_error_login.Text = "* Campo de usuario inválido"
            LoginForm.txt_error_login.Visible = True
        ElseIf LoginForm.box_clave.Text = "" And LoginForm.box_usuario.Text <> "" Then
            LoginForm.txt_error_login.Location = New Point(273, 288)
            LoginForm.txt_error_login.Text = "* Campo de clave inválido"
            LoginForm.txt_error_login.Visible = True
        ElseIf LoginForm.box_usuario.Text = "" And LoginForm.box_clave.Text = "" Then
            LoginForm.txt_error_login.Location = New Point(242, 288)
            LoginForm.txt_error_login.Text = "* Campo de usuario y clave inválido"
            LoginForm.txt_error_login.Visible = True
        Else
            LoginForm.txt_error_login.Location = New Point(215, 288)
            LoginForm.txt_error_login.Text = "* Nombre de usuario/contraseña incorecto/s"
            LoginForm.txt_error_login.Visible = True
        End If
    End Sub
End Class
