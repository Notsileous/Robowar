<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOpponent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOpponent))
        Me.txtHeavyDetails = New System.Windows.Forms.TextBox()
        Me.txtMidDetails = New System.Windows.Forms.TextBox()
        Me.txtLiteDetails = New System.Windows.Forms.TextBox()
        Me.btnHeavyDetails = New System.Windows.Forms.Button()
        Me.btnHeavy = New System.Windows.Forms.Button()
        Me.btnMidDetails = New System.Windows.Forms.Button()
        Me.btnMid = New System.Windows.Forms.Button()
        Me.btnLiteDetails = New System.Windows.Forms.Button()
        Me.btnLite = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnChoose = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.picLocked = New System.Windows.Forms.PictureBox()
        Me.pBoxRipper = New System.Windows.Forms.PictureBox()
        Me.pBoxStatic = New System.Windows.Forms.PictureBox()
        Me.pBoxHardcase = New System.Windows.Forms.PictureBox()
        Me.btnDetails = New System.Windows.Forms.Button()
        Me.txtScorp = New System.Windows.Forms.TextBox()
        CType(Me.picLocked, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pBoxRipper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pBoxStatic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pBoxHardcase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtHeavyDetails
        '
        Me.txtHeavyDetails.Enabled = False
        Me.txtHeavyDetails.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeavyDetails.Location = New System.Drawing.Point(572, 53)
        Me.txtHeavyDetails.Multiline = True
        Me.txtHeavyDetails.Name = "txtHeavyDetails"
        Me.txtHeavyDetails.Size = New System.Drawing.Size(276, 370)
        Me.txtHeavyDetails.TabIndex = 25
        Me.txtHeavyDetails.Text = resources.GetString("txtHeavyDetails.Text")
        Me.txtHeavyDetails.Visible = False
        '
        'txtMidDetails
        '
        Me.txtMidDetails.Enabled = False
        Me.txtMidDetails.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMidDetails.Location = New System.Drawing.Point(296, 53)
        Me.txtMidDetails.Multiline = True
        Me.txtMidDetails.Name = "txtMidDetails"
        Me.txtMidDetails.Size = New System.Drawing.Size(269, 370)
        Me.txtMidDetails.TabIndex = 24
        Me.txtMidDetails.Text = resources.GetString("txtMidDetails.Text")
        Me.txtMidDetails.Visible = False
        '
        'txtLiteDetails
        '
        Me.txtLiteDetails.Enabled = False
        Me.txtLiteDetails.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLiteDetails.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLiteDetails.Location = New System.Drawing.Point(16, 54)
        Me.txtLiteDetails.Multiline = True
        Me.txtLiteDetails.Name = "txtLiteDetails"
        Me.txtLiteDetails.Size = New System.Drawing.Size(273, 370)
        Me.txtLiteDetails.TabIndex = 23
        Me.txtLiteDetails.Text = resources.GetString("txtLiteDetails.Text")
        Me.txtLiteDetails.Visible = False
        '
        'btnHeavyDetails
        '
        Me.btnHeavyDetails.Location = New System.Drawing.Point(712, 429)
        Me.btnHeavyDetails.Name = "btnHeavyDetails"
        Me.btnHeavyDetails.Size = New System.Drawing.Size(136, 23)
        Me.btnHeavyDetails.TabIndex = 22
        Me.btnHeavyDetails.Text = "Toggle Stats"
        Me.btnHeavyDetails.UseVisualStyleBackColor = True
        '
        'btnHeavy
        '
        Me.btnHeavy.Location = New System.Drawing.Point(575, 429)
        Me.btnHeavy.Name = "btnHeavy"
        Me.btnHeavy.Size = New System.Drawing.Size(130, 23)
        Me.btnHeavy.TabIndex = 21
        Me.btnHeavy.Text = "Choose Hardcase"
        Me.btnHeavy.UseVisualStyleBackColor = True
        '
        'btnMidDetails
        '
        Me.btnMidDetails.Location = New System.Drawing.Point(433, 429)
        Me.btnMidDetails.Name = "btnMidDetails"
        Me.btnMidDetails.Size = New System.Drawing.Size(136, 23)
        Me.btnMidDetails.TabIndex = 20
        Me.btnMidDetails.Text = "Toggle Stats"
        Me.btnMidDetails.UseVisualStyleBackColor = True
        '
        'btnMid
        '
        Me.btnMid.Location = New System.Drawing.Point(296, 429)
        Me.btnMid.Name = "btnMid"
        Me.btnMid.Size = New System.Drawing.Size(130, 23)
        Me.btnMid.TabIndex = 19
        Me.btnMid.Text = "Choose Static"
        Me.btnMid.UseVisualStyleBackColor = True
        '
        'btnLiteDetails
        '
        Me.btnLiteDetails.Location = New System.Drawing.Point(153, 430)
        Me.btnLiteDetails.Name = "btnLiteDetails"
        Me.btnLiteDetails.Size = New System.Drawing.Size(136, 23)
        Me.btnLiteDetails.TabIndex = 18
        Me.btnLiteDetails.Text = "Toggle Stats"
        Me.btnLiteDetails.UseVisualStyleBackColor = True
        '
        'btnLite
        '
        Me.btnLite.Location = New System.Drawing.Point(16, 430)
        Me.btnLite.Name = "btnLite"
        Me.btnLite.Size = New System.Drawing.Size(130, 23)
        Me.btnLite.TabIndex = 17
        Me.btnLite.Text = "Choose Ripper"
        Me.btnLite.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 37)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Choose Your Opponent"
        '
        'btnChoose
        '
        Me.btnChoose.Enabled = False
        Me.btnChoose.Location = New System.Drawing.Point(866, 429)
        Me.btnChoose.Name = "btnChoose"
        Me.btnChoose.Size = New System.Drawing.Size(130, 23)
        Me.btnChoose.TabIndex = 27
        Me.btnChoose.Text = "Locked"
        Me.btnChoose.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(597, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(535, 25)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Beat all 3 opponents to earn the right to face a new challange!"
        '
        'picLocked
        '
        Me.picLocked.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picLocked.Image = CType(resources.GetObject("picLocked.Image"), System.Drawing.Image)
        Me.picLocked.Location = New System.Drawing.Point(854, 54)
        Me.picLocked.Name = "picLocked"
        Me.picLocked.Size = New System.Drawing.Size(278, 371)
        Me.picLocked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLocked.TabIndex = 26
        Me.picLocked.TabStop = False
        '
        'pBoxRipper
        '
        Me.pBoxRipper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pBoxRipper.Image = CType(resources.GetObject("pBoxRipper.Image"), System.Drawing.Image)
        Me.pBoxRipper.Location = New System.Drawing.Point(16, 53)
        Me.pBoxRipper.Name = "pBoxRipper"
        Me.pBoxRipper.Size = New System.Drawing.Size(273, 371)
        Me.pBoxRipper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBoxRipper.TabIndex = 13
        Me.pBoxRipper.TabStop = False
        '
        'pBoxStatic
        '
        Me.pBoxStatic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pBoxStatic.Image = CType(resources.GetObject("pBoxStatic.Image"), System.Drawing.Image)
        Me.pBoxStatic.Location = New System.Drawing.Point(296, 53)
        Me.pBoxStatic.Name = "pBoxStatic"
        Me.pBoxStatic.Size = New System.Drawing.Size(269, 371)
        Me.pBoxStatic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBoxStatic.TabIndex = 14
        Me.pBoxStatic.TabStop = False
        '
        'pBoxHardcase
        '
        Me.pBoxHardcase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pBoxHardcase.Image = CType(resources.GetObject("pBoxHardcase.Image"), System.Drawing.Image)
        Me.pBoxHardcase.Location = New System.Drawing.Point(571, 53)
        Me.pBoxHardcase.Name = "pBoxHardcase"
        Me.pBoxHardcase.Size = New System.Drawing.Size(278, 371)
        Me.pBoxHardcase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pBoxHardcase.TabIndex = 15
        Me.pBoxHardcase.TabStop = False
        '
        'btnDetails
        '
        Me.btnDetails.Enabled = False
        Me.btnDetails.Location = New System.Drawing.Point(1002, 429)
        Me.btnDetails.Name = "btnDetails"
        Me.btnDetails.Size = New System.Drawing.Size(115, 23)
        Me.btnDetails.TabIndex = 31
        Me.btnDetails.Text = "Locked"
        Me.btnDetails.UseVisualStyleBackColor = True
        '
        'txtScorp
        '
        Me.txtScorp.Enabled = False
        Me.txtScorp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScorp.Location = New System.Drawing.Point(856, 54)
        Me.txtScorp.Multiline = True
        Me.txtScorp.Name = "txtScorp"
        Me.txtScorp.Size = New System.Drawing.Size(273, 369)
        Me.txtScorp.TabIndex = 32
        Me.txtScorp.Text = resources.GetString("txtScorp.Text")
        Me.txtScorp.Visible = False
        '
        'frmOpponent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1141, 465)
        Me.Controls.Add(Me.btnDetails)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnChoose)
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
        Me.Controls.Add(Me.txtScorp)
        Me.Controls.Add(Me.pBoxRipper)
        Me.Controls.Add(Me.pBoxStatic)
        Me.Controls.Add(Me.pBoxHardcase)
        Me.Controls.Add(Me.picLocked)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1157, 503)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1157, 503)
        Me.Name = "frmOpponent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choose Your Opponent"
        CType(Me.picLocked, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pBoxRipper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pBoxStatic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pBoxHardcase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtHeavyDetails As TextBox
    Friend WithEvents txtMidDetails As TextBox
    Friend WithEvents txtLiteDetails As TextBox
    Friend WithEvents btnHeavyDetails As Button
    Friend WithEvents btnHeavy As Button
    Friend WithEvents btnMidDetails As Button
    Friend WithEvents btnMid As Button
    Friend WithEvents btnLiteDetails As Button
    Friend WithEvents btnLite As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents pBoxHardcase As PictureBox
    Friend WithEvents pBoxStatic As PictureBox
    Friend WithEvents pBoxRipper As PictureBox
    Friend WithEvents btnChoose As Button
    Friend WithEvents picLocked As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDetails As Button
    Friend WithEvents txtScorp As TextBox
End Class
