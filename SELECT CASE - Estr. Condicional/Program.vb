Imports System

Module Program
    Sub Main()
        Dim var As String
        Console.WriteLine("Type an A or B option: ")
        var = Console.ReadLine()
        'Agora eu quero que seja exibida uma mensagem diferente na tela, de acordo com o que o usuário digitou:'

        Select Case var
            Case "A"
                Console.Write("You've type the letter A.")
            Case "B"
                Console.Write("You've type the letter B.")
            Case Else
                Console.Write("You've type none of the correct letters.")

        End Select



    End Sub
End Module
