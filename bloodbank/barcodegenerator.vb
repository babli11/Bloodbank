Public Class frmbarcode

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub






    Private Sub checkbtn_Tick(sender As System.Object, e As System.EventArgs) Handles checkbtn.Tick
        btngen.Enabled = txtcode.Text.Length > 1

    End Sub

    Private Sub frmbarcodegenerator_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class