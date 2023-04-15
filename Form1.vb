Public Class InterestCalculator
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim Principle As Decimal = CDec(txtbxPrinciple.Text)
        Dim Rate As Decimal = CDec(txtbxRate.Text)
        Dim Time As Decimal = CDec(txtbxTime.Text)

        'Simple Interest = PRT/100
        'Compound Interest = P(1+R/100)^T

        If chbSimple.Checked = True Then
            Dim SimpInterest As Decimal = (Principle * Rate * Time) / 100
            txtbxInt.Text = SimpInterest
            txtbxAmt.Text = Principle + SimpInterest
        ElseIf chbCompound.Checked = True Then
            Dim CompInterest As Decimal = (Principle * (1 + (Rate / 100)) ^ Time)
            txtbxInt.Text = CompInterest - Principle
            txtbxAmt.Text = CompInterest

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
