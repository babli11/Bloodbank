Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlServerCe



Public Class frmrequest
    Private rowindex As Integer = 0
    Dim con As New SqlCeConnection(" Data Source=C:\Users\Pattabi.abbu\Documents\Visual Studio 2010\Projects\bloodbank\bloodbank\")

    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.RequestTableAdapter.Fill(Me.BloodbankDataSet1.request)


    End Sub

    Private Sub txtptname_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtptname.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsLetter(e.KeyChar)) Or (Char.IsWhiteSpace(e.KeyChar)) Then
            Else
                e.Handled = True
                MsgBox("only characters and space are allowed!!", MsgBoxStyle.Information, "verify")
                txtptname.Focus()


            End If
        End If
    End Sub

    Private Sub txthospital_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txthospital.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
        End If
        If (Char.IsLetter(e.KeyChar)) Or (Char.IsWhiteSpace(e.KeyChar)) Then
        Else
            e.Handled = True
            MsgBox("only characters and space are allowed!!", MsgBoxStyle.Information, "verify")
            txthospital.Focus()
        End If



    End Sub

    Private Sub txtphone_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtphone.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MsgBox("please entre numbers between 0 to 9")
            End If
        End If
    End Sub

    Private Sub Label7_Click(sender As System.Object, e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub btnexit_Click(sender As Object, e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub cbobg_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbobg.SelectedIndexChanged
        Dim cmd As New SqlCeCommand()
        Dim myda As SqlCeDataAdapter
        Dim mydataset As DataSet
        cmd.Connection = con
        con.Open()
        If cbobg.Text = "A+" Then
            If cborequest.Text = "NILL" Then
                cmd.CommandText = "select packid,bloodgroup,typeofpack,expirydate from collection where bloodgroup='A+' or bloodgroup='O+' or bloodgroup= 'O-' or bloodgroup='A+'"
                myda = New SqlCeDataAdapter(cmd)
                Dim dt As New DataTable()
                mydataset = New DataSet()
                myda.Fill(dt)
                DataGridView1.AutoGenerateColumns = False
                DataGridView1.DataSource = dt

            End If
            If cbobg.Text = "A-" Then
                cmd.CommandText = "select packid,bloodgroup,typeofpack,expirydate from collection where bloodgroup='A-' or bloodgroup='O-' or bloodgroup='A-'"
                myda = New SqlCeDataAdapter(cmd)
                Dim dt As New DataTable()
                mydataset = New DataSet()
                myda.Fill(dt)
                DataGridView1.AutoGenerateColumns = False
                DataGridView1.DataSource = dt
            End If
            If cbobg.Text = "A+" Then
                If cborequest.Text = "NILL" Then
                    cmd.CommandText = "select packid,bloodgroup,typeofpack,expirydate from collection where bloodgroup='A+' or bloodgroup='O-' or bloodgroup='A+'"
                    myda = New SqlCeDataAdapter(cmd)
                    Dim dt As New DataTable()
                    mydataset = New DataSet()
                    myda.Fill(dt)
                    DataGridView1.AutoGenerateColumns = False
                    DataGridView1.DataSource = dt
                End If
                If cbobg.Text = "O-" Then
                    If cborequest.Text = "NILL" Then
                        cmd.CommandText = "select packid,bloodgroup,typeofpack,expirydate from collection where bloodgroup='O-' or bloodgroup='O-'"
                        myda = New SqlCeDataAdapter(cmd)
                        Dim dt As New DataTable()
                        mydataset = New DataSet()
                        myda.Fill(dt)
                        DataGridView1.AutoGenerateColumns = False
                        DataGridView1.DataSource = dt
                    End If
                    If cbobg.Text = "B+" Then
                        cmd.CommandText = "select packid,bloodgroup,typeofpack,expirydate from collection where bloodgroup='B+' or bloodgroup='O+' or bloodgroup='O-' or bloodgroup='B-'"
                        myda = New SqlCeDataAdapter(cmd)
                        Dim dt As New DataTable()
                        mydataset = New DataSet()
                        myda.Fill(dt)
                        DataGridView1.AutoGenerateColumns = False
                        DataGridView1.DataSource = dt
                    End If
                    If cbobg.Text = "B-" Then
                        If cborequest.Text = "NILL" Then
                            cmd.CommandText = "select packid,bloodgroup,typeofpack,expirydate from collection where bloodgroup='B-' or bloodgroup='O-'"
                            myda = New SqlCeDataAdapter(cmd)
                            Dim dt As New DataTable()
                            mydataset = New DataSet()
                            myda.Fill(dt)
                            DataGridView1.AutoGenerateColumns = False
                            DataGridView1.DataSource = dt
                        End If
                        If cbobg.Text = "AB-" Then
                            cmd.CommandText = "select packid,bloodgroup,typeofpack,expirydate from collection where bloodgroup='AB-' or bloodgroup='O+' or bloodgroup='O-' or bloodgroup='B-'"
                            myda = New SqlCeDataAdapter(cmd)
                            Dim dt As New DataTable()
                            mydataset = New DataSet()
                            myda.Fill(dt)
                            DataGridView1.AutoGenerateColumns = False
                            DataGridView1.DataSource = dt
                        End If
                        If cbobg.Text = "AB+" Then

                            cmd.CommandText = "select packid,bloodgroup,typeofpack,expirydate from collection where bloodgroup='A+' or bloodgroup='A-' or bloodgroup='O+' or bloodgroup='B-' or bloodgroup='O-' or bloodgroup='B+' or bloodgroup='AB+' or bloodgroup='AB-'"
                            myda = New SqlCeDataAdapter(cmd)
                            Dim dt As New DataTable()
                            mydataset = New DataSet()
                            myda.Fill(dt)
                            DataGridView1.AutoGenerateColumns = False
                            DataGridView1.DataSource = dt
                        End If


                        If cbobg.Text = "AB+" Then

                            cmd.CommandText = "select packid,bloodgroup,typeofpack,expirydate from collection where bloodgroup='A+' or bloodgroup='A-' or bloodgroup='O+' or bloodgroup='B-' or bloodgroup='O-' or bloodgroup='B+' or bloodgroup='AB+' or bloodgroup='AB-'"
                            myda = New SqlCeDataAdapter(cmd)
                            Dim dt As New DataTable()
                            mydataset = New DataSet()
                            myda.Fill(dt)
                            DataGridView1.AutoGenerateColumns = False
                            DataGridView1.DataSource = dt
                        End If
                    End If


                    If cbobg.Text = "AB+" Then

                        cmd.CommandText = "select packid,bloodgroup,typeofpack,expirydate from collection where bloodgroup='A+' or bloodgroup='A-' or bloodgroup='O+' or bloodgroup='B-' or bloodgroup='O-' or bloodgroup='B+' or bloodgroup='AB+' or bloodgroup='AB-'"
                        myda = New SqlCeDataAdapter(cmd)
                        Dim dt As New DataTable()
                        mydataset = New DataSet()
                        myda.Fill(dt)
                        DataGridView1.AutoGenerateColumns = False
                        DataGridView1.DataSource = dt
                    End If
                End If



                If cbobg.Text = "A+" Then
                    If cborequest.Text = "RBC" Then

                        cmd.CommandText = "select packid,bloodgroup,typeofpack,expirydate from rbc where bloodgroup='A+' or bloodgroup='A-' or bloodgroup='O+' or bloodgroup='O-'"
                        myda = New SqlCeDataAdapter(cmd)
                        Dim dt As New DataTable()
                        mydataset = New DataSet()
                        myda.Fill(dt)
                        DataGridView1.AutoGenerateColumns = False
                        DataGridView1.DataSource = dt
                    End If
                End If


                If cbobg.Text = "A-" Then
                    If cborequest.Text = "RBC" Then
                        cmd.CommandText = "select packid,bloodgroup,typeofpack,expirydate from rbc where bloodgroup='A-' or bloodgroup='O-' or bloodgroup='A-'"
                        myda = New SqlCeDataAdapter(cmd)
                        Dim dt As New DataTable()
                        mydataset = New DataSet()
                        myda.Fill(dt)
                        DataGridView1.AutoGenerateColumns = False
                        DataGridView1.DataSource = dt
                    End If
                End If

                If cbobg.Text = "O-" Then
                    If cborequest.Text = "RBC" Then
                        cmd.CommandText = "select packid,bloodgroup,typeofpack,expirydate from rbc where bloodgroup='O-' or bloodgroup='O-'"
                        myda = New SqlCeDataAdapter(cmd)
                        Dim dt As New DataTable()
                        mydataset = New DataSet()
                        myda.Fill(dt)
                        DataGridView1.AutoGenerateColumns = False
                        DataGridView1.DataSource = dt
                    End If
                End If
                If cbobg.Text = "O+" Then
                    If cborequest.Text = "RBC" Then
                        cmd.CommandText = "select packid,bloodgroup,typeofpack,expirydate from rbc where bloodgroup='O+' or bloodgroup='O-'"
                        myda = New SqlCeDataAdapter(cmd)
                        Dim dt As New DataTable()
                        mydataset = New DataSet()
                        myda.Fill(dt)
                        DataGridView1.AutoGenerateColumns = False
                        DataGridView1.DataSource = dt
                    End If
                End If

                If cbobg.Text = "B+" Then
                    If cborequest.Text = "RBC" Then
                    End If
                    cmd.CommandText = "select packid,bloodgroup,typeofpack,expirydate from rbc where bloodgroup='B-' or bloodgroup='O+' or bloodgroup='O-' or bloodgroup='B+'"
                    myda = New SqlCeDataAdapter(cmd)
                    Dim dt As New DataTable()
                    mydataset = New DataSet()
                    myda.Fill(dt)
                    DataGridView1.AutoGenerateColumns = True

                    DataGridView1.DataSource = dt
                End If
            End If
            If cbobg.Text = "B-" Then
                If cborequest.Text = "RBC" Then
                    cmd.CommandText = "select packid,bloodgroup,typeofpack,expirydate from rbc where bloodgroup='B-' or bloodgroup='O-'"
                    myda = New SqlCeDataAdapter(cmd)
                    Dim dt As New DataTable()
                    mydataset = New DataSet()
                    myda.Fill(dt)
                    DataGridView1.AutoGenerateColumns = False
                    DataGridView1.DataSource = dt
                End If
            End If
            If cbobg.Text = "AB-" Then
                If cborequest.Text = "RBC" Then
                    cmd.CommandText = "select packid,bloodgroup,typeofpack,expirydate from rbc where bloodgroup='AB-' or bloodgroup='O+' or bloodgroup='O-' or bloodgroup='B-'"
                    myda = New SqlCeDataAdapter(cmd)
                    Dim dt As New DataTable()
                    mydataset = New DataSet()
                    myda.Fill(dt)
                    DataGridView1.AutoGenerateColumns = False
                    DataGridView1.DataSource = dt
                End If
            End If
            If cbobg.Text = "AB+" Then
                If cborequest.Text = "RBC" Then

                End If
                cmd.CommandText = "select packid,bloodgroup,typeofpack,expirydate from rbc where bloodgroup='A+' or bloodgroup='A-' or bloodgroup='B+' or bloodgroup='B-' or bloodgroup='O-' or bloodgroup='O+' or bloodgroup='AB+' or bloodgroup='AB-'"
                myda = New SqlCeDataAdapter(cmd)
                Dim dt As New DataTable()
                mydataset = New DataSet()
                myda.Fill(dt)
                DataGridView1.AutoGenerateColumns = True

                DataGridView1.DataSource = dt
            End If
        End If
        con.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        Me.TextBox2.Text = DataGridView1.Item(0, i).Value

    End Sub

    Private Sub btnissue_Click(sender As Object, e As System.EventArgs) Handles btnissue.Click
        Dim con As New SqlCeConnection("Data Source=c:\users\pattabi.abbu\documents\visual studio 2010\Projects\bloodbank\bloodbank\bloodbank.sdf")
        Dim cmd As New SqlCeCommand("insert into request values('" & txtpatient.Text & "','" & txtptname.Text & "','" & txtage.Text & "','" & txtphone.Text & "','" & txthospital.Text & "','" & txtaddress.Text & "','" & cbobg.Text & "','" & cborequest.Text & "','" & txtpack.Text & "','" & cbopurpose.Text & "','" & txtrequired.Text & "','" & txtrqdate.Text & "','" & TextBox1.Text & "')", con)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("BLOOD ISSUED")
        btnissue.Visible = True
        DataGridView1.Show()

        

    End Sub

    Private Sub txtrequired_GotFocus(sender As Object, e As System.EventArgs) Handles txtrequired.GotFocus
        txtrequired.Text = Date.Today

    End Sub

    
    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class