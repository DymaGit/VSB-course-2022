Module B_16
    Sub main()
        Dim cislo1 As Integer, cislo2 As Integer
        Dim operace As String

        cislo1 = Val(InputBox("zadej číslo 1"))
        cislo2 = Val(InputBox("zadej číslo 2"))
        operace = InputBox("zadej operaci. scitat/odcitat/nasobit/delit/koncit ")

        Select Case operace
            Case "scitat"
                MsgBox(cislo1 + cislo2)
            Case "odcitat"
                MsgBox(cislo1 - cislo2)
            Case "nasobit"
                MsgBox(cislo1 * cislo2)
            Case "delit"
                MsgBox(cislo1 / cislo2)
            Case "koncit"
                End
        End Select

    End Sub
End Module
