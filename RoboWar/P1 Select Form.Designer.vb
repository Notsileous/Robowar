<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmP1Select
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmP1Select))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLite = New System.Windows.Forms.Button()
        Me.btnLiteDetails = New System.Windows.Forms.Button()
        Me.btnMidDetails = New System.Windows.Forms.Button()
        Me.btnMid = New System.Windows.Forms.Button()
        Me.btnHeavyDetails = New System.Windows.Forms.Button()
        Me.btnHeavy = New System.Windows.Forms.Button()
        Me.txtLiteDetails = New System.Windows.Forms.TextBox()
        Me.txtMidDetails = New System.Windows.Forms.TextBox()
        Me.txtHeavyDetails = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(-1, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Choose Your Fighter"
        '
        'btnLite
        '
        Me.btnLite.Location = New System.Drawing.Point(3, 430)
        Me.btnLite.Name = "btnLite"
        Me.btnLite.Size = New System.Drawing.Size(130, 23)
        Me.btnLite.TabIndex = 4
        Me.btnLite.Text = "Choose Ripper"
        Me.btnLite.UseVisualStyleBackColor = True
        '
        'btnLiteDetails
        '
        Me.btnLiteDetails.Location = New System.Drawing.Point(140, 430)
        Me.btnLiteDetails.Name = "btnLiteDetails"
        Me.btnLiteDetails.Size = New System.Drawing.Size(136, 23)
        Me.btnLiteDetails.TabIndex = 5
        Me.btnLiteDetails.Text = "Toggle Stats"
        Me.btnLiteDetails.UseVisualStyleBackColor = True
        '
        'btnMidDetails
        '
        Me.btnMidDetails.Location = New System.Drawing.Point(420, 429)
        Me.btnMidDetails.Name = "btnMidDetails"
        Me.btnMidDetails.Size = New System.Drawing.Size(136, 23)
        Me.btnMidDetails.TabIndex = 7
        Me.btnMidDetails.Text = "Toggle Stats"
        Me.btnMidDetails.UseVisualStyleBackColor = True
        '
        'btnMid
        '
        Me.btnMid.Location = New System.Drawing.Point(283, 429)
        Me.btnMid.Name = "btnMid"
        Me.btnMid.Size = New System.Drawing.Size(130, 23)
        Me.btnMid.TabIndex = 6
        Me.btnMid.Text = "Choose Static"
        Me.btnMid.UseVisualStyleBackColor = True
        '
        'btnHeavyDetails
        '
        Me.btnHeavyDetails.Location = New System.Drawing.Point(699, 429)
        Me.btnHeavyDetails.Name = "btnHeavyDetails"
        Me.btnHeavyDetails.Size = New System.Drawing.Size(136, 23)
        Me.btnHeavyDetails.TabIndex = 9
        Me.btnHeavyDetails.Text = "Toggle Stats"
        Me.btnHeavyDetails.UseVisualStyleBackColor = True
        '
        'btnHeavy
        '
        Me.btnHeavy.Location = New System.Drawing.Point(562, 429)
        Me.btnHeavy.Name = "btnHeavy"
        Me.btnHeavy.Size = New System.Drawing.Size(130, 23)
        Me.btnHeavy.TabIndex = 8
        Me.btnHeavy.Text = "Choose Hardcase"
        Me.btnHeavy.UseVisualStyleBackColor = True
        '
        'txtLiteDetails
        '
        Me.txtLiteDetails.Enabled = False
        Me.txtLiteDetails.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLiteDetails.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLiteDetails.Location = New System.Drawing.Point(3, 54)
        Me.txtLiteDetails.Multiline = True
        Me.txtLiteDetails.Name = "txtLiteDetails"
        Me.txtLiteDetails.Size = New System.Drawing.Size(273, 370)
        Me.txtLiteDetails.TabIndex = 10
        Me.txtLiteDetails.Text = resources.GetString("txtLiteDetails.Text")
        Me.txtLiteDetails.Visible = False
        '
        'txtMidDetails
        '
        Me.txtMidDetails.Enabled = False
        Me.txtMidDetails.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMidDetails.Location = New System.Drawing.Point(283, 53)
        Me.txtMidDetails.Multiline = True
        Me.txtMidDetails.Name = "txtMidDetails"
        Me.txtMidDetails.Size = New System.Drawing.Size(269, 370)
        Me.txtMidDetails.TabIndex = 11
        Me.txtMidDetails.Text = resources.GetString("txtMidDetails.Text")
        Me.txtMidDetails.Visible = False
        '
        'txtHeavyDetails
        '
        Me.txtHeavyDetails.Enabled = False
        Me.txtHeavyDetails.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeavyDetails.Location = New System.Drawing.Point(559, 53)
        Me.txtHeavyDetails.Multiline = True
        Me.txtHeavyDetails.Name = "txtHeavyDetails"
        Me.txtHeavyDetails.Size = New System.Drawing.Size(276, 370)
        Me.txtHeavyDetails.TabIndex = 12
        Me.txtHeavyDetails.Text = resources.GetString("txtHeavyDetails.Text")
        Me.txtHeavyDetails.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(558, 53)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(278, 371)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(283, 53)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(269, 371)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(273, 371)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Blue
        Me.lblName.Location = New System.Drawing.Point(723, 20)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(91, 30)
        Me.lblName.TabIndex = 13
        Me.lblName.Text = "Player 1"
        '
        'frmP1Select
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 461)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnHeavyDetails)
        Me.Controls.Add(Me.btnHeavy)
        Me.Controls.Add(Me.btnMidDetails)
        Me.Controls.Add(Me.btnMid)
        Me.Controls.Add(Me.btnLiteDetails)
        Me.Controls.Add(Me.btnLite)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLiteDetails)
        Me.Controls.Add(Me.txtMidDetails)
        Me.Controls.Add(Me.txtHeavyDetails)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(860, 499)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(860, 499)
        Me.Name = "frmP1Select"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choose Your Fighter"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLite As Button
    Friend WithEvents btnLiteDetails As Button
    Friend WithEvents btnMidDetails As Button
    Friend WithEvents btnMid As Button
    Friend WithEvents btnHeavyDetails As Button
    Friend WithEvents btnHeavy As Button
    Friend WithEvents txtLiteDetails As TextBox
    Friend WithEvents txtMidDetails As TextBox
    Friend WithEvents txtHeavyDetails As TextBox
    Friend WithEvents lblName As Label
End Class
