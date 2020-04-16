

Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlServerCe

Public Class frmcollect
    Dim con As New SqlCeConnection("Data Source=c:\users\pattabi.abbu\documents\visual studio 2010\Projects\bloodbank\bloodbank\bloodbank.sdf")
    Dim result As String
    Dim curvalue As Integer


    Private Sub frmcollect_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
       

        txtcod.Text = Date.Today
        con.Open()
        Dim cmd As New SqlCeCommand("select donorno from donor", con)
        cmd.ExecuteNonQuery()
        Dim ird As SqlCeDataReader = cmd.ExecuteReader()
        While ird.Read
            cbodno.Items.Add(ird.Item(0))

        End While
        ird.Close()
        cmd.Dispose()
        con.Close()
        autogenerate_pack_id()

    End Sub


    Private Sub cbodno_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbodno.SelectedIndexChanged
        Dim cmd As New SqlCeCommand()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select name,bloodgroup from donor where donorno='" & cbodno.Text & "'"
        cmd.ExecuteNonQuery()
        Dim ird As SqlCeDataReader = cmd.ExecuteReader()
        While ird.Read()
            txtname.Text = ird.Item(0)
            cbobg.Text = ird.Item(1)
        End While
        ird.Close()
        cmd.Dispose()
        con.Close()
    End Sub
    Private Sub autogenerate_pack_id()
        Dim cmd As New SqlCeCommand()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select max(donorno) from collection"
        result = cmd.ExecuteScalar().ToString()
        If String.IsNullOrEmpty(result) Then
            result = "P001"
        End If
        result = result.Substring(1)
        Int32.TryParse(result, curvalue)
        curvalue = curvalue + 1
        result = "P" + curvalue.ToString("P3")
        txtpid.Text = result
        cmd.Dispose()
        con.Close()
    End Sub

    Private Sub btnsave_Click(sender As System.Object, e As System.EventArgs) Handles btnsave.Click
        Dim cmd As New SqlCeCommand("insert into collection values ('" & cbodno.Text & "','" & txtname.Text & "','" & cbobg.Text & "','" & cbopack.Text & "','" & txtqty.Text & "','" & txtcod.Text & "','" & txtpid.Text & "','" & txteod.Text & "')", con)

        con.Open()
        If (cmd.ExecuteNonQuery().Equals(1)) Then
            MsgBox("BLOOD COLLECTION DETAILS SAVED SUCCESSFULLY")
        End If
        clearfields()
        cmd.Dispose()
        con.Close()


    End Sub
    Sub clearfields()
        txtname.Text = ""
        cbobg.Text = ""
        txtcod.Text = ""
        txteod.Text = ""
        cbopack.Text = ""
        txtpid.Text = ""
        txtqty.Text = ""


    End Sub

    Private Sub btncheck_Click(sender As System.Object, e As System.EventArgs) Handles btncheck.Click
        Dim cmd As New SqlCeCommand()
        Dim myda As SqlCeDataAdapter
        Dim mydataset As DataSet
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from collection"

        myda = New SqlCeDataAdapter(cmd)

        Dim dt As New DataTable()
        mydataset = New DataSet()
        myda.Fill(dt)
        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = dt

        con.Close()

    End Sub

    Private Sub txteod_GotFocus(sender As Object, e As System.EventArgs) Handles txteod.GotFocus
        txteod.Text = Date.Today.AddMonths(6)

    End Sub

    Private Sub txtcod_TextChanged(sender As Object, e As System.EventArgs) Handles txtcod.TextChanged
        txtcod.Text = Date.Today

    End Sub

    Private Sub cbopack_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbopack.SelectedIndexChanged
        If cbopack.Text = "single" Then
            txtqty.Text = "350"
        Else
            txtqty.Text = "450"

        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As System.EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub txtpid_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtpid.TextChanged

    End Sub
End Class