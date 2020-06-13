Public Class EasyHTML
    Private Sub EasyHTML_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Theme = "Dark" Then
            Theme_Color_ComboBox.SelectedIndex = 0
        ElseIf My.Settings.Theme = "Light" Then
            Theme_Color_ComboBox.SelectedIndex = 1
        End If
    End Sub
End Class