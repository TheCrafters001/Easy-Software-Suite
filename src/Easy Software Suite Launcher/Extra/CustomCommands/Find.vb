Imports System.IO

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
            MessageBox.Show("Oops! You found an error! " & vbCrLf & ex.ToString, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Debug.WriteLine("Ran into error " & vbCrLf & ex.ToString)
        End Try
    End Sub
End Class