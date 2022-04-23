





Module mdHlavni

    Sub Main()
        Dim frA As New frHlavni
        Dim Ukonceni As System.Windows.Forms.DialogResult
        frA.Text = "Ja jsem A"
        Ukonceni = frA.ShowDialog()
        MsgBox(Ukonceni.ToString)

    End Sub

End Module
