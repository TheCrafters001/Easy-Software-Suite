Public Class appInfo
    Public Shared Sub Info(ByVal name As String, ByVal Desc As String, ByVal img As Image)
        launcherNew.app_logo_picbox.Image = img
        launcherNew.app_name_lbl.Text = name
        launcherNew.app_desc_rchtxtBox.text = Desc
    End Sub
End Class
