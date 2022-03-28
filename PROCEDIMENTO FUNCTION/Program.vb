Imports System

Module Program
    Sub Main()
        Dim num As Integer
        Console.WriteLine("Type any number: ")
        num = CInt(Console.ReadLine()) 'Utilizei CInt para converter o valor lido pra Inteiro - ReadLine retorna uma string.
        Console.WriteLine("The cube of {0} is {1}", num, cube(num))

    End Sub

    Function cube(ByVal x As Integer) As Integer 'O x é o número que ele vai usar; pode ser qualquer letra.
        Return x ^ 3
    End Function
End Module
