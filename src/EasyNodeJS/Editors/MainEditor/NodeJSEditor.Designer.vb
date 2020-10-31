<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EasyNodeJS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EasyNodeJS))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Pg_Main = New System.Windows.Forms.TabPage()
        Me.lvFiles = New System.Windows.Forms.ListView()
        Me.trvFolders = New System.Windows.Forms.TreeView()
        Me.Pg_About = New System.Windows.Forms.TabPage()
        Me.updateCheck_btn = New System.Windows.Forms.Button()
        Me.gnuGpl_pic = New System.Windows.Forms.PictureBox()
        Me.copyright_lbl = New System.Windows.Forms.Label()
        Me.version_lbl = New System.Windows.Forms.Label()
        Me.aboutText_lbl = New System.Windows.Forms.Label()
        Me.aboutTitle_lbl = New System.Windows.Forms.Label()
        Me.aboutImg_pic = New System.Windows.Forms.PictureBox()
        Me.Pg_Log = New System.Windows.Forms.TabPage()
        Me.iIconList = New System.Windows.Forms.ImageList(Me.components)
        Me.cmClipboardOp = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Log = New System.Windows.Forms.RichTextBox()
        Me.folderManagment_grp = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Pg_Commands = New System.Windows.Forms.TabPage()
        Me.editorCodeBox_rchtxt = New System.Windows.Forms.RichTextBox()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.run_btn = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.Pg_Main.SuspendLayout()
        Me.Pg_About.SuspendLayout()
        CType(Me.gnuGpl_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.aboutImg_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pg_Log.SuspendLayout()
        Me.cmClipboardOp.SuspendLayout()
        Me.folderManagment_grp.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Pg_Main)
        Me.TabControl1.Controls.Add(Me.Pg_Commands)
        Me.TabControl1.Controls.Add(Me.Pg_About)
        Me.TabControl1.Controls.Add(Me.Pg_Log)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(909, 626)
        Me.TabControl1.TabIndex = 0
        '
        'Pg_Main
        '
        Me.Pg_Main.BackColor = System.Drawing.Color.Gray
        Me.Pg_Main.Controls.Add(Me.GroupBox1)
        Me.Pg_Main.Controls.Add(Me.folderManagment_grp)
        Me.Pg_Main.Location = New System.Drawing.Point(4, 22)
        Me.Pg_Main.Name = "Pg_Main"
        Me.Pg_Main.Padding = New System.Windows.Forms.Padding(3)
        Me.Pg_Main.Size = New System.Drawing.Size(901, 600)
        Me.Pg_Main.TabIndex = 0
        Me.Pg_Main.Text = "Main Details"
        '
        'lvFiles
        '
        Me.lvFiles.HideSelection = False
        Me.lvFiles.Location = New System.Drawing.Point(6, 332)
        Me.lvFiles.Name = "lvFiles"
        Me.lvFiles.Size = New System.Drawing.Size(219, 248)
        Me.lvFiles.TabIndex = 6
        Me.lvFiles.UseCompatibleStateImageBehavior = False
        '
        'trvFolders
        '
        Me.trvFolders.Location = New System.Drawing.Point(6, 21)
        Me.trvFolders.Name = "trvFolders"
        Me.trvFolders.Size = New System.Drawing.Size(219, 305)
        Me.trvFolders.TabIndex = 5
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
        Me.Pg_About.TabIndex = 1
        Me.Pg_About.Text = "About"
        '
        'updateCheck_btn
        '
        Me.updateCheck_btn.ForeColor = System.Drawing.Color.Black
        Me.updateCheck_btn.Location = New System.Drawing.Point(8, 384)
        Me.updateCheck_btn.Name = "updateCheck_btn"
        Me.updateCheck_btn.Size = New System.Drawing.Size(111, 23)
        Me.updateCheck_btn.TabIndex = 13
        Me.updateCheck_btn.Text = "Check for Updates"
        Me.updateCheck_btn.UseVisualStyleBackColor = True
        '
        'gnuGpl_pic
        '
        Me.gnuGpl_pic.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gnuGpl_pic.BackgroundImage = Global.EasyNodeJS.My.Resources.Resources.GNUGPL3
        Me.gnuGpl_pic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gnuGpl_pic.Location = New System.Drawing.Point(756, 524)
        Me.gnuGpl_pic.Name = "gnuGpl_pic"
        Me.gnuGpl_pic.Size = New System.Drawing.Size(136, 68)
        Me.gnuGpl_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.gnuGpl_pic.TabIndex = 12
        Me.gnuGpl_pic.TabStop = False
        '
        'copyright_lbl
        '
        Me.copyright_lbl.AutoSize = True
        Me.copyright_lbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.copyright_lbl.Location = New System.Drawing.Point(8, 360)
        Me.copyright_lbl.Name = "copyright_lbl"
        Me.copyright_lbl.Size = New System.Drawing.Size(108, 21)
        Me.copyright_lbl.TabIndex = 11
        Me.copyright_lbl.Text = "Copyright LBL"
        '
        'version_lbl
        '
        Me.version_lbl.AutoSize = True
        Me.version_lbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.version_lbl.Location = New System.Drawing.Point(8, 339)
        Me.version_lbl.Name = "version_lbl"
        Me.version_lbl.Size = New System.Drawing.Size(114, 21)
        Me.version_lbl.TabIndex = 10
        Me.version_lbl.Text = "Version: X.X.X.X"
        '
        'aboutText_lbl
        '
        Me.aboutText_lbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.aboutText_lbl.Location = New System.Drawing.Point(12, 271)
        Me.aboutText_lbl.Name = "aboutText_lbl"
        Me.aboutText_lbl.Size = New System.Drawing.Size(880, 68)
        Me.aboutText_lbl.TabIndex = 9
        Me.aboutText_lbl.Text = resources.GetString("aboutText_lbl.Text")
        '
        'aboutTitle_lbl
        '
        Me.aboutTitle_lbl.AutoSize = True
        Me.aboutTitle_lbl.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aboutTitle_lbl.Location = New System.Drawing.Point(8, 231)
        Me.aboutTitle_lbl.Name = "aboutTitle_lbl"
        Me.aboutTitle_lbl.Size = New System.Drawing.Size(181, 40)
        Me.aboutTitle_lbl.TabIndex = 8
        Me.aboutTitle_lbl.Text = "EasyNodeJS"
        '
        'aboutImg_pic
        '
        Me.aboutImg_pic.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.aboutImg_pic.Image = Global.EasyNodeJS.My.Resources.Resources.Header
        Me.aboutImg_pic.Location = New System.Drawing.Point(8, 6)
        Me.aboutImg_pic.Name = "aboutImg_pic"
        Me.aboutImg_pic.Size = New System.Drawing.Size(887, 222)
        Me.aboutImg_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.aboutImg_pic.TabIndex = 7
        Me.aboutImg_pic.TabStop = False
        '
        'Pg_Log
        '
        Me.Pg_Log.BackColor = System.Drawing.Color.Gray
        Me.Pg_Log.Controls.Add(Me.Log)
        Me.Pg_Log.Location = New System.Drawing.Point(4, 22)
        Me.Pg_Log.Name = "Pg_Log"
        Me.Pg_Log.Size = New System.Drawing.Size(901, 600)
        Me.Pg_Log.TabIndex = 2
        Me.Pg_Log.Text = "Log"
        '
        'iIconList
        '
        Me.iIconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.iIconList.ImageSize = New System.Drawing.Size(16, 16)
        Me.iIconList.TransparentColor = System.Drawing.Color.Transparent
        '
        'cmClipboardOp
        '
        Me.cmClipboardOp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem})
        Me.cmClipboardOp.Name = "cmClipboardOp"
        Me.cmClipboardOp.Size = New System.Drawing.Size(103, 48)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'Log
        '
        Me.Log.Location = New System.Drawing.Point(8, 6)
        Me.Log.Name = "Log"
        Me.Log.ReadOnly = True
        Me.Log.Size = New System.Drawing.Size(885, 589)
        Me.Log.TabIndex = 1
        Me.Log.Text = ""
        '
        'folderManagment_grp
        '
        Me.folderManagment_grp.Controls.Add(Me.trvFolders)
        Me.folderManagment_grp.Controls.Add(Me.lvFiles)
        Me.folderManagment_grp.Location = New System.Drawing.Point(8, 6)
        Me.folderManagment_grp.Name = "folderManagment_grp"
        Me.folderManagment_grp.Size = New System.Drawing.Size(237, 586)
        Me.folderManagment_grp.TabIndex = 7
        Me.folderManagment_grp.TabStop = False
        Me.folderManagment_grp.Text = "Folder Managment"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.run_btn)
        Me.GroupBox1.Controls.Add(Me.save_btn)
        Me.GroupBox1.Controls.Add(Me.editorCodeBox_rchtxt)
        Me.GroupBox1.Location = New System.Drawing.Point(251, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(642, 586)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Editor"
        '
        'Pg_Commands
        '
        Me.Pg_Commands.Location = New System.Drawing.Point(4, 22)
        Me.Pg_Commands.Name = "Pg_Commands"
        Me.Pg_Commands.Size = New System.Drawing.Size(901, 600)
        Me.Pg_Commands.TabIndex = 3
        Me.Pg_Commands.Text = "Commands"
        Me.Pg_Commands.UseVisualStyleBackColor = True
        '
        'editorCodeBox_rchtxt
        '
        Me.editorCodeBox_rchtxt.Location = New System.Drawing.Point(6, 21)
        Me.editorCodeBox_rchtxt.Name = "editorCodeBox_rchtxt"
        Me.editorCodeBox_rchtxt.Size = New System.Drawing.Size(630, 530)
        Me.editorCodeBox_rchtxt.TabIndex = 0
        Me.editorCodeBox_rchtxt.Text = ""
        '
        'save_btn
        '
        Me.save_btn.Location = New System.Drawing.Point(561, 557)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(75, 23)
        Me.save_btn.TabIndex = 1
        Me.save_btn.Text = "Save"
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'run_btn
        '
        Me.run_btn.Location = New System.Drawing.Point(6, 557)
        Me.run_btn.Name = "run_btn"
        Me.run_btn.Size = New System.Drawing.Size(75, 23)
        Me.run_btn.TabIndex = 2
        Me.run_btn.Text = "Run App"
        Me.run_btn.UseVisualStyleBackColor = True
        '
        'EasyNodeJS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(909, 626)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EasyNodeJS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EasyNodeJS"
        Me.TabControl1.ResumeLayout(False)
        Me.Pg_Main.ResumeLayout(False)
        Me.Pg_About.ResumeLayout(False)
        Me.Pg_About.PerformLayout()
        CType(Me.gnuGpl_pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.aboutImg_pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pg_Log.ResumeLayout(False)
        Me.cmClipboardOp.ResumeLayout(False)
        Me.folderManagment_grp.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Pg_Main As TabPage
    Friend WithEvents Pg_About As TabPage
    Friend WithEvents Pg_Log As TabPage
    Friend WithEvents updateCheck_btn As Button
    Friend WithEvents gnuGpl_pic As PictureBox
    Friend WithEvents copyright_lbl As Label
    Friend WithEvents version_lbl As Label
    Friend WithEvents aboutText_lbl As Label
    Friend WithEvents aboutTitle_lbl As Label
    Friend WithEvents aboutImg_pic As PictureBox
    Friend WithEvents lvFiles As ListView
    Friend WithEvents trvFolders As TreeView
    Friend WithEvents iIconList As ImageList
    Friend WithEvents cmClipboardOp As ContextMenuStrip
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Log As RichTextBox
    Friend WithEvents folderManagment_grp As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Pg_Commands As TabPage
    Friend WithEvents editorCodeBox_rchtxt As RichTextBox
    Friend WithEvents save_btn As Button
    Friend WithEvents run_btn As Button
End Class
