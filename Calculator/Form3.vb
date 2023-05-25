﻿Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()
    End Sub

    Private Sub btnMonthlyMortgageCalculate_Click(sender As Object, e As EventArgs) Handles btnMonthlyMortgageCalculate.Click

        Dim HouseValue As Double
        Dim DownPayment As Double
        Dim InterestRate As Double
        Dim TermLengthMonths As Integer

        ' Check txtbox for Numeric and Positive
        If IsNumeric(txtMonthlyMortgageHomeValue.Text()) = True Then
            If txtMonthlyMortgageHomeValue.Text() > 0 Then
                HouseValue = txtMonthlyMortgageHomeValue.Text()
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

        ' Check txtbox for Numeric and Positive
        If IsNumeric(txtMonthlyMortgageDownpayment.Text()) = True Then
            If txtMonthlyMortgageDownpayment.Text() > 0 Then
                DownPayment = txtMonthlyMortgageDownpayment.Text()
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

        ' Check to see if House Value is greater than Downpayment
        If HouseValue < DownPayment Then
            MessageBox.Show("Please enter a downpayment that is less than the house value.",
                            "Input Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Exit Sub
        End If

        '  Interest Rate is combobox selection divided 100 to get 0.00 format
        If cmboMonthlyMortgageInterestRate.SelectedItem <> Nothing Then
            InterestRate = CDbl(cmboMonthlyMortgageInterestRate.SelectedItem) / 100
        Else
            MessageBox.Show("Please select a value from the drop down list.",
                            "Input Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Term Length is combobox selection multiplied by 12 to get total months
        If cmboMonthlyMortgageTermLength.SelectedItem <> Nothing Then
            TermLengthMonths = CInt(cmboMonthlyMortgageTermLength.SelectedItem) * 12
        Else
            MessageBox.Show("Please select a value from the drop down list.",
                            "Input Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim Principle As Double
        Dim MonthlyInterest As Decimal
        Dim BaseMortgageMonthly As Double

        ' Calculate Principle
        Principle = HouseValue - DownPayment

        ' Calculate Monthly Interest
        MonthlyInterest = InterestRate / 12

        ' Calculate and Round Monthly Mortgage
        BaseMortgageMonthly = Principle * ((MonthlyInterest * ((1 + MonthlyInterest) ^ TermLengthMonths)) /
            (((1 + MonthlyInterest) ^ TermLengthMonths) - 1))

        Dim TaxesMonthly As Double
        Dim InsuranceMonthly As Double

        ' Calculate Monthly Taxes
        TaxesMonthly = (HouseValue * 0.011) / 12

        ' Calculate Monthly Insurance
        InsuranceMonthly = (HouseValue * 0.0025) / 12

        Dim TotalMortgageMonthly As Double

        ' Calculate Total Monthly Mortgage
        TotalMortgageMonthly = BaseMortgageMonthly + TaxesMonthly + InsuranceMonthly

        ' Display Data
        MessageBox.Show("Your estimated monthly mortgage is: " & FormatCurrency(TotalMortgageMonthly) &
                        vbCrLf & vbCrLf &
                        "Breakdown:" &
                        vbCrLf & vbCrLf &
                        "Principle and Interest: " & FormatCurrency(BaseMortgageMonthly) & vbCrLf &
                        "Monthly Taxes: " & FormatCurrency(TaxesMonthly) & vbCrLf &
                        "Monthly Insurance: " & FormatCurrency(InsuranceMonthly),
                        "Estimated Monthly Mortgage",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

    End Sub

    Private Sub btnMonthlyMortgageClear_Click(sender As Object, e As EventArgs) Handles btnMonthlyMortgageClear.Click
        txtMonthlyMortgageHomeValue.Clear()
        txtMonthlyMortgageDownpayment.Clear()
        cmboMonthlyMortgageInterestRate.SelectedIndex = -1
        cmboMonthlyMortgageTermLength.SelectedIndex = -1
    End Sub

    Private Sub cmboMonthlyMortgageTermLength_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboMonthlyMortgageTermLength.SelectedIndexChanged

    End Sub
End Class