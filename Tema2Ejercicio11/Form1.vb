Public Class Form1
    Private Sub Calculate()
        Dim height As Decimal
        Dim weight As Decimal

        If Decimal.TryParse(TextBoxHeight.Text, height) And Decimal.TryParse(TextBoxWeight.Text, weight) Then
            Dim index As Decimal = 0

            If height > 0 Then
                height /= 100
                index = weight / (height * height)
            End If

            LabelIndex.Text = Format(index, "0.0")
            LabelDescription.Text = ""

            If index < 18.5 Then
                LabelDescription.Text = "Peso inferior al normal"
            ElseIf index >= 18.5 And index < 25 Then
                LabelDescription.Text = "Normal"
            ElseIf index >= 25 And index < 30 Then
                LabelDescription.Text = "Peso superior al normal"
            ElseIf index >= 30 And index < 35 Then
                LabelDescription.Text = "Obesidad tipo 2"
            ElseIf index >= 35 And index < 40 Then
                LabelDescription.Text = "Obesidad tipo 2"
            End If
        End If
    End Sub

    Private Sub TextBoxHeight_TextChanged(sender As Object, e As EventArgs) Handles TextBoxHeight.TextChanged
        Calculate()
    End Sub

    Private Sub TextBoxWeight_TextChanged(sender As Object, e As EventArgs) Handles TextBoxWeight.TextChanged
        Calculate()
    End Sub
End Class
