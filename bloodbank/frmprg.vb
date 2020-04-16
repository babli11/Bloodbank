Public Class frmprg

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtload.TextChanged

    End Sub

    Private Sub timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer.Tick
        If prgbar.Value < 100 Then
            timer.Enabled = True
            prgbar.Value = prgbar.Value + 10
            txtload.Text = prgbar.Value & "%"
        Else
            timer.Enabled = False
            Me.Hide()
            frmmdi1.Show()
        End If

    End Sub

    Private Sub frmprg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        prgbar.Value = 0
        txtload.Text = " 0 % "

    End Sub
End Class