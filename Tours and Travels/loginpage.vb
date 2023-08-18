Imports System.Data.SqlClient
Public Class loginpage
    Dim temp As VariantType


    Private Sub ButLogin_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim Cmd0 As New SqlCommand("select *from LoginTab where Username='" & UCase(TextBox1.Text) & "' and Password='" & TextBox2.Text & "'", conn)
        Dim D1 As SqlDataReader = Cmd0.ExecuteReader()
        If D1.HasRows Then
            TTDBMDI.Show()
        Else
            MsgBox("Type the correct username and password!", MsgBoxStyle.Critical, "login checkup")
            lable4.Text = ""
            TextBox2.Text = ""
            lable4.Focus()

        End If
    End Sub

    Private Sub ButCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim Cmd0 As New SqlCommand("select *from LoginTab where Username='" & UCase(TextBox1.Text) & "' and Password='" & TextBox2.Text & "'", conn)
        Dim D1 As SqlDataReader = Cmd0.ExecuteReader()
        If D1.HasRows Then
            TTDBMDI.Show()
        Else
            MsgBox("Type the correct username and password!", MsgBoxStyle.Critical, "login checkup")
            lable4.Text = ""
            TextBox2.Text = ""
            lable4.Focus()

        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        temp = MsgBox("Do you want to exit!(YES/NO)", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "exit")
        If temp = vbYes Then
            MsgBox("thank you", MsgBoxStyle.Information, "best wishes")
            End
        End If
    End Sub

   
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub
End Class