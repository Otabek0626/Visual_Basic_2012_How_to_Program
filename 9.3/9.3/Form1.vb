Public Class account
    Private balanceValue As Decimal
    Public Sub New(Optional initialBalance As Decimal = 0D)
        If initialBalance < 0D Then
            Throw New ArgumentOutOfRangeException("Initial bal ance must be greater than or equal to 0. ")
        End If
        balanceValue = initialBalance
    End Sub

    Public Sub Deposit(depositAmount As Decimal)
        If depositAmount <= 0D Then
            Throw New ArgumentOutOfRangeException("Deposit amount must be positive.")
        End If
        balanceValue += depositAmount
    End Sub
    Public Sub Withdraw(withdrawalAmount As Decimal)
        If withdrawalAmount > Balance Then
            Throw New ArgumentOutOfRangeException("Withdrawal amount must be less than or equal to balance. ")
        ElseIf withdrawalAmount <= 0D Then
            Throw New ArgumentOutOfRangeException("Withrawal amount must be positive. ")
        End If
        balanceValue -= withdrawalAmount
    End Sub
    Public ReadOnly Property Balance As Decimal
        Get
            Return balanceValue
        End Get
    End Property
End Class

Public Class Form1
    Private account As New account()
    Private Sub Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        accountBalanceValueLabel.Text = String.Format("{0:C}", account.Balance)
    End Sub
    Private Sub depositButton_Click(sender As Object, e As EventArgs) Handles depositButton.Click
        Try
            Dim depositAmount As Decimal = Convert.ToDecimal(inputTextBox.Text)
            account.Deposit(depositAmount)
            accountBalanceValueLabel.Text = String.Format("{0:C}", account.Balance)
        Catch ex As Exception
            MessageBox.Show("Deposit amount must be positi ve.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        inputTextBox.Clear()
        inputTextBox.Focus()
    End Sub
    Private Sub withdrawButton_Click(sender As Object, e As EventArgs) Handles withdrawButton.Click
        Try
            Dim withdrawalAmount As Decimal = Convert.ToDecimal(inputTextBox.Text)
            account.Withdraw(withdrawalAmount)
            accountBalanceValueLabel.Text = String.Format("{0:C}", account.Balance)
        Catch ex As Exception
            MessageBox.Show("Withdrawal amount must be greater than 0 " & "and less than or equal to the account bal ance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        inputTextBox.Clear()
        inputTextBox.Focus()
    End Sub

End Class
