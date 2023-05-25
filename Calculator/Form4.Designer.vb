<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        lblTitle4 = New Label()
        lblYears = New Label()
        txtHouseValue = New TextBox()
        lblHouseValue = New Label()
        cmboYears = New ComboBox()
        btnClear = New Button()
        btnCalculate = New Button()
        SuspendLayout()
        ' 
        ' lblTitle4
        ' 
        lblTitle4.AutoSize = True
        lblTitle4.Font = New Font("MS Reference Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitle4.Location = New Point(65, 25)
        lblTitle4.Name = "lblTitle4"
        lblTitle4.Size = New Size(476, 29)
        lblTitle4.TabIndex = 0
        lblTitle4.Text = "How Much Will My House Be Worth?"
        ' 
        ' lblYears
        ' 
        lblYears.AutoSize = True
        lblYears.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblYears.Location = New Point(175, 154)
        lblYears.Name = "lblYears"
        lblYears.Size = New Size(174, 21)
        lblYears.TabIndex = 3
        lblYears.Text = "Select How Many Years:"
        ' 
        ' txtHouseValue
        ' 
        txtHouseValue.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtHouseValue.Location = New Point(320, 101)
        txtHouseValue.MaxLength = 10
        txtHouseValue.Name = "txtHouseValue"
        txtHouseValue.Size = New Size(140, 29)
        txtHouseValue.TabIndex = 2
        ' 
        ' lblHouseValue
        ' 
        lblHouseValue.AutoSize = True
        lblHouseValue.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblHouseValue.Location = New Point(143, 104)
        lblHouseValue.Name = "lblHouseValue"
        lblHouseValue.Size = New Size(171, 21)
        lblHouseValue.TabIndex = 1
        lblHouseValue.Text = "Estimated House Value:"
        ' 
        ' cmboYears
        ' 
        cmboYears.DropDownStyle = ComboBoxStyle.DropDownList
        cmboYears.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cmboYears.FormattingEnabled = True
        cmboYears.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "15", "20", "25", "30", "35"})
        cmboYears.Location = New Point(355, 151)
        cmboYears.Name = "cmboYears"
        cmboYears.Size = New Size(77, 29)
        cmboYears.TabIndex = 4
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnClear.Location = New Point(306, 210)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(137, 43)
        btnClear.TabIndex = 6
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnCalculate.Location = New Point(163, 210)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(137, 43)
        btnCalculate.TabIndex = 5
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(606, 321)
        Controls.Add(btnClear)
        Controls.Add(btnCalculate)
        Controls.Add(cmboYears)
        Controls.Add(lblYears)
        Controls.Add(txtHouseValue)
        Controls.Add(lblHouseValue)
        Controls.Add(lblTitle4)
        Name = "Form4"
        Text = "Future Home Value Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle4 As Label
    Friend WithEvents lblYears As Label
    Friend WithEvents txtHouseValue As TextBox
    Friend WithEvents lblHouseValue As Label
    Friend WithEvents cmboYears As ComboBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalculate As Button
End Class
