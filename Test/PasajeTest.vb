Imports Viajes

Module PasajeTest
    Sub Main()
        Dim pasaje1 As New Pasaje("IGR", Today, 100.0, 0.21)
        Console.WriteLine("total: ${0}", pasaje1.calcularCosto())
        Console.ReadKey()
    End Sub
End Module
