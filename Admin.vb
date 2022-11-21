Imports MySql.Data.MySqlClient
Public Class Admin
    Inherits Persona
    Dim db As ReMe_DB
    Private ReadOnly ids As New List(Of Integer)
    Private Registrados As Integer

    Public nombres As New List(Of String)
    Public aprobadas As New List(Of Integer)
    Public desaprobadas As New List(Of Integer)
    Public importantes As New List(Of Integer)
    Public olvidadas As New List(Of Integer)
    Public globales As New List(Of Integer)

    Public ReadOnly Property Reg As Integer
        Get
            Return Registrados
        End Get
    End Property

    Public Sub New(usr As String, clv As String)
        MyBase.New(usr, clv)
    End Sub

    Public Sub ObtenerReporte()
        Try
            db = New ReMe_DB
            db.miComando.CommandText = "Obtener_Registrados"
            db.miComando.CommandType = CommandType.StoredProcedure
            Dim rd As MySqlDataReader = db.miComando.ExecuteReader
            If rd.HasRows Then
                While rd.Read()
                    Registrados = rd.GetValue(0)
                    ids.Add(Convert.ToInt32(rd.GetValue(1)))
                End While
                rd.NextResult()
            End If
        Catch ex As Exception
            MsgBox("Se ha producido un error inesperado..", vbCritical, "ERROR")
        End Try

        Try
            For Each itm In ids
                db = New ReMe_DB
                db.miComando.CommandText = "Reporte_Global"
                db.miComando.CommandType = CommandType.StoredProcedure
                Dim pa1 As New MySqlParameter("n1", MySqlDbType.Int32)
                pa1.Direction = ParameterDirection.Input
                pa1.Value = itm
                db.miComando.Parameters.Add(pa1)
                Dim rd2 As MySqlDataReader = db.miComando.ExecuteReader
                If rd2.HasRows Then
                    While rd2.Read()
                        nombres.Add(rd2.GetValue(0))
                        aprobadas.Add(Convert.ToInt32(rd2.GetValue(1)))
                        desaprobadas.Add(Convert.ToInt32(rd2.GetValue(2)))
                        importantes.Add(Convert.ToInt32(rd2.GetValue(3)))
                        olvidadas.Add(Convert.ToInt32(rd2.GetValue(4)))
                        globales.Add(Convert.ToInt32(rd2.GetValue(5)))
                    End While
                    rd2.NextResult()
                End If
            Next
        Catch ex As Exception
            MsgBox("Hubo un error al cargar los reportes :/", vbCritical, "ERROR")
        End Try
    End Sub
End Class
