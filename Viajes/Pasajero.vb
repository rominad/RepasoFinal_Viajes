Public Class Pasajero
    'campo
    Private _dni As Integer
    Private _nombre As String

    Private Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Private Property DNI As Integer
        Get
            Return _dni
        End Get
        Set(value As Integer)
            _dni = value
        End Set
    End Property
    Sub New(dni As Integer, nombre As String)
        Me.DNI = dni
        Me.Nombre = nombre
    End Sub
    Public Overrides Function ToString() As String
        Return "Nombre: " & Nombre & " -DNI: " & DNI
    End Function
End Class
