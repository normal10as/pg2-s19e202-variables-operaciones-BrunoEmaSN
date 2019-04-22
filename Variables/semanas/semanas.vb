Imports System

Module semanas
    Sub Main()
        Dim da As Integer
        Dim dl As Integer
        Dim ds As Integer
        Dim sa As Integer
        Dim sl As Integer

        da = 365
        dl = 180
        ds = 7
        sa = da / ds
        sl = dl / ds

        Console.WriteLine("Un año tiene " & sa & " semanas")
        Console.WriteLine("Un año laboral tiene " & sl & " semanas")
        Console.Read()
    End Sub
End Module
