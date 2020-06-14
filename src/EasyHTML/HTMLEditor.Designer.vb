<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EasyHTML
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Pgs_Main = New System.Windows.Forms.TabControl()
        Me.MainPageDetails = New System.Windows.Forms.TabPage()
        Me.Test_Page = New System.Windows.Forms.TabPage()
        Me.Pg_Export = New System.Windows.Forms.TabPage()
        Me.Pg_Preview = New System.Windows.Forms.TabPage()
        Me.Code_Export_Code_Box = New System.Windows.Forms.RichTextBox()
        Me.Btn_Export = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Pgs_Main.SuspendLayout()
        Me.Test_Page.SuspendLayout()
        Me.Pg_Export.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pgs_Main
        '
        Me.Pgs_Main.Controls.Add(Me.MainPageDetails)
        Me.Pgs_Main.Controls.Add(Me.Pg_Export)
        Me.Pgs_Main.Controls.Add(Me.Pg_Preview)
        Me.Pgs_Main.Controls.Add(Me.Test_Page)
        Me.Pgs_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pgs_Main.Location = New System.Drawing.Point(0, 0)
        Me.Pgs_Main.Name = "Pgs_Main"
        Me.Pgs_Main.SelectedIndex = 0
        Me.Pgs_Main.Size = New System.Drawing.Size(909, 626)
        Me.Pgs_Main.TabIndex = 0
        '
        'MainPageDetails
        '
        Me.MainPageDetails.BackColor = System.Drawing.Color.Gray
        Me.MainPageDetails.Location = New System.Drawing.Point(4, 22)
        Me.MainPageDetails.Name = "MainPageDetails"
        Me.MainPageDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.MainPageDetails.Size = New System.Drawing.Size(901, 600)
        Me.MainPageDetails.TabIndex = 0
        Me.MainPageDetails.Text = "Main Details"
        '
        'Test_Page
        '
        Me.Test_Page.BackColor = System.Drawing.Color.Gray
        Me.Test_Page.Controls.Add(Me.Button1)
        Me.Test_Page.Location = New System.Drawing.Point(4, 22)
        Me.Test_Page.Name = "Test_Page"
        Me.Test_Page.Padding = New System.Windows.Forms.Padding(3)
        Me.Test_Page.Size = New System.Drawing.Size(901, 600)
        Me.Test_Page.TabIndex = 1
        Me.Test_Page.Text = "Test Page"
        '
        'Pg_Export
        '
        Me.Pg_Export.BackColor = System.Drawing.Color.Gray
        Me.Pg_Export.Controls.Add(Me.Btn_Export)
        Me.Pg_Export.Controls.Add(Me.Code_Export_Code_Box)
        Me.Pg_Export.Location = New System.Drawing.Point(4, 22)
        Me.Pg_Export.Name = "Pg_Export"
        Me.Pg_Export.Size = New System.Drawing.Size(901, 600)
        Me.Pg_Export.TabIndex = 2
        Me.Pg_Export.Text = "Export"
        '
        'Pg_Preview
        '
        Me.Pg_Preview.BackColor = System.Drawing.Color.Gray
        Me.Pg_Preview.Location = New System.Drawing.Point(4, 22)
        Me.Pg_Preview.Name = "Pg_Preview"
        Me.Pg_Preview.Size = New System.Drawing.Size(901, 600)
        Me.Pg_Preview.TabIndex = 3
        Me.Pg_Preview.Text = "Preview"
        '
        'Code_Export_Code_Box
        '
        Me.Code_Export_Code_Box.Location = New System.Drawing.Point(0, 0)
        Me.Code_Export_Code_Box.Name = "Code_Export_Code_Box"
        Me.Code_Export_Code_Box.ReadOnly = True
        Me.Code_Export_Code_Box.Size = New System.Drawing.Size(901, 563)
        Me.Code_Export_Code_Box.TabIndex = 0
        Me.Code_Export_Code_Box.Text = ""
        '
        'Btn_Export
        '
        Me.Btn_Export.ForeColor = System.Drawing.Color.Black
        Me.Btn_Export.Location = New System.Drawing.Point(818, 574)
        Me.Btn_Export.Name = "Btn_Export"
        Me.Btn_Export.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Export.TabIndex = 1
        Me.Btn_Export.Text = "Export"
        Me.Btn_Export.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(8, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(202, 176)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "BugPageShow"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EasyHTML
        '
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(909, 626)
        Me.Controls.Add(Me.Pgs_Main)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "EasyHTML"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EasyHTML"
        Me.Pgs_Main.ResumeLayout(False)
        Me.Test_Page.ResumeLayout(False)
        Me.Pg_Export.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pgs_Main As TabControl
    Friend WithEvents MainPageDetails As TabPage
    Friend WithEvents Pg_Export As TabPage
    Friend WithEvents Btn_Export As Button
    Friend WithEvents Code_Export_Code_Box As RichTextBox
    Friend WithEvents Pg_Preview As TabPage
    Friend WithEvents Test_Page As TabPage
    Friend WithEvents Button1 As Button
End Class
