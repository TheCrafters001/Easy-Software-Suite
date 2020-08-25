Imports System.IO

#Region "Finder"
Public Class BrowserFinder
    Public Shared Sub Finder()
        '
        ' Google Chrome
        '
        If My.Computer.FileSystem.FileExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files (x86)\Google\Chrome\Application\chrome.exe") Then
            EasyHTML.BrowserListing_cmb.Items.Add("Google Chrome")
            Debug.WriteLine("Google Chrome Added")
        ElseIf My.Computer.FileSystem.FileExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files\Google\Chrome\Application\chrome.exe") Then
            EasyHTML.BrowserListing_cmb.Items.Add("Google Chrome")
            Debug.WriteLine("Google Chrome Added")
        End If
        '
        ' Internet Explorer
        '
        If My.Computer.FileSystem.FileExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files (x86)\Internet Explorer\iexplore.exe") Then
            EasyHTML.BrowserListing_cmb.Items.Add("Internet Explorer")
            Debug.WriteLine("IE Added")
        ElseIf My.Computer.FileSystem.FileExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files\Internet Explorer\iexplore.exe") Then
            EasyHTML.BrowserListing_cmb.Items.Add("Internet Explorer")
            Debug.WriteLine("IE Added")
        End If
        '
        ' FireFox
        '
        If My.Computer.FileSystem.FileExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files (x86)\Mozilla Firefox\firefox.exe") Then
            EasyHTML.BrowserListing_cmb.Items.Add("Mozilla FireFox")
            Debug.WriteLine("Mozilla FireFox Added")
        ElseIf My.Computer.FileSystem.FileExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files\Mozilla Firefox\firefox.exe") Then
            EasyHTML.BrowserListing_cmb.Items.Add("Mozilla FireFox")
            Debug.WriteLine("Mozilla FireFox Added")
        End If
        '
        ' Edge
        '
        If My.Computer.FileSystem.FileExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files (x86)\Microsoft\Edge\Application\msedge.exe") Then
            EasyHTML.BrowserListing_cmb.Items.Add("Microsoft Edge")
            Debug.WriteLine("Microsoft Edge Added")
        ElseIf My.Computer.FileSystem.FileExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files\Microsoft\Edge\Application\msedge.exe") Then
            EasyHTML.BrowserListing_cmb.Items.Add("Mozilla FireFox")
            Debug.WriteLine("Microsoft Edge Added")
        End If

    End Sub
#End Region

    Public Shared Sub Execute()

    End Sub

End Class
