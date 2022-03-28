Imports System

Module Program
    Sub Main()
        Dim variavel1 As Integer = 10
        Dim variavel2 As Integer = 10

        Console.WriteLine("Valores antes da atribuição: {0}, {1}", variavel1, variavel2)

        variavel1 += 5  'Isso equivale a v1 = v1 + 5'
        variavel2 *= 10 'Isso equivale a v2 = v2 * 10'

        Console.WriteLine("Valores após a atribuição: {0}, {1}", variavel1, variavel2)

        Console.ReadLine()
    End Sub
End Module
