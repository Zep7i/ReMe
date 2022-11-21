Public Class Usuario
    Inherits Persona
    Private Email As String
    Public Sub New(usr As String, clv As String, email As String)
        MyBase.New(usr, clv)
        Me.Email = email
    End Sub

    Public ReadOnly Property Mail As String
        Get
            Return Email
        End Get
    End Property
End Class
