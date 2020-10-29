Public Class Logging
    Public Shared Sub AddLogEntry(ByVal text As String)
        EasyHTML.Log.Text &= text & vbCrLf
    End Sub
End Class