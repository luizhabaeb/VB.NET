Imports System

Module Program
    Sub Main()
        Dim increase, number As Integer
        Dim fatorial As Integer = 1

        Console.WriteLine("Type a number: ")
        number = Console.ReadLine()

        For increase = number To 1 Step -1  'number to 1 pois é o Fatorial, ela vai variar até chegar em 1. 
            fatorial *= increase
            'Começa no número inserido e vai multiplicando pelo antecessor até chegar no 1. Por isso Step -1.
            'Apenas uma linha de código no loop - multiplicando ele pelo antecessor'
        Next

        Console.WriteLine("O fatorial é: {0}", fatorial)
        Console.ReadLine()
    End Sub
End Module
