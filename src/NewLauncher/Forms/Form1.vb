﻿Public Class Form1
    Private Sub thirdParty_lnklbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles thirdParty_lnklbl.LinkClicked
        ' Show Licenses Page
        Licenses.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Find Apps based on EXE Name
        Find.Find("EasyHTML")
        Find.Find("EasyHTML 2")
        Find.Find("EasyConsole")
        Find.Find("EasyButler")
        Find.Find("EasyChangelog")
        Find.Find("EasyGit")
        Find.Find("EasyNodeJS")
        Find.Find("EasyPresskit")
    End Sub

    Private Sub appList_lst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles appList_lst.SelectedIndexChanged
        ' Add app and Description based on what user has selected.
        If appList_lst.SelectedItem = "EasyChangelog" Then
            appInfo.Info("EasyChangelog", "EasyChangelog allows you create changelogs for your apps in a quick, and sorted fashion.​", My.Resources.EasyChangelog_Logo1)
        ElseIf appList_lst.SelectedItem = "EasyGit" Then
            appInfo.Info("EasyGit", "[Experimental] EasyGit is made so you can push Git changes to GitHub, GitLab, or anything that uses Git.​", My.Resources.EasyGit_logo)
        ElseIf appList_lst.SelectedItem = "EasyHTML" Then
            appInfo.Info("EasyHTML", "​EasyHTML is a free to use, easy-to-understand HTML Editor. It has Live Code Preview, and Exporting. You can save, and load, all your projects with ease, and you can easily update existing websites created with it! The Live Code Preview allows you to see what the website code looks like as you update it, and you can export that code with one click!", My.Resources.EasyHTML_Icon1)
        ElseIf appList_lst.SelectedItem = "EasyHTML 2" Then
            appInfo.Info("EasyHTML 2", "​EasyHTML 2 is a free to use, easy-to-understand HTML Editor. It has Live Code Preview, and Exporting. You can save, and load, all your projects with ease, and you can easily update existing websites created with it! The Live Code Preview allows you to see what the website code looks like as you update it, and you can export that code with one click!", My.Resources.EasyHTML2_logo)
        ElseIf appList_lst.SelectedItem = "EasyNodeJS" Then
            appInfo.Info("EasyNodeJS", "EasyNodeJS allows you to create, and edit, NodeJS Projects. This project has been discontinued and depreciated.​", My.Resources.EasyNodeJS_Logo1)
        ElseIf appList_lst.SelectedItem = "EasyPresskit" Then
            appInfo.Info("EasyPresskit", "[Experimental] EasyPresskit allows you to create presskit pages quickly, and easily!", My.Resources.EasyPresskit_logo)
        ElseIf appList_lst.SelectedItem = "EasyButler" Then
            appInfo.Info("EasyButler", "Update your Itch.IO Games easily!", My.Resources.EasySoftwareSuiteIconNew)
        ElseIf appList_lst.SelectedItem = "EasyConsole" Then
            appInfo.Info("EasyConsole", "A simple little console app.", My.Resources.EasySoftwareSuiteIconNew)
        End If
    End Sub

    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        ' Closes the App
        Application.Exit()
    End Sub

    Private Sub App_Launch_Btn_Click(sender As Object, e As EventArgs) Handles App_Launch_Btn.Click
        ' Launch Apps based on EXE Name, then closes the launcher.
        If appList_lst.SelectedItem = "EasyChangelog" Then
            Launch.Launch("EasyChangelog")
        ElseIf appList_lst.SelectedItem = "EasyGit" Then
            Launch.Launch("EasyGit")
        ElseIf appList_lst.SelectedItem = "EasyHTML" Then
            Launch.Launch("EasyHTML")
        ElseIf appList_lst.SelectedItem = "EasyHTML 2" Then
            Launch.Launch("EasyHTML 2")
        ElseIf appList_lst.SelectedItem = "EasyNodeJS" Then
            Launch.Launch("EasyNodeJS")
        ElseIf appList_lst.SelectedItem = "EasyPresskit" Then
            Launch.Launch("EasyPresskit")
        ElseIf appList_lst.SelectedItem = "EasyConsole" Then
            Launch.Launch("EasyConsole")
        ElseIf appList_lst.SelectedItem = "EasyButler" Then
            Launch.Launch("EasyButler")
        End If
    End Sub
End Class
