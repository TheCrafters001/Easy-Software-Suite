<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpenProject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OpenProject))
        Me.newProj_rad = New System.Windows.Forms.RadioButton()
        Me.openProj_rad = New System.Windows.Forms.RadioButton()
        Me.openProj_grp = New System.Windows.Forms.GroupBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ok_btn = New System.Windows.Forms.Button()
        Me.projLocation_txt = New System.Windows.Forms.TextBox()
        Me.browse_btn = New System.Windows.Forms.Button()
        Me.browser_lbl = New System.Windows.Forms.Label()
        Me.projLocation_fld = New System.Windows.Forms.FolderBrowserDialog()
        Me.openProj_grp.SuspendLayout()
        Me.SuspendLayout()
        '
        'newProj_rad
        '
        Me.newProj_rad.AutoSize = True
        Me.newProj_rad.Enabled = False
        Me.newProj_rad.Location = New System.Drawing.Point(12, 12)
        Me.newProj_rad.Name = "newProj_rad"
        Me.newProj_rad.Size = New System.Drawing.Size(117, 17)
        Me.newProj_rad.TabIndex = 0
        Me.newProj_rad.Text = "Create New Project"
        Me.newProj_rad.UseVisualStyleBackColor = True
        '
        'openProj_rad
        '
        Me.openProj_rad.AutoSize = True
        Me.openProj_rad.Checked = True
        Me.openProj_rad.Location = New System.Drawing.Point(12, 35)
        Me.openProj_rad.Name = "openProj_rad"
        Me.openProj_rad.Size = New System.Drawing.Size(128, 17)
        Me.openProj_rad.TabIndex = 1
        Me.openProj_rad.TabStop = True
        Me.openProj_rad.Text = "Open Exisiting Project"
        Me.openProj_rad.UseVisualStyleBackColor = True
        '
        'openProj_grp
        '
        Me.openProj_grp.Controls.Add(Me.browser_lbl)
        Me.openProj_grp.Controls.Add(Me.browse_btn)
        Me.openProj_grp.Controls.Add(Me.projLocation_txt)
        Me.openProj_grp.Location = New System.Drawing.Point(12, 58)
        Me.openProj_grp.Name = "openProj_grp"
        Me.openProj_grp.Size = New System.Drawing.Size(485, 64)
        Me.openProj_grp.TabIndex = 2
        Me.openProj_grp.TabStop = False
        Me.openProj_grp.Text = "Open Exisiting Project"
        '
        'Timer1
        '
        '
        'ok_btn
        '
        Me.ok_btn.Location = New System.Drawing.Point(422, 128)
        Me.ok_btn.Name = "ok_btn"
        Me.ok_btn.Size = New System.Drawing.Size(75, 23)
        Me.ok_btn.TabIndex = 3
        Me.ok_btn.Text = "OK"
        Me.ok_btn.UseVisualStyleBackColor = True
        '
        'projLocation_txt
        '
        Me.projLocation_txt.Location = New System.Drawing.Point(6, 32)
        Me.projLocation_txt.Name = "projLocation_txt"
        Me.projLocation_txt.ReadOnly = True
        Me.projLocation_txt.Size = New System.Drawing.Size(436, 20)
        Me.projLocation_txt.TabIndex = 0
        '
        'browse_btn
        '
        Me.browse_btn.Location = New System.Drawing.Point(448, 30)
        Me.browse_btn.Name = "browse_btn"
        Me.browse_btn.Size = New System.Drawing.Size(31, 23)
        Me.browse_btn.TabIndex = 1
        Me.browse_btn.Text = "..."
        Me.browse_btn.UseVisualStyleBackColor = True
        '
        'browser_lbl
        '
        Me.browser_lbl.AutoSize = True
        Me.browser_lbl.Location = New System.Drawing.Point(6, 16)
        Me.browser_lbl.Name = "browser_lbl"
        Me.browser_lbl.Size = New System.Drawing.Size(116, 13)
        Me.browser_lbl.TabIndex = 2
        Me.browser_lbl.Text = "Project Folder Location"
        '
        'OpenProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(509, 163)
        Me.Controls.Add(Me.ok_btn)
        Me.Controls.Add(Me.openProj_grp)
        Me.Controls.Add(Me.openProj_rad)
        Me.Controls.Add(Me.newProj_rad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OpenProject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Open Project"
        Me.openProj_grp.ResumeLayout(False)
        Me.openProj_grp.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents newProj_rad As RadioButton
    Friend WithEvents openProj_rad As RadioButton
    Friend WithEvents openProj_grp As GroupBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ok_btn As Button
    Friend WithEvents projLocation_txt As TextBox
    Friend WithEvents browse_btn As Button
    Friend WithEvents browser_lbl As Label
    Friend WithEvents projLocation_fld As FolderBrowserDialog
End Class
