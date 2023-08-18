Imports System.Data.SqlClient
Public Class Goa_Report

   





        Sub display()
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            Dim ds1 As New DataSet
            Dim adp As New SqlDataAdapter("Select Customerid from PackageBooking order by Customerid ", conn)
            adp.Fill(ds1)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Sub





        Private Sub PrintDocument1_PrintPage_1(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
            Dim xpos As Integer, ypos As Integer


            ypos = 50
            Dim MyFont As New Font("Impact", 20)
            xpos = 250
        e.Graphics.DrawString("GOA REPORT DETAILS", MyFont, Brushes.Blue, xpos, ypos)
            ypos = 150
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            Dim cmd0 As New SqlCommand("Select * from PackageBooking where Customerid='" & ComboBox1.Text & "'", conn)
            Dim d2 As SqlDataReader = cmd0.ExecuteReader()
            While d2.Read
                xpos = 130
                MyFont = New Font("Arial", 18)
                e.Graphics.DrawString("Customerid", MyFont, Brushes.Black, xpos, ypos)
                xpos = xpos + 300
                e.Graphics.DrawString(d2(0).ToString, MyFont, Brushes.Black, xpos, ypos)
                ypos = ypos + 80
                xpos = 130
                e.Graphics.DrawString("Name", MyFont, Brushes.Black, xpos, ypos)
                xpos = xpos + 300
                e.Graphics.DrawString(d2(1).ToString, MyFont, Brushes.Black, xpos, ypos)
                xpos = 50
                ypos = ypos + 80
                xpos = 130
            e.Graphics.DrawString("Address", MyFont, Brushes.Black, xpos, ypos)
                xpos = xpos + 300
                e.Graphics.DrawString(d2(2).ToString, MyFont, Brushes.Black, xpos, ypos)
                xpos = 50
                ypos = ypos + 80
                xpos = 130
            e.Graphics.DrawString("", MyFont, Brushes.Black, xpos, ypos)
                xpos = xpos + 300
                e.Graphics.DrawString(d2(3).ToString, MyFont, Brushes.Black, xpos, ypos)
                xpos = 50
                ypos = ypos + 80
                xpos = 130
            e.Graphics.DrawString("", MyFont, Brushes.Black, xpos, ypos)
                xpos = xpos + 300
                e.Graphics.DrawString(d2(4).ToString, MyFont, Brushes.Black, xpos, ypos)
                xpos = 50
                ypos = ypos + 80
                xpos = 130
            e.Graphics.DrawString("", MyFont, Brushes.Black, xpos, ypos)
                xpos = xpos + 300
                e.Graphics.DrawString(d2(5).ToString, MyFont, Brushes.Black, xpos, ypos)
                xpos = 50
                ypos = ypos + 80
                xpos = 130
                e.Graphics.DrawString("Contact", MyFont, Brushes.Black, xpos, ypos)
                xpos = xpos + 300
                e.Graphics.DrawString(d2(6).ToString, MyFont, Brushes.Black, xpos, ypos)
                xpos = 50
                ypos = ypos + 80
                xpos = 130
            e.Graphics.DrawString("Email", MyFont, Brushes.Black, xpos, ypos)
                xpos = xpos + 300
                e.Graphics.DrawString(d2(7).ToString, MyFont, Brushes.Black, xpos, ypos)
                xpos = 50
                ypos = ypos + 80
                xpos = 130
                e.Graphics.DrawString("Date", MyFont, Brushes.Black, xpos, ypos)
                xpos = xpos + 300
                e.Graphics.DrawString(d2(8).ToString, MyFont, Brushes.Black, xpos, ypos)
                xpos = 50
                ypos = ypos + 80
                xpos = 130
                e.Graphics.DrawString("Days", MyFont, Brushes.Black, xpos, ypos)
                xpos = xpos + 300
                e.Graphics.DrawString(d2(9).ToString, MyFont, Brushes.Black, xpos, ypos)
                xpos = 50
                ypos = ypos + 80
                xpos = 130
                e.Graphics.DrawString("Total", MyFont, Brushes.Black, xpos, ypos)
                xpos = xpos + 300
                e.Graphics.DrawString(d2(10).ToString, MyFont, Brushes.Black, xpos, ypos)
                xpos = 50
                ypos = ypos + 80
                xpos = 130


                e.Graphics.DrawString("Places", MyFont, Brushes.Black, xpos, ypos)
                xpos = xpos + 300
                e.Graphics.DrawString(d2(11).ToString, MyFont, Brushes.Black, xpos, ypos)
                xpos = 50
                ypos = ypos + 80
                xpos = 130
            End While
        End Sub

        Private Sub PP1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PP1.Load
            PP1.Show()
        End Sub



    Private Sub Goa_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd0 As New SqlCommand("Select Customerid from PackageBooking order by Customerid ", conn)
        Dim d1 As SqlDataReader = cmd0.ExecuteReader
        While d1.Read
            ComboBox1.Items.Add(d1(0).ToString)
        End While
        display()
    End Sub

        Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            Dim cmd0 As New SqlCommand("Select * from PackageBooking where Customerid ='" & ComboBox1.Text & "'", conn)
            Dim d1 As SqlDataReader = cmd0.ExecuteReader()
            If d1.HasRows Then
                d1.Read()
                ComboBox1.Text = d1(0).ToString
            End If
        End Sub

        Private Sub ButShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButShow.Click
            PP1.Show()

        End Sub
    End Class
