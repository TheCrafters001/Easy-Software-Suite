<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.pages = New System.Windows.Forms.TabControl()
        Me.Pg_pullpush = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.folderPull_lbl = New System.Windows.Forms.Label()
        Me.folderPull_txt = New System.Windows.Forms.TextBox()
        Me.folderPull_btn = New System.Windows.Forms.Button()
        Me.pull_btn = New System.Windows.Forms.Button()
        Me.firstTime_LBL = New System.Windows.Forms.LinkLabel()
        Me.pushCommit_grp = New System.Windows.Forms.GroupBox()
        Me.folderCommit_lbl = New System.Windows.Forms.Label()
        Me.folderCommit_txt = New System.Windows.Forms.TextBox()
        Me.folderCommit_btn = New System.Windows.Forms.Button()
        Me.commit_btn = New System.Windows.Forms.Button()
        Me.commitTitle_lbl = New System.Windows.Forms.Label()
        Me.commitMessage_txt = New System.Windows.Forms.TextBox()
        Me.Pg_setuser = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.githubEmail_lbl = New System.Windows.Forms.Label()
        Me.githubEmail_txt = New System.Windows.Forms.TextBox()
        Me.githubUsername_lbl = New System.Windows.Forms.Label()
        Me.githubUsername_txt = New System.Windows.Forms.TextBox()
        Me.note_setuser_lbl = New System.Windows.Forms.Label()
        Me.folderFinder = New System.Windows.Forms.FolderBrowserDialog()
        Me.pages.SuspendLayout()
        Me.Pg_pullpush.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pushCommit_grp.SuspendLayout()
        Me.Pg_setuser.SuspendLayout()
        Me.SuspendLayout()
        '
        'pages
        '
        Me.pages.Controls.Add(Me.Pg_pullpush)
        Me.pages.Controls.Add(Me.Pg_setuser)
        Me.pages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pages.Location = New System.Drawing.Point(0, 0)
        Me.pages.Name = "pages"
        Me.pages.SelectedIndex = 0
        Me.pages.Size = New System.Drawing.Size(534, 191)
        Me.pages.TabIndex = 0
        '
        'Pg_pullpush
        '
        Me.Pg_pullpush.Controls.Add(Me.GroupBox1)
        Me.Pg_pullpush.Controls.Add(Me.firstTime_LBL)
        Me.Pg_pullpush.Controls.Add(Me.pushCommit_grp)
        Me.Pg_pullpush.Location = New System.Drawing.Point(4, 22)
        Me.Pg_pullpush.Name = "Pg_pullpush"
        Me.Pg_pullpush.Padding = New System.Windows.Forms.Padding(3)
        Me.Pg_pullpush.Size = New System.Drawing.Size(526, 165)
        Me.Pg_pullpush.TabIndex = 0
        Me.Pg_pullpush.Text = "Push & Pull"
        Me.Pg_pullpush.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.folderPull_lbl)
        Me.GroupBox1.Controls.Add(Me.folderPull_txt)
        Me.GroupBox1.Controls.Add(Me.folderPull_btn)
        Me.GroupBox1.Controls.Add(Me.pull_btn)
        Me.GroupBox1.Location = New System.Drawing.Point(263, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(249, 121)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pull"
        '
        'folderPull_lbl
        '
        Me.folderPull_lbl.AutoSize = True
        Me.folderPull_lbl.Location = New System.Drawing.Point(6, 18)
        Me.folderPull_lbl.Name = "folderPull_lbl"
        Me.folderPull_lbl.Size = New System.Drawing.Size(40, 13)
        Me.folderPull_lbl.TabIndex = 9
        Me.folderPull_lbl.Text = "Folder"
        '
        'folderPull_txt
        '
        Me.folderPull_txt.Location = New System.Drawing.Point(6, 34)
        Me.folderPull_txt.Name = "folderPull_txt"
        Me.folderPull_txt.Size = New System.Drawing.Size(207, 22)
        Me.folderPull_txt.TabIndex = 8
        '
        'folderPull_btn
        '
        Me.folderPull_btn.Location = New System.Drawing.Point(219, 33)
        Me.folderPull_btn.Name = "folderPull_btn"
        Me.folderPull_btn.Size = New System.Drawing.Size(24, 23)
        Me.folderPull_btn.TabIndex = 7
        Me.folderPull_btn.Text = "..."
        Me.folderPull_btn.UseVisualStyleBackColor = True
        '
        'pull_btn
        '
        Me.pull_btn.Location = New System.Drawing.Point(174, 98)
        Me.pull_btn.Name = "pull_btn"
        Me.pull_btn.Size = New System.Drawing.Size(75, 23)
        Me.pull_btn.TabIndex = 3
        Me.pull_btn.Text = "Pull!"
        Me.pull_btn.UseVisualStyleBackColor = True
        '
        'firstTime_LBL
        '
        Me.firstTime_LBL.AutoSize = True
        Me.firstTime_LBL.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstTime_LBL.Location = New System.Drawing.Point(6, 130)
        Me.firstTime_LBL.Name = "firstTime_LBL"
        Me.firstTime_LBL.Size = New System.Drawing.Size(448, 30)
        Me.firstTime_LBL.TabIndex = 3
        Me.firstTime_LBL.TabStop = True
        Me.firstTime_LBL.Text = "Is this your first time using this app? Click here."
        '
        'pushCommit_grp
        '
        Me.pushCommit_grp.Controls.Add(Me.folderCommit_lbl)
        Me.pushCommit_grp.Controls.Add(Me.folderCommit_txt)
        Me.pushCommit_grp.Controls.Add(Me.folderCommit_btn)
        Me.pushCommit_grp.Controls.Add(Me.commit_btn)
        Me.pushCommit_grp.Controls.Add(Me.commitTitle_lbl)
        Me.pushCommit_grp.Controls.Add(Me.commitMessage_txt)
        Me.pushCommit_grp.Location = New System.Drawing.Point(8, 6)
        Me.pushCommit_grp.Name = "pushCommit_grp"
        Me.pushCommit_grp.Size = New System.Drawing.Size(249, 121)
        Me.pushCommit_grp.TabIndex = 2
        Me.pushCommit_grp.TabStop = False
        Me.pushCommit_grp.Text = "Push"
        '
        'folderCommit_lbl
        '
        Me.folderCommit_lbl.AutoSize = True
        Me.folderCommit_lbl.Location = New System.Drawing.Point(6, 59)
        Me.folderCommit_lbl.Name = "folderCommit_lbl"
        Me.folderCommit_lbl.Size = New System.Drawing.Size(40, 13)
        Me.folderCommit_lbl.TabIndex = 6
        Me.folderCommit_lbl.Text = "Folder"
        '
        'folderCommit_txt
        '
        Me.folderCommit_txt.Location = New System.Drawing.Point(6, 75)
        Me.folderCommit_txt.Name = "folderCommit_txt"
        Me.folderCommit_txt.Size = New System.Drawing.Size(207, 22)
        Me.folderCommit_txt.TabIndex = 5
        '
        'folderCommit_btn
        '
        Me.folderCommit_btn.Location = New System.Drawing.Point(219, 74)
        Me.folderCommit_btn.Name = "folderCommit_btn"
        Me.folderCommit_btn.Size = New System.Drawing.Size(24, 23)
        Me.folderCommit_btn.TabIndex = 4
        Me.folderCommit_btn.Text = "..."
        Me.folderCommit_btn.UseVisualStyleBackColor = True
        '
        'commit_btn
        '
        Me.commit_btn.Location = New System.Drawing.Point(174, 98)
        Me.commit_btn.Name = "commit_btn"
        Me.commit_btn.Size = New System.Drawing.Size(75, 23)
        Me.commit_btn.TabIndex = 3
        Me.commit_btn.Text = "Push!"
        Me.commit_btn.UseVisualStyleBackColor = True
        '
        'commitTitle_lbl
        '
        Me.commitTitle_lbl.AutoSize = True
        Me.commitTitle_lbl.Location = New System.Drawing.Point(6, 18)
        Me.commitTitle_lbl.Name = "commitTitle_lbl"
        Me.commitTitle_lbl.Size = New System.Drawing.Size(94, 13)
        Me.commitTitle_lbl.TabIndex = 1
        Me.commitTitle_lbl.Text = "Commit Message"
        '
        'commitMessage_txt
        '
        Me.commitMessage_txt.Location = New System.Drawing.Point(6, 34)
        Me.commitMessage_txt.Name = "commitMessage_txt"
        Me.commitMessage_txt.Size = New System.Drawing.Size(234, 22)
        Me.commitMessage_txt.TabIndex = 0
        '
        'Pg_setuser
        '
        Me.Pg_setuser.Controls.Add(Me.Button1)
        Me.Pg_setuser.Controls.Add(Me.githubEmail_lbl)
        Me.Pg_setuser.Controls.Add(Me.githubEmail_txt)
        Me.Pg_setuser.Controls.Add(Me.githubUsername_lbl)
        Me.Pg_setuser.Controls.Add(Me.githubUsername_txt)
        Me.Pg_setuser.Controls.Add(Me.note_setuser_lbl)
        Me.Pg_setuser.Location = New System.Drawing.Point(4, 22)
        Me.Pg_setuser.Name = "Pg_setuser"
        Me.Pg_setuser.Padding = New System.Windows.Forms.Padding(3)
        Me.Pg_setuser.Size = New System.Drawing.Size(526, 165)
        Me.Pg_setuser.TabIndex = 1
        Me.Pg_setuser.Text = "Set User"
        Me.Pg_setuser.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(445, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Set user"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'githubEmail_lbl
        '
        Me.githubEmail_lbl.AutoSize = True
        Me.githubEmail_lbl.Location = New System.Drawing.Point(8, 70)
        Me.githubEmail_lbl.Name = "githubEmail_lbl"
        Me.githubEmail_lbl.Size = New System.Drawing.Size(74, 13)
        Me.githubEmail_lbl.TabIndex = 10
        Me.githubEmail_lbl.Text = "GitHub Email"
        '
        'githubEmail_txt
        '
        Me.githubEmail_txt.Location = New System.Drawing.Point(8, 86)
        Me.githubEmail_txt.Name = "githubEmail_txt"
        Me.githubEmail_txt.Size = New System.Drawing.Size(510, 22)
        Me.githubEmail_txt.TabIndex = 9
        '
        'githubUsername_lbl
        '
        Me.githubUsername_lbl.AutoSize = True
        Me.githubUsername_lbl.Location = New System.Drawing.Point(8, 29)
        Me.githubUsername_lbl.Name = "githubUsername_lbl"
        Me.githubUsername_lbl.Size = New System.Drawing.Size(97, 13)
        Me.githubUsername_lbl.TabIndex = 8
        Me.githubUsername_lbl.Text = "GitHub username"
        '
        'githubUsername_txt
        '
        Me.githubUsername_txt.Location = New System.Drawing.Point(8, 45)
        Me.githubUsername_txt.Name = "githubUsername_txt"
        Me.githubUsername_txt.Size = New System.Drawing.Size(510, 22)
        Me.githubUsername_txt.TabIndex = 7
        '
        'note_setuser_lbl
        '
        Me.note_setuser_lbl.AutoSize = True
        Me.note_setuser_lbl.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.note_setuser_lbl.Location = New System.Drawing.Point(8, 3)
        Me.note_setuser_lbl.Name = "note_setuser_lbl"
        Me.note_setuser_lbl.Size = New System.Drawing.Size(270, 13)
        Me.note_setuser_lbl.TabIndex = 0
        Me.note_setuser_lbl.Text = "You will only need to do this one time per machine."
        '
        'folderFinder
        '
        Me.folderFinder.Description = "Please select the folder where your local repo is."
        Me.folderFinder.ShowNewFolderButton = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 191)
        Me.Controls.Add(Me.pages)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(550, 230)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EasyGit"
        Me.pages.ResumeLayout(False)
        Me.Pg_pullpush.ResumeLayout(False)
        Me.Pg_pullpush.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pushCommit_grp.ResumeLayout(False)
        Me.pushCommit_grp.PerformLayout()
        Me.Pg_setuser.ResumeLayout(False)
        Me.Pg_setuser.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pages As TabControl
    Friend WithEvents Pg_pullpush As TabPage
    Friend WithEvents Pg_setuser As TabPage
    Friend WithEvents note_setuser_lbl As Label
    Friend WithEvents commitMessage_txt As TextBox
    Friend WithEvents commitTitle_lbl As Label
    Friend WithEvents pushCommit_grp As GroupBox
    Friend WithEvents commit_btn As Button
    Friend WithEvents firstTime_LBL As LinkLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pull_btn As Button
    Friend WithEvents folderCommit_btn As Button
    Friend WithEvents folderCommit_lbl As Label
    Friend WithEvents folderCommit_txt As TextBox
    Friend WithEvents folderPull_lbl As Label
    Friend WithEvents folderPull_txt As TextBox
    Friend WithEvents folderPull_btn As Button
    Friend WithEvents folderFinder As FolderBrowserDialog
    Friend WithEvents githubEmail_lbl As Label
    Friend WithEvents githubEmail_txt As TextBox
    Friend WithEvents githubUsername_lbl As Label
    Friend WithEvents githubUsername_txt As TextBox
    Friend WithEvents Button1 As Button
End Class
