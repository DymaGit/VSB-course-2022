<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formular1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formular1))
        Me.cb = New System.Windows.Forms.ComboBox()
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.tb2 = New System.Windows.Forms.TextBox()
        Me.nud1 = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SouborToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtevřítToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VšechnySouboryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JendocToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.save = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rtb1 = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb1 = New System.Windows.Forms.CheckBox()
        Me.cb2 = New System.Windows.Forms.CheckBox()
        Me.cb3 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rb1 = New System.Windows.Forms.RadioButton()
        Me.rb2 = New System.Windows.Forms.RadioButton()
        Me.rb3 = New System.Windows.Forms.RadioButton()
        Me.rb4 = New System.Windows.Forms.RadioButton()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ssl1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ssl2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ssl0 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ssl3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ofd1 = New System.Windows.Forms.OpenFileDialog()
        Me.sfd1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.nud1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cb
        '
        Me.cb.FormattingEnabled = True
        Me.cb.Items.AddRange(New Object() {"hnědá", "červená", "fialová", "zelená", "modrá"})
        Me.cb.Location = New System.Drawing.Point(45, 336)
        Me.cb.Name = "cb"
        Me.cb.Size = New System.Drawing.Size(121, 21)
        Me.cb.TabIndex = 4
        '
        'tb1
        '
        Me.tb1.Location = New System.Drawing.Point(45, 58)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(41, 20)
        Me.tb1.TabIndex = 5
        '
        'tb2
        '
        Me.tb2.Location = New System.Drawing.Point(104, 58)
        Me.tb2.Name = "tb2"
        Me.tb2.Size = New System.Drawing.Size(41, 20)
        Me.tb2.TabIndex = 6
        '
        'nud1
        '
        Me.nud1.Location = New System.Drawing.Point(173, 58)
        Me.nud1.Name = "nud1"
        Me.nud1.Size = New System.Drawing.Size(55, 20)
        Me.nud1.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(418, 352)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 69)
        Me.Button1.TabIndex = 8
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(398, 241)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 42)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Button2"
        Me.ToolTip1.SetToolTip(Me.Button2, "bublinková nápověda")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(45, 158)
        Me.TrackBar1.Margin = New System.Windows.Forms.Padding(1)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Minimum = 1
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(183, 45)
        Me.TrackBar1.TabIndex = 10
        Me.TrackBar1.TickFrequency = 11
        Me.TrackBar1.Value = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Posuvníkem nastaveno:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(176, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "100"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SouborToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(516, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SouborToolStripMenuItem
        '
        Me.SouborToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OtevřítToolStripMenuItem, Me.save})
        Me.SouborToolStripMenuItem.Name = "SouborToolStripMenuItem"
        Me.SouborToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.SouborToolStripMenuItem.Text = "Soubor"
        '
        'OtevřítToolStripMenuItem
        '
        Me.OtevřítToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VšechnySouboryToolStripMenuItem, Me.JendocToolStripMenuItem})
        Me.OtevřítToolStripMenuItem.Name = "OtevřítToolStripMenuItem"
        Me.OtevřítToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.OtevřítToolStripMenuItem.Text = "Otevřít (default)"
        '
        'VšechnySouboryToolStripMenuItem
        '
        Me.VšechnySouboryToolStripMenuItem.Name = "VšechnySouboryToolStripMenuItem"
        Me.VšechnySouboryToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.VšechnySouboryToolStripMenuItem.Text = "všechny soubory"
        '
        'JendocToolStripMenuItem
        '
        Me.JendocToolStripMenuItem.Name = "JendocToolStripMenuItem"
        Me.JendocToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.JendocToolStripMenuItem.Text = "jen *.doc"
        '
        'save
        '
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(158, 22)
        Me.save.Text = "Uložit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'rtb1
        '
        Me.rtb1.AutoWordSelection = True
        Me.rtb1.Location = New System.Drawing.Point(265, 58)
        Me.rtb1.Name = "rtb1"
        Me.rtb1.Size = New System.Drawing.Size(217, 145)
        Me.rtb1.TabIndex = 14
        Me.rtb1.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(101, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Součet: "
        '
        'cb1
        '
        Me.cb1.AutoSize = True
        Me.cb1.Location = New System.Drawing.Point(219, 294)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(49, 17)
        Me.cb1.TabIndex = 17
        Me.cb1.Text = "delší"
        Me.cb1.UseVisualStyleBackColor = True
        '
        'cb2
        '
        Me.cb2.AutoSize = True
        Me.cb2.Location = New System.Drawing.Point(219, 317)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(51, 17)
        Me.cb2.TabIndex = 18
        Me.cb2.Text = "vyšší"
        Me.cb2.UseVisualStyleBackColor = True
        '
        'cb3
        '
        Me.cb3.AutoSize = True
        Me.cb3.Location = New System.Drawing.Point(219, 340)
        Me.cb3.Name = "cb3"
        Me.cb3.Size = New System.Drawing.Size(55, 17)
        Me.cb3.TabIndex = 19
        Me.cb3.Text = "hlubší"
        Me.cb3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(152, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Součet * TrackBar: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 380)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 22
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.Location = New System.Drawing.Point(6, 25)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(53, 17)
        Me.rb1.TabIndex = 23
        Me.rb1.TabStop = True
        Me.rb1.Text = "dřevo"
        Me.rb1.UseVisualStyleBackColor = True
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.Location = New System.Drawing.Point(6, 48)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(43, 17)
        Me.rb2.TabIndex = 24
        Me.rb2.TabStop = True
        Me.rb2.Text = "kov"
        Me.rb2.UseVisualStyleBackColor = True
        '
        'rb3
        '
        Me.rb3.AutoSize = True
        Me.rb3.Location = New System.Drawing.Point(6, 71)
        Me.rb3.Name = "rb3"
        Me.rb3.Size = New System.Drawing.Size(47, 17)
        Me.rb3.TabIndex = 25
        Me.rb3.TabStop = True
        Me.rb3.Text = "plast"
        Me.rb3.UseVisualStyleBackColor = True
        '
        'rb4
        '
        Me.rb4.AutoSize = True
        Me.rb4.Location = New System.Drawing.Point(5, 95)
        Me.rb4.Name = "rb4"
        Me.rb4.Size = New System.Drawing.Size(44, 17)
        Me.rb4.TabIndex = 26
        Me.rb4.TabStop = True
        Me.rb4.Text = "sklo"
        Me.rb4.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(24, 398)
        Me.ProgressBar1.MarqueeAnimationSpeed = 10000
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(378, 23)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 27
        '
        'Timer1
        '
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ssl1, Me.ssl2, Me.ssl0, Me.ssl3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(516, 22)
        Me.StatusStrip1.TabIndex = 28
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ssl1
        '
        Me.ssl1.Name = "ssl1"
        Me.ssl1.Size = New System.Drawing.Size(119, 17)
        Me.ssl1.Text = "ToolStripStatusLabel1"
        '
        'ssl2
        '
        Me.ssl2.Name = "ssl2"
        Me.ssl2.Size = New System.Drawing.Size(0, 17)
        '
        'ssl0
        '
        Me.ssl0.Name = "ssl0"
        Me.ssl0.Size = New System.Drawing.Size(158, 17)
        Me.ssl0.Text = "Naposledy otevřený soubor: "
        '
        'ssl3
        '
        Me.ssl3.Name = "ssl3"
        Me.ssl3.Size = New System.Drawing.Size(16, 17)
        Me.ssl3.Text = "   "
        '
        'Timer2
        '
        '
        'ofd1
        '
        Me.ofd1.FileName = "ofd1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb1)
        Me.GroupBox1.Controls.Add(Me.rb2)
        Me.GroupBox1.Controls.Add(Me.rb3)
        Me.GroupBox1.Controls.Add(Me.rb4)
        Me.GroupBox1.Location = New System.Drawing.Point(280, 241)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(107, 133)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Materiál"
        '
        'Formular1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cb3)
        Me.Controls.Add(Me.cb2)
        Me.Controls.Add(Me.cb1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rtb1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.nud1)
        Me.Controls.Add(Me.tb2)
        Me.Controls.Add(Me.tb1)
        Me.Controls.Add(Me.cb)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Formular1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formular1"
        CType(Me.nud1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cb As Windows.Forms.ComboBox
    Friend WithEvents tb1 As Windows.Forms.TextBox
    Friend WithEvents tb2 As Windows.Forms.TextBox
    Friend WithEvents nud1 As Windows.Forms.NumericUpDown
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents Button2 As Windows.Forms.Button
    Friend WithEvents ToolTip1 As Windows.Forms.ToolTip
    Friend WithEvents TrackBar1 As Windows.Forms.TrackBar
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents MenuStrip1 As Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents rtb1 As Windows.Forms.RichTextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents cb1 As Windows.Forms.CheckBox
    Friend WithEvents cb2 As Windows.Forms.CheckBox
    Friend WithEvents cb3 As Windows.Forms.CheckBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents rb1 As Windows.Forms.RadioButton
    Friend WithEvents rb2 As Windows.Forms.RadioButton
    Friend WithEvents rb3 As Windows.Forms.RadioButton
    Friend WithEvents rb4 As Windows.Forms.RadioButton
    Friend WithEvents ProgressBar1 As Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As Windows.Forms.Timer
    Friend WithEvents StatusStrip1 As Windows.Forms.StatusStrip
    Friend WithEvents ssl1 As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer2 As Windows.Forms.Timer
    Friend WithEvents SouborToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtevřítToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents save As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ofd1 As Windows.Forms.OpenFileDialog
    Friend WithEvents VšechnySouboryToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents JendocToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents sfd1 As Windows.Forms.SaveFileDialog
    Friend WithEvents ssl2 As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ssl0 As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ssl3 As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
End Class
