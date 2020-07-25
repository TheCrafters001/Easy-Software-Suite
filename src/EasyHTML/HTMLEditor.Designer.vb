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
        Me.Pgs_Main = New System.Windows.Forms.TabControl()
        Me.MainPageDetails = New System.Windows.Forms.TabPage()
        Me.mainEditor_grp = New System.Windows.Forms.GroupBox()
        Me.CodeEditorBox = New System.Windows.Forms.RichTextBox()
        Me.misc_grp = New System.Windows.Forms.GroupBox()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Test_Page = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Pgs_Main.SuspendLayout()
        Me.MainPageDetails.SuspendLayout()
        Me.mainEditor_grp.SuspendLayout()
        Me.misc_grp.SuspendLayout()
        Me.jsImport_grp.SuspendLayout()
        Me.cssImport_grp.SuspendLayout()
        Me.Pg_Export.SuspendLayout()
        Me.Pg_Preview.SuspendLayout()
        Me.Test_Page.SuspendLayout()
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
        Me.MainPageDetails.Controls.Add(Me.mainEditor_grp)
        Me.MainPageDetails.Controls.Add(Me.misc_grp)
        Me.MainPageDetails.Controls.Add(Me.jsImport_grp)
        Me.MainPageDetails.Controls.Add(Me.cssImport_grp)
        Me.MainPageDetails.Controls.Add(Me.pageTitle_lbl)
        Me.MainPageDetails.Controls.Add(Me.pageTitle_txtBox)
        Me.MainPageDetails.Controls.Add(Me.Component_Box)
        Me.MainPageDetails.Controls.Add(Me.HTMLEditorError)
        Me.MainPageDetails.Location = New System.Drawing.Point(4, 22)
        Me.MainPageDetails.Name = "MainPageDetails"
        Me.MainPageDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.MainPageDetails.Size = New System.Drawing.Size(901, 600)
        Me.MainPageDetails.TabIndex = 0
        Me.MainPageDetails.Text = "Main Details"
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
        Me.CodeEditorBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CodeEditorBox.Location = New System.Drawing.Point(3, 16)
        Me.CodeEditorBox.Name = "CodeEditorBox"
        Me.CodeEditorBox.Size = New System.Drawing.Size(732, 411)
        Me.CodeEditorBox.TabIndex = 0
        Me.CodeEditorBox.Text = ""
        '
        'misc_grp
        '
        Me.misc_grp.Controls.Add(Me.mobileViewport_chkbox)
        Me.misc_grp.Location = New System.Drawing.Point(8, 48)
        Me.misc_grp.Name = "misc_grp"
        Me.misc_grp.Size = New System.Drawing.Size(208, 108)
        Me.misc_grp.TabIndex = 8
        Me.misc_grp.TabStop = False
        Me.misc_grp.Text = "Misc Items"
        '
        'mobileViewport_chkbox
        '
        Me.mobileViewport_chkbox.AutoSize = True
        Me.mobileViewport_chkbox.Location = New System.Drawing.Point(6, 19)
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
        Me.jsImport_lst.Items.AddRange(New Object() {"js/script.js"})
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
        Me.cssImport_lst.Items.AddRange(New Object() {"css/style.css"})
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
        Me.Pg_Preview.Controls.Add(Me.Label1)
        Me.Pg_Preview.Controls.Add(Me.Button2)
        Me.Pg_Preview.Controls.Add(Me.WebBrowser1)
        Me.Pg_Preview.Location = New System.Drawing.Point(4, 22)
        Me.Pg_Preview.Name = "Pg_Preview"
        Me.Pg_Preview.Size = New System.Drawing.Size(901, 600)
        Me.Pg_Preview.TabIndex = 3
        Me.Pg_Preview.Text = "Preview"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 582)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(382, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Preview may not be exactly what really displays, as the browser this uses is bad." &
    ""
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(796, 575)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Update Preview"
        Me.Button2.UseVisualStyleBackColor = True
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
        Me.MainPageDetails.ResumeLayout(False)
        Me.MainPageDetails.PerformLayout()
        Me.mainEditor_grp.ResumeLayout(False)
        Me.misc_grp.ResumeLayout(False)
        Me.misc_grp.PerformLayout()
        Me.jsImport_grp.ResumeLayout(False)
        Me.cssImport_grp.ResumeLayout(False)
        Me.Pg_Export.ResumeLayout(False)
        Me.Pg_Preview.ResumeLayout(False)
        Me.Pg_Preview.PerformLayout()
        Me.Test_Page.ResumeLayout(False)
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
    Friend WithEvents HTMLEditorError As TextBox
    Friend WithEvents Component_Box As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
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
End Class
