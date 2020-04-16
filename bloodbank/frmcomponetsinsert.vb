
Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlServerCe

Public Class frmcomponetsinsert
    Dim con As New SqlCeConnection("Data Source=c:\users\pattabi.abbu\documents\visual studio 2010\Projects\bloodbank\bloodbank\bloodbank.sdf")

    Private rowindex As Integer = 0

    Private Sub frmcomponetsinsert_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbobg.SelectedIndexChanged
        Dim cmd As New SqlCeCommand()
        Dim myda As SqlCeDataAdapter
        Dim mydataset As DataSet
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select packidno,bloodgroup,typeofpack,expirydate from collection where bloodgroup='" & cbobg.Text & "'"
        myda = New SqlCeDataAdapter(cmd)
        Dim dt As New DataTable()
        mydataset = New DataSet()
        myda.Fill(dt)


        DataGridView1.AutoGenerateColumns = True

        DataGridView1.DataSource = dt
        con.Close()

    End Sub

    Private Sub txtdate_GotFocus(sender As Object, e As System.EventArgs) Handles txtdate.GotFocus
        txtdate.Text = Date.Today
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtdate.TextChanged
        txtdate.Text = Date.Today
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtexp1_GotFocus(sender As Object, e As System.EventArgs) Handles txtexp1.GotFocus
        txtexp1.Text = Date.Today.AddDays(42)
    End Sub

    Private Sub txtexp1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtexp1.TextChanged

    End Sub

    Private Sub txtexp3_GotFocus(sender As Object, e As System.EventArgs) Handles txtexp3.GotFocus
        txtexp3.Text = Date.Today.AddDays(5)
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles txtexp3.TextChanged

    End Sub

    Private Sub txtexp2_GotFocus(sender As Object, e As System.EventArgs) Handles txtexp2.GotFocus
        txtexp2.Text = Date.Today.AddHours(6)
    End Sub

    Private Sub txtexp2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtexp2.TextChanged

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        Me.txtpackid.text = DataGridView1.Item(2, i).Value
        Me.txttypeofpack.Text = DataGridView1.Item(1, i).Value


    End Sub

    Private Sub txtqt1_GotFocus(sender As Object, e As System.EventArgs) Handles txtqt1.GotFocus
        If txttypeofpack.text = "single" Then
            txtqt1.Text = 150
        ElseIf txttypeofpack.text = "double" Then
            txtqt1.Text = 200
        End If
    End Sub

    Private Sub txtqt1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtqt1.TextChanged

    End Sub

    Private Sub Label7_Click(sender As System.Object, e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub txtqt2_GotFocus(sender As Object, e As System.EventArgs) Handles txtqt2.GotFocus
        If txttypeofpack.text = "single" Then
            txtqt1.Text = 150
        ElseIf txttypeofpack.text = "double" Then
            txtqt1.Text = 200
        End If
    End Sub

    Private Sub TextBox1_TextChanged_2(sender As System.Object, e As System.EventArgs) Handles txtqt2.TextChanged

    End Sub

    Private Sub txtqt3_GotFocus(sender As Object, e As System.EventArgs) Handles txtqt3.GotFocus
        If txttypeofpack.text = "single" Then
            txtqt1.Text = 50
        ElseIf txttypeofpack.text = "double" Then
            txtqt1.Text = 50
        End If
    End Sub

    Private Sub txtqt3_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtqt3.TextChanged

    End Sub

    Private Sub btnsave_Click(sender As System.Object, e As System.EventArgs) Handles btnsave.Click
        Dim con As New SqlCeConnection("Data Source=c:\users\pattabi.abbu\documents\visual studio 2010\Projects\bloodbank\bloodbank\bloodbank.sdf")
        Dim cmd As New SqlCeCommand("insert into rbc values('" & cbobg.Text & "','" & txttypeofpack.text & "','" & txtpackid.text & "','" & txtqt1.Text & "','" & txtdate.Text & "','" & txtexp1.Text & "')", con)
        con.Open()
        If (cmd.ExecuteNonQuery().Equals(1)) Then
            MsgBox("rbc details saved")

        End If
        cmd.Dispose()
        con.Close()


        Dim cmd1 As New SqlCeCommand("insert into plasma values('" & cbobg.Text & "','" & txttypeofpack.Text & "','" & txtpackid.Text & "','" & txtqt2.Text & "','" & txtdate.Text & "','" & txtexp2.Text & "')", con)
        con.Open()
        If (cmd1.ExecuteNonQuery().Equals(1)) Then
            MsgBox("plasma details saved")

        End If
        cmd1.Dispose()
        con.Close()


        Dim cmd2 As New SqlCeCommand("insert into platelets values('" & cbobg.Text & "','" & txttypeofpack.Text & "','" & txtpackid.Text & "','" & txtqt3.Text & "','" & txtdate.Text & "','" & txtexp3.Text & "')", con)
        con.Open()
        If (cmd2.ExecuteNonQuery().Equals(1)) Then
            MsgBox(" platelets details saved")

        End If
        cmd1.Dispose()
        con.Close()

        Dim cmddel As New SqlCeCommand()
        cmddel.CommandText = "delete from collection where packidno='" & txtpackid.text & "'"
        cmddel.Connection = con
        con.Open()
        cmddel.ExecuteNonQuery()
        Me.DataGridView1.Rows.RemoveAt(Me.rowindex)
        con.Close()
        clearfields()
    End Sub

    Sub clearfields()
        txtdate.Text = " "
        txtexp1.Text = " "
        txtexp2.Text = " "
        txtexp3.Text = " "
        txtpackid.text = " "
        txtqt1.Text = " "
        txtexp2.Text = " "
        txtqt3.Text = " "
        cbobg.Text = " "
        txttypeofpack.text = " "
    End Sub

    Private Sub Label9_Click(sender As System.Object, e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label10_Click(sender As System.Object, e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class