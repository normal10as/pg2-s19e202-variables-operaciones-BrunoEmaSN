Imports System

Module Matematica1
    Sub Main()
        Dim a As Single
        Console.WriteLine("Ingrese un Valor a A")
        a = Console.ReadLine()
        Console.WriteLine("valor absoluto de A = " & Math.Abs(a))
        Console.WriteLine("A^10 = " & a ^ 10)
        Console.WriteLine("A su raiz cuadrada es " & Math.Sqrt(a))
        Console.Read()
    End Sub
End Module
