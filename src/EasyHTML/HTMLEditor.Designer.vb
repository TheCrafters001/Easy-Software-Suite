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
        Me.loadEditorProj_btn = New System.Windows.Forms.Button()
        Me.loadJsLibs_btn = New System.Windows.Forms.Button()
        Me.loadCssLibs_btn = New System.Windows.Forms.Button()
        Me.newProject_btn = New System.Windows.Forms.Button()
        Me.mainEditor_grp = New System.Windows.Forms.GroupBox()
        Me.CodeEditorBox = New System.Windows.Forms.RichTextBox()
        Me.misc_grp = New System.Windows.Forms.GroupBox()
        Me.credit_chkbox = New System.Windows.Forms.CheckBox()
        Me.mobileViewport_chkbox = New System.Windows.Forms.CheckBox()
        Me.jsImport_grp = New System.Windows.Forms.GroupBox()
        Me.jsImport_lst = New System.Windows.Forms.ListBox()
        Me.jsImport_btn = New System.Windows.Forms.Button()
        Me.cssImport_grp = New System.Windows.Forms.GroupBox()
        Me.cssImport_lst = New System.Windows.Forms.ListBox()
        Me.cssImport_btn = New System.Windows.Forms.Button()
        Me.pageTitle_lbl = New System.Windows.Forms.Label()
        Me.pageTitle_txtBox = New System.Windows.Forms.TextBox()
        Me.Component_Box = New System.Windows.Forms.ListBox()
        Me.HTMLEditorError = New System.Windows.Forms.TextBox()
        Me.Pg_Export = New System.Windows.Forms.TabPage()
        Me.Btn_Export = New System.Windows.Forms.Button()
        Me.Code_Export_Code_Box = New System.Windows.Forms.RichTextBox()
        Me.Pg_Preview = New System.Windows.Forms.TabPage()
        Me.prvwarn_LBL = New System.Windows.Forms.Label()
        Me.updatePreview_btn = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Test_Page = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_Tip1 = New System.Windows.Forms.Label()
        Me.MainEditorContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.JSContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CSSContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveEditorProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadEditorProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveDialog = New System.Windows.Forms.SaveFileDialog()
        Me.OpenDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveJSLibrariesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadJSLibrariesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveCSSLibrariesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadCSSLibrariesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pg_About = New System.Windows.Forms.TabPage()
        Me.Pg_Help = New System.Windows.Forms.TabPage()
        Me.Pg_Meta = New System.Windows.Forms.TabPage()
        Me.UTF8_Set_chkbox = New System.Windows.Forms.CheckBox()
        Me.metatags_chkbox = New System.Windows.Forms.CheckBox()
        Me.siteAuthor_lbl = New System.Windows.Forms.Label()
        Me.siteAuthor_txtbox = New System.Windows.Forms.TextBox()
        Me.revisit_txtBox = New System.Windows.Forms.TextBox()
        Me.revisit_lbl = New System.Windows.Forms.Label()
        Me.keywords_txtBox = New System.Windows.Forms.TextBox()
        Me.keywords_lbl = New System.Windows.Forms.Label()
        Me.title_txtBox = New System.Windows.Forms.TextBox()
        Me.title_lbl = New System.Windows.Forms.Label()
        Me.description_txtBox = New System.Windows.Forms.TextBox()
        Me.description_lbl = New System.Windows.Forms.Label()
        Me.Pgs_Main.SuspendLayout()
        Me.Pg_Main.SuspendLayout()
        Me.mainEditor_grp.SuspendLayout()
        Me.misc_grp.SuspendLayout()
        Me.jsImport_grp.SuspendLayout()
        Me.cssImport_grp.SuspendLayout()
        Me.Pg_Export.SuspendLayout()
        Me.Pg_Preview.SuspendLayout()
        Me.Test_Page.SuspendLayout()
        Me.MainEditorContextMenu.SuspendLayout()
        Me.JSContextMenu.SuspendLayout()
        Me.CSSContextMenu.SuspendLayout()
        Me.Pg_Meta.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pgs_Main
        '
        Me.Pgs_Main.Controls.Add(Me.Pg_Main)
        Me.Pgs_Main.Controls.Add(Me.Pg_Meta)
        Me.Pgs_Main.Controls.Add(Me.Pg_Export)
        Me.Pgs_Main.Controls.Add(Me.Pg_Preview)
        Me.Pgs_Main.Controls.Add(Me.Pg_About)
        Me.Pgs_Main.Controls.Add(Me.Pg_Help)
        Me.Pgs_Main.Controls.Add(Me.Test_Page)
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
        Me.mainEditor_grp.Location = New System.Drawing.Point(3, 162)
        Me.mainEditor_grp.Name = "mainEditor_grp"
        Me.mainEditor_grp.Size = New System.Drawing.Size(738, 430)
        Me.mainEditor_grp.TabIndex = 9
        Me.mainEditor_grp.TabStop = False
        Me.mainEditor_grp.Text = "Main Editor"
        '
        'CodeEditorBox
        '
        Me.CodeEditorBox.ContextMenuStrip = Me.MainEditorContextMenu
        Me.CodeEditorBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CodeEditorBox.Location = New System.Drawing.Point(3, 16)
        Me.CodeEditorBox.Name = "CodeEditorBox"
        Me.CodeEditorBox.Size = New System.Drawing.Size(732, 411)
        Me.CodeEditorBox.TabIndex = 0
        Me.CodeEditorBox.Text = ""
        '
        'misc_grp
        '
        Me.misc_grp.Controls.Add(Me.metatags_chkbox)
        Me.misc_grp.Controls.Add(Me.UTF8_Set_chkbox)
        Me.misc_grp.Controls.Add(Me.credit_chkbox)
        Me.misc_grp.Controls.Add(Me.mobileViewport_chkbox)
        Me.misc_grp.Location = New System.Drawing.Point(8, 48)
        Me.misc_grp.Name = "misc_grp"
        Me.misc_grp.Size = New System.Drawing.Size(208, 108)
        Me.misc_grp.TabIndex = 8
        Me.misc_grp.TabStop = False
        Me.misc_grp.Text = "Misc Items"
        '
        'credit_chkbox
        '
        Me.credit_chkbox.AutoSize = True
        Me.credit_chkbox.Location = New System.Drawing.Point(6, 84)
        Me.credit_chkbox.Name = "credit_chkbox"
        Me.credit_chkbox.Size = New System.Drawing.Size(75, 17)
        Me.credit_chkbox.TabIndex = 1
        Me.credit_chkbox.Text = "Add Credit"
        Me.credit_chkbox.UseVisualStyleBackColor = True
        '
        'mobileViewport_chkbox
        '
        Me.mobileViewport_chkbox.AutoSize = True
        Me.mobileViewport_chkbox.Location = New System.Drawing.Point(6, 65)
        Me.mobileViewport_chkbox.Name = "mobileViewport_chkbox"
        Me.mobileViewport_chkbox.Size = New System.Drawing.Size(123, 17)
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
        Me.pageTitle_lbl.Size = New System.Drawing.Size(55, 13)
        Me.pageTitle_lbl.TabIndex = 3
        Me.pageTitle_lbl.Text = "Page Title"
        '
        'pageTitle_txtBox
        '
        Me.pageTitle_txtBox.Location = New System.Drawing.Point(6, 22)
        Me.pageTitle_txtBox.MaxLength = 64
        Me.pageTitle_txtBox.Name = "pageTitle_txtBox"
        Me.pageTitle_txtBox.Size = New System.Drawing.Size(210, 20)
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
        Me.HTMLEditorError.Size = New System.Drawing.Size(17, 20)
        Me.HTMLEditorError.TabIndex = 0
        Me.HTMLEditorError.Visible = False
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
        Me.Code_Export_Code_Box.Location = New System.Drawing.Point(0, 0)
        Me.Code_Export_Code_Box.Name = "Code_Export_Code_Box"
        Me.Code_Export_Code_Box.ReadOnly = True
        Me.Code_Export_Code_Box.Size = New System.Drawing.Size(901, 563)
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
        Me.prvwarn_LBL.AutoSize = True
        Me.prvwarn_LBL.Location = New System.Drawing.Point(8, 582)
        Me.prvwarn_LBL.Name = "prvwarn_LBL"
        Me.prvwarn_LBL.Size = New System.Drawing.Size(382, 13)
        Me.prvwarn_LBL.TabIndex = 2
        Me.prvwarn_LBL.Text = "Preview may not be exactly what really displays, as the browser this uses is bad." &
    ""
        '
        'updatePreview_btn
        '
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
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(895, 566)
        Me.WebBrowser1.TabIndex = 0
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
        'Timer1
        '
        '
        'lbl_Tip1
        '
        Me.lbl_Tip1.AutoSize = True
        Me.lbl_Tip1.Location = New System.Drawing.Point(628, 119)
        Me.lbl_Tip1.Name = "lbl_Tip1"
        Me.lbl_Tip1.Size = New System.Drawing.Size(116, 39)
        Me.lbl_Tip1.TabIndex = 14
        Me.lbl_Tip1.Text = "Right click on an editor" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to save that specific" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "part"
        '
        'MainEditorContextMenu
        '
        Me.MainEditorContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveEditorProjectToolStripMenuItem, Me.LoadEditorProjectToolStripMenuItem})
        Me.MainEditorContextMenu.Name = "MainEditorContextMenu"
        Me.MainEditorContextMenu.Size = New System.Drawing.Size(175, 48)
        '
        'JSContextMenu
        '
        Me.JSContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveJSLibrariesToolStripMenuItem, Me.LoadJSLibrariesToolStripMenuItem})
        Me.JSContextMenu.Name = "JSContextMenu"
        Me.JSContextMenu.Size = New System.Drawing.Size(161, 48)
        '
        'CSSContextMenu
        '
        Me.CSSContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveCSSLibrariesToolStripMenuItem1, Me.LoadCSSLibrariesToolStripMenuItem1})
        Me.CSSContextMenu.Name = "CSSContextMenu"
        Me.CSSContextMenu.Size = New System.Drawing.Size(171, 48)
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
        'Pg_About
        '
        Me.Pg_About.BackColor = System.Drawing.Color.Gray
        Me.Pg_About.Location = New System.Drawing.Point(4, 22)
        Me.Pg_About.Name = "Pg_About"
        Me.Pg_About.Padding = New System.Windows.Forms.Padding(3)
        Me.Pg_About.Size = New System.Drawing.Size(901, 600)
        Me.Pg_About.TabIndex = 4
        Me.Pg_About.Text = "About"
        '
        'Pg_Help
        '
        Me.Pg_Help.BackColor = System.Drawing.Color.Gray
        Me.Pg_Help.Location = New System.Drawing.Point(4, 22)
        Me.Pg_Help.Name = "Pg_Help"
        Me.Pg_Help.Size = New System.Drawing.Size(901, 600)
        Me.Pg_Help.TabIndex = 5
        Me.Pg_Help.Text = "Help"
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
        'UTF8_Set_chkbox
        '
        Me.UTF8_Set_chkbox.AutoSize = True
        Me.UTF8_Set_chkbox.Location = New System.Drawing.Point(6, 19)
        Me.UTF8_Set_chkbox.Name = "UTF8_Set_chkbox"
        Me.UTF8_Set_chkbox.Size = New System.Drawing.Size(95, 17)
        Me.UTF8_Set_chkbox.TabIndex = 2
        Me.UTF8_Set_chkbox.Text = "UTF-8 Charset"
        Me.UTF8_Set_chkbox.UseVisualStyleBackColor = True
        '
        'metatags_chkbox
        '
        Me.metatags_chkbox.AutoSize = True
        Me.metatags_chkbox.Location = New System.Drawing.Point(6, 42)
        Me.metatags_chkbox.Name = "metatags_chkbox"
        Me.metatags_chkbox.Size = New System.Drawing.Size(150, 17)
        Me.metatags_chkbox.TabIndex = 3
        Me.metatags_chkbox.Text = "Meta Tags (Experamental)"
        Me.metatags_chkbox.UseVisualStyleBackColor = True
        '
        'siteAuthor_lbl
        '
        Me.siteAuthor_lbl.AutoSize = True
        Me.siteAuthor_lbl.Location = New System.Drawing.Point(8, 6)
        Me.siteAuthor_lbl.Name = "siteAuthor_lbl"
        Me.siteAuthor_lbl.Size = New System.Drawing.Size(59, 13)
        Me.siteAuthor_lbl.TabIndex = 0
        Me.siteAuthor_lbl.Text = "Site Author"
        '
        'siteAuthor_txtbox
        '
        Me.siteAuthor_txtbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.siteAuthor_txtbox.Location = New System.Drawing.Point(73, 3)
        Me.siteAuthor_txtbox.Name = "siteAuthor_txtbox"
        Me.siteAuthor_txtbox.Size = New System.Drawing.Size(820, 20)
        Me.siteAuthor_txtbox.TabIndex = 1
        '
        'revisit_txtBox
        '
        Me.revisit_txtBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.revisit_txtBox.Location = New System.Drawing.Point(111, 29)
        Me.revisit_txtBox.MaxLength = 1
        Me.revisit_txtBox.Name = "revisit_txtBox"
        Me.revisit_txtBox.Size = New System.Drawing.Size(782, 20)
        Me.revisit_txtBox.TabIndex = 3
        '
        'revisit_lbl
        '
        Me.revisit_lbl.AutoSize = True
        Me.revisit_lbl.Location = New System.Drawing.Point(8, 32)
        Me.revisit_lbl.Name = "revisit_lbl"
        Me.revisit_lbl.Size = New System.Drawing.Size(97, 13)
        Me.revisit_lbl.TabIndex = 2
        Me.revisit_lbl.Text = "Revisit After (Days)"
        '
        'keywords_txtBox
        '
        Me.keywords_txtBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.keywords_txtBox.Location = New System.Drawing.Point(67, 55)
        Me.keywords_txtBox.Name = "keywords_txtBox"
        Me.keywords_txtBox.Size = New System.Drawing.Size(826, 20)
        Me.keywords_txtBox.TabIndex = 5
        '
        'keywords_lbl
        '
        Me.keywords_lbl.AutoSize = True
        Me.keywords_lbl.Location = New System.Drawing.Point(8, 58)
        Me.keywords_lbl.Name = "keywords_lbl"
        Me.keywords_lbl.Size = New System.Drawing.Size(53, 13)
        Me.keywords_lbl.TabIndex = 4
        Me.keywords_lbl.Text = "Keywords"
        '
        'title_txtBox
        '
        Me.title_txtBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.title_txtBox.Location = New System.Drawing.Point(41, 107)
        Me.title_txtBox.Name = "title_txtBox"
        Me.title_txtBox.Size = New System.Drawing.Size(852, 20)
        Me.title_txtBox.TabIndex = 7
        '
        'title_lbl
        '
        Me.title_lbl.AutoSize = True
        Me.title_lbl.Location = New System.Drawing.Point(8, 110)
        Me.title_lbl.Name = "title_lbl"
        Me.title_lbl.Size = New System.Drawing.Size(27, 13)
        Me.title_lbl.TabIndex = 6
        Me.title_lbl.Text = "Title"
        '
        'description_txtBox
        '
        Me.description_txtBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.description_txtBox.Location = New System.Drawing.Point(74, 81)
        Me.description_txtBox.Name = "description_txtBox"
        Me.description_txtBox.Size = New System.Drawing.Size(819, 20)
        Me.description_txtBox.TabIndex = 9
        '
        'description_lbl
        '
        Me.description_lbl.AutoSize = True
        Me.description_lbl.Location = New System.Drawing.Point(8, 84)
        Me.description_lbl.Name = "description_lbl"
        Me.description_lbl.Size = New System.Drawing.Size(60, 13)
        Me.description_lbl.TabIndex = 8
        Me.description_lbl.Text = "Description"
        '
        'EasyHTML
        '
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(909, 626)
        Me.Controls.Add(Me.Pgs_Main)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EasyHTML"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EasyHTML"
        Me.Pgs_Main.ResumeLayout(False)
        Me.Pg_Main.ResumeLayout(False)
        Me.Pg_Main.PerformLayout()
        Me.mainEditor_grp.ResumeLayout(False)
        Me.misc_grp.ResumeLayout(False)
        Me.misc_grp.PerformLayout()
        Me.jsImport_grp.ResumeLayout(False)
        Me.cssImport_grp.ResumeLayout(False)
        Me.Pg_Export.ResumeLayout(False)
        Me.Pg_Preview.ResumeLayout(False)
        Me.Pg_Preview.PerformLayout()
        Me.Test_Page.ResumeLayout(False)
        Me.MainEditorContextMenu.ResumeLayout(False)
        Me.JSContextMenu.ResumeLayout(False)
        Me.CSSContextMenu.ResumeLayout(False)
        Me.Pg_Meta.ResumeLayout(False)
        Me.Pg_Meta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pgs_Main As TabControl
    Friend WithEvents Pg_Main As TabPage
    Friend WithEvents Pg_Export As TabPage
    Friend WithEvents Btn_Export As Button
    Friend WithEvents Code_Export_Code_Box As RichTextBox
    Friend WithEvents Pg_Preview As TabPage
    Friend WithEvents Test_Page As TabPage
    Friend WithEvents Button1 As Button
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
    Friend WithEvents Pg_Help As TabPage
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
End Class
