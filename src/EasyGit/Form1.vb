Public Class Form1
    Private Sub folderCommit_btn_Click(sender As Object, e As EventArgs) Handles folderCommit_btn.Click
        Dim result As DialogResult = folderFinder.ShowDialog()
        If result = DialogResult.Cancel Then
            '
        ElseIf result = DialogResult.OK Then
            folderCommit_txt.Text = folderFinder.SelectedPath
        End If
    End Sub

    Private Sub folderPull_btn_Click(sender As Object, e As EventArgs) Handles folderPull_btn.Click
        Dim result As DialogResult = folderFinder.ShowDialog()
        If result = DialogResult.Cancel Then
            '
        ElseIf result = DialogResult.OK Then
            folderPull_txt.Text = folderFinder.SelectedPath
        End If
    End Sub

    Private Sub commit_btn_Click(sender As Object, e As EventArgs) Handles commit_btn.Click
        If commitMessage_txt.Text = "" Then
            MessageBox.Show("Please enter a message into the Commit Message box.", "Missing text", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf folderCommit_txt.Text = "" Then
            MessageBox.Show("Please select a folder to make a commit to.", "Missing folder", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim gitCommand As New ProcessStartInfo
            gitCommand.FileName = ".\Extra\Scripts\gitCommit.bat"
            gitCommand.Arguments = """" + commitMessage_txt.Text + """ """ + folderCommit_txt.Text + """ ""push"""
            gitCommand.UseShellExecute = True
            gitCommand.WindowStyle = ProcessWindowStyle.Normal
            Dim gitProc As Process = Process.Start(gitCommand)
            gitProc.WaitForExit(False)
        End If
    End Sub

    Private Sub pull_btn_Click(sender As Object, e As EventArgs) Handles pull_btn.Click
        If folderCommit_txt.Text = "" Then
            MessageBox.Show("Please select a local repo to pull to.", "Missing folder", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim gitCommand As New ProcessStartInfo
            gitCommand.FileName = ".\Extra\Scripts\gitCommit.bat"
            gitCommand.Arguments = """NoCommit"" """ + folderCommit_txt.Text + """ ""pull"""
            gitCommand.UseShellExecute = True
            gitCommand.WindowStyle = ProcessWindowStyle.Normal
            Dim gitProc As Process = Process.Start(gitCommand)
            gitProc.WaitForExit(False)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim gitCommand As New ProcessStartInfo
        gitCommand.FileName = ".\Extra\Scripts\gitCommit.bat"
        gitCommand.Arguments = """NoCommit"" ""C:\NoFolder"" ""setuser"" """ + githubUsername_txt.Text + """ """ + githubEmail_txt.Text + """"
        gitCommand.UseShellExecute = True
        gitCommand.WindowStyle = ProcessWindowStyle.Normal
        Dim gitProc As Process = Process.Start(gitCommand)
        gitProc.WaitForExit(False)
    End Sub

    Private Sub firstTime_LBL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles firstTime_LBL.LinkClicked
        firstTime.Show()
    End Sub
End Class
