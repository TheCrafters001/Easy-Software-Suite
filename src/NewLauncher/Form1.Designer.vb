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
        Me.applist_grp = New System.Windows.Forms.GroupBox()
        Me.aboutApp_grp = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.app_desc_GrpBox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.aboutApp_grp.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'applist_grp
        '
        Me.applist_grp.Location = New System.Drawing.Point(12, 12)
        Me.applist_grp.Name = "applist_grp"
        Me.applist_grp.Size = New System.Drawing.Size(180, 419)
        Me.applist_grp.TabIndex = 0
        Me.applist_grp.TabStop = False
        Me.applist_grp.Text = "App List"
        '
        'aboutApp_grp
        '
        Me.aboutApp_grp.Controls.Add(Me.Button1)
        Me.aboutApp_grp.Controls.Add(Me.app_desc_GrpBox)
        Me.aboutApp_grp.Controls.Add(Me.Label1)
        Me.aboutApp_grp.Controls.Add(Me.PictureBox1)
        Me.aboutApp_grp.Location = New System.Drawing.Point(198, 12)
        Me.aboutApp_grp.Name = "aboutApp_grp"
        Me.aboutApp_grp.Size = New System.Drawing.Size(274, 408)
        Me.aboutApp_grp.TabIndex = 1
        Me.aboutApp_grp.TabStop = False
        Me.aboutApp_grp.Text = "About Selected App"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(193, 379)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'app_desc_GrpBox
        '
        Me.app_desc_GrpBox.Location = New System.Drawing.Point(6, 112)
        Me.app_desc_GrpBox.Name = "app_desc_GrpBox"
        Me.app_desc_GrpBox.Size = New System.Drawing.Size(262, 261)
        Me.app_desc_GrpBox.TabIndex = 2
        Me.app_desc_GrpBox.TabStop = False
        Me.app_desc_GrpBox.Text = "App Description"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(99, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 84)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Easy Software Suite"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Easy_Software_Suite_Launcher.My.Resources.Resources.EasySoftwareSuite1
        Me.PictureBox1.Location = New System.Drawing.Point(6, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(397, 426)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 434)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(63, 15)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "LinkLabel1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.aboutApp_grp)
        Me.Controls.Add(Me.applist_grp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(500, 500)
        Me.MinimumSize = New System.Drawing.Size(500, 500)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.aboutApp_grp.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents applist_grp As GroupBox
    Friend WithEvents aboutApp_grp As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents app_desc_GrpBox As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
