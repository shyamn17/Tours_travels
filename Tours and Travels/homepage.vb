
Public Class homepage
    Dim x As Integer


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If x < ProgressBar1.Maximum() Then
            ProgressBar1.Value = x
            x = x + 4
            Label2.Text = x & "%"
        Else
            Me.Hide()
            loginpage.Show()

        End If
    End Sub

   
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
End Class
