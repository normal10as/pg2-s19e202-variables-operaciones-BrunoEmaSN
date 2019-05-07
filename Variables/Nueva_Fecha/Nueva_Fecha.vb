Imports System

Module Nueva_Fecha
    Sub Main()
        Dim fecha As Date
        Dim dias As Int32
        Console.WriteLine("Ingrese una Fecha(AAAA-MM-DD)")
        fecha = Console.ReadLine()
        Console.WriteLine("Ingrese los Dias")
        dias = Console.ReadLine()
        fecha = New DateTime(Convert.ToInt32(fecha.Year), Convert.ToInt32(fecha.Month), (Convert.ToInt32(fecha.Day) + dias))
        Console.WriteLine(fecha)
        Console.Read()
    End Sub
End Module
