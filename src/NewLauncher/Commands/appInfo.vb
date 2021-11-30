Public Class appInfo
    Public Shared Sub Info(ByVal name As String, ByVal Desc As String, ByVal img As Image)
        Form1.app_logo_picbox.Image = img
        Form1.app_name_lbl.Text = name
        Form1.app_desc_rchtxtBox.text = Desc
    End Sub
End Class
