<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrequest
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.txtptname = New System.Windows.Forms.TextBox()
        Me.txtpatient = New System.Windows.Forms.TextBox()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.txthospital = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.cborequest = New System.Windows.Forms.ComboBox()
        Me.cbobg = New System.Windows.Forms.ComboBox()
        Me.txtpack = New System.Windows.Forms.TextBox()
        Me.cbopurpose = New System.Windows.Forms.ComboBox()
        Me.txtrequired = New System.Windows.Forms.DateTimePicker()
        Me.txtrqdate = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PATIENTIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PATIENTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AGEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PHONENODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HOSPITALNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BLOODGROUPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQUESTCOMPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOOFPACKSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PURPOSEOFBLOODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BLOODISSUEDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PACKIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BLOODREQUESTDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RequestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BloodbankDataSet1 = New bloodbank.bloodbankDataSet1()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnissue = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.RequestTableAdapter = New bloodbank.bloodbankDataSet1TableAdapters.requestTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BloodbankDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(140, 518)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PURPOSE OF BLOOD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(148, 423)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "REQUEST COMPONENTS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(156, 319)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ADDRESS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(157, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = " "
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(152, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = " PATIENT ID"
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(130, 164)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(314, 23)
        Me.label6.TabIndex = 5
        Me.label6.Text = " "
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(41, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(988, 75)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = " "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(157, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = " "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(156, 280)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "HOSPITAL NAME"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(148, 368)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 17)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "BLOOD GROUP"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(149, 470)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 17)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "NO OF PACKS"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(156, 630)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 17)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "REQUEST DATE"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(140, 575)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(158, 17)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "BLOOD ISSUE DATE"
        '
        'txtage
        '
        Me.txtage.Location = New System.Drawing.Point(530, 201)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(112, 22)
        Me.txtage.TabIndex = 14
        '
        'txtptname
        '
        Me.txtptname.Location = New System.Drawing.Point(530, 161)
        Me.txtptname.Name = "txtptname"
        Me.txtptname.Size = New System.Drawing.Size(112, 22)
        Me.txtptname.TabIndex = 15
        '
        'txtpatient
        '
        Me.txtpatient.Location = New System.Drawing.Point(530, 110)
        Me.txtpatient.Name = "txtpatient"
        Me.txtpatient.Size = New System.Drawing.Size(112, 22)
        Me.txtpatient.TabIndex = 16
        '
        'txtphone
        '
        Me.txtphone.Location = New System.Drawing.Point(530, 239)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(112, 22)
        Me.txtphone.TabIndex = 17
        '
        'txthospital
        '
        Me.txthospital.Location = New System.Drawing.Point(521, 277)
        Me.txthospital.Name = "txthospital"
        Me.txthospital.Size = New System.Drawing.Size(121, 22)
        Me.txthospital.TabIndex = 18
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(521, 319)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(121, 22)
        Me.txtaddress.TabIndex = 19
        '
        'cborequest
        '
        Me.cborequest.FormattingEnabled = True
        Me.cborequest.Items.AddRange(New Object() {"RBC", "PLATELETS", "PLASMA", "BLOOD"})
        Me.cborequest.Location = New System.Drawing.Point(521, 406)
        Me.cborequest.Name = "cborequest"
        Me.cborequest.Size = New System.Drawing.Size(121, 24)
        Me.cborequest.TabIndex = 20
        '
        'cbobg
        '
        Me.cbobg.FormattingEnabled = True
        Me.cbobg.Items.AddRange(New Object() {"A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-"})
        Me.cbobg.Location = New System.Drawing.Point(521, 361)
        Me.cbobg.Name = "cbobg"
        Me.cbobg.Size = New System.Drawing.Size(121, 24)
        Me.cbobg.TabIndex = 21
        '
        'txtpack
        '
        Me.txtpack.Location = New System.Drawing.Point(510, 465)
        Me.txtpack.Name = "txtpack"
        Me.txtpack.Size = New System.Drawing.Size(132, 22)
        Me.txtpack.TabIndex = 23
        '
        'cbopurpose
        '
        Me.cbopurpose.FormattingEnabled = True
        Me.cbopurpose.Location = New System.Drawing.Point(521, 511)
        Me.cbopurpose.Name = "cbopurpose"
        Me.cbopurpose.Size = New System.Drawing.Size(121, 24)
        Me.cbopurpose.TabIndex = 24
        '
        'txtrequired
        '
        Me.txtrequired.Location = New System.Drawing.Point(483, 558)
        Me.txtrequired.Name = "txtrequired"
        Me.txtrequired.Size = New System.Drawing.Size(200, 22)
        Me.txtrequired.TabIndex = 25
        '
        'txtrqdate
        '
        Me.txtrqdate.Location = New System.Drawing.Point(483, 625)
        Me.txtrqdate.Name = "txtrqdate"
        Me.txtrqdate.Size = New System.Drawing.Size(200, 22)
        Me.txtrqdate.TabIndex = 26
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(157, 674)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 17)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "packid"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(94, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(766, 49)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "BLOOD REQUEST"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(149, 164)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(155, 23)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "PATIENT NAME"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(157, 201)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(100, 23)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "AGE"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(149, 242)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(136, 19)
        Me.Label20.TabIndex = 34
        Me.Label20.Text = "PHONE NUMBER"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PATIENTIDDataGridViewTextBoxColumn, Me.PATIENTNAMEDataGridViewTextBoxColumn, Me.AGEDataGridViewTextBoxColumn, Me.PHONENODataGridViewTextBoxColumn, Me.HOSPITALNAMEDataGridViewTextBoxColumn, Me.ADDRESSDataGridViewTextBoxColumn, Me.BLOODGROUPDataGridViewTextBoxColumn, Me.REQUESTCOMPDataGridViewTextBoxColumn, Me.NOOFPACKSDataGridViewTextBoxColumn, Me.PURPOSEOFBLOODDataGridViewTextBoxColumn, Me.BLOODISSUEDATEDataGridViewTextBoxColumn, Me.PACKIDDataGridViewTextBoxColumn, Me.BLOODREQUESTDATEDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RequestBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(749, 122)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(638, 263)
        Me.DataGridView1.TabIndex = 35
        '
        'PATIENTIDDataGridViewTextBoxColumn
        '
        Me.PATIENTIDDataGridViewTextBoxColumn.DataPropertyName = "PATIENT ID"
        Me.PATIENTIDDataGridViewTextBoxColumn.HeaderText = "PATIENT ID"
        Me.PATIENTIDDataGridViewTextBoxColumn.Name = "PATIENTIDDataGridViewTextBoxColumn"
        '
        'PATIENTNAMEDataGridViewTextBoxColumn
        '
        Me.PATIENTNAMEDataGridViewTextBoxColumn.DataPropertyName = "PATIENT NAME"
        Me.PATIENTNAMEDataGridViewTextBoxColumn.HeaderText = "PATIENT NAME"
        Me.PATIENTNAMEDataGridViewTextBoxColumn.Name = "PATIENTNAMEDataGridViewTextBoxColumn"
        '
        'AGEDataGridViewTextBoxColumn
        '
        Me.AGEDataGridViewTextBoxColumn.DataPropertyName = "AGE"
        Me.AGEDataGridViewTextBoxColumn.HeaderText = "AGE"
        Me.AGEDataGridViewTextBoxColumn.Name = "AGEDataGridViewTextBoxColumn"
        '
        'PHONENODataGridViewTextBoxColumn
        '
        Me.PHONENODataGridViewTextBoxColumn.DataPropertyName = "PHONE NO"
        Me.PHONENODataGridViewTextBoxColumn.HeaderText = "PHONE NO"
        Me.PHONENODataGridViewTextBoxColumn.Name = "PHONENODataGridViewTextBoxColumn"
        '
        'HOSPITALNAMEDataGridViewTextBoxColumn
        '
        Me.HOSPITALNAMEDataGridViewTextBoxColumn.DataPropertyName = "HOSPITAL NAME"
        Me.HOSPITALNAMEDataGridViewTextBoxColumn.HeaderText = "HOSPITAL NAME"
        Me.HOSPITALNAMEDataGridViewTextBoxColumn.Name = "HOSPITALNAMEDataGridViewTextBoxColumn"
        '
        'ADDRESSDataGridViewTextBoxColumn
        '
        Me.ADDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.Name = "ADDRESSDataGridViewTextBoxColumn"
        '
        'BLOODGROUPDataGridViewTextBoxColumn
        '
        Me.BLOODGROUPDataGridViewTextBoxColumn.DataPropertyName = "BLOOD GROUP"
        Me.BLOODGROUPDataGridViewTextBoxColumn.HeaderText = "BLOOD GROUP"
        Me.BLOODGROUPDataGridViewTextBoxColumn.Name = "BLOODGROUPDataGridViewTextBoxColumn"
        '
        'REQUESTCOMPDataGridViewTextBoxColumn
        '
        Me.REQUESTCOMPDataGridViewTextBoxColumn.DataPropertyName = "REQUEST COMP"
        Me.REQUESTCOMPDataGridViewTextBoxColumn.HeaderText = "REQUEST COMP"
        Me.REQUESTCOMPDataGridViewTextBoxColumn.Name = "REQUESTCOMPDataGridViewTextBoxColumn"
        '
        'NOOFPACKSDataGridViewTextBoxColumn
        '
        Me.NOOFPACKSDataGridViewTextBoxColumn.DataPropertyName = "NO OF PACKS"
        Me.NOOFPACKSDataGridViewTextBoxColumn.HeaderText = "NO OF PACKS"
        Me.NOOFPACKSDataGridViewTextBoxColumn.Name = "NOOFPACKSDataGridViewTextBoxColumn"
        '
        'PURPOSEOFBLOODDataGridViewTextBoxColumn
        '
        Me.PURPOSEOFBLOODDataGridViewTextBoxColumn.DataPropertyName = "PURPOSE OF BLOOD"
        Me.PURPOSEOFBLOODDataGridViewTextBoxColumn.HeaderText = "PURPOSE OF BLOOD"
        Me.PURPOSEOFBLOODDataGridViewTextBoxColumn.Name = "PURPOSEOFBLOODDataGridViewTextBoxColumn"
        '
        'BLOODISSUEDATEDataGridViewTextBoxColumn
        '
        Me.BLOODISSUEDATEDataGridViewTextBoxColumn.DataPropertyName = "BLOOD ISSUE DATE"
        Me.BLOODISSUEDATEDataGridViewTextBoxColumn.HeaderText = "BLOOD ISSUE DATE"
        Me.BLOODISSUEDATEDataGridViewTextBoxColumn.Name = "BLOODISSUEDATEDataGridViewTextBoxColumn"
        '
        'PACKIDDataGridViewTextBoxColumn
        '
        Me.PACKIDDataGridViewTextBoxColumn.DataPropertyName = "PACKID"
        Me.PACKIDDataGridViewTextBoxColumn.HeaderText = "PACKID"
        Me.PACKIDDataGridViewTextBoxColumn.Name = "PACKIDDataGridViewTextBoxColumn"
        '
        'BLOODREQUESTDATEDataGridViewTextBoxColumn
        '
        Me.BLOODREQUESTDATEDataGridViewTextBoxColumn.DataPropertyName = "BLOOD REQUEST DATE"
        Me.BLOODREQUESTDATEDataGridViewTextBoxColumn.HeaderText = "BLOOD REQUEST DATE"
        Me.BLOODREQUESTDATEDataGridViewTextBoxColumn.Name = "BLOODREQUESTDATEDataGridViewTextBoxColumn"
        '
        'RequestBindingSource
        '
        Me.RequestBindingSource.DataMember = "request"
        Me.RequestBindingSource.DataSource = Me.BloodbankDataSet1
        '
        'BloodbankDataSet1
        '
        Me.BloodbankDataSet1.DataSetName = "bloodbankDataSet1"
        Me.BloodbankDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(1140, 68)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 36
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnissue
        '
        Me.btnissue.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnissue.Location = New System.Drawing.Point(764, 61)
        Me.btnissue.Name = "btnissue"
        Me.btnissue.Size = New System.Drawing.Size(75, 23)
        Me.btnissue.TabIndex = 37
        Me.btnissue.Text = "ISSUE"
        Me.btnissue.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(530, 671)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 38
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(739, 439)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(451, 22)
        Me.TextBox2.TabIndex = 39
        '
        'RequestTableAdapter
        '
        Me.RequestTableAdapter.ClearBeforeFill = True
        '
        'frmrequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1442, 744)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnissue)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtrqdate)
        Me.Controls.Add(Me.txtrequired)
        Me.Controls.Add(Me.cbopurpose)
        Me.Controls.Add(Me.txtpack)
        Me.Controls.Add(Me.cbobg)
        Me.Controls.Add(Me.cborequest)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.txthospital)
        Me.Controls.Add(Me.txtphone)
        Me.Controls.Add(Me.txtpatient)
        Me.Controls.Add(Me.txtptname)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmrequest"
        Me.Text = "request form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BloodbankDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents txtptname As System.Windows.Forms.TextBox
    Friend WithEvents txtpatient As System.Windows.Forms.TextBox
    Friend WithEvents txtphone As System.Windows.Forms.TextBox
    Friend WithEvents txthospital As System.Windows.Forms.TextBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents cborequest As System.Windows.Forms.ComboBox
    Friend WithEvents cbobg As System.Windows.Forms.ComboBox
    Friend WithEvents txtpack As System.Windows.Forms.TextBox
    Friend WithEvents cbopurpose As System.Windows.Forms.ComboBox
    Friend WithEvents txtrequired As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtrqdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnissue As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents BloodbankDataSet1 As bloodbank.bloodbankDataSet1
    Friend WithEvents RequestBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RequestTableAdapter As bloodbank.bloodbankDataSet1TableAdapters.requestTableAdapter
    Friend WithEvents PATIENTIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PATIENTNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AGEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PHONENODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HOSPITALNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ADDRESSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BLOODGROUPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REQUESTCOMPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOOFPACKSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PURPOSEOFBLOODDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BLOODISSUEDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PACKIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BLOODREQUESTDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
