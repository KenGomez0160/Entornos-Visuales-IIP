Public Class Motoristas
    Dim contador1, contador2, contador3, contador4, contador5, contador6 As Integer
    Dim tiempo1, tiempo2, tiempo3, tiempo4, tiempo5, tiempo6 As Integer
    Private Sub btnEnviar1_Click(sender As Object, e As EventArgs) Handles btnEnviar1.Click

        tiempo1 = Usuarios.tiempo
        Timer1.Start()
        contador1 = 60
        Me.lblMinutos1.Text = tiempo1
        Me.lblSegundos1.Text = "00"
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        contador1 -= 1
        Me.lblSegundos1.Text = contador1

        If contador1 < 1 Or contador1 = 59 Then
            contador1 = 59
            Me.lblMinutos1.Text = tiempo1 - 1
            tiempo1 -= 1
        End If

        If Me.lblMinutos1.Text < 0 And Me.lblSegundos1.Text = "0" Then
            Me.lblMinutos1.Text = "00"
            Me.lblSegundos1.Text = "00"

            Timer1.Stop()
        End If
    End Sub


    Private Sub btnEnviar2_Click(sender As Object, e As EventArgs) Handles btnEnviar2.Click
        Timer2.Start()
        contador2 = 60
        tiempo2 = Usuarios.tiempo
        Me.lblMinutos2.Text = tiempo2
        Me.lblSegundos2.Text = "00"
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        contador2 -= 1
        Me.lblSegundos2.Text = contador2

        If contador2 < 1 Or contador2 = 59 Then
            Me.lblMinutos2.Text = tiempo2 - 1
            tiempo2 -= 1
            contador2 = 59
        End If
        If Me.lblMinutos2.Text < 0 And Me.lblSegundos2.Text = 0 Then
            Me.lblMinutos2.Text = "00"
            Me.lblSegundos2.Text = "00"

            Timer2.Stop()
        End If
    End Sub

    Private Sub btnEnviar3_Click(sender As Object, e As EventArgs) Handles btnEnviar3.Click
        Timer3.Start()
        tiempo3 = Usuarios.tiempo
        contador3 = 60
        Me.lblMinutos3.Text = tiempo3
        Me.lblSegundos3.Text = "00"
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        contador3 -= 1
        Me.lblSegundos3.Text = contador3

        If contador3 < 1 Or contador3 = 59 Then
            Me.lblMinutos3.Text = tiempo3 - 1
            tiempo3 -= 1
            contador3 = 59
        End If
        If Me.lblMinutos3.Text < 0 And Me.lblSegundos3.Text = 0 Then
            Me.lblMinutos3.Text = "00"
            Me.lblSegundos3.Text = "00"
            Timer3.Stop()
        End If
    End Sub
    Private Sub btnEnviar4_Click(sender As Object, e As EventArgs) Handles btnEnviar4.Click
        Timer4.Start()
        tiempo4 = Usuarios.tiempo
        contador4 = 60
        Me.lblMinutos4.Text = tiempo4
        Me.lblSegundos4.Text = "00"
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        contador4 -= 1
        Me.lblSegundos4.Text = contador4

        If contador4 < 1 Or contador4 = 59 Then
            Me.lblMinutos4.Text = tiempo4 - 1
            tiempo4 -= 1
            contador4 = 59
        End If
        If Me.lblMinutos4.Text < 0 And Me.lblSegundos4.Text = 0 Then
            Me.lblMinutos4.Text = "00"
            Me.lblSegundos4.Text = "00"
            Timer4.Stop()
        End If
    End Sub
    Private Sub btnEnviar5_Click(sender As Object, e As EventArgs) Handles btnEnviar5.Click
        Timer5.Start()
        tiempo5 = Usuarios.tiempo
        contador5 = 60
        Me.lblMinutos5.Text = tiempo5
        Me.lblSegundos5.Text = "00"
    End Sub
    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        contador5 -= 1
        Me.lblSegundos5.Text = contador5

        If contador5 < 1 Or contador5 = 59 Then
            Me.lblMinutos5.Text = tiempo5 - 1
            tiempo5 -= 1
            contador5 = 59
        End If
        If Me.lblMinutos5.Text < 0 And Me.lblSegundos5.Text = 0 Then
            Me.lblMinutos5.Text = "00"
            Me.lblSegundos5.Text = "00"
            Timer5.Stop()
        End If
    End Sub
    Private Sub btnEnviar6_Click(sender As Object, e As EventArgs) Handles btnEnviar6.Click
        Timer6.Start()
        tiempo6 = Usuarios.tiempo
        contador6 = 60
        Me.lblMinutos6.Text = tiempo6
        Me.lblSegundos6.Text = "00"
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        contador6 -= 1
        Me.lblSegundos6.Text = contador6

        If contador6 < 1 Or contador6 = 59 Then
            Me.lblMinutos6.Text = tiempo6 - 1
            tiempo6 -= 1
            contador6 = 59
        End If
        If Me.lblMinutos6.Text < 0 And Me.lblSegundos6.Text = 0 Then
            Me.lblMinutos6.Text = "00"
            Me.lblSegundos6.Text = "00"
            Timer6.Stop()
        End If
    End Sub




End Class