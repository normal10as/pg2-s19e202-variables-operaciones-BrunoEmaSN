Module Refrase

    Sub Main()
        Dim Text As String = "Aunque la cadena sea de oro, sirve para lo mismo"
        Dim TestString As String
        Dim TestString2 As String
        Console.WriteLine("Ingrese una Palabra a remplazar en esta frase ")
        Console.WriteLine("(" & Text & ")")
        TestString = Console.ReadLine()
        Console.WriteLine("Ingrese Palabra para remplazar")
        TestString2 = Console.ReadLine()
        Console.WriteLine("Reemplazar en '{0}' la {1} por la {2}", Text, TestString, TestString2)
        Console.WriteLine(Replace(Text, TestString, TestString2))
        Console.Read()
    End Sub

End Module
