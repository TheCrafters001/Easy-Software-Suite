Imports System.IO

Public Class Launch
    Declare Function Wow64DisableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean
    Declare Function Wow64EnableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean
    Public Shared Sub Launch(folderpath As String, exe As String, name As String)
        ' Solution By Joel Coehoorn https://stackoverflow.com/a/64594585/7799766
        Dim htmlPath As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
        htmlPath = Path.Combine(htmlPath, "Temp", "EasyHTML", "Preview.html")

        Launch(folderpath, exe, name, htmlPath)
    End Sub

    Public Shared Sub Launch(folderpath As String, exe As String, name As String, argument As String)
        ' Solution By Joel Coehoorn https://stackoverflow.com/a/64594585/7799766
        Dim exePath As String = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System))
        exePath = Path.Combine(exePath, "Program Files (x86)", folderpath, exe & ".exe")

        If Not File.Exists(exePath) Then
            exePath = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System))
            exePath = Path.Combine(exePath, "Program Files", folderpath, exe & ".exe")
        End If

        Dim pHelp As New ProcessStartInfo
        pHelp.FileName = Path.Combine(exePath, exe & ".exe")
        If Not String.IsNullOrWhiteSpace(argument) Then
            pHelp.Arguments = argument
        End If
        pHelp.UseShellExecute = True
        pHelp.WindowStyle = ProcessWindowStyle.Normal
        Dim proc As Process = Process.Start(pHelp)
        Logging.AddLogEntry(name & " Launched")
    End Sub
    Public Shared Sub LaunchBrowser(browserName As String, url As String)
        ' Solution By Joel Coehoorn https://stackoverflow.com/a/64594585/7799766
        If browserName = "Google Chrome" Then
            Launch("Google\Chrome\Application", "chrome", "Google Chrome", url)
        ElseIf browserName = "Mozilla FireFox" Then
            Launch("Mozilla Firefox", "firefox", "Mozilla FireFox", url)
        ElseIf browserName = "Microsoft Edge" Then
            Launch("Microsoft\Edge\Application", "msedge", "Microsoft Edge", url)
        ElseIf browserName = "Internet Explorer" Then
            Launch("Internet Explorer", "iexplore", "Internet Explorer", url)
        ElseIf browserName = "Opera" Then
            Launch("Opera", "Launcher", "Opera", url)
        ElseIf browserName = "Opera Beta" Then
            Launch("Opera Beta", "Launcher", "Opera Beta", url)
        ElseIf browserName = "Opera Developer" Then
            Launch("Opera Developer", "Launcher", "Opera Developer", url)
        End If
    End Sub
End Class
