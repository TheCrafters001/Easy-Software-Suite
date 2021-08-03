Imports ErrorLogger.Logger

Public Class EasyHTML_Two

    'Create the output for the whole editor to hold.
    Dim output As String = Generator.Generate()

    Private Sub EasyHTML_Two_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Start Timer
        Main_Timer.Start()
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
            output = "<html><head>" + headerCodeBox_txt.Text + "</head><body>" + bodyEditor_edt.Text + footerCodeStuff_txt.Text + "</body>"
            ' Set Filter for HTML Files
            SaveDialog.Filter = "HTML File (*.html; *.htm; *.hta; *.shtml; *.shtm)|*.html; *.htm; *.hta; *.shtml; *.shtm"
            SaveDialog.Title = "Save HTML File"
            SaveDialog.FileName = "CoolWebsite.html"
            ' Show Dialog. If the result is OK, save file to FileName.
            If (SaveDialog.ShowDialog = DialogResult.OK) Then
                My.Computer.FileSystem.WriteAllText(SaveDialog.FileName, output, False)
                MessageBox.Show("File Saved at: " & SaveDialog.FileName)
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region

End Class
