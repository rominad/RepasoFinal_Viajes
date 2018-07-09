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
    'propiedad interface
    Public Function calcularCosto() As Single Implements Abono.calcularCosto
        Throw New NotImplementedException()
    End Function
    'metodo clase
    Public Sub addPasajeros(_persona As Pasajero)
        _pasajeros.Add(_persona)
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
        _fechaFinal = Nothing
    End Sub
    Public Overrides Function ToString() As String
        Dim Servicios As String = ""
        For Each servis In getAllServicios()
            Servicios += " - " + servis.Descripcion
        Next
        Return "Servicios: " + Servicios
    End Function
End Class
