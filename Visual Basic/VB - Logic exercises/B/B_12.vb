Module B_12

    Sub main()
        Dim den As String, teplota As String

        den = InputBox("je den? y/n")
        teplota = InputBox("je horko? y/n")

        'závorky jsou nutné, jinak to nefunguje správně
        If (den = "y" Or den = "Y") And (teplota = "y" Or teplota = "Y") Then
            MsgBox("běž si tedy zaplavat když je den a horko.")
        Else
            MsgBox("ok tak to je na pytel")
        End If

    End Sub

End Module
