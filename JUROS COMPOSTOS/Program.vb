Imports System

Module Program
    Sub Main()
        Dim montante, capinicial As Decimal 'Para representar um número com bastante precisão
        Dim taxaJuros As Double 'Pode ser um número quebrado
        Dim ano As Integer
        Dim saída As String 'Vamos utilizar para exibir a quantia após cada ano

        Console.WriteLine("Coloque o capital inicial: ")
        capinicial = Console.ReadLine()
        Console.WriteLine()

        Console.WriteLine("Qual a taxa de juros?")
        taxaJuros = Console.ReadLine()
        Console.WriteLine()
        saída = "Ano" & vbTab & "Quantia" & vbCrLf

        For ano = 1 To 10
            montante = capinicial * (1 + taxaJuros) ^ ano
            saída &= ano & vbTab & String.Format("{0:C}", montante) & vbCrLf 'O String.Format é dispensável. Daria pra fazer apenas concatenando '& montante'
        Next

        Console.WriteLine(saída)
    End Sub
End Module
