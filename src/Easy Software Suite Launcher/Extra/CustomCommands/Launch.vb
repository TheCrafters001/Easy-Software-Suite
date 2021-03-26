Imports System.IO
Imports ErrorLogger.Logger

Public Class Launch
    Public Shared Sub Launch(ByVal name As String)
        ' The only reason why I check if the file exist, is either for debugging,
        ' or if someone tries to change the components while the app is running.
        If My.Computer.FileSystem.FileExists(".\" & name & ".exe") Then
            Try
                Dim pHelp As New ProcessStartInfo
                pHelp.FileName = ".\" & name & ".exe"
                pHelp.Arguments = ""
                pHelp.UseShellExecute = True
                pHelp.WindowStyle = ProcessWindowStyle.Normal
                Dim proc As Process = Process.Start(pHelp)
                Application.Exit()
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Error")
            End Try
        ElseIf Not My.Computer.FileSystem.FileExists(".\" & name & ".exe") Then
            Input("Non-fatal error: " & name & " cannot be found. Is it installed?")
            MessageBox.Show(name & " cannot be found. Is it installed?", "Cannot Open " & name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
