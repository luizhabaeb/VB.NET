Class MainWindow
    Private Sub Botton1_Click(sender As Object, e As RoutedEventArgs) Handles Botton1.Click

    End Sub

    Private Sub Grid_Loaded(sender As Object, e As RoutedEventArgs)
        'Criar uma lista de itens com Array'
        Dim cities() As String = {"São Paulo", "New York", "Vancouver", "Montevideo"}
        For Each place In cities
            ComboBox1.Items.Add(place)
        Next
    End Sub

    Private Sub Botton2_Click(sender As Object, e As RoutedEventArgs) Handles Botton2.Click
        TextBox1.Text = ComboBox1.SelectedItem 'O "place" que estiver selecionado no ComboBox irá ser exibido na TextBox
    End Sub

    Private Sub ComboBox1_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles ComboBox1.SelectionChanged
        TextBox1.Text = ComboBox1.SelectedItem 'Dessa forma eu anulo a de cima; basta selecionar no ComboBox que já será exibido na TextBox
    End Sub
End Class
