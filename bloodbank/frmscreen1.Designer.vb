<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmscreen1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmscreen1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cbobg = New System.Windows.Forms.ComboBox()
        Me.cboproof = New System.Windows.Forms.ComboBox()
        Me.txtidno = New System.Windows.Forms.TextBox()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtelg = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbobp = New System.Windows.Forms.ComboBox()
        Me.cbohepc = New System.Windows.Forms.ComboBox()
        Me.cbohepb = New System.Windows.Forms.ComboBox()
        Me.cbohiv = New System.Windows.Forms.ComboBox()
        Me.txthg = New System.Windows.Forms.TextBox()
        Me.txttemp = New System.Windows.Forms.TextBox()
        Me.txtpr = New System.Windows.Forms.TextBox()
        Me.txtwt = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.txtweight = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(563, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(487, 53)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SCREENING DETAILS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(209, 290)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(166, 22)
        Me.DateTimePicker1.TabIndex = 7
        '
        'cbobg
        '
        Me.cbobg.FormattingEnabled = True
        Me.cbobg.Items.AddRange(New Object() {"A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-"})
        Me.cbobg.Location = New System.Drawing.Point(1052, 385)
        Me.cbobg.Name = "cbobg"
        Me.cbobg.Size = New System.Drawing.Size(121, 24)
        Me.cbobg.TabIndex = 12
        '
        'cboproof
        '
        Me.cboproof.FormattingEnabled = True
        Me.cboproof.Items.AddRange(New Object() {"AADHAR CARD", "IDENTITY CARD", "PAN CARD"})
        Me.cboproof.Location = New System.Drawing.Point(1052, 233)
        Me.cboproof.Name = "cboproof"
        Me.cboproof.Size = New System.Drawing.Size(121, 24)
        Me.cboproof.TabIndex = 11
        '
        'txtidno
        '
        Me.txtidno.Location = New System.Drawing.Point(1061, 309)
        Me.txtidno.Name = "txtidno"
        Me.txtidno.Size = New System.Drawing.Size(100, 22)
        Me.txtidno.TabIndex = 9
        '
        'txtage
        '
        Me.txtage.Location = New System.Drawing.Point(209, 387)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(100, 22)
        Me.txtage.TabIndex = 8
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(209, 233)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(100, 22)
        Me.txtname.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(758, 371)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 55)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "BLOOD GROUP"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(758, 305)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 31)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = " ID NO"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(758, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 41)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "ID PROOF"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 371)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 58)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "AGE"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 288)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 48)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "DOB"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 40)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "NAME"
        '
        'txtelg
        '
        Me.txtelg.Location = New System.Drawing.Point(606, 882)
        Me.txtelg.Name = "txtelg"
        Me.txtelg.Size = New System.Drawing.Size(100, 22)
        Me.txtelg.TabIndex = 17
        Me.txtelg.Text = "txtet"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(343, 865)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(186, 53)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "ELIGIBILITY TEST"
        '
        'cbobp
        '
        Me.cbobp.FormattingEnabled = True
        Me.cbobp.Items.AddRange(New Object() {"high", "normal", "low"})
        Me.cbobp.Location = New System.Drawing.Point(1061, 571)
        Me.cbobp.Name = "cbobp"
        Me.cbobp.Size = New System.Drawing.Size(121, 24)
        Me.cbobp.TabIndex = 15
        Me.cbobp.Text = "cbobp"
        '
        'cbohepc
        '
        Me.cbohepc.FormattingEnabled = True
        Me.cbohepc.Items.AddRange(New Object() {"yes", "no"})
        Me.cbohepc.Location = New System.Drawing.Point(222, 729)
        Me.cbohepc.Name = "cbohepc"
        Me.cbohepc.Size = New System.Drawing.Size(121, 24)
        Me.cbohepc.TabIndex = 14
        '
        'cbohepb
        '
        Me.cbohepb.FormattingEnabled = True
        Me.cbohepb.Items.AddRange(New Object() {"yes", "no"})
        Me.cbohepb.Location = New System.Drawing.Point(209, 656)
        Me.cbohepb.Name = "cbohepb"
        Me.cbohepb.Size = New System.Drawing.Size(121, 24)
        Me.cbohepb.TabIndex = 13
        '
        'cbohiv
        '
        Me.cbohiv.FormattingEnabled = True
        Me.cbohiv.Items.AddRange(New Object() {"yes", "no"})
        Me.cbohiv.Location = New System.Drawing.Point(209, 575)
        Me.cbohiv.Name = "cbohiv"
        Me.cbohiv.Size = New System.Drawing.Size(121, 24)
        Me.cbohiv.TabIndex = 12
        '
        'txthg
        '
        Me.txthg.Location = New System.Drawing.Point(1061, 729)
        Me.txthg.Name = "txthg"
        Me.txthg.Size = New System.Drawing.Size(100, 22)
        Me.txthg.TabIndex = 11
        Me.txthg.Text = "txthg"
        '
        'txttemp
        '
        Me.txttemp.Location = New System.Drawing.Point(1061, 470)
        Me.txttemp.Name = "txttemp"
        Me.txttemp.Size = New System.Drawing.Size(100, 22)
        Me.txttemp.TabIndex = 10
        '
        'txtpr
        '
        Me.txtpr.Location = New System.Drawing.Point(1061, 645)
        Me.txtpr.Name = "txtpr"
        Me.txtpr.Size = New System.Drawing.Size(100, 22)
        Me.txtpr.TabIndex = 9
        Me.txtpr.Text = "txtpr"
        '
        'txtwt
        '
        Me.txtwt.Location = New System.Drawing.Point(209, 470)
        Me.txtwt.Name = "txtwt"
        Me.txtwt.Size = New System.Drawing.Size(100, 22)
        Me.txtwt.TabIndex = 8
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(27, 466)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(139, 48)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "WEIGHT"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(763, 725)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(172, 36)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "HEMOGLOBIN"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(758, 641)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(177, 39)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "PULSE RATE"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(758, 547)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(147, 52)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "BLOOD PRESSURE"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(758, 455)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(222, 48)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "TEMPARATURE"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(27, 738)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 27)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "HEPC"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(27, 652)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 55)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "HEPB"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 571)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 52)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "HIV"
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(1375, 530)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(201, 46)
        Me.btnexit.TabIndex = 3
        Me.btnexit.Text = "CANCEL"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(1357, 371)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(219, 49)
        Me.btnsave.TabIndex = 4
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'txtweight
        '
        Me.txtweight.Location = New System.Drawing.Point(272, 44)
        Me.txtweight.Name = "txtweight"
        Me.txtweight.Size = New System.Drawing.Size(100, 22)
        Me.txtweight.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(1287, 102)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(134, 23)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "DATE"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Location = New System.Drawing.Point(1443, 102)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(0, 17)
        Me.lbldate.TabIndex = 6
        '
        'frmscreen1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1641, 1037)
        Me.Controls.Add(Me.txtelg)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txthg)
        Me.Controls.Add(Me.cbobp)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtpr)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbohepc)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txttemp)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.cbohepb)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cbobg)
        Me.Controls.Add(Me.cbohiv)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtidno)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtwt)
        Me.Controls.Add(Me.cboproof)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Name = "frmscreen1"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbobg As System.Windows.Forms.ComboBox
    Friend WithEvents cboproof As System.Windows.Forms.ComboBox
    Friend WithEvents txtidno As System.Windows.Forms.TextBox
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtelg As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cbobp As System.Windows.Forms.ComboBox
    Friend WithEvents cbohepc As System.Windows.Forms.ComboBox
    Friend WithEvents cbohepb As System.Windows.Forms.ComboBox
    Friend WithEvents cbohiv As System.Windows.Forms.ComboBox
    Friend WithEvents txthg As System.Windows.Forms.TextBox
    Friend WithEvents txttemp As System.Windows.Forms.TextBox
    Friend WithEvents txtpr As System.Windows.Forms.TextBox
    Friend WithEvents txtwt As System.Windows.Forms.TextBox
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents txtweight As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
