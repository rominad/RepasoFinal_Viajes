Imports Viajes

Module PaqueteTest
    Sub Main()

        Try
            Dim paquete1 As New Paquete()
            Dim hotel1 As New Hotel("HotelCopado", 2, 5, 100)
            Dim pasaje1 As New Pasaje("Posadas-Santa Ana", Today, 100, 0.2)
            Dim pasajero1 As New Pasajero(35124656, "Benitez Martin")
            Dim pasajero2 As New Pasajero(34524561, "Baltazar David")

            paquete1.addPasajeros(pasajero1)
            paquete1.addPasajeros(pasajero2)
            paquete1.addServicios(hotel1)
            paquete1.addServicios(pasaje1)

            Console.WriteLine("Paquete:")
            Console.WriteLine(paquete1.ToString())
            Console.WriteLine("Listado de Pasajeros")
            For Each pasajero In paquete1.getAllPasajeros()
                Console.WriteLine("- {0}", pasajero)
            Next
            Console.WriteLine("calcular costos: {0}", paquete1.calcularCosto())

        Catch ex As Exception
            'Console.WriteLine(ex.Message)
            Console.WriteLine("Error inesperado!")

        End Try

        Console.ReadLine()

    End Sub
End Module
