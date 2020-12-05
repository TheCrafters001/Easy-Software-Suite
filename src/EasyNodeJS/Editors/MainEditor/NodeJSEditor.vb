Imports System.ComponentModel
Imports System.IO

'
' Folder Management code provided by Hannes Du Preez
' https://www.codeguru.com/columns/vb/creating-a-windows-explorer-application-with-visual-studio-2012.htm
'

Public Class EasyNodeJS
#Region "Folder Management"
    Private Sub trvFolders_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles trvFolders.AfterSelect
        Dim FileExtension As String 'Stores File Extension
        Dim SubItemIndex As Integer 'Sub Item Counter
        Dim DateMod As String 'Stores Date Modified Of File
        lvFiles.Items.Clear() 'Clear Existing Items
        If trvFolders.SelectedNode.Nodes.Count = 1 AndAlso trvFolders.SelectedNode.Nodes(0).Text = "Loading..." Then
            trvFolders.SelectedNode.Nodes.Clear() 'Reset
            Explorer.AddAllFolders(trvFolders.SelectedNode, CStr(trvFolders.SelectedNode.Tag))
        End If
        Dim folder As String = CStr(trvFolders.SelectedNode.Tag) 'Folder Name
        If Not folder Is Nothing AndAlso Directory.Exists(folder) Then
            Try
                For Each file As String In Directory.GetFiles(folder) 'Get Files In Folder
                    FileExtension = Path.GetExtension(file) 'Get File Extension(s)
                    DateMod = System.IO.File.GetLastWriteTime(file).ToString() 'Get Date Modified For Each File
                    Explorer.AddImages(file) 'Add Icons
                    lvFiles.Items.Add(file.Substring(file.LastIndexOf("\"c) + 1), file.ToString()) 'Add Files & File Properties To ListView
                    lvFiles.Items(SubItemIndex).SubItems.Add(FileExtension.ToString() & " File")
                    lvFiles.Items(SubItemIndex).SubItems.Add(DateMod.ToString())
                    SubItemIndex += 1
                Next
            Catch ex As Exception 'Something Went Wrong
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Private Sub trvFolders_BeforeExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles trvFolders.BeforeExpand
        If e.Node.Nodes.Count = 1 AndAlso e.Node.Nodes(0).Text = "Loading..." Then
            e.Node.Nodes.Clear() 'Clear All Items
            Explorer.AddAllFolders(e.Node, CStr(e.Node.Tag)) 'Add All Folders
        End If
    End Sub
    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Dim lvItem As ListViewItem 'ListView item
        Dim lvSel As ListView.SelectedListViewItemCollection = Me.lvFiles.SelectedItems 'ListViewItems
        Dim strFileName As String 'File Name
        For Each lvItem In lvSel 'Loop Through Select File Names In ListView
            strFileName = trvFolders.SelectedNode.Tag & "\" & lvItem.Text 'Get Selected File Name
            Dim clpDataObj As New DataObject() 'Create New Data Object
            Dim cbClipBoardFile(0) As String 'Break File Apart Into A String Array
            cbClipBoardFile(0) = strFileName
            clpDataObj.SetData(DataFormats.FileDrop, True, cbClipBoardFile) 'Put String Array Onto ClipBoard
            Clipboard.SetDataObject(clpDataObj)
            MessageBox.Show("File Copied To Clipboard") 'Inform User
        Next
    End Sub
    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        Dim idClipboardData As IDataObject = Clipboard.GetDataObject() 'Get Data Present on ClipBoard
        If idClipboardData.GetDataPresent(DataFormats.FileDrop) Then
            Dim strClipFile As String() = DirectCast(idClipboardData.GetData(DataFormats.FileDrop), String()) 'Convert String Array Back Into File
            Dim i As Integer
            For i = 0 To strClipFile.Length - 1
                'If File Exists, Rename COpied File
                If File.Exists(trvFolders.SelectedNode.Tag & "\" & Path.GetFileName(strClipFile(i))) Then
                    File.Move(trvFolders.SelectedNode.Tag & "\" & Path.GetFileName(strClipFile(i)), trvFolders.SelectedNode.Tag & "temp")
                End If
                'Copy File From ClipbBoard
                File.Copy(strClipFile(i), trvFolders.SelectedNode.Tag & "\" & Path.GetFileName(strClipFile(i)))
            Next
            MessageBox.Show("File Pasted From Clipboard") 'Inform User
        End If
    End Sub
#End Region
#Region "Misc"
    Private Sub EasyNodeJS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set BackColor of main window
        Me.BackColor = Color.LightBlue
        ' Apply Version and Copyright Info
        version_lbl.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        copyright_lbl.Text = My.Application.Info.Copyright
        OpenProject.Show()
        OpenProject.TopMost = True
    End Sub
    Private Sub gnuGpl_pic_MouseHover(sender As Object, e As EventArgs) Handles gnuGpl_pic.MouseHover
        ' Set Color to Dark Gray if hover over
        gnuGpl_pic.BackColor = Color.DarkGray
    End Sub

    Private Sub gnuGpl_pic_MouseLeave(sender As Object, e As EventArgs) Handles gnuGpl_pic.MouseLeave
        ' Set color to Gray if not hoving over.
        gnuGpl_pic.BackColor = Color.Gray
    End Sub

    Private Sub gnuGpl_pic_Click(sender As Object, e As EventArgs) Handles gnuGpl_pic.Click
        ' Open GNU GPL Website
        Process.Start("https://www.gnu.org/licenses/gpl-3.0.en.html")
    End Sub

    Private Sub EasyNodeJS_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ' Close Open Project form
        OpenProject.Close()
    End Sub
#End Region
End Class
