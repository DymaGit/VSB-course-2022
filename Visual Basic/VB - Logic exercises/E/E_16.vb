Module E_16


    Sub main()
        Dim b As Byte, a As Byte, win1 As Byte, win2 As Byte, barva1 As Byte, barva2 As Byte
        Dim karty(50, 50) As Integer, tah(10, 10) As Integer, rnda As Integer, rndb As Integer
        Dim hrac1 As Integer, hrac2 As Integer
        Dim ok As Boolean
        Dim r As New Random
        Dim vypis As String, vyhra As String, cislo1 As String, cislo2 As String, znak1 As String, znak2 As String

        cislo1 = ""
        cislo2 = ""
        znak1 = ""
        znak2 = ""
        vypis = "hráč 1 " + Chr(9) + Chr(9) + "hráč2" + Chr(10) + Chr(10)
        a = 0
        'načtení karet.. 4x(různé barvy) 8 karet
        For b = 0 To 3
            For i = 7 To 14
                karty(a, b) = i
                a = a + 1
            Next
            a = 0
        Next

        'načtení pole tah.. všechno na nulu
        For b = 0 To 3
            For a = 0 To 7
                tah(a, b) = 0
            Next
        Next

        For x = 1 To 16

            Do
                rnda = r.Next(0, 8)
                rndb = r.Next(0, 4)

                If tah(rnda, rndb) < 1 Then             'tažení a uložení karty 1. hráč
                    ok = True
                    hrac1 = karty(rnda, rndb)
                    barva1 = rndb
                    tah(rnda, rndb) = tah(rnda, rndb) + 1
                Else
                    ok = False
                End If
            Loop While ok = False


            Do
                rnda = r.Next(0, 8)
                rndb = r.Next(0, 4)

                If tah(rnda, rndb) < 1 Then             'tažení a uložení karty 2. hráč
                    ok = True
                    hrac2 = karty(rnda, rndb)
                    barva2 = rndb
                    tah(rnda, rndb) = tah(rnda, rndb) + 1
                Else
                    ok = False
                End If
            Loop While ok = False

            If hrac1 > hrac2 Then   'součet výher
                win1 = win1 + 1
            ElseIf hrac2 > hrac1 Then
                win2 = win2 + 1
            End If

            If hrac1 > 10 Then          'převod na junek+ a barvy
                If hrac1 = 11 Then
                    cislo1 = "junek "
                ElseIf hrac1 = 12 Then
                    cislo1 = "dáma "
                ElseIf hrac1 = 13 Then
                    cislo1 = "král "
                ElseIf hrac1 = 14 Then
                    cislo1 = "eso "
                End If

            ElseIf hrac1 < 11 Then
                cislo1 = hrac1
            End If

            If hrac2 > 10 Then
                If hrac2 = 11 Then
                    cislo2 = "junek "
                ElseIf hrac2 = 12 Then
                    cislo2 = "dáma "
                ElseIf hrac2 = 13 Then
                    cislo2 = "král "
                ElseIf hrac2 = 14 Then
                    cislo2 = "eso "
                End If
            ElseIf hrac2 < 11 Then
                cislo2 = hrac2
            End If

            If barva1 = 0 Then
                znak1 = "s"
            ElseIf barva1 = 1 Then
                znak1 = "p"
            ElseIf barva1 = 2 Then
                znak1 = "ká"
            ElseIf barva1 = 3 Then
                znak1 = "kř"
            End If

            If barva2 = 0 Then
                znak2 = "s"

            ElseIf barva2 = 1 Then
                znak2 = "p"

            ElseIf barva2 = 2 Then
                znak2 = "ká"
            ElseIf barva2 = 3 Then
                znak2 = "kř"
            End If

            vypis = vypis + cislo1 + " " + znak1 + Chr(9) + Chr(9) + cislo2 + " " + znak2 + Chr(10)

        Next

        If win1 > win2 Then
            vyhra = "vyhrál hráč 1"
        Else
            vyhra = "vyhrál hráč 2"
        End If

        MsgBox(vypis + Chr(10) + vyhra + Chr(10) + Str(win1) + "/" + Str(win2))

    End Sub

End Module
