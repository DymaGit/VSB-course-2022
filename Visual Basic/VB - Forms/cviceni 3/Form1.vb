Imports System.Windows.Forms
Public Class Form1
    Public jakost As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Maximum = cas * 1000
        Timer1.Start()
        Timer2.Start()
        ToolStripStatusLabel1.Text = DateTime.Now.ToLongTimeString
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += Timer1.Interval
        If ProgressBar1.Value = ProgressBar1.Maximum Then Timer1.Stop()
    End Sub
    Private Sub KonecToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KonecToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub OtevřítToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OtevřítToolStripMenuItem.Click
        With OpenFileDialog1
            .Filter = "Vše(*.*)|*.*"
            .FilterIndex = 1
        End With
        Dim tlac As DialogResult
        tlac = OpenFileDialog1.ShowDialog()
        If (tlac.Equals(DialogResult.OK)) Then
            FileOpen(1, OpenFileDialog1.FileName, OpenMode.Input)
            Input(1, TextBox1.Text) : FileClose(1)
        End If
        ProgressBar1.Value = 0
        Timer1.Start()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ovoce()
    End Sub
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        ovoce()
    End Sub
    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        ovoce()
    End Sub
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Label2.Text = "součin je: " + (NumericUpDown1.Value * NumericUpDown2.Value).ToString
    End Sub
    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        Label2.Text = "součin je: " + (NumericUpDown1.Value * NumericUpDown2.Value).ToString
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        jakost = RadioButton1.Text
        ovoce()
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        jakost = RadioButton2.Text
        ovoce()
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        jakost = RadioButton3.Text
        ovoce()
    End Sub
    Sub ovoce()
        Label1.Text = ComboBox1.Text + " " + Str(TrackBar1.Value) + " kg " + jakost
    End Sub
    Private Sub NápovědaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NápovědaToolStripMenuItem.Click
        MsgBox("Ttoto je nápověda k tomuto programu")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Visible = False
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Visible = True
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        cb()
    End Sub

    Sub cb()
        Dim check(0 To 6) As Integer
        Dim soucet As Integer
        soucet = 0
        If CheckBox1.Checked() Then check(0) = 1 Else check(0) = 0
        If CheckBox2.Checked() Then check(1) = 1 Else check(1) = 0
        If CheckBox3.Checked() Then check(2) = 1 Else check(2) = 0
        If CheckBox4.Checked() Then check(3) = 1 Else check(3) = 0
        If CheckBox5.Checked() Then check(4) = 1 Else check(4) = 0
        If CheckBox6.Checked() Then check(5) = 1 Else check(5) = 0
        If CheckBox7.Checked() Then check(6) = 1 Else check(6) = 0
        For i = 0 To 6
            soucet = soucet + check(i)
        Next
        ToolStripStatusLabel2.Text = "Počet zatrhnutých checkboxů: " + soucet.ToString
    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        cb()
    End Sub
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        cb()
    End Sub
    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        cb()
    End Sub
    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        cb()
    End Sub
    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        cb()
    End Sub
    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        cb()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Start()
        ToolStripStatusLabel1.Text = DateTime.Now.ToLongTimeString
    End Sub
End Class