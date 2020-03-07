Imports Microsoft.VisualBasic
Imports System
Partial Public Class frmFieldChooser
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (Not components Is Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        'Me.officeFormAdorner1 = New Janus.Windows.Ribbon.OfficeFormAdorner(Me.components)
        Me.gridEXFieldChooserControl1 = New Janus.Windows.GridEX.GridEXFieldChooserControl()
        Me.SuspendLayout()
        ' 
        ' officeFormAdorner1
        ' 
        'Me.officeFormAdorner1.DocumentName = "Field Chooser"
        'Me.officeFormAdorner1.Form = Me
        'Me.officeFormAdorner1.Office2007CustomColor = System.Drawing.Color.Empty
        ' 
        ' gridEXFieldChooserControl1
        ' 
        Me.gridEXFieldChooserControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridEXFieldChooserControl1.Location = New System.Drawing.Point(0, 0)
        Me.gridEXFieldChooserControl1.Name = "gridEXFieldChooserControl1"
        Me.gridEXFieldChooserControl1.Size = New System.Drawing.Size(158, 182)
        Me.gridEXFieldChooserControl1.TabIndex = 0
        Me.gridEXFieldChooserControl1.Text = "gridEXFieldChooserControl1"
        ' 
        ' frmFieldChooser
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(158, 182)
        Me.Controls.Add(Me.gridEXFieldChooserControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmFieldChooser"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Field Chooser"
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' Private officeFormAdorner1 As Janus.Windows.Ribbon.OfficeFormAdorner
    Private gridEXFieldChooserControl1 As Janus.Windows.GridEX.GridEXFieldChooserControl
End Class
