Module CodeExtension
    ' Solution from https://social.msdn.microsoft.com/Forums/vstudio/en-US/fdb5a2a8-be70-4782-b5e9-8f89126942e0/how-to-save-listbox-items-to-a-file?forum=vbgeneral

    ''' <summary>
    ''' Save unbound items to a file
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="FileName">File to save items too</param>
    ''' <remarks></remarks>
    <System.Runtime.CompilerServices.Extension()>
    Public Sub SaveToFile(ByVal sender As ListBox.ObjectCollection, ByVal FileName As String)
        System.IO.File.WriteAllLines(FileName,
            (From Row In sender.Cast(Of String)() Select Row).ToArray())
    End Sub
    ''' <summary>
    ''' Save unbound items to a file
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="FileName">File to save items too</param>
    ''' <param name="Append">Indicates whether new contents should be appended to existing file</param>
    ''' <remarks></remarks>
    <System.Runtime.CompilerServices.Extension()>
    Public Sub SaveToFile(ByVal sender As ListBox.ObjectCollection, ByVal FileName As String, ByVal Append As Boolean)
        Dim Items = (From Row In sender.Cast(Of String)() Select Row).ToList
        If Append Then
            If IO.File.Exists(FileName) Then
                Dim CurrentFileLines = IO.File.ReadAllLines(FileName).ToList
                Items.AddRange(CurrentFileLines)
            End If
        End If
        System.IO.File.WriteAllLines(FileName, Items.ToArray)
    End Sub
    ''' <summary>
    ''' Save one column of a bound listbox to a file
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="FileName">File to save items too</param>
    ''' <param name="ColumnName">Name of column to write to disk</param>
    ''' <remarks></remarks>
    <System.Runtime.CompilerServices.Extension()>
    Public Sub SaveToFile(ByVal sender As ListBox.ObjectCollection, ByVal FileName As String, ByVal ColumnName As String)
        System.IO.File.WriteAllLines(FileName,
            (
                From Row In sender.Cast(Of DataRowView)()
                Select CStr(Row.Item(ColumnName))).ToArray())
    End Sub
    ''' <summary>
    ''' Save one column of a bound listbox to a file
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="FileName">File to save items too</param>
    ''' <param name="ColumnIndex">Index of column to write to disk</param>
    ''' <remarks></remarks>
    <System.Runtime.CompilerServices.Extension()>
    Public Sub SaveToFile(ByVal sender As ListBox.ObjectCollection, ByVal FileName As String, ByVal ColumnIndex As Integer)
        System.IO.File.WriteAllLines(FileName,
            (
                From Row In sender.Cast(Of DataRowView)()
                Select CStr(Row.Item(ColumnIndex))).ToArray())
    End Sub
    <System.Runtime.CompilerServices.Extension()>
    Public Sub LoadFromFile(ByVal sender As ListBox.ObjectCollection, ByVal FileName As String)
        sender.AddRange(IO.File.ReadAllLines(FileName))
    End Sub
End Module
