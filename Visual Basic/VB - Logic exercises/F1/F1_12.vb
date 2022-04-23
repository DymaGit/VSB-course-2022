Module F1_12
    Sub main()
        Dim den As Byte, mesic As Byte, rok As Integer
        Dim cislo As Integer

        mesic = Val(InputBox("zadej číslo měsíce"))
        den = Val(InputBox("zadej číslo dne"))
        rok = Val(InputBox("zadej číslo roku"))

        cislodnevroceS(mesic, den, rok, cislo)
        MsgBox("funkce:" + Str(cislodnevroceF(mesic, den, rok)) + Chr(10) + "subrutina: " + Str(cislo))

    End Sub


    Function cislodnevroceF(month As Integer, day As Integer, year As Integer) As Integer
        Dim prestup As Boolean
        Dim unor As Byte, pocetdni As Integer, propocet As Integer

        'vypocet prestupneho roku a zmeny unoru
        If (year Mod 100 = 0 And year Mod 400 = 0) Or (year Mod 4 = 0 And Not year Mod 100 = 0) Then
            prestup = True
        Else
            prestup = False
        End If

        If prestup = True Then
            unor = 29
        Else
            unor = 28
        End If

        'sekce k součtu dní
        If month > 1 Then
            For i = 1 To month - 1

                If i < 8 And i > 0 Then
                    If i Mod 2 = 0 Then
                        pocetdni = 30
                        If i = 2 Then
                            pocetdni = unor
                        End If
                    Else
                        pocetdni = 31
                    End If
                ElseIf i > 7 And i < 13 Then
                    If i Mod 2 = 1 Then
                        pocetdni = 30
                    Else
                        pocetdni = 31
                    End If
                End If
                propocet = propocet + pocetdni
            Next
        End If
        cislodnevroceF = day + propocet

        'podmínky pro neexistující datum
        If month = 2 And day > unor Then
            cislodnevroceF = -1
        End If

        If day < 1 Or day > 31 Then
            cislodnevroceF = -1
        End If
        If month < 1 Or month > 12 Then
            cislodnevroceF = -1
        End If

    End Function

    Sub cislodnevroceS(month As Integer, day As Integer, year As Integer, ByRef cislo As Integer)
        Dim prestup As Boolean
        Dim unor As Byte, pocetdni As Integer, propocet As Integer

        'vypocet prestupneho roku a zmeny unoru
        If (year Mod 100 = 0 And year Mod 400 = 0) Or (year Mod 4 = 0 And Not year Mod 100 = 0) Then
            prestup = True
        Else
            prestup = False
        End If

        If prestup = True Then
            unor = 29
        Else
            unor = 28
        End If

        'sekce k součtu dní
        If month > 1 Then
            For i = 1 To month - 1

                If i < 8 And i > 0 Then
                    If i Mod 2 = 0 Then
                        pocetdni = 30
                        If i = 2 Then
                            pocetdni = unor
                        End If
                    Else
                        pocetdni = 31
                    End If
                ElseIf i > 7 And i < 13 Then
                    If i Mod 2 = 1 Then
                        pocetdni = 30
                    Else
                        pocetdni = 31
                    End If
                End If
                propocet = propocet + pocetdni
            Next
        End If
        cislo = day + propocet

        'podmínky pro neexistující datum
        If month = 2 And day > unor Then
            cislo = -1
        End If

        If day < 1 Or day > 31 Then
            cislo = -1
        End If
        If month < 1 Or month > 12 Then
            cislo = -1
        End If
    End Sub
End Module
