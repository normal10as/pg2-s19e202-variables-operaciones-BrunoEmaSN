Imports System

Module concatenacion
    Sub Main()
        Dim nde As String
        Dim ndc As String
        Dim adc As Integer
        Dim fia As Date

        Console.WriteLine("///////Nombre de Empresa//////")
        nde = Console.ReadLine()
        Console.WriteLine("///////Nombre de Calle////////")
        ndc = Console.ReadLine()
        Console.WriteLine("///////Altura de Calle////////")
        adc = Console.ReadLine()
        Console.WriteLine("Fecha de inicio de Actividades")
        fia = Console.ReadLine()

        Console.WriteLine("Concatenacion  Explicita")
        Console.WriteLine("El nombre de la empresa es " & nde & " en la calle " & ndc & " al " & adc & " las actividades empiezan el " & fia)
        Console.WriteLine("Concatenacion  Implicita")
        Console.WriteLine(nde & ";" & ndc & "," & adc & "," & fia)
        Console.Read()
    End Sub
End Module
