Imports System.IO

Public Class Find
    Public Shared Sub Find(ByVal folderpath As String, ByVal exe As String, ByVal name As String)
        Try
            If My.Computer.FileSystem.FileExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files (x86)\" & folderpath & "\" & exe & ".exe") Then
                Lists.AddToList(name)
                Debug.WriteLine(name & " Added")
            ElseIf My.Computer.FileSystem.FileExists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) & "Program Files\" & folderpath & "\" & exe & ".exe") Then
                Lists.AddToList(name)
                Debug.WriteLine(name & " Added")
            End If
        Catch ex As Exception
            MessageBox.Show("Oops! You found an error! " & vbCrLf & ex.ToString, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Debug.WriteLine("Ran into error " & vbCrLf & ex.ToString)
        End Try
    End Sub
    Public Shared Sub FindLocalAppData(ByVal folderpath As String, ByVal exe As String, ByVal name As String)
        Try
            If My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\" & folderpath & "\" & exe & ".exe") Then
                Lists.AddToList(name)
                Debug.WriteLine(name & " Added")
            End If
        Catch ex As Exception
            MessageBox.Show("Oops! You found an error! " & vbCrLf & ex.ToString, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Debug.WriteLine("Ran into error " & vbCrLf & ex.ToString)
        End Try
    End Sub
End Class