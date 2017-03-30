<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EndGame
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
        Me.pBox = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnStartOver = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        CType(Me.pBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pBox
        '
        Me.pBox.Location = New System.Drawing.Point(-1, 1)
        Me.pBox.Name = "pBox"
        Me.pBox.Size = New System.Drawing.Size(623, 507)
        Me.pBox.TabIndex = 0
        Me.pBox.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(71, 456)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(96, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnStartOver
        '
        Me.btnStartOver.Location = New System.Drawing.Point(250, 456)
        Me.btnStartOver.Name = "btnStartOver"
        Me.btnStartOver.Size = New System.Drawing.Size(96, 23)
        Me.btnStartOver.TabIndex = 2
        Me.btnStartOver.Text = "Start Over"
        Me.btnStartOver.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Enabled = False
        Me.btnNext.Location = New System.Drawing.Point(429, 456)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(96, 23)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "Next Round"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'EndGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 506)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnStartOver)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.pBox)
        Me.MaximumSize = New System.Drawing.Size(639, 544)
        Me.MinimumSize = New System.Drawing.Size(639, 544)
        Me.Name = "EndGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Round Over"
        CType(Me.pBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pBox As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnStartOver As Button
    Friend WithEvents btnNext As Button
End Class
