Imports System

Module Redondeo
    Sub Main()
        Dim a As Double
        Console.WriteLine("Ingrese un Valor a A")
        a = Console.ReadLine()
        Console.WriteLine("valor aproximado de " & a & " por exceso " & Math.Ceiling(a))
        Console.WriteLine("valor aproximado de " & a & " por defecto " & Math.Floor(a))
        Console.WriteLine("valor de " & a & " redondeado " & Math.Round(a))
        Console.Read()
    End Sub
End Module
