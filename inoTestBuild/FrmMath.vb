Imports inoTestBuildDLL

Public Class FrmMath

    Private cMath As New ClsMath
    Private Sub CmdAdd_Click(sender As Object, e As EventArgs) Handles CmdAdd.Click
        TxtResult.Text = cMath.addition(TxtValue1.Text, TxtValue2.Text)
    End Sub

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        Me.Close()
    End Sub

    Private Sub CmdSubtract_Click(sender As Object, e As EventArgs) Handles CmdSubtract.Click
        TxtResult.Text = cMath.substraction(TxtValue1.Text, TxtValue2.Text)
    End Sub
End Class