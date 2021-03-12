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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EasyHTML))
        Me.Pgs_Main = New System.Windows.Forms.TabControl()
        Me.Pg_Main = New System.Windows.Forms.TabPage()
        Me.newUI_btn = New System.Windows.Forms.Button()
        Me.editorControls_grp = New System.Windows.Forms.GroupBox()
        Me.newProject_btn = New System.Windows.Forms.Button()
        Me.loadCssLibs_btn = New System.Windows.Forms.Button()
        Me.lbl_Tip1 = New System.Windows.Forms.Label()
        Me.loadJsLibs_btn = New System.Windows.Forms.Button()
        Me.loadEditorProj_btn = New System.Windows.Forms.Button()
        Me.launcher_btn = New System.Windows.Forms.Button()
        Me.misc_grp = New System.Windows.Forms.GroupBox()
        Me.internetExplorerCompatability_chk = New System.Windows.Forms.CheckBox()
        Me.metatags_chkbox = New System.Windows.Forms.CheckBox()
        Me.UTF8_Set_chkbox = New System.Windows.Forms.CheckBox()
        Me.credit_chkbox = New System.Windows.Forms.CheckBox()
        Me.mobileViewport_chkbox = New System.Windows.Forms.CheckBox()
        Me.jsImport_grp = New System.Windows.Forms.GroupBox()
        Me.jsImport_lst = New System.Windows.Forms.ListBox()
        Me.JSContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveJSLibrariesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadJSLibrariesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.jsImport_btn = New System.Windows.Forms.Button()
        Me.cssImport_grp = New System.Windows.Forms.GroupBox()
        Me.cssImport_lst = New System.Windows.Forms.ListBox()
        Me.CSSContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveCSSLibrariesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadCSSLibrariesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cssImport_btn = New System.Windows.Forms.Button()
        Me.pageTitle_lbl = New System.Windows.Forms.Label()
        Me.pageTitle_txtBox = New System.Windows.Forms.TextBox()
        Me.HTMLEditorError = New System.Windows.Forms.TextBox()
        Me.Pg_Editor = New System.Windows.Forms.TabPage()
        Me.mainEditor_grp = New System.Windows.Forms.GroupBox()
        Me.CodeEditorBox = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.MainEditorContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveEditorProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadEditorProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Component_Box = New System.Windows.Forms.ListBox()
        Me.Pg_Meta = New System.Windows.Forms.TabPage()
        Me.description_txtBox = New System.Windows.Forms.TextBox()
        Me.description_lbl = New System.Windows.Forms.Label()
        Me.title_txtBox = New System.Windows.Forms.TextBox()
        Me.title_lbl = New System.Windows.Forms.Label()
        Me.keywords_txtBox = New System.Windows.Forms.TextBox()
        Me.keywords_lbl = New System.Windows.Forms.Label()
        Me.revisit_txtBox = New System.Windows.Forms.TextBox()
        Me.revisit_lbl = New System.Windows.Forms.Label()
        Me.siteAuthor_txtbox = New System.Windows.Forms.TextBox()
        Me.siteAuthor_lbl = New System.Windows.Forms.Label()
        Me.Pg_Export = New System.Windows.Forms.TabPage()
        Me.Btn_Export = New System.Windows.Forms.Button()
        Me.Code_Export_Code_Box = New System.Windows.Forms.RichTextBox()
        Me.Pg_Preview = New System.Windows.Forms.TabPage()
        Me.builtInPreview_grp = New System.Windows.Forms.GroupBox()
        Me.builtInPreview_btn = New System.Windows.Forms.Button()
        Me.preview_Python = New System.Windows.Forms.GroupBox()
        Me.pythonPreview_btn = New System.Windows.Forms.Button()
        Me.pythonPreviewBrowser_cmb = New System.Windows.Forms.ComboBox()
        Me.pythonPreview_lbl = New System.Windows.Forms.Label()
        Me.previewNew_grp = New System.Windows.Forms.GroupBox()
        Me.preview_btn = New System.Windows.Forms.Button()
        Me.BrowserListing_cmb = New System.Windows.Forms.ComboBox()
        Me.previewBrowser_lbl = New System.Windows.Forms.Label()
        Me.preview_lbl = New System.Windows.Forms.Label()
        Me.Pg_RedirectMaker = New System.Windows.Forms.TabPage()
        Me.redirectMakerCodeBox = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.redirectMakerInfo_lbl = New System.Windows.Forms.Label()
        Me.redirectMakerTools_grp = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.redirect_SecondsToWait_txtBox = New System.Windows.Forms.TextBox()
        Me.redirectMakerUrlPrefix_cmb = New System.Windows.Forms.ComboBox()
        Me.redirectMakerGenerate_btn = New System.Windows.Forms.Button()
        Me.redirectMakerUrl_txtBox = New System.Windows.Forms.TextBox()
        Me.redirectMakerUrl_lbl = New System.Windows.Forms.Label()
        Me.redirectMakerTitle_lbl = New System.Windows.Forms.Label()
        Me.Pg_About = New System.Windows.Forms.TabPage()
        Me.licenses_btn = New System.Windows.Forms.Button()
        Me.gnuGpl_pic = New System.Windows.Forms.PictureBox()
        Me.copyright_lbl = New System.Windows.Forms.Label()
        Me.version_lbl = New System.Windows.Forms.Label()
        Me.aboutText_lbl = New System.Windows.Forms.Label()
        Me.aboutTitle_lbl = New System.Windows.Forms.Label()
        Me.aboutImg_pic = New System.Windows.Forms.PictureBox()
        Me.redirectMakerContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveRedirectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SaveDialog = New System.Windows.Forms.SaveFileDialog()
        Me.OpenDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Pgs_Main.SuspendLayout()
        Me.Pg_Main.SuspendLayout()
        Me.editorControls_grp.SuspendLayout()
        Me.misc_grp.SuspendLayout()
        Me.jsImport_grp.SuspendLayout()
        Me.JSContextMenu.SuspendLayout()
        Me.cssImport_grp.SuspendLayout()
        Me.CSSContextMenu.SuspendLayout()
        Me.Pg_Editor.SuspendLayout()
        Me.mainEditor_grp.SuspendLayout()
        CType(Me.CodeEditorBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainEditorContextMenu.SuspendLayout()
        Me.Pg_Meta.SuspendLayout()
        Me.Pg_Export.SuspendLayout()
        Me.Pg_Preview.SuspendLayout()
        Me.builtInPreview_grp.SuspendLayout()
        Me.preview_Python.SuspendLayout()
        Me.previewNew_grp.SuspendLayout()
        Me.Pg_RedirectMaker.SuspendLayout()
        CType(Me.redirectMakerCodeBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.redirectMakerTools_grp.SuspendLayout()
        Me.Pg_About.SuspendLayout()
        CType(Me.gnuGpl_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.aboutImg_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.redirectMakerContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pgs_Main
        '
        Me.Pgs_Main.Controls.Add(Me.Pg_Main)
        Me.Pgs_Main.Controls.Add(Me.Pg_Editor)
        Me.Pgs_Main.Controls.Add(Me.Pg_Meta)
        Me.Pgs_Main.Controls.Add(Me.Pg_Export)
        Me.Pgs_Main.Controls.Add(Me.Pg_Preview)
        Me.Pgs_Main.Controls.Add(Me.Pg_RedirectMaker)
        Me.Pgs_Main.Controls.Add(Me.Pg_About)
        Me.Pgs_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pgs_Main.Location = New System.Drawing.Point(0, 0)
        Me.Pgs_Main.Name = "Pgs_Main"
        Me.Pgs_Main.SelectedIndex = 0
        Me.Pgs_Main.Size = New System.Drawing.Size(952, 626)
        Me.Pgs_Main.TabIndex = 0
        '
        'Pg_Main
        '
        Me.Pg_Main.BackColor = System.Drawing.Color.Gray
        Me.Pg_Main.Controls.Add(Me.newUI_btn)
        Me.Pg_Main.Controls.Add(Me.editorControls_grp)
        Me.Pg_Main.Controls.Add(Me.launcher_btn)
        Me.Pg_Main.Controls.Add(Me.misc_grp)
        Me.Pg_Main.Controls.Add(Me.jsImport_grp)
        Me.Pg_Main.Controls.Add(Me.cssImport_grp)
        Me.Pg_Main.Controls.Add(Me.pageTitle_lbl)
        Me.Pg_Main.Controls.Add(Me.pageTitle_txtBox)
        Me.Pg_Main.Controls.Add(Me.HTMLEditorError)
        Me.Pg_Main.Location = New System.Drawing.Point(4, 22)
        Me.Pg_Main.Name = "Pg_Main"
        Me.Pg_Main.Padding = New System.Windows.Forms.Padding(3)
        Me.Pg_Main.Size = New System.Drawing.Size(944, 600)
        Me.Pg_Main.TabIndex = 0
        Me.Pg_Main.Text = "Details"
        '
        'newUI_btn
        '
        Me.newUI_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.newUI_btn.ForeColor = System.Drawing.Color.Black
        Me.newUI_btn.Location = New System.Drawing.Point(8, 526)
        Me.newUI_btn.Name = "newUI_btn"
        Me.newUI_btn.Size = New System.Drawing.Size(208, 30)
        Me.newUI_btn.TabIndex = 17
        Me.newUI_btn.Text = "Try EasyHTML 2!"
        Me.newUI_btn.UseVisualStyleBackColor = True
        '
        'editorControls_grp
        '
        Me.editorControls_grp.Controls.Add(Me.newProject_btn)
        Me.editorControls_grp.Controls.Add(Me.loadCssLibs_btn)
        Me.editorControls_grp.Controls.Add(Me.lbl_Tip1)
        Me.editorControls_grp.Controls.Add(Me.loadJsLibs_btn)
        Me.editorControls_grp.Controls.Add(Me.loadEditorProj_btn)
        Me.editorControls_grp.Location = New System.Drawing.Point(728, 6)
        Me.editorControls_grp.Name = "editorControls_grp"
        Me.editorControls_grp.Size = New System.Drawing.Size(208, 586)
        Me.editorControls_grp.TabIndex = 16
        Me.editorControls_grp.TabStop = False
        Me.editorControls_grp.Text = "Project Management"
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
        Me.loadCssLibs_btn.Location = New System.Drawing.Point(6, 50)
        Me.loadCssLibs_btn.Name = "loadCssLibs_btn"
        Me.loadCssLibs_btn.Size = New System.Drawing.Size(196, 23)
        Me.loadCssLibs_btn.TabIndex = 11
        Me.loadCssLibs_btn.Text = "Load CSS Libraries"
        Me.loadCssLibs_btn.UseVisualStyleBackColor = True
        '
        'lbl_Tip1
        '
        Me.lbl_Tip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_Tip1.Location = New System.Drawing.Point(3, 546)
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
        Me.loadJsLibs_btn.Location = New System.Drawing.Point(6, 79)
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
        Me.loadEditorProj_btn.Location = New System.Drawing.Point(6, 108)
        Me.loadEditorProj_btn.Name = "loadEditorProj_btn"
        Me.loadEditorProj_btn.Size = New System.Drawing.Size(196, 23)
        Me.loadEditorProj_btn.TabIndex = 13
        Me.loadEditorProj_btn.Text = "Load Editor Project"
        Me.loadEditorProj_btn.UseVisualStyleBackColor = True
        '
        'launcher_btn
        '
        Me.launcher_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.launcher_btn.ForeColor = System.Drawing.Color.Black
        Me.launcher_btn.Location = New System.Drawing.Point(8, 562)
        Me.launcher_btn.Name = "launcher_btn"
        Me.launcher_btn.Size = New System.Drawing.Size(208, 30)
        Me.launcher_btn.TabIndex = 15
        Me.launcher_btn.Text = "Back to Launcher"
        Me.launcher_btn.UseVisualStyleBackColor = True
        '
        'misc_grp
        '
        Me.misc_grp.Controls.Add(Me.internetExplorerCompatability_chk)
        Me.misc_grp.Controls.Add(Me.metatags_chkbox)
        Me.misc_grp.Controls.Add(Me.UTF8_Set_chkbox)
        Me.misc_grp.Controls.Add(Me.credit_chkbox)
        Me.misc_grp.Controls.Add(Me.mobileViewport_chkbox)
        Me.misc_grp.Location = New System.Drawing.Point(8, 48)
        Me.misc_grp.Name = "misc_grp"
        Me.misc_grp.Size = New System.Drawing.Size(208, 138)
        Me.misc_grp.TabIndex = 8
        Me.misc_grp.TabStop = False
        Me.misc_grp.Text = "Misc Items"
        '
        'internetExplorerCompatability_chk
        '
        Me.internetExplorerCompatability_chk.AutoSize = True
        Me.internetExplorerCompatability_chk.Location = New System.Drawing.Point(6, 88)
        Me.internetExplorerCompatability_chk.Name = "internetExplorerCompatability_chk"
        Me.internetExplorerCompatability_chk.Size = New System.Drawing.Size(186, 17)
        Me.internetExplorerCompatability_chk.TabIndex = 4
        Me.internetExplorerCompatability_chk.Text = "Internet Explorer Compatability"
        Me.internetExplorerCompatability_chk.UseVisualStyleBackColor = True
        '
        'metatags_chkbox
        '
        Me.metatags_chkbox.AutoSize = True
        Me.metatags_chkbox.Location = New System.Drawing.Point(6, 42)
        Me.metatags_chkbox.Name = "metatags_chkbox"
        Me.metatags_chkbox.Size = New System.Drawing.Size(156, 17)
        Me.metatags_chkbox.TabIndex = 3
        Me.metatags_chkbox.Text = "Meta Tags (Experamental)"
        Me.metatags_chkbox.UseVisualStyleBackColor = True
        '
        'UTF8_Set_chkbox
        '
        Me.UTF8_Set_chkbox.AutoSize = True
        Me.UTF8_Set_chkbox.Location = New System.Drawing.Point(6, 19)
        Me.UTF8_Set_chkbox.Name = "UTF8_Set_chkbox"
        Me.UTF8_Set_chkbox.Size = New System.Drawing.Size(98, 17)
        Me.UTF8_Set_chkbox.TabIndex = 2
        Me.UTF8_Set_chkbox.Text = "UTF-8 Charset"
        Me.UTF8_Set_chkbox.UseVisualStyleBackColor = True
        '
        'credit_chkbox
        '
        Me.credit_chkbox.AutoSize = True
        Me.credit_chkbox.Location = New System.Drawing.Point(6, 111)
        Me.credit_chkbox.Name = "credit_chkbox"
        Me.credit_chkbox.Size = New System.Drawing.Size(81, 17)
        Me.credit_chkbox.TabIndex = 1
        Me.credit_chkbox.Text = "Add Credit"
        Me.credit_chkbox.UseVisualStyleBackColor = True
        '
        'mobileViewport_chkbox
        '
        Me.mobileViewport_chkbox.AutoSize = True
        Me.mobileViewport_chkbox.Location = New System.Drawing.Point(6, 65)
        Me.mobileViewport_chkbox.Name = "mobileViewport_chkbox"
        Me.mobileViewport_chkbox.Size = New System.Drawing.Size(134, 17)
        Me.mobileViewport_chkbox.TabIndex = 0
        Me.mobileViewport_chkbox.Text = "Use Mobile Viewport"
        Me.mobileViewport_chkbox.UseVisualStyleBackColor = True
        '
        'jsImport_grp
        '
        Me.jsImport_grp.Controls.Add(Me.jsImport_lst)
        Me.jsImport_grp.Controls.Add(Me.jsImport_btn)
        Me.jsImport_grp.Location = New System.Drawing.Point(475, 6)
        Me.jsImport_grp.Name = "jsImport_grp"
        Me.jsImport_grp.Size = New System.Drawing.Size(247, 586)
        Me.jsImport_grp.TabIndex = 7
        Me.jsImport_grp.TabStop = False
        Me.jsImport_grp.Text = "JavaScript Libraries"
        '
        'jsImport_lst
        '
        Me.jsImport_lst.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.jsImport_lst.ContextMenuStrip = Me.JSContextMenu
        Me.jsImport_lst.FormattingEnabled = True
        Me.jsImport_lst.Location = New System.Drawing.Point(6, 48)
        Me.jsImport_lst.Name = "jsImport_lst"
        Me.jsImport_lst.Size = New System.Drawing.Size(235, 524)
        Me.jsImport_lst.TabIndex = 9
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
        'jsImport_btn
        '
        Me.jsImport_btn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.jsImport_btn.ForeColor = System.Drawing.Color.Black
        Me.jsImport_btn.Location = New System.Drawing.Point(6, 19)
        Me.jsImport_btn.Name = "jsImport_btn"
        Me.jsImport_btn.Size = New System.Drawing.Size(235, 23)
        Me.jsImport_btn.TabIndex = 5
        Me.jsImport_btn.Text = "Import New Library"
        Me.jsImport_btn.UseVisualStyleBackColor = True
        '
        'cssImport_grp
        '
        Me.cssImport_grp.Controls.Add(Me.cssImport_lst)
        Me.cssImport_grp.Controls.Add(Me.cssImport_btn)
        Me.cssImport_grp.Location = New System.Drawing.Point(222, 6)
        Me.cssImport_grp.Name = "cssImport_grp"
        Me.cssImport_grp.Size = New System.Drawing.Size(247, 586)
        Me.cssImport_grp.TabIndex = 6
        Me.cssImport_grp.TabStop = False
        Me.cssImport_grp.Text = "CSS Libraries"
        '
        'cssImport_lst
        '
        Me.cssImport_lst.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cssImport_lst.ContextMenuStrip = Me.CSSContextMenu
        Me.cssImport_lst.FormattingEnabled = True
        Me.cssImport_lst.Location = New System.Drawing.Point(6, 48)
        Me.cssImport_lst.Name = "cssImport_lst"
        Me.cssImport_lst.Size = New System.Drawing.Size(235, 524)
        Me.cssImport_lst.TabIndex = 8
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
        'cssImport_btn
        '
        Me.cssImport_btn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cssImport_btn.ForeColor = System.Drawing.Color.Black
        Me.cssImport_btn.Location = New System.Drawing.Point(6, 19)
        Me.cssImport_btn.Name = "cssImport_btn"
        Me.cssImport_btn.Size = New System.Drawing.Size(235, 23)
        Me.cssImport_btn.TabIndex = 4
        Me.cssImport_btn.Text = "Import New Library"
        Me.cssImport_btn.UseVisualStyleBackColor = True
        '
        'pageTitle_lbl
        '
        Me.pageTitle_lbl.AutoSize = True
        Me.pageTitle_lbl.Location = New System.Drawing.Point(8, 6)
        Me.pageTitle_lbl.Name = "pageTitle_lbl"
        Me.pageTitle_lbl.Size = New System.Drawing.Size(57, 13)
        Me.pageTitle_lbl.TabIndex = 3
        Me.pageTitle_lbl.Text = "Page Title"
        '
        'pageTitle_txtBox
        '
        Me.pageTitle_txtBox.Location = New System.Drawing.Point(6, 22)
        Me.pageTitle_txtBox.MaxLength = 64
        Me.pageTitle_txtBox.Name = "pageTitle_txtBox"
        Me.pageTitle_txtBox.Size = New System.Drawing.Size(210, 22)
        Me.pageTitle_txtBox.TabIndex = 2
        Me.pageTitle_txtBox.Text = "Cool Website"
        '
        'HTMLEditorError
        '
        Me.HTMLEditorError.Location = New System.Drawing.Point(6, 192)
        Me.HTMLEditorError.Name = "HTMLEditorError"
        Me.HTMLEditorError.Size = New System.Drawing.Size(17, 22)
        Me.HTMLEditorError.TabIndex = 0
        Me.HTMLEditorError.Visible = False
        '
        'Pg_Editor
        '
        Me.Pg_Editor.BackColor = System.Drawing.Color.Gray
        Me.Pg_Editor.Controls.Add(Me.mainEditor_grp)
        Me.Pg_Editor.Controls.Add(Me.Component_Box)
        Me.Pg_Editor.Location = New System.Drawing.Point(4, 22)
        Me.Pg_Editor.Name = "Pg_Editor"
        Me.Pg_Editor.Padding = New System.Windows.Forms.Padding(3)
        Me.Pg_Editor.Size = New System.Drawing.Size(944, 600)
        Me.Pg_Editor.TabIndex = 9
        Me.Pg_Editor.Text = "Editor"
        '
        'mainEditor_grp
        '
        Me.mainEditor_grp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mainEditor_grp.Controls.Add(Me.CodeEditorBox)
        Me.mainEditor_grp.Location = New System.Drawing.Point(8, 6)
        Me.mainEditor_grp.Name = "mainEditor_grp"
        Me.mainEditor_grp.Size = New System.Drawing.Size(776, 586)
        Me.mainEditor_grp.TabIndex = 11
        Me.mainEditor_grp.TabStop = False
        Me.mainEditor_grp.Text = "Body Editor"
        '
        'CodeEditorBox
        '
        Me.CodeEditorBox.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.CodeEditorBox.AutoIndentCharsPatterns = "^\s*[\w\.]+(\s\w+)?\s*(?<range>=)\s*(?<range>[^;=]+);" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "^\s*(case|default)\s*[^:]*" &
    "(?<range>:)\s*(?<range>[^;]+);"
        Me.CodeEditorBox.AutoScrollMinSize = New System.Drawing.Size(2, 14)
        Me.CodeEditorBox.BackBrush = Nothing
        Me.CodeEditorBox.CharHeight = 14
        Me.CodeEditorBox.CharWidth = 8
        Me.CodeEditorBox.ContextMenuStrip = Me.MainEditorContextMenu
        Me.CodeEditorBox.CurrentPenSize = 3
        Me.CodeEditorBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CodeEditorBox.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.CodeEditorBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CodeEditorBox.DocumentPath = Nothing
        Me.CodeEditorBox.ForeColor = System.Drawing.Color.Black
        Me.CodeEditorBox.IsReplaceMode = False
        Me.CodeEditorBox.Location = New System.Drawing.Point(3, 18)
        Me.CodeEditorBox.Name = "CodeEditorBox"
        Me.CodeEditorBox.Paddings = New System.Windows.Forms.Padding(0)
        Me.CodeEditorBox.SelectionChangedDelayedEnabled = False
        Me.CodeEditorBox.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CodeEditorBox.ServiceColors = CType(resources.GetObject("CodeEditorBox.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.CodeEditorBox.Size = New System.Drawing.Size(770, 565)
        Me.CodeEditorBox.TabIndex = 0
        Me.CodeEditorBox.Zoom = 100
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
        'Component_Box
        '
        Me.Component_Box.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Component_Box.FormattingEnabled = True
        Me.Component_Box.Items.AddRange(New Object() {"<!-- Comment -->", "<a href=""""></a>", "<abbr></abbr>", "<address></address>", "<area>", "<article></article>", "<aside></aside>", "<audio></audio>", "<b></b>", "<base>", "<bdi></bdi>", "<bdo></bdo>", "<blockquote></blockquote>", "<body></body>", "<br>", "<button></button>", "<canvas></canvas>", "<caption></caption>", "<cite></cite>", "<code></code>", "<col>", "<colgroup></colgroup>", "<command></command>", "<datalist>", "<dd></dd>", "<del></del>", "<details></details>", "<dfn></dfn>", "<div class=""""></div>", "<dl></dl>", "<dt></dt>", "<em></em>", "<embed></datalist>", "<fieldset></fieldset>", "<figcaption></figcaption>", "<figure></figure>", "<footer></footer>", "<form></form>", "<h1></h1>", "<h2></h2>", "<h3></h3>", "<h4></h4>", "<h5></h5>", "<h6></h6>", "<head></head>", "<header></header>", "<hgroup></hgroup>", "<hr>", "<html></html>", "<i></i>", "<iframe src=""""></iframe>", "<img>", "<input>", "<ins></ins>", "<kbd></kbd>", "<label></label>", "<legend></legend>", "<li></li>", "<link>", "<map></map>", "<mark></mark>", "<menu></menu>", "<meta>", "<meter></meter>", "<nav></nav>", "<noscript></noscript>", "<object></object>", "<ol></ol>", "<optgroup></optgroup>", "<option></option>", "<output></output>", "<p></p>", "<param>", "<pre></pre>", "<progress></progress>", "<q></q>", "<rp></rp>", "<rt></rt>", "<ruby></ruby>", "<s></s>", "<samp></samp>", "<script></script>", "<section></section>", "<select></select>", "<small></small>", "<source>", "<span></span>", "<strong></strong>", "<style></style>", "<sub></sub>", "<summary></summary>", "<sup></sup>", "<table></table>", "<tbody></tbody>", "<td></td>", "<textarea></textarea>", "<tfoot></tfoot>", "<th></th>", "<thead></thead>", "<time></time>", "<title></title>", "<tr></tr>", "<track>", "<u></u>", "<ul></ul>", "<var></var>", "<video></video>", "<wbr>"})
        Me.Component_Box.Location = New System.Drawing.Point(790, 3)
        Me.Component_Box.Name = "Component_Box"
        Me.Component_Box.Size = New System.Drawing.Size(146, 589)
        Me.Component_Box.TabIndex = 10
        '
        'Pg_Meta
        '
        Me.Pg_Meta.BackColor = System.Drawing.Color.Gray
        Me.Pg_Meta.Controls.Add(Me.description_txtBox)
        Me.Pg_Meta.Controls.Add(Me.description_lbl)
        Me.Pg_Meta.Controls.Add(Me.title_txtBox)
        Me.Pg_Meta.Controls.Add(Me.title_lbl)
        Me.Pg_Meta.Controls.Add(Me.keywords_txtBox)
        Me.Pg_Meta.Controls.Add(Me.keywords_lbl)
        Me.Pg_Meta.Controls.Add(Me.revisit_txtBox)
        Me.Pg_Meta.Controls.Add(Me.revisit_lbl)
        Me.Pg_Meta.Controls.Add(Me.siteAuthor_txtbox)
        Me.Pg_Meta.Controls.Add(Me.siteAuthor_lbl)
        Me.Pg_Meta.Location = New System.Drawing.Point(4, 22)
        Me.Pg_Meta.Name = "Pg_Meta"
        Me.Pg_Meta.Size = New System.Drawing.Size(944, 600)
        Me.Pg_Meta.TabIndex = 6
        Me.Pg_Meta.Text = "Meta Tags"
        '
        'description_txtBox
        '
        Me.description_txtBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.description_txtBox.Location = New System.Drawing.Point(74, 81)
        Me.description_txtBox.Name = "description_txtBox"
        Me.description_txtBox.Size = New System.Drawing.Size(862, 22)
        Me.description_txtBox.TabIndex = 9
        '
        'description_lbl
        '
        Me.description_lbl.AutoSize = True
        Me.description_lbl.Location = New System.Drawing.Point(8, 84)
        Me.description_lbl.Name = "description_lbl"
        Me.description_lbl.Size = New System.Drawing.Size(66, 13)
        Me.description_lbl.TabIndex = 8
        Me.description_lbl.Text = "Description"
        '
        'title_txtBox
        '
        Me.title_txtBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.title_txtBox.Location = New System.Drawing.Point(41, 107)
        Me.title_txtBox.Name = "title_txtBox"
        Me.title_txtBox.Size = New System.Drawing.Size(895, 22)
        Me.title_txtBox.TabIndex = 7
        '
        'title_lbl
        '
        Me.title_lbl.AutoSize = True
        Me.title_lbl.Location = New System.Drawing.Point(8, 110)
        Me.title_lbl.Name = "title_lbl"
        Me.title_lbl.Size = New System.Drawing.Size(29, 13)
        Me.title_lbl.TabIndex = 6
        Me.title_lbl.Text = "Title"
        '
        'keywords_txtBox
        '
        Me.keywords_txtBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.keywords_txtBox.Location = New System.Drawing.Point(67, 55)
        Me.keywords_txtBox.Name = "keywords_txtBox"
        Me.keywords_txtBox.Size = New System.Drawing.Size(869, 22)
        Me.keywords_txtBox.TabIndex = 5
        '
        'keywords_lbl
        '
        Me.keywords_lbl.AutoSize = True
        Me.keywords_lbl.Location = New System.Drawing.Point(8, 58)
        Me.keywords_lbl.Name = "keywords_lbl"
        Me.keywords_lbl.Size = New System.Drawing.Size(56, 13)
        Me.keywords_lbl.TabIndex = 4
        Me.keywords_lbl.Text = "Keywords"
        '
        'revisit_txtBox
        '
        Me.revisit_txtBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.revisit_txtBox.Location = New System.Drawing.Point(111, 29)
        Me.revisit_txtBox.MaxLength = 1
        Me.revisit_txtBox.Name = "revisit_txtBox"
        Me.revisit_txtBox.Size = New System.Drawing.Size(825, 22)
        Me.revisit_txtBox.TabIndex = 3
        '
        'revisit_lbl
        '
        Me.revisit_lbl.AutoSize = True
        Me.revisit_lbl.Location = New System.Drawing.Point(8, 32)
        Me.revisit_lbl.Name = "revisit_lbl"
        Me.revisit_lbl.Size = New System.Drawing.Size(101, 13)
        Me.revisit_lbl.TabIndex = 2
        Me.revisit_lbl.Text = "Revisit After (Days)"
        '
        'siteAuthor_txtbox
        '
        Me.siteAuthor_txtbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.siteAuthor_txtbox.Location = New System.Drawing.Point(73, 3)
        Me.siteAuthor_txtbox.Name = "siteAuthor_txtbox"
        Me.siteAuthor_txtbox.Size = New System.Drawing.Size(863, 22)
        Me.siteAuthor_txtbox.TabIndex = 1
        '
        'siteAuthor_lbl
        '
        Me.siteAuthor_lbl.AutoSize = True
        Me.siteAuthor_lbl.Location = New System.Drawing.Point(8, 6)
        Me.siteAuthor_lbl.Name = "siteAuthor_lbl"
        Me.siteAuthor_lbl.Size = New System.Drawing.Size(65, 13)
        Me.siteAuthor_lbl.TabIndex = 0
        Me.siteAuthor_lbl.Text = "Site Author"
        '
        'Pg_Export
        '
        Me.Pg_Export.BackColor = System.Drawing.Color.Gray
        Me.Pg_Export.Controls.Add(Me.Btn_Export)
        Me.Pg_Export.Controls.Add(Me.Code_Export_Code_Box)
        Me.Pg_Export.Location = New System.Drawing.Point(4, 22)
        Me.Pg_Export.Name = "Pg_Export"
        Me.Pg_Export.Size = New System.Drawing.Size(944, 600)
        Me.Pg_Export.TabIndex = 2
        Me.Pg_Export.Text = "Export"
        '
        'Btn_Export
        '
        Me.Btn_Export.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Export.ForeColor = System.Drawing.Color.Black
        Me.Btn_Export.Location = New System.Drawing.Point(861, 574)
        Me.Btn_Export.Name = "Btn_Export"
        Me.Btn_Export.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Export.TabIndex = 1
        Me.Btn_Export.Text = "Export"
        Me.Btn_Export.UseVisualStyleBackColor = True
        '
        'Code_Export_Code_Box
        '
        Me.Code_Export_Code_Box.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Code_Export_Code_Box.Location = New System.Drawing.Point(0, 0)
        Me.Code_Export_Code_Box.Name = "Code_Export_Code_Box"
        Me.Code_Export_Code_Box.ReadOnly = True
        Me.Code_Export_Code_Box.Size = New System.Drawing.Size(944, 568)
        Me.Code_Export_Code_Box.TabIndex = 0
        Me.Code_Export_Code_Box.Text = ""
        '
        'Pg_Preview
        '
        Me.Pg_Preview.BackColor = System.Drawing.Color.Gray
        Me.Pg_Preview.Controls.Add(Me.builtInPreview_grp)
        Me.Pg_Preview.Controls.Add(Me.preview_Python)
        Me.Pg_Preview.Controls.Add(Me.previewNew_grp)
        Me.Pg_Preview.Controls.Add(Me.preview_lbl)
        Me.Pg_Preview.ForeColor = System.Drawing.Color.White
        Me.Pg_Preview.Location = New System.Drawing.Point(4, 22)
        Me.Pg_Preview.Name = "Pg_Preview"
        Me.Pg_Preview.Padding = New System.Windows.Forms.Padding(3)
        Me.Pg_Preview.Size = New System.Drawing.Size(944, 600)
        Me.Pg_Preview.TabIndex = 8
        Me.Pg_Preview.Text = "Preview"
        '
        'builtInPreview_grp
        '
        Me.builtInPreview_grp.Controls.Add(Me.builtInPreview_btn)
        Me.builtInPreview_grp.Location = New System.Drawing.Point(8, 252)
        Me.builtInPreview_grp.Name = "builtInPreview_grp"
        Me.builtInPreview_grp.Size = New System.Drawing.Size(928, 61)
        Me.builtInPreview_grp.TabIndex = 4
        Me.builtInPreview_grp.TabStop = False
        Me.builtInPreview_grp.Text = "Built-in Preview [EXPERIMENTAL]"
        '
        'builtInPreview_btn
        '
        Me.builtInPreview_btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.builtInPreview_btn.ForeColor = System.Drawing.Color.Black
        Me.builtInPreview_btn.Location = New System.Drawing.Point(3, 18)
        Me.builtInPreview_btn.Name = "builtInPreview_btn"
        Me.builtInPreview_btn.Size = New System.Drawing.Size(922, 40)
        Me.builtInPreview_btn.TabIndex = 6
        Me.builtInPreview_btn.Text = "Start Preview"
        Me.builtInPreview_btn.UseVisualStyleBackColor = True
        '
        'preview_Python
        '
        Me.preview_Python.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.preview_Python.Controls.Add(Me.pythonPreview_btn)
        Me.preview_Python.Controls.Add(Me.pythonPreviewBrowser_cmb)
        Me.preview_Python.Controls.Add(Me.pythonPreview_lbl)
        Me.preview_Python.Location = New System.Drawing.Point(8, 143)
        Me.preview_Python.Name = "preview_Python"
        Me.preview_Python.Size = New System.Drawing.Size(928, 103)
        Me.preview_Python.TabIndex = 3
        Me.preview_Python.TabStop = False
        Me.preview_Python.Text = "Python Preview Settings (Beta)"
        '
        'pythonPreview_btn
        '
        Me.pythonPreview_btn.ForeColor = System.Drawing.Color.Black
        Me.pythonPreview_btn.Location = New System.Drawing.Point(6, 69)
        Me.pythonPreview_btn.Name = "pythonPreview_btn"
        Me.pythonPreview_btn.Size = New System.Drawing.Size(71, 26)
        Me.pythonPreview_btn.TabIndex = 5
        Me.pythonPreview_btn.Text = "Preview"
        Me.pythonPreview_btn.UseVisualStyleBackColor = True
        '
        'pythonPreviewBrowser_cmb
        '
        Me.pythonPreviewBrowser_cmb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pythonPreviewBrowser_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pythonPreviewBrowser_cmb.FormattingEnabled = True
        Me.pythonPreviewBrowser_cmb.Location = New System.Drawing.Point(6, 34)
        Me.pythonPreviewBrowser_cmb.Name = "pythonPreviewBrowser_cmb"
        Me.pythonPreviewBrowser_cmb.Size = New System.Drawing.Size(916, 21)
        Me.pythonPreviewBrowser_cmb.TabIndex = 4
        '
        'pythonPreview_lbl
        '
        Me.pythonPreview_lbl.AutoSize = True
        Me.pythonPreview_lbl.Location = New System.Drawing.Point(6, 18)
        Me.pythonPreview_lbl.Name = "pythonPreview_lbl"
        Me.pythonPreview_lbl.Size = New System.Drawing.Size(48, 13)
        Me.pythonPreview_lbl.TabIndex = 3
        Me.pythonPreview_lbl.Text = "Browser"
        '
        'previewNew_grp
        '
        Me.previewNew_grp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.previewNew_grp.Controls.Add(Me.preview_btn)
        Me.previewNew_grp.Controls.Add(Me.BrowserListing_cmb)
        Me.previewNew_grp.Controls.Add(Me.previewBrowser_lbl)
        Me.previewNew_grp.Location = New System.Drawing.Point(8, 36)
        Me.previewNew_grp.Name = "previewNew_grp"
        Me.previewNew_grp.Size = New System.Drawing.Size(928, 101)
        Me.previewNew_grp.TabIndex = 1
        Me.previewNew_grp.TabStop = False
        Me.previewNew_grp.Text = "Preview Settings"
        '
        'preview_btn
        '
        Me.preview_btn.ForeColor = System.Drawing.Color.Black
        Me.preview_btn.Location = New System.Drawing.Point(6, 69)
        Me.preview_btn.Name = "preview_btn"
        Me.preview_btn.Size = New System.Drawing.Size(71, 26)
        Me.preview_btn.TabIndex = 2
        Me.preview_btn.Text = "Preview"
        Me.preview_btn.UseVisualStyleBackColor = True
        '
        'BrowserListing_cmb
        '
        Me.BrowserListing_cmb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrowserListing_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BrowserListing_cmb.FormattingEnabled = True
        Me.BrowserListing_cmb.Location = New System.Drawing.Point(6, 34)
        Me.BrowserListing_cmb.Name = "BrowserListing_cmb"
        Me.BrowserListing_cmb.Size = New System.Drawing.Size(916, 21)
        Me.BrowserListing_cmb.TabIndex = 1
        '
        'previewBrowser_lbl
        '
        Me.previewBrowser_lbl.AutoSize = True
        Me.previewBrowser_lbl.Location = New System.Drawing.Point(6, 18)
        Me.previewBrowser_lbl.Name = "previewBrowser_lbl"
        Me.previewBrowser_lbl.Size = New System.Drawing.Size(48, 13)
        Me.previewBrowser_lbl.TabIndex = 0
        Me.previewBrowser_lbl.Text = "Browser"
        '
        'preview_lbl
        '
        Me.preview_lbl.AutoSize = True
        Me.preview_lbl.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.preview_lbl.Location = New System.Drawing.Point(6, 3)
        Me.preview_lbl.Name = "preview_lbl"
        Me.preview_lbl.Size = New System.Drawing.Size(90, 30)
        Me.preview_lbl.TabIndex = 0
        Me.preview_lbl.Text = "Preview"
        '
        'Pg_RedirectMaker
        '
        Me.Pg_RedirectMaker.BackColor = System.Drawing.Color.Gray
        Me.Pg_RedirectMaker.Controls.Add(Me.redirectMakerCodeBox)
        Me.Pg_RedirectMaker.Controls.Add(Me.redirectMakerInfo_lbl)
        Me.Pg_RedirectMaker.Controls.Add(Me.redirectMakerTools_grp)
        Me.Pg_RedirectMaker.Controls.Add(Me.redirectMakerTitle_lbl)
        Me.Pg_RedirectMaker.Location = New System.Drawing.Point(4, 22)
        Me.Pg_RedirectMaker.Name = "Pg_RedirectMaker"
        Me.Pg_RedirectMaker.Size = New System.Drawing.Size(944, 600)
        Me.Pg_RedirectMaker.TabIndex = 7
        Me.Pg_RedirectMaker.Text = "Redirect Maker"
        '
        'redirectMakerCodeBox
        '
        Me.redirectMakerCodeBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.redirectMakerCodeBox.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.redirectMakerCodeBox.AutoIndentCharsPatterns = "^\s*[\w\.]+(\s\w+)?\s*(?<range>=)\s*(?<range>[^;=]+);" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "^\s*(case|default)\s*[^:]*" &
    "(?<range>:)\s*(?<range>[^;]+);"
        Me.redirectMakerCodeBox.AutoScrollMinSize = New System.Drawing.Size(0, 14)
        Me.redirectMakerCodeBox.BackBrush = Nothing
        Me.redirectMakerCodeBox.CharHeight = 14
        Me.redirectMakerCodeBox.CharWidth = 8
        Me.redirectMakerCodeBox.CurrentPenSize = 3
        Me.redirectMakerCodeBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.redirectMakerCodeBox.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.redirectMakerCodeBox.DocumentPath = Nothing
        Me.redirectMakerCodeBox.ForeColor = System.Drawing.Color.Black
        Me.redirectMakerCodeBox.IsReplaceMode = False
        Me.redirectMakerCodeBox.Location = New System.Drawing.Point(285, 33)
        Me.redirectMakerCodeBox.Name = "redirectMakerCodeBox"
        Me.redirectMakerCodeBox.Paddings = New System.Windows.Forms.Padding(0)
        Me.redirectMakerCodeBox.SelectionChangedDelayedEnabled = False
        Me.redirectMakerCodeBox.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.redirectMakerCodeBox.ServiceColors = CType(resources.GetObject("redirectMakerCodeBox.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.redirectMakerCodeBox.Size = New System.Drawing.Size(651, 559)
        Me.redirectMakerCodeBox.TabIndex = 4
        Me.redirectMakerCodeBox.WordWrap = True
        Me.redirectMakerCodeBox.Zoom = 100
        '
        'redirectMakerInfo_lbl
        '
        Me.redirectMakerInfo_lbl.Location = New System.Drawing.Point(8, 220)
        Me.redirectMakerInfo_lbl.Name = "redirectMakerInfo_lbl"
        Me.redirectMakerInfo_lbl.Size = New System.Drawing.Size(271, 372)
        Me.redirectMakerInfo_lbl.TabIndex = 3
        Me.redirectMakerInfo_lbl.Text = "To save the created redirect, right click the code box, and click save. Code gene" &
    "rated with Redirect Maker is Minified by default."
        '
        'redirectMakerTools_grp
        '
        Me.redirectMakerTools_grp.Controls.Add(Me.Label1)
        Me.redirectMakerTools_grp.Controls.Add(Me.redirect_SecondsToWait_txtBox)
        Me.redirectMakerTools_grp.Controls.Add(Me.redirectMakerUrlPrefix_cmb)
        Me.redirectMakerTools_grp.Controls.Add(Me.redirectMakerGenerate_btn)
        Me.redirectMakerTools_grp.Controls.Add(Me.redirectMakerUrl_txtBox)
        Me.redirectMakerTools_grp.Controls.Add(Me.redirectMakerUrl_lbl)
        Me.redirectMakerTools_grp.Location = New System.Drawing.Point(8, 33)
        Me.redirectMakerTools_grp.Name = "redirectMakerTools_grp"
        Me.redirectMakerTools_grp.Size = New System.Drawing.Size(271, 184)
        Me.redirectMakerTools_grp.TabIndex = 1
        Me.redirectMakerTools_grp.TabStop = False
        Me.redirectMakerTools_grp.Text = "Redirect Maker Tools"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Seconds to wait"
        '
        'redirect_SecondsToWait_txtBox
        '
        Me.redirect_SecondsToWait_txtBox.Location = New System.Drawing.Point(101, 46)
        Me.redirect_SecondsToWait_txtBox.Name = "redirect_SecondsToWait_txtBox"
        Me.redirect_SecondsToWait_txtBox.Size = New System.Drawing.Size(164, 22)
        Me.redirect_SecondsToWait_txtBox.TabIndex = 4
        Me.redirect_SecondsToWait_txtBox.Text = "0"
        '
        'redirectMakerUrlPrefix_cmb
        '
        Me.redirectMakerUrlPrefix_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.redirectMakerUrlPrefix_cmb.FormattingEnabled = True
        Me.redirectMakerUrlPrefix_cmb.Items.AddRange(New Object() {"http://", "https://", "ftp://", "file://"})
        Me.redirectMakerUrlPrefix_cmb.Location = New System.Drawing.Point(78, 19)
        Me.redirectMakerUrlPrefix_cmb.Name = "redirectMakerUrlPrefix_cmb"
        Me.redirectMakerUrlPrefix_cmb.Size = New System.Drawing.Size(48, 21)
        Me.redirectMakerUrlPrefix_cmb.TabIndex = 3
        '
        'redirectMakerGenerate_btn
        '
        Me.redirectMakerGenerate_btn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.redirectMakerGenerate_btn.ForeColor = System.Drawing.Color.Black
        Me.redirectMakerGenerate_btn.Location = New System.Drawing.Point(6, 155)
        Me.redirectMakerGenerate_btn.Name = "redirectMakerGenerate_btn"
        Me.redirectMakerGenerate_btn.Size = New System.Drawing.Size(259, 23)
        Me.redirectMakerGenerate_btn.TabIndex = 2
        Me.redirectMakerGenerate_btn.Text = "Generate Redirect"
        Me.redirectMakerGenerate_btn.UseVisualStyleBackColor = True
        '
        'redirectMakerUrl_txtBox
        '
        Me.redirectMakerUrl_txtBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.redirectMakerUrl_txtBox.Location = New System.Drawing.Point(132, 18)
        Me.redirectMakerUrl_txtBox.Name = "redirectMakerUrl_txtBox"
        Me.redirectMakerUrl_txtBox.Size = New System.Drawing.Size(133, 22)
        Me.redirectMakerUrl_txtBox.TabIndex = 1
        '
        'redirectMakerUrl_lbl
        '
        Me.redirectMakerUrl_lbl.AutoSize = True
        Me.redirectMakerUrl_lbl.Location = New System.Drawing.Point(6, 22)
        Me.redirectMakerUrl_lbl.Name = "redirectMakerUrl_lbl"
        Me.redirectMakerUrl_lbl.Size = New System.Drawing.Size(75, 13)
        Me.redirectMakerUrl_lbl.TabIndex = 0
        Me.redirectMakerUrl_lbl.Text = "URL To Go To"
        '
        'redirectMakerTitle_lbl
        '
        Me.redirectMakerTitle_lbl.AutoSize = True
        Me.redirectMakerTitle_lbl.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.redirectMakerTitle_lbl.Location = New System.Drawing.Point(8, 0)
        Me.redirectMakerTitle_lbl.Name = "redirectMakerTitle_lbl"
        Me.redirectMakerTitle_lbl.Size = New System.Drawing.Size(161, 30)
        Me.redirectMakerTitle_lbl.TabIndex = 0
        Me.redirectMakerTitle_lbl.Text = "Redirect Maker"
        '
        'Pg_About
        '
        Me.Pg_About.BackColor = System.Drawing.Color.Gray
        Me.Pg_About.Controls.Add(Me.licenses_btn)
        Me.Pg_About.Controls.Add(Me.gnuGpl_pic)
        Me.Pg_About.Controls.Add(Me.copyright_lbl)
        Me.Pg_About.Controls.Add(Me.version_lbl)
        Me.Pg_About.Controls.Add(Me.aboutText_lbl)
        Me.Pg_About.Controls.Add(Me.aboutTitle_lbl)
        Me.Pg_About.Controls.Add(Me.aboutImg_pic)
        Me.Pg_About.Location = New System.Drawing.Point(4, 22)
        Me.Pg_About.Name = "Pg_About"
        Me.Pg_About.Padding = New System.Windows.Forms.Padding(3)
        Me.Pg_About.Size = New System.Drawing.Size(944, 600)
        Me.Pg_About.TabIndex = 4
        Me.Pg_About.Text = "About"
        '
        'licenses_btn
        '
        Me.licenses_btn.ForeColor = System.Drawing.Color.Black
        Me.licenses_btn.Location = New System.Drawing.Point(164, 569)
        Me.licenses_btn.Name = "licenses_btn"
        Me.licenses_btn.Size = New System.Drawing.Size(159, 23)
        Me.licenses_btn.TabIndex = 7
        Me.licenses_btn.Text = "Third Party Licenses"
        Me.licenses_btn.UseVisualStyleBackColor = True
        '
        'gnuGpl_pic
        '
        Me.gnuGpl_pic.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gnuGpl_pic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gnuGpl_pic.Image = Global.EasyHTML.My.Resources.Resources.GNUGPL3
        Me.gnuGpl_pic.Location = New System.Drawing.Point(800, 524)
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
        Me.copyright_lbl.Location = New System.Drawing.Point(167, 148)
        Me.copyright_lbl.Name = "copyright_lbl"
        Me.copyright_lbl.Size = New System.Drawing.Size(108, 21)
        Me.copyright_lbl.TabIndex = 4
        Me.copyright_lbl.Text = "Copyright LBL"
        '
        'version_lbl
        '
        Me.version_lbl.AutoSize = True
        Me.version_lbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.version_lbl.Location = New System.Drawing.Point(167, 127)
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
        Me.aboutText_lbl.Size = New System.Drawing.Size(768, 81)
        Me.aboutText_lbl.TabIndex = 2
        Me.aboutText_lbl.Text = resources.GetString("aboutText_lbl.Text")
        '
        'aboutTitle_lbl
        '
        Me.aboutTitle_lbl.AutoSize = True
        Me.aboutTitle_lbl.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aboutTitle_lbl.Location = New System.Drawing.Point(164, 6)
        Me.aboutTitle_lbl.Name = "aboutTitle_lbl"
        Me.aboutTitle_lbl.Size = New System.Drawing.Size(159, 40)
        Me.aboutTitle_lbl.TabIndex = 1
        Me.aboutTitle_lbl.Text = "EasyHTML"
        '
        'aboutImg_pic
        '
        Me.aboutImg_pic.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.aboutImg_pic.Image = Global.EasyHTML.My.Resources.Resources.Side
        Me.aboutImg_pic.Location = New System.Drawing.Point(8, 6)
        Me.aboutImg_pic.Name = "aboutImg_pic"
        Me.aboutImg_pic.Size = New System.Drawing.Size(150, 588)
        Me.aboutImg_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.aboutImg_pic.TabIndex = 0
        Me.aboutImg_pic.TabStop = False
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
        'Timer1
        '
        '
        'EasyHTML
        '
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(952, 626)
        Me.Controls.Add(Me.Pgs_Main)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(968, 665)
        Me.Name = "EasyHTML"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EasyHTML"
        Me.Pgs_Main.ResumeLayout(False)
        Me.Pg_Main.ResumeLayout(False)
        Me.Pg_Main.PerformLayout()
        Me.editorControls_grp.ResumeLayout(False)
        Me.misc_grp.ResumeLayout(False)
        Me.misc_grp.PerformLayout()
        Me.jsImport_grp.ResumeLayout(False)
        Me.JSContextMenu.ResumeLayout(False)
        Me.cssImport_grp.ResumeLayout(False)
        Me.CSSContextMenu.ResumeLayout(False)
        Me.Pg_Editor.ResumeLayout(False)
        Me.mainEditor_grp.ResumeLayout(False)
        CType(Me.CodeEditorBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainEditorContextMenu.ResumeLayout(False)
        Me.Pg_Meta.ResumeLayout(False)
        Me.Pg_Meta.PerformLayout()
        Me.Pg_Export.ResumeLayout(False)
        Me.Pg_Preview.ResumeLayout(False)
        Me.Pg_Preview.PerformLayout()
        Me.builtInPreview_grp.ResumeLayout(False)
        Me.preview_Python.ResumeLayout(False)
        Me.preview_Python.PerformLayout()
        Me.previewNew_grp.ResumeLayout(False)
        Me.previewNew_grp.PerformLayout()
        Me.Pg_RedirectMaker.ResumeLayout(False)
        Me.Pg_RedirectMaker.PerformLayout()
        CType(Me.redirectMakerCodeBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.redirectMakerTools_grp.ResumeLayout(False)
        Me.redirectMakerTools_grp.PerformLayout()
        Me.Pg_About.ResumeLayout(False)
        Me.Pg_About.PerformLayout()
        CType(Me.gnuGpl_pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.aboutImg_pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.redirectMakerContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pgs_Main As TabControl
    Friend WithEvents Pg_Main As TabPage
    Friend WithEvents Pg_Export As TabPage
    Friend WithEvents Btn_Export As Button
    Friend WithEvents Code_Export_Code_Box As RichTextBox
    Friend WithEvents HTMLEditorError As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pageTitle_lbl As Label
    Friend WithEvents pageTitle_txtBox As TextBox
    Friend WithEvents jsImport_btn As Button
    Friend WithEvents cssImport_btn As Button
    Friend WithEvents jsImport_grp As GroupBox
    Friend WithEvents jsImport_lst As ListBox
    Friend WithEvents cssImport_grp As GroupBox
    Friend WithEvents cssImport_lst As ListBox
    Friend WithEvents misc_grp As GroupBox
    Friend WithEvents mobileViewport_chkbox As CheckBox
    Friend WithEvents credit_chkbox As CheckBox
    Friend WithEvents newProject_btn As Button
    Friend WithEvents loadEditorProj_btn As Button
    Friend WithEvents loadJsLibs_btn As Button
    Friend WithEvents loadCssLibs_btn As Button
    Friend WithEvents lbl_Tip1 As Label
    Friend WithEvents MainEditorContextMenu As ContextMenuStrip
    Friend WithEvents SaveEditorProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadEditorProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JSContextMenu As ContextMenuStrip
    Friend WithEvents SaveJSLibrariesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadJSLibrariesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CSSContextMenu As ContextMenuStrip
    Friend WithEvents SaveCSSLibrariesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LoadCSSLibrariesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Pg_Meta As TabPage
    Friend WithEvents Pg_About As TabPage
    Friend WithEvents SaveDialog As SaveFileDialog
    Friend WithEvents OpenDialog As OpenFileDialog
    Friend WithEvents metatags_chkbox As CheckBox
    Friend WithEvents UTF8_Set_chkbox As CheckBox
    Friend WithEvents keywords_txtBox As TextBox
    Friend WithEvents keywords_lbl As Label
    Friend WithEvents revisit_txtBox As TextBox
    Friend WithEvents revisit_lbl As Label
    Friend WithEvents siteAuthor_txtbox As TextBox
    Friend WithEvents siteAuthor_lbl As Label
    Friend WithEvents description_txtBox As TextBox
    Friend WithEvents description_lbl As Label
    Friend WithEvents title_txtBox As TextBox
    Friend WithEvents title_lbl As Label
    Friend WithEvents aboutImg_pic As PictureBox
    Friend WithEvents aboutText_lbl As Label
    Friend WithEvents aboutTitle_lbl As Label
    Friend WithEvents version_lbl As Label
    Friend WithEvents copyright_lbl As Label
    Friend WithEvents gnuGpl_pic As PictureBox
    Friend WithEvents Pg_RedirectMaker As TabPage
    Friend WithEvents redirectMakerTools_grp As GroupBox
    Friend WithEvents redirectMakerUrl_txtBox As TextBox
    Friend WithEvents redirectMakerUrl_lbl As Label
    Friend WithEvents redirectMakerTitle_lbl As Label
    Friend WithEvents redirectMakerInfo_lbl As Label
    Friend WithEvents redirectMakerContextMenu As ContextMenuStrip
    Friend WithEvents SaveRedirectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents redirectMakerGenerate_btn As Button
    Friend WithEvents redirectMakerUrlPrefix_cmb As ComboBox
    Friend WithEvents Pg_Preview As TabPage
    Friend WithEvents preview_btn As Button
    Friend WithEvents previewNew_grp As GroupBox
    Friend WithEvents BrowserListing_cmb As ComboBox
    Friend WithEvents previewBrowser_lbl As Label
    Friend WithEvents preview_lbl As Label
    Friend WithEvents internetExplorerCompatability_chk As CheckBox
    Friend WithEvents launcher_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents redirect_SecondsToWait_txtBox As TextBox
    Friend WithEvents preview_Python As GroupBox
    Friend WithEvents licenses_btn As Button
    Friend WithEvents redirectMakerCodeBox As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents pythonPreview_btn As Button
    Friend WithEvents pythonPreviewBrowser_cmb As ComboBox
    Friend WithEvents pythonPreview_lbl As Label
    Friend WithEvents builtInPreview_grp As GroupBox
    Friend WithEvents builtInPreview_btn As Button
    Friend WithEvents Pg_Editor As TabPage
    Friend WithEvents mainEditor_grp As GroupBox
    Friend WithEvents CodeEditorBox As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents Component_Box As ListBox
    Friend WithEvents editorControls_grp As GroupBox
    Friend WithEvents newUI_btn As Button
End Class
