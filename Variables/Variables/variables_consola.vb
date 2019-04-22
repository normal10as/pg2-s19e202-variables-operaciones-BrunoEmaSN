Imports System

Module variables_consola
    Sub Main()
        Dim nombre As String
        Dim apellido As String
        Dim fdn As Date
        Console.WriteLine("Ingrese por teclado")
        Console.WriteLine("///////Nombre//////")
        nombre = Console.ReadLine()
        Console.WriteLine("//////Apellido/////")
        apellido = Console.ReadLine()
        Console.WriteLine("Fecha de Nacimiento")
        Console.WriteLine("/////AAAA-MM-DD////")
        fdn = Console.ReadLine()
        Console.WriteLine(apellido & ", " & nombre & " nacio el " & fdn)
        Console.Read()
    End Sub
End Module
