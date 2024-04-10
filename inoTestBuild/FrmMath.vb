Imports inoTestBuildDLL

Public Class FrmMath

    Private cMath As New ClsMath
    Private Sub CmdAdd_Click(sender As Object, e As EventArgs) Handles CmdAdd.Click
        TxtResult.Text = cMath.addition(TxtValue1.Text, TxtValue2.Text)
    End Sub

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        Me.Close()
    End Sub
End Class