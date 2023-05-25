<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblMonthlyMortgageTitle = New Label()
        txtMonthlyMortgageDownpayment = New TextBox()
        lblMonthlyMortgageDownpayment = New Label()
        txtMonthlyMortgageHomeValue = New TextBox()
        lblMonthlyMortgageHomeValue = New Label()
        lblMonthlyMortgageInterestRate = New Label()
        cmboMonthlyMortgageInterestRate = New ComboBox()
        cmboMonthlyMortgageTermLength = New ComboBox()
        lblMonthlyMortgageTermLength = New Label()
        btnMonthlyMortgageClear = New Button()
        btnMonthlyMortgageCalculate = New Button()
        SuspendLayout()
        ' 
        ' lblMonthlyMortgageTitle
        ' 
        lblMonthlyMortgageTitle.AutoSize = True
        lblMonthlyMortgageTitle.Font = New Font("MS Reference Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lblMonthlyMortgageTitle.Location = New Point(72, 25)
        lblMonthlyMortgageTitle.Name = "lblMonthlyMortgageTitle"
        lblMonthlyMortgageTitle.Size = New Size(463, 29)
        lblMonthlyMortgageTitle.TabIndex = 0
        lblMonthlyMortgageTitle.Text = "How Much is My Monthly Payment?"
        ' 
        ' txtMonthlyMortgageDownpayment
        ' 
        txtMonthlyMortgageDownpayment.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtMonthlyMortgageDownpayment.Location = New Point(294, 138)
        txtMonthlyMortgageDownpayment.MaxLength = 10
        txtMonthlyMortgageDownpayment.Name = "txtMonthlyMortgageDownpayment"
        txtMonthlyMortgageDownpayment.Size = New Size(140, 29)
        txtMonthlyMortgageDownpayment.TabIndex = 4
        ' 
        ' lblMonthlyMortgageDownpayment
        ' 
        lblMonthlyMortgageDownpayment.AutoSize = True
        lblMonthlyMortgageDownpayment.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblMonthlyMortgageDownpayment.Location = New Point(173, 141)
        lblMonthlyMortgageDownpayment.Name = "lblMonthlyMortgageDownpayment"
        lblMonthlyMortgageDownpayment.Size = New Size(115, 21)
        lblMonthlyMortgageDownpayment.TabIndex = 3
        lblMonthlyMortgageDownpayment.Text = "Downpayment:"
        ' 
        ' txtMonthlyMortgageHomeValue
        ' 
        txtMonthlyMortgageHomeValue.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtMonthlyMortgageHomeValue.Location = New Point(286, 94)
        txtMonthlyMortgageHomeValue.MaxLength = 10
        txtMonthlyMortgageHomeValue.Name = "txtMonthlyMortgageHomeValue"
        txtMonthlyMortgageHomeValue.Size = New Size(140, 29)
        txtMonthlyMortgageHomeValue.TabIndex = 2
        ' 
        ' lblMonthlyMortgageHomeValue
        ' 
        lblMonthlyMortgageHomeValue.AutoSize = True
        lblMonthlyMortgageHomeValue.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblMonthlyMortgageHomeValue.Location = New Point(181, 97)
        lblMonthlyMortgageHomeValue.Name = "lblMonthlyMortgageHomeValue"
        lblMonthlyMortgageHomeValue.Size = New Size(99, 21)
        lblMonthlyMortgageHomeValue.TabIndex = 1
        lblMonthlyMortgageHomeValue.Text = "House Value:"
        ' 
        ' lblMonthlyMortgageInterestRate
        ' 
        lblMonthlyMortgageInterestRate.AutoSize = True
        lblMonthlyMortgageInterestRate.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblMonthlyMortgageInterestRate.Location = New Point(212, 185)
        lblMonthlyMortgageInterestRate.Name = "lblMonthlyMortgageInterestRate"
        lblMonthlyMortgageInterestRate.Size = New Size(100, 21)
        lblMonthlyMortgageInterestRate.TabIndex = 5
        lblMonthlyMortgageInterestRate.Text = "Interest Rate:"
        ' 
        ' cmboMonthlyMortgageInterestRate
        ' 
        cmboMonthlyMortgageInterestRate.DropDownStyle = ComboBoxStyle.DropDownList
        cmboMonthlyMortgageInterestRate.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cmboMonthlyMortgageInterestRate.FormattingEnabled = True
        cmboMonthlyMortgageInterestRate.Items.AddRange(New Object() {"2.00", "2.50", "3.00", "3.50", "4.00", "4.50", "5.00", "5.50", "6.00", "6.50", "7.00", "7.50", "8.00", "8.50", "9.00", "9.50", "10.0"})
        cmboMonthlyMortgageInterestRate.Location = New Point(318, 182)
        cmboMonthlyMortgageInterestRate.Name = "cmboMonthlyMortgageInterestRate"
        cmboMonthlyMortgageInterestRate.Size = New Size(77, 29)
        cmboMonthlyMortgageInterestRate.TabIndex = 6
        ' 
        ' cmboMonthlyMortgageTermLength
        ' 
        cmboMonthlyMortgageTermLength.DropDownStyle = ComboBoxStyle.DropDownList
        cmboMonthlyMortgageTermLength.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cmboMonthlyMortgageTermLength.FormattingEnabled = True
        cmboMonthlyMortgageTermLength.Items.AddRange(New Object() {"5", "10", "15", "20", "25", "30"})
        cmboMonthlyMortgageTermLength.Location = New Point(353, 226)
        cmboMonthlyMortgageTermLength.Name = "cmboMonthlyMortgageTermLength"
        cmboMonthlyMortgageTermLength.Size = New Size(77, 29)
        cmboMonthlyMortgageTermLength.TabIndex = 8
        ' 
        ' lblMonthlyMortgageTermLength
        ' 
        lblMonthlyMortgageTermLength.AutoSize = True
        lblMonthlyMortgageTermLength.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblMonthlyMortgageTermLength.Location = New Point(176, 229)
        lblMonthlyMortgageTermLength.Name = "lblMonthlyMortgageTermLength"
        lblMonthlyMortgageTermLength.Size = New Size(171, 21)
        lblMonthlyMortgageTermLength.TabIndex = 7
        lblMonthlyMortgageTermLength.Text = "Mortgage Term Length:"
        ' 
        ' btnMonthlyMortgageClear
        ' 
        btnMonthlyMortgageClear.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnMonthlyMortgageClear.Location = New Point(306, 296)
        btnMonthlyMortgageClear.Name = "btnMonthlyMortgageClear"
        btnMonthlyMortgageClear.Size = New Size(137, 43)
        btnMonthlyMortgageClear.TabIndex = 10
        btnMonthlyMortgageClear.Text = "Clear"
        btnMonthlyMortgageClear.UseVisualStyleBackColor = True
        ' 
        ' btnMonthlyMortgageCalculate
        ' 
        btnMonthlyMortgageCalculate.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnMonthlyMortgageCalculate.Location = New Point(163, 296)
        btnMonthlyMortgageCalculate.Name = "btnMonthlyMortgageCalculate"
        btnMonthlyMortgageCalculate.Size = New Size(137, 43)
        btnMonthlyMortgageCalculate.TabIndex = 9
        btnMonthlyMortgageCalculate.Text = "Calculate"
        btnMonthlyMortgageCalculate.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(606, 387)
        Controls.Add(btnMonthlyMortgageClear)
        Controls.Add(btnMonthlyMortgageCalculate)
        Controls.Add(cmboMonthlyMortgageTermLength)
        Controls.Add(lblMonthlyMortgageTermLength)
        Controls.Add(cmboMonthlyMortgageInterestRate)
        Controls.Add(lblMonthlyMortgageInterestRate)
        Controls.Add(txtMonthlyMortgageDownpayment)
        Controls.Add(lblMonthlyMortgageDownpayment)
        Controls.Add(txtMonthlyMortgageHomeValue)
        Controls.Add(lblMonthlyMortgageHomeValue)
        Controls.Add(lblMonthlyMortgageTitle)
        Name = "Form3"
        Text = "Monthly Mortgage Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblMonthlyMortgageTitle As Label
    Friend WithEvents txtMonthlyMortgageDownpayment As TextBox
    Friend WithEvents lblMonthlyMortgageDownpayment As Label
    Friend WithEvents txtMonthlyMortgageHomeValue As TextBox
    Friend WithEvents lblMonthlyMortgageHomeValue As Label
    Friend WithEvents lblMonthlyMortgageInterestRate As Label
    Friend WithEvents cmboMonthlyMortgageInterestRate As ComboBox
    Friend WithEvents cmboMonthlyMortgageTermLength As ComboBox
    Friend WithEvents lblMonthlyMortgageTermLength As Label
    Friend WithEvents btnMonthlyMortgageClear As Button
    Friend WithEvents btnMonthlyMortgageCalculate As Button
End Class
