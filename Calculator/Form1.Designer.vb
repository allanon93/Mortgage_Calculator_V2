<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblMortgageCalculatorAppTitle = New Label()
        btnMonthlyMortgageTotal = New Button()
        btnTotalMortgage = New Button()
        lblTotalMortgage = New Label()
        lblMonthlyMortgageTotal = New Label()
        lblHouseAppreciation = New Label()
        btnHouseAppreciation = New Button()
        SuspendLayout()
        ' 
        ' lblMortgageCalculatorAppTitle
        ' 
        lblMortgageCalculatorAppTitle.AutoSize = True
        lblMortgageCalculatorAppTitle.Font = New Font("MS Reference Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lblMortgageCalculatorAppTitle.Location = New Point(40, 25)
        lblMortgageCalculatorAppTitle.Name = "lblMortgageCalculatorAppTitle"
        lblMortgageCalculatorAppTitle.Size = New Size(329, 29)
        lblMortgageCalculatorAppTitle.TabIndex = 0
        lblMortgageCalculatorAppTitle.Text = "Mortgage Calculator App"
        ' 
        ' btnMonthlyMortgageTotal
        ' 
        btnMonthlyMortgageTotal.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnMonthlyMortgageTotal.Location = New Point(136, 216)
        btnMonthlyMortgageTotal.Name = "btnMonthlyMortgageTotal"
        btnMonthlyMortgageTotal.Size = New Size(137, 43)
        btnMonthlyMortgageTotal.TabIndex = 4
        btnMonthlyMortgageTotal.Text = "Click here"
        btnMonthlyMortgageTotal.UseVisualStyleBackColor = True
        ' 
        ' btnTotalMortgage
        ' 
        btnTotalMortgage.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnTotalMortgage.Location = New Point(136, 128)
        btnTotalMortgage.Name = "btnTotalMortgage"
        btnTotalMortgage.Size = New Size(137, 43)
        btnTotalMortgage.TabIndex = 2
        btnTotalMortgage.Text = "Click here"
        btnTotalMortgage.UseVisualStyleBackColor = True
        ' 
        ' lblTotalMortgage
        ' 
        lblTotalMortgage.AutoSize = True
        lblTotalMortgage.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblTotalMortgage.Location = New Point(94, 95)
        lblTotalMortgage.Name = "lblTotalMortgage"
        lblTotalMortgage.Size = New Size(220, 21)
        lblTotalMortgage.TabIndex = 1
        lblTotalMortgage.Text = "How much house can I afford?"
        ' 
        ' lblMonthlyMortgageTotal
        ' 
        lblMonthlyMortgageTotal.AutoSize = True
        lblMonthlyMortgageTotal.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblMonthlyMortgageTotal.Location = New Point(54, 183)
        lblMonthlyMortgageTotal.Name = "lblMonthlyMortgageTotal"
        lblMonthlyMortgageTotal.Size = New Size(301, 21)
        lblMonthlyMortgageTotal.TabIndex = 3
        lblMonthlyMortgageTotal.Text = "How much will my monthly mortgage be?"
        ' 
        ' lblHouseAppreciation
        ' 
        lblHouseAppreciation.AutoSize = True
        lblHouseAppreciation.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblHouseAppreciation.Location = New Point(35, 271)
        lblHouseAppreciation.Name = "lblHouseAppreciation"
        lblHouseAppreciation.Size = New Size(338, 21)
        lblHouseAppreciation.TabIndex = 5
        lblHouseAppreciation.Text = "How much will my house appreciate over time?"
        ' 
        ' btnHouseAppreciation
        ' 
        btnHouseAppreciation.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnHouseAppreciation.Location = New Point(136, 304)
        btnHouseAppreciation.Name = "btnHouseAppreciation"
        btnHouseAppreciation.Size = New Size(137, 43)
        btnHouseAppreciation.TabIndex = 6
        btnHouseAppreciation.Text = "Click here"
        btnHouseAppreciation.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(409, 386)
        Controls.Add(lblHouseAppreciation)
        Controls.Add(btnHouseAppreciation)
        Controls.Add(lblMonthlyMortgageTotal)
        Controls.Add(lblTotalMortgage)
        Controls.Add(btnTotalMortgage)
        Controls.Add(btnMonthlyMortgageTotal)
        Controls.Add(lblMortgageCalculatorAppTitle)
        Name = "Form1"
        Text = "Mortgage Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblMortgageCalculatorAppTitle As Label
    Friend WithEvents btnMonthlyMortgageTotal As Button
    Friend WithEvents btnTotalMortgage As Button
    Friend WithEvents lblTotalMortgage As Label
    Friend WithEvents lblMonthlyMortgageTotal As Label
    Friend WithEvents lblHouseAppreciation As Label
    Friend WithEvents btnHouseAppreciation As Button
End Class
