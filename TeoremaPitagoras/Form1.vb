Public Class frmPitagoras

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        If String.IsNullOrEmpty(txtA.Text) And String.IsNullOrEmpty(txtB.Text) And String.IsNullOrEmpty(txtH.Text) Then
            MessageBox.Show("Informe pelo menos dois valores para calcular...")
        ElseIf Not String.IsNullOrEmpty(txtA.Text) And Not String.IsNullOrEmpty(txtB.Text) Then
            Dim a As Single = Convert.ToSingle(txtA.Text)
            Dim b As Single = Convert.ToSingle(txtB.Text)
            CalculaTeoremaPitagoras1(a, b)
            lblArea5.Text = "Área ="
        ElseIf Not String.IsNullOrEmpty(txtA.Text) And Not String.IsNullOrEmpty(txtH.Text) Then
            Dim a As Single = Convert.ToSingle(txtA.Text)
            Dim h As Single = Convert.ToSingle(txtH.Text)
            If a > h Then
                MessageBox.Show("O valor da altura deve ser maior que o valor do cateto a")
            Else
                CalculaTeoremaPitagoras2(a, h)
                lblArea5.Text = "Área ="
            End If
        ElseIf Not String.IsNullOrEmpty(txtB.Text) And Not String.IsNullOrEmpty(txtH.Text) Then
            Dim b As Single = Convert.ToSingle(txtB.Text)
            Dim h As Single = Convert.ToSingle(txtH.Text)
            If b > h Then
                MessageBox.Show("O valor da altura deve ser maior que o valor do cateto b")
                Return
            Else
                CalculaTeoremaPitagoras3(b, h)
                CalculaArea(b, h)
            End If
        End If
    End Sub

    Private Sub CalculaTeoremaPitagoras1(ByVal a As Single, ByVal b As Single)
        Dim h As Single
        h = (a ^ 2 + b ^ 2) ^ (1 / 2)
        txtH.Text = h
    End Sub

    Private Sub CalculaTeoremaPitagoras2(ByVal a As Single, ByVal h As Single)
        Dim b As Single
        b = Math.Sqrt((h ^ 2) - (a ^ 2))
        txtB.Text = b
    End Sub

    Private Sub CalculaTeoremaPitagoras3(ByVal b As Single, ByVal h As Single)
        Dim a As Single
        Dim temp As Single = (h ^ 2) - (b ^ 2)
        a = Math.Sqrt(temp)
        txtA.Text = a
    End Sub

    Private Sub CalculaArea(b As Single, h As Single)
        Dim area As Single
        area = (b + h) / 2
        lblArea5.Text = "Área = " & area
    End Sub
End Class
