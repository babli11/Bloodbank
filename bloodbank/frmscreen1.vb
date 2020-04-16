
Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlServerCe



Public Class frmscreen1

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim con As New SqlCeConnection("Data Source=c:\users\pattabi.abbu\documents\visual studio 2010\Projects\bloodbank\bloodbank\bloodbank.sdf")

        Dim strname As String = txtname.Text
        Dim strage As String = txtage.Text
        Dim stridproof As String = cboproof.SelectedItem.ToString()
        Dim stridno As String = txtidno.Text
        Dim strbg As String = cbobg.SelectedItem.ToString()
        Dim strwt As String = txtwt.Text
        Dim strhepb As String = cbohepb.SelectedItem.ToString()
        Dim strhepc As String = cbohepc.SelectedItem.ToString()
        Dim strbp As String = cbobp.SelectedItem.ToString()
        Dim strtemp As String = txttemp.Text
        Dim strpr As String = txtpr.Text
        Dim strhg As String = txthg.Text
        Dim strelg As String = txtelg.Text
        Dim strhiv As String = cbohiv.SelectedItem()
        Dim strdatedob As Date = DateTimePicker1.Text
        Dim cmd As New SqlCeCommand("insert into sreening values ('" & strname & "','" & strage & "','" & stridproof & "','" & stridno & "','" & strbg & "','" & strwt & "','" & strhepb & "','" & strhepc & "','" & strbp & "','" & strtemp & "','" & strpr & "','" & strhg & "','" & strelg & "','" & strhiv & "','" & strdatedob & "')", con)

        con.Open()
        If txtelg.Text = "yes" Then
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox(" your details saved successfully")
            btnsave.Visible = True
        Else

            MsgBox(" not stored in database")

        End If
        clearfields()
    End Sub

    Sub clearfields()
        txtname.Text = ""
        txttemp.Text = ""
        txtwt.Text = " "
        txtelg.Text = ""
        txtpr.Text = ""
        txthg.Text = ""
        txtage.Text = ""
        cboproof.Text = ""
        txtidno.Text = ""
        cbobg.Text = ""
        cbohepc.Text = ""
        cbohepb.Text = ""
        cbobp.Text = ""
        cbohiv.Text = ""
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnsave.Click
        frmdonor.Show()
    End Sub

    Private Sub frmscreen1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lbldate.Text = Date.Today
        btnsave.Visible = True
        clearfields()

    End Sub

    Private Sub Label15_Click(sender As System.Object, e As System.EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label18_Click(sender As System.Object, e As System.EventArgs) Handles lbldate.Click

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtage_GotFocus(sender As Object, e As System.EventArgs) Handles txtage.GotFocus
        Dim date1 As Date = Date.Today
        Dim date2 As Date = DateTimePicker1.Text
        Dim age As Long = DateDiff(DateInterval.Year, date2, date1)
        txtage.Text = age

    End Sub

    Private Sub txtelg_GotFocus(sender As Object, e As System.EventArgs) Handles txtelg.GotFocus
        If ((cbohiv.Text = "no") And (cbohepc.Text = "no") And (cbohepb.Text = "no") And (txtwt.Text > 50 And txtwt.Text < 120) And (txttemp.Text > 37) And (cbobp.Text = "normal") And (txtpr.Text >= 60 And txtpr.Text <= 100) And (txthg.Text >= 12.5) And (txtage.Text >= 18 And txtage.Text <= 60)) Then
            txtelg.Text = "yes"
        Else
            txtelg.Text = "no"
        End If

    End Sub

    Private Sub btnexit_Click(sender As Object, e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub txtname_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtname.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsLetter(e.KeyChar)) Or (Char.IsWhiteSpace(e.KeyChar)) Then
            Else
                e.Handled = True
                MsgBox("only characters and space allowed!!!", MsgBoxStyle.Information, "verify")
                txtname.Focus()
            End If
        End If

    End Sub

    Private Sub txtwt_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtwt.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MsgBox("please entre number between 0 to 9")
            End If
        End If
    End Sub

    Private Sub txttemp_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txttemp.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MsgBox("please entre numbers between 0 to 9")
            End If
        End If
    End Sub

    Private Sub txtpr_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtpr.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MsgBox("please entre numbers between 0 to 9")
            End If
        End If
    End Sub

    Private Sub txthg_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txthg.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MsgBox("please entre numbers between 0 to 9")
            End If

        End If
    End Sub

    Private Sub Label12_Click(sender As System.Object, e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label17_Click(sender As System.Object, e As System.EventArgs) Handles Label17.Click

    End Sub

    Private Sub txtelg_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtelg.TextChanged

    End Sub

    Private Sub Label7_Click(sender As System.Object, e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class
