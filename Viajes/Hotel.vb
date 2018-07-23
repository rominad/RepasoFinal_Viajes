Imports Viajes

Public Class Hotel
    Inherits Servicio
    'interface
    Implements Abono
    'campos
    Private _numeroHabitaciones As Integer
    Private _numeroNoches As Integer
    Private _valorDiaria As Single
    Private _ciudad As Ciudad
    'propiedades
    Private Property numeroHabitaciones As Integer
        Get
            Return _numeroHabitaciones
        End Get
        Set(value As Integer)
            _numeroHabitaciones = value
        End Set
    End Property
    Private Property numeroNoches As Integer
        Get
            Return _numeroNoches
        End Get
        Set(value As Integer)
            _numeroNoches = value
        End Set
    End Property
    Private Property valorDiaria As Single
        Get
            Return _valorDiaria
        End Get
        Set(value As Single)
            _valorDiaria = value
        End Set
    End Property
    Private Property Ciudad As Ciudad
        Get
            Return _ciudad
        End Get
        Set(value As Ciudad)
            _ciudad = value
        End Set
    End Property
    'metodos
    Sub New(descripcion As String, habitaciones As Integer, noches As Integer, diaria As Single)
        MyBase.New(descripcion)
        Me.numeroHabitaciones = habitaciones
        Me.numeroNoches = noches
        Me.valorDiaria = diaria
    End Sub
    Public Overrides Function ToString() As String
        Return Descripcion
    End Function

    Public Overloads Function calcularCosto() As Single Implements Abono.calcularCosto
        Return valorDiaria * numeroHabitaciones * numeroNoches
    End Function
End Class
