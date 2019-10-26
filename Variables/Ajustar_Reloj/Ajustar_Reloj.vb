Imports System.DateTime
Imports System.String
Module dias
    Sub Main()
        Dim TestDateTime As Date
        Dim dia As Integer
        Dim hora As Integer
        Console.WriteLine("Ingrese un Dia(1 a 31)")
        dia = Console.ReadLine()
        Console.WriteLine("Ingrese una hora(0 a 23)")
        hora = Console.ReadLine()
        TestDateTime = New DateTime(Now.Year, Now.Month, dia, hora, Now.Hour, Now.Minute, Now.Second)
        Console.WriteLine(TestDateTime)
        Console.Read()
    End Sub
End Module