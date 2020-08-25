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
        Me.lbl_Tip1 = New System.Windows.Forms.Label()
        Me.loadEditorProj_btn = New System.Windows.Forms.Button()
        Me.loadJsLibs_btn = New System.Windows.Forms.Button()
        Me.loadCssLibs_btn = New System.Windows.Forms.Button()
        Me.newProject_btn = New System.Windows.Forms.Button()
        Me.mainEditor_grp = New System.Windows.Forms.GroupBox()
        Me.CodeEditorBox = New System.Windows.Forms.RichTextBox()
        Me.MainEditorContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveEditorProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadEditorProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.Component_Box = New System.Windows.Forms.ListBox()
        Me.HTMLEditorError = New System.Windows.Forms.TextBox()
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
        Me.prvwarn_LBL = New System.Windows.Forms.Label()
        Me.updatePreview_btn = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Pg_PreviewNew = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.preview_btn = New System.Windows.Forms.Button()
        Me.previewNew_grp = New System.Windows.Forms.GroupBox()
        Me.BrowserListing_cmb = New System.Windows.Forms.ComboBox()
        Me.previewBrowser_lbl = New System.Windows.Forms.Label()
        Me.preview_lbl = New System.Windows.Forms.Label()
        Me.Pg_RedirectMaker = New System.Windows.Forms.TabPage()
        Me.redirectMakerInfo_lbl = New System.Windows.Forms.Label()
        Me.redirectMakerCodeBox_rchTxtBox = New System.Windows.Forms.RichTextBox()
        Me.redirectMakerContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveRedirectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.redirectMakerTools_grp = New System.Windows.Forms.GroupBox()
        Me.redirectMakerUrlPrefix_cmb = New System.Windows.Forms.ComboBox()
        Me.redirectMakerGenerate_btn = New System.Windows.Forms.Button()
        Me.redirectMakerUrl_txtBox = New System.Windows.Forms.TextBox()
        Me.redirectMakerUrl_lbl = New System.Windows.Forms.Label()
        Me.redirectMakerTitle_lbl = New System.Windows.Forms.Label()
        Me.Pg_About = New System.Windows.Forms.TabPage()
        Me.updateCheck_btn = New System.Windows.Forms.Button()
        Me.gnuGpl_pic = New System.Windows.Forms.PictureBox()
        Me.copyright_lbl = New System.Windows.Forms.Label()
        Me.version_lbl = New System.Windows.Forms.Label()
        Me.aboutText_lbl = New System.Windows.Forms.Label()
        Me.aboutTitle_lbl = New System.Windows.Forms.Label()
        Me.aboutImg_pic = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SaveDialog = New System.Windows.Forms.SaveFileDialog()
        Me.OpenDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Pgs_Main.SuspendLayout()
        Me.Pg_Main.SuspendLayout()
        Me.mainEditor_grp.SuspendLayout()
        Me.MainEditorContextMenu.SuspendLayout()
        Me.misc_grp.SuspendLayout()
        Me.jsImport_grp.SuspendLayout()
        Me.JSContextMenu.SuspendLayout()
        Me.cssImport_grp.SuspendLayout()
        Me.CSSContextMenu.SuspendLayout()
        Me.Pg_Meta.SuspendLayout()
        Me.Pg_Export.SuspendLayout()
        Me.Pg_Preview.SuspendLayout()
        Me.Pg_PreviewNew.SuspendLayout()
        Me.previewNew_grp.SuspendLayout()
        Me.Pg_RedirectMaker.SuspendLayout()
        Me.redirectMakerContextMenu.SuspendLayout()
        Me.redirectMakerTools_grp.SuspendLayout()
        Me.Pg_About.SuspendLayout()
        CType(Me.gnuGpl_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.aboutImg_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pgs_Main
        '
        Me.Pgs_Main.Controls.Add(Me.Pg_Main)
        Me.Pgs_Main.Controls.Add(Me.Pg_Meta)
        Me.Pgs_Main.Controls.Add(Me.Pg_Export)
        Me.Pgs_Main.Controls.Add(Me.Pg_Preview)
        Me.Pgs_Main.Controls.Add(Me.Pg_PreviewNew)
        Me.Pgs_Main.Controls.Add(Me.Pg_RedirectMaker)
        Me.Pgs_Main.Controls.Add(Me.Pg_About)
        Me.Pgs_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pgs_Main.Location = New System.Drawing.Point(0, 0)
        Me.Pgs_Main.Name = "Pgs_Main"
        Me.Pgs_Main.SelectedIndex = 0
        Me.Pgs_Main.Size = New System.Drawing.Size(909, 626)
        Me.Pgs_Main.TabIndex = 0
        '
        'Pg_Main
        '
        Me.Pg_Main.BackColor = System.Drawing.Color.Gray
        Me.Pg_Main.Controls.Add(Me.lbl_Tip1)
        Me.Pg_Main.Controls.Add(Me.loadEditorProj_btn)
        Me.Pg_Main.Controls.Add(Me.loadJsLibs_btn)
        Me.Pg_Main.Controls.Add(Me.loadCssLibs_btn)
        Me.Pg_Main.Controls.Add(Me.newProject_btn)
        Me.Pg_Main.Controls.Add(Me.mainEditor_grp)
        Me.Pg_Main.Controls.Add(Me.misc_grp)
        Me.Pg_Main.Controls.Add(Me.jsImport_grp)
        Me.Pg_Main.Controls.Add(Me.cssImport_grp)
        Me.Pg_Main.Controls.Add(Me.pageTitle_lbl)
        Me.Pg_Main.Controls.Add(Me.pageTitle_txtBox)
        Me.Pg_Main.Controls.Add(Me.Component_Box)
        Me.Pg_Main.Controls.Add(Me.HTMLEditorError)
        Me.Pg_Main.Location = New System.Drawing.Point(4, 22)
        Me.Pg_Main.Name = "Pg_Main"
        Me.Pg_Main.Padding = New System.Windows.Forms.Padding(3)
        Me.Pg_Main.Size = New System.Drawing.Size(901, 600)
        Me.Pg_Main.TabIndex = 0
        Me.Pg_Main.Text = "Main Details"
        '
        'lbl_Tip1
        '
        Me.lbl_Tip1.Location = New System.Drawing.Point(628, 119)
        Me.lbl_Tip1.Name = "lbl_Tip1"
        Me.lbl_Tip1.Size = New System.Drawing.Size(116, 47)
        Me.lbl_Tip1.TabIndex = 14
        Me.lbl_Tip1.Text = "Right click on an editor to save that specific part"
        '
        'loadEditorProj_btn
        '
        Me.loadEditorProj_btn.ForeColor = System.Drawing.Color.Black
        Me.loadEditorProj_btn.Location = New System.Drawing.Point(634, 93)
        Me.loadEditorProj_btn.Name = "loadEditorProj_btn"
        Me.loadEditorProj_btn.Size = New System.Drawing.Size(107, 23)
        Me.loadEditorProj_btn.TabIndex = 13
        Me.loadEditorProj_btn.Text = "Load Editor Project"
        Me.loadEditorProj_btn.UseVisualStyleBackColor = True
        '
        'loadJsLibs_btn
        '
        Me.loadJsLibs_btn.ForeColor = System.Drawing.Color.Black
        Me.loadJsLibs_btn.Location = New System.Drawing.Point(634, 64)
        Me.loadJsLibs_btn.Name = "loadJsLibs_btn"
        Me.loadJsLibs_btn.Size = New System.Drawing.Size(107, 23)
        Me.loadJsLibs_btn.TabIndex = 12
        Me.loadJsLibs_btn.Text = "Load JS Libraries"
        Me.loadJsLibs_btn.UseVisualStyleBackColor = True
        '
        'loadCssLibs_btn
        '
        Me.loadCssLibs_btn.ForeColor = System.Drawing.Color.Black
        Me.loadCssLibs_btn.Location = New System.Drawing.Point(634, 35)
        Me.loadCssLibs_btn.Name = "loadCssLibs_btn"
        Me.loadCssLibs_btn.Size = New System.Drawing.Size(107, 23)
        Me.loadCssLibs_btn.TabIndex = 11
        Me.loadCssLibs_btn.Text = "Load CSS Libraries"
        Me.loadCssLibs_btn.UseVisualStyleBackColor = True
        '
        'newProject_btn
        '
        Me.newProject_btn.ForeColor = System.Drawing.Color.Black
        Me.newProject_btn.Location = New System.Drawing.Point(634, 6)
        Me.newProject_btn.Name = "newProject_btn"
        Me.newProject_btn.Size = New System.Drawing.Size(107, 23)
        Me.newProject_btn.TabIndex = 10
        Me.newProject_btn.Text = "New Project"
        Me.newProject_btn.UseVisualStyleBackColor = True
        '
        'mainEditor_grp
        '
        Me.mainEditor_grp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mainEditor_grp.Controls.Add(Me.CodeEditorBox)
        Me.mainEditor_grp.Location = New System.Drawing.Point(222, 162)
        Me.mainEditor_grp.Name = "mainEditor_grp"
        Me.mainEditor_grp.Size = New System.Drawing.Size(519, 430)
        Me.mainEditor_grp.TabIndex = 9
        Me.mainEditor_grp.TabStop = False
        Me.mainEditor_grp.Text = "Main Editor"
        '
        'CodeEditorBox
        '
        Me.CodeEditorBox.ContextMenuStrip = Me.MainEditorContextMenu
        Me.CodeEditorBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CodeEditorBox.Location = New System.Drawing.Point(3, 18)
        Me.CodeEditorBox.Name = "CodeEditorBox"
        Me.CodeEditorBox.Size = New System.Drawing.Size(513, 409)
        Me.CodeEditorBox.TabIndex = 0
        Me.CodeEditorBox.Text = ""
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
        'misc_grp
        '
        Me.misc_grp.Controls.Add(Me.internetExplorerCompatability_chk)
        Me.misc_grp.Controls.Add(Me.metatags_chkbox)
        Me.misc_grp.Controls.Add(Me.UTF8_Set_chkbox)
        Me.misc_grp.Controls.Add(Me.credit_chkbox)
        Me.misc_grp.Controls.Add(Me.mobileViewport_chkbox)
        Me.misc_grp.Location = New System.Drawing.Point(8, 48)
        Me.misc_grp.Name = "misc_grp"
        Me.misc_grp.Size = New System.Drawing.Size(208, 141)
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
        Me.jsImport_grp.Location = New System.Drawing.Point(428, 6)
        Me.jsImport_grp.Name = "jsImport_grp"
        Me.jsImport_grp.Size = New System.Drawing.Size(200, 150)
        Me.jsImport_grp.TabIndex = 7
        Me.jsImport_grp.TabStop = False
        Me.jsImport_grp.Text = "JavaScript Libraries"
        '
        'jsImport_lst
        '
        Me.jsImport_lst.ContextMenuStrip = Me.JSContextMenu
        Me.jsImport_lst.FormattingEnabled = True
        Me.jsImport_lst.Location = New System.Drawing.Point(6, 48)
        Me.jsImport_lst.Name = "jsImport_lst"
        Me.jsImport_lst.Size = New System.Drawing.Size(188, 95)
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
        Me.jsImport_btn.ForeColor = System.Drawing.Color.Black
        Me.jsImport_btn.Location = New System.Drawing.Point(6, 19)
        Me.jsImport_btn.Name = "jsImport_btn"
        Me.jsImport_btn.Size = New System.Drawing.Size(188, 23)
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
        Me.cssImport_grp.Size = New System.Drawing.Size(200, 150)
        Me.cssImport_grp.TabIndex = 6
        Me.cssImport_grp.TabStop = False
        Me.cssImport_grp.Text = "CSS Libraries"
        '
        'cssImport_lst
        '
        Me.cssImport_lst.ContextMenuStrip = Me.CSSContextMenu
        Me.cssImport_lst.FormattingEnabled = True
        Me.cssImport_lst.Location = New System.Drawing.Point(6, 48)
        Me.cssImport_lst.Name = "cssImport_lst"
        Me.cssImport_lst.Size = New System.Drawing.Size(188, 95)
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
        Me.cssImport_btn.ForeColor = System.Drawing.Color.Black
        Me.cssImport_btn.Location = New System.Drawing.Point(6, 19)
        Me.cssImport_btn.Name = "cssImport_btn"
        Me.cssImport_btn.Size = New System.Drawing.Size(188, 23)
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
        'Component_Box
        '
        Me.Component_Box.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Component_Box.FormattingEnabled = True
        Me.Component_Box.Items.AddRange(New Object() {"<!-- Comment -->", "<a href=""""></a>", "<abbr></abbr>", "<address></address>", "<area>", "<article></article>", "<aside></aside>", "<audio></audio>", "<b></b>", "<base>", "<bdi></bdi>", "<bdo></bdo>", "<blockquote></blockquote>", "<body></body>", "<br>", "<button></button>", "<canvas></canvas>", "<caption></caption>", "<cite></cite>", "<code></code>", "<col>", "<colgroup></colgroup>", "<command></command>", "<datalist>", "<dd></dd>", "<del></del>", "<details></details>", "<dfn></dfn>", "<div class=""""></div>", "<dl></dl>", "<dt></dt>", "<em></em>", "<embed></datalist>", "<fieldset></fieldset>", "<figcaption></figcaption>", "<figure></figure>", "<footer></footer>", "<form></form>", "<h1></h1>", "<h2></h2>", "<h3></h3>", "<h4></h4>", "<h5></h5>", "<h6></h6>", "<head></head>", "<header></header>", "<hgroup></hgroup>", "<hr>", "<html></html>", "<i></i>", "<iframe src=""""></iframe>", "<img>", "<input>", "<ins></ins>", "<kbd></kbd>", "<label></label>", "<legend></legend>", "<li></li>", "<link>", "<map></map>", "<mark></mark>", "<menu></menu>", "<meta>", "<meter></meter>", "<nav></nav>", "<noscript></noscript>", "<object></object>", "<ol></ol>", "<optgroup></optgroup>", "<option></option>", "<output></output>", "<p></p>", "<param>", "<pre></pre>", "<progress></progress>", "<q></q>", "<rp></rp>", "<rt></rt>", "<ruby></ruby>", "<s></s>", "<samp></samp>", "<script></script>", "<section></section>", "<select></select>", "<small></small>", "<source>", "<span></span>", "<strong></strong>", "<style></style>", "<sub></sub>", "<summary></summary>", "<sup></sup>", "<table></table>", "<tbody></tbody>", "<td></td>", "<textarea></textarea>", "<tfoot></tfoot>", "<th></th>", "<thead></thead>", "<time></time>", "<title></title>", "<tr></tr>", "<track>", "<u></u>", "<ul></ul>", "<var></var>", "<video></video>", "<wbr>"})
        Me.Component_Box.Location = New System.Drawing.Point(747, 6)
        Me.Component_Box.Name = "Component_Box"
        Me.Component_Box.Size = New System.Drawing.Size(146, 589)
        Me.Component_Box.TabIndex = 1
        '
        'HTMLEditorError
        '
        Me.HTMLEditorError.Location = New System.Drawing.Point(888, 584)
        Me.HTMLEditorError.Name = "HTMLEditorError"
        Me.HTMLEditorError.Size = New System.Drawing.Size(17, 22)
        Me.HTMLEditorError.TabIndex = 0
        Me.HTMLEditorError.Visible = False
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
        Me.Pg_Meta.Size = New System.Drawing.Size(901, 600)
        Me.Pg_Meta.TabIndex = 6
        Me.Pg_Meta.Text = "Meta Tags"
        '
        'description_txtBox
        '
        Me.description_txtBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.description_txtBox.Location = New System.Drawing.Point(74, 81)
        Me.description_txtBox.Name = "description_txtBox"
        Me.description_txtBox.Size = New System.Drawing.Size(819, 22)
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
        Me.title_txtBox.Size = New System.Drawing.Size(852, 22)
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
        Me.keywords_txtBox.Size = New System.Drawing.Size(826, 22)
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
        Me.revisit_txtBox.Size = New System.Drawing.Size(782, 22)
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
        Me.siteAuthor_txtbox.Size = New System.Drawing.Size(820, 22)
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
        Me.Pg_Export.Size = New System.Drawing.Size(901, 600)
        Me.Pg_Export.TabIndex = 2
        Me.Pg_Export.Text = "Export"
        '
        'Btn_Export
        '
        Me.Btn_Export.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Export.ForeColor = System.Drawing.Color.Black
        Me.Btn_Export.Location = New System.Drawing.Point(818, 574)
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
        Me.Code_Export_Code_Box.Size = New System.Drawing.Size(901, 568)
        Me.Code_Export_Code_Box.TabIndex = 0
        Me.Code_Export_Code_Box.Text = ""
        '
        'Pg_Preview
        '
        Me.Pg_Preview.BackColor = System.Drawing.Color.Gray
        Me.Pg_Preview.Controls.Add(Me.prvwarn_LBL)
        Me.Pg_Preview.Controls.Add(Me.updatePreview_btn)
        Me.Pg_Preview.Controls.Add(Me.WebBrowser1)
        Me.Pg_Preview.Location = New System.Drawing.Point(4, 22)
        Me.Pg_Preview.Name = "Pg_Preview"
        Me.Pg_Preview.Size = New System.Drawing.Size(901, 600)
        Me.Pg_Preview.TabIndex = 3
        Me.Pg_Preview.Text = "Preview"
        '
        'prvwarn_LBL
        '
        Me.prvwarn_LBL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.prvwarn_LBL.AutoSize = True
        Me.prvwarn_LBL.Location = New System.Drawing.Point(8, 582)
        Me.prvwarn_LBL.Name = "prvwarn_LBL"
        Me.prvwarn_LBL.Size = New System.Drawing.Size(413, 13)
        Me.prvwarn_LBL.TabIndex = 2
        Me.prvwarn_LBL.Text = "Preview may not be exactly what really displays, as the browser this uses is bad." &
    ""
        '
        'updatePreview_btn
        '
        Me.updatePreview_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.updatePreview_btn.ForeColor = System.Drawing.Color.Black
        Me.updatePreview_btn.Location = New System.Drawing.Point(796, 575)
        Me.updatePreview_btn.Name = "updatePreview_btn"
        Me.updatePreview_btn.Size = New System.Drawing.Size(97, 23)
        Me.updatePreview_btn.TabIndex = 1
        Me.updatePreview_btn.Text = "Update Preview"
        Me.updatePreview_btn.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(895, 566)
        Me.WebBrowser1.TabIndex = 0
        '
        'Pg_PreviewNew
        '
        Me.Pg_PreviewNew.BackColor = System.Drawing.Color.Gray
        Me.Pg_PreviewNew.Controls.Add(Me.Label1)
        Me.Pg_PreviewNew.Controls.Add(Me.preview_btn)
        Me.Pg_PreviewNew.Controls.Add(Me.previewNew_grp)
        Me.Pg_PreviewNew.Controls.Add(Me.preview_lbl)
        Me.Pg_PreviewNew.ForeColor = System.Drawing.Color.White
        Me.Pg_PreviewNew.Location = New System.Drawing.Point(4, 22)
        Me.Pg_PreviewNew.Name = "Pg_PreviewNew"
        Me.Pg_PreviewNew.Padding = New System.Windows.Forms.Padding(3)
        Me.Pg_PreviewNew.Size = New System.Drawing.Size(901, 600)
        Me.Pg_PreviewNew.TabIndex = 8
        Me.Pg_PreviewNew.Text = "New Preview (Experimental)"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(404, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(489, 119)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Preview Disabled. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This is an experimental feature, and is heavly being worked o" &
    "n." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "These options will unlocked as soon as they are ready to be tested."
        '
        'preview_btn
        '
        Me.preview_btn.ForeColor = System.Drawing.Color.Black
        Me.preview_btn.Location = New System.Drawing.Point(248, 36)
        Me.preview_btn.Name = "preview_btn"
        Me.preview_btn.Size = New System.Drawing.Size(150, 119)
        Me.preview_btn.TabIndex = 2
        Me.preview_btn.Text = "Preview"
        Me.preview_btn.UseVisualStyleBackColor = True
        '
        'previewNew_grp
        '
        Me.previewNew_grp.Controls.Add(Me.BrowserListing_cmb)
        Me.previewNew_grp.Controls.Add(Me.previewBrowser_lbl)
        Me.previewNew_grp.Enabled = False
        Me.previewNew_grp.Location = New System.Drawing.Point(8, 36)
        Me.previewNew_grp.Name = "previewNew_grp"
        Me.previewNew_grp.Size = New System.Drawing.Size(234, 119)
        Me.previewNew_grp.TabIndex = 1
        Me.previewNew_grp.TabStop = False
        Me.previewNew_grp.Text = "Preview Settings"
        '
        'BrowserListing_cmb
        '
        Me.BrowserListing_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BrowserListing_cmb.FormattingEnabled = True
        Me.BrowserListing_cmb.Location = New System.Drawing.Point(0, 34)
        Me.BrowserListing_cmb.Name = "BrowserListing_cmb"
        Me.BrowserListing_cmb.Size = New System.Drawing.Size(234, 21)
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
        Me.Pg_RedirectMaker.Controls.Add(Me.redirectMakerInfo_lbl)
        Me.Pg_RedirectMaker.Controls.Add(Me.redirectMakerCodeBox_rchTxtBox)
        Me.Pg_RedirectMaker.Controls.Add(Me.redirectMakerTools_grp)
        Me.Pg_RedirectMaker.Controls.Add(Me.redirectMakerTitle_lbl)
        Me.Pg_RedirectMaker.Location = New System.Drawing.Point(4, 22)
        Me.Pg_RedirectMaker.Name = "Pg_RedirectMaker"
        Me.Pg_RedirectMaker.Size = New System.Drawing.Size(901, 600)
        Me.Pg_RedirectMaker.TabIndex = 7
        Me.Pg_RedirectMaker.Text = "Redirect Maker"
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
        'redirectMakerCodeBox_rchTxtBox
        '
        Me.redirectMakerCodeBox_rchTxtBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.redirectMakerCodeBox_rchTxtBox.ContextMenuStrip = Me.redirectMakerContextMenu
        Me.redirectMakerCodeBox_rchTxtBox.DetectUrls = False
        Me.redirectMakerCodeBox_rchTxtBox.Location = New System.Drawing.Point(285, 33)
        Me.redirectMakerCodeBox_rchTxtBox.Name = "redirectMakerCodeBox_rchTxtBox"
        Me.redirectMakerCodeBox_rchTxtBox.ReadOnly = True
        Me.redirectMakerCodeBox_rchTxtBox.Size = New System.Drawing.Size(608, 559)
        Me.redirectMakerCodeBox_rchTxtBox.TabIndex = 2
        Me.redirectMakerCodeBox_rchTxtBox.Text = ""
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
        'redirectMakerTools_grp
        '
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
        'redirectMakerUrlPrefix_cmb
        '
        Me.redirectMakerUrlPrefix_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.redirectMakerUrlPrefix_cmb.FormattingEnabled = True
        Me.redirectMakerUrlPrefix_cmb.Items.AddRange(New Object() {"http://", "https://", "ftp://", "file://"})
        Me.redirectMakerUrlPrefix_cmb.Location = New System.Drawing.Point(90, 18)
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
        Me.redirectMakerUrl_txtBox.Location = New System.Drawing.Point(144, 19)
        Me.redirectMakerUrl_txtBox.Name = "redirectMakerUrl_txtBox"
        Me.redirectMakerUrl_txtBox.Size = New System.Drawing.Size(121, 22)
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
        Me.redirectMakerTitle_lbl.Size = New System.Drawing.Size(233, 30)
        Me.redirectMakerTitle_lbl.TabIndex = 0
        Me.redirectMakerTitle_lbl.Text = "Redirect Maker (BETA)"
        '
        'Pg_About
        '
        Me.Pg_About.BackColor = System.Drawing.Color.Gray
        Me.Pg_About.Controls.Add(Me.updateCheck_btn)
        Me.Pg_About.Controls.Add(Me.gnuGpl_pic)
        Me.Pg_About.Controls.Add(Me.copyright_lbl)
        Me.Pg_About.Controls.Add(Me.version_lbl)
        Me.Pg_About.Controls.Add(Me.aboutText_lbl)
        Me.Pg_About.Controls.Add(Me.aboutTitle_lbl)
        Me.Pg_About.Controls.Add(Me.aboutImg_pic)
        Me.Pg_About.Location = New System.Drawing.Point(4, 22)
        Me.Pg_About.Name = "Pg_About"
        Me.Pg_About.Padding = New System.Windows.Forms.Padding(3)
        Me.Pg_About.Size = New System.Drawing.Size(901, 600)
        Me.Pg_About.TabIndex = 4
        Me.Pg_About.Text = "About"
        '
        'updateCheck_btn
        '
        Me.updateCheck_btn.ForeColor = System.Drawing.Color.Black
        Me.updateCheck_btn.Location = New System.Drawing.Point(171, 148)
        Me.updateCheck_btn.Name = "updateCheck_btn"
        Me.updateCheck_btn.Size = New System.Drawing.Size(105, 23)
        Me.updateCheck_btn.TabIndex = 6
        Me.updateCheck_btn.Text = "Check for Updates"
        Me.updateCheck_btn.UseVisualStyleBackColor = True
        '
        'gnuGpl_pic
        '
        Me.gnuGpl_pic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gnuGpl_pic.Image = Global.EasyHTML.My.Resources.Resources.GNUGPL3
        Me.gnuGpl_pic.Location = New System.Drawing.Point(757, 524)
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
        Me.copyright_lbl.Location = New System.Drawing.Point(168, 124)
        Me.copyright_lbl.Name = "copyright_lbl"
        Me.copyright_lbl.Size = New System.Drawing.Size(108, 21)
        Me.copyright_lbl.TabIndex = 4
        Me.copyright_lbl.Text = "Copyright LBL"
        '
        'version_lbl
        '
        Me.version_lbl.AutoSize = True
        Me.version_lbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.version_lbl.Location = New System.Drawing.Point(168, 103)
        Me.version_lbl.Name = "version_lbl"
        Me.version_lbl.Size = New System.Drawing.Size(114, 21)
        Me.version_lbl.TabIndex = 3
        Me.version_lbl.Text = "Version: X.X.X.X"
        '
        'aboutText_lbl
        '
        Me.aboutText_lbl.Location = New System.Drawing.Point(168, 46)
        Me.aboutText_lbl.Name = "aboutText_lbl"
        Me.aboutText_lbl.Size = New System.Drawing.Size(727, 57)
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
        Me.aboutImg_pic.Image = Global.EasyHTML.My.Resources.Resources.Side
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
        'EasyHTML
        '
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(909, 626)
        Me.Controls.Add(Me.Pgs_Main)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(925, 665)
        Me.Name = "EasyHTML"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EasyHTML"
        Me.Pgs_Main.ResumeLayout(False)
        Me.Pg_Main.ResumeLayout(False)
        Me.Pg_Main.PerformLayout()
        Me.mainEditor_grp.ResumeLayout(False)
        Me.MainEditorContextMenu.ResumeLayout(False)
        Me.misc_grp.ResumeLayout(False)
        Me.misc_grp.PerformLayout()
        Me.jsImport_grp.ResumeLayout(False)
        Me.JSContextMenu.ResumeLayout(False)
        Me.cssImport_grp.ResumeLayout(False)
        Me.CSSContextMenu.ResumeLayout(False)
        Me.Pg_Meta.ResumeLayout(False)
        Me.Pg_Meta.PerformLayout()
        Me.Pg_Export.ResumeLayout(False)
        Me.Pg_Preview.ResumeLayout(False)
        Me.Pg_Preview.PerformLayout()
        Me.Pg_PreviewNew.ResumeLayout(False)
        Me.Pg_PreviewNew.PerformLayout()
        Me.previewNew_grp.ResumeLayout(False)
        Me.previewNew_grp.PerformLayout()
        Me.Pg_RedirectMaker.ResumeLayout(False)
        Me.Pg_RedirectMaker.PerformLayout()
        Me.redirectMakerContextMenu.ResumeLayout(False)
        Me.redirectMakerTools_grp.ResumeLayout(False)
        Me.redirectMakerTools_grp.PerformLayout()
        Me.Pg_About.ResumeLayout(False)
        Me.Pg_About.PerformLayout()
        CType(Me.gnuGpl_pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.aboutImg_pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pgs_Main As TabControl
    Friend WithEvents Pg_Main As TabPage
    Friend WithEvents Pg_Export As TabPage
    Friend WithEvents Btn_Export As Button
    Friend WithEvents Code_Export_Code_Box As RichTextBox
    Friend WithEvents Pg_Preview As TabPage
    Friend WithEvents HTMLEditorError As TextBox
    Friend WithEvents Component_Box As ListBox
    Friend WithEvents prvwarn_LBL As Label
    Friend WithEvents updatePreview_btn As Button
    Friend WithEvents WebBrowser1 As WebBrowser
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
    Friend WithEvents mainEditor_grp As GroupBox
    Friend WithEvents CodeEditorBox As RichTextBox
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
    Friend WithEvents updateCheck_btn As Button
    Friend WithEvents Pg_RedirectMaker As TabPage
    Friend WithEvents redirectMakerTools_grp As GroupBox
    Friend WithEvents redirectMakerUrl_txtBox As TextBox
    Friend WithEvents redirectMakerUrl_lbl As Label
    Friend WithEvents redirectMakerTitle_lbl As Label
    Friend WithEvents redirectMakerInfo_lbl As Label
    Friend WithEvents redirectMakerCodeBox_rchTxtBox As RichTextBox
    Friend WithEvents redirectMakerContextMenu As ContextMenuStrip
    Friend WithEvents SaveRedirectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents redirectMakerGenerate_btn As Button
    Friend WithEvents redirectMakerUrlPrefix_cmb As ComboBox
    Friend WithEvents Pg_PreviewNew As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents preview_btn As Button
    Friend WithEvents previewNew_grp As GroupBox
    Friend WithEvents BrowserListing_cmb As ComboBox
    Friend WithEvents previewBrowser_lbl As Label
    Friend WithEvents preview_lbl As Label
    Friend WithEvents internetExplorerCompatability_chk As CheckBox
End Class
