Public Class Form1
    Dim i, c, redon, n, ib As Integer
    Dim x(), y(), vx, vy, s, m As Single
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub




    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        n = tn.Text
        c = tc.Text
        vx = tx.Text
        ReDim x(0 To n)
        ReDim y(0 To n)

        For i = 0 To n - 1

            x(i) = InputBox(" x(" & i & ")= ")
            y(i) = InputBox(" y(" & i & ")= ")

            Salida.Rows.Add(i, x(i), y(i))
        Next


        i = 0
        Do While vx > x(i)
            i = i + 1

        Loop
        ib = i - 1
        ibb.Text = ib
        s = (vx - x(ib)) / (x(ib + 1) - x(ib))
        ts.Text = s
        m = n - (ib + 1)
        tm.Text = m

    End Sub
End Class
