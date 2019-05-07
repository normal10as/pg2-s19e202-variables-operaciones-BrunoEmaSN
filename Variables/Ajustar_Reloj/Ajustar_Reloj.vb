Imports System.DateTime
Imports System.String
Module Program
    Sub Main()
        Dim TestDateTime As Date = Now
        Dim dia As Integer
        Dim hora As Integer
        Console.WriteLine("Ingrese un Dia(1 a 31)")
        dia = Console.ReadLine()
        Console.WriteLine("Ingrese una hora(0 a 23)")
        hora = Console.ReadLine()
        TestDateTime = New DateTime(Convert.ToInt32(TestDateTime.Year), Convert.ToInt32(TestDateTime.Month), dia, hora, 0, 0)
        Console.WriteLine(TestDateTime)
        Console.Read()
    End Sub
End Module