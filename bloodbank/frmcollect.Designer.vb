<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcollect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcollect))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbodno = New System.Windows.Forms.ComboBox()
        Me.cbobg = New System.Windows.Forms.ComboBox()
        Me.cbopack = New System.Windows.Forms.ComboBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtpid = New System.Windows.Forms.TextBox()
        Me.txteod = New System.Windows.Forms.TextBox()
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btncheck = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 482)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TYPE OF PACK"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 407)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "BLOOD GROUP"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 313)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 26)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "NAME"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(795, 398)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "EXPIRY DATE"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(795, 329)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(224, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "COLLECTION DATE"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(795, 257)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "QUANTITY"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(795, 480)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "PACK ID"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(566, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(377, 32)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "BLOOD COLLECTION DETAILS"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 237)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 28)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "DONOR NO"
        '
        'cbodno
        '
        Me.cbodno.FormattingEnabled = True
        Me.cbodno.Location = New System.Drawing.Point(351, 241)
        Me.cbodno.Name = "cbodno"
        Me.cbodno.Size = New System.Drawing.Size(121, 24)
        Me.cbodno.TabIndex = 10
        '
        'cbobg
        '
        Me.cbobg.FormattingEnabled = True
        Me.cbobg.Location = New System.Drawing.Point(351, 402)
        Me.cbobg.Name = "cbobg"
        Me.cbobg.Size = New System.Drawing.Size(121, 24)
        Me.cbobg.TabIndex = 11
        '
        'cbopack
        '
        Me.cbopack.FormattingEnabled = True
        Me.cbopack.Items.AddRange(New Object() {"single", "double"})
        Me.cbopack.Location = New System.Drawing.Point(351, 479)
        Me.cbopack.Name = "cbopack"
        Me.cbopack.Size = New System.Drawing.Size(121, 24)
        Me.cbopack.TabIndex = 12
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(351, 317)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(100, 22)
        Me.txtname.TabIndex = 13
        '
        'txtpid
        '
        Me.txtpid.Location = New System.Drawing.Point(1070, 481)
        Me.txtpid.Name = "txtpid"
        Me.txtpid.Size = New System.Drawing.Size(100, 22)
        Me.txtpid.TabIndex = 14
        '
        'txteod
        '
        Me.txteod.Location = New System.Drawing.Point(1070, 411)
        Me.txteod.Name = "txteod"
        Me.txteod.Size = New System.Drawing.Size(100, 22)
        Me.txteod.TabIndex = 15
        '
        'txtcod
        '
        Me.txtcod.Location = New System.Drawing.Point(1070, 333)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(100, 22)
        Me.txtcod.TabIndex = 16
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(1070, 257)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(100, 22)
        Me.txtqty.TabIndex = 17
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(566, 313)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(115, 39)
        Me.btnsave.TabIndex = 18
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(557, 389)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(146, 50)
        Me.btncancel.TabIndex = 19
        Me.btncancel.Text = "CANCEL"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 542)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1182, 198)
        Me.DataGridView1.TabIndex = 20
        '
        'btncheck
        '
        Me.btncheck.AutoSize = True
        Me.btncheck.Location = New System.Drawing.Point(1345, 300)
        Me.btncheck.Name = "btncheck"
        Me.btncheck.Size = New System.Drawing.Size(75, 27)
        Me.btncheck.TabIndex = 21
        Me.btncheck.Text = "CHECK"
        Me.btncheck.UseVisualStyleBackColor = True
        '
        'frmcollect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1489, 749)
        Me.Controls.Add(Me.btncheck)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.txtcod)
        Me.Controls.Add(Me.txteod)
        Me.Controls.Add(Me.txtpid)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.cbopack)
        Me.Controls.Add(Me.cbobg)
        Me.Controls.Add(Me.cbodno)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmcollect"
        Me.Text = "frmcollect"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbodno As System.Windows.Forms.ComboBox
    Friend WithEvents cbobg As System.Windows.Forms.ComboBox
    Friend WithEvents cbopack As System.Windows.Forms.ComboBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtpid As System.Windows.Forms.TextBox
    Friend WithEvents txteod As System.Windows.Forms.TextBox
    Friend WithEvents txtcod As System.Windows.Forms.TextBox
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btncheck As System.Windows.Forms.Button
End Class
