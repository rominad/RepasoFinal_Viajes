Imports Viajes

Module PaqueteTest
    Sub Main()
        Dim pasajero1 As New Pasajero(35124656, "Benitez Martin")
        Dim pasajero2 As New Pasajero(34524561, "Baltazar David")
        'Dim servicio1 As New Servicio("Hotel 1")
        'Dim servicio2 As New Servicio("Hotel 2")
        Dim Paquete1 As New Paquete

        Console.WriteLine(pasajero1.ToString())
        Console.WriteLine(pasajero2.ToString())
        'Console.WriteLine(servicio1.ToString())
        'Console.WriteLine(servicio2.ToString())


        Paquete1.addPasajeros(pasajero1)
        Paquete1.addPasajeros(pasajero2)
        'Paquete1.addServicios(servicio1)
        'Paquete1.addServicios(servicio2)
        Paquete1.calcularCosto()

        Console.WriteLine(Paquete1.ToString())

        For Each pasajero In Paquete1.getAllPasajeros()
            Console.WriteLine("Pasajero: {0}", pasajero)
        Next


        Console.WriteLine()
        Console.ReadLine()

    End Sub
End Module
