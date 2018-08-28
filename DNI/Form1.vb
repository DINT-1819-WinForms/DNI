Public Class Form1

    Private Sub CalcularButton_Click(sender As Object, e As EventArgs) Handles CalcularButton.Click
        Dim numero As Integer

        'Si los dos cuadros de texto están vacíos generamos un DNI aleatorio y calculamos su letra
        If String.IsNullOrEmpty(NumerosTextBox.Text.Trim()) And
           String.IsNullOrEmpty(LetraTextBox.Text.Trim()) Then
            numero = GenerarDniAleatorio()
            NumerosTextBox.Text = numero.ToString()
            LetraTextBox.Text = CalcularLetra(numero)

            'Si los dos están rellenos validamos la letra
        ElseIf Not String.IsNullOrEmpty(NumerosTextBox.Text.Trim()) And
               Not String.IsNullOrEmpty(LetraTextBox.Text.Trim()) Then

            If LetraTextBox.Text.ToUpper() = CalcularLetra(CInt(NumerosTextBox.Text)) Then
                MessageBox.Show("DNI correcto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("DNI erróneo", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            'Si solo está relleno el número, calculamos la letra
        ElseIf Not String.IsNullOrEmpty(NumerosTextBox.Text.Trim()) Then
            LetraTextBox.Text = CalcularLetra(CInt(NumerosTextBox.Text))

        Else
            'Si solo está rellena la letra, generamos un número para esa letra
            NumerosTextBox.Text = GenerarDniLetra(LetraTextBox.Text.ToUpper()).ToString()
        End If

    End Sub

    Private Sub LimpiarButton_Click(sender As Object, e As EventArgs) Handles LimpiarButton.Click
        'Limpiamos el contenido de los cuadros de texto
        NumerosTextBox.Clear()
        LetraTextBox.Clear()

        'Situamos el foco en el cuadro de texto de los números
        NumerosTextBox.Focus()
    End Sub
End Class
