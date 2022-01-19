Public Class vEmpleado
    Dim id_empleado As Integer
    Dim Primer_nombre, Segundo_nombre, Primer_apellido, Segundo_apellido, Estado As String
    Dim Fecha_ingreso As Date
    Dim id_cargo As Integer

    Public Sub New(Optional id_empleado As Integer = Nothing, Optional primer_nombre As String = Nothing,
                   Optional segundo_nombre As String = Nothing, Optional primer_apellido As String = Nothing,
                   Optional segundo_apellido As String = Nothing, Optional estado As String = Nothing,
                   Optional fecha_ingreso As Date = Nothing, Optional id_cargo As Integer = Nothing)
        Me.id_empleado = id_empleado
        Me.Primer_nombre = primer_nombre
        Me.Segundo_nombre = segundo_nombre
        Me.Primer_apellido = primer_apellido
        Me.Segundo_apellido = segundo_apellido
        Me.Fecha_ingreso = fecha_ingreso
        Me.id_cargo = id_cargo
        Me.Estado = estado
    End Sub

    Public Property Primer_nombre1 As String
        Get
            Return Primer_nombre
        End Get
        Set(value As String)
            Primer_nombre = value
        End Set
    End Property

    Public Property Segundo_nombre1 As String
        Get
            Return Segundo_nombre
        End Get
        Set(value As String)
            Segundo_nombre = value
        End Set
    End Property

    Public Property Primer_apellido1 As String
        Get
            Return Primer_apellido
        End Get
        Set(value As String)
            Primer_apellido = value
        End Set
    End Property

    Public Property Segundo_apellido1 As String
        Get
            Return Segundo_apellido
        End Get
        Set(value As String)
            Segundo_apellido = value
        End Set
    End Property

    Public Property Estado1 As String
        Get
            Return Estado
        End Get
        Set(value As String)
            Estado = value
        End Set
    End Property

    Public Property Fecha_ingreso1 As Date
        Get
            Return Fecha_ingreso
        End Get
        Set(value As Date)
            Fecha_ingreso = value
        End Set
    End Property

    Public Property Id_cargo1 As Integer
        Get
            Return id_cargo
        End Get
        Set(value As Integer)
            id_cargo = value
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
End Class
