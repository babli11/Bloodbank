<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdonor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmdonor))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtlbd = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtaddr = New System.Windows.Forms.TextBox()
        Me.txtmob = New System.Windows.Forms.TextBox()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtdno = New System.Windows.Forms.TextBox()
        Me.btncollecton = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtidno = New System.Windows.Forms.TextBox()
        Me.cboproof = New System.Windows.Forms.ComboBox()
        Me.cbogender = New System.Windows.Forms.ComboBox()
        Me.cbobg = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(910, 349)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AGE"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(910, 438)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ADDRESS"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(151, 241)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 58)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NAME"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(151, 346)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 76)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DONOR NO"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(151, 437)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 51)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ID PROOF"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(151, 520)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 29)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ID NO"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(151, 677)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 47)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "BLOOD GROUP"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(910, 256)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 29)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "DOB"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(910, 525)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 29)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "MOBILE NO"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(910, 604)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 29)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "E-MAIL"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(576, 65)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(295, 71)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "DONOR DETAILS"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(910, 689)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(170, 45)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "LAST BLOOD DONATED"
        '
        'txtlbd
        '
        Me.txtlbd.Location = New System.Drawing.Point(1135, 697)
        Me.txtlbd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtlbd.Name = "txtlbd"
        Me.txtlbd.Size = New System.Drawing.Size(136, 27)
        Me.txtlbd.TabIndex = 12
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(1135, 604)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(136, 27)
        Me.txtemail.TabIndex = 13
        '
        'txtaddr
        '
        Me.txtaddr.Location = New System.Drawing.Point(1135, 444)
        Me.txtaddr.Margin = New System.Windows.Forms.Padding(4)
        Me.txtaddr.Name = "txtaddr"
        Me.txtaddr.Size = New System.Drawing.Size(136, 27)
        Me.txtaddr.TabIndex = 14
        '
        'txtmob
        '
        Me.txtmob.Location = New System.Drawing.Point(1135, 522)
        Me.txtmob.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmob.Name = "txtmob"
        Me.txtmob.Size = New System.Drawing.Size(136, 27)
        Me.txtmob.TabIndex = 17
        '
        'txtage
        '
        Me.txtage.Location = New System.Drawing.Point(1135, 343)
        Me.txtage.Margin = New System.Windows.Forms.Padding(4)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(136, 27)
        Me.txtage.TabIndex = 18
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(372, 256)
        Me.txtname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(136, 27)
        Me.txtname.TabIndex = 21
        '
        'txtdno
        '
        Me.txtdno.Location = New System.Drawing.Point(372, 349)
        Me.txtdno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdno.Name = "txtdno"
        Me.txtdno.Size = New System.Drawing.Size(136, 27)
        Me.txtdno.TabIndex = 22
        '
        'btncollecton
        '
        Me.btncollecton.Location = New System.Drawing.Point(615, 428)
        Me.btncollecton.Name = "btncollecton"
        Me.btncollecton.Size = New System.Drawing.Size(166, 39)
        Me.btncollecton.TabIndex = 25
        Me.btncollecton.Text = "COLLECTION"
        Me.btncollecton.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(615, 320)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(132, 40)
        Me.btnsave.TabIndex = 26
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(629, 525)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(118, 50)
        Me.btnexit.TabIndex = 27
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(1208, 75)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 20)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "DATE"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(1364, 75)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(0, 20)
        Me.Label15.TabIndex = 29
        '
        'lbldate
        '
        Me.lbldate.Location = New System.Drawing.Point(1335, 75)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(117, 33)
        Me.lbldate.TabIndex = 30
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(151, 604)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(108, 29)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "GENDER"
        '
        'txtidno
        '
        Me.txtidno.Location = New System.Drawing.Point(372, 522)
        Me.txtidno.Name = "txtidno"
        Me.txtidno.Size = New System.Drawing.Size(136, 27)
        Me.txtidno.TabIndex = 32
        '
        'cboproof
        '
        Me.cboproof.FormattingEnabled = True
        Me.cboproof.Items.AddRange(New Object() {"ADDHAR CARD", "IDENTITY CARD", "PAN CARD"})
        Me.cboproof.Location = New System.Drawing.Point(372, 444)
        Me.cboproof.Name = "cboproof"
        Me.cboproof.Size = New System.Drawing.Size(136, 28)
        Me.cboproof.TabIndex = 33
        '
        'cbogender
        '
        Me.cbogender.FormattingEnabled = True
        Me.cbogender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.cbogender.Location = New System.Drawing.Point(372, 603)
        Me.cbogender.Name = "cbogender"
        Me.cbogender.Size = New System.Drawing.Size(136, 28)
        Me.cbogender.TabIndex = 34
        '
        'cbobg
        '
        Me.cbobg.FormattingEnabled = True
        Me.cbobg.Items.AddRange(New Object() {"A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-"})
        Me.cbobg.Location = New System.Drawing.Point(372, 689)
        Me.cbobg.Name = "cbobg"
        Me.cbobg.Size = New System.Drawing.Size(136, 28)
        Me.cbobg.TabIndex = 35
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(1135, 254)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 27)
        Me.DateTimePicker1.TabIndex = 36
        '
        'frmdonor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1492, 1037)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.cbobg)
        Me.Controls.Add(Me.cbogender)
        Me.Controls.Add(Me.cboproof)
        Me.Controls.Add(Me.txtidno)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btncollecton)
        Me.Controls.Add(Me.txtdno)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.txtmob)
        Me.Controls.Add(Me.txtaddr)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtlbd)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmdonor"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "DONOR FORM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtlbd As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtaddr As System.Windows.Forms.TextBox
    Friend WithEvents txtmob As System.Windows.Forms.TextBox
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtdno As System.Windows.Forms.TextBox
    Friend WithEvents btncollecton As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtidno As System.Windows.Forms.TextBox
    Friend WithEvents cboproof As System.Windows.Forms.ComboBox
    Friend WithEvents cbogender As System.Windows.Forms.ComboBox
    Friend WithEvents cbobg As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
