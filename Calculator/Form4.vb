﻿Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim HouseValueNow As Double
        Dim AppreciationYears As Integer

        ' Check if Value is Numeric and Positive
        If IsNumeric(txtHouseValue.Text()) = True Then
            If txtHouseValue.Text() > 0 Then
                HouseValueNow = txtHouseValue.Text()
            Else
                MessageBox.Show("Please enter a positive number.",
                            "Input Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            MessageBox.Show("Please enter numbers only.",
                            "Input Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Check is Years has been selected
        If cmboYears.SelectedItem <> Nothing Then
            AppreciationYears = CInt(cmboYears.SelectedItem)
        Else
            MessageBox.Show("Please select a value from the drop down list.",
                            "Input Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim AppreciationRate As Double
        Dim HouseValueThen As Double
        Dim Difference As Double

        ' Set AppreciationRate with U.S. average rate
        AppreciationRate = 0.044

        ' Calculate Appreciation
        HouseValueThen = HouseValueNow * ((1 + AppreciationRate) ^ AppreciationYears)

        ' Calculate Difference
        Difference = HouseValueThen - HouseValueNow

        MessageBox.Show("Your current home value of " & FormatCurrency(HouseValueNow) & " is expected to increase " &
                        FormatPercent(AppreciationRate) & " year over year." &
                        vbCrLf & vbCrLf &
                        "Over " & AppreciationYears & " years your home is expected to increase by " &
                        FormatCurrency(Difference) & " and be worth a total of " & FormatCurrency(HouseValueThen),
                        "Estimated Appreciated Home Value",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtHouseValue.Clear()
        cmboYears.SelectedIndex = -1
    End Sub
End Class