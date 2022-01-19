Public Class VP_Registrar_Mascota
    Dim id As Integer
    Dim nombre, raza, sexo, peso, fecha_nacimiento As String

    Public Property gid
        Get
            Return id

        End Get
        Set(value)
            id = value
        End Set
    End Property
    Public Property gnombre
        Get
            Return nombre
        End Get
        Set(value)
            nombre = value
        End Set
    End Property

    Public Property graza
        Get
            Return raza
        End Get
        Set(value)
            raza = value
        End Set
    End Property


    Public Property gsexo
        Get
            Return sexo
        End Get
        Set(value)
            sexo = value
        End Set
    End Property


    Public Property gpeso
        Get
            Return peso
        End Get
        Set(value)
            peso = value
        End Set
    End Property
    Public Property gfecha_nacimiento
        Get
            Return fecha_nacimiento
        End Get
        Set(value)
            fecha_nacimiento = value
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(ByVal id As Integer, ByVal nombre As String, ByVal raza As String, ByVal sexo As String, ByVal peso As String, ByVal fecha_nacimiento As String)
        gnombre = nombre
        graza = raza
        gsexo = sexo
        gpeso = peso
        gfecha_nacimiento = fecha_nacimiento

    End Sub
End Class
