Imports System

Module intereses
    Sub Main()
        Dim m, r As Single
        Dim t As Int16

        Console.WriteLine("Monto")
        m = Console.ReadLine()
        Console.WriteLine("Interes")
        r = Console.ReadLine()
        Console.WriteLine("Duracion(Dias)")
        t = Console.ReadLine()
        Console.WriteLine("I = (m*r*t)/(360*100) = " & (m * r * t) / (360 * 100))
        Console.Read()
    End Sub
End Module
