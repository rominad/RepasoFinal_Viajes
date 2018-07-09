Public Class Ciudad
    'campos
    Private _nombre As String
    'popiedad
    Private Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    'metodos
    Sub New(nombre As String)
        Me.Nombre = nombre
    End Sub
    Public Overrides Function ToString() As String
        Return "Nombre: " & Nombre
    End Function
End Class
