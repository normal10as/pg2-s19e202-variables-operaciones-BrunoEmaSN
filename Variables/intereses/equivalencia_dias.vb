Imports System

Module equivalencia_dias
    Sub Main()
        Dim numero As Integer
        Dim ds As Byte
        Dim hd As Byte
        Dim mh As Byte

        Console.WriteLine("Ingresar un numero")
        numero = Console.ReadLine()
        ds = numero / 7
        hd = numero * 24
        mh = hd * 60
        Console.WriteLine("Numero de Semanas: " & ds & ", Numero de Horas: " & hd & " y Numero de Minutos: " & mh)
        Console.Read()
    End Sub
End Module
