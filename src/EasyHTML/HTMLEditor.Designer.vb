<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EasyHTML
    Inherits MetroFramework.Forms.MetroForm

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
        Me.components = New System.ComponentModel.Container()
        Me.EditorWindow = New MetroFramework.Controls.MetroTabControl()
        Me.MainDetailsPage = New MetroFramework.Controls.MetroTabPage()
        Me.Page_Title_Label = New MetroFramework.Controls.MetroLabel()
        Me.Page_Title_TextBox = New MetroFramework.Controls.MetroTextBox()
        Me.MetaTags_Show_Toggle = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        Me.Settings_page = New MetroFramework.Controls.MetroTabPage()
        Me.ThemeColor_Label = New MetroFramework.Controls.MetroLabel()
        Me.Theme_Color_ComboBox = New MetroFramework.Controls.MetroComboBox()
        Me.EditorWindow.SuspendLayout()
        Me.MainDetailsPage.SuspendLayout()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Settings_page.SuspendLayout()
        Me.SuspendLayout()
        '
        'EditorWindow
        '
        Me.EditorWindow.Controls.Add(Me.MainDetailsPage)
        Me.EditorWindow.Controls.Add(Me.Settings_page)
        Me.EditorWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EditorWindow.Location = New System.Drawing.Point(20, 60)
        Me.EditorWindow.Name = "EditorWindow"
        Me.EditorWindow.SelectedIndex = 1
        Me.EditorWindow.Size = New System.Drawing.Size(1091, 589)
        Me.EditorWindow.Style = MetroFramework.MetroColorStyle.Green
        Me.EditorWindow.TabIndex = 0
        Me.EditorWindow.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.EditorWindow.UseStyleColors = True
        '
        'MainDetailsPage
        '
        Me.MainDetailsPage.Controls.Add(Me.MetroLabel1)
        Me.MainDetailsPage.Controls.Add(Me.MetaTags_Show_Toggle)
        Me.MainDetailsPage.Controls.Add(Me.Page_Title_TextBox)
        Me.MainDetailsPage.Controls.Add(Me.Page_Title_Label)
        Me.MainDetailsPage.HorizontalScrollbarBarColor = True
        Me.MainDetailsPage.Location = New System.Drawing.Point(4, 35)
        Me.MainDetailsPage.Name = "MainDetailsPage"
        Me.MainDetailsPage.Size = New System.Drawing.Size(1083, 550)
        Me.MainDetailsPage.Style = MetroFramework.MetroColorStyle.Green
        Me.MainDetailsPage.TabIndex = 0
        Me.MainDetailsPage.Text = "Main"
        Me.MainDetailsPage.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MainDetailsPage.VerticalScrollbarBarColor = True
        '
        'Page_Title_Label
        '
        Me.Page_Title_Label.AutoSize = True
        Me.Page_Title_Label.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.Page_Title_Label.Location = New System.Drawing.Point(3, 0)
        Me.Page_Title_Label.Name = "Page_Title_Label"
        Me.Page_Title_Label.Size = New System.Drawing.Size(85, 25)
        Me.Page_Title_Label.Style = MetroFramework.MetroColorStyle.Green
        Me.Page_Title_Label.TabIndex = 2
        Me.Page_Title_Label.Text = "Page Title"
        Me.Page_Title_Label.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'Page_Title_TextBox
        '
        Me.Page_Title_TextBox.Location = New System.Drawing.Point(3, 28)
        Me.Page_Title_TextBox.Name = "Page_Title_TextBox"
        Me.Page_Title_TextBox.Size = New System.Drawing.Size(204, 23)
        Me.Page_Title_TextBox.Style = MetroFramework.MetroColorStyle.Green
        Me.Page_Title_TextBox.TabIndex = 3
        Me.Page_Title_TextBox.Text = "Example Page"
        Me.Page_Title_TextBox.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetaTags_Show_Toggle
        '
        Me.MetaTags_Show_Toggle.Checked = True
        Me.MetaTags_Show_Toggle.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MetaTags_Show_Toggle.Location = New System.Drawing.Point(226, 28)
        Me.MetaTags_Show_Toggle.Name = "MetaTags_Show_Toggle"
        Me.MetaTags_Show_Toggle.Size = New System.Drawing.Size(98, 23)
        Me.MetaTags_Show_Toggle.Style = MetroFramework.MetroColorStyle.Green
        Me.MetaTags_Show_Toggle.TabIndex = 4
        Me.MetaTags_Show_Toggle.Text = "On"
        Me.MetaTags_Show_Toggle.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetaTags_Show_Toggle.UseVisualStyleBackColor = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(215, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(120, 25)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel1.TabIndex = 5
        Me.MetroLabel1.Text = "Add Meta Info"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Nothing
        Me.MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'Settings_page
        '
        Me.Settings_page.Controls.Add(Me.Theme_Color_ComboBox)
        Me.Settings_page.Controls.Add(Me.ThemeColor_Label)
        Me.Settings_page.HorizontalScrollbarBarColor = True
        Me.Settings_page.Location = New System.Drawing.Point(4, 35)
        Me.Settings_page.Name = "Settings_page"
        Me.Settings_page.Size = New System.Drawing.Size(1083, 550)
        Me.Settings_page.Style = MetroFramework.MetroColorStyle.Green
        Me.Settings_page.TabIndex = 1
        Me.Settings_page.Text = "Settings"
        Me.Settings_page.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Settings_page.VerticalScrollbarBarColor = True
        '
        'ThemeColor_Label
        '
        Me.ThemeColor_Label.AutoSize = True
        Me.ThemeColor_Label.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.ThemeColor_Label.Location = New System.Drawing.Point(3, 0)
        Me.ThemeColor_Label.Name = "ThemeColor_Label"
        Me.ThemeColor_Label.Size = New System.Drawing.Size(70, 25)
        Me.ThemeColor_Label.Style = MetroFramework.MetroColorStyle.Green
        Me.ThemeColor_Label.TabIndex = 2
        Me.ThemeColor_Label.Text = "Theme"
        Me.ThemeColor_Label.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'Theme_Color_ComboBox
        '
        Me.Theme_Color_ComboBox.FormattingEnabled = True
        Me.Theme_Color_ComboBox.ItemHeight = 23
        Me.Theme_Color_ComboBox.Items.AddRange(New Object() {"Dark", "Light"})
        Me.Theme_Color_ComboBox.Location = New System.Drawing.Point(3, 28)
        Me.Theme_Color_ComboBox.Name = "Theme_Color_ComboBox"
        Me.Theme_Color_ComboBox.Size = New System.Drawing.Size(121, 29)
        Me.Theme_Color_ComboBox.Style = MetroFramework.MetroColorStyle.Green
        Me.Theme_Color_ComboBox.TabIndex = 3
        Me.Theme_Color_ComboBox.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'EasyHTML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(1131, 669)
        Me.Controls.Add(Me.EditorWindow)
        Me.Name = "EasyHTML"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "EasyHTML"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.EditorWindow.ResumeLayout(False)
        Me.MainDetailsPage.ResumeLayout(False)
        Me.MainDetailsPage.PerformLayout()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Settings_page.ResumeLayout(False)
        Me.Settings_page.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EditorWindow As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MainDetailsPage As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetaTags_Show_Toggle As MetroFramework.Controls.MetroToggle
    Friend WithEvents Page_Title_TextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Page_Title_Label As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
    Friend WithEvents MetroStyleExtender1 As MetroFramework.Components.MetroStyleExtender
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
    Friend WithEvents Settings_page As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Theme_Color_ComboBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents ThemeColor_Label As MetroFramework.Controls.MetroLabel
End Class
