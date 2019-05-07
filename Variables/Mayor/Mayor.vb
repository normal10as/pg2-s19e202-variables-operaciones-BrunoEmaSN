Imports System

Module Mayor
    Sub Main()
        Dim a, b, c As Single
        Console.WriteLine("Ingrese un numero")
        a = Console.ReadLine()
        Console.WriteLine("Ingrese otro numero")
        b = Console.ReadLine()
        Console.WriteLine("Ingrese otro numero")
        c = Console.ReadLine()
        Console.WriteLine("el mayor es " & Math.Max(Math.Max(a, b), Math.Max(b, c)))
        Console.Read()
    End Sub
End Module
