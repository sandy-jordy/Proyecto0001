Public Class vAsistencia
    Dim id_asistencia, id_empleado, id_concepto As Integer
    Dim Fecha_asistencia As Date
    Public Sub New()

    End Sub
    Public Sub New(Optional id_asistencia As Integer = Nothing, Optional id_empleado As Integer = Nothing,
                   Optional id_concepto As Integer = Nothing, Optional fecha_asistencia As Date = Nothing)
        Me.id_asistencia = id_asistencia
        Me.id_empleado = id_empleado
        Me.id_concepto = id_concepto
        Me.Fecha_asistencia = fecha_asistencia
    End Sub

    Public Property Id_asistencia1 As Integer
        Get
            Return id_asistencia
        End Get
        Set(value As Integer)
            id_asistencia = value
        End Set
    End Property

    Public Property Id_empleado1 As Integer
        Get
            Return id_empleado
        End Get
        Set(value As Integer)
            id_empleado = value
        End Set
    End Property

    Public Property Id_concepto1 As Integer
        Get
            Return id_concepto
        End Get
        Set(value As Integer)
            id_concepto = value
        End Set
    End Property

    Public Property Fecha_asistencia1 As Date
        Get
            Return Fecha_asistencia
        End Get
        Set(value As Date)
            Fecha_asistencia = value
        End Set
    End Property
End Class
