Imports System

Module Program
    Sub Main()
        Dim increase, number As Integer
        Dim fatorial As Integer = 1

        Console.WriteLine("Type a number: ")
        number = Console.ReadLine()

        For increase = number To 1 Step -1  'number to 1 pois � o Fatorial, ela vai variar at� chegar em 1. 
            fatorial *= increase
            'Come�a no n�mero inserido e vai multiplicando pelo antecessor at� chegar no 1. Por isso Step -1.
            'Apenas uma linha de c�digo no loop - multiplicando ele pelo antecessor'
        Next

        Console.WriteLine("O fatorial �: {0}", fatorial)
        Console.ReadLine()
    End Sub
End Module
