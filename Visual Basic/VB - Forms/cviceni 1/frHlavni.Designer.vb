<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frHlavni
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
        Me.tlHotovo = New System.Windows.Forms.Button()
        Me.tlStorno = New System.Windows.Forms.Button()
        Me.tlVypocti = New System.Windows.Forms.Button()
        Me.txA = New System.Windows.Forms.TextBox()
        Me.txB = New System.Windows.Forms.TextBox()
        Me.txC = New System.Windows.Forms.TextBox()
        Me.lbA = New System.Windows.Forms.Label()
        Me.lbB = New System.Windows.Forms.Label()
        Me.lbC = New System.Windows.Forms.Label()
        Me.cbRovnoramenny = New System.Windows.Forms.CheckBox()
        Me.sbA = New System.Windows.Forms.VScrollBar()
        Me.cbbarvy = New System.Windows.Forms.ComboBox()
        Me.pbA = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'tlHotovo
        '
        Me.tlHotovo.Location = New System.Drawing.Point(692, 354)
        Me.tlHotovo.Name = "tlHotovo"
        Me.tlHotovo.Size = New System.Drawing.Size(96, 38)
        Me.tlHotovo.TabIndex = 0
        Me.tlHotovo.Text = "&Hotovo"
        Me.tlHotovo.UseVisualStyleBackColor = True
        '
        'tlStorno
        '
        Me.tlStorno.Location = New System.Drawing.Point(569, 354)
        Me.tlStorno.Name = "tlStorno"
        Me.tlStorno.Size = New System.Drawing.Size(96, 38)
        Me.tlStorno.TabIndex = 1
        Me.tlStorno.Text = "&Storno"
        Me.tlStorno.UseVisualStyleBackColor = True
        '
        'tlVypocti
        '
        Me.tlVypocti.Location = New System.Drawing.Point(12, 354)
        Me.tlVypocti.Name = "tlVypocti"
        Me.tlVypocti.Size = New System.Drawing.Size(96, 38)
        Me.tlVypocti.TabIndex = 2
        Me.tlVypocti.Text = "&Vypočti"
        Me.tlVypocti.UseVisualStyleBackColor = True
        '
        'txA
        '
        Me.txA.Location = New System.Drawing.Point(107, 58)
        Me.txA.Name = "txA"
        Me.txA.Size = New System.Drawing.Size(134, 20)
        Me.txA.TabIndex = 3
        '
        'txB
        '
        Me.txB.Location = New System.Drawing.Point(107, 105)
        Me.txB.Name = "txB"
        Me.txB.Size = New System.Drawing.Size(134, 20)
        Me.txB.TabIndex = 4
        '
        'txC
        '
        Me.txC.Location = New System.Drawing.Point(107, 152)
        Me.txC.Name = "txC"
        Me.txC.Size = New System.Drawing.Size(134, 20)
        Me.txC.TabIndex = 5
        '
        'lbA
        '
        Me.lbA.AutoSize = True
        Me.lbA.Location = New System.Drawing.Point(25, 58)
        Me.lbA.Name = "lbA"
        Me.lbA.Size = New System.Drawing.Size(46, 13)
        Me.lbA.TabIndex = 6
        Me.lbA.Text = "strana A"
        '
        'lbB
        '
        Me.lbB.AutoSize = True
        Me.lbB.Location = New System.Drawing.Point(25, 105)
        Me.lbB.Name = "lbB"
        Me.lbB.Size = New System.Drawing.Size(46, 13)
        Me.lbB.TabIndex = 7
        Me.lbB.Text = "strana B"
        '
        'lbC
        '
        Me.lbC.AutoSize = True
        Me.lbC.Location = New System.Drawing.Point(25, 152)
        Me.lbC.Name = "lbC"
        Me.lbC.Size = New System.Drawing.Size(57, 13)
        Me.lbC.TabIndex = 8
        Me.lbC.Text = "přepona C"
        '
        'cbRovnoramenny
        '
        Me.cbRovnoramenny.AutoSize = True
        Me.cbRovnoramenny.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cbRovnoramenny.Location = New System.Drawing.Point(259, 60)
        Me.cbRovnoramenny.Name = "cbRovnoramenny"
        Me.cbRovnoramenny.Size = New System.Drawing.Size(98, 17)
        Me.cbRovnoramenny.TabIndex = 9
        Me.cbRovnoramenny.Text = "Rovnoramenny"
        Me.cbRovnoramenny.UseVisualStyleBackColor = True
        '
        'sbA
        '
        Me.sbA.Location = New System.Drawing.Point(399, 38)
        Me.sbA.Maximum = 500
        Me.sbA.Name = "sbA"
        Me.sbA.Size = New System.Drawing.Size(17, 80)
        Me.sbA.TabIndex = 10
        '
        'cbbarvy
        '
        Me.cbbarvy.FormattingEnabled = True
        Me.cbbarvy.Location = New System.Drawing.Point(418, 197)
        Me.cbbarvy.Name = "cbbarvy"
        Me.cbbarvy.Size = New System.Drawing.Size(121, 21)
        Me.cbbarvy.TabIndex = 11
        '
        'pbA
        '
        Me.pbA.Location = New System.Drawing.Point(418, 258)
        Me.pbA.Maximum = 500
        Me.pbA.Name = "pbA"
        Me.pbA.Size = New System.Drawing.Size(226, 23)
        Me.pbA.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.pbA.TabIndex = 12
        '
        'frHlavni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pbA)
        Me.Controls.Add(Me.cbbarvy)
        Me.Controls.Add(Me.sbA)
        Me.Controls.Add(Me.cbRovnoramenny)
        Me.Controls.Add(Me.lbC)
        Me.Controls.Add(Me.lbB)
        Me.Controls.Add(Me.lbA)
        Me.Controls.Add(Me.txC)
        Me.Controls.Add(Me.txB)
        Me.Controls.Add(Me.txA)
        Me.Controls.Add(Me.tlVypocti)
        Me.Controls.Add(Me.tlStorno)
        Me.Controls.Add(Me.tlHotovo)
        Me.Name = "frHlavni"
        Me.Text = "frHlavni"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tlHotovo As Windows.Forms.Button
    Friend WithEvents tlStorno As Windows.Forms.Button
    Friend WithEvents tlVypocti As Windows.Forms.Button
    Friend WithEvents txA As Windows.Forms.TextBox
    Friend WithEvents txB As Windows.Forms.TextBox
    Friend WithEvents txC As Windows.Forms.TextBox
    Friend WithEvents lbA As Windows.Forms.Label
    Friend WithEvents lbB As Windows.Forms.Label
    Friend WithEvents lbC As Windows.Forms.Label
    Friend WithEvents cbRovnoramenny As Windows.Forms.CheckBox
    Friend WithEvents sbA As Windows.Forms.VScrollBar
    Friend WithEvents cbbarvy As Windows.Forms.ComboBox
    Friend WithEvents pbA As Windows.Forms.ProgressBar
End Class
