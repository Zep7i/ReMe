Public Class VerificacionTarea
    Public cadc As Integer = 1
    Private tipo_fecha As String
    Public fecha_notif As DateTime
    Private plazo_seleccionado As String
    Public finalizacion As DateTime
    Public categoria As Integer
    Dim t As Tarea

    Public Property TFecha As String
        Get
            Return tipo_fecha
        End Get
        Set(value As String)
            tipo_fecha = value
        End Set
    End Property

    Public Property Plazo As String
        Get
            Return plazo_seleccionado
        End Get
        Set(value As String)
            plazo_seleccionado = value
        End Set
    End Property

    Public Function ComprobarFormato() As Boolean
        t = New Tarea
        Dim err As Boolean = False
#Disable Warning BC42025 ' Acceso del miembro compartido, el miembro de constante, el miembro de enumeración o el tipo anidado a través de una instancia
        If Form6.box_nombre_tarea.Text = "" And t.Rt = 0 Then
            MsgBox("El nombre de la tarea es obligatoria")
            err = True
        End If
        If Form6.opc_categoria_adc.Text = "Categoria" And t.Rt = 0 Then
            ' Establecer categoria adc por defecto en "Tarea"
            MsgBox("La categoria adicional de la tarea es obligatoria")
            err = True
        ElseIf Form6.opc_categoria_adc.Text = "Trabajo Practico" Then
            cadc = 2
        End If
        '1 Mes
        '1/2 Año (6 Meses)
        '1 Año
        If err = False Then
            If TFecha = "Normal" Then
                finalizacion = Form6.date_finalizacion.Value.Date
                If cadc = 1 Then
                    fecha_notif = Form6.date_finalizacion.Value.AddDays(-2)
                    categoria = 1
                Else
                    fecha_notif = Form6.date_finalizacion.Value.AddDays(-4)
                    categoria = 2
                End If
            ElseIf TFecha = "Plazo" Then
                If cadc = 1 Then
                    If Plazo = "1 Mes" Then
                        finalizacion = Now().AddMonths(1).Date
                        fecha_notif = finalizacion.AddDays(-7)
                    ElseIf Plazo = "1/2 Año (6 Meses)" Then
                        finalizacion = Now().AddMonths(6).Date
                        fecha_notif = finalizacion.AddMonths(-2)
                    ElseIf Plazo = "1 Año" Then
                        finalizacion = Now().AddYears(1).Date
                        fecha_notif = finalizacion.AddMonths(-3)
                    End If
                    categoria = 1
                Else
                    If Plazo = "1 Mes" Then
                        finalizacion = Now().AddMonths(1).Date
                        fecha_notif = finalizacion.AddDays(-14)
                    ElseIf Plazo = "1/2 Año (6 Meses)" Then
                        finalizacion = Now().AddMonths(6).Date
                        fecha_notif = finalizacion.AddMonths(-3)
                    ElseIf Plazo = "1 Año" Then
                        finalizacion = Now().AddYears(1)
                        fecha_notif = finalizacion.AddMonths(-6)
                    End If
                    categoria = 2
                End If
            End If
        End If

        Return err
    End Function
#Enable Warning BC42025 ' Acceso del miembro compartido, el miembro de constante, el miembro de enumeración o el tipo anidado a través de una instancia
End Class
