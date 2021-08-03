Public Class Generator
    Public Shared Function Generate()
        Dim viewPort As String
        Dim metaTag As String
        Dim utf8CharSet As String
        Dim pageHead As String
        Dim pageBody As String
        Dim pageFooter As String
        Dim ieCompat As String
        Dim cssImport As System.Text.StringBuilder
        Dim jsImport As System.Text.StringBuilder
        Dim credits_string As String

        Dim output As String

#Region "Credits"
        ' This section handles if the credits are on or not.
        If EasyHTML_Two.credit_chkbox.Checked = True Then
            credits_string = "<hr><div align=""center""><h3>Built with EasyHTML 2</h3><P>You can get EasyHTML 2, a free, open-source HTML editor, today at no cost! EasyHTML is a part of the Easy Software Suite, made by TheCrafters001<br><br><form action=""https://github.com/TheCrafters001/Easy-Software-Suite/releases/latest""><input type=""submit"" value=""Get EasyHTML 2 Now!"" /></form></P></div>"
        ElseIf EasyHTML_Two.credit_chkbox.checked = False Then
            credits_string = ""
        End If
#End Region

#Region "Viewport"
        ' This will handle the view port meta tag.

#End Region
        Return output
    End Function
End Class
