Public Class Queue

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = TimeOfDay
        Label6.Text = DateString

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Dim que As Integer

        For que = 1 To 100

        Next

        Label4.Text = Label4.Text + 1

        If Label4.Text = "60" Then

            Label4.Text = "0"
            Label1.Text = Label1.Text + 1

        End If

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        Dim att As Integer
        For att = 1 To 10
        Next

        Label5.Text = Label5.Text + 1

        If Label5.Text = "2" Then

            Label1.ForeColor = Color.OrangeRed

        ElseIf Label5.Text = "4" Then

            Label1.ForeColor = Color.Snow

        ElseIf Label5.Text = "6" Then

            Label1.ForeColor = Color.OrangeRed

        ElseIf Label5.Text = "8" Then

            Label1.ForeColor = Color.Snow

        ElseIf Label5.Text = "10" Then

            Label1.ForeColor = Color.Snow
            Timer3.Enabled = False
            Label5.Text = "0"

        End If

    End Sub
End Class