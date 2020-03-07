Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Janus.Windows.GridEX
Partial Public Class frmFieldChooser : Inherits Form
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Overloads Sub Show(ByVal grid As GridEX, ByVal owner As Form)
        Me.gridEXFieldChooserControl1.GridEX = grid
        Me.gridEXFieldChooserControl1.VisualStyleManager = grid.VisualStyleManager
        Dim location As Point = grid.Location
        location = grid.PointToScreen(location)
        location.X = owner.Bounds.Right + 4
        Me.Location = location
        Dim screenBounds As Rectangle = Screen.GetBounds(grid)
        If Me.Bounds.Right > screenBounds.Right Then
            Me.Left = screenBounds.Right - Me.Width
        End If
        Me.Show(owner)

    End Sub
End Class
