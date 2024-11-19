<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        btnCalculate = New Button()
        txtDisplay = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        Button10 = New Button()
        Button11 = New Button()
        Button12 = New Button()
        Button13 = New Button()
        lblSimpleCalculator = New Label()
        Button14 = New Button()
        SuspendLayout()
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(98, 217)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(93, 36)
        btnCalculate.TabIndex = 0
        btnCalculate.Text = "0"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' txtDisplay
        ' 
        txtDisplay.Location = New Point(116, 47)
        txtDisplay.Name = "txtDisplay"
        txtDisplay.Size = New Size(399, 23)
        txtDisplay.TabIndex = 1
        txtDisplay.Text = "0"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(98, 98)
        Button1.Name = "Button1"
        Button1.Size = New Size(93, 36)
        Button1.TabIndex = 2
        Button1.Text = "1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(215, 98)
        Button2.Name = "Button2"
        Button2.Size = New Size(93, 36)
        Button2.TabIndex = 2
        Button2.Text = "2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(332, 98)
        Button3.Name = "Button3"
        Button3.Size = New Size(93, 36)
        Button3.TabIndex = 2
        Button3.Text = "3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(449, 98)
        Button4.Name = "Button4"
        Button4.Size = New Size(93, 36)
        Button4.TabIndex = 2
        Button4.Text = "+"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(98, 137)
        Button5.Name = "Button5"
        Button5.Size = New Size(93, 36)
        Button5.TabIndex = 2
        Button5.Text = "4"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(215, 137)
        Button6.Name = "Button6"
        Button6.Size = New Size(93, 36)
        Button6.TabIndex = 2
        Button6.Text = "5"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(332, 137)
        Button7.Name = "Button7"
        Button7.Size = New Size(93, 36)
        Button7.TabIndex = 2
        Button7.Text = "6"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(449, 137)
        Button8.Name = "Button8"
        Button8.Size = New Size(93, 36)
        Button8.TabIndex = 2
        Button8.Text = "-"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(98, 175)
        Button9.Name = "Button9"
        Button9.Size = New Size(93, 36)
        Button9.TabIndex = 2
        Button9.Text = "7"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button10
        ' 
        Button10.Location = New Point(215, 175)
        Button10.Name = "Button10"
        Button10.Size = New Size(93, 36)
        Button10.TabIndex = 2
        Button10.Text = "8"
        Button10.UseVisualStyleBackColor = True
        ' 
        ' Button11
        ' 
        Button11.Location = New Point(332, 175)
        Button11.Name = "Button11"
        Button11.Size = New Size(93, 36)
        Button11.TabIndex = 2
        Button11.Text = "9"
        Button11.UseVisualStyleBackColor = True
        ' 
        ' Button12
        ' 
        Button12.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button12.Location = New Point(449, 175)
        Button12.Name = "Button12"
        Button12.Size = New Size(93, 36)
        Button12.TabIndex = 2
        Button12.Text = "."
        Button12.TextAlign = ContentAlignment.TopCenter
        Button12.UseVisualStyleBackColor = True
        ' 
        ' Button13
        ' 
        Button13.Location = New Point(332, 217)
        Button13.Name = "Button13"
        Button13.Size = New Size(210, 36)
        Button13.TabIndex = 0
        Button13.Text = "Calculate"
        Button13.UseVisualStyleBackColor = True
        ' 
        ' lblSimpleCalculator
        ' 
        lblSimpleCalculator.AutoSize = True
        lblSimpleCalculator.Location = New Point(12, 9)
        lblSimpleCalculator.Name = "lblSimpleCalculator"
        lblSimpleCalculator.Size = New Size(100, 15)
        lblSimpleCalculator.TabIndex = 3
        lblSimpleCalculator.Text = "Simple Calculator"
        ' 
        ' Button14
        ' 
        Button14.BackColor = SystemColors.GradientActiveCaption
        Button14.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button14.Location = New Point(215, 217)
        Button14.Name = "Button14"
        Button14.Size = New Size(93, 36)
        Button14.TabIndex = 4
        Button14.Text = "C"
        Button14.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(619, 321)
        Controls.Add(Button14)
        Controls.Add(lblSimpleCalculator)
        Controls.Add(Button12)
        Controls.Add(Button11)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(Button10)
        Controls.Add(Button4)
        Controls.Add(Button6)
        Controls.Add(Button9)
        Controls.Add(Button3)
        Controls.Add(Button5)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(txtDisplay)
        Controls.Add(Button13)
        Controls.Add(btnCalculate)
        Name = "Form1"
        RightToLeft = RightToLeft.Yes
        Text = "Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents lblSimpleCalculator As Label
    Friend WithEvents Button14 As Button

End Class
