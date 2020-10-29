Imports System.IO

Public Class Launch
    Declare Function Wow64DisableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean
    Declare Function Wow64EnableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean
    Public Shared Sub Launch(ByVal folderpath As String, ByVal exe As String, ByVal name As String)
        If My.Computer.FileSystem.FileExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files (x86)\" & folderpath & "\" & exe & ".exe") Then
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files (x86)\" & folderpath & "\" & exe & ".exe"
            pHelp.Arguments = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Temp\EasyHTML\Preview.html"""
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(pHelp)
            Logging.AddLogEntry(name & " Launched")
        ElseIf My.Computer.FileSystem.FileExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files\" & folderpath & "\" & exe & ".exe") Then
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files\" & folderpath & "\" & exe & ".exe"
            pHelp.Arguments = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Temp\EasyHTML\Preview.html"""
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(pHelp)
            Logging.AddLogEntry(name & " Launched")
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
            Logging.AddLogEntry(name & " added")
        End If
    End Sub
End Class
