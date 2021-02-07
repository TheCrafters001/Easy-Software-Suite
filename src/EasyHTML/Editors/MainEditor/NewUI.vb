Public Class NewUI
    Private Sub NewUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set BackColor of main window
        Me.BackColor = Color.FromArgb(124, 63, 255)
    End Sub

    Private Sub classicUI_btn_Click(sender As Object, e As EventArgs) Handles classicUI_btn.Click
        EasyHTML.Show()
        Me.Close()
    End Sub
End Class