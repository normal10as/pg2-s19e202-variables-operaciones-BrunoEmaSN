Imports System

Module tablas_de_verdad
    Sub Main()
        Dim v As Boolean
        Dim f As Boolean

        v = True
        f = False

        Console.WriteLine("AND")
        Console.WriteLine("p q ")
        Console.WriteLine("v v " & (v And v))
        Console.WriteLine("v f " & (v And f))
        Console.WriteLine("f v " & (f And v))
        Console.WriteLine("f f " & (f And f))

        Console.WriteLine("OR")
        Console.WriteLine("p q ")
        Console.WriteLine("v v " & (v Or v))
        Console.WriteLine("v f " & (v Or f))
        Console.WriteLine("f v " & (f And v))
        Console.WriteLine("f f " & (f And f))

        Console.WriteLine("NOT")
        Console.WriteLine("p    ¬p ")
        Console.WriteLine(v & "  " & Not v)
        Console.WriteLine(f & " " & Not f)

        Console.WriteLine("XOR")
        Console.WriteLine("p q ")
        Console.WriteLine("v v " & (v And v))
        Console.WriteLine("v f " & (v And f))
        Console.WriteLine("f v " & (f And v))
        Console.WriteLine("f f " & (f And f))
        Console.Read()

    End Sub
End Module
