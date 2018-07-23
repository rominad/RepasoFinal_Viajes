Imports Viajes

Public Class Paquete
    'interface
    Implements Abono
    'campos
    Private _fechaFinal As Date
    Private _fechaInicial As Date
    Private _numeroDias As Integer
    Private _pasajeros As List(Of Pasajero)
    Private _servicios As List(Of Servicio)
    'propiedad
    Public ReadOnly Property fechaFinal As Date
        Get
            Return _fechaFinal
        End Get
    End Property
    Public ReadOnly Property fechaInicial As Date
        Get
            Return _fechaInicial
        End Get
    End Property
    Public ReadOnly Property numeroDias As Integer
        Get
            Return DateDiff(DateInterval.Day, fechaInicial, fechaFinal)
        End Get
    End Property
    Public ReadOnly Property numeroMiembros As Integer
        Get
            Return _pasajeros.Count()
        End Get
    End Property
    Public Function calcularCosto() As Single Implements Abono.calcularCosto
        Dim total As New Single
        For Each servicio In getAllServicios()
            total += servicio.calcularCosto()
        Next
        Return total
    End Function
    'metodo clase
    Public Sub addPasajeros(value As Pasajero)
        _pasajeros.Add(value)
    End Sub
    Public Function getAllPasajeros() As List(Of Pasajero)
        Return _pasajeros
    End Function

    Public Sub addServicios(_servicio As Servicio)
        _servicios.Add(_servicio)
    End Sub
    Public Function getAllServicios() As List(Of Servicio)
        Return _servicios
    End Function
    ' constructor
    Sub New()
        _fechaFinal = Nothing
        _fechaInicial = Nothing
        _numeroDias = Nothing
        _pasajeros = New List(Of Pasajero)
        _servicios = New List(Of Servicio)
    End Sub
    Public Overrides Function ToString() As String
        Dim Servicios As String = ""
        For Each servis In getAllServicios()
            Servicios += " - " + servis.Descripcion
        Next
        Return "Servicios: " + Servicios
    End Function
End Class
