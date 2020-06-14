Public Class EasyHTML
    Private Sub EasyHTML_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_Export_Click(sender As Object, e As EventArgs) Handles Btn_Export.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BugReport.Show()
        BugReport.TextBox1.Text = "Test Report"
        Me.Close()
    End Sub
End Class