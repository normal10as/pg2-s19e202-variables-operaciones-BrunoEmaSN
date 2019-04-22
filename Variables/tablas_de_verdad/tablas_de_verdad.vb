Imports System

Module tablas_de_verdad
    Sub Main()
        Dim v As Boolean
        Dim f As Boolean

        v = True
        f = False

        Console.WriteLine("AND")
        Console.WriteLine("p q ")
        Console.WriteLine("v v " & v)
        Console.WriteLine("v f " & f)
        Console.WriteLine("f v " & f)
        Console.WriteLine("f f " & v)

        Console.WriteLine("OR")
        Console.WriteLine("p q ")
        Console.WriteLine("v v " & v)
        Console.WriteLine("v f " & v)
        Console.WriteLine("f v " & v)
        Console.WriteLine("f f " & f)

        Console.WriteLine("NOT")
        Console.WriteLine("p    ¬p ")
        Console.WriteLine(v & "  " & f)
        Console.WriteLine(f & " " & v)

        Console.WriteLine("XOR")
        Console.WriteLine("p q ")
        Console.WriteLine("v v " & f)
        Console.WriteLine("v f " & v)
        Console.WriteLine("f v " & v)
        Console.WriteLine("f f " & f)
        Console.Read()

    End Sub
End Module
