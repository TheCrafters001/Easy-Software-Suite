Public Class Logging
    Public Shared Sub AddLogEntry(ByVal text As String)
        EasyNodeJS.Log.Text &= text & vbCrLf
    End Sub
End Class