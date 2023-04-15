<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InterestCalculator
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
        Me.lblPrinciple = New System.Windows.Forms.Label()
        Me.txtbxPrinciple = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.chbSimple = New System.Windows.Forms.RadioButton()
        Me.txtbxRate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbxTime = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chbCompound = New System.Windows.Forms.RadioButton()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.grbOutput = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbxAmt = New System.Windows.Forms.TextBox()
        Me.txtbxInt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grbOutput.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPrinciple
        '
        Me.lblPrinciple.AutoSize = True
        Me.lblPrinciple.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblPrinciple.Location = New System.Drawing.Point(13, 9)
        Me.lblPrinciple.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrinciple.Name = "lblPrinciple"
        Me.lblPrinciple.Size = New System.Drawing.Size(68, 20)
        Me.lblPrinciple.TabIndex = 0
        Me.lblPrinciple.Text = "Principle"
        '
        'txtbxPrinciple
        '
        Me.txtbxPrinciple.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtbxPrinciple.Location = New System.Drawing.Point(89, 3)
        Me.txtbxPrinciple.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbxPrinciple.Name = "txtbxPrinciple"
        Me.txtbxPrinciple.Size = New System.Drawing.Size(148, 26)
        Me.txtbxPrinciple.TabIndex = 1
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(17, 145)
        Me.btnCalc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(112, 35)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'chbSimple
        '
        Me.chbSimple.AutoSize = True
        Me.chbSimple.Location = New System.Drawing.Point(17, 111)
        Me.chbSimple.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chbSimple.Name = "chbSimple"
        Me.chbSimple.Size = New System.Drawing.Size(75, 24)
        Me.chbSimple.TabIndex = 4
        Me.chbSimple.TabStop = True
        Me.chbSimple.Text = "Simple"
        Me.chbSimple.UseVisualStyleBackColor = True
        '
        'txtbxRate
        '
        Me.txtbxRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtbxRate.Location = New System.Drawing.Point(89, 39)
        Me.txtbxRate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbxRate.Name = "txtbxRate"
        Me.txtbxRate.Size = New System.Drawing.Size(148, 26)
        Me.txtbxRate.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(13, 45)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "R.O.I (%)"
        '
        'txtbxTime
        '
        Me.txtbxTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtbxTime.Location = New System.Drawing.Point(89, 75)
        Me.txtbxTime.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbxTime.Name = "txtbxTime"
        Me.txtbxTime.Size = New System.Drawing.Size(148, 26)
        Me.txtbxTime.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(13, 81)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Time (Yrs)"
        '
        'chbCompound
        '
        Me.chbCompound.AutoSize = True
        Me.chbCompound.Location = New System.Drawing.Point(100, 111)
        Me.chbCompound.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chbCompound.Name = "chbCompound"
        Me.chbCompound.Size = New System.Drawing.Size(123, 24)
        Me.chbCompound.TabIndex = 5
        Me.chbCompound.TabStop = True
        Me.chbCompound.Text = "Compounded"
        Me.chbCompound.UseVisualStyleBackColor = True
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(6, 22)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(65, 20)
        Me.lblAmount.TabIndex = 9
        Me.lblAmount.Text = "Amount"
        '
        'grbOutput
        '
        Me.grbOutput.Controls.Add(Me.txtbxInt)
        Me.grbOutput.Controls.Add(Me.txtbxAmt)
        Me.grbOutput.Controls.Add(Me.Label3)
        Me.grbOutput.Controls.Add(Me.lblAmount)
        Me.grbOutput.Location = New System.Drawing.Point(256, 9)
        Me.grbOutput.Name = "grbOutput"
        Me.grbOutput.Size = New System.Drawing.Size(189, 180)
        Me.grbOutput.TabIndex = 10
        Me.grbOutput.TabStop = False
        Me.grbOutput.Text = "Interest"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Interest"
        '
        'txtbxAmt
        '
        Me.txtbxAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtbxAmt.Location = New System.Drawing.Point(10, 47)
        Me.txtbxAmt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbxAmt.Name = "txtbxAmt"
        Me.txtbxAmt.ReadOnly = True
        Me.txtbxAmt.Size = New System.Drawing.Size(148, 26)
        Me.txtbxAmt.TabIndex = 0
        '
        'txtbxInt
        '
        Me.txtbxInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtbxInt.Location = New System.Drawing.Point(11, 103)
        Me.txtbxInt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbxInt.Name = "txtbxInt"
        Me.txtbxInt.ReadOnly = True
        Me.txtbxInt.Size = New System.Drawing.Size(148, 26)
        Me.txtbxInt.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(137, 145)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'InterestCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 194)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chbCompound)
        Me.Controls.Add(Me.txtbxTime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtbxRate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chbSimple)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtbxPrinciple)
        Me.Controls.Add(Me.lblPrinciple)
        Me.Controls.Add(Me.grbOutput)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "InterestCalculator"
        Me.Text = "Interest Calculator"
        Me.grbOutput.ResumeLayout(False)
        Me.grbOutput.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrinciple As Label
    Friend WithEvents txtbxPrinciple As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents chbSimple As RadioButton
    Friend WithEvents txtbxRate As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbxTime As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chbCompound As RadioButton
    Friend WithEvents lblAmount As Label
    Friend WithEvents grbOutput As GroupBox
    Friend WithEvents txtbxInt As TextBox
    Friend WithEvents txtbxAmt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
