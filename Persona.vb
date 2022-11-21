Imports MySql.Data.MySqlClient
Public Class Persona
    Dim db As ReMe_DB
    Private Nombre As String
    Private Clave As String

    Public Sub New(usr As String, clv As String)
        Nombre = usr
        Clave = clv
    End Sub

    Public Property Usr As String
        Get
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property

    Public Property Clv As String
        Get
            Return Clave
        End Get
        Set(value As String)
            Clave = value
        End Set
    End Property

    Public Event Load(sender As Object, e As EventArgs)

    Public Sub CambiarNombre(nombre As String, id As Integer)
        Try
            db = New ReMe_DB
            db.miComando.CommandText = "Verificar_Nombre"
            db.miComando.CommandType = CommandType.StoredProcedure
            Dim pa1 As New MySqlParameter("n1", MySqlDbType.VarChar)
            pa1.Direction = ParameterDirection.Input
            pa1.Value = nombre
            db.miComando.Parameters.Add(pa1)
            Dim rd As MySqlDataReader = db.miComando.ExecuteReader
            If rd.HasRows Then
                While rd.Read
                    If rd.GetValue(0).ToString = "correcto" And AjustesForm.box_contraseña.Text = Clv Then
                        Try
                            db = New ReMe_DB
                            db.miComando.CommandText = "Cambiar_Nombre"
                            db.miComando.CommandType = CommandType.StoredProcedure
                            Dim p1 As New MySqlParameter("n1", MySqlDbType.VarChar)
                            Dim p2 As New MySqlParameter("n2", MySqlDbType.Int32)
                            p1.Direction = ParameterDirection.Input
                            p2.Direction = ParameterDirection.Input
                            p1.Value = nombre
                            p2.Value = id
                            db.miComando.Parameters.Add(p1)
                            db.miComando.Parameters.Add(p2)
                            db.miComando.ExecuteNonQuery()
                            db.Dispose()

                            AjustesForm.txt_error_ajustes.Location = New Point(321, 289)
                            AjustesForm.txt_error_ajustes.Text = "* Nombre cambiado exitosamente"
                            AjustesForm.txt_error_ajustes.Visible = True
                        Catch ex As Exception
                            AjustesForm.txt_error_ajustes.Location = New Point(370, 289)
                            AjustesForm.txt_error_ajustes.Text = "* Algo salió mal :/"
                            AjustesForm.txt_error_ajustes.Visible = True
                        End Try
                    Else
                        AjustesForm.txt_error_ajustes.Location = New Point(331, 289)
                        AjustesForm.txt_error_ajustes.Text = "* No fué posible realizar el cambio"
                        AjustesForm.txt_error_ajustes.Visible = True
                    End If
                End While
                rd.NextResult()
            End If
        Catch ex As Exception
            AjustesForm.txt_error_ajustes.Location = New Point(370, 289)
            AjustesForm.txt_error_ajustes.Text = "* Algo salió mal :/"
            AjustesForm.txt_error_ajustes.Visible = True
        End Try
    End Sub

    Public Sub CambiarClave(clave_a As String, clave_n As String, id As Integer)
        Try
            db = New ReMe_DB
            db.miComando.CommandText = "Verificar_Clave"
            db.miComando.CommandType = CommandType.StoredProcedure
            Dim p1 As New MySqlParameter("n1", MySqlDbType.VarChar)
            Dim p2 As New MySqlParameter("n2", MySqlDbType.Int32)
            p1.Direction = ParameterDirection.Input
            p2.Direction = ParameterDirection.Input
            p1.Value = clave_a
            p2.Value = id
            db.miComando.Parameters.Add(p1)
            db.miComando.Parameters.Add(p2)
            Dim rd As MySqlDataReader = db.miComando.ExecuteReader
            If rd.HasRows Then
                While rd.Read
                    If rd.GetValue(0).ToString = "correcto" Then
                        Try
                            db = New ReMe_DB
                            db.miComando.CommandText = "Cambiar_Clave"
                            db.miComando.CommandType = CommandType.StoredProcedure
                            Dim pa1 As New MySqlParameter("n1", MySqlDbType.VarChar)
                            Dim pa2 As New MySqlParameter("n2", MySqlDbType.Int32)
                            pa1.Direction = ParameterDirection.Input
                            pa2.Direction = ParameterDirection.Input
                            pa1.Value = clave_n
                            pa2.Value = id
                            db.miComando.Parameters.Add(pa1)
                            db.miComando.Parameters.Add(pa2)
                            db.miComando.ExecuteNonQuery()
                            db.Dispose()

                            AjustesForm.txt_error_ajustes.Location = New Point(328, 289)
                            AjustesForm.txt_error_ajustes.Text = "* Clave cambiada exitosamente"
                            AjustesForm.txt_error_ajustes.Visible = True
                        Catch ex As Exception
                            AjustesForm.txt_error_ajustes.Location = New Point(370, 289)
                            AjustesForm.txt_error_ajustes.Text = "* Algo salió mal :/"
                            AjustesForm.txt_error_ajustes.Visible = True
                        End Try
                    Else
                        AjustesForm.txt_error_ajustes.Location = New Point(331, 289)
                        AjustesForm.txt_error_ajustes.Text = "* No fué posible realizar el cambio"
                        AjustesForm.txt_error_ajustes.Visible = True
                    End If
                End While
                rd.NextResult()
            End If
        Catch ex As Exception
            AjustesForm.txt_error_ajustes.Location = New Point(370, 289)
            AjustesForm.txt_error_ajustes.Text = "* Algo salió mal :/"
            AjustesForm.txt_error_ajustes.Visible = True
        End Try
    End Sub
End Class
