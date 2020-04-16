
Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlServerCe
Public Class frmlogin
    Private Sub cmdbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbtn.Click
        Dim con As New SqlCeConnection("Data Source=c:\users\pattabi.abbu\documents\visual studio 2010\Projects\bloodbank\bloodbank\bloodbank.sdf")
        Dim cmd As New SqlCeCommand
        Dim flag As Boolean
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from login"
        cmd.ExecuteNonQuery()
        Dim ird As SqlCeDataReader = cmd.ExecuteReader()
        flag = False
        'if ird.hasrows then
        While ird.Read()
            If ird("username") = txtuser.Text And ird("password") = txtpass.Text Then
                MsgBox("valid user")
                flag = True
                frmprg.Show()
                Me.Hide()

            End If
        End While
        If flag = False Then
            MsgBox("username and password do not match....")
            'clear all fields
            txtpass.Text = ""
            txtuser.Text = ""

        End If
        con.Close()
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        'close()
        Application.Exit()
    End Sub

    Private Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub frmlogin_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtuser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtuser.TextChanged

    End Sub
End Class
