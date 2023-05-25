<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        lblHouseAffordabilityTitle = New Label()
        lblMonthlyIncome = New Label()
        txtMonthlyIncome = New TextBox()
        txtMonthlyExpenses = New TextBox()
        lblMonthlyExpenses = New Label()
        btnTotalMortgageCalculate = New Button()
        btnTotalMortgageClear = New Button()
        SuspendLayout()
        ' 
        ' lblHouseAffordabilityTitle
        ' 
        lblHouseAffordabilityTitle.AutoSize = True
        lblHouseAffordabilityTitle.Font = New Font("MS Reference Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lblHouseAffordabilityTitle.Location = New Point(57, 25)
        lblHouseAffordabilityTitle.Name = "lblHouseAffordabilityTitle"
        lblHouseAffordabilityTitle.Size = New Size(627, 29)
        lblHouseAffordabilityTitle.TabIndex = 0
        lblHouseAffordabilityTitle.Text = "How Large of A Monthly Mortgage Can I Afford?"
        ' 
        ' lblMonthlyIncome
        ' 
        lblMonthlyIncome.AutoSize = True
        lblMonthlyIncome.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblMonthlyIncome.Location = New Point(146, 95)
        lblMonthlyIncome.Name = "lblMonthlyIncome"
        lblMonthlyIncome.Size = New Size(303, 21)
        lblMonthlyIncome.TabIndex = 1
        lblMonthlyIncome.Text = "Monthly Household Income (before taxes):"
        ' 
        ' txtMonthlyIncome
        ' 
        txtMonthlyIncome.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtMonthlyIncome.Location = New Point(455, 92)
        txtMonthlyIncome.MaxLength = 10
        txtMonthlyIncome.Name = "txtMonthlyIncome"
        txtMonthlyIncome.Size = New Size(140, 29)
        txtMonthlyIncome.TabIndex = 2
        ' 
        ' txtMonthlyExpenses
        ' 
        txtMonthlyExpenses.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtMonthlyExpenses.Location = New Point(505, 136)
        txtMonthlyExpenses.MaxLength = 10
        txtMonthlyExpenses.Name = "txtMonthlyExpenses"
        txtMonthlyExpenses.Size = New Size(140, 29)
        txtMonthlyExpenses.TabIndex = 4
        ' 
        ' lblMonthlyExpenses
        ' 
        lblMonthlyExpenses.AutoSize = True
        lblMonthlyExpenses.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblMonthlyExpenses.Location = New Point(96, 139)
        lblMonthlyExpenses.Name = "lblMonthlyExpenses"
        lblMonthlyExpenses.Size = New Size(403, 21)
        lblMonthlyExpenses.TabIndex = 3
        lblMonthlyExpenses.Text = "Monthly Household Expenses (excluding rent/mortgage):"
        ' 
        ' btnTotalMortgageCalculate
        ' 
        btnTotalMortgageCalculate.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnTotalMortgageCalculate.Location = New Point(230, 203)
        btnTotalMortgageCalculate.Name = "btnTotalMortgageCalculate"
        btnTotalMortgageCalculate.Size = New Size(137, 43)
        btnTotalMortgageCalculate.TabIndex = 7
        btnTotalMortgageCalculate.Text = "Calculate"
        btnTotalMortgageCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnTotalMortgageClear
        ' 
        btnTotalMortgageClear.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnTotalMortgageClear.Location = New Point(373, 203)
        btnTotalMortgageClear.Name = "btnTotalMortgageClear"
        btnTotalMortgageClear.Size = New Size(137, 43)
        btnTotalMortgageClear.TabIndex = 8
        btnTotalMortgageClear.Text = "Clear"
        btnTotalMortgageClear.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(740, 289)
        Controls.Add(btnTotalMortgageClear)
        Controls.Add(btnTotalMortgageCalculate)
        Controls.Add(txtMonthlyExpenses)
        Controls.Add(lblMonthlyExpenses)
        Controls.Add(txtMonthlyIncome)
        Controls.Add(lblMonthlyIncome)
        Controls.Add(lblHouseAffordabilityTitle)
        Name = "Form2"
        Text = "Home Affordability Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHouseAffordabilityTitle As Label
    Friend WithEvents lblMonthlyIncome As Label
    Friend WithEvents txtMonthlyIncome As TextBox
    Friend WithEvents txtMonthlyExpenses As TextBox
    Friend WithEvents lblMonthlyExpenses As Label
    Friend WithEvents btnTotalMortgageCalculate As Button
    Friend WithEvents btnTotalMortgageClear As Button
End Class
