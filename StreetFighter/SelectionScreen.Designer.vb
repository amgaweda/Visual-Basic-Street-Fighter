<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StreetFighterScreen
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
        Me.groupCharacter = New System.Windows.Forms.GroupBox()
        Me.radChunLi = New System.Windows.Forms.RadioButton()
        Me.radGuile = New System.Windows.Forms.RadioButton()
        Me.radRyu = New System.Windows.Forms.RadioButton()
        Me.groupBackground = New System.Windows.Forms.GroupBox()
        Me.radBGBlanka = New System.Windows.Forms.RadioButton()
        Me.radBGSagat = New System.Windows.Forms.RadioButton()
        Me.radBGBison = New System.Windows.Forms.RadioButton()
        Me.picCharacter = New System.Windows.Forms.PictureBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.panelStage = New System.Windows.Forms.Panel()
        Me.panelControls = New System.Windows.Forms.Panel()
        Me.btnKick = New System.Windows.Forms.Button()
        Me.btnPunch = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.groupCharacter.SuspendLayout()
        Me.groupBackground.SuspendLayout()
        CType(Me.picCharacter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelStage.SuspendLayout()
        Me.panelControls.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupCharacter
        '
        Me.groupCharacter.Controls.Add(Me.radChunLi)
        Me.groupCharacter.Controls.Add(Me.radGuile)
        Me.groupCharacter.Controls.Add(Me.radRyu)
        Me.groupCharacter.Location = New System.Drawing.Point(12, 12)
        Me.groupCharacter.Name = "groupCharacter"
        Me.groupCharacter.Size = New System.Drawing.Size(206, 92)
        Me.groupCharacter.TabIndex = 0
        Me.groupCharacter.TabStop = False
        Me.groupCharacter.Text = "Choose Your Character"
        '
        'radChunLi
        '
        Me.radChunLi.AutoSize = True
        Me.radChunLi.Location = New System.Drawing.Point(7, 68)
        Me.radChunLi.Name = "radChunLi"
        Me.radChunLi.Size = New System.Drawing.Size(61, 17)
        Me.radChunLi.TabIndex = 2
        Me.radChunLi.TabStop = True
        Me.radChunLi.Text = "Chun-Li"
        Me.radChunLi.UseVisualStyleBackColor = True
        '
        'radGuile
        '
        Me.radGuile.AutoSize = True
        Me.radGuile.Location = New System.Drawing.Point(7, 44)
        Me.radGuile.Name = "radGuile"
        Me.radGuile.Size = New System.Drawing.Size(49, 17)
        Me.radGuile.TabIndex = 1
        Me.radGuile.TabStop = True
        Me.radGuile.Text = "Guile"
        Me.radGuile.UseVisualStyleBackColor = True
        '
        'radRyu
        '
        Me.radRyu.AutoSize = True
        Me.radRyu.Location = New System.Drawing.Point(7, 20)
        Me.radRyu.Name = "radRyu"
        Me.radRyu.Size = New System.Drawing.Size(44, 17)
        Me.radRyu.TabIndex = 0
        Me.radRyu.TabStop = True
        Me.radRyu.Text = "Ryu"
        Me.radRyu.UseVisualStyleBackColor = True
        '
        'groupBackground
        '
        Me.groupBackground.Controls.Add(Me.radBGBlanka)
        Me.groupBackground.Controls.Add(Me.radBGSagat)
        Me.groupBackground.Controls.Add(Me.radBGBison)
        Me.groupBackground.Location = New System.Drawing.Point(328, 12)
        Me.groupBackground.Name = "groupBackground"
        Me.groupBackground.Size = New System.Drawing.Size(206, 92)
        Me.groupBackground.TabIndex = 3
        Me.groupBackground.TabStop = False
        Me.groupBackground.Text = "Choose Your Stage"
        '
        'radBGBlanka
        '
        Me.radBGBlanka.AutoSize = True
        Me.radBGBlanka.Location = New System.Drawing.Point(7, 68)
        Me.radBGBlanka.Name = "radBGBlanka"
        Me.radBGBlanka.Size = New System.Drawing.Size(58, 17)
        Me.radBGBlanka.TabIndex = 2
        Me.radBGBlanka.TabStop = True
        Me.radBGBlanka.Text = "Blanka"
        Me.radBGBlanka.UseVisualStyleBackColor = True
        '
        'radBGSagat
        '
        Me.radBGSagat.AutoSize = True
        Me.radBGSagat.Location = New System.Drawing.Point(7, 44)
        Me.radBGSagat.Name = "radBGSagat"
        Me.radBGSagat.Size = New System.Drawing.Size(53, 17)
        Me.radBGSagat.TabIndex = 1
        Me.radBGSagat.TabStop = True
        Me.radBGSagat.Text = "Sagat"
        Me.radBGSagat.UseVisualStyleBackColor = True
        '
        'radBGBison
        '
        Me.radBGBison.AutoSize = True
        Me.radBGBison.Location = New System.Drawing.Point(7, 20)
        Me.radBGBison.Name = "radBGBison"
        Me.radBGBison.Size = New System.Drawing.Size(51, 17)
        Me.radBGBison.TabIndex = 0
        Me.radBGBison.TabStop = True
        Me.radBGBison.Text = "Bison"
        Me.radBGBison.UseVisualStyleBackColor = True
        '
        'picCharacter
        '
        Me.picCharacter.BackColor = System.Drawing.Color.Transparent
        Me.picCharacter.Location = New System.Drawing.Point(74, 90)
        Me.picCharacter.Name = "picCharacter"
        Me.picCharacter.Size = New System.Drawing.Size(106, 104)
        Me.picCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picCharacter.TabIndex = 5
        Me.picCharacter.TabStop = False
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(220, 21)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(109, 83)
        Me.btnLoad.TabIndex = 6
        Me.btnLoad.Text = "Fight!"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'panelStage
        '
        Me.panelStage.Controls.Add(Me.picCharacter)
        Me.panelStage.Location = New System.Drawing.Point(7, 207)
        Me.panelStage.Name = "panelStage"
        Me.panelStage.Size = New System.Drawing.Size(527, 211)
        Me.panelStage.TabIndex = 7
        '
        'panelControls
        '
        Me.panelControls.Controls.Add(Me.btnKick)
        Me.panelControls.Controls.Add(Me.btnPunch)
        Me.panelControls.Controls.Add(Me.btnRight)
        Me.panelControls.Controls.Add(Me.btnDown)
        Me.panelControls.Controls.Add(Me.btnLeft)
        Me.panelControls.Enabled = False
        Me.panelControls.Location = New System.Drawing.Point(7, 110)
        Me.panelControls.Name = "panelControls"
        Me.panelControls.Size = New System.Drawing.Size(526, 91)
        Me.panelControls.TabIndex = 8
        '
        'btnKick
        '
        Me.btnKick.Location = New System.Drawing.Point(384, 20)
        Me.btnKick.Name = "btnKick"
        Me.btnKick.Size = New System.Drawing.Size(57, 54)
        Me.btnKick.TabIndex = 4
        Me.btnKick.Text = "Kick"
        Me.btnKick.UseVisualStyleBackColor = True
        '
        'btnPunch
        '
        Me.btnPunch.Location = New System.Drawing.Point(321, 20)
        Me.btnPunch.Name = "btnPunch"
        Me.btnPunch.Size = New System.Drawing.Size(57, 54)
        Me.btnPunch.TabIndex = 3
        Me.btnPunch.Text = "Punch"
        Me.btnPunch.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.Location = New System.Drawing.Point(143, 20)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(57, 54)
        Me.btnRight.TabIndex = 2
        Me.btnRight.Text = ">"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Location = New System.Drawing.Point(80, 20)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(57, 54)
        Me.btnDown.TabIndex = 1
        Me.btnDown.Text = "\/"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnLeft
        '
        Me.btnLeft.Location = New System.Drawing.Point(17, 20)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(57, 54)
        Me.btnLeft.TabIndex = 0
        Me.btnLeft.Text = "<"
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'StreetFighterScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 430)
        Me.Controls.Add(Me.panelControls)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.groupBackground)
        Me.Controls.Add(Me.groupCharacter)
        Me.Controls.Add(Me.panelStage)
        Me.Name = "StreetFighterScreen"
        Me.Text = "Street Fighter Selection Screen"
        Me.groupCharacter.ResumeLayout(False)
        Me.groupCharacter.PerformLayout()
        Me.groupBackground.ResumeLayout(False)
        Me.groupBackground.PerformLayout()
        CType(Me.picCharacter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelStage.ResumeLayout(False)
        Me.panelStage.PerformLayout()
        Me.panelControls.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents groupCharacter As System.Windows.Forms.GroupBox
    Friend WithEvents radChunLi As System.Windows.Forms.RadioButton
    Friend WithEvents radGuile As System.Windows.Forms.RadioButton
    Friend WithEvents radRyu As System.Windows.Forms.RadioButton
    Friend WithEvents groupBackground As System.Windows.Forms.GroupBox
    Friend WithEvents radBGBlanka As System.Windows.Forms.RadioButton
    Friend WithEvents radBGSagat As System.Windows.Forms.RadioButton
    Friend WithEvents radBGBison As System.Windows.Forms.RadioButton
    Friend WithEvents picCharacter As System.Windows.Forms.PictureBox
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents panelStage As System.Windows.Forms.Panel
    Friend WithEvents panelControls As System.Windows.Forms.Panel
    Friend WithEvents btnKick As System.Windows.Forms.Button
    Friend WithEvents btnPunch As System.Windows.Forms.Button
    Friend WithEvents btnRight As System.Windows.Forms.Button
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnLeft As System.Windows.Forms.Button

End Class
