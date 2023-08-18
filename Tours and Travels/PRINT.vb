Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class PRINT

    Private Sub PRINT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd0 As New SqlCommand("Select PassengerID from Booking order by PassengerID ", conn)
        Dim d1 As SqlDataReader = cmd0.ExecuteReader
        While d1.Read
            ComboBox1.Items.Add(d1(0).ToString)
        End While
        display()
    End Sub
    Dim xpos As Integer, ypos As Integer
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        PP1.MdiParent = TTDBMDI
        ypos = 50
        Dim MyFont As New Font("impact", 20)
        xpos = 10
        e.Graphics.DrawString("DETAILS", MyFont, Brushes.Blue, xpos, ypos)
        ypos += 50
        xpos = 10
        MyFont = New Font("arial", 14)
        e.Graphics.DrawString("NAME", MyFont, Brushes.Blue, xpos, ypos)
        xpos = xpos + 230
        e.Graphics.DrawString("GENDER", MyFont, Brushes.Blue, xpos, ypos)
        xpos = xpos + 100
        e.Graphics.DrawString("CONTACT", MyFont, Brushes.Blue, xpos, ypos)
        xpos = xpos + 100
        e.Graphics.DrawString("EMAIL ID", MyFont, Brushes.Blue, xpos, ypos)
        xpos = xpos + 100
        xpos = 10
        ypos += 40

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd0 As New SqlCommand("Select Name,Gender,Contact,EmailID from Booking ", conn)
        Dim D2 As SqlDataReader = cmd0.ExecuteReader()
        While D2.Read
            xpos = 10
            e.Graphics.DrawString(D2(0).ToString, MyFont, Brushes.Black, xpos, ypos)
            xpos = xpos + 120
            e.Graphics.DrawString(D2(1).ToString, MyFont, Brushes.Black, xpos, ypos)
            xpos = xpos + 120
            e.Graphics.DrawString(D2(2).ToString, MyFont, Brushes.Black, xpos, ypos)
            xpos = xpos + 130
            e.Graphics.DrawString(D2(3).ToString, MyFont, Brushes.Black, xpos, ypos)
            xpos = xpos + 190
           
            ypos += 25



        End While

    End Sub
    Sub display()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim ds1 As New DataSet
        Dim adp As New SqlDataAdapter("Select PassengerID from Booking order by PassengerID ", conn)
        adp.Fill(ds1)
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub
    Private Sub PP1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PP1.Load
        PP1.Show()
    End Sub

    Private Sub ButShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButShow.Click
        PP1.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd0 As New SqlCommand("Select * from Booking where PassengerID ='" & ComboBox1.Text & "'", conn)
        Dim d1 As SqlDataReader = cmd0.ExecuteReader()
        If d1.HasRows Then
            d1.Read()
            ComboBox1.Text = d1(0).ToString
        End If
    End Sub

End Class