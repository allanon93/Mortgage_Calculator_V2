Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()
    End Sub

    Private Sub btnTotalMortgageAllowed_Click(sender As Object, e As EventArgs) Handles btnTotalMortgage.Click
        ' Close Forms other than 1 and 2
        Form3.Close()
        Form4.Close()

        ' Show Form2
        Form2.Show()
    End Sub

    Private Sub btnMonthlyMortgageTotal_Click(sender As Object, e As EventArgs) Handles btnMonthlyMortgageTotal.Click
        ' Close Forms other than 1 and 3
        Form2.Close()
        Form4.Close()

        ' Show Form3
        Form3.Show()
    End Sub

    Private Sub btnHouseAppreciation_Click(sender As Object, e As EventArgs) Handles btnHouseAppreciation.Click
        ' Close Forms other than 1 and 4
        Form2.Close()
        Form3.Close()

        'Show Form4
        Form4.Show()
    End Sub

End Class
