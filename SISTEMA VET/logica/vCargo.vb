Public Class vCargo

    Dim Nombre_cargo As String
    Dim Id_Cargo As Integer
    Public Property Id_Cargo1 As Integer
        Get
            Return Id_Cargo
        End Get
        Set(value As Integer)
            Id_Cargo = value
        End Set
    End Property

    Public Property Nombre_cargo1 As String
        Get
            Return Nombre_cargo
        End Get
        Set(value As String)
            Nombre_cargo = value
        End Set
    End Property



    Public Sub New(Optional id_Cargo As Integer = Nothing, Optional nombre_cargo As String = Nothing)
        Me.Nombre_cargo = nombre_cargo
        Me.Id_Cargo = id_Cargo
    End Sub


End Class
