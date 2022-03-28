Imports System

Module Program
    Sub Main()
        'Quero somar os números PARES de 0 até 100
        Dim number As Integer  'Variável Contadora
        Dim sum As Integer = 0 'Iniciar como 0 para garantir que não tenha nada na variável - Pois ela é acumuladora

        For number = 0 To 100 Step 2  'Se eu quiser todos os números, pares  ou não, basta apagar o STEP 2.
            sum += number      'Atribuir e Acumular/Somar ao mesmo tempo → +=             
        Next

        Console.WriteLine("A soma é: " & sum)
        Console.ReadLine()
    End Sub
End Module


