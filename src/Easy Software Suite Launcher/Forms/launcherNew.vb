Public Class launcherNew
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Application.Exit()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Licenses.Show()
    End Sub

    Private Sub launcherNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Find.Find("EasyHTML")
        Find.Find("EasyNodeJS")
        Find.Find("EasyChangelog")
        Find.Find("EasyPresskit")
        Find.Find("EasyGit")
    End Sub

    Private Sub appList_lst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles appList_lst.SelectedIndexChanged
        If appList_lst.SelectedItem = "EasyHTML" Then
            appInfo.Info("EasyHTML", "​EasyHTML is a free to use, easy-to-understand HTML Editor. It has Live Code Preview, and Exporting. You can save, and load, all your projects with ease, and you can easily update existing websites created with it! The Live Code Preview allows you to see what the website code looks like as you update it, and you can export that code with one click!", My.Resources.EasyHTML_Icon)
        ElseIf appList_lst.SelectedItem = "EasyNodeJS" Then
            appInfo.Info("EasyNodeJS", "EasyNodeJS allows you to create, and edit, NodeJS Projects. This project has been discontinued and depreciated.​", My.Resources.EasyNodeJS_Logo1)
        ElseIf appList_lst.SelectedItem = "EasyChangelog" Then
            appInfo.Info("EasyChangelog", "EasyChangelog allows you create changelogs for your apps in a quick, and sorted fashion.​", My.Resources.EasyChangelog_Logo)
        ElseIf appList_lst.SelectedItem = "EasyPresskit" Then
            appInfo.Info("EasyPresskit", "[Experimental] EasyPresskit allows you to create presskit pages quickly, and easily!", My.Resources.EasyPresskit_logo)
        ElseIf appList_lst.SelectedItem = "EasyGit" Then
            appInfo.Info("EasyGit", "[Experimental] EasyGit is made so you can push Git changes to GitHub, GitLab, or anything that uses Git.​", My.Resources.EasyGit_logo)
        End If
    End Sub

    Private Sub App_Launch_Btn_Click(sender As Object, e As EventArgs) Handles App_Launch_Btn.Click
        If appList_lst.SelectedItem = "EasyHTML" Then
            Launch.Launch("EasyHTML")
        ElseIf appList_lst.SelectedItem = "EasyNodeJS" Then
            Launch.Launch("EasyNodeJS")
        ElseIf appList_lst.SelectedItem = "EasyChangelog" Then
            Launch.Launch("EasyChangelog")
        ElseIf appList_lst.SelectedItem = "EasyPresskit" Then
            Launch.Launch("EasyPresskit")
        ElseIf appList_lst.SelectedItem = "EasyGit" Then
            Launch.Launch("EasyGit")
        End If
    End Sub
End Class