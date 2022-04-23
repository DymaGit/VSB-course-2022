Imports System.Windows.Forms
Imports Scripting
Public Class Formular1

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Me.Label2.Text = Me.TrackBar1.Value
        vypocet()

    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click

        MsgBox("toto je nápověda")

    End Sub

    Private Sub tb1_TextChanged(sender As Object, e As EventArgs) Handles tb1.TextChanged

        vypocet()

    End Sub

    Private Sub tb2_TextChanged(sender As Object, e As EventArgs) Handles tb2.TextChanged
        vypocet()

    End Sub

    Private Sub nud1_ValueChanged(sender As Object, e As EventArgs) Handles nud1.ValueChanged
        vypocet()
    End Sub

    Sub vypocet()
        Dim a As Double
        Dim b As Double
        Dim c As Double
        Dim d As Double
        a = CDbl(Val(tb1.Text))
        b = CDbl(Val(tb2.Text))
        c = CDbl(nud1.Value)
        d = a + b + c
        Label3.Text = d.ToString
        Label5.Text = Str(d * TrackBar1.Value)

    End Sub
    Private Sub cb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb.SelectedIndexChanged
        vypis()
    End Sub
    Private Sub cb1_CheckedChanged(sender As Object, e As EventArgs) Handles cb1.CheckedChanged
        vypis()
    End Sub

    Private Sub cb2_CheckedChanged(sender As Object, e As EventArgs) Handles cb2.CheckedChanged
        vypis()
    End Sub
    Private Sub cb3_CheckedChanged(sender As Object, e As EventArgs) Handles cb3.CheckedChanged
        vypis()
    End Sub

    Private Sub rb1_CheckedChanged(sender As Object, e As EventArgs) Handles rb1.CheckedChanged
        vypis()
    End Sub

    Private Sub rb2_CheckedChanged(sender As Object, e As EventArgs) Handles rb2.CheckedChanged
        vypis()
    End Sub

    Private Sub rb3_CheckedChanged(sender As Object, e As EventArgs) Handles rb3.CheckedChanged
        vypis()
    End Sub

    Private Sub rb4_CheckedChanged(sender As Object, e As EventArgs) Handles rb4.CheckedChanged
        vypis()
    End Sub

    Sub vypis()
        Dim vypisek(0 To 6) As String
        Dim dokupy As String = ""

        If cb1.Checked Then vypisek(0) = cb1.Text Else vypisek(0) = ""
        If cb2.Checked Then vypisek(1) = cb2.Text Else vypisek(1) = ""
        If cb3.Checked Then vypisek(2) = cb3.Text Else vypisek(2) = ""
        If rb1.Checked Then vypisek(3) = rb1.Text Else vypisek(3) = ""
        If rb2.Checked Then vypisek(4) = rb2.Text Else vypisek(4) = ""
        If rb3.Checked Then vypisek(5) = rb3.Text Else vypisek(5) = ""
        If rb4.Checked Then vypisek(6) = rb4.Text Else vypisek(6) = ""

        For i = 0 To 6
            dokupy = dokupy + " " + vypisek(i)
        Next
        Label7.Text = dokupy + " " + cb.Text
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProgressBar1.Value = 0
        Timer1.Start()
    End Sub

    Private Sub Formular1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
        ssl1.Text = DateTime.Now.ToLongTimeString
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Start()
        ssl1.Text = DateTime.Now.ToLongTimeString
    End Sub

    Private Sub VšechnySouboryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VšechnySouboryToolStripMenuItem.Click
        ofd1.Filter = "vše (*.*)|*.*"
        open()
    End Sub

    Private Sub JendocToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JendocToolStripMenuItem.Click
        ofd1.Filter = "Jen doc (*.doc;*.docx)|*.doc;*.docx"
        open()
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        sfd1.Filter = "txt (*.txt)|*.txt"
        sfd1.ShowDialog()
        FileOpen(1, sfd1.FileName, OpenMode.Output)
        Write(1, rtb1.Text)
        FileClose(1)
    End Sub

    Private Sub OtevřítToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OtevřítToolStripMenuItem.Click
        ofd1.Filter = "default (*.doc;*.docx)|*.doc;*.docx"
        open()
    End Sub

    Sub open()
        Dim fso As New FileSystemObject
        Dim tlac As DialogResult

        tlac = ofd1.ShowDialog()
        If tlac.Equals(DialogResult.OK) Then
            FileOpen(1, ofd1.FileName, OpenMode.Input)
            Input(1, rtb1.Text)
            FileClose(1)
        End If
        ssl3.Text = fso.GetAbsolutePathName(ofd1.FileName)
    End Sub

    Private Sub tb1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb1.KeyPress
        Dim znak As String = e.KeyChar
        If znak >= "0" And znak <= "9" Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub tb2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb2.KeyPress
        Dim znak As String = e.KeyChar
        If znak >= "0" And znak <= "9" Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class