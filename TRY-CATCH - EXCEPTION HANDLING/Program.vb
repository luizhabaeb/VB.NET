Imports System

Module Program
    Sub Main()
        Dim number1, number2 As String
        Dim Result As Double

        Console.WriteLine("Type a number: ")
        number1 = Console.ReadLine()
        Console.WriteLine("Type another number: ")
        number2 = Console.ReadLine()

        'Quero dividir um n�mero pelo outro, e, caso o usu�rio digite uma letra, o Bloco abaixo identifique como uma exce��o/erro e n�o trave o programa'
        Try
            Result = CDbl(number1) / CDbl(number2)
            Console.WriteLine("The division of {0} to {1} is {2:0.00}", number1, number2, Result)
        Catch ex As Exception 'ex: vari�vel exception
            Console.WriteLine("Letters or characters can't be calculed.")
        Finally


        End Try


    End Sub
End Module
