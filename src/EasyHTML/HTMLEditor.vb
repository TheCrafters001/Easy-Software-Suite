Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports AutoUpdaterDotNET
Public Class EasyHTML
#Region "Misc"
    Private Sub EasyHTML_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeSelect.Show()
        ThemeSelect.TopMost = True
        Timer1.Start()
    End Sub

    Private Sub Btn_Export_Click(sender As Object, e As EventArgs) Handles Btn_Export.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        HTMLEditorError.Text = "Test"
        BugReport.Show()
    End Sub

    Private Sub EasyHTML_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ThemeSelect.Close()
    End Sub
#End Region
#Region "Generator"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim viewport As String
        Dim metatag As String = ""
        Dim pageBody As String
        Dim iecompat As String = ""
        Dim credit As String
        Dim cssImport As New System.Text.StringBuilder()
        Dim jsImport As New System.Text.StringBuilder()
#Region "Credit"
        If credit_chkbox.Checked = True Then
            credit = "<hr><iframe style=""width: 100%; height: 250px; overflow: hidden;"" src=""https://api.thecrafters001.ga/credit/Easy.HTML"" width=""100%"" height=""50px"" scrolling=""no"" frameborder=""0"">Iframes not supported</iframe>"
        ElseIf credit_chkbox.Checked = False Then
            credit = ""
        End If
#End Region
#Region "Viewport"
        If mobileViewport_chkbox.Checked = True Then
            viewport = "<meta name=""viewport"" content=""width=device-width, initial-scale=1"">"
        ElseIf mobileViewport_chkbox.Checked = False Then
            viewport = ""
        End If
#End Region
#Region "cssImport"
        For Each o As Object In cssImport_lst.Items
            cssImport.AppendLine("<link rel=""stylesheet"" href=""" & o & """ />")
        Next
#End Region
#Region "jsImport"
        For Each p As Object In jsImport_lst.Items
            jsImport.AppendLine("<script src=""" & p & """></script>")
        Next

#End Region
        pageBody = CodeEditorBox.Text
        Code_Export_Code_Box.Text = "<!DOCTYPE html>" & vbCrLf & "<head>" & vbCrLf & "<title>" & pageTitle_txtBox.Text & "</title>" & vbCrLf &
            viewport.ToString & vbCrLf & iecompat.ToString & vbCrLf & metatag.ToString & vbCrLf & cssImport.ToString() & vbCrLf &
            "</head>" & vbCrLf & "<body>" & vbCrLf & pageBody & vbCrLf & jsImport.ToString() & vbCrLf & "</body>" & vbCrLf & "</html>"

    End Sub
#End Region
#Region "Editor"
    Private Sub Component_Box_DoubleClick(sender As Object, e As EventArgs) Handles Component_Box.DoubleClick
        CodeEditorBox.Text &= vbCrLf & Me.Component_Box.SelectedItem()
    End Sub

    Private Sub cssImport_lst_DoubleClick(sender As Object, e As EventArgs) Handles cssImport_lst.DoubleClick
        Me.cssImport_lst.Items.Remove(Me.cssImport_lst.SelectedItem)
    End Sub

    Private Sub jsImport_list_DoubleClick(sender As Object, e As EventArgs) Handles jsImport_lst.DoubleClick
        Me.jsImport_lst.Items.Remove(Me.jsImport_lst.SelectedItem)
    End Sub

    Private Sub updatePreview_btn_Click(sender As Object, e As EventArgs) Handles updatePreview_btn.Click
        WebBrowser1.DocumentText = Code_Export_Code_Box.Text
    End Sub

    Private Sub cssImport_btn_Click(sender As Object, e As EventArgs) Handles cssImport_btn.Click
        Dim cssinput As String = InputBox("Please enter your CSS Library Location" & "(example: http://example.com/css/style.css)", "CSS Import")
        cssImport_lst.Items.Add(cssinput)
    End Sub

    Private Sub jsImport_btn_Click(sender As Object, e As EventArgs) Handles jsImport_btn.Click
        Dim jsinput As String = InputBox("Please enter your JavaScrupt Library Location" & "(example: http://example.com/js/script.js)", "JavaScript Import")
        jsImport_lst.Items.Add(jsinput)
    End Sub
#End Region
End Class