Imports Viajes
Module HotelTest
    Sub Main()
        Dim ciudad1 As New Ciudad("Posadas")
        Dim hotel1 As New Hotel("HotelCopado", 2, 5, 100.0)
        Console.WriteLine("Monto Total a cobrar: ${0}", hotel1.calcularCosto())
        Console.WriteLine(hotel1.ToString())
        Console.ReadKey()
    End Sub
End Module

