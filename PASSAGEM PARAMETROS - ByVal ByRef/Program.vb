Imports System

Module Program
    Sub Main()
        Dim number As Integer = 10
        Dim number2 As Integer = 10
        Console.WriteLine("Passagem de parâmetro por valor: ")
        Console.WriteLine("Antes de chamar a sub quadValor, number vale " & number)
        quadValor(number)
        Console.WriteLine("Após chamar a sub quadValor, number vale " & number)
        Console.WriteLine()

        Console.WriteLine("Passagem de parâmetro por referência ")
        Console.WriteLine("Antes de chamar a sub quadRef, number2 vale " & number2)
        quadRef(number2)
        Console.WriteLine("Após chamar a sub quadRef, number2 vale " & number2)
        Console.WriteLine()
    End Sub

    'Elevar o número passado por valor → ao quadrado
    Sub quadValor(ByVal x As Integer)
        x *= x
        Console.WriteLine("Antes de sair da sub, x vale " & x)
    End Sub

    'Elevar o número passado por referência → ao quadrado
    Sub quadRef(ByRef x As Integer)
        x *= x
        Console.WriteLine("Antes de sair da sub, x vale " & x)
    End Sub
End Module
