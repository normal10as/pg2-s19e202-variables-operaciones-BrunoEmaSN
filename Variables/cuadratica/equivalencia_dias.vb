Imports System

Module equivalencia_dias
    Sub Main()
        Dim numero As Integer
        Const ds As Int16 = 7
        Const hd As Int16 = 24
        Const mh As Int16 = 60

        Console.WriteLine("Ingresar un numero")
        numero = Console.ReadLine()
        Console.WriteLine("Numero de Semanas: " & numero / ds & ", Numero de Horas: " & numero * hd & " y Numero de Minutos: " & (numero * hd) * mh)
        Console.Read()
    End Sub
End Module
