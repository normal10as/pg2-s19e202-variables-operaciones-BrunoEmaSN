Imports System

Module intereses
    Sub Main()
        Dim m, r As Single
        Dim t As UShort

        Console.WriteLine("Monto")
        m = Console.ReadLine()
        Console.WriteLine("Interes")
        r = Console.ReadLine()
        Console.WriteLine("Duracion(Dias)")
        t = Console.ReadLine()
        Console.WriteLine("Intreses:" & (m * r * t) / (360 * 100))
        Console.WriteLine("Capital Acumulado: " & ((m * r * t) / (360 * 100) + m))
        Console.Read()
    End Sub
End Module
