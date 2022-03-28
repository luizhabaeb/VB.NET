Imports System

Module Program
    Sub Main()
        Dim counter As Integer = 1

        While counter <= 10 'Enquanto o contador for menor ou igual a 10 - o código segue em execução 
            Console.WriteLine(counter) 'Método "WRITE" retorna o valor da variável na tela todos na mesma linha.
            counter += 1 'OPERADOR DE ATRIBUIÇÃO "ACUMULADOR" → Vai pegar o conteúdo do contador (1) e somar 1 acumulando o valor - Até chegar no 10.
            'counter +=1 → expressão de saída - é o que vai tornar a expressão "While counter <= 10" falsa e sair do Loop.
        End While

        If counter Mod 2 = 1 Then
            Console.WriteLine("odd")
        Else
            Console.WriteLine("pair")
        End If

    End Sub
End Module
