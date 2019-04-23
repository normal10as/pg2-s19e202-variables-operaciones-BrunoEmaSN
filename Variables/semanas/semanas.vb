Imports System

Module semanas
    Sub Main()
        Dim da As UShort
        Dim dl As Byte
        Dim ds As Byte
        Dim sa As Byte
        Dim sl As Byte

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
