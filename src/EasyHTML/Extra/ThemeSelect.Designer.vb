<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThemeSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ThemeSelect))
        Me.rad_Blank = New System.Windows.Forms.RadioButton()
        Me.rad_Template = New System.Windows.Forms.RadioButton()
        Me.grp_SelectTemplate = New System.Windows.Forms.GroupBox()
        Me.cmb_Theme = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rad_exampleLoad = New System.Windows.Forms.RadioButton()
        Me.grp_exampleLoad = New System.Windows.Forms.GroupBox()
        Me.cmb_exampleLoad = New System.Windows.Forms.ComboBox()
        Me.grp_SelectTemplate.SuspendLayout()
        Me.grp_exampleLoad.SuspendLayout()
        Me.SuspendLayout()
        '
        'rad_Blank
        '
        Me.rad_Blank.AutoSize = True
        Me.rad_Blank.Location = New System.Drawing.Point(12, 12)
        Me.rad_Blank.Name = "rad_Blank"
        Me.rad_Blank.Size = New System.Drawing.Size(161, 17)
        Me.rad_Blank.TabIndex = 0
        Me.rad_Blank.TabStop = True
        Me.rad_Blank.Text = "Blank, Don't Use a Template"
        Me.rad_Blank.UseVisualStyleBackColor = True
        '
        'rad_Template
        '
        Me.rad_Template.AutoSize = True
        Me.rad_Template.Location = New System.Drawing.Point(12, 35)
        Me.rad_Template.Name = "rad_Template"
        Me.rad_Template.Size = New System.Drawing.Size(96, 17)
        Me.rad_Template.TabIndex = 1
        Me.rad_Template.TabStop = True
        Me.rad_Template.Text = "Use a template"
        Me.rad_Template.UseVisualStyleBackColor = True
        '
        'grp_SelectTemplate
        '
        Me.grp_SelectTemplate.Controls.Add(Me.cmb_Theme)
        Me.grp_SelectTemplate.Location = New System.Drawing.Point(12, 58)
        Me.grp_SelectTemplate.Name = "grp_SelectTemplate"
        Me.grp_SelectTemplate.Size = New System.Drawing.Size(485, 64)
        Me.grp_SelectTemplate.TabIndex = 2
        Me.grp_SelectTemplate.TabStop = False
        Me.grp_SelectTemplate.Text = "Select a Template"
        '
        'cmb_Theme
        '
        Me.cmb_Theme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Theme.FormattingEnabled = True
        Me.cmb_Theme.Items.AddRange(New Object() {"HTML 5 Test Page", "Bootstrap", "UI Kit", "Bulma", "W3.CSS", "Materialize", "Pure", "Foundation", "Semantic UI", "Milligram", "Skeleton", "Tailwind", "SPECTRE", "Picnic", "Dead Simple Grid"})
        Me.cmb_Theme.Location = New System.Drawing.Point(6, 19)
        Me.cmb_Theme.Name = "cmb_Theme"
        Me.cmb_Theme.Size = New System.Drawing.Size(473, 21)
        Me.cmb_Theme.TabIndex = 4
        '
        'Timer1
        '
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(422, 221)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rad_exampleLoad
        '
        Me.rad_exampleLoad.AutoSize = True
        Me.rad_exampleLoad.Location = New System.Drawing.Point(12, 128)
        Me.rad_exampleLoad.Name = "rad_exampleLoad"
        Me.rad_exampleLoad.Size = New System.Drawing.Size(106, 17)
        Me.rad_exampleLoad.TabIndex = 4
        Me.rad_exampleLoad.TabStop = True
        Me.rad_exampleLoad.Text = "Load an example"
        Me.rad_exampleLoad.UseVisualStyleBackColor = True
        '
        'grp_exampleLoad
        '
        Me.grp_exampleLoad.Controls.Add(Me.cmb_exampleLoad)
        Me.grp_exampleLoad.Location = New System.Drawing.Point(12, 151)
        Me.grp_exampleLoad.Name = "grp_exampleLoad"
        Me.grp_exampleLoad.Size = New System.Drawing.Size(485, 64)
        Me.grp_exampleLoad.TabIndex = 5
        Me.grp_exampleLoad.TabStop = False
        Me.grp_exampleLoad.Text = "Select a Template"
        '
        'cmb_exampleLoad
        '
        Me.cmb_exampleLoad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_exampleLoad.FormattingEnabled = True
        Me.cmb_exampleLoad.Location = New System.Drawing.Point(6, 19)
        Me.cmb_exampleLoad.Name = "cmb_exampleLoad"
        Me.cmb_exampleLoad.Size = New System.Drawing.Size(473, 21)
        Me.cmb_exampleLoad.TabIndex = 4
        '
        'ThemeSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(509, 253)
        Me.Controls.Add(Me.grp_exampleLoad)
        Me.Controls.Add(Me.rad_exampleLoad)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grp_SelectTemplate)
        Me.Controls.Add(Me.rad_Template)
        Me.Controls.Add(Me.rad_Blank)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ThemeSelect"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select a Template"
        Me.grp_SelectTemplate.ResumeLayout(False)
        Me.grp_exampleLoad.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rad_Blank As RadioButton
    Friend WithEvents rad_Template As RadioButton
    Friend WithEvents grp_SelectTemplate As GroupBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents cmb_Theme As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents rad_exampleLoad As RadioButton
    Friend WithEvents grp_exampleLoad As GroupBox
    Friend WithEvents cmb_exampleLoad As ComboBox
End Class
