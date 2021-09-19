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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EasyHTML_Two))
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
        Me.Main_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.SaveDialog = New System.Windows.Forms.SaveFileDialog()
        Me.OpenDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Pgs_Main = New EasyHTML_2.BonfireTabControl()
        Me.Pg_Details = New System.Windows.Forms.TabPage()
        Me.exportbox_txt = New System.Windows.Forms.TextBox()
        Me.ProjectMan_grp = New EasyHTML_2.BonfireGroupBox()
        Me.loadWholeProject_btn = New EasyHTML_2.BonfireButton()
        Me.saveWholeProject_btn = New EasyHTML_2.BonfireButton()
        Me.ProMessage1 = New EasyHTML_2.ProMessage()
        Me.ProjectManTitle_lbl = New EasyHTML_2.BonfireLabel()
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
        Me.pageTitle_txtBox = New System.Windows.Forms.TextBox()
        Me.Pg_MetaTags = New System.Windows.Forms.TabPage()
        Me.description_lbl = New EasyHTML_2.BonfireLabel()
        Me.title_lbl = New EasyHTML_2.BonfireLabel()
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
        Me.Pg_Editors_Header = New System.Windows.Forms.TabPage()
        Me.headerCodeBox_txt = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.Pg_Editors_Body = New System.Windows.Forms.TabPage()
        Me.bodyAddElement_btn = New EasyHTML_2.BonfireButton()
        Me.bodyEditor_edt = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.Pg_Editors_Footer = New System.Windows.Forms.TabPage()
        Me.footerCodeStuff_txt = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.pg_Preview = New System.Windows.Forms.TabPage()
        Me.PreviewAlert_alrt = New EasyHTML_2.ProMessage()
        Me.previewPython_btn = New EasyHTML_2.ProDescriptiveButton()
        Me.previewBrowser_btn = New EasyHTML_2.ProDescriptiveButton()
        Me.Pg_Export = New System.Windows.Forms.TabPage()
        Me.export_btn = New EasyHTML_2.ProDescriptiveButton()
        Me.exportPreview_btn = New EasyHTML_2.ProDescriptiveButton()
        Me.Pg_About = New System.Windows.Forms.TabPage()
        Me.gnuGpl_pic = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.about_lbl = New EasyHTML_2.BonfireLabel()
        Me.aboutHeader_lbl = New EasyHTML_2.BonfireLabelHeader()
        Me.Pg_ExtraStuff = New System.Windows.Forms.TabPage()
        Me.JSContextMenu.SuspendLayout()
        Me.CSSContextMenu.SuspendLayout()
        Me.MainEditorContextMenu.SuspendLayout()
        Me.redirectMakerContextMenu.SuspendLayout()
        Me.Pgs_Main.SuspendLayout()
        Me.Pg_Details.SuspendLayout()
        Me.ProjectMan_grp.SuspendLayout()
        Me.jsLibraries_grp.SuspendLayout()
        Me.cssLibraries_grp.SuspendLayout()
        Me.Misc_grp.SuspendLayout()
        Me.Pg_MetaTags.SuspendLayout()
        Me.Pg_Editors.SuspendLayout()
        Me.BonfireTabControl1.SuspendLayout()
        Me.Pg_Editors_Header.SuspendLayout()
        CType(Me.headerCodeBox_txt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pg_Editors_Body.SuspendLayout()
        CType(Me.bodyEditor_edt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pg_Editors_Footer.SuspendLayout()
        CType(Me.footerCodeStuff_txt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pg_Preview.SuspendLayout()
        Me.Pg_Export.SuspendLayout()
        Me.Pg_About.SuspendLayout()
        CType(Me.gnuGpl_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Main_Timer
        '
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
        Me.Pg_Details.Controls.Add(Me.exportbox_txt)
        Me.Pg_Details.Controls.Add(Me.ProjectMan_grp)
        Me.Pg_Details.Controls.Add(Me.jsLibraries_grp)
        Me.Pg_Details.Controls.Add(Me.cssLibraries_grp)
        Me.Pg_Details.Controls.Add(Me.Misc_grp)
        Me.Pg_Details.Controls.Add(Me.pageTitle_lbl)
        Me.Pg_Details.Controls.Add(Me.Beta_Notice_ProMsg)
        Me.Pg_Details.Controls.Add(Me.returnToLauncher_btn)
        Me.Pg_Details.Controls.Add(Me.pageTitle_txtBox)
        Me.Pg_Details.Location = New System.Drawing.Point(4, 34)
        Me.Pg_Details.Name = "Pg_Details"
        Me.Pg_Details.Padding = New System.Windows.Forms.Padding(3)
        Me.Pg_Details.Size = New System.Drawing.Size(876, 592)
        Me.Pg_Details.TabIndex = 0
        Me.Pg_Details.Text = "Details"
        '
        'exportbox_txt
        '
        Me.exportbox_txt.Location = New System.Drawing.Point(6, 191)
        Me.exportbox_txt.Name = "exportbox_txt"
        Me.exportbox_txt.Size = New System.Drawing.Size(210, 22)
        Me.exportbox_txt.TabIndex = 36
        Me.exportbox_txt.Visible = False
        '
        'ProjectMan_grp
        '
        Me.ProjectMan_grp.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ProjectMan_grp.Controls.Add(Me.loadWholeProject_btn)
        Me.ProjectMan_grp.Controls.Add(Me.saveWholeProject_btn)
        Me.ProjectMan_grp.Controls.Add(Me.ProMessage1)
        Me.ProjectMan_grp.Controls.Add(Me.ProjectManTitle_lbl)
        Me.ProjectMan_grp.Location = New System.Drawing.Point(660, 6)
        Me.ProjectMan_grp.Name = "ProjectMan_grp"
        Me.ProjectMan_grp.Size = New System.Drawing.Size(210, 578)
        Me.ProjectMan_grp.TabIndex = 35
        Me.ProjectMan_grp.Text = "BonfireGroupBox1"
        '
        'loadWholeProject_btn
        '
        Me.loadWholeProject_btn.ButtonStyle = EasyHTML_2.BonfireButton.Style.Light
        Me.loadWholeProject_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loadWholeProject_btn.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.loadWholeProject_btn.Image = Nothing
        Me.loadWholeProject_btn.Location = New System.Drawing.Point(3, 50)
        Me.loadWholeProject_btn.Name = "loadWholeProject_btn"
        Me.loadWholeProject_btn.RoundedCorners = True
        Me.loadWholeProject_btn.Size = New System.Drawing.Size(204, 26)
        Me.loadWholeProject_btn.TabIndex = 6
        Me.loadWholeProject_btn.Text = "Load Whole Project"
        '
        'saveWholeProject_btn
        '
        Me.saveWholeProject_btn.ButtonStyle = EasyHTML_2.BonfireButton.Style.Light
        Me.saveWholeProject_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.saveWholeProject_btn.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.saveWholeProject_btn.Image = Nothing
        Me.saveWholeProject_btn.Location = New System.Drawing.Point(3, 18)
        Me.saveWholeProject_btn.Name = "saveWholeProject_btn"
        Me.saveWholeProject_btn.RoundedCorners = True
        Me.saveWholeProject_btn.Size = New System.Drawing.Size(204, 26)
        Me.saveWholeProject_btn.TabIndex = 4
        Me.saveWholeProject_btn.Text = "Save Whole Project"
        '
        'ProMessage1
        '
        Me.ProMessage1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ProMessage1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProMessage1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ProMessage1.Header = "Tip!"
        Me.ProMessage1.HeaderFont = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ProMessage1.Location = New System.Drawing.Point(0, 476)
        Me.ProMessage1.Name = "ProMessage1"
        Me.ProMessage1.Size = New System.Drawing.Size(210, 102)
        Me.ProMessage1.SizeByText = False
        Me.ProMessage1.TabIndex = 5
        Me.ProMessage1.Text = "If you don't want to return to the details tab to save to project, right click on" &
    " the editor you want to save!"
        '
        'ProjectManTitle_lbl
        '
        Me.ProjectManTitle_lbl.AutoSize = True
        Me.ProjectManTitle_lbl.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ProjectManTitle_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.ProjectManTitle_lbl.Location = New System.Drawing.Point(3, 2)
        Me.ProjectManTitle_lbl.Name = "ProjectManTitle_lbl"
        Me.ProjectManTitle_lbl.Size = New System.Drawing.Size(124, 13)
        Me.ProjectManTitle_lbl.TabIndex = 4
        Me.ProjectManTitle_lbl.Text = "Project Management"
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
        Me.jsImport_lst.ContextMenuStrip = Me.JSContextMenu
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
        Me.jsImport_btn.RoundedCorners = True
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
        Me.cssImport_lst.ContextMenuStrip = Me.CSSContextMenu
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
        Me.cssImport_btn.RoundedCorners = True
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
        Me.Pg_MetaTags.Controls.Add(Me.description_lbl)
        Me.Pg_MetaTags.Controls.Add(Me.title_lbl)
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
        'description_lbl
        '
        Me.description_lbl.AutoSize = True
        Me.description_lbl.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.description_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.description_lbl.Location = New System.Drawing.Point(8, 38)
        Me.description_lbl.Name = "description_lbl"
        Me.description_lbl.Size = New System.Drawing.Size(71, 13)
        Me.description_lbl.TabIndex = 15
        Me.description_lbl.Text = "Description"
        '
        'title_lbl
        '
        Me.title_lbl.AutoSize = True
        Me.title_lbl.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.title_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.title_lbl.Location = New System.Drawing.Point(8, 10)
        Me.title_lbl.Name = "title_lbl"
        Me.title_lbl.Size = New System.Drawing.Size(31, 13)
        Me.title_lbl.TabIndex = 14
        Me.title_lbl.Text = "Title"
        '
        'description_txtBox
        '
        Me.description_txtBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.description_txtBox.Location = New System.Drawing.Point(85, 35)
        Me.description_txtBox.MaxLength = 160
        Me.description_txtBox.Name = "description_txtBox"
        Me.description_txtBox.Size = New System.Drawing.Size(783, 22)
        Me.description_txtBox.TabIndex = 13
        '
        'title_txtBox
        '
        Me.title_txtBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.title_txtBox.Location = New System.Drawing.Point(45, 7)
        Me.title_txtBox.MaxLength = 70
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
        Me.BonfireTabControl1.Controls.Add(Me.Pg_Editors_Header)
        Me.BonfireTabControl1.Controls.Add(Me.Pg_Editors_Body)
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
        'Pg_Editors_Header
        '
        Me.Pg_Editors_Header.BackColor = System.Drawing.Color.White
        Me.Pg_Editors_Header.Controls.Add(Me.headerCodeBox_txt)
        Me.Pg_Editors_Header.Location = New System.Drawing.Point(4, 34)
        Me.Pg_Editors_Header.Name = "Pg_Editors_Header"
        Me.Pg_Editors_Header.Size = New System.Drawing.Size(862, 548)
        Me.Pg_Editors_Header.TabIndex = 2
        Me.Pg_Editors_Header.Text = "Header"
        '
        'headerCodeBox_txt
        '
        Me.headerCodeBox_txt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.headerCodeBox_txt.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.headerCodeBox_txt.AutoIndentCharsPatterns = ""
        Me.headerCodeBox_txt.AutoScrollMinSize = New System.Drawing.Size(362, 14)
        Me.headerCodeBox_txt.BackBrush = Nothing
        Me.headerCodeBox_txt.CharHeight = 14
        Me.headerCodeBox_txt.CharWidth = 8
        Me.headerCodeBox_txt.CommentPrefix = Nothing
        Me.headerCodeBox_txt.CurrentPenSize = 3
        Me.headerCodeBox_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.headerCodeBox_txt.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.headerCodeBox_txt.DocumentPath = Nothing
        Me.headerCodeBox_txt.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.headerCodeBox_txt.IsReplaceMode = False
        Me.headerCodeBox_txt.Language = FastColoredTextBoxNS.Language.HTML
        Me.headerCodeBox_txt.LeftBracket = Global.Microsoft.VisualBasic.ChrW(60)
        Me.headerCodeBox_txt.LeftBracket2 = Global.Microsoft.VisualBasic.ChrW(40)
        Me.headerCodeBox_txt.Location = New System.Drawing.Point(6, 6)
        Me.headerCodeBox_txt.Name = "headerCodeBox_txt"
        Me.headerCodeBox_txt.Paddings = New System.Windows.Forms.Padding(0)
        Me.headerCodeBox_txt.RightBracket = Global.Microsoft.VisualBasic.ChrW(62)
        Me.headerCodeBox_txt.RightBracket2 = Global.Microsoft.VisualBasic.ChrW(41)
        Me.headerCodeBox_txt.SelectionChangedDelayedEnabled = False
        Me.headerCodeBox_txt.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.headerCodeBox_txt.ServiceColors = Nothing
        Me.headerCodeBox_txt.Size = New System.Drawing.Size(850, 536)
        Me.headerCodeBox_txt.TabIndex = 1
        Me.headerCodeBox_txt.Text = "<link rel=""stylesheet"" href=""/css/style.css"">"
        Me.headerCodeBox_txt.Zoom = 100
        '
        'Pg_Editors_Body
        '
        Me.Pg_Editors_Body.BackColor = System.Drawing.Color.White
        Me.Pg_Editors_Body.Controls.Add(Me.bodyAddElement_btn)
        Me.Pg_Editors_Body.Controls.Add(Me.bodyEditor_edt)
        Me.Pg_Editors_Body.Location = New System.Drawing.Point(4, 34)
        Me.Pg_Editors_Body.Name = "Pg_Editors_Body"
        Me.Pg_Editors_Body.Padding = New System.Windows.Forms.Padding(3)
        Me.Pg_Editors_Body.Size = New System.Drawing.Size(862, 548)
        Me.Pg_Editors_Body.TabIndex = 0
        Me.Pg_Editors_Body.Text = "Body"
        '
        'bodyAddElement_btn
        '
        Me.bodyAddElement_btn.ButtonStyle = EasyHTML_2.BonfireButton.Style.Dark
        Me.bodyAddElement_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bodyAddElement_btn.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.bodyAddElement_btn.Image = Nothing
        Me.bodyAddElement_btn.Location = New System.Drawing.Point(755, 516)
        Me.bodyAddElement_btn.Name = "bodyAddElement_btn"
        Me.bodyAddElement_btn.RoundedCorners = True
        Me.bodyAddElement_btn.Size = New System.Drawing.Size(101, 26)
        Me.bodyAddElement_btn.TabIndex = 1
        Me.bodyAddElement_btn.Text = "Add Element"
        '
        'bodyEditor_edt
        '
        Me.bodyEditor_edt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bodyEditor_edt.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.bodyEditor_edt.AutoIndentCharsPatterns = ""
        Me.bodyEditor_edt.AutoScrollMinSize = New System.Drawing.Size(114, 14)
        Me.bodyEditor_edt.BackBrush = Nothing
        Me.bodyEditor_edt.CharHeight = 14
        Me.bodyEditor_edt.CharWidth = 8
        Me.bodyEditor_edt.CommentPrefix = Nothing
        Me.bodyEditor_edt.CurrentPenSize = 3
        Me.bodyEditor_edt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.bodyEditor_edt.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.bodyEditor_edt.DocumentPath = Nothing
        Me.bodyEditor_edt.IsReplaceMode = False
        Me.bodyEditor_edt.Language = FastColoredTextBoxNS.Language.HTML
        Me.bodyEditor_edt.LeftBracket = Global.Microsoft.VisualBasic.ChrW(60)
        Me.bodyEditor_edt.LeftBracket2 = Global.Microsoft.VisualBasic.ChrW(40)
        Me.bodyEditor_edt.Location = New System.Drawing.Point(6, 6)
        Me.bodyEditor_edt.Name = "bodyEditor_edt"
        Me.bodyEditor_edt.Paddings = New System.Windows.Forms.Padding(0)
        Me.bodyEditor_edt.RightBracket = Global.Microsoft.VisualBasic.ChrW(62)
        Me.bodyEditor_edt.RightBracket2 = Global.Microsoft.VisualBasic.ChrW(41)
        Me.bodyEditor_edt.SelectionChangedDelayedEnabled = False
        Me.bodyEditor_edt.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bodyEditor_edt.ServiceColors = Nothing
        Me.bodyEditor_edt.Size = New System.Drawing.Size(850, 504)
        Me.bodyEditor_edt.TabIndex = 0
        Me.bodyEditor_edt.Text = "<p>Welcome</p>"
        Me.bodyEditor_edt.Zoom = 100
        '
        'Pg_Editors_Footer
        '
        Me.Pg_Editors_Footer.BackColor = System.Drawing.Color.White
        Me.Pg_Editors_Footer.Controls.Add(Me.footerCodeStuff_txt)
        Me.Pg_Editors_Footer.Location = New System.Drawing.Point(4, 34)
        Me.Pg_Editors_Footer.Name = "Pg_Editors_Footer"
        Me.Pg_Editors_Footer.Padding = New System.Windows.Forms.Padding(3)
        Me.Pg_Editors_Footer.Size = New System.Drawing.Size(862, 548)
        Me.Pg_Editors_Footer.TabIndex = 1
        Me.Pg_Editors_Footer.Text = "Footer"
        '
        'footerCodeStuff_txt
        '
        Me.footerCodeStuff_txt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.footerCodeStuff_txt.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.footerCodeStuff_txt.AutoIndentCharsPatterns = ""
        Me.footerCodeStuff_txt.AutoScrollMinSize = New System.Drawing.Size(162, 14)
        Me.footerCodeStuff_txt.BackBrush = Nothing
        Me.footerCodeStuff_txt.CharHeight = 14
        Me.footerCodeStuff_txt.CharWidth = 8
        Me.footerCodeStuff_txt.CommentPrefix = Nothing
        Me.footerCodeStuff_txt.CurrentPenSize = 3
        Me.footerCodeStuff_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.footerCodeStuff_txt.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.footerCodeStuff_txt.DocumentPath = Nothing
        Me.footerCodeStuff_txt.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.footerCodeStuff_txt.IsReplaceMode = False
        Me.footerCodeStuff_txt.Language = FastColoredTextBoxNS.Language.HTML
        Me.footerCodeStuff_txt.LeftBracket = Global.Microsoft.VisualBasic.ChrW(60)
        Me.footerCodeStuff_txt.LeftBracket2 = Global.Microsoft.VisualBasic.ChrW(40)
        Me.footerCodeStuff_txt.Location = New System.Drawing.Point(6, 6)
        Me.footerCodeStuff_txt.Name = "footerCodeStuff_txt"
        Me.footerCodeStuff_txt.Paddings = New System.Windows.Forms.Padding(0)
        Me.footerCodeStuff_txt.RightBracket = Global.Microsoft.VisualBasic.ChrW(62)
        Me.footerCodeStuff_txt.RightBracket2 = Global.Microsoft.VisualBasic.ChrW(41)
        Me.footerCodeStuff_txt.SelectionChangedDelayedEnabled = False
        Me.footerCodeStuff_txt.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.footerCodeStuff_txt.ServiceColors = Nothing
        Me.footerCodeStuff_txt.Size = New System.Drawing.Size(850, 536)
        Me.footerCodeStuff_txt.TabIndex = 2
        Me.footerCodeStuff_txt.Text = "<!-- Footer Code -->"
        Me.footerCodeStuff_txt.Zoom = 100
        '
        'pg_Preview
        '
        Me.pg_Preview.BackColor = System.Drawing.Color.White
        Me.pg_Preview.Controls.Add(Me.PreviewAlert_alrt)
        Me.pg_Preview.Controls.Add(Me.previewPython_btn)
        Me.pg_Preview.Controls.Add(Me.previewBrowser_btn)
        Me.pg_Preview.Location = New System.Drawing.Point(4, 34)
        Me.pg_Preview.Name = "pg_Preview"
        Me.pg_Preview.Size = New System.Drawing.Size(876, 592)
        Me.pg_Preview.TabIndex = 3
        Me.pg_Preview.Text = "Preview"
        '
        'PreviewAlert_alrt
        '
        Me.PreviewAlert_alrt.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PreviewAlert_alrt.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.PreviewAlert_alrt.Header = "Hello!"
        Me.PreviewAlert_alrt.HeaderFont = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.PreviewAlert_alrt.Location = New System.Drawing.Point(8, 504)
        Me.PreviewAlert_alrt.Name = "PreviewAlert_alrt"
        Me.PreviewAlert_alrt.Size = New System.Drawing.Size(860, 80)
        Me.PreviewAlert_alrt.SizeByText = False
        Me.PreviewAlert_alrt.TabIndex = 2
        Me.PreviewAlert_alrt.Text = "I know that there are only two options at the moment.. This is because these are " &
    "the only two I could figure out how to run at the moment. I will add more when I" &
    " can."
        '
        'previewPython_btn
        '
        Me.previewPython_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.previewPython_btn.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.previewPython_btn.Image = Nothing
        Me.previewPython_btn.Location = New System.Drawing.Point(214, 3)
        Me.previewPython_btn.Name = "previewPython_btn"
        Me.previewPython_btn.Size = New System.Drawing.Size(200, 149)
        Me.previewPython_btn.TabIndex = 1
        Me.previewPython_btn.Text = "This will generate a simple HTML file, then will launch a Python HTTP.SERVER modu" &
    "al to run a localhost server. Requires Python."
        Me.previewPython_btn.Title = "Python Preview"
        Me.previewPython_btn.TitleFont = New System.Drawing.Font("Verdana", 14.0!)
        '
        'previewBrowser_btn
        '
        Me.previewBrowser_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.previewBrowser_btn.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.previewBrowser_btn.Image = Nothing
        Me.previewBrowser_btn.Location = New System.Drawing.Point(8, 3)
        Me.previewBrowser_btn.Name = "previewBrowser_btn"
        Me.previewBrowser_btn.Size = New System.Drawing.Size(200, 149)
        Me.previewBrowser_btn.TabIndex = 0
        Me.previewBrowser_btn.Text = "Generate a simple HTML file for you to preview your page with. This will open in " &
    "your prefered browser. This file is placed in a temporary folder."
        Me.previewBrowser_btn.Title = "Browser Preview"
        Me.previewBrowser_btn.TitleFont = New System.Drawing.Font("Verdana", 14.0!)
        '
        'Pg_Export
        '
        Me.Pg_Export.BackColor = System.Drawing.Color.White
        Me.Pg_Export.Controls.Add(Me.export_btn)
        Me.Pg_Export.Controls.Add(Me.exportPreview_btn)
        Me.Pg_Export.Location = New System.Drawing.Point(4, 34)
        Me.Pg_Export.Name = "Pg_Export"
        Me.Pg_Export.Size = New System.Drawing.Size(876, 592)
        Me.Pg_Export.TabIndex = 4
        Me.Pg_Export.Text = "Export"
        '
        'export_btn
        '
        Me.export_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.export_btn.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.export_btn.Image = Nothing
        Me.export_btn.Location = New System.Drawing.Point(268, 3)
        Me.export_btn.Name = "export_btn"
        Me.export_btn.Size = New System.Drawing.Size(200, 146)
        Me.export_btn.TabIndex = 1
        Me.export_btn.Text = "Just export the code."
        Me.export_btn.Title = "Just Export"
        Me.export_btn.TitleFont = New System.Drawing.Font("Verdana", 14.0!)
        '
        'exportPreview_btn
        '
        Me.exportPreview_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exportPreview_btn.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.exportPreview_btn.Image = Nothing
        Me.exportPreview_btn.Location = New System.Drawing.Point(8, 3)
        Me.exportPreview_btn.Name = "exportPreview_btn"
        Me.exportPreview_btn.Size = New System.Drawing.Size(254, 146)
        Me.exportPreview_btn.TabIndex = 0
        Me.exportPreview_btn.Text = "Preview the code you have made, and then you can choose to export it or not!"
        Me.exportPreview_btn.Title = "Preview Code & Export"
        Me.exportPreview_btn.TitleFont = New System.Drawing.Font("Verdana", 14.0!)
        '
        'Pg_About
        '
        Me.Pg_About.BackColor = System.Drawing.Color.White
        Me.Pg_About.Controls.Add(Me.gnuGpl_pic)
        Me.Pg_About.Controls.Add(Me.PictureBox1)
        Me.Pg_About.Controls.Add(Me.about_lbl)
        Me.Pg_About.Controls.Add(Me.aboutHeader_lbl)
        Me.Pg_About.Location = New System.Drawing.Point(4, 34)
        Me.Pg_About.Name = "Pg_About"
        Me.Pg_About.Size = New System.Drawing.Size(876, 592)
        Me.Pg_About.TabIndex = 5
        Me.Pg_About.Text = "About"
        '
        'gnuGpl_pic
        '
        Me.gnuGpl_pic.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gnuGpl_pic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gnuGpl_pic.Image = Global.EasyHTML_2.My.Resources.Resources.GNUGPL3
        Me.gnuGpl_pic.Location = New System.Drawing.Point(732, 516)
        Me.gnuGpl_pic.Name = "gnuGpl_pic"
        Me.gnuGpl_pic.Size = New System.Drawing.Size(136, 68)
        Me.gnuGpl_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.gnuGpl_pic.TabIndex = 6
        Me.gnuGpl_pic.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EasyHTML_2.My.Resources.Resources.EasyHTML2_logo
        Me.PictureBox1.Location = New System.Drawing.Point(3, 409)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(183, 180)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'about_lbl
        '
        Me.about_lbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.about_lbl.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.about_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.about_lbl.Location = New System.Drawing.Point(0, 41)
        Me.about_lbl.Name = "about_lbl"
        Me.about_lbl.Size = New System.Drawing.Size(876, 46)
        Me.about_lbl.TabIndex = 1
        Me.about_lbl.Text = resources.GetString("about_lbl.Text")
        '
        'aboutHeader_lbl
        '
        Me.aboutHeader_lbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.aboutHeader_lbl.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.aboutHeader_lbl.Location = New System.Drawing.Point(0, 0)
        Me.aboutHeader_lbl.Name = "aboutHeader_lbl"
        Me.aboutHeader_lbl.Size = New System.Drawing.Size(876, 41)
        Me.aboutHeader_lbl.TabIndex = 0
        Me.aboutHeader_lbl.Text = "EasyHTML 2"
        Me.aboutHeader_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.JSContextMenu.ResumeLayout(False)
        Me.CSSContextMenu.ResumeLayout(False)
        Me.MainEditorContextMenu.ResumeLayout(False)
        Me.redirectMakerContextMenu.ResumeLayout(False)
        Me.Pgs_Main.ResumeLayout(False)
        Me.Pg_Details.ResumeLayout(False)
        Me.Pg_Details.PerformLayout()
        Me.ProjectMan_grp.ResumeLayout(False)
        Me.ProjectMan_grp.PerformLayout()
        Me.jsLibraries_grp.ResumeLayout(False)
        Me.jsLibraries_grp.PerformLayout()
        Me.cssLibraries_grp.ResumeLayout(False)
        Me.cssLibraries_grp.PerformLayout()
        Me.Misc_grp.ResumeLayout(False)
        Me.Pg_MetaTags.ResumeLayout(False)
        Me.Pg_MetaTags.PerformLayout()
        Me.Pg_Editors.ResumeLayout(False)
        Me.BonfireTabControl1.ResumeLayout(False)
        Me.Pg_Editors_Header.ResumeLayout(False)
        CType(Me.headerCodeBox_txt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pg_Editors_Body.ResumeLayout(False)
        CType(Me.bodyEditor_edt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pg_Editors_Footer.ResumeLayout(False)
        CType(Me.footerCodeStuff_txt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pg_Preview.ResumeLayout(False)
        Me.Pg_Export.ResumeLayout(False)
        Me.Pg_About.ResumeLayout(False)
        Me.Pg_About.PerformLayout()
        CType(Me.gnuGpl_pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pgs_Main As BonfireTabControl
    Friend WithEvents Pg_Details As TabPage
    Friend WithEvents Pg_Editors As TabPage
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
    Friend WithEvents Main_Timer As Timer
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
    Friend WithEvents title_lbl As BonfireLabel
    Friend WithEvents description_txtBox As TextBox
    Friend WithEvents title_txtBox As TextBox
    Friend WithEvents description_lbl As BonfireLabel
    Friend WithEvents BonfireTabControl1 As BonfireTabControl
    Friend WithEvents Pg_Editors_Body As TabPage
    Friend WithEvents Pg_Editors_Footer As TabPage
    Friend WithEvents Pg_Editors_Header As TabPage
    Friend WithEvents bodyEditor_edt As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents headerCodeBox_txt As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents footerCodeStuff_txt As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents previewBrowser_btn As ProDescriptiveButton
    Friend WithEvents previewPython_btn As ProDescriptiveButton
    Friend WithEvents PreviewAlert_alrt As ProMessage
    Friend WithEvents ProjectMan_grp As BonfireGroupBox
    Friend WithEvents ProjectManTitle_lbl As BonfireLabel
    Friend WithEvents bodyAddElement_btn As BonfireButton
    Friend WithEvents ProMessage1 As ProMessage
    Friend WithEvents exportPreview_btn As ProDescriptiveButton
    Friend WithEvents export_btn As ProDescriptiveButton
    Friend WithEvents aboutHeader_lbl As BonfireLabelHeader
    Friend WithEvents saveWholeProject_btn As BonfireButton
    Friend WithEvents loadWholeProject_btn As BonfireButton
    Friend WithEvents about_lbl As BonfireLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents gnuGpl_pic As PictureBox
    Friend WithEvents exportbox_txt As TextBox
End Class
