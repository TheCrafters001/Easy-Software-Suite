<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Editor
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Editor))
        Me.Pgs_Main = New System.Windows.Forms.TabControl()
        Me.Pg_Main = New System.Windows.Forms.TabPage()
        Me.grp_MainEditor = New System.Windows.Forms.GroupBox()
        Me.lbl_Security = New System.Windows.Forms.Label()
        Me.lbl_Fixed = New System.Windows.Forms.Label()
        Me.lst_security = New System.Windows.Forms.ListBox()
        Me.lbl_Removed = New System.Windows.Forms.Label()
        Me.lbl_Deprecated = New System.Windows.Forms.Label()
        Me.lbl_Changed = New System.Windows.Forms.Label()
        Me.lst_fixed = New System.Windows.Forms.ListBox()
        Me.lst_removed = New System.Windows.Forms.ListBox()
        Me.lst_Deprecated = New System.Windows.Forms.ListBox()
        Me.lst_changed = New System.Windows.Forms.ListBox()
        Me.lst_added = New System.Windows.Forms.ListBox()
        Me.lbl_added = New System.Windows.Forms.Label()
        Me.grp_Controls = New System.Windows.Forms.GroupBox()
        Me.btn_security = New System.Windows.Forms.Button()
        Me.btn_fixed = New System.Windows.Forms.Button()
        Me.btn_removed = New System.Windows.Forms.Button()
        Me.btn_deprecated = New System.Windows.Forms.Button()
        Me.btn_changed = New System.Windows.Forms.Button()
        Me.btn_added = New System.Windows.Forms.Button()
        Me.lbl_Note = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.HTMLEditorError = New System.Windows.Forms.TextBox()
        Me.Pg_Export = New System.Windows.Forms.TabPage()
        Me.Pg_About = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.gnuGpl_pic = New System.Windows.Forms.PictureBox()
        Me.copyright_lbl = New System.Windows.Forms.Label()
        Me.version_lbl = New System.Windows.Forms.Label()
        Me.aboutText_lbl = New System.Windows.Forms.Label()
        Me.aboutTitle_lbl = New System.Windows.Forms.Label()
        Me.aboutImg_pic = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SaveDialog = New System.Windows.Forms.SaveFileDialog()
        Me.OpenDialog = New System.Windows.Forms.OpenFileDialog()
        Me.grp_HTMLExport = New System.Windows.Forms.GroupBox()
        Me.btn_Export = New System.Windows.Forms.Button()
        Me.export_html = New System.Windows.Forms.RichTextBox()
        Me.Pgs_Main.SuspendLayout()
        Me.Pg_Main.SuspendLayout()
        Me.grp_MainEditor.SuspendLayout()
        Me.grp_Controls.SuspendLayout()
        Me.Pg_Export.SuspendLayout()
        Me.Pg_About.SuspendLayout()
        CType(Me.gnuGpl_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.aboutImg_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_HTMLExport.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pgs_Main
        '
        Me.Pgs_Main.Controls.Add(Me.Pg_Main)
        Me.Pgs_Main.Controls.Add(Me.Pg_Export)
        Me.Pgs_Main.Controls.Add(Me.Pg_About)
        Me.Pgs_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pgs_Main.Location = New System.Drawing.Point(0, 0)
        Me.Pgs_Main.Name = "Pgs_Main"
        Me.Pgs_Main.SelectedIndex = 0
        Me.Pgs_Main.Size = New System.Drawing.Size(1249, 626)
        Me.Pgs_Main.TabIndex = 1
        '
        'Pg_Main
        '
        Me.Pg_Main.BackColor = System.Drawing.Color.Gray
        Me.Pg_Main.Controls.Add(Me.grp_MainEditor)
        Me.Pg_Main.Controls.Add(Me.grp_Controls)
        Me.Pg_Main.Controls.Add(Me.Button1)
        Me.Pg_Main.Controls.Add(Me.HTMLEditorError)
        Me.Pg_Main.Location = New System.Drawing.Point(4, 22)
        Me.Pg_Main.Name = "Pg_Main"
        Me.Pg_Main.Padding = New System.Windows.Forms.Padding(3)
        Me.Pg_Main.Size = New System.Drawing.Size(1241, 600)
        Me.Pg_Main.TabIndex = 0
        Me.Pg_Main.Text = "Main Details"
        '
        'grp_MainEditor
        '
        Me.grp_MainEditor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_MainEditor.Controls.Add(Me.lbl_Security)
        Me.grp_MainEditor.Controls.Add(Me.lbl_Fixed)
        Me.grp_MainEditor.Controls.Add(Me.lst_security)
        Me.grp_MainEditor.Controls.Add(Me.lbl_Removed)
        Me.grp_MainEditor.Controls.Add(Me.lbl_Deprecated)
        Me.grp_MainEditor.Controls.Add(Me.lbl_Changed)
        Me.grp_MainEditor.Controls.Add(Me.lst_fixed)
        Me.grp_MainEditor.Controls.Add(Me.lst_removed)
        Me.grp_MainEditor.Controls.Add(Me.lst_Deprecated)
        Me.grp_MainEditor.Controls.Add(Me.lst_changed)
        Me.grp_MainEditor.Controls.Add(Me.lst_added)
        Me.grp_MainEditor.Controls.Add(Me.lbl_added)
        Me.grp_MainEditor.Location = New System.Drawing.Point(222, 6)
        Me.grp_MainEditor.Name = "grp_MainEditor"
        Me.grp_MainEditor.Size = New System.Drawing.Size(1011, 586)
        Me.grp_MainEditor.TabIndex = 18
        Me.grp_MainEditor.TabStop = False
        Me.grp_MainEditor.Text = "Main Details"
        '
        'lbl_Security
        '
        Me.lbl_Security.AutoSize = True
        Me.lbl_Security.Location = New System.Drawing.Point(841, 16)
        Me.lbl_Security.Name = "lbl_Security"
        Me.lbl_Security.Size = New System.Drawing.Size(45, 13)
        Me.lbl_Security.TabIndex = 11
        Me.lbl_Security.Text = "Security"
        '
        'lbl_Fixed
        '
        Me.lbl_Fixed.AutoSize = True
        Me.lbl_Fixed.Location = New System.Drawing.Point(674, 16)
        Me.lbl_Fixed.Name = "lbl_Fixed"
        Me.lbl_Fixed.Size = New System.Drawing.Size(32, 13)
        Me.lbl_Fixed.TabIndex = 10
        Me.lbl_Fixed.Text = "Fixed"
        '
        'lst_security
        '
        Me.lst_security.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lst_security.FormattingEnabled = True
        Me.lst_security.Location = New System.Drawing.Point(844, 32)
        Me.lst_security.Name = "lst_security"
        Me.lst_security.Size = New System.Drawing.Size(161, 550)
        Me.lst_security.TabIndex = 9
        '
        'lbl_Removed
        '
        Me.lbl_Removed.AutoSize = True
        Me.lbl_Removed.Location = New System.Drawing.Point(510, 16)
        Me.lbl_Removed.Name = "lbl_Removed"
        Me.lbl_Removed.Size = New System.Drawing.Size(53, 13)
        Me.lbl_Removed.TabIndex = 8
        Me.lbl_Removed.Text = "Removed"
        '
        'lbl_Deprecated
        '
        Me.lbl_Deprecated.AutoSize = True
        Me.lbl_Deprecated.Location = New System.Drawing.Point(343, 16)
        Me.lbl_Deprecated.Name = "lbl_Deprecated"
        Me.lbl_Deprecated.Size = New System.Drawing.Size(63, 13)
        Me.lbl_Deprecated.TabIndex = 7
        Me.lbl_Deprecated.Text = "Deprecated"
        '
        'lbl_Changed
        '
        Me.lbl_Changed.AutoSize = True
        Me.lbl_Changed.Location = New System.Drawing.Point(173, 16)
        Me.lbl_Changed.Name = "lbl_Changed"
        Me.lbl_Changed.Size = New System.Drawing.Size(50, 13)
        Me.lbl_Changed.TabIndex = 6
        Me.lbl_Changed.Text = "Changed"
        '
        'lst_fixed
        '
        Me.lst_fixed.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lst_fixed.FormattingEnabled = True
        Me.lst_fixed.Location = New System.Drawing.Point(677, 32)
        Me.lst_fixed.Name = "lst_fixed"
        Me.lst_fixed.Size = New System.Drawing.Size(161, 550)
        Me.lst_fixed.TabIndex = 5
        '
        'lst_removed
        '
        Me.lst_removed.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lst_removed.FormattingEnabled = True
        Me.lst_removed.Location = New System.Drawing.Point(510, 32)
        Me.lst_removed.Name = "lst_removed"
        Me.lst_removed.Size = New System.Drawing.Size(161, 550)
        Me.lst_removed.TabIndex = 4
        '
        'lst_Deprecated
        '
        Me.lst_Deprecated.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lst_Deprecated.FormattingEnabled = True
        Me.lst_Deprecated.Location = New System.Drawing.Point(343, 32)
        Me.lst_Deprecated.Name = "lst_Deprecated"
        Me.lst_Deprecated.Size = New System.Drawing.Size(161, 550)
        Me.lst_Deprecated.TabIndex = 3
        '
        'lst_changed
        '
        Me.lst_changed.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lst_changed.FormattingEnabled = True
        Me.lst_changed.Location = New System.Drawing.Point(176, 32)
        Me.lst_changed.Name = "lst_changed"
        Me.lst_changed.Size = New System.Drawing.Size(161, 550)
        Me.lst_changed.TabIndex = 2
        '
        'lst_added
        '
        Me.lst_added.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lst_added.FormattingEnabled = True
        Me.lst_added.Location = New System.Drawing.Point(9, 32)
        Me.lst_added.Name = "lst_added"
        Me.lst_added.Size = New System.Drawing.Size(161, 550)
        Me.lst_added.TabIndex = 1
        '
        'lbl_added
        '
        Me.lbl_added.AutoSize = True
        Me.lbl_added.Location = New System.Drawing.Point(6, 16)
        Me.lbl_added.Name = "lbl_added"
        Me.lbl_added.Size = New System.Drawing.Size(38, 13)
        Me.lbl_added.TabIndex = 0
        Me.lbl_added.Text = "Added"
        '
        'grp_Controls
        '
        Me.grp_Controls.Controls.Add(Me.btn_security)
        Me.grp_Controls.Controls.Add(Me.btn_fixed)
        Me.grp_Controls.Controls.Add(Me.btn_removed)
        Me.grp_Controls.Controls.Add(Me.btn_deprecated)
        Me.grp_Controls.Controls.Add(Me.btn_changed)
        Me.grp_Controls.Controls.Add(Me.btn_added)
        Me.grp_Controls.Controls.Add(Me.lbl_Note)
        Me.grp_Controls.Location = New System.Drawing.Point(8, 6)
        Me.grp_Controls.Name = "grp_Controls"
        Me.grp_Controls.Size = New System.Drawing.Size(208, 550)
        Me.grp_Controls.TabIndex = 17
        Me.grp_Controls.TabStop = False
        Me.grp_Controls.Text = "Controls"
        '
        'btn_security
        '
        Me.btn_security.ForeColor = System.Drawing.Color.Black
        Me.btn_security.Location = New System.Drawing.Point(9, 164)
        Me.btn_security.Name = "btn_security"
        Me.btn_security.Size = New System.Drawing.Size(193, 23)
        Me.btn_security.TabIndex = 6
        Me.btn_security.Text = "Add to Security"
        Me.btn_security.UseVisualStyleBackColor = True
        '
        'btn_fixed
        '
        Me.btn_fixed.ForeColor = System.Drawing.Color.Black
        Me.btn_fixed.Location = New System.Drawing.Point(9, 135)
        Me.btn_fixed.Name = "btn_fixed"
        Me.btn_fixed.Size = New System.Drawing.Size(193, 23)
        Me.btn_fixed.TabIndex = 5
        Me.btn_fixed.Text = "Add to Fixed"
        Me.btn_fixed.UseVisualStyleBackColor = True
        '
        'btn_removed
        '
        Me.btn_removed.ForeColor = System.Drawing.Color.Black
        Me.btn_removed.Location = New System.Drawing.Point(9, 106)
        Me.btn_removed.Name = "btn_removed"
        Me.btn_removed.Size = New System.Drawing.Size(193, 23)
        Me.btn_removed.TabIndex = 4
        Me.btn_removed.Text = "Add to Removed"
        Me.btn_removed.UseVisualStyleBackColor = True
        '
        'btn_deprecated
        '
        Me.btn_deprecated.ForeColor = System.Drawing.Color.Black
        Me.btn_deprecated.Location = New System.Drawing.Point(9, 77)
        Me.btn_deprecated.Name = "btn_deprecated"
        Me.btn_deprecated.Size = New System.Drawing.Size(193, 23)
        Me.btn_deprecated.TabIndex = 3
        Me.btn_deprecated.Text = "Add to Deprecated"
        Me.btn_deprecated.UseVisualStyleBackColor = True
        '
        'btn_changed
        '
        Me.btn_changed.ForeColor = System.Drawing.Color.Black
        Me.btn_changed.Location = New System.Drawing.Point(9, 48)
        Me.btn_changed.Name = "btn_changed"
        Me.btn_changed.Size = New System.Drawing.Size(193, 23)
        Me.btn_changed.TabIndex = 2
        Me.btn_changed.Text = "Add to Changed"
        Me.btn_changed.UseVisualStyleBackColor = True
        '
        'btn_added
        '
        Me.btn_added.ForeColor = System.Drawing.Color.Black
        Me.btn_added.Location = New System.Drawing.Point(9, 19)
        Me.btn_added.Name = "btn_added"
        Me.btn_added.Size = New System.Drawing.Size(193, 23)
        Me.btn_added.TabIndex = 1
        Me.btn_added.Text = "Add to Added"
        Me.btn_added.UseVisualStyleBackColor = True
        '
        'lbl_Note
        '
        Me.lbl_Note.Location = New System.Drawing.Point(6, 516)
        Me.lbl_Note.Name = "lbl_Note"
        Me.lbl_Note.Size = New System.Drawing.Size(196, 31)
        Me.lbl_Note.TabIndex = 0
        Me.lbl_Note.Text = "Any item can be removed by double clicking it on any list."
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(8, 562)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(208, 30)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "EasyHTML"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HTMLEditorError
        '
        Me.HTMLEditorError.Location = New System.Drawing.Point(927, 584)
        Me.HTMLEditorError.Name = "HTMLEditorError"
        Me.HTMLEditorError.Size = New System.Drawing.Size(17, 20)
        Me.HTMLEditorError.TabIndex = 0
        Me.HTMLEditorError.Visible = False
        '
        'Pg_Export
        '
        Me.Pg_Export.BackColor = System.Drawing.Color.Gray
        Me.Pg_Export.Controls.Add(Me.btn_Export)
        Me.Pg_Export.Controls.Add(Me.grp_HTMLExport)
        Me.Pg_Export.Location = New System.Drawing.Point(4, 22)
        Me.Pg_Export.Name = "Pg_Export"
        Me.Pg_Export.Size = New System.Drawing.Size(1241, 600)
        Me.Pg_Export.TabIndex = 2
        Me.Pg_Export.Text = "Export"
        '
        'Pg_About
        '
        Me.Pg_About.BackColor = System.Drawing.Color.Gray
        Me.Pg_About.Controls.Add(Me.Button2)
        Me.Pg_About.Controls.Add(Me.gnuGpl_pic)
        Me.Pg_About.Controls.Add(Me.copyright_lbl)
        Me.Pg_About.Controls.Add(Me.version_lbl)
        Me.Pg_About.Controls.Add(Me.aboutText_lbl)
        Me.Pg_About.Controls.Add(Me.aboutTitle_lbl)
        Me.Pg_About.Controls.Add(Me.aboutImg_pic)
        Me.Pg_About.Location = New System.Drawing.Point(4, 22)
        Me.Pg_About.Name = "Pg_About"
        Me.Pg_About.Padding = New System.Windows.Forms.Padding(3)
        Me.Pg_About.Size = New System.Drawing.Size(1241, 600)
        Me.Pg_About.TabIndex = 4
        Me.Pg_About.Text = "About"
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(164, 569)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(159, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Third Party Licenses"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'gnuGpl_pic
        '
        Me.gnuGpl_pic.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gnuGpl_pic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gnuGpl_pic.Image = Global.EasyChangelog.My.Resources.Resources.GNUGPL3
        Me.gnuGpl_pic.Location = New System.Drawing.Point(1099, 524)
        Me.gnuGpl_pic.Name = "gnuGpl_pic"
        Me.gnuGpl_pic.Size = New System.Drawing.Size(136, 68)
        Me.gnuGpl_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.gnuGpl_pic.TabIndex = 5
        Me.gnuGpl_pic.TabStop = False
        '
        'copyright_lbl
        '
        Me.copyright_lbl.AutoSize = True
        Me.copyright_lbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.copyright_lbl.Location = New System.Drawing.Point(167, 101)
        Me.copyright_lbl.Name = "copyright_lbl"
        Me.copyright_lbl.Size = New System.Drawing.Size(108, 21)
        Me.copyright_lbl.TabIndex = 4
        Me.copyright_lbl.Text = "Copyright LBL"
        '
        'version_lbl
        '
        Me.version_lbl.AutoSize = True
        Me.version_lbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.version_lbl.Location = New System.Drawing.Point(167, 80)
        Me.version_lbl.Name = "version_lbl"
        Me.version_lbl.Size = New System.Drawing.Size(114, 21)
        Me.version_lbl.TabIndex = 3
        Me.version_lbl.Text = "Version: X.X.X.X"
        '
        'aboutText_lbl
        '
        Me.aboutText_lbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.aboutText_lbl.Location = New System.Drawing.Point(168, 46)
        Me.aboutText_lbl.Name = "aboutText_lbl"
        Me.aboutText_lbl.Size = New System.Drawing.Size(1065, 34)
        Me.aboutText_lbl.TabIndex = 2
        Me.aboutText_lbl.Text = resources.GetString("aboutText_lbl.Text")
        '
        'aboutTitle_lbl
        '
        Me.aboutTitle_lbl.AutoSize = True
        Me.aboutTitle_lbl.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aboutTitle_lbl.Location = New System.Drawing.Point(164, 6)
        Me.aboutTitle_lbl.Name = "aboutTitle_lbl"
        Me.aboutTitle_lbl.Size = New System.Drawing.Size(224, 40)
        Me.aboutTitle_lbl.TabIndex = 1
        Me.aboutTitle_lbl.Text = "EasyChangelog"
        '
        'aboutImg_pic
        '
        Me.aboutImg_pic.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.aboutImg_pic.Image = Global.EasyChangelog.My.Resources.Resources.Side
        Me.aboutImg_pic.Location = New System.Drawing.Point(8, 6)
        Me.aboutImg_pic.Name = "aboutImg_pic"
        Me.aboutImg_pic.Size = New System.Drawing.Size(150, 588)
        Me.aboutImg_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.aboutImg_pic.TabIndex = 0
        Me.aboutImg_pic.TabStop = False
        '
        'Timer1
        '
        '
        'grp_HTMLExport
        '
        Me.grp_HTMLExport.Controls.Add(Me.export_html)
        Me.grp_HTMLExport.Location = New System.Drawing.Point(8, 3)
        Me.grp_HTMLExport.Name = "grp_HTMLExport"
        Me.grp_HTMLExport.Size = New System.Drawing.Size(1225, 560)
        Me.grp_HTMLExport.TabIndex = 1
        Me.grp_HTMLExport.TabStop = False
        Me.grp_HTMLExport.Text = "HTML"
        '
        'btn_Export
        '
        Me.btn_Export.ForeColor = System.Drawing.Color.Black
        Me.btn_Export.Location = New System.Drawing.Point(1155, 569)
        Me.btn_Export.Name = "btn_Export"
        Me.btn_Export.Size = New System.Drawing.Size(75, 23)
        Me.btn_Export.TabIndex = 2
        Me.btn_Export.Text = "Export"
        Me.btn_Export.UseVisualStyleBackColor = True
        '
        'export_html
        '
        Me.export_html.Dock = System.Windows.Forms.DockStyle.Fill
        Me.export_html.Location = New System.Drawing.Point(3, 16)
        Me.export_html.Name = "export_html"
        Me.export_html.ReadOnly = True
        Me.export_html.Size = New System.Drawing.Size(1219, 541)
        Me.export_html.TabIndex = 0
        Me.export_html.Text = ""
        '
        'Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1249, 626)
        Me.Controls.Add(Me.Pgs_Main)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Editor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EasyChangelog"
        Me.Pgs_Main.ResumeLayout(False)
        Me.Pg_Main.ResumeLayout(False)
        Me.Pg_Main.PerformLayout()
        Me.grp_MainEditor.ResumeLayout(False)
        Me.grp_MainEditor.PerformLayout()
        Me.grp_Controls.ResumeLayout(False)
        Me.Pg_Export.ResumeLayout(False)
        Me.Pg_About.ResumeLayout(False)
        Me.Pg_About.PerformLayout()
        CType(Me.gnuGpl_pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.aboutImg_pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_HTMLExport.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pgs_Main As TabControl
    Friend WithEvents Pg_Main As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents HTMLEditorError As TextBox
    Friend WithEvents Pg_Export As TabPage
    Friend WithEvents Pg_About As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents gnuGpl_pic As PictureBox
    Friend WithEvents copyright_lbl As Label
    Friend WithEvents version_lbl As Label
    Friend WithEvents aboutText_lbl As Label
    Friend WithEvents aboutTitle_lbl As Label
    Friend WithEvents aboutImg_pic As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SaveDialog As SaveFileDialog
    Friend WithEvents OpenDialog As OpenFileDialog
    Friend WithEvents grp_Controls As GroupBox
    Friend WithEvents grp_MainEditor As GroupBox
    Friend WithEvents lbl_added As Label
    Friend WithEvents lst_Deprecated As ListBox
    Friend WithEvents lst_changed As ListBox
    Friend WithEvents lst_added As ListBox
    Friend WithEvents lbl_Changed As Label
    Friend WithEvents lst_fixed As ListBox
    Friend WithEvents lst_removed As ListBox
    Friend WithEvents lbl_Deprecated As Label
    Friend WithEvents lbl_Removed As Label
    Friend WithEvents lbl_Fixed As Label
    Friend WithEvents lst_security As ListBox
    Friend WithEvents lbl_Security As Label
    Friend WithEvents lbl_Note As Label
    Friend WithEvents btn_added As Button
    Friend WithEvents btn_security As Button
    Friend WithEvents btn_fixed As Button
    Friend WithEvents btn_removed As Button
    Friend WithEvents btn_deprecated As Button
    Friend WithEvents btn_changed As Button
    Friend WithEvents grp_HTMLExport As GroupBox
    Friend WithEvents btn_Export As Button
    Friend WithEvents export_html As RichTextBox
End Class
