Public Class Form4
    Dim t As Tarea
    Private Sub Opc_ordenar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles opc_ordenar.SelectedIndexChanged
        t = New Tarea()
        If opc_ordenar.Text = "Fecha" Then
            t.Ordenar_Tareas(3, 1, Form1.id_usr)
        ElseIf opc_ordenar.Text = "Nombre (ASC)" Then
            t.Ordenar_Tareas(3, 2, Form1.id_usr)
        Else
            t.Ordenar_Tareas(3, 3, Form1.id_usr)
        End If
    End Sub
End Class