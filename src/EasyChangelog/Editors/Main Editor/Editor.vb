Public Class Editor
#Region "Editor"
    Private Sub btn_added_Click(sender As Object, e As EventArgs) Handles btn_added.Click
        Try
            ' Add an Item to CSS Imports
            Dim input As String = InputBox("What was added to your software?" + "(Do not add the word ""Added"". It does that for you.)" + "(Example: Button in about page)", "CSS Import")
            If input = "" Then
                MessageBox.Show("Cannot add item, nothing in input box.", "Oops.")
            ElseIf Not input = "" Then
                lst_added.Items.Add(input)
            End If
        Catch ex As Exception
            HTMLEditorError.Text = ex.ToString
            BugReport.Show()
        End Try
    End Sub

    Private Sub btn_changed_Click(sender As Object, e As EventArgs) Handles btn_changed.Click
        Try
            ' Add an Item to CSS Imports
            Dim input As String = InputBox("What was changed in your software?" + "(Do not add the word ""Changed"". It does that for you.)" + "(Example: Button in about page)", "CSS Import")
            If input = "" Then
                MessageBox.Show("Cannot add item, nothing in input box.", "Oops.")
            ElseIf Not input = "" Then
                lst_changed.Items.Add(input)
            End If
        Catch ex As Exception
            HTMLEditorError.Text = ex.ToString
            BugReport.Show()
        End Try
    End Sub

    Private Sub btn_deprecated_Click(sender As Object, e As EventArgs) Handles btn_deprecated.Click
        Try
            ' Add an Item to CSS Imports
            Dim input As String = InputBox("What was deprecated on your software?" + "(Do not add the word ""Deprecated"". It does that for you.)" + "(Example: Button in about page)", "CSS Import")
            If input = "" Then
                MessageBox.Show("Cannot add item, nothing in input box.", "Oops.")
            ElseIf Not input = "" Then
                lst_Deprecated.Items.Add(input)
            End If
        Catch ex As Exception
            HTMLEditorError.Text = ex.ToString
            BugReport.Show()
        End Try
    End Sub

    Private Sub btn_removed_Click(sender As Object, e As EventArgs) Handles btn_removed.Click
        Try
            ' Add an Item to CSS Imports
            Dim input As String = InputBox("What was removed from your software?" + "(Do not add the word ""Removed"". It does that for you.)" + "(Example: Button in about page)", "CSS Import")
            If input = "" Then
                MessageBox.Show("Cannot add item, nothing in input box.", "Oops.")
            ElseIf Not input = "" Then
                lst_removed.Items.Add(input)
            End If
        Catch ex As Exception
            HTMLEditorError.Text = ex.ToString
            BugReport.Show()
        End Try
    End Sub

    Private Sub btn_fixed_Click(sender As Object, e As EventArgs) Handles btn_fixed.Click
        Try
            ' Add an Item to CSS Imports
            Dim input As String = InputBox("What was fixed in your software?" + "(Do not add the word ""Fixed"". It does that for you.)" + "(Example: Button in about page)", "CSS Import")
            If input = "" Then
                MessageBox.Show("Cannot add item, nothing in input box.", "Oops.")
            ElseIf Not input = "" Then
                lst_fixed.Items.Add(input)
            End If
        Catch ex As Exception
            HTMLEditorError.Text = ex.ToString
            BugReport.Show()
        End Try
    End Sub

    Private Sub btn_security_Click(sender As Object, e As EventArgs) Handles btn_security.Click
        Try
            ' Add an Item to CSS Imports
            Dim input As String = InputBox("What was a security issue?" + "(Do not add the word ""Security"". It does that for you.)" + "(Example: Button in about page)", "CSS Import")
            If input = "" Then
                MessageBox.Show("Cannot add item, nothing in input box.", "Oops.")
            ElseIf Not input = "" Then
                lst_security.Items.Add(input)
            End If
        Catch ex As Exception
            HTMLEditorError.Text = ex.ToString
            BugReport.Show()
        End Try
    End Sub

    Private Sub lst_added_DoubleClick(sender As Object, e As EventArgs) Handles lst_added.DoubleClick
        Me.lst_added.Items.Remove(Me.lst_added.SelectedItem)
    End Sub
    Private Sub lst_changed_DoubleClick(sender As Object, e As EventArgs) Handles lst_changed.DoubleClick
        Me.lst_changed.Items.Remove(Me.lst_changed.SelectedItem)
    End Sub
    Private Sub lst_deprecated_DoubleClick(sender As Object, e As EventArgs) Handles lst_Deprecated.DoubleClick
        Me.lst_Deprecated.Items.Remove(Me.lst_Deprecated.SelectedItem)
    End Sub
    Private Sub lst_removed_DoubleClick(sender As Object, e As EventArgs) Handles lst_removed.DoubleClick
        Me.lst_removed.Items.Remove(Me.lst_removed.SelectedItem)
    End Sub
    Private Sub lst_fixed_DoubleClick(sender As Object, e As EventArgs) Handles lst_fixed.DoubleClick
        Me.lst_fixed.Items.Remove(Me.lst_fixed.SelectedItem)
    End Sub
    Private Sub lst_security_DoubleClick(sender As Object, e As EventArgs) Handles lst_security.DoubleClick
        Me.lst_security.Items.Remove(Me.lst_added.SelectedItem)
    End Sub
