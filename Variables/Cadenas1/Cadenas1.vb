Module Cadenas1

    Sub Main()
        Dim SearchString As String
        Console.WriteLine("Ingrese una Palabra")
        SearchString = Console.ReadLine()
        Dim SearchChar As String = "a"
        Dim startPosition As Byte = 1
        Console.WriteLine("aparece la primer a en la posicion " & InStr(startPosition, SearchString, SearchChar, CompareMethod.Text))
        SearchChar = "o"
        Console.WriteLine("aparece la primer o en la posicion " & InStr(startPosition, SearchString, SearchChar, CompareMethod.Text))
        Console.WriteLine("palabra invertida " & StrReverse(SearchString))
        Console.Read()
    End Sub

End Module
