Imports System

Module sumatoria_y_media
    Sub Main()
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim d As Integer

        Console.WriteLine("Ingrese 4 numeros enteros")
        Console.WriteLine("Ingrese el primer numero")
        a = Console.ReadLine()
        Console.WriteLine("Ingrese el segundo numero")
        b = Console.ReadLine()
        Console.WriteLine("Ingrese el tercero numero")
        c = Console.ReadLine()
        Console.WriteLine("Ingrese el cuarto numero")
        d = Console.ReadLine()

        Console.WriteLine("Sumatoria: " & a + b + c + d)
        Console.WriteLine("Media: " & (a + b + c + d) / 2)
        Console.Read()
    End Sub
End Module
