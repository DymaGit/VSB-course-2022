Module B_15

    Sub main()
        Dim pocasi As String

        pocasi = InputBox("Jak je venku? vedro/zima/déšť/mlha/chumelenice")

        Select Case pocasi
            Case "vedro"
                MsgBox("Běž tedy na bazén")
            Case "zima"
                MsgBox("Dobře se obleč")
            Case "déšť"
                MsgBox("Vem si deštník")
            Case "mlha"
                MsgBox("Nezapomeň si zapnout mlhovky")
            Case "chumelenice"
                MsgBox("Pozor ať se neztratíš")
        End Select

    End Sub

End Module
