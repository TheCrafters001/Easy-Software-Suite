<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainEditor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainEditor))
        Me.Pgs_Main = New System.Windows.Forms.TabControl()
        Me.Pg_Main = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_Tip1 = New System.Windows.Forms.Label()
        Me.loadEditorProj_btn = New System.Windows.Forms.Button()
        Me.loadJsLibs_btn = New System.Windows.Forms.Button()
        Me.loadCssLibs_btn = New System.Windows.Forms.Button()
        Me.newProject_btn = New System.Windows.Forms.Button()
        Me.mainEditor_grp = New System.Windows.Forms.GroupBox()
        Me.CodeEditorBox = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.misc_grp = New System.Windows.Forms.GroupBox()
        Me.internetExplorerCompatability_chk = New System.Windows.Forms.CheckBox()
        Me.metatags_chkbox = New System.Windows.Forms.CheckBox()
        Me.UTF8_Set_chkbox = New System.Windows.Forms.CheckBox()
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
        Me.preview_Python = New System.Windows.Forms.GroupBox()
        Me.previewNew_grp = New System.Windows.Forms.GroupBox()
        Me.preview_btn = New System.Windows.Forms.Button()
        Me.BrowserListing_cmb = New System.Windows.Forms.ComboBox()
        Me.previewBrowser_lbl = New System.Windows.Forms.Label()
        Me.preview_lbl = New System.Windows.Forms.Label()
        Me.Pg_About = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.gnuGpl_pic = New System.Windows.Forms.PictureBox()
        Me.copyright_lbl = New System.Windows.Forms.Label()
        Me.version_lbl = New System.Windows.Forms.Label()
        Me.aboutText_lbl = New System.Windows.Forms.Label()
        Me.aboutTitle_lbl = New System.Windows.Forms.Label()
        Me.aboutImg_pic = New System.Windows.Forms.PictureBox()
        Me.Pgs_Main.SuspendLayout()
        Me.Pg_Main.SuspendLayout()
        Me.mainEditor_grp.SuspendLayout()
        CType(Me.CodeEditorBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.misc_grp.SuspendLayout()
        Me.jsImport_grp.SuspendLayout()
        Me.cssImport_grp.SuspendLayout()
        Me.Pg_Export.SuspendLayout()
        Me.Pg_Preview.SuspendLayout()
        Me.previewNew_grp.SuspendLayout()
        Me.Pg_About.SuspendLayout()
        CType(Me.gnuGpl_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.aboutImg_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pgs_Main
        '
        Me.Pgs_Main.Controls.Add(Me.Pg_Main)
        Me.Pgs_Main.Controls.Add(Me.Pg_Export)
        Me.Pgs_Main.Controls.Add(Me.Pg_Preview)
        Me.Pgs_Main.Controls.Add(Me.Pg_About)
        Me.Pgs_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pgs_Main.Location = New System.Drawing.Point(0, 0)
        Me.Pgs_Main.Name = "Pgs_Main"
        Me.Pgs_Main.SelectedIndex = 0
        Me.Pgs_Main.Size = New System.Drawing.Size(952, 626)
        Me.Pgs_Main.TabIndex = 1
        '
        'Pg_Main
        '
        Me.Pg_Main.BackColor = System.Drawing.Color.Gray
        Me.Pg_Main.Controls.Add(Me.Button1)
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
        Me.Pg_Main.Size = New System.Drawing.Size(944, 600)
        Me.Pg_Main.TabIndex = 0
        Me.Pg_Main.Text = "Main Details"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(8, 562)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(208, 30)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Back to Launcher"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl_Tip1
        '
        Me.lbl_Tip1.Location = New System.Drawing.Point(628, 119)
        Me.lbl_Tip1.Name = "lbl_Tip1"
        Me.lbl_Tip1.Size = New System.Drawing.Size(156, 37)
        Me.lbl_Tip1.TabIndex = 14
        Me.lbl_Tip1.Text = "Right click on an editor to save that specific part"
        '
        'loadEditorProj_btn
        '
        Me.loadEditorProj_btn.ForeColor = System.Drawing.Color.Black
        Me.loadEditorProj_btn.Location = New System.Drawing.Point(634, 93)
        Me.loadEditorProj_btn.Name = "loadEditorProj_btn"
        Me.loadEditorProj_btn.Size = New System.Drawing.Size(150, 23)
        Me.loadEditorProj_btn.TabIndex = 13
        Me.loadEditorProj_btn.Text = "Load Editor Project"
        Me.loadEditorProj_btn.UseVisualStyleBackColor = True
        '
        'loadJsLibs_btn
        '
        Me.loadJsLibs_btn.ForeColor = System.Drawing.Color.Black
        Me.loadJsLibs_btn.Location = New System.Drawing.Point(634, 64)
        Me.loadJsLibs_btn.Name = "loadJsLibs_btn"
        Me.loadJsLibs_btn.Size = New System.Drawing.Size(150, 23)
        Me.loadJsLibs_btn.TabIndex = 12
        Me.loadJsLibs_btn.Text = "Load JS Libraries"
        Me.loadJsLibs_btn.UseVisualStyleBackColor = True
        '
        'loadCssLibs_btn
        '
        Me.loadCssLibs_btn.ForeColor = System.Drawing.Color.Black
        Me.loadCssLibs_btn.Location = New System.Drawing.Point(634, 35)
        Me.loadCssLibs_btn.Name = "loadCssLibs_btn"
        Me.loadCssLibs_btn.Size = New System.Drawing.Size(150, 23)
        Me.loadCssLibs_btn.TabIndex = 11
        Me.loadCssLibs_btn.Text = "Load CSS Libraries"
        Me.loadCssLibs_btn.UseVisualStyleBackColor = True
        '
        'newProject_btn
        '
        Me.newProject_btn.ForeColor = System.Drawing.Color.Black
        Me.newProject_btn.Location = New System.Drawing.Point(634, 6)
        Me.newProject_btn.Name = "newProject_btn"
        Me.newProject_btn.Size = New System.Drawing.Size(150, 23)
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
        Me.mainEditor_grp.Size = New System.Drawing.Size(562, 430)
        Me.mainEditor_grp.TabIndex = 9
        Me.mainEditor_grp.TabStop = False
        Me.mainEditor_grp.Text = "Body Editor"
        '
        'CodeEditorBox
        '
        Me.CodeEditorBox.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.CodeEditorBox.AutoIndentCharsPatterns = "^\s*[\w\.]+(\s\w+)?\s*(?<range>=)\s*(?<range>[^;=]+);" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "^\s*(case|default)\s*[^:]*" &
    "(?<range>:)\s*(?<range>[^;]+);"
        Me.CodeEditorBox.AutoScrollMinSize = New System.Drawing.Size(27, 14)
        Me.CodeEditorBox.BackBrush = Nothing
        Me.CodeEditorBox.CharHeight = 14
        Me.CodeEditorBox.CharWidth = 8
        Me.CodeEditorBox.CurrentPenSize = 3
        Me.CodeEditorBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CodeEditorBox.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.CodeEditorBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CodeEditorBox.DocumentPath = Nothing
        Me.CodeEditorBox.ForeColor = System.Drawing.Color.Black
        Me.CodeEditorBox.IsReplaceMode = False
        Me.CodeEditorBox.Location = New System.Drawing.Point(3, 16)
        Me.CodeEditorBox.Name = "CodeEditorBox"
        Me.CodeEditorBox.Paddings = New System.Windows.Forms.Padding(0)
        Me.CodeEditorBox.SelectionChangedDelayedEnabled = False
        Me.CodeEditorBox.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CodeEditorBox.ServiceColors = CType(resources.GetObject("CodeEditorBox.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.CodeEditorBox.Size = New System.Drawing.Size(556, 411)
        Me.CodeEditorBox.TabIndex = 0
        Me.CodeEditorBox.Zoom = 100
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
        Me.internetExplorerCompatability_chk.Size = New System.Drawing.Size(168, 17)
        Me.internetExplorerCompatability_chk.TabIndex = 4
        Me.internetExplorerCompatability_chk.Text = "Internet Explorer Compatability"
        Me.internetExplorerCompatability_chk.UseVisualStyleBackColor = True
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
        'credit_chkbox
        '
        Me.credit_chkbox.AutoSize = True
        Me.credit_chkbox.Location = New System.Drawing.Point(6, 111)
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
        Me.pageTitle_lbl.Size = New System.Drawing.Size(75, 13)
        Me.pageTitle_lbl.TabIndex = 3
        Me.pageTitle_lbl.Text = "Product Name"
        '
        'pageTitle_txtBox
        '
        Me.pageTitle_txtBox.Location = New System.Drawing.Point(6, 22)
        Me.pageTitle_txtBox.MaxLength = 64
        Me.pageTitle_txtBox.Name = "pageTitle_txtBox"
        Me.pageTitle_txtBox.Size = New System.Drawing.Size(210, 20)
        Me.pageTitle_txtBox.TabIndex = 2
        Me.pageTitle_txtBox.Text = "Cool Product"
        '
        'Component_Box
        '
        Me.Component_Box.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Component_Box.FormattingEnabled = True
        Me.Component_Box.Items.AddRange(New Object() {"<!-- Comment -->", "<a href=""""></a>", "<abbr></abbr>", "<address></address>", "<area>", "<article></article>", "<aside></aside>", "<audio></audio>", "<b></b>", "<base>", "<bdi></bdi>", "<bdo></bdo>", "<blockquote></blockquote>", "<body></body>", "<br>", "<button></button>", "<canvas></canvas>", "<caption></caption>", "<cite></cite>", "<code></code>", "<col>", "<colgroup></colgroup>", "<command></command>", "<datalist>", "<dd></dd>", "<del></del>", "<details></details>", "<dfn></dfn>", "<div class=""""></div>", "<dl></dl>", "<dt></dt>", "<em></em>", "<embed></datalist>", "<fieldset></fieldset>", "<figcaption></figcaption>", "<figure></figure>", "<footer></footer>", "<form></form>", "<h1></h1>", "<h2></h2>", "<h3></h3>", "<h4></h4>", "<h5></h5>", "<h6></h6>", "<head></head>", "<header></header>", "<hgroup></hgroup>", "<hr>", "<html></html>", "<i></i>", "<iframe src=""""></iframe>", "<img>", "<input>", "<ins></ins>", "<kbd></kbd>", "<label></label>", "<legend></legend>", "<li></li>", "<link>", "<map></map>", "<mark></mark>", "<menu></menu>", "<meta>", "<meter></meter>", "<nav></nav>", "<noscript></noscript>", "<object></object>", "<ol></ol>", "<optgroup></optgroup>", "<option></option>", "<output></output>", "<p></p>", "<param>", "<pre></pre>", "<progress></progress>", "<q></q>", "<rp></rp>", "<rt></rt>", "<ruby></ruby>", "<s></s>", "<samp></samp>", "<script></script>", "<section></section>", "<select></select>", "<small></small>", "<source>", "<span></span>", "<strong></strong>", "<style></style>", "<sub></sub>", "<summary></summary>", "<sup></sup>", "<table></table>", "<tbody></tbody>", "<td></td>", "<textarea></textarea>", "<tfoot></tfoot>", "<th></th>", "<thead></thead>", "<time></time>", "<title></title>", "<tr></tr>", "<track>", "<u></u>", "<ul></ul>", "<var></var>", "<video></video>", "<wbr>"})
        Me.Component_Box.Location = New System.Drawing.Point(790, 6)
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
        'preview_Python
        '
        Me.preview_Python.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.preview_Python.Enabled = False
        Me.preview_Python.Location = New System.Drawing.Point(8, 143)
        Me.preview_Python.Name = "preview_Python"
        Me.preview_Python.Size = New System.Drawing.Size(928, 101)
        Me.preview_Python.TabIndex = 3
        Me.preview_Python.TabStop = False
        Me.preview_Python.Text = "Python Preview Settings (Coming Soon)"
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
        Me.previewBrowser_lbl.Size = New System.Drawing.Size(172, 13)
        Me.previewBrowser_lbl.TabIndex = 0
        Me.previewBrowser_lbl.Text = "Browser (Currently, IE isn't working)"
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
        Me.Pg_About.Size = New System.Drawing.Size(944, 600)
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
        Me.aboutImg_pic.Location = New System.Drawing.Point(8, 6)
        Me.aboutImg_pic.Name = "aboutImg_pic"
        Me.aboutImg_pic.Size = New System.Drawing.Size(150, 588)
        Me.aboutImg_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.aboutImg_pic.TabIndex = 0
        Me.aboutImg_pic.TabStop = False
        '
        'MainEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 626)
        Me.Controls.Add(Me.Pgs_Main)
        Me.MinimumSize = New System.Drawing.Size(968, 665)
        Me.Name = "MainEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Pgs_Main.ResumeLayout(False)
        Me.Pg_Main.ResumeLayout(False)
        Me.Pg_Main.PerformLayout()
        Me.mainEditor_grp.ResumeLayout(False)
        CType(Me.CodeEditorBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.misc_grp.ResumeLayout(False)
        Me.misc_grp.PerformLayout()
        Me.jsImport_grp.ResumeLayout(False)
        Me.cssImport_grp.ResumeLayout(False)
        Me.Pg_Export.ResumeLayout(False)
        Me.Pg_Preview.ResumeLayout(False)
        Me.Pg_Preview.PerformLayout()
        Me.previewNew_grp.ResumeLayout(False)
        Me.previewNew_grp.PerformLayout()
        Me.Pg_About.ResumeLayout(False)
        Me.Pg_About.PerformLayout()
        CType(Me.gnuGpl_pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.aboutImg_pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pgs_Main As TabControl
    Friend WithEvents Pg_Main As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents lbl_Tip1 As Label
    Friend WithEvents loadEditorProj_btn As Button
    Friend WithEvents loadJsLibs_btn As Button
    Friend WithEvents loadCssLibs_btn As Button
    Friend WithEvents newProject_btn As Button
    Friend WithEvents mainEditor_grp As GroupBox
    Friend WithEvents CodeEditorBox As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents misc_grp As GroupBox
    Friend WithEvents internetExplorerCompatability_chk As CheckBox
    Friend WithEvents metatags_chkbox As CheckBox
    Friend WithEvents UTF8_Set_chkbox As CheckBox
    Friend WithEvents credit_chkbox As CheckBox
    Friend WithEvents mobileViewport_chkbox As CheckBox
    Friend WithEvents jsImport_grp As GroupBox
    Friend WithEvents jsImport_lst As ListBox
    Friend WithEvents jsImport_btn As Button
    Friend WithEvents cssImport_grp As GroupBox
    Friend WithEvents cssImport_lst As ListBox
    Friend WithEvents cssImport_btn As Button
    Friend WithEvents pageTitle_lbl As Label
    Friend WithEvents pageTitle_txtBox As TextBox
    Friend WithEvents Component_Box As ListBox
    Friend WithEvents HTMLEditorError As TextBox
    Friend WithEvents Pg_Export As TabPage
    Friend WithEvents Btn_Export As Button
    Friend WithEvents Code_Export_Code_Box As RichTextBox
    Friend WithEvents Pg_Preview As TabPage
    Friend WithEvents preview_Python As GroupBox
    Friend WithEvents previewNew_grp As GroupBox
    Friend WithEvents preview_btn As Button
    Friend WithEvents BrowserListing_cmb As ComboBox
    Friend WithEvents previewBrowser_lbl As Label
    Friend WithEvents preview_lbl As Label
    Friend WithEvents Pg_About As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents gnuGpl_pic As PictureBox
    Friend WithEvents copyright_lbl As Label
    Friend WithEvents version_lbl As Label
    Friend WithEvents aboutText_lbl As Label
    Friend WithEvents aboutTitle_lbl As Label
    Friend WithEvents aboutImg_pic As PictureBox
End Class
