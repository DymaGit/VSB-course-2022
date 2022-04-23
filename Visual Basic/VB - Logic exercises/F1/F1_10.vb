Module F1_10
    Sub main()
        Dim text As String
        Dim nospace As String
        text = InputBox("zadej více slov")

        bezmezerS(text, nospace)
        MsgBox("funkce: " + bezmezerF(text) + Chr(10) + "subrutina: " + nospace)

    End Sub



    Function bezmezerF(veta) As String
        bezmezerF = Replace(veta, " ", "")
    End Function


    Sub bezmezerS(veta As String, ByRef nospace As String)

        nospace = Replace(veta, " ", "")

    End Sub

End Module
