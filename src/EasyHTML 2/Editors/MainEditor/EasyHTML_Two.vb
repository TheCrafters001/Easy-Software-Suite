Imports ErrorLogger.Logger

Public Class EasyHTML_Two

    Private Sub EasyHTML_Two_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Input("Starting EasyHTML 2...")
        'Start Timer
        Main_Timer.Start()
        Input("Started EasyHTML 2 Main timer...")
        BonfireTabControl1.SelectedTab = Pg_Editors_Body
    End Sub

#Region "Timer"
    Private Sub Main_Timer_Tick(sender As Object, e As EventArgs) Handles Main_Timer.Tick
        If metatags_chkbox.Checked = True Then
            title_txtBox.Enabled = True
            description_txtBox.Enabled = True
            siteAuthor_txtbox.Enabled = True
            revisit_txtBox.Enabled = True
            keywords_txtBox.Enabled = True
        ElseIf metatags_chkbox.Checked = False Then
            title_txtBox.Enabled = False
            description_txtBox.Enabled = False
            siteAuthor_txtbox.Enabled = False
            revisit_txtBox.Enabled = False
            keywords_txtBox.Enabled = False
        End If
    End Sub
#End Region

#Region "Return to Launcher"
    Private Sub returnToLauncher_btn_Click(sender As Object, e As EventArgs) Handles returnToLauncher_btn.Click
        ' Create DlgResult
        Dim DlgResult As DialogResult
        ' Show Message Box
        DlgResult = MessageBox.Show("Are you sure you want to exit to the launcher? Any unsaved changes will not be saved.", "Exit to Launcher", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        'See waht users says, then take an action
        If DlgResult = DialogResult.Yes Then
            Try
                ' Create a new ProcessStartInfo to prepare to launch the Launcher
                Dim launcher As New ProcessStartInfo
                ' Choose the launcher.
                launcher.FileName = ".\Easy Software Suite Launcher.exe"
                launcher.Arguments = ""
                launcher.UseShellExecute = True
                launcher.WindowStyle = ProcessWindowStyle.Normal
                ' Launch the Launcher, then exit the application.
                Dim proc As Process = Process.Start(launcher)
                Application.Exit()
            Catch ex As Exception
                Input(ex.ToString)
                MessageBox.Show("Oh, seems like you ran into an error. The error was logged in the following file: " & Environment.CurrentDirectory & "\ErrorLog.txt", "Error")
            End Try
        ElseIf DlgResult = DialogResult.No Then
            ' Do nothing
        End If
    End Sub
#End Region

#Region "GNU GPL 3"
    Private Sub gnuGpl_pic_Click(sender As Object, e As EventArgs) Handles gnuGpl_pic.Click
        ' Open GNU GPL Website
        Process.Start("https://www.gnu.org/licenses/gpl-3.0.en.html")
    End Sub
#End Region

#Region "Export Stuff"
    Private Sub exportPreview_btn_Click(sender As Object, e As EventArgs) Handles exportPreview_btn.Click

    End Sub

    Private Sub export_btn_Click(sender As Object, e As EventArgs) Handles export_btn.Click
        Try
            'Generate the Code
            Generate()
            ' Set Filter for HTML Files
            SaveDialog.Filter = "HTML File (*.html; *.htm; *.hta; *.shtml; *.shtm)|*.html; *.htm; *.hta; *.shtml; *.shtm"
            SaveDialog.Title = "Save HTML File"
            SaveDialog.FileName = "CoolWebsite.html"
            ' Show Dialog. If the result is OK, save file to FileNa
            If (SaveDialog.ShowDialog = DialogResult.OK) Then
                My.Computer.FileSystem.WriteAllText(SaveDialog.FileName, exportbox_txt.Text, False)
                MessageBox.Show("File Saved at: " & SaveDialog.FileName)
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Preview"

#Region "Browser Preview"
    Private Sub previewBrowser_btn_Click(sender As Object, e As EventArgs) Handles previewBrowser_btn.Click
        ' Generator Code
        Generate()

        ' Set Path to Temp
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
        path = IO.Path.Combine(path, "Temp\EasyHTML2")

        ' Create Preview File
        IO.Directory.CreateDirectory(path)
        IO.File.WriteAllText(IO.Path.Combine(path, "preview.html"), exportbox_txt.Text)

        ' Launch in Default Browser
        Process.Start(IO.Path.Combine(path, "preview.html"))
    End Sub
#End Region

#End Region

#Region "Generator"
    Private Sub Generate()
        Dim viewPort As String = ""
        Dim metaTag As String = ""
        Dim utf8CharSet As String = ""
        Dim pageHead As String = ""
        Dim pageBody As String = ""
        Dim pageFooter As String = ""
        Dim ieCompat As String = ""
        Dim cssImport As New System.Text.StringBuilder
        Dim jsImport As New System.Text.StringBuilder
        Dim credits As String = ""

        Dim output As String

#Region "Credits"
        ' This section handles if the credits are on or not.
        If credit_chkbox.Checked = True Then
            credits = "<hr><div align=""center""><h3>Built with EasyHTML 2</h3><P>You can get EasyHTML 2, a free, open-source HTML editor, today at no cost! EasyHTML is a part of the Easy Software Suite, made by TheCrafters001<br><br><form action=""https://github.com/TheCrafters001/Easy-Software-Suite/releases/latest""><input type=""submit"" value=""Get EasyHTML 2 Now!"" /></form></P></div>"
        ElseIf credit_chkbox.Checked = False Then
            credits = ""
        End If
#End Region

#Region "Viewport"
        ' This will handle the view port meta tag.
        If mobileViewport_chkbox.Checked = True Then
            viewPort = "<meta name=""viewport"" content=""width=device-width, initial-scale=1"">"
        ElseIf mobileViewport_chkbox.Checked = False Then
            viewPort = ""
        End If
#End Region

#Region "Metatags"
        ' Set the meta tags, if the user chooses to have them enabled.
        If metatags_chkbox.Checked = True Then
            metaTag = "<meta name=""title"" content=""" & title_txtBox.Text & """>" & vbCrLf &
                    "<meta name=""description"" content=""" & description_txtBox.Text & """>" & vbCrLf &
                    "<meta name=""keywords"" content=""" & keywords_txtBox.Text & """>" & vbCrLf &
                    "<meta name=""robots"" content=""index, follow"">" &
                    "<meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"">" & vbCrLf &
                    "<meta name = ""language"" content=""English"">" & vbCrLf &
                    "<meta name = ""revisit-after"" content=""" & revisit_txtBox.Text & " days"">" & vbCrLf &
                    "<meta name = ""author"" content=""" & siteAuthor_txtbox.Text & """>"
        ElseIf metatags_chkbox.Checked = False Then
            metaTag = ""
        End If
#End Region

#Region "UTF-8 Charset"
        ' Set UTF-8 Charset
        If UTF8_Set_chkbox.Checked = True Then
            utf8CharSet = "<meta charset=""utf-8"">"
        ElseIf UTF8_Set_chkbox.Checked = False Then
            utf8CharSet = ""
        End If
#End Region

#Region "IE Compatibility"
        ' This generates the to to tell the browser if this website works with IE 8.
        If internetExplorerCompatability_chk.Checked = True Then
            ieCompat = "<meta http-equiv=""X-UA-Compatible"" content=""IE=8"" />"
        ElseIf internetExplorerCompatability_chk.Checked = False Then
            ieCompat = ""
        End If
#End Region

#Region "cssImport"
        ' Generate CSS Import.
        ' For each line, generate code.
        For Each o As Object In cssImport_lst.Items
            cssImport.AppendLine("<link rel=""stylesheet"" href=""" & o & """ />")
        Next
#End Region
#Region "jsImport"
        ' Generate JS Import.
        ' For each line, generate code.
        For Each p As Object In jsImport_lst.Items
            jsImport.AppendLine("<script src=""" & p & """></script>")
        Next
#End Region

#Region "Header"
        ' This code adds extra code to the <HEAD> tags
        pageHead = headerCodeBox_txt.Text
#End Region

#Region "Body"
        ' This generates the main code in the <BODY> tag
        pageBody = bodyEditor_edt.Text
#End Region

#Region "Footer"
        ' This code comes before the </BODY> tag at the end of the document
        pageFooter = footerCodeStuff_txt.Text
#End Region

        output = "<!DOCTYPE html>" & vbCrLf & "<head>" & vbCrLf & viewPort & vbCrLf & ieCompat & vbCrLf & utf8CharSet & vbCrLf & metaTag & vbCrLf & cssImport.ToString & vbCrLf & pageHead & vbCrLf & "</head>" _
            & vbCrLf & "<body>" & vbCrLf & pageBody & vbCrLf & credits & vbCrLf & pageFooter & vbCrLf & jsImport.ToString & vbCrLf & "</body>" & vbCrLf & "</html>"

        exportbox_txt.Text = output
    End Sub

    Private Sub saveWholeProject_btn_Click(sender As Object, e As EventArgs) Handles saveWholeProject_btn.Click
        ProjFolder.Description = "Select a folder to save to."
        If (ProjFolder.ShowDialog = DialogResult.OK) Then
            ' Save Body, Header and Footer
            My.Computer.FileSystem.WriteAllText(ProjFolder.SelectedPath + "\body.ehtml", bodyEditor_edt.Text, False)
            My.Computer.FileSystem.WriteAllText(ProjFolder.SelectedPath + "\header.ehtml", headerCodeBox_txt.Text, False)
            My.Computer.FileSystem.WriteAllText(ProjFolder.SelectedPath + "\footer.ehtml", footerCodeStuff_txt.Text, False)
        End If
    End Sub
#End Region

End Class
