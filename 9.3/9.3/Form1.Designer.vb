<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.instructionsLabel = New System.Windows.Forms.Label()
        Me.inputTextBox = New System.Windows.Forms.TextBox()
        Me.depositButton = New System.Windows.Forms.Button()
        Me.withdrawButton = New System.Windows.Forms.Button()
        Me.accountBalanceLabel = New System.Windows.Forms.Label()
        Me.accountBalanceValueLabel = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'instructionsLabel
        '
        Me.instructionsLabel.AutoSize = True
        Me.instructionsLabel.Location = New System.Drawing.Point(12, 9)
        Me.instructionsLabel.Name = "instructionsLabel"
        Me.instructionsLabel.Size = New System.Drawing.Size(175, 13)
        Me.instructionsLabel.TabIndex = 0
        Me.instructionsLabel.Text = "Enter deposit or withdrawal amount:"
        '
        'inputTextBox
        '
        Me.inputTextBox.Location = New System.Drawing.Point(193, 6)
        Me.inputTextBox.Name = "inputTextBox"
        Me.inputTextBox.Size = New System.Drawing.Size(100, 20)
        Me.inputTextBox.TabIndex = 1
        '
        'depositButton
        '
        Me.depositButton.Location = New System.Drawing.Point(15, 41)
        Me.depositButton.Name = "depositButton"
        Me.depositButton.Size = New System.Drawing.Size(75, 23)
        Me.depositButton.TabIndex = 2
        Me.depositButton.Text = "Deposit"
        Me.depositButton.UseVisualStyleBackColor = True
        '
        'withdrawButton
        '
        Me.withdrawButton.Location = New System.Drawing.Point(128, 41)
        Me.withdrawButton.Name = "withdrawButton"
        Me.withdrawButton.Size = New System.Drawing.Size(75, 23)
        Me.withdrawButton.TabIndex = 3
        Me.withdrawButton.Text = "Withdraw"
        Me.withdrawButton.UseVisualStyleBackColor = True
        '
        'accountBalanceLabel
        '
        Me.accountBalanceLabel.AutoSize = True
        Me.accountBalanceLabel.Location = New System.Drawing.Point(125, 96)
        Me.accountBalanceLabel.Name = "accountBalanceLabel"
        Me.accountBalanceLabel.Size = New System.Drawing.Size(92, 13)
        Me.accountBalanceLabel.TabIndex = 4
        Me.accountBalanceLabel.Text = "Account Balance:"
        '
        'accountBalanceValueLabel
        '
        Me.accountBalanceValueLabel.Location = New System.Drawing.Point(223, 93)
        Me.accountBalanceValueLabel.Name = "accountBalanceValueLabel"
        Me.accountBalanceValueLabel.Size = New System.Drawing.Size(70, 20)
        Me.accountBalanceValueLabel.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 155)
        Me.Controls.Add(Me.accountBalanceValueLabel)
        Me.Controls.Add(Me.accountBalanceLabel)
        Me.Controls.Add(Me.withdrawButton)
        Me.Controls.Add(Me.depositButton)
        Me.Controls.Add(Me.inputTextBox)
        Me.Controls.Add(Me.instructionsLabel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents instructionsLabel As Label
    Friend WithEvents inputTextBox As TextBox
    Friend WithEvents depositButton As Button
    Friend WithEvents withdrawButton As Button
    Friend WithEvents accountBalanceLabel As Label
    Friend WithEvents accountBalanceValueLabel As TextBox
End Class