#End Region
#Region "Generator"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Dim added As New System.Text.StringBuilder()
            Dim changed As New System.Text.StringBuilder()
            Dim deprecated As New System.Text.StringBuilder()
            Dim removed As New System.Text.StringBuilder()
            Dim fixed As New System.Text.StringBuilder()
            Dim security As New System.Text.StringBuilder()
#Region "Changelog"
            For Each a As Object In lst_added.Items
                added.AppendLine("<li>Added " + a + "</li>")
            Next
            For Each c As Object In lst_changed.Items
                changed.AppendLine("<li>Changed " + c + "</li>")
            Next
            For Each d As Object In lst_Deprecated.Items
                deprecated.AppendLine("<li>Deprecated " + d + "</li>")
            Next
            For Each r As Object In lst_removed.Items
                removed.AppendLine("<li>Removed " + r + "</li>")
            Next
            For Each f As Object In lst_fixed.Items
                fixed.AppendLine("<li>Fixed " + f + "</li>")
            Next
            For Each s As Object In lst_security.Items
                security.AppendLine("<li>Security " + s + "</li>")
            Next
#End Region
            export_html.Text = "<section id=""v" + verNumb_txt.Text + """><h1>Version " + verNumb_txt.Text + "</h1><br><h2>Table of Contents</h2> <ul><li><a href=""#added"">Added</a></li><li><a href=""#changed"">Changed</a></li><li><a href=""#deprecated"">Deprecated</a></li><li><a href=""#removed"">Removed</a></li><li><a href=""#fixed"">Fixed</a></li><li><a href=""#security"">Security</a></li></ul> <section id=""added""><br><br><h1>Added</h1><hr><ul>" + added.ToString _
                + "</ul></section><br><section id=""changed""><h1>Changed</h1><hr><ul>" + changed.ToString + "</ul></section><br>" +
                "<section id=""deprecated""><h1>Deprecated</h1><hr><ul>" + deprecated.ToString + "</ul></section><br>" +
                "<section id=""removed""><h1>Removed</h1><hr><ul>" + removed.ToString + "</ul></section><br>" +
                "<section id=""fixed""><h1>Fixed</h1><hr><ul>" + fixed.ToString + "</ul></section><br>" +
                "<section id=""security""><h1>Security</h1><hr><ul>" + security.ToString + "</ul></section><br><!--Created with EasyChangelog--></section>"
        Catch ex As Exception
            HTMLEditorError.Text = ex.ToString
            BugReport.Show()
        End Try
    End Sub
#End Region
#Region "Misc"
    Private Sub Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set BackColor of main window
        Me.BackColor = Color.FromArgb(0, 19, 127)
        ' Apply Version and Copyright Info
        version_lbl.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        copyright_lbl.Text = My.Application.Info.Copyright
        Timer1.Start()
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
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Licenses.Show()
    End Sub

    Private Sub btn_Export_Click(sender As Object, e As EventArgs) Handles btn_Export.Click
        Try
            ' Set Filter for HTML Files
            SaveDialog.Filter = "HTML File (*.html; *.htm; *.hta; *.shtml; *.shtm)|*.html; *.htm; *.hta; *.shtml; *.shtm"
            SaveDialog.Title = "Save HTML File"
            SaveDialog.FileName = "Changelog-v" + verNumb_txt.Text + ".html"
            ' Show Dialog. If the result is OK, save file to FileName.
            If (SaveDialog.ShowDialog = DialogResult.OK) Then
                My.Computer.FileSystem.WriteAllText(SaveDialog.FileName, export_html.Text, False)
                MessageBox.Show("File Saved at: " & SaveDialog.FileName)
            End If
        Catch ex As Exception
            ' Show Error Window
            HTMLEditorError.Text = ex.ToString
            BugReport.Show()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = ".\Easy Software Suite Launcher.exe"
            pHelp.Arguments = ""
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(pHelp)
            Application.Exit()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error")
        End Try
    End Sub
#End Region
End Class
