<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class previewWindow
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
        Me.preview_Web = New Microsoft.Web.WebView2.WinForms.WebView2()
        CType(Me.preview_Web, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'preview_Web
        '
        Me.preview_Web.CreationProperties = Nothing
        Me.preview_Web.Dock = System.Windows.Forms.DockStyle.Fill
        Me.preview_Web.Location = New System.Drawing.Point(0, 0)
        Me.preview_Web.Name = "preview_Web"
        Me.preview_Web.Size = New System.Drawing.Size(800, 585)
        Me.preview_Web.TabIndex = 0
        Me.preview_Web.ZoomFactor = 1.0R
        '
        'previewWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 585)
        Me.Controls.Add(Me.preview_Web)
        Me.Name = "previewWindow"
        Me.Text = "previewWindow"
        CType(Me.preview_Web, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents preview_Web As Microsoft.Web.WebView2.WinForms.WebView2
End Class
