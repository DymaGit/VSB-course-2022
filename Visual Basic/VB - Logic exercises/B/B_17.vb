Module B_17
    Sub main()
        Dim kc As Integer
        Dim mena As String

        kc = Val(InputBox("Zadej částku. (kč)"))
        mena = InputBox("Zadej měnu. usd/eur/gbp/hrk")

        Select Case mena
            Case "usd"
                MsgBox(kc / 21)
            Case "eur"
                MsgBox(kc / 26)
            Case "gbp"
                MsgBox(kc / 30)
            Case "hrk"
                MsgBox(kc / 3)
        End Select
    End Sub

End Module
