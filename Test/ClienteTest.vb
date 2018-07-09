Imports Viajes

Module ClienteTest
    Sub Main()
        Dim persona1 As New Pasajero(35214663, "Lopez")
        Dim cliente1 As New Cliente(persona1, 27352146635)
        Console.WriteLine(cliente1.ToString())
        Console.ReadKey()
    End Sub
End Module
