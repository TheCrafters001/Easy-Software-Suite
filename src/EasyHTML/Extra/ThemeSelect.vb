Public Class ThemeSelect
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If rad_Template.Checked = True Then
            grp_SelectTemplate.Enabled = True
            'cmb_Theme.Enabled = True
        ElseIf rad_Template.Checked = False Then
            grp_SelectTemplate.Enabled = False
            'cmb_Theme.Enabled = False
        End If
    End Sub

    Private Sub ThemeSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rad_Template.Checked = False
        rad_Blank.Checked = True
        Timer1.Start()
    End Sub
End Class