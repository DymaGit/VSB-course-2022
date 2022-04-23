Public Class frHlavni
    Private Sub tlHotovo_Click(sender As Object, e As EventArgs) Handles tlHotovo.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()


    End Sub

    Private Sub tlStorno_Click(sender As Object, e As EventArgs) Handles tlStorno.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()

    End Sub

    Private Sub frHlavni_MouseMove(sender As Object, e As Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        Dim x = e.X
        Dim y = e.Y
        Dim T As String = x.ToString + "   -   " + y.ToString
        Me.Text = T


    End Sub

    Private Sub tmCas_Tick(sender As Object, e As EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.Abort
        Me.Close()
    End Sub



    Private Sub tlVypocti_Click(sender As Object, e As EventArgs) Handles tlVypocti.Click

        VypoctiPreponu()

    End Sub


    Sub VypoctiPreponu()
        Dim a As Double
        Dim b As Double
        Dim c As Double

        a = CDbl(Val(Me.txA.Text))

        If Me.cbRovnoramenny.Checked Then
            b = a

        Else
            b = CDbl(Val(Me.txB.Text))
        End If

        c = Math.Sqrt(a * a + b * b)
        Me.txC.Text = c.ToString("# ##0.00")


    End Sub

    Private Sub cbRovnoramenny_CheckedChanged(sender As Object, e As EventArgs) Handles cbRovnoramenny.CheckedChanged

        If cbRovnoramenny.Checked Then
            txB.Visible = False
            lbB.Visible = False
        Else
            txB.Visible = True
            lbB.Visible = True
        End If

    End Sub

    Private Sub txA_TextChanged(sender As Object, e As EventArgs) Handles txA.TextChanged

        VypoctiPreponu()


    End Sub

    Private Sub txB_TextChanged(sender As Object, e As EventArgs) Handles txB.TextChanged
        VypoctiPreponu()
    End Sub

    Private Sub txA_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txA.KeyPress
        Dim znak As String = e.KeyChar

        If znak >= "0" And znak <= "9" Then
            e.Handled = False
        Else e.Handled = True
        End If


    End Sub

    Private Sub sbA_Scroll(sender As Object, e As Windows.Forms.ScrollEventArgs) Handles sbA.Scroll
        Dim T As String = sbA.Value.ToString.Trim
        txA.Text = T
        Me.pbA.Value = sbA.Value
    End Sub

    Private Sub frHlavni_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        With Me.cbbarvy.Items
            .Clear()
            .Add("zelena")
            .Add("modra")
            .Add("cervena")
        End With


    End Sub

    Private Sub cbbarvy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbarvy.SelectedIndexChanged
        Dim i As Integer = Me.cbbarvy.SelectedIndex
        Dim T As String = Me.cbbarvy.Text
        Dim H As String = "vybrana položka " + i.ToString + " " + T
        MsgBox(H)


    End Sub
End Class