Module E_15
    Sub main()
        Dim slova As String
        Dim max As Byte
        Dim pismena(99) As String, vystup As String

        vystup = ""
        slova = InputBox("zadej pár slov")

        max = Len(slova)

        For i = 1 To max
            pismena(i) = Mid(slova, i, 1)

            Select Case pismena(i)
                Case "a"
                    vystup = vystup + ".-/"
                Case "b"
                    vystup = vystup + "-.../"
                Case "c"
                    vystup = vystup + "-.-./"
                Case "d"
                    vystup = vystup + "-../"
                Case "e"
                    vystup = vystup + "./"
                Case "f"
                    vystup = vystup + "..-./"
                Case "g"
                    vystup = vystup + "--./"
                Case "h"
                    vystup = vystup + "..../"
                Case "i"
                    vystup = vystup + "../"
                Case "j"
                    vystup = vystup + ".---/"
                Case "k"
                    vystup = vystup + "-.-/"
                Case "l"
                    vystup = vystup + ".-../"
                Case "m"
                    vystup = vystup + "--/"
                Case "n"
                    vystup = vystup + "-./"
                Case "o"
                    vystup = vystup + "---/"
                Case "p"
                    vystup = vystup + ".--./"
                Case "q"
                    vystup = vystup + "--.-/"
                Case "r"
                    vystup = vystup + ".-./"
                Case "s"
                    vystup = vystup + ".../"
                Case "t"
                    vystup = vystup + "-/"
                Case "u"
                    vystup = vystup + "..-/"
                Case "v"
                    vystup = vystup + "...-/"
                Case "w"
                    vystup = vystup + ".--/"
                Case "q"
                    vystup = vystup + "-..-/"
                Case "y"
                    vystup = vystup + "-.--/"
                Case "z"
                    vystup = vystup + "--../"
                Case " "
                    vystup = vystup + "//"
            End Select
        Next

        MsgBox(vystup)

    End Sub
End Module
