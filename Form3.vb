Public Class Form3
    Dim t As Tarea
    Private Sub Opc_ordenar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles opc_ordenar.SelectedIndexChanged
        t = New Tarea()
        If opc_ordenar.Text = "Fecha" Then
            t.Ordenar_Tareas(2, 1, Form1.id_usr)
        ElseIf opc_ordenar.Text = "Nombre (ASC)" Then
            t.Ordenar_Tareas(2, 2, Form1.id_usr)
        Else
            t.Ordenar_Tareas(2, 3, Form1.id_usr)
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Cargar_Importantes()
    End Sub
End Class