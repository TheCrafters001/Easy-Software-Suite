﻿Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If My.Computer.FileSystem.FileExists(".\EasyHTML.exe") Then
            Try
                Dim pHelp As New ProcessStartInfo
                pHelp.FileName = ".\EasyHTML.exe"
                pHelp.Arguments = ""
                pHelp.UseShellExecute = True
                pHelp.WindowStyle = ProcessWindowStyle.Normal
                Dim proc As Process = Process.Start(pHelp)
                Application.Exit()
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Error")
            End Try
        ElseIf Not My.Computer.FileSystem.FileExists(".\EasyHTML.exe") Then
            MessageBox.Show("EasyHTML cannot be found. Is it installed?", "Cannot Open EasyHTML", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If My.Computer.FileSystem.FileExists(".\EasyNodeJS.exe") Then
            Try
                Dim pHelp As New ProcessStartInfo
                pHelp.FileName = ".\EasyNodeJS.exe"
                pHelp.Arguments = ""
                pHelp.UseShellExecute = True
                pHelp.WindowStyle = ProcessWindowStyle.Normal
                Dim proc As Process = Process.Start(pHelp)
                Application.Exit()
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Error")
            End Try
        ElseIf Not My.Computer.FileSystem.FileExists(".\EasyNodeJS.exe") Then
            MessageBox.Show("EasyNodeJS cannot be found. Is it installed?", "Cannot Open EasyNodeJS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If My.Computer.FileSystem.FileExists(".\EasyChangelog.exe") Then
            Try
                Dim pHelp As New ProcessStartInfo
                pHelp.FileName = ".\EasyChangelog.exe"
                pHelp.Arguments = ""
                pHelp.UseShellExecute = True
                pHelp.WindowStyle = ProcessWindowStyle.Normal
                Dim proc As Process = Process.Start(pHelp)
                Application.Exit()
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Error")
            End Try
        ElseIf Not My.Computer.FileSystem.FileExists(".\EasyChangelog.exe") Then
            MessageBox.Show("EasyChangelog cannot be found. Is it installed?", "Cannot Open EasyChangelog", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Application.Exit()
    End Sub
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Licenses.Show()
    End Sub

    Private Sub easyGit_pic_Click(sender As Object, e As EventArgs) Handles easyGit_pic.Click
        If My.Computer.FileSystem.FileExists(".\EasyGit.exe") Then
            Try
                Dim pHelp As New ProcessStartInfo
                pHelp.FileName = ".\EasyGit.exe"
                pHelp.Arguments = ""
                pHelp.UseShellExecute = True
                pHelp.WindowStyle = ProcessWindowStyle.Normal
                Dim proc As Process = Process.Start(pHelp)
                Application.Exit()
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Error")
            End Try
        ElseIf Not My.Computer.FileSystem.FileExists(".\EasyGit.exe") Then
            MessageBox.Show("EasyGit cannot be found. Is it installed?", "Cannot Open EasyHTML", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub easyPresskit_pic_Click(sender As Object, e As EventArgs) Handles easyPresskit_pic.Click
        If My.Computer.FileSystem.FileExists(".\EasyPresskit.exe") Then
            Try
                Dim pHelp As New ProcessStartInfo
                pHelp.FileName = ".\EasyPresskit.exe"
                pHelp.Arguments = ""
                pHelp.UseShellExecute = True
                pHelp.WindowStyle = ProcessWindowStyle.Normal
                Dim proc As Process = Process.Start(pHelp)
                Application.Exit()
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Error")
            End Try
        ElseIf Not My.Computer.FileSystem.FileExists(".\EasyPresskit.exe") Then
            MessageBox.Show("EasyPresskit cannot be found. Is it installed?", "Cannot Open EasyHTML", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
