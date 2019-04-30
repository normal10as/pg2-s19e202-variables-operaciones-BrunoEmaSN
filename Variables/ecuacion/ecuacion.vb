Imports System

Module ecuacion
    Sub Main()
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer

        a = 1
        b = 5
        c = 2
        Console.WriteLine("a={0}, b={1} y c={2}", a, b, c)
        Console.WriteLine("Ecuacion x=(b^2-4ac)/2a")
        Console.WriteLine((b ^ 2 - 4 * a * c) / 2 * a)
        Console.Read()
    End Sub
End Module
