<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbarcode
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
        Me.txtcode = New System.Windows.Forms.TextBox()
        Me.btngen = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picbar = New System.Windows.Forms.PictureBox()
        Me.checkbtn = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picbar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtcode
        '
        Me.txtcode.Location = New System.Drawing.Point(52, 135)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(427, 22)
        Me.txtcode.TabIndex = 0
        '
        'btngen
        '
        Me.btngen.Location = New System.Drawing.Point(523, 134)
        Me.btngen.Name = "btngen"
        Me.btngen.Size = New System.Drawing.Size(121, 23)
        Me.btngen.TabIndex = 1
        Me.btngen.Text = "GENERATE"
        Me.btngen.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(251, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "WELCOME TO BARCODE GENERATOR"
        '
        'picbar
        '
        Me.picbar.Location = New System.Drawing.Point(12, 203)
        Me.picbar.Name = "picbar"
        Me.picbar.Size = New System.Drawing.Size(713, 359)
        Me.picbar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbar.TabIndex = 3
        Me.picbar.TabStop = False
        '
        'checkbtn
        '
        Me.checkbtn.Enabled = True
        Me.checkbtn.Interval = 1
        '
        'frmbarcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 569)
        Me.Controls.Add(Me.picbar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btngen)
        Me.Controls.Add(Me.txtcode)
        Me.Name = "frmbarcode"
        Me.Text = "barcodegenerator"
        CType(Me.picbar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents btngen As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picbar As System.Windows.Forms.PictureBox
    Friend WithEvents checkbtn As System.Windows.Forms.Timer
End Class
