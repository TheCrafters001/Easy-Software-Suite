<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class launcherNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(launcherNew))
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.applist_grp = New System.Windows.Forms.GroupBox()
        Me.appList_lst = New System.Windows.Forms.ListBox()
        Me.aboutApp_grp = New System.Windows.Forms.GroupBox()
        Me.app_logo_picbox = New System.Windows.Forms.PictureBox()
        Me.app_name_lbl = New System.Windows.Forms.Label()
        Me.app_desc_GrpBox = New System.Windows.Forms.GroupBox()
        Me.App_Launch_Btn = New System.Windows.Forms.Button()
        Me.app_desc_rchtxtBox = New System.Windows.Forms.RichTextBox()
        Me.applist_grp.SuspendLayout()
        Me.aboutApp_grp.SuspendLayout()
        CType(Me.app_logo_picbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.app_desc_GrpBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'LinkLabel2
        '
        Me.LinkLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(12, 439)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(103, 13)
        Me.LinkLabel2.TabIndex = 7
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Third Pary Licenses"
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancel.ForeColor = System.Drawing.Color.Black
        Me.btn_cancel.Location = New System.Drawing.Point(397, 426)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 6
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'applist_grp
        '
        Me.applist_grp.Controls.Add(Me.appList_lst)
        Me.applist_grp.Location = New System.Drawing.Point(12, 12)
        Me.applist_grp.Name = "applist_grp"
        Me.applist_grp.Size = New System.Drawing.Size(180, 424)
        Me.applist_grp.TabIndex = 8
        Me.applist_grp.TabStop = False
        Me.applist_grp.Text = "App List"
        '
        'appList_lst
        '
        Me.appList_lst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.appList_lst.FormattingEnabled = True
        Me.appList_lst.Location = New System.Drawing.Point(3, 18)
        Me.appList_lst.Name = "appList_lst"
        Me.appList_lst.Size = New System.Drawing.Size(174, 403)
        Me.appList_lst.TabIndex = 0
        '
        'aboutApp_grp
        '
        Me.aboutApp_grp.Controls.Add(Me.App_Launch_Btn)
        Me.aboutApp_grp.Controls.Add(Me.app_desc_GrpBox)
        Me.aboutApp_grp.Controls.Add(Me.app_name_lbl)
        Me.aboutApp_grp.Controls.Add(Me.app_logo_picbox)
        Me.aboutApp_grp.Location = New System.Drawing.Point(198, 12)
        Me.aboutApp_grp.Name = "aboutApp_grp"
        Me.aboutApp_grp.Size = New System.Drawing.Size(274, 408)
        Me.aboutApp_grp.TabIndex = 9
        Me.aboutApp_grp.TabStop = False
        Me.aboutApp_grp.Text = "About Selected App"
        '
        'app_logo_picbox
        '
        Me.app_logo_picbox.Image = Global.Easy_Software_Suite_Launcher.My.Resources.Resources.EasySoftwareSuite
        Me.app_logo_picbox.Location = New System.Drawing.Point(6, 16)
        Me.app_logo_picbox.Name = "app_logo_picbox"
        Me.app_logo_picbox.Size = New System.Drawing.Size(87, 84)
        Me.app_logo_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.app_logo_picbox.TabIndex = 0
        Me.app_logo_picbox.TabStop = False
        '
        'app_name_lbl
        '
        Me.app_name_lbl.AutoSize = True
        Me.app_name_lbl.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.app_name_lbl.Location = New System.Drawing.Point(99, 16)
        Me.app_name_lbl.Name = "app_name_lbl"
        Me.app_name_lbl.Size = New System.Drawing.Size(146, 20)
        Me.app_name_lbl.TabIndex = 1
        Me.app_name_lbl.Text = "Easy Software Suite"
        '
        'app_desc_GrpBox
        '
        Me.app_desc_GrpBox.Controls.Add(Me.app_desc_rchtxtBox)
        Me.app_desc_GrpBox.Location = New System.Drawing.Point(6, 106)
        Me.app_desc_GrpBox.Name = "app_desc_GrpBox"
        Me.app_desc_GrpBox.Size = New System.Drawing.Size(262, 267)
        Me.app_desc_GrpBox.TabIndex = 2
        Me.app_desc_GrpBox.TabStop = False
        Me.app_desc_GrpBox.Text = "App Description"
        '
        'App_Launch_Btn
        '
        Me.App_Launch_Btn.Location = New System.Drawing.Point(181, 379)
        Me.App_Launch_Btn.Name = "App_Launch_Btn"
        Me.App_Launch_Btn.Size = New System.Drawing.Size(87, 23)
        Me.App_Launch_Btn.TabIndex = 3
        Me.App_Launch_Btn.Text = "Launch App"
        Me.App_Launch_Btn.UseVisualStyleBackColor = True
        '
        'app_desc_rchtxtBox
        '
        Me.app_desc_rchtxtBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.app_desc_rchtxtBox.Location = New System.Drawing.Point(3, 18)
        Me.app_desc_rchtxtBox.Name = "app_desc_rchtxtBox"
        Me.app_desc_rchtxtBox.ReadOnly = True
        Me.app_desc_rchtxtBox.Size = New System.Drawing.Size(256, 246)
        Me.app_desc_rchtxtBox.TabIndex = 0
        Me.app_desc_rchtxtBox.Text = "Select an app from the list to get started :)"
        '
        'launcherNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.aboutApp_grp)
        Me.Controls.Add(Me.applist_grp)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.btn_cancel)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 500)
        Me.MinimumSize = New System.Drawing.Size(500, 500)
        Me.Name = "launcherNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Easy Software Suite"
        Me.applist_grp.ResumeLayout(False)
        Me.aboutApp_grp.ResumeLayout(False)
        Me.aboutApp_grp.PerformLayout()
        CType(Me.app_logo_picbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.app_desc_GrpBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents btn_cancel As Button
    Friend WithEvents applist_grp As GroupBox
    Friend WithEvents aboutApp_grp As GroupBox
    Friend WithEvents appList_lst As ListBox
    Friend WithEvents app_logo_picbox As PictureBox
    Friend WithEvents app_name_lbl As Label
    Friend WithEvents app_desc_GrpBox As GroupBox
    Friend WithEvents App_Launch_Btn As Button
    Friend WithEvents app_desc_rchtxtBox As RichTextBox
End Class
