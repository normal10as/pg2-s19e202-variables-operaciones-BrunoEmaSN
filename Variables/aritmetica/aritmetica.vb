Imports System

Module aritmetica
    Sub Main()
        Dim entero1 As Integer
        Dim entero2 As Integer
        Dim flotante1 As Single
        Dim flotante2 As Single

        entero1 = 64
        entero2 = 32
        flotante1 = 3.2
        flotante2 = 6.4

        Console.WriteLine("entero1 = " & entero1 & " y entero2 = " & entero2)
        Console.WriteLine("flotante1 = " & flotante1 & " y flotante2 = " & flotante2)

        Console.WriteLine("Sumar")
        Console.WriteLine("entero con entero " & entero1 + entero2)
        Console.WriteLine("entero con punto flotante " & entero1 + flotante1)
        Console.WriteLine("punto flotante con punto flotante " & flotante1 + flotante2)
        Console.WriteLine("Restar")
        Console.WriteLine("entero con entero " & entero1 - entero2)
        Console.WriteLine("entero con punto flotante " & entero1 - flotante1)
        Console.WriteLine("punto flotante con punto flotante " & flotante1 - flotante2)
        Console.WriteLine("Multiplicar")
        Console.WriteLine("entero por entero " & entero1 * entero2)
        Console.WriteLine("entero por punto flotante " & entero1 * flotante1)
        Console.WriteLine("punto flotante por punto flotante " & flotante1 * flotante2)
        Console.WriteLine("Dividir")
        Console.WriteLine("entero por entero " & entero1 / entero2)
        Console.WriteLine("entero por punto flotante " & entero1 / flotante1)
        Console.WriteLine("punto flotante por punto flotante " & flotante1 / flotante2)
        Console.Read()
    End Sub
End Module
