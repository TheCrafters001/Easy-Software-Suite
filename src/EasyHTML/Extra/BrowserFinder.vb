Imports System.IO

Public Class BrowserFinder
    Public Shared Sub Finder()
        Find.Find("Google\Chrome\Application", "chrome", "Google Chrome")
        Find.Find("Mozilla Firefox", "firefox", "Mozilla FireFox")
        Find.Find("Microsoft\Edge\Application", "msedge", "Microsoft Edge")
        Find.Find("Opera", "Launcher", "Opera")
        Find.Find("Opera Beta", "Launcher", "Opera Beta")
        Find.Find("Opera Developer", "Launcher", "Opera Developer")
    End Sub
End Class
