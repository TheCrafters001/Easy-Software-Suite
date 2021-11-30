Imports System.IO
Imports Errorlogger.Logger

Public Class Find
    Public Shared Sub Find(ByVal name As String)
        Try
            If My.Computer.FileSystem.FileExists(".\" & name & ".exe") Then
                Lists.AddToList(name)
                Debug.WriteLine(name & " Added")
            Else
                ' Do nothing.
            End If
        Catch ex As Exception
            Input(ex.ToString)
            MessageBox.Show("Oh, seems like you ran into an error. The error was logged in the following file: " & Environment.CurrentDirectory & "\ErrorLog.txt", "Error")
        End Try
    End Sub
End Class