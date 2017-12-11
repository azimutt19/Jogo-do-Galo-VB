Public Class Form1
    Dim i As Integer
    Private Sub reiniciar()
        TextBox1.Text = ""
        TextBox1.Enabled = True
        TextBox2.Text = ""
        TextBox2.Enabled = True
        TextBox3.Text = ""
        TextBox3.Enabled = True
        TextBox4.Text = ""
        TextBox4.Enabled = True
        TextBox5.Text = ""
        TextBox5.Enabled = True
        TextBox6.Text = ""
        TextBox6.Enabled = True
        TextBox7.Text = ""
        TextBox7.Enabled = True
        TextBox8.Text = ""
        TextBox8.Enabled = True
        TextBox9.Text = ""
        TextBox9.Enabled = True
        i = 1
    End Sub
    Private Sub repeat()
        'jogador1
        If TextBox1.Text = "X" And TextBox2.Text = "X" AndAlso TextBox3.Text = "X" Then
            MsgBox("Parabéns jogador1" & " ganhou!")
            reiniciar()
        End If
        If TextBox4.Text = "X" And TextBox5.Text = "X" AndAlso TextBox6.Text = "X" Then
            MsgBox("Parabéns jogador1" & " ganhou!")
            reiniciar()

        End If
        If TextBox7.Text = "X" And TextBox8.Text = "X" AndAlso TextBox9.Text = "X" Then
            MsgBox("Parabéns jogador1" & " ganhou!")
            reiniciar()

        End If
        If TextBox1.Text = "X" And TextBox4.Text = "X" AndAlso TextBox7.Text = "X" Then
            MsgBox("Parabéns jogador1" & " ganhou!")
            reiniciar()
        End If
        If TextBox2.Text = "X" And TextBox5.Text = "X" AndAlso TextBox8.Text = "X" Then
            MsgBox("Parabéns jogador1" & " ganhou!")
            reiniciar()
        End If
        If TextBox3.Text = "X" And TextBox6.Text = "X" AndAlso TextBox9.Text = "X" Then
            MsgBox("Parabéns jogador1" & " ganhou!")
            reiniciar()
        End If
        If TextBox1.Text = "X" And TextBox5.Text = "X" AndAlso TextBox9.Text = "X" Then
            MsgBox("Parabéns jogador1" & " ganhou!")
            reiniciar()
        End If
        If TextBox3.Text = "X" And TextBox5.Text = "X" AndAlso TextBox7.Text = "X" Then
            MsgBox("Parabéns jogador1" & " ganhou!")
            reiniciar()
        End If

        'jogador2
        If TextBox1.Text = "0" And TextBox2.Text = "0" AndAlso TextBox3.Text = "0" Then
            MsgBox("Parabéns jogador2" & " ganhou!")
            reiniciar()
        End If
        If TextBox4.Text = "0" And TextBox5.Text = "0" AndAlso TextBox6.Text = "0" Then
            MsgBox("Parabéns jogador2" & " ganhou!")
            reiniciar()

        End If
        If TextBox7.Text = "0" And TextBox8.Text = "0" AndAlso TextBox9.Text = "0" Then
            MsgBox("Parabéns jogador2" & " ganhou!")
            reiniciar()
        End If
        If TextBox1.Text = "0" And TextBox4.Text = "0" AndAlso TextBox7.Text = "0" Then
            MsgBox("Parabéns jogador2" & " ganhou!")
            reiniciar()
        End If
        If TextBox2.Text = "0" And TextBox5.Text = "0" AndAlso TextBox8.Text = "0" Then
            MsgBox("Parabéns jogador2" & " ganhou!")
            reiniciar()
        End If
        If TextBox3.Text = "0" And TextBox6.Text = "0" AndAlso TextBox9.Text = "0" Then
            MsgBox("Parabéns jogador2" & " ganhou!")
            reiniciar()
        End If
        If TextBox1.Text = "0" And TextBox5.Text = "0" AndAlso TextBox9.Text = "0" Then
            MsgBox("Parabéns jogador2" & " ganhou!")
            reiniciar()
        End If
        If TextBox3.Text = "0" And TextBox5.Text = "0" AndAlso TextBox7.Text = "0" Then
            MsgBox("Parabéns jogador2" & " ganhou!")
            reiniciar()
        End If
        'empate
        If i = 10 Then
            MsgBox("O jogo acabou empatado!")
            reiniciar()
        End If


    End Sub


    Private Sub textbox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.DoubleClick
        If i Mod 2 = 0 And i < 10 Then
            TextBox1.Text = "0"
            repeat()
            TextBox1.Enabled = False
            i = i + 1
        Else
            TextBox1.Text = "X"
            repeat()
            TextBox1.Enabled = False
            i = i + 1
        End If

    End Sub
    Private Sub textbox2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.DoubleClick
        If i Mod 2 = 0 And i < 10 Then
            TextBox2.Text = "0"
            repeat()
            TextBox2.Enabled = False
            i = i + 1
        Else
            TextBox2.Text = "X"
            repeat()
            TextBox2.Enabled = False
            i = i + 1
        End If

    End Sub
    Private Sub textbox3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.DoubleClick
        If i Mod 2 = 0 And i < 10 Then
            TextBox3.Text = "0"
            repeat()
            TextBox3.Enabled = False
            i = i + 1
        Else
            TextBox3.Text = "X"
            repeat()
            TextBox3.Enabled = False
            i = i + 1
        End If

    End Sub
    Private Sub textbox4_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox4.DoubleClick
        If i Mod 2 = 0 And i < 10 Then
            TextBox4.Text = "0"
            repeat()
            TextBox4.Enabled = False
            i = i + 1
        Else
            TextBox4.Text = "X"
            repeat()
            TextBox4.Enabled = False
            i = i + 1
        End If

    End Sub
    Private Sub textbox5_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.DoubleClick
        If i Mod 2 = 0 And i < 10 Then
            TextBox5.Text = "0"
            repeat()
            TextBox5.Enabled = False
            i = i + 1
        Else
            TextBox5.Text = "X"
            repeat()
            TextBox5.Enabled = False
            i = i + 1
        End If

    End Sub
    Private Sub textbox6_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox6.DoubleClick
        If i Mod 2 = 0 And i < 10 Then
            TextBox6.Text = "0"
            repeat()
            TextBox6.Enabled = False
            i = i + 1
        Else
            TextBox6.Text = "X"
            repeat()
            TextBox6.Enabled = False
            i = i + 1
        End If

    End Sub
    Private Sub textbox7_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox7.DoubleClick
        If i Mod 2 = 0 And i < 10 Then
            TextBox7.Text = "0"
            repeat()
            TextBox7.Enabled = False
            i = i + 1
        Else
            TextBox7.Text = "X"
            repeat()
            TextBox7.Enabled = False
            i = i + 1
        End If

    End Sub
    Private Sub textbox8_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox8.DoubleClick
        If i Mod 2 = 0 And i < 10 Then
            TextBox8.Text = "0"
            repeat()
            TextBox8.Enabled = False
            i = i + 1
        Else
            TextBox8.Text = "X"
            repeat()
            TextBox8.Enabled = False
            i = i + 1
        End If

    End Sub
    Private Sub textbox9_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox9.DoubleClick
        If i Mod 2 = 0 And i < 10 Then
            TextBox9.Text = "0"
            repeat()
            TextBox9.Enabled = False
            i = i + 1
        Else
            TextBox9.Text = "X"
            repeat()
            TextBox9.Enabled = False
            i = i + 1
        End If

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Dim resp As Integer
        resp = MsgBox("Tem a certeza que pretende abandonar a aplicação?", MsgBoxStyle.YesNo, "Abandonar")
        If resp = 6 Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        i = 1
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        'Dim semvalor, wtv, jogador, i As Integer
        'jogador = 1
        'wtv = 0
        'i = 1
        'Dim jogada = "X"

        'Do Until i > 9
        '    Do While wtv = 0
        '        semvalor = InputBox("TURNO" & i & ": JOGADOR" & jogador)
        '        Select Case semvalor
        '            Case "1" : If TextBox1.Text = "1" Then
        '                    TextBox1.Text = jogada
        '                    wtv = 1
        '                Else
        '                    MsgBox("Numero ja inserido")
        '                    wtv = 0
        '                End If

        '            Case "2" : If TextBox2.Text = "2" Then
        '                    TextBox2.Text = jogada
        '                    wtv = 1
        '                Else
        '                    MsgBox("Numero ja inserido")
        '                    wtv = 0
        '                End If

        '            Case "3" : If TextBox3.Text = "3" Then
        '                    TextBox3.Text = jogada
        '                    wtv = 1
        '                Else
        '                    MsgBox("Numero ja inserido")
        '                    ' wtv = 0
        '                End If
        '            Case "4" : If TextBox4.Text = "4" Then
        '                    TextBox4.Text = jogada
        '                    '  wtv = 1
        '                Else
        '                    MsgBox("Numero ja inserido")
        '                    '  wtv = 0
        '                End If

        '            Case "5" : If TextBox5.Text = "5" Then
        '                    TextBox5.Text = jogada
        '                    '  wtv = 1
        '                Else
        '                    MsgBox("Numero ja inserido")
        '                    '  wtv = 0
        '                End If

        '            Case "6" : If TextBox6.Text = "6" Then
        '                    TextBox6.Text = jogada
        '                    ' wtv = 1
        '                Else
        '                    MsgBox("Numero ja inserido")
        '                    ' wtv = 0
        '                End If

        '            Case "7" : If TextBox7.Text = "7" Then
        '                    TextBox7.Text = jogada
        '                    ' wtv = 1
        '                Else
        '                    MsgBox("Numero ja inserido")
        '                    ' wtv = 0
        '                End If

        '            Case "8" : If TextBox8.Text = "8" Then
        '                    TextBox8.Text = jogada
        '                    ' wtv = 1
        '                Else
        '                    MsgBox("Numero ja inserido")
        '                    '  wtv = 0
        '                End If

        '            Case "9" : If TextBox9.Text = "9" Then
        '                    TextBox9.Text = jogada
        '                    ' wtv = 1
        '                Else
        '                    MsgBox("Numero ja inserido")
        '                    ' wtv = 0
        '                End If

        '            Case Else : MsgBox("Insira um numero válido")

        '                ' wtv = 0
        '        End Select
        '    Loop
        '    If TextBox1.Text = jogada And TextBox2.Text = jogada AndAlso TextBox3.Text = jogada Then
        '            MsgBox("Parabéns jogador" & jogador & " ganhou!")
        '            Exit Do
        '        End If
        '        If TextBox4.Text = jogada And TextBox5.Text = jogada AndAlso TextBox6.Text = jogada Then
        '            MsgBox("Parabéns jogador" & jogador & " ganhou!")
        '            Exit Do
        '        End If
        '        If TextBox7.Text = jogada And TextBox8.Text = jogada AndAlso TextBox9.Text = jogada Then
        '            MsgBox("Parabéns jogador" & jogador & " ganhou!")
        '            Exit Do
        '        End If
        '        If TextBox1.Text = jogada And TextBox4.Text = jogada AndAlso TextBox7.Text = jogada Then
        '            MsgBox("Parabéns jogador" & jogador & " ganhou!")
        '            Exit Do
        '        End If
        '        If TextBox2.Text = jogada And TextBox5.Text = jogada AndAlso TextBox8.Text = jogada Then
        '            MsgBox("Parabéns jogador" & jogador & " ganhou!")
        '            Exit Do
        '        End If
        '        If TextBox3.Text = jogada And TextBox6.Text = jogada AndAlso TextBox9.Text = jogada Then
        '            MsgBox("Parabéns jogador" & jogador & " ganhou!")
        '            Exit Do
        '        End If
        '        If TextBox1.Text = jogada And TextBox5.Text = jogada AndAlso TextBox9.Text = jogada Then
        '            MsgBox("Parabéns jogador" & jogador & " ganhou!")
        '            Exit Do
        '        End If
        '        If TextBox3.Text = jogada And TextBox5.Text = jogada AndAlso TextBox7.Text = jogada Then
        '            MsgBox("Parabéns jogador" & jogador & " ganhou!")
        '            Exit Do
        '        End If


        '        If jogador = "1" Then
        '            jogador = "2"
        '            jogada = "0"
        '        Else
        '            jogador = "1"
        '            jogada = "X"
        '        End If

        '        i = i + 1
        '        If i = 10 Then
        '            MsgBox("O jogo acabou empatado!")
        '        End If

        '    Loop
        'For i As Integer = 1 To 9
        '    Do
        '        semvalor = InputBox("TURNO" & i & ": JOGADOR1")
        '        Select Case semvalor
        '            Case "1" : If TextBox1.Text = "1" Then TextBox1.Text = "x" And wtv = 1 Else MsgBox("Numero ja inserido") wtv = 0
        '            Case "2" : If TextBox2.Text = "2" Then TextBox2.Text = "x" And wtv = 1 Else MsgBox("Numero ja inserido") wtv = 0
        '            Case "3" : If TextBox3.Text = "3" Then TextBox3.Text = "x" And wtv = 1 Else MsgBox("Numero ja inserido") wtv = 0
        '            Case "4" : If TextBox4.Text = "4" Then TextBox4.Text = "x" And wtv = 1 Else MsgBox("Numero ja inserido") wtv = 0
        '            Case "5" : If TextBox5.Text = "5" Then TextBox5.Text = "x" And wtv = 1 Else MsgBox("Numero ja inserido") wtv = 0
        '            Case "6" : If TextBox6.Text = "6" Then TextBox6.Text = "x" And wtv = 1 Else MsgBox("Numero ja inserido") wtv = 0
        '            Case "7" : If TextBox7.Text = "7" Then TextBox7.Text = "x" And wtv = 1 Else MsgBox("Numero ja inserido") wtv = 0
        '            Case "8" : If TextBox8.Text = "8" Then TextBox8.Text = "x" And wtv = 1 Else MsgBox("Numero ja inserido") wtv = 0
        '            Case "9" : If TextBox9.Text = "9" Then TextBox9.Text = "x" And wtv = 1 Else MsgBox("Numero ja inserido") wtv = 0
        '            Case Else : MsgBox("Insira um numero válido")
        '                i = i - 1
        '        End Select
        '    Loop Until wtv = 1
        '    i = i + 1
        '    If TextBox1.Text = "x" And TextBox2.Text = "x" And TextBox3.Text = "x" Then
        '        MsgBox("Parabéns JOGADOR1! GANHOU!")
        '    End If
        '    If TextBox4.Text = "x" And TextBox5.Text = "x" And TextBox6.Text = "x" Then
        '        MsgBox("Parabéns JOGADOR1! GANHOU!")
        '    End If
        '    If TextBox7.Text = "x" And TextBox8.Text = "x" And TextBox9.Text = "x" Then
        '        MsgBox("Parabéns JOGADOR1! GANHOU!")
        '    End If
        '    If TextBox1.Text = "x" And TextBox4.Text = "x" And TextBox7.Text = "x" Then
        '        MsgBox("Parabéns JOGADOR1! GANHOU!")
        '    End If
        '    If TextBox2.Text = "x" And TextBox5.Text = "x" And TextBox8.Text = "x" Then
        '        MsgBox("Parabéns JOGADOR1! GANHOU!")
        '    End If
        '    If TextBox3.Text = "x" And TextBox6.Text = "x" And TextBox9.Text = "x" Then
        '        MsgBox("Parabéns JOGADOR1! GANHOU!")
        '    End If
        '    If TextBox1.Text = "x" And TextBox5.Text = "x" And TextBox9.Text = "x" Then
        '        MsgBox("Parabéns JOGADOR1! GANHOU!")
        '    End If
        '    If TextBox3.Text = "x" And TextBox5.Text = "x" And TextBox7.Text = "x" Then
        '        MsgBox("Parabéns JOGADOR1! GANHOU!")
        '    End If




        '    Do
        '        semvalor2 = InputBox("TURNO" & i & ": JOGADOR2")
        '        Select Case semvalor2
        '            Case "1" : If TextBox1.Text = "1" Then TextBox1.Text = "0" And wtv = 1 Else MsgBox("Numero ja inserido") wtv = 0
        '            Case "2" : If TextBox2.Text = "2" Then TextBox2.Text = "0" And wtv = 1 Else MsgBox("Numero ja inserido") wtv = 0
        '            Case "3" : If TextBox3.Text = "3" Then TextBox3.Text = "0" And wtv = 1 Else MsgBox("Numero ja inserido") wtv = 0
        '            Case "4" : If TextBox4.Text = "4" Then TextBox4.Text = "0" And wtv = 1 Else MsgBox("Numero ja inserido") wtv = 0
        '            Case "5" : If TextBox5.Text = "5" Then TextBox5.Text = "0" And wtv = 1 Else MsgBox("Numero ja inserido") wtv = 0
        '            Case "6" : If TextBox6.Text = "6" Then TextBox6.Text = "0" And wtv = 1 Else MsgBox("Numero ja inserido") wtv = 0
        '            Case "7" : If TextBox7.Text = "7" Then TextBox7.Text = "0" And wtv = 1 Else MsgBox("Numero ja inserido") wtv = 0
        '            Case "8" : If TextBox8.Text = "8" Then TextBox8.Text = "0" And wtv = 1 Else MsgBox("Numero ja inserido") wtv = 0
        '            Case "9" : If TextBox9.Text = "9" Then TextBox9.Text = "0" And wtv = 1 Else MsgBox("Numero ja inserido") wtv = 0
        '            Case Else : MsgBox("Insira um numero válido")
        '        End Select
        '    Loop Until wtv = 1

        '    If TextBox1.Text = "0" And TextBox2.Text = "0" And TextBox3.Text = "0" Then
        '        MsgBox("Parabéns JOGADOR1! GANHOU!")
        '    End If
        '    If TextBox4.Text = "0" And TextBox5.Text = "0" And TextBox6.Text = "0" Then
        '        MsgBox("Parabéns JOGADOR1! GANHOU!")
        '    End If
        '    If TextBox7.Text = "0" And TextBox8.Text = "0" And TextBox9.Text = "0" Then
        '        MsgBox("Parabéns JOGADOR1! GANHOU!")
        '    End If
        '    If TextBox1.Text = "0" And TextBox4.Text = "0" And TextBox7.Text = "0" Then
        '        MsgBox("Parabéns JOGADOR1! GANHOU!")
        '    End If
        '    If TextBox2.Text = "0" And TextBox5.Text = "0" And TextBox8.Text = "0" Then
        '        MsgBox("Parabéns JOGADOR1! GANHOU!")
        '    End If
        '    If TextBox3.Text = "0" And TextBox6.Text = "0" And TextBox9.Text = "0" Then
        '        MsgBox("Parabéns JOGADOR1! GANHOU!")
        '    End If
        '    If TextBox1.Text = "0" And TextBox5.Text = "0" And TextBox9.Text = "0" Then
        '        MsgBox("Parabéns JOGADOR1! GANHOU!")
        '    End If
        '    If TextBox3.Text = "0" And TextBox5.Text = "0" And TextBox7.Text = "0" Then MsgBox("Parabéns JOGADOR1! GANHOU!")
        '    i = i + 1
        'Next
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles btn_reiniciar.Click
        TextBox1.Text = ""
        TextBox1.Enabled = True
        TextBox2.Text = ""
        TextBox2.Enabled = True
        TextBox3.Text = ""
        TextBox3.Enabled = True
        TextBox4.Text = ""
        TextBox4.Enabled = True
        TextBox5.Text = ""
        TextBox5.Enabled = True
        TextBox6.Text = ""
        TextBox6.Enabled = True
        TextBox7.Text = ""
        TextBox7.Enabled = True
        TextBox8.Text = ""
        TextBox8.Enabled = True
        TextBox9.Text = ""
        TextBox9.Enabled = True
        i = 1
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
