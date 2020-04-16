
Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlServerCe
Public Class frmcomponents
    Dim con As New SqlCeConnection("Data Source=c:\users\pattabi.abbu\documents\visual studio 2010\Projects\bloodbank\bloodbank\bloodbank.sdf")




    Private Sub cbobg_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbobg.SelectedIndexChanged
        Dim cmd As New SqlCeCommand()
        Dim myda As SqlCeDataAdapter
        Dim mydataset As DataSet
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select packidno,bloodgroup,typeofpack,expirydate from collection where bloodgroup='" & Trim(cbobg.Text) & "'"
        myda = New SqlCeDataAdapter(cmd)
        Dim dt As New DataTable()
        mydataset = New DataSet()
        myda.Fill(dt)


        DataGridView1.AutoGenerateColumns = True

        DataGridView1.DataSource = dt
        con.Close()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

    End Sub


    Private Sub cbocomp_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbocomp.SelectedIndexChanged
        Dim cmd As New SqlCeCommand()
        Dim myda As SqlCeDataAdapter
        cmd.Connection = con
        con.Open()
        If (cbocomp.Text = "PLATELETS") Then
            cmd.CommandText = "select bloodgroup,typeofpack,packid,quantity,date,expirydate from platelets where bloodgroup='" & Trim(cbobg.Text) & "'"
        ElseIf (cbocomp.Text = "RBC") Then
            cmd.CommandText = "select bloodgroup,typeofpack,packidno,quantity,date,expirydate from rbc where bloodgroup='" & Trim(cbobg.Text) & "'"
            Else
            cbocomp.Text = "PLASMA"
            cmd.CommandText = "select bloodgroup,typeofpack,packidno,quantity,date,expirydate from plasma where bloodgroup='" & Trim(cbobg.Text) & "'"
        End If

            myda = New SqlCeDataAdapter(cmd)
            Dim dt As New DataTable()
            myda.Fill(dt)
            DataGridView1.AutoGenerateColumns = True

            DataGridView1.DataSource = dt
            con.Close()
    End Sub

    Private Sub frmcomponents_Load(sender As Object, e As System.EventArgs) Handles Me.Load



    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class