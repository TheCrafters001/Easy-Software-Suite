Public Class OpenProject
    Private Sub OpenProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set BackColor of main window
        Me.BackColor = Color.FromArgb(124, 63, 255)
        ' Start Timer
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Check if rad_Template is checked or not.
        If openProj_rad.Checked = True Then
            openProj_grp.Enabled = True
            'cmb_Theme.Enabled = True
        ElseIf newProj_rad.Checked = False Then
            openProj_grp.Enabled = False
            'cmb_Theme.Enabled = False
        End If
    End Sub

    Private Sub browse_btn_Click(sender As Object, e As EventArgs) Handles browse_btn.Click
        Try
            projLocation_fld.Description = "Please select a folder with a NodeJS project"
            projLocation_fld.ShowNewFolderButton = False
            Dim result As DialogResult = projLocation_fld.ShowDialog()
            If result = DialogResult.OK Then
                projLocation_txt.Text = projLocation_fld.SelectedPath
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ok_btn_Click(sender As Object, e As EventArgs) Handles ok_btn.Click
        Try
            If projLocation_txt.Text = "" Then
                MessageBox.Show("You cannot leave the Project Folder Location blank")
            ElseIf Not projLocation_txt.Text = "" Then
                Explorer.Init(projLocation_txt.Text)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class