<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcomponetsinsert
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbobg = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdate = New System.Windows.Forms.TextBox()
        Me.txtexp1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtexp3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtexp2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtqt1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtqt2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtqt3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtpackid = New System.Windows.Forms.TextBox()
        Me.txttypeofpack = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BLOOD GROUP"
        '
        'cbobg
        '
        Me.cbobg.FormattingEnabled = True
        Me.cbobg.Items.AddRange(New Object() {"A+", "B+", "AB+", "O+", "A-", "B-", "AB-", "O-"})
        Me.cbobg.Location = New System.Drawing.Point(285, 126)
        Me.cbobg.Name = "cbobg"
        Me.cbobg.Size = New System.Drawing.Size(121, 24)
        Me.cbobg.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(96, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "DATE"
        '
        'txtdate
        '
        Me.txtdate.Location = New System.Drawing.Point(285, 199)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(100, 22)
        Me.txtdate.TabIndex = 3
        '
        'txtexp1
        '
        Me.txtexp1.Location = New System.Drawing.Point(285, 282)
        Me.txtexp1.Name = "txtexp1"
        Me.txtexp1.Size = New System.Drawing.Size(100, 22)
        Me.txtexp1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(96, 282)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "EXPIRY OF RBC"
        '
        'txtexp3
        '
        Me.txtexp3.Location = New System.Drawing.Point(285, 348)
        Me.txtexp3.Name = "txtexp3"
        Me.txtexp3.Size = New System.Drawing.Size(100, 22)
        Me.txtexp3.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(96, 348)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "EXPIRY OF PLASMA"
        '
        'txtexp2
        '
        Me.txtexp2.Location = New System.Drawing.Point(285, 406)
        Me.txtexp2.Name = "txtexp2"
        Me.txtexp2.Size = New System.Drawing.Size(100, 22)
        Me.txtexp2.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(94, 406)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "EXPIRY OF PLATELETS"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(457, 80)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(660, 196)
        Me.DataGridView1.TabIndex = 10
        '
        'txtqt1
        '
        Me.txtqt1.Location = New System.Drawing.Point(285, 460)
        Me.txtqt1.Name = "txtqt1"
        Me.txtqt1.Size = New System.Drawing.Size(100, 22)
        Me.txtqt1.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(96, 460)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = " RBC QUANTITY"
        '
        'txtqt2
        '
        Me.txtqt2.Location = New System.Drawing.Point(285, 540)
        Me.txtqt2.Name = "txtqt2"
        Me.txtqt2.Size = New System.Drawing.Size(100, 22)
        Me.txtqt2.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(96, 543)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(179, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "PLATELETS QUANTITY"
        '
        'txtqt3
        '
        Me.txtqt3.Location = New System.Drawing.Point(285, 605)
        Me.txtqt3.Name = "txtqt3"
        Me.txtqt3.Size = New System.Drawing.Size(100, 22)
        Me.txtqt3.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(96, 608)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "PLASMA QUANTITY"
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(617, 353)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(126, 51)
        Me.btnsave.TabIndex = 17
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(542, 499)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 17)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "PACKID"
        '
        'txtpackid
        '
        Me.txtpackid.Location = New System.Drawing.Point(679, 494)
        Me.txtpackid.Name = "txtpackid"
        Me.txtpackid.Size = New System.Drawing.Size(100, 22)
        Me.txtpackid.TabIndex = 19
        '
        'txttypeofpack
        '
        Me.txttypeofpack.Location = New System.Drawing.Point(679, 580)
        Me.txttypeofpack.Name = "txttypeofpack"
        Me.txttypeofpack.Size = New System.Drawing.Size(100, 22)
        Me.txttypeofpack.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(533, 580)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 17)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "TYPE OF PACK"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(880, 353)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 51)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "CANCEL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmcomponetsinsert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1548, 729)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txttypeofpack)
        Me.Controls.Add(Me.txtpackid)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtqt3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtqt2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtqt1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtexp2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtexp3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtexp1)
        Me.Controls.Add(Me.txtdate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbobg)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmcomponetsinsert"
        Me.Text = "frmcomponetsinsert"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbobg As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtdate As System.Windows.Forms.TextBox
    Friend WithEvents txtexp1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtexp3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtexp2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtqt1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtqt2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtqt3 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtpackid As System.Windows.Forms.TextBox
    Friend WithEvents txttypeofpack As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
