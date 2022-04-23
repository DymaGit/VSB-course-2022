Module Module1

    Sub Main()
        Dim frm As New Formular1
        Dim nazev As String


        nazev = InputBox("zadej název formuláře" + Chr(10) + "(název je: Formular1)")

        If nazev = "Formular1" Then
            frm.ShowDialog()
        End If


    End Sub

End Module
