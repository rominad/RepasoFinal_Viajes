Public Class Cliente
    Private _cuit_cuil As String
    Private _pasajero As Pasajero
    'propiedades
    Private Property Cuit_cuil As String
        Get
            Return _cuit_cuil
        End Get
        Set(value As String)
            _cuit_cuil = value
        End Set
    End Property
    Private Property Pasajero As Pasajero
        Get
            Return _pasajero
        End Get
        Set(value As Pasajero)
            _pasajero = value
        End Set
    End Property
    'metodos
    Sub New(persona As Pasajero, cuit_cuil As String)
        Me.Pasajero = persona
        Me.Cuit_cuil = _cuit_cuil
    End Sub
    Public Overrides Function ToString() As String
        Return Pasajero.ToString
    End Function

End Class
