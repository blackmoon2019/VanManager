Imports Janus.Windows.GridEX
Public Class frmFilter

    Public Overloads Function ShowDialog(ByVal grid As GridEX, ByVal parent As Form) As DialogResult

        Me.FilterEditor1.SourceControl = grid
        Me.ShowDialog(parent)
        If Me.DialogResult = System.Windows.Forms.DialogResult.OK Then
            grid.RootTable.FilterCondition = CType(Me.FilterEditor1.FilterCondition, IFilterCondition)
        End If
        Return Me.DialogResult
    End Function
End Class