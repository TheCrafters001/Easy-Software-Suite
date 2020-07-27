Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports AutoUpdaterDotNET
Public Class EasyHTML
#Region "Editor"
    Private Sub Component_Box_DoubleClick(sender As Object, e As EventArgs) Handles Component_Box.DoubleClick
        CodeEditorBox.Text &= vbCrLf & Me.Component_Box.SelectedItem()
    End Sub

    Private Sub cssImport_lst_DoubleClick(sender As Object, e As EventArgs) Handles cssImport_lst.DoubleClick
        Me.cssImport_lst.Items.Remove(Me.cssImport_lst.SelectedItem)
    End Sub

    Private Sub jsImport_list_DoubleClick(sender As Object, e As EventArgs) Handles jsImport_lst.DoubleClick
        Me.jsImport_lst.Items.Remove(Me.jsImport_lst.SelectedItem)
    End Sub

    Private Sub updatePreview_btn_Click(sender As Object, e As EventArgs) Handles updatePreview_btn.Click
        WebBrowser1.DocumentText = Code_Export_Code_Box.Text
    End Sub

    Private Sub cssImport_btn_Click(sender As Object, e As EventArgs) Handles cssImport_btn.Click
        Try
            Dim cssinput As String = InputBox("Please enter your CSS Library Location" & "(example: http://example.com/css/style.css)", "CSS Import")
            cssImport_lst.Items.Add(cssinput)
        Catch ex As Exception
            HTMLEditorError.Text = ex.ToString
            BugReport.Show()
        End Try
    End Sub

    Private Sub jsImport_btn_Click(sender As Object, e As EventArgs) Handles jsImport_btn.Click
        Try
            Dim jsinput As String = InputBox("Please enter your JavaScrupt Library Location" & "(example: http://example.com/js/script.js)", "JavaScript Import")
            jsImport_lst.Items.Add(jsinput)
        Catch ex As Exception
            HTMLEditorError.Text = ex.ToString
            BugReport.Show()
        End Try
    End Sub
    Private Sub newProject_btn_Click(sender As Object, e As EventArgs) Handles newProject_btn.Click
        Try
            Dim DlgRslt As DialogResult = MessageBox.Show("Are you sure you want to make a new project?" & vbCrLf & "Any unsaved changes will be lost forever.", "Create New Project", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If DlgRslt = DialogResult.Yes Then
                jsImport_lst.Items.Clear()
                cssImport_lst.Items.Clear()
                CodeEditorBox.Text = ""
                mobileViewport_chkbox.Checked = False
                UTF8_Set_chkbox.Checked = False
                metatags_chkbox.Checked = False
                siteAuthor_txtbox.Text = ""
                title_txtBox.Text = ""
                revisit_txtBox.Text = ""
                description_txtBox.Text = ""
                keywords_txtBox.Text = ""
                ThemeSelect.Show()
            End If
        Catch ex As Exception
            HTMLEditorError.Text = ex.ToString
            BugReport.Show()
        End Try
    End Sub
#End Region
#Region "Generator"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If redirectMakerUrl_txtBox.Text = "" Then
                redirectMakerUrl_txtBox.Text = "http://"
            End If
        Catch ex As Exception
            HTMLEditorError.Text = ex.ToString
            BugReport.Show()
        End Try
        Try
            Dim viewport As String
            Dim metatag As String
            Dim utf8charset As String
            Dim pageBody As String
            Dim iecompat As String = ""
            Dim credit As String
            Dim cssImport As New System.Text.StringBuilder()
            Dim jsImport As New System.Text.StringBuilder()
#Region "Credit"
            If credit_chkbox.Checked = True Then
                credit = "<hr><iframe style=""width: 100%; height: 250px; overflow: hidden;"" src=""https://api.thecrafters001.ga/credit/Easy.HTML"" width=""100%"" height=""50px"" scrolling=""no"" frameborder=""0"">Iframes not supported</iframe>"
            ElseIf credit_chkbox.Checked = False Then
                credit = ""
            End If
#End Region
#Region "Viewport"
            If mobileViewport_chkbox.Checked = True Then
                viewport = "<meta name=""viewport"" content=""width=device-width, initial-scale=1"">"
            ElseIf mobileViewport_chkbox.Checked = False Then
                viewport = ""
            End If
#End Region
#Region "cssImport"
            For Each o As Object In cssImport_lst.Items
                cssImport.AppendLine("<link rel=""stylesheet"" href=""" & o & """ />")
            Next
#End Region
#Region "jsImport"
            For Each p As Object In jsImport_lst.Items
                jsImport.AppendLine("<script src=""" & p & """></script>")
            Next

#End Region
#Region "UTF-8 Charset"
            If UTF8_Set_chkbox.Checked = True Then
                utf8charset = "<meta charset=""utf-8"">"
            ElseIf UTF8_Set_chkbox.Checked = False Then
                utf8charset = ""
            End If
#End Region
#Region "Meta Tags"
            If metatags_chkbox.Checked = True Then
                metatag = "<meta name=""title"" content=""" & title_txtBox.Text & """>" &
                    "<meta name=""description"" content=""" & description_txtBox.Text & """>" &
                    "<meta name=""keywords"" content=""" & keywords_txtBox.Text & """>" &
                    "<meta name=""robots"" content=""index, follow"">" &
                    "<meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"">" &
                    "<meta name = ""language"" content=""English"">" &
                    "<meta name = ""revisit-after"" content=""" & revisit_txtBox.Text & " days"">" &
                    "<meta name = ""author"" content=""" & siteAuthor_txtbox.Text & """>"
            ElseIf metatags_chkbox.Checked = False Then
                metatag = ""
            End If
#End Region
            pageBody = CodeEditorBox.Text
            Code_Export_Code_Box.Text = "<!DOCTYPE html>" & vbCrLf & "<head>" & vbCrLf & "<title>" & pageTitle_txtBox.Text & "</title>" & vbCrLf &
                utf8charset.ToString & vbCrLf & viewport.ToString & vbCrLf & iecompat.ToString & vbCrLf & metatag.ToString & vbCrLf &
                cssImport.ToString() & vbCrLf & "</head>" & vbCrLf & "<body>" & vbCrLf & pageBody & vbCrLf & credit & vbCrLf & jsImport.ToString() & vbCrLf &
                "</body>" & vbCrLf & "</html>"
        Catch ex As Exception
            HTMLEditorError.Text = ex.ToString
            BugReport.Show()
        End Try
    End Sub
    Private Sub redirectMakerGenerate_btn_Click(sender As Object, e As EventArgs) Handles redirectMakerGenerate_btn.Click
        Try
            redirectMakerCodeBox_rchTxtBox.Text = "<!DOCTYPE html><html><head><meta http-equiv=""Refresh"" content=""3;URL=" & redirectMakerUrl_txtBox.Text & """><meta charset=""UTF-8""><title>Redirecting...</title><meta name=""description"" content=""Redirecting Service"" ><!-- Mobile Specific Meta --><meta name=""viewport"" content=""width=device-width, initial-scale=1""><!--[if IE]><meta http-equiv='X-UA-Compatible' content='IE=edge,chrome=1'><![endif]--><link href='http://fonts.googleapis.com/css?family=Noto+Sans:400,700' rel='stylesheet' type='text/css'><style>body{font-family:'Noto Sans',Arial,serif;font-weight:400;-webkit-font-smoothing:antialiased;-moz-osx-font-smoothing:grayscale;line-height:1.618em;background:#464646 url(/Branding.png) center center no-repeat fixed;background-size:cover}h2{font-family:'Noto Sans',Arial,serif;font-weight:700;font-size:40px;line-height:1.618em}section{max-width:800px;margin:8% auto 1em auto;background-color:#222;opacity:.8;color:#fff;padding:1em 5%}a{color:#0c6}a:focus{outline:0;outline-offset:inherit}@media (max-device-width:1027px){body{text-align:center;font-size:larger}section{max-width:90%}}@media (max-device-width:640px){section{max-width:97%}}</style></head><body><section><h2>Redirecting to desired website...</h2><h3>I am redirecting you to <a href=""" & redirectMakerUrl_txtBox.Text & """>" & redirectMakerUrl_txtBox.Text & "</a></h3><h3>...You will be transferred to the new site in a moment...</h3><p>If you have waited more than a few seconds and you are still seeing this message, please click on the link above! Thank you.</p></section></body></html>"
        Catch ex As Exception
            HTMLEditorError.Text = ex.ToString
            BugReport.Show()
        End Try
    End Sub
#End Region
#Region "Dialogs"
    Private Sub Btn_Export_Click(sender As Object, e As EventArgs) Handles Btn_Export.Click
        Try
            SaveDialog.Filter = "HTML File (*.html; *.htm; *.hta; *.shtml; *.shtm)|*.html; *.htm; *.hta; *.shtml; *.shtm"
            SaveDialog.Title = "Save HTML File"
            SaveDialog.FileName = "CoolWebsite.html"
            If (SaveDialog.ShowDialog = DialogResult.OK) Then
                My.Computer.FileSystem.WriteAllText(SaveDialog.FileName, Code_Export_Code_Box.Text, False)
                MessageBox.Show("File Saved at: " & SaveDialog.FileName)
            End If
        Catch ex As Exception
            HTMLEditorError.Text = ex.ToString
            BugReport.Show()
        End Try
    End Sub
    Private Sub SaveEditorProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveEditorProjectToolStripMenuItem.Click
        Try
            SaveDialog.Filter = "EasyHTML Project|*.ehtml"
            SaveDialog.Title = "Save EasyHTML Project"
            SaveDialog.FileName = "Project1.ehtml"
            If (SaveDialog.ShowDialog = DialogResult.OK) Then
                My.Computer.FileSystem.WriteAllText(SaveDialog.FileName, CodeEditorBox.Text, False)
                MessageBox.Show("File Saved at: " & SaveDialog.FileName)
            End If
        Catch ex As Exception
            HTMLEditorError.Text = ex.ToString
            BugReport.Show()
        End Try
    End Sub
    Private Sub LoadEditorProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadEditorProjectToolStripMenuItem.Click
        Try
            OpenDialog.Filter = "EasyHTML Project|*.ehtml"
            OpenDialog.Title = "Open EasyHTML Project"
            OpenDialog.FileName = "*.ehtml"
            If (OpenDialog.ShowDialog = DialogResult.OK) Then
                CodeEditorBox.Text = My.Computer.FileSystem.ReadAllText(OpenDialog.FileName)
            End If
        Catch ex As Exception
            HTMLEditorError.Text = ex.ToString
            BugReport.Show()
        End Try
    End Sub
    Private Sub SaveJSLibrariesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveJSLibrariesToolStripMenuItem.Click
        Try
            SaveDialog.Filter = "EasyHTML JS File|*.ejavas"
            SaveDialog.Title = "Save EasyHTML JS File"
            SaveDialog.FileName = "Project1.ejavas"
            If (SaveDialog.ShowDialog = DialogResult.OK) Then
                jsImport_lst.Items.SaveToFile(SaveDialog.FileName)
                MessageBox.Show("File Saved at: " & SaveDialog.FileName)
            End If
        Catch ex As Exception
            HTMLEditorError.Text = ex.ToString
            BugReport.Show()
        End Try
    End Sub
    Private Sub LoadJSLibrariesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadJSLibrariesToolStripMenuItem.Click
        Try
            OpenDialog.Filter = "EasyHTML JS File|*.ejavas"
            OpenDialog.Title = "Open EasyHTML JS File"
            OpenDialog.FileName = "*.ejavas"
            If (OpenDialog.ShowDialog = DialogResult.OK) Then
                For Each o As String In My.Computer.FileSystem.ReadAllText(OpenDialog.FileName)
                    jsImport_lst.Items.LoadFromFile(OpenDialog.FileName)
                Next
            End If
        Catch ex As Exception
            HTMLEditorError.Text = ex.ToString
            BugReport.Show()
        End Try
    End Sub
    Private Sub SaveCSSLibrariesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaveCSSLibrariesToolStripMenuItem1.Click
        Try
            SaveDialog.Filter = "EasyHTML CSS File|*.ecss"
            SaveDialog.Title = "Save EasyHTML CSS File"
            SaveDialog.FileName = "Project1.ecss"
            If (SaveDialog.ShowDialog = DialogResult.OK) Then
                cssImport_lst.Items.SaveToFile(SaveDialog.FileName)
                MessageBox.Show("File Saved at: " & SaveDialog.FileName)
            End If
        Catch ex As Exception
            HTMLEditorError.Text = ex.ToString
            BugReport.Show()
        End Try
    End Sub
    Private Sub LoadCSSLibrariesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LoadCSSLibrariesToolStripMenuItem1.Click
        Try
            OpenDialog.Filter = "EasyHTML CSS File|*.ecss"
            OpenDialog.Title = "Open EasyHTML CSS File"
            OpenDialog.FileName = "*.ecss"
            If (OpenDialog.ShowDialog = DialogResult.OK) Then
                cssImport_lst.Items.LoadFromFile(OpenDialog.FileName)
            End If
        Catch ex As Exception
            HTMLEditorError.Text = ex.ToString
            BugReport.Show()
        End Try
    End Sub
    Private Sub loadCssLibs_btn_Click(sender As Object, e As EventArgs) Handles loadCssLibs_btn.Click
        Try
            OpenDialog.Filter = "EasyHTML CSS File|*.ecss"
            OpenDialog.Title = "Open EasyHTML CSS File"
            OpenDialog.FileName = "*.ecss"
            If (OpenDialog.ShowDialog = DialogResult.OK) Then
                cssImport_lst.Items.LoadFromFile(OpenDialog.FileName)
            End If
        Catch ex As Exception
            HTMLEditorError.Text = ex.ToString
            BugReport.Show()
        End Try
    End Sub
    Private Sub loadJsLibs_btn_Click(sender As Object, e As EventArgs) Handles loadJsLibs_btn.Click
        Try
            OpenDialog.Filter = "EasyHTML JS File|*.ejavas"
            OpenDialog.Title = "Open EasyHTML JS File"
            OpenDialog.FileName = "*.ejavas"
            If (OpenDialog.ShowDialog = DialogResult.OK) Then
                For Each o As String In My.Computer.FileSystem.ReadAllText(OpenDialog.FileName)
                    jsImport_lst.Items.LoadFromFile(OpenDialog.FileName)
                Next
            End If
        Catch ex As Exception
            HTMLEditorError.Text = ex.ToString
            BugReport.Show()
        End Try
    End Sub
    Private Sub loadEditorProj_btn_Click(sender As Object, e As EventArgs) Handles loadEditorProj_btn.Click
        Try
            OpenDialog.Filter = "EasyHTML Project|*.ehtml"
            OpenDialog.Title = "Open EasyHTML Project"
            OpenDialog.FileName = "*.ehtml"
            If (OpenDialog.ShowDialog = DialogResult.OK) Then
                CodeEditorBox.Text = My.Computer.FileSystem.ReadAllText(OpenDialog.FileName)
            End If
        Catch ex As Exception
            HTMLEditorError.Text = ex.ToString
            BugReport.Show()
        End Try
    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Try
            SaveDialog.Filter = "HTML File (*.html; *.htm; *.hta; *.shtml; *.shtm)|*.html; *.htm; *.hta; *.shtml; *.shtm"
            SaveDialog.Title = "Save HTML File"
            SaveDialog.FileName = "CoolRedirect.html"
            If (SaveDialog.ShowDialog = DialogResult.OK) Then
                My.Computer.FileSystem.WriteAllText(SaveDialog.FileName, redirectMakerCodeBox_rchTxtBox.Text, False)
                MessageBox.Show("Redirect File Saved at: " & SaveDialog.FileName)
            End If
        Catch ex As Exception
            HTMLEditorError.Text = ex.ToString
            BugReport.Show()
        End Try
    End Sub
#End Region
#Region "Misc"
    Private Sub EasyHTML_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        version_lbl.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        copyright_lbl.Text = My.Application.Info.Copyright
        ThemeSelect.Show()
        ThemeSelect.TopMost = True
    End Sub
    Private Sub EasyHTML_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ThemeSelect.Close()
    End Sub
    Private Sub updateCheck_btn_Click(sender As Object, e As EventArgs) Handles updateCheck_btn.Click
        AutoUpdater.ShowSkipButton = True
        AutoUpdater.ShowRemindLaterButton = True
        AutoUpdater.ReportErrors = True
        AutoUpdater.RunUpdateAsAdmin = True
        AutoUpdater.LetUserSelectRemindLater = True
        AutoUpdater.RemindLaterTimeSpan = RemindLaterFormat.Hours
        AutoUpdater.RemindLaterAt = 1
        AutoUpdater.UpdateFormSize = New System.Drawing.Size(925, 665)
        AutoUpdater.Start("https://api.thecrafters001.ga/updates/easyhtml.xml")
    End Sub
    Private Sub gnuGpl_pic_MouseHover(sender As Object, e As EventArgs) Handles gnuGpl_pic.MouseHover
        gnuGpl_pic.BackColor = Color.DarkGray
    End Sub

    Private Sub gnuGpl_pic_MouseLeave(sender As Object, e As EventArgs) Handles gnuGpl_pic.MouseLeave
        gnuGpl_pic.BackColor = Color.Gray
    End Sub

    Private Sub gnuGpl_pic_Click(sender As Object, e As EventArgs) Handles gnuGpl_pic.Click
        Process.Start("https://www.gnu.org/licenses/gpl-3.0.en.html")
    End Sub
#End Region
End Class