
Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlServerCe

Public Class frmdonor
    Dim result As String
    Dim curvalue As Integer
    Dim con As New SqlCeConnection("Data Source=c:\users\pattabi.abbu\documents\visual studio 2010\Projects\bloodbank\bloodbank\bloodbank.sdf")
    Private Sub btnsave_Click(sender As System.Object, e As System.EventArgs) Handles btnsave.Click
        Dim strname As String = txtname.Text
        Dim strdno As String = txtdno.Text
        Dim stridproof As String = cboproof.SelectedItem.ToString()
        Dim stridno As String = txtidno.Text
        Dim strgender As String = cbogender.SelectedItem.ToString()
        Dim strbg As String = cbobg.SelectedItem.ToString()
        Dim strdatedob As Date = DateTimePicker1.Text
        Dim strage As String = txtage.Text
        Dim straddr As String = txtaddr.Text
        Dim strmob As String = txtmob.Text
        Dim stremail As String = txtemail.Text
        Dim strlbd As String = txtlbd.Text

        Dim cmd As New SqlCeCommand("insert into donor values ('" & strname & "','" & strdno & "','" & stridproof & "','" & stridno & "','" & strgender & "','" & strbg & "','" & strdatedob & "','" & strage & "','" & straddr & "','" & strmob & "','" & stremail & "','" & strlbd & "')", con)

        con.Open()
        If (cmd.ExecuteNonQuery().Equals(1)) Then
            MsgBox(" donor details saved successfully")

        End If
        cmd.Dispose()
        con.Close()
    End Sub
    Sub clearfields()
        txtname.Text = ""
        txtdno.Text = ""
        cboproof.Text = " "
        txtidno.Text = ""
        cbogender.Text = ""
        cbobg.Text = ""
        txtage.Text = ""
        txtaddr.Text = ""
        txtmob.Text = ""
        txtemail.Text = ""
        txtlbd.Text = ""
        autogenerate_dno()
    End Sub




    Private Sub txtage_GotFocus(sender As Object, e As System.EventArgs) Handles txtage.GotFocus
        Dim date1 As Date = Date.Today
        Dim date2 As Date = DateTimePicker1.Text
        Dim age As Long = DateDiff(DateInterval.Year, date2, date1)
        txtage.Text = age
    End Sub



    Private Sub frmdonor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        autogenerate_dno()
        lbldate.Text = Date.Today


    End Sub

    Private Sub btnexit_Click(sender As System.Object, e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btncollecton_Click(sender As System.Object, e As System.EventArgs) Handles btncollecton.Click
        frmcollect.Show()
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

    Private Sub txtmob_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtmob.KeyPress
        If Asc(e.KeyChar) <> 10 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MsgBox("PLEASE ENTER VALUES FROM 0 TO 9")
            End If
        End If
    End Sub

    Private Sub autogenerate_dno()
        Dim con As New SqlCeConnection("Data Source=c:\users\pattabi.abbu\documents\visual studio 2010\Projects\bloodbank\bloodbank\bloodbank.sdf")
        Dim result As String
        Dim cmd As New SqlCeCommand()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select max(donorno) from donor"
        result = cmd.ExecuteScalar().ToString()
        If String.IsNullOrEmpty(result) Then
            result = "D001"

        End If
        result = result.Substring(1)
        Int32.TryParse(result, curvalue)
        curvalue = curvalue + 1
        result = "D" + curvalue.ToString("D3")
        txtdno.Text = result
        cmd.Dispose()
        con.Close()

    End Sub

End Class




