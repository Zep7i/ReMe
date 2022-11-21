Imports MySql.Data.MySqlClient
Public Class ReMe_DB
    Private ReadOnly nombreDB As String = "reme"
    Private ReadOnly hostname As String = "127.0.0.1"
    Private ReadOnly UsuarioDB As String = "root"

    Private ReadOnly miConexion As New MySqlConnection
    Public miComando As New MySqlCommand
    Public miDataAdapter As New MySqlDataAdapter
    Public miDataSet As New DataSet
    Public Conexion_Error As String
    Public reader As MySqlDataReader
    Public Sub New()
        Try
            miConexion.ConnectionString = $"server={hostname};database={nombreDB};Uid={UsuarioDB};"
            miConexion.Open()
            miComando.Connection = miConexion
            Conexion_Error = ""
        Catch ex As Exception
            Conexion_Error = ex.Message
            MsgBox("Error en el connection string")
        End Try
    End Sub
    Public ReadOnly Property Database()
        Get
            Return nombreDB
        End Get
    End Property
    Public Sub EjecutarSQL(SentenciaSQL As String)
        miComando.CommandText = SentenciaSQL
        miComando.ExecuteNonQuery()
    End Sub

    Public Sub Dispose()
        miConexion.Close()
        miConexion.Dispose()
        miComando.Dispose()
    End Sub
End Class
