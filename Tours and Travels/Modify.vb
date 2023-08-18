Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Drawing.Size

Public Class Modify




    Dim pkvar As String

    Sub saveRecord()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        q1var = "Insert Booking("
        q2var = "values("
        q1var = q1var & "PassengerID" & ","
        q2var = q2var & "" & TextBox1.Text & ","
        q1var = q1var & "Name" & ","
        q2var = q2var & "'" & UCase(TextBox2.Text) & "',"
        q1var = q1var & "Gender" & ","
        q2var = q2var & "'" & TextBox3.Text & "',"
        q1var = q1var & "Contact" & ","
        q2var = q2var & "'" & Val(TextBox4.Text) & "',"
        q1var = q1var & "EmailID" & ","
        q2var = q2var & "'" & TextBox5.Text & "',"
        q1var = q1var & "Add1" & ","
        q2var = q2var & "'" & TextBox6.Text & "',"
        q1var = q1var & "Add2" & ","
        q2var = q2var & "'" & TextBox7.Text & "',"
        q1var = q1var & "Add3" & ","
        q2var = q2var & "'" & TextBox8.Text & "',"
        q1var = q1var & "Date" & ","
        q2var = q2var & "'" & DateTimePicker2.Text & "',"
        q1var = q1var & "Days" & ","
        q2var = q2var & "'" & ComboBox1.Text & "',"
        q1var = q1var & "Total" & ","
        q2var = q2var & "'" & TextBox9.Text & "',"
        q1var = q1var & "Places" & ")"
        q2var = q2var & "'" & TextBox10.Text & "')"
        MsgBox("Data has been save successfully")
        Dim cmd1 As New SqlCommand(q1var & q2var, conn)
        cmd1.ExecuteNonQuery()
        disrecords()
        If conn.State = ConnectionState.Open Then conn.Close()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox5.Text = ""
        TextBox4.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""

        ComboBox1.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox1.Focus()
    End Sub


    Sub disrecords()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim DS1 As New DataSet
        Dim adp As New SqlDataAdapter("select * from Booking", conn)
        adp.Fill(DS1)
        DG1.DataSource = DS1.Tables(0)
        If conn.State = ConnectionState.Open Then conn.Close()

    End Sub





    


    Private Sub Butdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butdelete.Click
        If vbNo = MsgBox("ARE YOU SURE YOU WANT TO MODIFY THIS RECORD", MsgBoxStyle.YesNo, " Delete") Then Exit Sub
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd1 As New SqlCommand("Delete from Booking where PassengerID=" & Val(TextBox1.Text) & "", conn)
        cmd1.ExecuteNonQuery()
        If conn.State = ConnectionState.Open Then conn.Close()
        disrecords()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""

        ComboBox1.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        DateTimePicker2.Text = ""
        TextBox1.Focus()
    End Sub













    Private Sub DG1_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG1.CellContentClick
        pkvar = DG1.CurrentRow.Cells(0).Value
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd0 As New SqlCommand("select * from Booking where PassengerID='" & pkvar & "'", conn)
        Dim d1 As SqlDataReader = cmd0.ExecuteReader()
        If d1.HasRows Then
            d1.Read()
            TextBox1.Text = d1(0).ToString
            TextBox2.Text = d1(1).ToString
            TextBox3.Text = d1(2).ToString
            TextBox4.Text = d1(3).ToString
            TextBox5.Text = d1(4).ToString
            TextBox6.Text = d1(5).ToString
            TextBox7.Text = d1(6).ToString
            TextBox8.Text = d1(7).ToString
            DateTimePicker2.Text = d1(8).ToString
            ComboBox1.Text = d1(9).ToString
            TextBox9.Text = d1(10).ToString
            TextBox10.Text = d1(11).ToString
        Else

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
            DateTimePicker2.Text = ""
            ComboBox1.Text = ""
            TextBox10.Text = ""


        End If
    End Sub

    Private Sub Butsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        saveRecord()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Butexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butexit.Click
        End
    End Sub


    Private Sub ModifyDV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        disrecords()
    End Sub

    Private Sub Butmodify_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butmodify.Click
        If vbNo = MsgBox("ARE YOU SURE YOU WANT TO MODIFY THIS RECORD", MsgBoxStyle.YesNo, "Modify Record") Then Exit Sub
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd1 As New SqlCommand("Delete from Booking where PassengerID=" & Val(TextBox1.Text) & "", conn)
        cmd1.ExecuteNonQuery()
        If conn.State = ConnectionState.Open Then conn.Close()
        saveRecord()

    End Sub

    Private Sub ButPRINT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButPRINT.Click
        PP1.Show()
    End Sub

    Private Sub PP1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PP1.Load

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim xpos As Integer, ypos As Integer
        PP1.MdiParent = TTDBMDI
        ypos = 50

        xpos = 10
    
        'Dim pen As System.Drawing.Graphics
        Dim MyFont As New Font("ALGERIAN", 20)
        xpos = 185
        e.Graphics.DrawString("INCREDIBLE !NDIA TRAVELS", MyFont, Brushes.Red, xpos, ypos)
        ypos += 50
        MyFont = New Font("Times New Roman", 20)
        xpos = 210
        e.Graphics.DrawString("One country many worlds...!", MyFont, Brushes.Black, xpos, ypos)
        ypos = ypos + 20
        xpos = 0
        e.Graphics.DrawString("______________________________________________________________________________________________________________", MyFont, Brushes.BlueViolet, xpos, ypos)
        ypos += 5
        xpos = 1
        MyFont = New Font("impact", 30)
        xpos = 80
        ypos = 210
        e.Graphics.DrawString("PASSENGER DETAILS", MyFont, Brushes.Cyan, xpos, ypos)
        ypos += 100
        'Pen = Me.CreateGraphics()
        'e.Graphics.DrawLine(Pens.AliceBlue, x1:=10, y1:=10, x2:=20, y2:=20)
        ypos += 2
        'ypos = ypos + 50
      xpos = 10
        MyFont = New Font("Georgia Bold", 20)
        xpos = 100
        ypos = 307
        e.Graphics.DrawString("NAME", MyFont, Brushes.Blue, xpos, ypos)
        ypos = ypos + 50
        xpos = 100
        MyFont = New Font("Times New Roman ", 18)
        e.Graphics.DrawString(TextBox2.Text, MyFont, Brushes.Black, xpos, ypos)
        'ypos = ypos + 12

        xpos = 10
        ypos = 395
        MyFont = New Font("Georgia Bold", 20)
        xpos = 90
        ypos += 38
        e.Graphics.DrawString("CONTACT NUMBER", MyFont, Brushes.Blue, xpos, ypos)
        ypos = ypos + 50
        xpos = 90
        MyFont = New Font("Times New Roman", 18)
        e.Graphics.DrawString(TextBox4.Text, MyFont, Brushes.Black, xpos, ypos)

        ypos += 1
        ypos = 305
        xpos = 400
        MyFont = New Font("Georgia Bold", 20)
        xpos = xpos + 100
        ypos += 8
        e.Graphics.DrawString("GENDER", MyFont, Brushes.Blue, xpos, ypos)
        ypos = ypos + 50
        xpos = xpos + 4
        MyFont = New Font("Times New Roman", 18)
        e.Graphics.DrawString(TextBox3.Text, MyFont, Brushes.Black, xpos, ypos)
        ypos = ypos + 70


        ypos += 1
        ypos = 382
        xpos = 393
        MyFont = New Font("Georgia Bold", 20)
        xpos = xpos + 105
        ypos += 50
        e.Graphics.DrawString("EMAIL ID", MyFont, Brushes.Blue, xpos, ypos)
        ypos = ypos + 50
        xpos = xpos + 7
        MyFont = New Font("Times New Roman", 18)
        e.Graphics.DrawString(TextBox5.Text, MyFont, Brushes.Black, xpos, ypos)
        ypos = ypos + 70

        xpos = 0
        ypos += 1
        e.Graphics.DrawString("__________________________________________________________________________________________________________________________", MyFont, Brushes.Blue, xpos, ypos)

        MyFont = New Font("impact", 30)
        xpos = 80
        ypos = 620
        e.Graphics.DrawString("PACKAGE DETAILS", MyFont, Brushes.Cyan, xpos, ypos)

        xpos = 10
        ypos = 680
        MyFont = New Font("Georgia Bold", 20)
        xpos = 90
        ypos += 38
        e.Graphics.DrawString("BOOKING STATUS", MyFont, Brushes.Blue, xpos, ypos)
        ypos = ypos + 50
        xpos = 90
        MyFont = New Font("Times New Roman", 18)
        e.Graphics.DrawString("Confirmed", MyFont, Brushes.Black, xpos, ypos)

        ypos = 710
        xpos = 400
        MyFont = New Font("Georgia Bold", 20)
        xpos = xpos + 100
        ypos += 8
        e.Graphics.DrawString("DATE OF TRIP", MyFont, Brushes.Blue, xpos, ypos)
        ypos = ypos + 50
        xpos = xpos + 4
        MyFont = New Font("Times New Roman", 18)
        e.Graphics.DrawString(DateTimePicker2.Text, MyFont, Brushes.Black, xpos, ypos)
        ypos = ypos + 70

        xpos = 10
        ypos = 800
        MyFont = New Font("Georgia Bold", 20)
        xpos = 90
        ypos += 38
        e.Graphics.DrawString("NO. OF DAYS", MyFont, Brushes.Blue, xpos, ypos)
        ypos = ypos + 50
        xpos = 90
        MyFont = New Font("Times New Roman", 18)
        e.Graphics.DrawString(ComboBox1.Text, MyFont, Brushes.Black, xpos, ypos)

        ypos = 830
        xpos = 400
        MyFont = New Font("Georgia Bold", 20)
        xpos = xpos + 100
        ypos += 8
        e.Graphics.DrawString("TOTAL PRICE", MyFont, Brushes.Blue, xpos, ypos)
        ypos = ypos + 50
        xpos = xpos + 4
        MyFont = New Font("Times New Roman", 18)
        e.Graphics.DrawString(TextBox9.Text, MyFont, Brushes.Black, xpos, ypos)
        ypos = ypos + 70


        xpos = 10
        ypos = 900
        MyFont = New Font("Georgia Bold", 20)
        xpos = 90
        ypos += 38
        e.Graphics.DrawString("PLACES", MyFont, Brushes.MediumBlue, xpos, ypos)
        ypos = ypos + 50
        xpos = 90
        MyFont = New Font("Gabriola Bold", 18)
        e.Graphics.DrawString(TextBox10.Text, MyFont, Brushes.Black, xpos, ypos)

    End Sub
End Class


