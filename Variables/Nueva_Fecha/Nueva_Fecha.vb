Imports System

Module Nueva_Fecha
    Sub Main()
        Dim fecha As Date
        Dim dias As Int32
        Console.WriteLine("Ingrese una Fecha(AAAA-MM-DD)")
        fecha = Console.ReadLine()
        Console.WriteLine("Ingrese los Dias")
        dias = Console.ReadLine()
        Console.WriteLine(fecha.AddDays(dias))
        Console.Read()
    End Sub
End Module
