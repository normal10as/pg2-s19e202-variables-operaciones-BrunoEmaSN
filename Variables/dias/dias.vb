Imports System

Module dias
    Enum DiaSemana
        domingo = 1
        lunes = 2
        martes = 3
        miercoles = 4
        jueves = 5
        viernes = 6
        sabados = 7
    End Enum
    Sub Main()
        Dim dia As DiaSemana
        Console.WriteLine("Ingrese un Dia(1 a 7)")
        dia = Console.ReadLine()
        Console.WriteLine("Dia de la semana: " & dia.ToString)
    End Sub
End Module
