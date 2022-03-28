Class MainWindow
    Private Sub txt_INPUT_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txt_INPUT.TextChanged
        txt_OUTPUT.Text = txt_INPUT.Text 'O que eu digitar na TextBox de entrada exibirá na TextBox de saída.
    End Sub

    Private Sub txt_INPUT_MouseMove(sender As Object, e As MouseEventArgs) Handles txt_INPUT.MouseMove
        lbl_OUTPUT.Content = "Cursor under the TextBox."
    End Sub

    Private Sub lbl_OUTPUT_MouseLeave(sender As Object, e As MouseEventArgs) Handles lbl_OUTPUT.MouseLeave
        lbl_OUTPUT.Content = Nothing
    End Sub

    Private Sub txt_INPUT_LostFocus(sender As Object, e As RoutedEventArgs) Handles txt_INPUT.LostFocus
        MessageBox.Show("Event lost focus.", "Foco")
    End Sub
End Class
