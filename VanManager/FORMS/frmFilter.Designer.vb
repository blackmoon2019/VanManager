<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFilter
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
        Me.FilterEditor1 = New Janus.Windows.FilterEditor.FilterEditor()
        Me.SuspendLayout()
        '
        'FilterEditor1
        '
        Me.FilterEditor1.BackColor = System.Drawing.Color.DarkGray
        Me.FilterEditor1.InnerAreaStyle = Janus.Windows.UI.Dock.PanelInnerAreaStyle.UseFormatStyle
        Me.FilterEditor1.Location = New System.Drawing.Point(2, 0)
        Me.FilterEditor1.MinSize = New System.Drawing.Size(0, 0)
        Me.FilterEditor1.Name = "FilterEditor1"
        Me.FilterEditor1.ScrollMode = Janus.Windows.UI.Dock.ScrollMode.Both
        Me.FilterEditor1.ScrollStep = 15
        Me.FilterEditor1.Size = New System.Drawing.Size(457, 249)
        Me.FilterEditor1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2010
        '
        'frmFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 250)
        Me.Controls.Add(Me.FilterEditor1)
        Me.Name = "frmFilter"
        Me.Text = "frmFilter"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FilterEditor1 As Janus.Windows.FilterEditor.FilterEditor
End Class
