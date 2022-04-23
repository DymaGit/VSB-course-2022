Module B_18
    Sub main()
        Dim mesic As Byte
        Dim dni As Byte

        mesic = Val(InputBox("Zadej číslo měsíce. 1-12"))

        If mesic < 8 Then
            If mesic Mod 2 = 0 Then
                dni = 30
                If mesic = 2 Then
                    dni = 28
                End If
            Else
                dni = 31
            End If
        Else
            If mesic Mod 2 = 1 Then
                dni = 30
            Else
                dni = 31
            End If
        End If

        Select Case mesic
            Case 1
                MsgBox("Leden má" + Str(dni) + " dní.")
            Case 2
                MsgBox("Únor má" + Str(dni) + " dní.")
            Case 3
                MsgBox("Březn má" + Str(dni) + " dní.")
            Case 4
                MsgBox("Duben má" + Str(dni) + " dní.")
            Case 5
                MsgBox("Květen má" + Str(dni) + " dní.")
            Case 6
                MsgBox("Červen má" + Str(dni) + " dní.")
            Case 7
                MsgBox("Červenec má" + Str(dni) + " dní.")
            Case 8
                MsgBox("Srpen má" + Str(dni) + " dní.")
            Case 9
                MsgBox("Září má" + Str(dni) + " dní.")
            Case 10
                MsgBox("Říjen má" + Str(dni) + " dní.")
            Case 11
                MsgBox("Listopad má" + Str(dni) + " dní.")
            Case 12
                MsgBox("Prosinec má" + Str(dni) + " dní.")
        End Select

    End Sub

End Module
