Imports Microsoft.Web.WebView2.Core

Public Class previewWindow
    Private Sub previewWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) ' Solution By Joel Coehoorn https://stackoverflow.com/a/64594585/7799766
        path = IO.Path.Combine(path, "Temp\EasyHTML") ' Solution By Joel Coehoorn https://stackoverflow.com/a/64594585/7799766
        If preview_Web IsNot Nothing AndAlso preview_Web.CoreWebView2 IsNot Nothing Then
            preview_Web.CoreWebView2.Navigate(path & "\Preview.html")
        End If
    End Sub
End Class