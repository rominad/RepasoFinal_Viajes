Public Class Pasaje
    Inherits Servicio
    Implements Abono
    'campos
    Private _fecha As Date
    Private _impuesto As Single
    Private _valor As Single
    Private _origen As Ciudad
    Private _destino As Ciudad
    'propiedades
    Private Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property
    Private Property Impuesto As Single
        Get
            Return _impuesto
        End Get
        Set(value As Single)
            _impuesto = value
        End Set
    End Property
    Private Property Valor As Single
        Get
            Return _valor
        End Get
        Set(value As Single)
            _valor = value
        End Set
    End Property
    'metodos
    Public Overloads Function calcularCosto() As Single Implements Abono.calcularCosto
        Return (Valor * Impuesto) + Valor
    End Function
    Sub New(descripcion As String, fecha As Date, valor As Single, impuesto As Single)
        MyBase.New(descripcion)
        Me.Fecha = fecha
        Me.Valor = valor
        Me.Impuesto = impuesto
    End Sub
    'asociaciones
    Private Property Origen As Ciudad
        Get
            Return _origen
        End Get
        Set(value As Ciudad)
            _origen = value
        End Set
    End Property
    Private Property Destino As Ciudad
        Get
            Return _destino
        End Get
        Set(value As Ciudad)
            _destino = value
        End Set
    End Property

End Class
