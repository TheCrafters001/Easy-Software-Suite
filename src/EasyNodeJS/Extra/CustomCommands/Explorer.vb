Imports System.IO 'File Info
Imports System.Runtime.InteropServices 'APIs

'
' Folder Management code provided by Hannes Du Preez
' https://www.codeguru.com/columns/vb/creating-a-windows-explorer-application-with-visual-studio-2012.htm
'

Public Class Explorer
    Private Structure SHFILEINFO 'Contains information about a file object
        Public hIcon As IntPtr            'Icon
        Public iIcon As Integer           'Icondex
        Public dwAttributes As Integer    'SFGAO_ flags
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=260)>
        Public szDisplayName As String
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=80)>
        Public szTypeName As String
    End Structure

    Private Declare Auto Function SHGetFileInfo Lib "shell32.dll" _
        (ByVal pszPath As String,
         ByVal dwFileAttributes As Integer,
         ByRef psfi As SHFILEINFO,
         ByVal cbFileInfo As Integer,
         ByVal uFlags As Integer) As IntPtr 'Retrieves information about an object in the file system, such as a file, folder, directory, or drive root

    Private Const SHGFI_ICON = &H100 'Icon
    Private Const SHGFI_SMALLICON = &H1 'Small Icon
    Private Const SHGFI_LARGEICON = &H0    ' Large icon

    Private Const MAX_PATH = 260 'Path to Icon
    Public Shared Sub Init(ByVal folderPath As String)
        EasyNodeJS.trvFolders.Sort() 'Sort Alphabetically

        Dim Tnode As TreeNode = EasyNodeJS.trvFolders.Nodes.Add("[root]") 'Add Main Node

        AddAllFolders(Tnode, folderPath) 'Add All Folders 

        EasyNodeJS.lvFiles.View = View.List 'Set View of ListView

        ' Add ListView Columns With Specified Width
        EasyNodeJS.lvFiles.Columns.Add("File Name", 150, HorizontalAlignment.Left)
        EasyNodeJS.lvFiles.Columns.Add("File Type", 80, HorizontalAlignment.Left)
        EasyNodeJS.lvFiles.Columns.Add("Date Modified", 150, HorizontalAlignment.Left)
    End Sub

    Public Shared Sub AddImages(ByVal strFileName As String)
        Try
            Dim shInfo As SHFILEINFO 'Create File Info Object
            shInfo = New SHFILEINFO() 'Instantiate File Info Object
            shInfo.szDisplayName = New String(vbNullChar, MAX_PATH) 'Get Display Name
            shInfo.szTypeName = New String(vbNullChar, 80) 'Get File Type
            Dim hIcon As IntPtr 'Get File Type Icon Based On File Association
            hIcon = SHGetFileInfo(strFileName, 0, shInfo, Marshal.SizeOf(shInfo), SHGFI_ICON Or SHGFI_SMALLICON)
            Dim MyIcon As Drawing.Bitmap 'Create icon
            MyIcon = Drawing.Icon.FromHandle(shInfo.hIcon).ToBitmap 'Set Icon
            EasyNodeJS.iIconList.Images.Add(strFileName.ToString(), MyIcon) 'Add To ListView FileNames
        Catch ex As Exception
            MessageBox.Show(ex.Message & ex.Source)
        End Try
    End Sub

    Public Shared Sub AddAllFolders(ByVal TNode As TreeNode, ByVal FolderPath As String)
        Try
            For Each FolderNode As String In Directory.GetDirectories(FolderPath) 'Load All Sub Folders 
                Dim SubFolderNode As TreeNode = TNode.Nodes.Add(FolderNode.Substring(FolderNode.LastIndexOf("\"c) + 1)) 'Add Each Sub Folder Name
                SubFolderNode.Tag = FolderNode 'Set Tag For Each Sub Folder
                SubFolderNode.Nodes.Add("Loading...")
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message) 'Something Went Wrong
        End Try
    End Sub
End Class
