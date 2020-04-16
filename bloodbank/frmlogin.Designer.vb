<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmlogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.cmdbtn = New System.Windows.Forms.Button()
        Me.cmdbt = New System.Windows.Forms.Button()
        Me.cmdexit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Algerian", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label1.Location = New System.Drawing.Point(460, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(635, 92)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BLOOD BANK LOGIN FORM"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(138, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(305, 65)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "USERNAME"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(139, 343)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(249, 56)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PASSWORD"
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(446, 240)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(150, 22)
        Me.txtuser.TabIndex = 3
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(446, 343)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(150, 22)
        Me.txtpass.TabIndex = 4
        '
        'cmdbtn
        '
        Me.cmdbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdbtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdbtn.ForeColor = System.Drawing.Color.SaddleBrown
        Me.cmdbtn.Location = New System.Drawing.Point(143, 483)
        Me.cmdbtn.Name = "cmdbtn"
        Me.cmdbtn.Size = New System.Drawing.Size(203, 75)
        Me.cmdbtn.TabIndex = 5
        Me.cmdbtn.Text = "LOGIN"
        Me.cmdbtn.UseVisualStyleBackColor = False
        '
        'cmdbt
        '
        Me.cmdbt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdbt.Location = New System.Drawing.Point(456, 418)
        Me.cmdbt.Name = "cmdbt"
        Me.cmdbt.Size = New System.Drawing.Size(203, 38)
        Me.cmdbt.TabIndex = 5
        Me.cmdbt.Text = "LOGIN"
        Me.cmdbt.UseVisualStyleBackColor = True
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdexit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.Maroon
        Me.cmdexit.Location = New System.Drawing.Point(456, 493)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(194, 65)
        Me.cmdexit.TabIndex = 6
        Me.cmdexit.Text = "EXIT"
        Me.cmdexit.UseVisualStyleBackColor = False
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1481, 750)
        Me.Controls.Add(Me.cmdexit)
        Me.Controls.Add(Me.cmdbtn)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmlogin"
        Me.Text = "frmlogin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents cmdbtn As System.Windows.Forms.Button
    Friend WithEvents cmdbt As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
End Class
