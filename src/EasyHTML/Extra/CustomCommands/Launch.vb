Imports System.IO

Public Class Launch
#Region "HTML Preview"
    Public Shared Sub Launch(ByVal folderpath As String, ByVal exe As String, ByVal name As String)
        If My.Computer.FileSystem.FileExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files (x86)\" & folderpath & "\" & exe & ".exe") Then
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files (x86)\" & folderpath & "\" & exe & ".exe"
            pHelp.Arguments = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Temp\EasyHTML\Preview.html"""
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(pHelp)

        ElseIf My.Computer.FileSystem.FileExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files\" & folderpath & "\" & exe & ".exe") Then
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files\" & folderpath & "\" & exe & ".exe"
            pHelp.Arguments = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Temp\EasyHTML\Preview.html"""
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(pHelp)

        End If
    End Sub
    Public Shared Sub LaunchAppData(ByVal folderpath As String, ByVal exe As String, ByVal name As String)
        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\" & folderpath & "\" & exe & ".exe")) Then
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\" & folderpath & "\" & exe & ".exe"
            pHelp.Arguments = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Temp\EasyHTML\Preview.html"""
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(pHelp)
        End If
    End Sub
    Public Shared Sub LaunchBrowser(browserName As String)
        ' Solution By Joel Coehoorn https://stackoverflow.com/a/64594585/7799766
        If browserName = "Google Chrome" Then
            Launch("Google\Chrome\Application", "chrome", "Google Chrome")
        ElseIf browserName = "Mozilla FireFox" Then
            Launch("Mozilla Firefox", "firefox", "Mozilla FireFox")
        ElseIf browserName = "Microsoft Edge" Then
            Launch("Microsoft\Edge\Application", "msedge", "Microsoft Edge")
        ElseIf browserName = "Internet Explorer" Then
            Launch("Internet Explorer", "iexplore", "Internet Explorer")
        ElseIf browserName = "Opera" Then
            Launch("Opera", "Launcher", "Opera")
        ElseIf browserName = "Opera Beta" Then
            Launch("Opera Beta", "Launcher", "Opera Beta")
        ElseIf browserName = "Opera Developer" Then
            Launch("Opera Developer", "Launcher", "Opera Developer")
        End If
    End Sub
#End Region

#Region "Python Preview"
    Public Shared Sub LaunchPythonPreview(ByVal folderpath As String, ByVal exe As String, ByVal name As String)
        Try
            Dim pythonLaunch As New ProcessStartInfo
            pythonLaunch.FileName = ".\Extra\Scripts\pythonPreviewScript.bat"
            pythonLaunch.Arguments = """%USERPROFILE%\AppData\Local\Temp\EasyHTML\"""
            pythonLaunch.UseShellExecute = True
            pythonLaunch.WindowStyle = ProcessWindowStyle.Normal
            Dim pythonProc As Process = Process.Start(pythonLaunch)
            pythonProc.WaitForExit(False)
            Threading.Thread.Sleep(10000)
            If My.Computer.FileSystem.FileExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files (x86)\" & folderpath & "\" & exe & ".exe") Then
                Dim pHelp As New ProcessStartInfo
                pHelp.FileName = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files (x86)\" & folderpath & "\" & exe & ".exe"
                pHelp.Arguments = "http://localhost:8000/Preview.html"
                pHelp.UseShellExecute = True
                pHelp.WindowStyle = ProcessWindowStyle.Normal
                Dim proc As Process = Process.Start(pHelp)

            ElseIf My.Computer.FileSystem.FileExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files\" & folderpath & "\" & exe & ".exe") Then
                Dim pHelp As New ProcessStartInfo
                pHelp.FileName = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files\" & folderpath & "\" & exe & ".exe"
                pHelp.Arguments = "http://localhost:8000/Preview.html"
                pHelp.UseShellExecute = True
                pHelp.WindowStyle = ProcessWindowStyle.Normal
                Dim proc As Process = Process.Start(pHelp)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error")
        End Try
    End Sub

    Public Shared Sub PythonLaunchBrowser(browserName As String)
        ' Solution By Joel Coehoorn https://stackoverflow.com/a/64594585/7799766
        If browserName = "Google Chrome" Then
            LaunchPythonPreview("Google\Chrome\Application", "chrome", "Google Chrome")
        ElseIf browserName = "Mozilla FireFox" Then
            LaunchPythonPreview("Mozilla Firefox", "firefox", "Mozilla FireFox")
        ElseIf browserName = "Microsoft Edge" Then
            LaunchPythonPreview("Microsoft\Edge\Application", "msedge", "Microsoft Edge")
        ElseIf browserName = "Internet Explorer" Then
            LaunchPythonPreview("Internet Explorer", "iexplore", "Internet Explorer")
        ElseIf browserName = "Opera" Then
            LaunchPythonPreview("Opera", "Launcher", "Opera")
        ElseIf browserName = "Opera Beta" Then
            LaunchPythonPreview("Opera Beta", "Launcher", "Opera Beta")
        ElseIf browserName = "Opera Developer" Then
            LaunchPythonPreview("Opera Developer", "Launcher", "Opera Developer")
        End If
    End Sub
#End Region
End Class
