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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.applist_grp = New System.Windows.Forms.GroupBox()
        Me.appList_lst = New System.Windows.Forms.ListBox()
        Me.aboutApp_grp = New System.Windows.Forms.GroupBox()
        Me.App_Launch_Btn = New System.Windows.Forms.Button()
        Me.app_desc_GrpBox = New System.Windows.Forms.GroupBox()
        Me.app_desc_rchtxtBox = New System.Windows.Forms.RichTextBox()
        Me.app_name_lbl = New System.Windows.Forms.Label()
        Me.app_logo_picbox = New System.Windows.Forms.PictureBox()
        Me.cancel_btn = New System.Windows.Forms.Button()
        Me.thirdParty_lnklbl = New System.Windows.Forms.LinkLabel()
        Me.applist_grp.SuspendLayout()
        Me.aboutApp_grp.SuspendLayout()
        Me.app_desc_GrpBox.SuspendLayout()
        CType(Me.app_logo_picbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'applist_grp
        '
        Me.applist_grp.Controls.Add(Me.appList_lst)
        Me.applist_grp.Location = New System.Drawing.Point(12, 12)
        Me.applist_grp.Name = "applist_grp"
        Me.applist_grp.Size = New System.Drawing.Size(180, 419)
        Me.applist_grp.TabIndex = 0
        Me.applist_grp.TabStop = False
        Me.applist_grp.Text = "App List"
        '
        'appList_lst
        '
        Me.appList_lst.FormattingEnabled = True
        Me.appList_lst.ItemHeight = 15
        Me.appList_lst.Location = New System.Drawing.Point(6, 22)
        Me.appList_lst.Name = "appList_lst"
        Me.appList_lst.Size = New System.Drawing.Size(168, 394)
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
        Me.aboutApp_grp.TabIndex = 1
        Me.aboutApp_grp.TabStop = False
        Me.aboutApp_grp.Text = "About Selected App"
        '
        'App_Launch_Btn
        '
        Me.App_Launch_Btn.Location = New System.Drawing.Point(183, 379)
        Me.App_Launch_Btn.Name = "App_Launch_Btn"
        Me.App_Launch_Btn.Size = New System.Drawing.Size(85, 23)
        Me.App_Launch_Btn.TabIndex = 3
        Me.App_Launch_Btn.Text = "Launch App"
        Me.App_Launch_Btn.UseVisualStyleBackColor = True
        '
        'app_desc_GrpBox
        '
        Me.app_desc_GrpBox.Controls.Add(Me.app_desc_rchtxtBox)
        Me.app_desc_GrpBox.Location = New System.Drawing.Point(6, 112)
        Me.app_desc_GrpBox.Name = "app_desc_GrpBox"
        Me.app_desc_GrpBox.Size = New System.Drawing.Size(262, 261)
        Me.app_desc_GrpBox.TabIndex = 2
        Me.app_desc_GrpBox.TabStop = False
        Me.app_desc_GrpBox.Text = "App Description"
        '
        'app_desc_rchtxtBox
        '
        Me.app_desc_rchtxtBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.app_desc_rchtxtBox.Location = New System.Drawing.Point(3, 19)
        Me.app_desc_rchtxtBox.Name = "app_desc_rchtxtBox"
        Me.app_desc_rchtxtBox.ReadOnly = True
        Me.app_desc_rchtxtBox.Size = New System.Drawing.Size(256, 239)
        Me.app_desc_rchtxtBox.TabIndex = 0
        Me.app_desc_rchtxtBox.Text = "Select an app from the list to get started :)"
        '
        'app_name_lbl
        '
        Me.app_name_lbl.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.app_name_lbl.Location = New System.Drawing.Point(99, 22)
        Me.app_name_lbl.Name = "app_name_lbl"
        Me.app_name_lbl.Size = New System.Drawing.Size(169, 84)
        Me.app_name_lbl.TabIndex = 1
        Me.app_name_lbl.Text = "Easy Software Suite"
        '
        'app_logo_picbox
        '
        Me.app_logo_picbox.Image = Global.Easy_Software_Suite_Launcher.My.Resources.Resources.EasySoftwareSuite1
        Me.app_logo_picbox.Location = New System.Drawing.Point(6, 22)
        Me.app_logo_picbox.Name = "app_logo_picbox"
        Me.app_logo_picbox.Size = New System.Drawing.Size(87, 84)
        Me.app_logo_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.app_logo_picbox.TabIndex = 0
        Me.app_logo_picbox.TabStop = False
        '
        'cancel_btn
        '
        Me.cancel_btn.Location = New System.Drawing.Point(397, 426)
        Me.cancel_btn.Name = "cancel_btn"
        Me.cancel_btn.Size = New System.Drawing.Size(75, 23)
        Me.cancel_btn.TabIndex = 2
        Me.cancel_btn.Text = "Cancel"
        Me.cancel_btn.UseVisualStyleBackColor = True
        '
        'thirdParty_lnklbl
        '
        Me.thirdParty_lnklbl.AutoSize = True
        Me.thirdParty_lnklbl.Location = New System.Drawing.Point(12, 434)
        Me.thirdParty_lnklbl.Name = "thirdParty_lnklbl"
        Me.thirdParty_lnklbl.Size = New System.Drawing.Size(111, 15)
        Me.thirdParty_lnklbl.TabIndex = 3
        Me.thirdParty_lnklbl.TabStop = True
        Me.thirdParty_lnklbl.Text = "Third Party Licenses"
        '
        'Form1
        '
        Me.AcceptButton = Me.App_Launch_Btn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cancel_btn
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.thirdParty_lnklbl)
        Me.Controls.Add(Me.cancel_btn)
        Me.Controls.Add(Me.aboutApp_grp)
        Me.Controls.Add(Me.applist_grp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 500)
        Me.MinimumSize = New System.Drawing.Size(500, 500)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Easy Software Suite"
        Me.applist_grp.ResumeLayout(False)
        Me.aboutApp_grp.ResumeLayout(False)
        Me.app_desc_GrpBox.ResumeLayout(False)
        CType(Me.app_logo_picbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents applist_grp As GroupBox
    Friend WithEvents aboutApp_grp As GroupBox
    Friend WithEvents app_logo_picbox As PictureBox
    Friend WithEvents app_name_lbl As Label
    Friend WithEvents app_desc_GrpBox As GroupBox
    Friend WithEvents App_Launch_Btn As Button
    Friend WithEvents cancel_btn As Button
    Friend WithEvents thirdParty_lnklbl As LinkLabel
    Friend WithEvents appList_lst As ListBox
    Friend WithEvents app_desc_rchtxtBox As RichTextBox
End Class
