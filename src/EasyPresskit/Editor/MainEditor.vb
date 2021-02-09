Public Class MainEditor
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = ".\Easy Software Suite Launcher.exe"
            pHelp.Arguments = ""
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(pHelp)
            Application.Exit()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error")
        End Try
    End Sub
End Class
