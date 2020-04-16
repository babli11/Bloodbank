
Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlServerCe

Public Class frmgdonor
    Dim con As New SqlCeConnection("Data Source=c:\users\pattabi.abbu\documents\visual studio 2010\Projects\bloodbank\bloodbank\bloodbank.sdf")

    Private Sub frmgdonor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim index As Integer
        index = DataGridView1.CurrentCell.RowIndex
        DataGridView1.Rows.RemoveAt(index)









    End Sub


    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim cmd As New SqlCeCommand()

        Dim myda As SqlCeDataAdapter
        Dim mydataset As DataSet
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from donor"

        myda = New SqlCeDataAdapter(cmd)

        Dim dt As New DataTable()
        mydataset = New DataSet()
        myda.Fill(dt)
        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = dt

        con.Close()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click

    End Sub
End Class