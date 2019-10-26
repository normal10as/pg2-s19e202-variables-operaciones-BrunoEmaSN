Module Refrase

    Sub Main()
        Dim Text As String = "Aunque la cadena sea de oro, sirve para lo mismo"
        Dim palabra_vieja As String
        Dim palabra_nueva As String
        Dim palabra_a_reemplazar As String
        Dim palabra_que_reemplaza As String
        Dim frasenueva As String
        Console.WriteLine("(" & Text & ")")
        Console.WriteLine("Ingrese una Palabra a remplazar en esta frase ")
        palabra_vieja = Console.ReadLine()
        Console.WriteLine("Ingrese Palabra para remplazar")
        palabra_nueva = Console.ReadLine()
        Console.WriteLine("Reemplazar en '{0}' la {1} por la {2}", Text, palabra_vieja, palabra_nueva)
        Console.WriteLine(Replace(Text, palabra_vieja, palabra_nueva))
        Console.Read()
        palabra_a_reemplazar = " " & palabra_vieja & " "
        palabra_que_reemplaza = " " & palabra_nueva & " "
        frasenueva = (Replace(Text, palabra_a_reemplazar, palabra_que_reemplaza, 1, -1, 1))
        palabra_a_reemplazar = " " & palabra_vieja & ","
        palabra_que_reemplaza = " " & palabra_nueva & ","
        frasenueva = (Replace(frasenueva, palabra_a_reemplazar, palabra_que_reemplaza, 1, -1, 1))
        palabra_a_reemplazar = " " & palabra_vieja & "."
        palabra_que_reemplaza = " " & palabra_nueva & "."
        frasenueva = (Replace(frasenueva, palabra_a_reemplazar, palabra_que_reemplaza, 1, -1, 1))
        Console.WriteLine(frasenueva)
    End Sub

End Module
