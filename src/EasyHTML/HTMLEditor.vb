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
    Dim viewport As String
    Dim metatag As String
    Dim pageBody As String
    Dim iecompat As String
    Dim credit As String
    Dim sb As New System.Text.StringBuilder()
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        pageBody = CodeEditorBox.Text
        Code_Export_Code_Box.Text = pageBody

    End Sub

    Private Sub Component_Box_DoubleClick(sender As Object, e As EventArgs) Handles Component_Box.DoubleClick
        CodeEditorBox.Text &= vbCrLf & Me.Component_Box.SelectedItem()
    End Sub

    Private Sub cssImport_lst_DoubleClick(sender As Object, e As EventArgs) Handles cssImport_lst.DoubleClick
        Me.cssImport_lst.Items.Remove(Me.cssImport_lst.SelectedItem)
    End Sub

    Private Sub jsImport_list_DoubleClick(sender As Object, e As EventArgs) Handles jsImport_lst.DoubleClick
        Me.jsImport_lst.Items.Remove(Me.jsImport_lst.SelectedItem)
    End Sub
End Class