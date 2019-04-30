Imports System

Module equivalencia_dias
    Sub Main()
        Dim numero As Integer
        Dim ds As Int16
        Dim hd As Int16
        Dim mh As Int16

        Console.WriteLine("Ingresar un numero")
        numero = Console.ReadLine()
        ds = numero / 7
        hd = numero * 24
        mh = hd * 60
        Console.WriteLine("Numero de Semanas: " & ds & ", Numero de Horas: " & hd & " y Numero de Minutos: " & mh)
        Console.Read()
    End Sub
End Module
