Imports System.Windows.Forms

Public Class BugReport

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub BugReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Generate Dynamic Error Report
        RichTextBox1.Text = "Thank you for using EasyHTML. It seems like you have encountered an error. Send the following information to the email listed below." & vbCrLf & vbCrLf _
            & "Hi, I have encountered the following error: " & TextBox1.Text & ". Can you please patch this out?" & vbCrLf & vbCrLf _
            & "Send report to bug-report@thecrafters001.ga"
    End Sub
End Class
