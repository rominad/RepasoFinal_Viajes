Public Class Viajes
    'CLASES DE UTILIDADES
    'campos
    Private _ciudades As List(Of Ciudad)
    Private _paquetes As List(Of Paquete)
    Private _clientes As List(Of Cliente)
    'metodos
    'PARA REALIZAR LA SIGUIENTE FUNCION LA CLASE CIUDAD DEBERIA CONTAR CON UN ID, lo cual no existe en el diagrama 

    'Public Function getCityByID(id As String) As Ciudad
    '    For Each ciudad In _ciudades
    '        If id = ciudad.id Then
    '            Return ciudad
    '        End If
    '    Next
    'End Function
    Public Function getPaqueteByCliente(cuit_cuil As String) As List(Of Paquete)
        For Each cliente In _clientes
            If cuit_cuil = cliente.Cuit_cuil Then
                Return _paquetes
            End If
        Next
    End Function
End Class
