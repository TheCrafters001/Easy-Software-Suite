<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EasyHTML_Two
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
        Me.Pgs_Main = New EasyHTML_2.BonfireTabControl()
        Me.Pg_Details = New System.Windows.Forms.TabPage()
        Me.jsLibraries_grp = New EasyHTML_2.BonfireGroupBox()
        Me.jsImport_lst = New System.Windows.Forms.ListBox()
        Me.jsImport_btn = New EasyHTML_2.BonfireButton()
        Me.jsLibrariesTitle_lbl = New EasyHTML_2.BonfireLabel()
        Me.cssLibraries_grp = New EasyHTML_2.BonfireGroupBox()
        Me.cssImport_lst = New System.Windows.Forms.ListBox()
        Me.cssImport_btn = New EasyHTML_2.BonfireButton()
        Me.cssLibrariesTitle_lbl = New EasyHTML_2.BonfireLabel()
        Me.Misc_grp = New EasyHTML_2.BonfireGroupBox()
        Me.credit_chkbox = New EasyHTML_2.BonfireCheckbox()
        Me.internetExplorerCompatability_chk = New EasyHTML_2.BonfireCheckbox()
        Me.mobileViewport_chkbox = New EasyHTML_2.BonfireCheckbox()
        Me.metatags_chkbox = New EasyHTML_2.BonfireCheckbox()
        Me.UTF8_Set_chkbox = New EasyHTML_2.BonfireCheckbox()
        Me.pageTitle_lbl = New EasyHTML_2.BonfireLabel()
        Me.Beta_Notice_ProMsg = New EasyHTML_2.ProMessage()
        Me.returnToLauncher_btn = New EasyHTML_2.ProBasicButton()
        Me.editorControls_grp = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.newProject_btn = New System.Windows.Forms.Button()
        Me.loadCssLibs_btn = New System.Windows.Forms.Button()
        Me.lbl_Tip1 = New System.Windows.Forms.Label()
        Me.loadJsLibs_btn = New System.Windows.Forms.Button()
        Me.loadEditorProj_btn = New System.Windows.Forms.Button()
        Me.pageTitle_txtBox = New System.Windows.Forms.TextBox()
        Me.Pg_MetaTags = New System.Windows.Forms.TabPage()
        Me.BonfireLabel2 = New EasyHTML_2.BonfireLabel()
        Me.BonfireLabel1 = New EasyHTML_2.BonfireLabel()
        Me.description_txtBox = New System.Windows.Forms.TextBox()
        Me.title_txtBox = New System.Windows.Forms.TextBox()
        Me.keywords_lbl = New EasyHTML_2.BonfireLabel()
        Me.keywords_txtBox = New System.Windows.Forms.TextBox()
        Me.revisit_lbl = New EasyHTML_2.BonfireLabel()
        Me.revisit_txtBox = New System.Windows.Forms.TextBox()
        Me.siteAuthor_txtbox = New System.Windows.Forms.TextBox()
        Me.siteAuthor_lbl = New EasyHTML_2.BonfireLabel()
        Me.Pg_Editors = New System.Windows.Forms.TabPage()
        Me.BonfireTabControl1 = New EasyHTML_2.BonfireTabControl()
        Me.Pg_Editors_Body = New System.Windows.Forms.TabPage()
        Me.Pg_Editors_Header = New System.Windows.Forms.TabPage()
        Me.Pg_Editors_Footer = New System.Windows.Forms.TabPage()
        Me.pg_Preview = New System.Windows.Forms.TabPage()
        Me.Pg_Export = New System.Windows.Forms.TabPage()
        Me.Pg_About = New System.Windows.Forms.TabPage()
        Me.Pg_ExtraStuff = New System.Windows.Forms.TabPage()
        Me.JSContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveJSLibrariesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadJSLibrariesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CSSContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveCSSLibrariesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadCSSLibrariesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainEditorContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveEditorProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadEditorProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.redirectMakerContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveRedirectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SaveDialog = New System.Windows.Forms.SaveFileDialog()
        Me.OpenDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Pgs_Main.SuspendLayout()
        Me.Pg_Details.SuspendLayout()
        Me.jsLibraries_grp.SuspendLayout()
        Me.cssLibraries_grp.SuspendLayout()
        Me.Misc_grp.SuspendLayout()
        Me.editorControls_grp.SuspendLayout()
        Me.Pg_MetaTags.SuspendLayout()
        Me.Pg_Editors.SuspendLayout()
        Me.BonfireTabControl1.SuspendLayout()
        Me.JSContextMenu.SuspendLayout()
        Me.CSSContextMenu.SuspendLayout()
        Me.MainEditorContextMenu.SuspendLayout()
        Me.redirectMakerContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pgs_Main
        '
        Me.Pgs_Main.Controls.Add(Me.Pg_Details)
        Me.Pgs_Main.Controls.Add(Me.Pg_MetaTags)
        Me.Pgs_Main.Controls.Add(Me.Pg_Editors)
        Me.Pgs_Main.Controls.Add(Me.pg_Preview)
        Me.Pgs_Main.Controls.Add(Me.Pg_Export)
        Me.Pgs_Main.Controls.Add(Me.Pg_About)
        Me.Pgs_Main.Controls.Add(Me.Pg_ExtraStuff)
        Me.Pgs_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pgs_Main.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pgs_Main.ItemSize = New System.Drawing.Size(0, 30)
        Me.Pgs_Main.Location = New System.Drawing.Point(0, 0)
        Me.Pgs_Main.Name = "Pgs_Main"
        Me.Pgs_Main.SelectedIndex = 0
        Me.Pgs_Main.Size = New System.Drawing.Size(884, 630)
        Me.Pgs_Main.TabIndex = 16
        '
        'Pg_Details
        '
        Me.Pg_Details.BackColor = System.Drawing.Color.White
        Me.Pg_Details.Controls.Add(Me.jsLibraries_grp)
        Me.Pg_Details.Controls.Add(Me.cssLibraries_grp)
        Me.Pg_Details.Controls.Add(Me.Misc_grp)
        Me.Pg_Details.Controls.Add(Me.pageTitle_lbl)
        Me.Pg_Details.Controls.Add(Me.Beta_Notice_ProMsg)
        Me.Pg_Details.Controls.Add(Me.returnToLauncher_btn)
        Me.Pg_Details.Controls.Add(Me.editorControls_grp)
        Me.Pg_Details.Controls.Add(Me.pageTitle_txtBox)
        Me.Pg_Details.Location = New System.Drawing.Point(4, 34)
        Me.Pg_Details.Name = "Pg_Details"
        Me.Pg_Details.Padding = New System.Windows.Forms.Padding(3)
        Me.Pg_Details.Size = New System.Drawing.Size(876, 592)
        Me.Pg_Details.TabIndex = 0
        Me.Pg_Details.Text = "Details"
        '
        'jsLibraries_grp
        '
        Me.jsLibraries_grp.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.jsLibraries_grp.Controls.Add(Me.jsImport_lst)
        Me.jsLibraries_grp.Controls.Add(Me.jsImport_btn)
        Me.jsLibraries_grp.Controls.Add(Me.jsLibrariesTitle_lbl)
        Me.jsLibraries_grp.Location = New System.Drawing.Point(441, 6)
        Me.jsLibraries_grp.Name = "jsLibraries_grp"
        Me.jsLibraries_grp.Size = New System.Drawing.Size(213, 578)
        Me.jsLibraries_grp.TabIndex = 34
        Me.jsLibraries_grp.Text = "BonfireGroupBox1"
        '
        'jsImport_lst
        '
        Me.jsImport_lst.FormattingEnabled = True
        Me.jsImport_lst.Location = New System.Drawing.Point(3, 18)
        Me.jsImport_lst.Name = "jsImport_lst"
        Me.jsImport_lst.Size = New System.Drawing.Size(207, 524)
        Me.jsImport_lst.TabIndex = 3
        '
        'jsImport_btn
        '
        Me.jsImport_btn.ButtonStyle = EasyHTML_2.BonfireButton.Style.Light
        Me.jsImport_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.jsImport_btn.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.jsImport_btn.Image = Nothing
        Me.jsImport_btn.Location = New System.Drawing.Point(3, 549)
        Me.jsImport_btn.Name = "jsImport_btn"
        Me.jsImport_btn.RoundedCorners = False
        Me.jsImport_btn.Size = New System.Drawing.Size(207, 26)
        Me.jsImport_btn.TabIndex = 2
        Me.jsImport_btn.Text = "Add JS Library"
        '
        'jsLibrariesTitle_lbl
        '
        Me.jsLibrariesTitle_lbl.AutoSize = True
        Me.jsLibrariesTitle_lbl.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.jsLibrariesTitle_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.jsLibrariesTitle_lbl.Location = New System.Drawing.Point(2, 2)
        Me.jsLibrariesTitle_lbl.Name = "jsLibrariesTitle_lbl"
        Me.jsLibrariesTitle_lbl.Size = New System.Drawing.Size(73, 13)
        Me.jsLibrariesTitle_lbl.TabIndex = 0
        Me.jsLibrariesTitle_lbl.Text = "JS Libraries"
        '
        'cssLibraries_grp
        '
        Me.cssLibraries_grp.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cssLibraries_grp.Controls.Add(Me.cssImport_lst)
        Me.cssLibraries_grp.Controls.Add(Me.cssImport_btn)
        Me.cssLibraries_grp.Controls.Add(Me.cssLibrariesTitle_lbl)
        Me.cssLibraries_grp.Location = New System.Drawing.Point(222, 6)
        Me.cssLibraries_grp.Name = "cssLibraries_grp"
        Me.cssLibraries_grp.Size = New System.Drawing.Size(213, 578)
        Me.cssLibraries_grp.TabIndex = 33
        Me.cssLibraries_grp.Text = "BonfireGroupBox1"
        '
        'cssImport_lst
        '
        Me.cssImport_lst.FormattingEnabled = True
        Me.cssImport_lst.Location = New System.Drawing.Point(3, 18)
        Me.cssImport_lst.Name = "cssImport_lst"
        Me.cssImport_lst.Size = New System.Drawing.Size(207, 524)
        Me.cssImport_lst.TabIndex = 2
        '
        'cssImport_btn
        '
        Me.cssImport_btn.ButtonStyle = EasyHTML_2.BonfireButton.Style.Light
        Me.cssImport_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cssImport_btn.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cssImport_btn.Image = Nothing
        Me.cssImport_btn.Location = New System.Drawing.Point(3, 549)
        Me.cssImport_btn.Name = "cssImport_btn"
        Me.cssImport_btn.RoundedCorners = False
        Me.cssImport_btn.Size = New System.Drawing.Size(207, 26)
        Me.cssImport_btn.TabIndex = 1
        Me.cssImport_btn.Text = "Add CSS Library"
        '
        'cssLibrariesTitle_lbl
        '
        Me.cssLibrariesTitle_lbl.AutoSize = True
        Me.cssLibrariesTitle_lbl.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cssLibrariesTitle_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.cssLibrariesTitle_lbl.Location = New System.Drawing.Point(2, 2)
        Me.cssLibrariesTitle_lbl.Name = "cssLibrariesTitle_lbl"
        Me.cssLibrariesTitle_lbl.Size = New System.Drawing.Size(85, 13)
        Me.cssLibrariesTitle_lbl.TabIndex = 0
        Me.cssLibrariesTitle_lbl.Text = "CSS Libraries"
        '
        'Misc_grp
        '
        Me.Misc_grp.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Misc_grp.Controls.Add(Me.credit_chkbox)
        Me.Misc_grp.Controls.Add(Me.internetExplorerCompatability_chk)
        Me.Misc_grp.Controls.Add(Me.mobileViewport_chkbox)
        Me.Misc_grp.Controls.Add(Me.metatags_chkbox)
        Me.Misc_grp.Controls.Add(Me.UTF8_Set_chkbox)
        Me.Misc_grp.Location = New System.Drawing.Point(6, 47)
        Me.Misc_grp.Name = "Misc_grp"
        Me.Misc_grp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Misc_grp.Size = New System.Drawing.Size(210, 138)
        Me.Misc_grp.TabIndex = 32
        Me.Misc_grp.Text = "Misc"
        '
        'credit_chkbox
        '
        Me.credit_chkbox.Checked = False
        Me.credit_chkbox.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.credit_chkbox.Location = New System.Drawing.Point(3, 111)
        Me.credit_chkbox.Name = "credit_chkbox"
        Me.credit_chkbox.Size = New System.Drawing.Size(204, 20)
        Me.credit_chkbox.TabIndex = 36
        Me.credit_chkbox.Text = "Add Credit"
        '
        'internetExplorerCompatability_chk
        '
        Me.internetExplorerCompatability_chk.Checked = False
        Me.internetExplorerCompatability_chk.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.internetExplorerCompatability_chk.Location = New System.Drawing.Point(3, 85)
        Me.internetExplorerCompatability_chk.Name = "internetExplorerCompatability_chk"
        Me.internetExplorerCompatability_chk.Size = New System.Drawing.Size(204, 20)
        Me.internetExplorerCompatability_chk.TabIndex = 35
        Me.internetExplorerCompatability_chk.Text = "IE Compatability"
        '
        'mobileViewport_chkbox
        '
        Me.mobileViewport_chkbox.Checked = True
        Me.mobileViewport_chkbox.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.mobileViewport_chkbox.Location = New System.Drawing.Point(3, 59)
        Me.mobileViewport_chkbox.Name = "mobileViewport_chkbox"
        Me.mobileViewport_chkbox.Size = New System.Drawing.Size(204, 20)
        Me.mobileViewport_chkbox.TabIndex = 34
        Me.mobileViewport_chkbox.Text = "Use Mobile Viewport"
        '
        'metatags_chkbox
        '
        Me.metatags_chkbox.Checked = True
        Me.metatags_chkbox.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.metatags_chkbox.Location = New System.Drawing.Point(3, 33)
        Me.metatags_chkbox.Name = "metatags_chkbox"
        Me.metatags_chkbox.Size = New System.Drawing.Size(204, 20)
        Me.metatags_chkbox.TabIndex = 33
        Me.metatags_chkbox.Text = "Meta Tags"
        '
        'UTF8_Set_chkbox
        '
        Me.UTF8_Set_chkbox.Checked = True
        Me.UTF8_Set_chkbox.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.UTF8_Set_chkbox.Location = New System.Drawing.Point(3, 7)
        Me.UTF8_Set_chkbox.Name = "UTF8_Set_chkbox"
        Me.UTF8_Set_chkbox.Size = New System.Drawing.Size(204, 20)
        Me.UTF8_Set_chkbox.TabIndex = 33
        Me.UTF8_Set_chkbox.Text = "UTF-8 Character Set"
        '
        'pageTitle_lbl
        '
        Me.pageTitle_lbl.AutoSize = True
        Me.pageTitle_lbl.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.pageTitle_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.pageTitle_lbl.Location = New System.Drawing.Point(6, 3)
        Me.pageTitle_lbl.Name = "pageTitle_lbl"
        Me.pageTitle_lbl.Size = New System.Drawing.Size(63, 13)
        Me.pageTitle_lbl.TabIndex = 31
        Me.pageTitle_lbl.Text = "Page Title"
        '
        'Beta_Notice_ProMsg
        '
        Me.Beta_Notice_ProMsg.BackColor = System.Drawing.Color.LemonChiffon
        Me.Beta_Notice_ProMsg.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Beta_Notice_ProMsg.Header = "Notice!"
        Me.Beta_Notice_ProMsg.HeaderFont = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Beta_Notice_ProMsg.Location = New System.Drawing.Point(8, 448)
        Me.Beta_Notice_ProMsg.Name = "Beta_Notice_ProMsg"
        Me.Beta_Notice_ProMsg.Size = New System.Drawing.Size(208, 80)
        Me.Beta_Notice_ProMsg.SizeByText = False
        Me.Beta_Notice_ProMsg.TabIndex = 30
        Me.Beta_Notice_ProMsg.Text = "EasyHTML 2 is still in the beta stage, and as such, is not fully functional."
        '
        'returnToLauncher_btn
        '
        Me.returnToLauncher_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.returnToLauncher_btn.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.returnToLauncher_btn.Image = Nothing
        Me.returnToLauncher_btn.Location = New System.Drawing.Point(6, 534)
        Me.returnToLauncher_btn.Name = "returnToLauncher_btn"
        Me.returnToLauncher_btn.Scheme = EasyHTML_2.ProBasicButton.ColorScheme.White
        Me.returnToLauncher_btn.Size = New System.Drawing.Size(210, 50)
        Me.returnToLauncher_btn.TabIndex = 29
        Me.returnToLauncher_btn.Text = "Return to Launcher"
        Me.returnToLauncher_btn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        '
        'editorControls_grp
        '
        Me.editorControls_grp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.editorControls_grp.Controls.Add(Me.Button1)
        Me.editorControls_grp.Controls.Add(Me.Button2)
        Me.editorControls_grp.Controls.Add(Me.Button3)
        Me.editorControls_grp.Controls.Add(Me.newProject_btn)
        Me.editorControls_grp.Controls.Add(Me.loadCssLibs_btn)
        Me.editorControls_grp.Controls.Add(Me.lbl_Tip1)
        Me.editorControls_grp.Controls.Add(Me.loadJsLibs_btn)
        Me.editorControls_grp.Controls.Add(Me.loadEditorProj_btn)
        Me.editorControls_grp.Location = New System.Drawing.Point(660, 6)
        Me.editorControls_grp.Name = "editorControls_grp"
        Me.editorControls_grp.Size = New System.Drawing.Size(208, 578)
        Me.editorControls_grp.TabIndex = 28
        Me.editorControls_grp.TabStop = False
        Me.editorControls_grp.Text = "Project Management"
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(6, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Save CSS Libraries"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(6, 79)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(196, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Save JS Libraries"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(6, 108)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(196, 23)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Save Editor Project"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'newProject_btn
        '
        Me.newProject_btn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.newProject_btn.ForeColor = System.Drawing.Color.Black
        Me.newProject_btn.Location = New System.Drawing.Point(6, 21)
        Me.newProject_btn.Name = "newProject_btn"
        Me.newProject_btn.Size = New System.Drawing.Size(196, 23)
        Me.newProject_btn.TabIndex = 10
        Me.newProject_btn.Text = "New Project"
        Me.newProject_btn.UseVisualStyleBackColor = True
        '
        'loadCssLibs_btn
        '
        Me.loadCssLibs_btn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.loadCssLibs_btn.ForeColor = System.Drawing.Color.Black
        Me.loadCssLibs_btn.Location = New System.Drawing.Point(6, 137)
        Me.loadCssLibs_btn.Name = "loadCssLibs_btn"
        Me.loadCssLibs_btn.Size = New System.Drawing.Size(196, 23)
        Me.loadCssLibs_btn.TabIndex = 11
        Me.loadCssLibs_btn.Text = "Load CSS Libraries"
        Me.loadCssLibs_btn.UseVisualStyleBackColor = True
        '
        'lbl_Tip1
        '
        Me.lbl_Tip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_Tip1.Location = New System.Drawing.Point(3, 538)
        Me.lbl_Tip1.Name = "lbl_Tip1"
        Me.lbl_Tip1.Size = New System.Drawing.Size(202, 37)
        Me.lbl_Tip1.TabIndex = 14
        Me.lbl_Tip1.Text = "Right click on an editor to save that specific part"
        '
        'loadJsLibs_btn
        '
        Me.loadJsLibs_btn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.loadJsLibs_btn.ForeColor = System.Drawing.Color.Black
        Me.loadJsLibs_btn.Location = New System.Drawing.Point(6, 166)
        Me.loadJsLibs_btn.Name = "loadJsLibs_btn"
        Me.loadJsLibs_btn.Size = New System.Drawing.Size(196, 23)
        Me.loadJsLibs_btn.TabIndex = 12
        Me.loadJsLibs_btn.Text = "Load JS Libraries"
        Me.loadJsLibs_btn.UseVisualStyleBackColor = True
        '
        'loadEditorProj_btn
        '
        Me.loadEditorProj_btn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.loadEditorProj_btn.ForeColor = System.Drawing.Color.Black
        Me.loadEditorProj_btn.Location = New System.Drawing.Point(6, 195)
        Me.loadEditorProj_btn.Name = "loadEditorProj_btn"
        Me.loadEditorProj_btn.Size = New System.Drawing.Size(196, 23)
        Me.loadEditorProj_btn.TabIndex = 13
        Me.loadEditorProj_btn.Text = "Load Editor Project"
        Me.loadEditorProj_btn.UseVisualStyleBackColor = True
        '
        'pageTitle_txtBox
        '
        Me.pageTitle_txtBox.Location = New System.Drawing.Point(6, 19)
        Me.pageTitle_txtBox.MaxLength = 64
        Me.pageTitle_txtBox.Name = "pageTitle_txtBox"
        Me.pageTitle_txtBox.Size = New System.Drawing.Size(210, 22)
        Me.pageTitle_txtBox.TabIndex = 23
        '
        'Pg_MetaTags
        '
        Me.Pg_MetaTags.BackColor = System.Drawing.Color.White
        Me.Pg_MetaTags.Controls.Add(Me.BonfireLabel2)
        Me.Pg_MetaTags.Controls.Add(Me.BonfireLabel1)
        Me.Pg_MetaTags.Controls.Add(Me.description_txtBox)
        Me.Pg_MetaTags.Controls.Add(Me.title_txtBox)
        Me.Pg_MetaTags.Controls.Add(Me.keywords_lbl)
        Me.Pg_MetaTags.Controls.Add(Me.keywords_txtBox)
        Me.Pg_MetaTags.Controls.Add(Me.revisit_lbl)
        Me.Pg_MetaTags.Controls.Add(Me.revisit_txtBox)
        Me.Pg_MetaTags.Controls.Add(Me.siteAuthor_txtbox)
        Me.Pg_MetaTags.Controls.Add(Me.siteAuthor_lbl)
        Me.Pg_MetaTags.Location = New System.Drawing.Point(4, 34)
        Me.Pg_MetaTags.Name = "Pg_MetaTags"
        Me.Pg_MetaTags.Size = New System.Drawing.Size(876, 592)
        Me.Pg_MetaTags.TabIndex = 2
        Me.Pg_MetaTags.Text = "Meta Tags"
        '
        'BonfireLabel2
        '
        Me.BonfireLabel2.AutoSize = True
        Me.BonfireLabel2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BonfireLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.BonfireLabel2.Location = New System.Drawing.Point(8, 38)
        Me.BonfireLabel2.Name = "BonfireLabel2"
        Me.BonfireLabel2.Size = New System.Drawing.Size(71, 13)
        Me.BonfireLabel2.TabIndex = 15
        Me.BonfireLabel2.Text = "Description"
        '
        'BonfireLabel1
        '
        Me.BonfireLabel1.AutoSize = True
        Me.BonfireLabel1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BonfireLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.BonfireLabel1.Location = New System.Drawing.Point(8, 10)
        Me.BonfireLabel1.Name = "BonfireLabel1"
        Me.BonfireLabel1.Size = New System.Drawing.Size(31, 13)
        Me.BonfireLabel1.TabIndex = 14
        Me.BonfireLabel1.Text = "Title"
        '
        'description_txtBox
        '
        Me.description_txtBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.description_txtBox.Location = New System.Drawing.Point(85, 35)
        Me.description_txtBox.Name = "description_txtBox"
        Me.description_txtBox.Size = New System.Drawing.Size(783, 22)
        Me.description_txtBox.TabIndex = 13
        '
        'title_txtBox
        '
        Me.title_txtBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.title_txtBox.Location = New System.Drawing.Point(45, 7)
        Me.title_txtBox.Name = "title_txtBox"
        Me.title_txtBox.Size = New System.Drawing.Size(823, 22)
        Me.title_txtBox.TabIndex = 11
        '
        'keywords_lbl
        '
        Me.keywords_lbl.AutoSize = True
        Me.keywords_lbl.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.keywords_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.keywords_lbl.Location = New System.Drawing.Point(8, 122)
        Me.keywords_lbl.Name = "keywords_lbl"
        Me.keywords_lbl.Size = New System.Drawing.Size(63, 13)
        Me.keywords_lbl.TabIndex = 7
        Me.keywords_lbl.Text = "Keywords"
        '
        'keywords_txtBox
        '
        Me.keywords_txtBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.keywords_txtBox.Location = New System.Drawing.Point(77, 119)
        Me.keywords_txtBox.MaxLength = 1
        Me.keywords_txtBox.Name = "keywords_txtBox"
        Me.keywords_txtBox.Size = New System.Drawing.Size(791, 22)
        Me.keywords_txtBox.TabIndex = 6
        '
        'revisit_lbl
        '
        Me.revisit_lbl.AutoSize = True
        Me.revisit_lbl.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.revisit_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.revisit_lbl.Location = New System.Drawing.Point(8, 94)
        Me.revisit_lbl.Name = "revisit_lbl"
        Me.revisit_lbl.Size = New System.Drawing.Size(117, 13)
        Me.revisit_lbl.TabIndex = 5
        Me.revisit_lbl.Text = "Revisit after (days)"
        '
        'revisit_txtBox
        '
        Me.revisit_txtBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.revisit_txtBox.Location = New System.Drawing.Point(131, 91)
        Me.revisit_txtBox.MaxLength = 1
        Me.revisit_txtBox.Name = "revisit_txtBox"
        Me.revisit_txtBox.Size = New System.Drawing.Size(737, 22)
        Me.revisit_txtBox.TabIndex = 4
        '
        'siteAuthor_txtbox
        '
        Me.siteAuthor_txtbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.siteAuthor_txtbox.Location = New System.Drawing.Point(85, 63)
        Me.siteAuthor_txtbox.Name = "siteAuthor_txtbox"
        Me.siteAuthor_txtbox.Size = New System.Drawing.Size(783, 22)
        Me.siteAuthor_txtbox.TabIndex = 2
        '
        'siteAuthor_lbl
        '
        Me.siteAuthor_lbl.AutoSize = True
        Me.siteAuthor_lbl.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.siteAuthor_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.siteAuthor_lbl.Location = New System.Drawing.Point(8, 66)
        Me.siteAuthor_lbl.Name = "siteAuthor_lbl"
        Me.siteAuthor_lbl.Size = New System.Drawing.Size(71, 13)
        Me.siteAuthor_lbl.TabIndex = 0
        Me.siteAuthor_lbl.Text = "Site Author"
        '
        'Pg_Editors
        '
        Me.Pg_Editors.BackColor = System.Drawing.Color.White
        Me.Pg_Editors.Controls.Add(Me.BonfireTabControl1)
        Me.Pg_Editors.Location = New System.Drawing.Point(4, 34)
        Me.Pg_Editors.Name = "Pg_Editors"
        Me.Pg_Editors.Padding = New System.Windows.Forms.Padding(3)
        Me.Pg_Editors.Size = New System.Drawing.Size(876, 592)
        Me.Pg_Editors.TabIndex = 1
        Me.Pg_Editors.Text = "Editors"
        '
        'BonfireTabControl1
        '
        Me.BonfireTabControl1.Controls.Add(Me.Pg_Editors_Body)
        Me.BonfireTabControl1.Controls.Add(Me.Pg_Editors_Header)
        Me.BonfireTabControl1.Controls.Add(Me.Pg_Editors_Footer)
        Me.BonfireTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BonfireTabControl1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BonfireTabControl1.ItemSize = New System.Drawing.Size(0, 30)
        Me.BonfireTabControl1.Location = New System.Drawing.Point(3, 3)
        Me.BonfireTabControl1.Name = "BonfireTabControl1"
        Me.BonfireTabControl1.SelectedIndex = 0
        Me.BonfireTabControl1.Size = New System.Drawing.Size(870, 586)
        Me.BonfireTabControl1.TabIndex = 0
        '
        'Pg_Editors_Body
        '
        Me.Pg_Editors_Body.BackColor = System.Drawing.Color.White
        Me.Pg_Editors_Body.Location = New System.Drawing.Point(4, 34)
        Me.Pg_Editors_Body.Name = "Pg_Editors_Body"
        Me.Pg_Editors_Body.Padding = New System.Windows.Forms.Padding(3)
        Me.Pg_Editors_Body.Size = New System.Drawing.Size(862, 548)
        Me.Pg_Editors_Body.TabIndex = 0
        Me.Pg_Editors_Body.Text = "Body"
        '
        'Pg_Editors_Header
        '
        Me.Pg_Editors_Header.BackColor = System.Drawing.Color.White
        Me.Pg_Editors_Header.Location = New System.Drawing.Point(4, 34)
        Me.Pg_Editors_Header.Name = "Pg_Editors_Header"
        Me.Pg_Editors_Header.Size = New System.Drawing.Size(862, 548)
        Me.Pg_Editors_Header.TabIndex = 2
        Me.Pg_Editors_Header.Text = "Header"
        '
        'Pg_Editors_Footer
        '
        Me.Pg_Editors_Footer.BackColor = System.Drawing.Color.White
        Me.Pg_Editors_Footer.Location = New System.Drawing.Point(4, 34)
        Me.Pg_Editors_Footer.Name = "Pg_Editors_Footer"
        Me.Pg_Editors_Footer.Padding = New System.Windows.Forms.Padding(3)
        Me.Pg_Editors_Footer.Size = New System.Drawing.Size(862, 548)
        Me.Pg_Editors_Footer.TabIndex = 1
        Me.Pg_Editors_Footer.Text = "Footer"
        '
        'pg_Preview
        '
        Me.pg_Preview.BackColor = System.Drawing.Color.White
        Me.pg_Preview.Location = New System.Drawing.Point(4, 34)
        Me.pg_Preview.Name = "pg_Preview"
        Me.pg_Preview.Size = New System.Drawing.Size(876, 592)
        Me.pg_Preview.TabIndex = 3
        Me.pg_Preview.Text = "Preview"
        '
        'Pg_Export
        '
        Me.Pg_Export.BackColor = System.Drawing.Color.White
        Me.Pg_Export.Location = New System.Drawing.Point(4, 34)
        Me.Pg_Export.Name = "Pg_Export"
        Me.Pg_Export.Size = New System.Drawing.Size(876, 592)
        Me.Pg_Export.TabIndex = 4
        Me.Pg_Export.Text = "Export"
        '
        'Pg_About
        '
        Me.Pg_About.BackColor = System.Drawing.Color.White
        Me.Pg_About.Location = New System.Drawing.Point(4, 34)
        Me.Pg_About.Name = "Pg_About"
        Me.Pg_About.Size = New System.Drawing.Size(876, 592)
        Me.Pg_About.TabIndex = 5
        Me.Pg_About.Text = "About"
        '
        'Pg_ExtraStuff
        '
        Me.Pg_ExtraStuff.BackColor = System.Drawing.Color.White
        Me.Pg_ExtraStuff.Location = New System.Drawing.Point(4, 34)
        Me.Pg_ExtraStuff.Name = "Pg_ExtraStuff"
        Me.Pg_ExtraStuff.Size = New System.Drawing.Size(876, 592)
        Me.Pg_ExtraStuff.TabIndex = 6
        Me.Pg_ExtraStuff.Text = "Extra Fun Stuff"
        '
        'JSContextMenu
        '
        Me.JSContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveJSLibrariesToolStripMenuItem, Me.LoadJSLibrariesToolStripMenuItem})
        Me.JSContextMenu.Name = "JSContextMenu"
        Me.JSContextMenu.Size = New System.Drawing.Size(161, 48)
        '
        'SaveJSLibrariesToolStripMenuItem
        '
        Me.SaveJSLibrariesToolStripMenuItem.Name = "SaveJSLibrariesToolStripMenuItem"
        Me.SaveJSLibrariesToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.SaveJSLibrariesToolStripMenuItem.Text = "Save JS Libraries"
        '
        'LoadJSLibrariesToolStripMenuItem
        '
        Me.LoadJSLibrariesToolStripMenuItem.Name = "LoadJSLibrariesToolStripMenuItem"
        Me.LoadJSLibrariesToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.LoadJSLibrariesToolStripMenuItem.Text = "Load JS Libraries"
        '
        'CSSContextMenu
        '
        Me.CSSContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveCSSLibrariesToolStripMenuItem1, Me.LoadCSSLibrariesToolStripMenuItem1})
        Me.CSSContextMenu.Name = "CSSContextMenu"
        Me.CSSContextMenu.Size = New System.Drawing.Size(171, 48)
        '
        'SaveCSSLibrariesToolStripMenuItem1
        '
        Me.SaveCSSLibrariesToolStripMenuItem1.Name = "SaveCSSLibrariesToolStripMenuItem1"
        Me.SaveCSSLibrariesToolStripMenuItem1.Size = New System.Drawing.Size(170, 22)
        Me.SaveCSSLibrariesToolStripMenuItem1.Text = "Save CSS Libraries"
        '
        'LoadCSSLibrariesToolStripMenuItem1
        '
        Me.LoadCSSLibrariesToolStripMenuItem1.Name = "LoadCSSLibrariesToolStripMenuItem1"
        Me.LoadCSSLibrariesToolStripMenuItem1.Size = New System.Drawing.Size(170, 22)
        Me.LoadCSSLibrariesToolStripMenuItem1.Text = "Load CSS Libraries"
        '
        'MainEditorContextMenu
        '
        Me.MainEditorContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveEditorProjectToolStripMenuItem, Me.LoadEditorProjectToolStripMenuItem})
        Me.MainEditorContextMenu.Name = "MainEditorContextMenu"
        Me.MainEditorContextMenu.Size = New System.Drawing.Size(175, 48)
        '
        'SaveEditorProjectToolStripMenuItem
        '
        Me.SaveEditorProjectToolStripMenuItem.Name = "SaveEditorProjectToolStripMenuItem"
        Me.SaveEditorProjectToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.SaveEditorProjectToolStripMenuItem.Text = "Save Editor Project"
        '
        'LoadEditorProjectToolStripMenuItem
        '
        Me.LoadEditorProjectToolStripMenuItem.Name = "LoadEditorProjectToolStripMenuItem"
        Me.LoadEditorProjectToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.LoadEditorProjectToolStripMenuItem.Text = "Load Editor Project"
        '
        'redirectMakerContextMenu
        '
        Me.redirectMakerContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveRedirectToolStripMenuItem})
        Me.redirectMakerContextMenu.Name = "redirectMakerContextMenu"
        Me.redirectMakerContextMenu.Size = New System.Drawing.Size(145, 26)
        '
        'SaveRedirectToolStripMenuItem
        '
        Me.SaveRedirectToolStripMenuItem.Name = "SaveRedirectToolStripMenuItem"
        Me.SaveRedirectToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.SaveRedirectToolStripMenuItem.Text = "Save Redirect"
        '
        'EasyHTML_Two
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 630)
        Me.Controls.Add(Me.Pgs_Main)
        Me.MinimumSize = New System.Drawing.Size(900, 669)
        Me.Name = "EasyHTML_Two"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EasyHTML 2"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Pgs_Main.ResumeLayout(False)
        Me.Pg_Details.ResumeLayout(False)
        Me.Pg_Details.PerformLayout()
        Me.jsLibraries_grp.ResumeLayout(False)
        Me.jsLibraries_grp.PerformLayout()
        Me.cssLibraries_grp.ResumeLayout(False)
        Me.cssLibraries_grp.PerformLayout()
        Me.Misc_grp.ResumeLayout(False)
        Me.editorControls_grp.ResumeLayout(False)
        Me.Pg_MetaTags.ResumeLayout(False)
        Me.Pg_MetaTags.PerformLayout()
        Me.Pg_Editors.ResumeLayout(False)
        Me.BonfireTabControl1.ResumeLayout(False)
        Me.JSContextMenu.ResumeLayout(False)
        Me.CSSContextMenu.ResumeLayout(False)
        Me.MainEditorContextMenu.ResumeLayout(False)
        Me.redirectMakerContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pgs_Main As BonfireTabControl
    Friend WithEvents Pg_Details As TabPage
    Friend WithEvents Pg_Editors As TabPage
    Friend WithEvents editorControls_grp As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents newProject_btn As Button
    Friend WithEvents loadCssLibs_btn As Button
    Friend WithEvents lbl_Tip1 As Label
    Friend WithEvents loadJsLibs_btn As Button
    Friend WithEvents loadEditorProj_btn As Button
    Friend WithEvents pageTitle_txtBox As TextBox
    Friend WithEvents Pg_MetaTags As TabPage
    Friend WithEvents pg_Preview As TabPage
    Friend WithEvents Pg_Export As TabPage
    Friend WithEvents Pg_About As TabPage
    Friend WithEvents Pg_ExtraStuff As TabPage
    Friend WithEvents returnToLauncher_btn As ProBasicButton
    Friend WithEvents Beta_Notice_ProMsg As ProMessage
    Friend WithEvents pageTitle_lbl As BonfireLabel
    Friend WithEvents Misc_grp As BonfireGroupBox
    Friend WithEvents UTF8_Set_chkbox As BonfireCheckbox
    Friend WithEvents metatags_chkbox As BonfireCheckbox
    Friend WithEvents mobileViewport_chkbox As BonfireCheckbox
    Friend WithEvents internetExplorerCompatability_chk As BonfireCheckbox
    Friend WithEvents credit_chkbox As BonfireCheckbox
    Friend WithEvents cssLibraries_grp As BonfireGroupBox
    Friend WithEvents cssLibrariesTitle_lbl As BonfireLabel
    Friend WithEvents jsLibraries_grp As BonfireGroupBox
    Friend WithEvents jsLibrariesTitle_lbl As BonfireLabel
    Friend WithEvents JSContextMenu As ContextMenuStrip
    Friend WithEvents SaveJSLibrariesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadJSLibrariesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CSSContextMenu As ContextMenuStrip
    Friend WithEvents SaveCSSLibrariesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LoadCSSLibrariesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MainEditorContextMenu As ContextMenuStrip
    Friend WithEvents SaveEditorProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadEditorProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents redirectMakerContextMenu As ContextMenuStrip
    Friend WithEvents SaveRedirectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SaveDialog As SaveFileDialog
    Friend WithEvents OpenDialog As OpenFileDialog
    Friend WithEvents cssImport_btn As BonfireButton
    Friend WithEvents jsImport_btn As BonfireButton
    Friend WithEvents jsImport_lst As ListBox
    Friend WithEvents cssImport_lst As ListBox
    Friend WithEvents siteAuthor_lbl As BonfireLabel
    Friend WithEvents siteAuthor_txtbox As TextBox
    Friend WithEvents revisit_lbl As BonfireLabel
    Friend WithEvents revisit_txtBox As TextBox
    Friend WithEvents keywords_lbl As BonfireLabel
    Friend WithEvents keywords_txtBox As TextBox
    Friend WithEvents BonfireLabel1 As BonfireLabel
    Friend WithEvents description_txtBox As TextBox
    Friend WithEvents title_txtBox As TextBox
    Friend WithEvents BonfireLabel2 As BonfireLabel
    Friend WithEvents BonfireTabControl1 As BonfireTabControl
    Friend WithEvents Pg_Editors_Body As TabPage
    Friend WithEvents Pg_Editors_Footer As TabPage
    Friend WithEvents Pg_Editors_Header As TabPage
End Class
