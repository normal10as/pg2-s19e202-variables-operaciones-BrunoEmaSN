Imports System

Module variables_tipo
    Sub Main()
        Dim nombre As String
        Dim nd As UInteger
        Dim ldn As String
        Dim fdn As Date
        Dim altura As Byte
        Dim sea As Boolean
        Dim ta As SByte
        Dim ndc As String
        Dim adc As Integer
        Dim distancia As UShort
        Dim profundidad As UShort
        Dim cantidad As UInteger
        Dim peso As Single
        Dim precio As Single

        nombre = "Bruce Wayne"
        nd = 27051939
        ldn = "Gotham City"
        fdn = #1939-2-19#
        altura = 190
        sea = False
        ta = 30
        ndc = "Arkham"
        adc = 20
        distancia = 5
        profundidad = 200
        cantidad = 65535
        peso = 0.2
        precio = 85.75

        Console.WriteLine("Nombre: " & nombre)
        Console.WriteLine("Numero de Documento: " & nd)
        Console.WriteLine("Lugar de Nacimiento: " & ldn)
        Console.WriteLine("Altura Corporal: " & altura)
        Console.WriteLine("Es Argentino: " & sea)
        Console.WriteLine("Temperatura ambiente: " & ta & "°C")
        Console.WriteLine("Nombre de Calle: " & ndc)
        Console.WriteLine("Altura de Calle: " & adc)
        Console.WriteLine("La distancia entre Gotham y Metropolis es de " & distancia)
        Console.WriteLine("La profundidad del mar es de " & profundidad)
        Console.WriteLine("La cantidad de habitantes del territorio nacional es de " & cantidad)
        Console.WriteLine("El peso de un baticinturon del supermercado es de " & peso)
        Console.WriteLine("El precio de un baticinturon del supermercado es de " & precio)
        Console.Read()
    End Sub
End Module
