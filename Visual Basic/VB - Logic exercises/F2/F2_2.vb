Module F2_2
    Sub main()
        Dim polenah(49) As Long, polenahoc() As Long, policko() As Long
        Dim i As Byte
        Dim r As New Random
        Dim vypis As String, vypis2 As String, vypis3 As String

        vypis = ""
        vypis2 = ""
        vypis3 = ""
        For i = 0 To 49
            polenah(i) = r.Next(1, 50)
        Next

        polenahoc = ocistaF(polenah)
        ocistaS(polenah, policko)
        For i = 0 To 49
            polenahoc(i) = polenahoc(i)
            policko(i) = policko(i)
            vypis = vypis + Str(polenah(i))
            If polenahoc(i) > 0 Then            'asi by šlo i lépe vymazat nepoužíté buňky pole.. možná UBoundem-(max-y).. 
                vypis2 = vypis2 + Str(polenahoc(i))
                vypis3 = vypis3 + Str(policko(i))
            End If
        Next

        MsgBox("původní nah. čísla: " + vypis + Chr(10) + "nah. čísla bez opakování fce: " + vypis2 + Chr(10) + "nah. čísla bez opakování sbrtn: " + vypis3)

    End Sub


    Function ocistaF(pole() As Long) As Long()
        Dim pocet(49) As Long
        Dim nove(49) As Long 'tady by se dalo použít UBound (odkaz na příchozí pole), ale řekl bych že je to jedno
        Dim x As Byte
        Dim y As Byte
        For x = 0 To 49
            pocet(x) = 0
        Next
        y = 0
        For x = 0 To 49

            If pocet(pole(x)) = 0 Then
                pocet(pole(x)) = 1

                If pocet(pole(x)) = 1 Then
                    nove(y) = pole(x)
                    If pocet(pole(x)) = 1 Then
                        y = y + 1
                    End If
                    pocet(pole(x)) = pocet(pole(x)) + 1
                End If
            End If

        Next
        ocistaF = nove
    End Function

    Sub ocistaS(pole() As Long, ByRef policko() As Long)
        Dim pocet(49) As Long
        Dim nove(49) As Long 'tady by se dalo použít UBound (odkaz na příchozí pole), ale řekl bych že je to jedno
        Dim x As Byte
        Dim y As Byte
        For x = 0 To 49
            pocet(x) = 0
        Next
        y = 0
        For x = 0 To 49

            If pocet(pole(x)) = 0 Then
                pocet(pole(x)) = 1

                If pocet(pole(x)) = 1 Then
                    nove(y) = pole(x)
                    If pocet(pole(x)) = 1 Then
                        y = y + 1
                    End If
                    pocet(pole(x)) = pocet(pole(x)) + 1
                End If
            End If

        Next
        policko = nove

    End Sub

End Module
