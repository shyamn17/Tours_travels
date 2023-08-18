

Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Devotional_Packages




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

        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub

    Private Sub Butsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        saveRecord()
        Butnew.Enabled = True
        Butsave.Enabled = True

    End Sub



    'Private Sub Butmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If vbNo = MsgBox("ARE YOU SURE YOU WANT TO MODIFY THIS RECORD", MsgBoxStyle.YesNo, "Modify Record") Then Exit Sub
    '    If conn.State = ConnectionState.Open Then conn.Close()
    '    conn.Open()
    '    Dim cmd1 As New SqlCommand("Delete from North India Packages where Customerid =" & Val(TextBox1.Text) & "", conn)
    '    cmd1.ExecuteNonQuery()
    '    If conn.State = ConnectionState.Open Then conn.Close()
    '    saveRecord()
    '    Butnew.Enabled = True
    '    Butsave.Enabled = True
    '    Butmodify.Enabled = True
    '    Butdelete.Enabled = True
    'End Sub
    Private Sub Butnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd0 As New SqlCommand("Select max(PassengerID) from Booking", conn)
        Dim d1 As SqlDataReader = cmd0.ExecuteReader()
        If d1.HasRows Then
            d1.Read()
            TextBox1.Text = IIf(IsDBNull(d1(0)), 300, d1(0)) + 1
        Else
            TextBox1.Text = "301"
        End If
        TextBox1.Enabled = False
        Butnew.Enabled = False
        Butsave.Enabled = True


    End Sub



    Private Sub Butnew_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butnew.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox5.Text = ""
        TextBox4.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox6.Text = ""

        ComboBox1.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""

        TextBox1.Focus()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd0 As New SqlCommand("Select max(PassengerID) from Booking", conn)
        Dim d1 As SqlDataReader = cmd0.ExecuteReader()
        If d1.HasRows Then
            d1.Read()
            TextBox1.Text = Val(IIf(IsDBNull(d1(0)), 300, d1(0))) + 1
        Else
            TextBox1.Text = "301"
        End If
        TextBox1.Enabled = False
        Butnew.Enabled = False
        Butsave.Enabled = True

        If TextBox1.Text = "301" Then
            TextBox13.Text = "24"
        ElseIf TextBox1.Text = "302" Then
            TextBox13.Text = "23"
        ElseIf TextBox1.Text = "303" Then
            TextBox13.Text = "22"
        ElseIf TextBox1.Text = "304" Then
            TextBox13.Text = "21"
        ElseIf TextBox1.Text = "305" Then
            TextBox13.Text = "20"
        ElseIf TextBox1.Text = "306" Then
            TextBox13.Text = "19"
        ElseIf TextBox1.Text = "307" Then
            TextBox13.Text = "18"
        ElseIf TextBox1.Text = "308" Then
            TextBox13.Text = "17"
        ElseIf TextBox1.Text = "309" Then
            TextBox13.Text = "16"
        ElseIf TextBox1.Text = "310" Then
            TextBox13.Text = "15"
        ElseIf TextBox1.Text = "311" Then
            TextBox13.Text = "14"
        ElseIf TextBox1.Text = "312" Then
            TextBox13.Text = "13"
        ElseIf TextBox1.Text = "313" Then
            TextBox13.Text = "12"
        ElseIf TextBox1.Text = "314" Then
            TextBox13.Text = "11"
        ElseIf TextBox1.Text = "315" Then
            TextBox13.Text = "10"
        ElseIf TextBox1.Text = "316" Then
            TextBox13.Text = "09"
        ElseIf TextBox1.Text = "317" Then
            TextBox13.Text = "08"
        ElseIf TextBox1.Text = "318" Then
            TextBox13.Text = "07"
        ElseIf TextBox1.Text = "319" Then
            TextBox13.Text = "06"
        ElseIf TextBox1.Text = "320" Then
            TextBox13.Text = "05"
        ElseIf TextBox1.Text = "321" Then
            TextBox13.Text = "04"
        ElseIf TextBox1.Text = "322" Then
            TextBox13.Text = "03"
        ElseIf TextBox1.Text = "323" Then
            TextBox13.Text = "02"
        ElseIf TextBox1.Text = "324" Then
            TextBox13.Text = "01"
        ElseIf (TextBox1.Text > "325") Then
            TextBox13.Text = "NO SEATS"
        Else
            If vbNo = MsgBox("SORRY,NO SEATS AVAILABLE", MsgBoxStyle.OkCancel, "Available Seats") Then Exit Sub

        End If

    End Sub

    Private Sub Butmodify_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd0 As New SqlCommand("select Total,Places from  Devotional where Days='" & ComboBox1.Text & "'", conn)
        Dim d1 As SqlDataReader = cmd0.ExecuteReader()
        If d1.HasRows Then
            d1.Read()
            TextBox9.Text = d1(0).ToString
            TextBox10.Text = d1(1).ToString
        End If
    End Sub

    Private Sub North_India_Packages_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd0 As New SqlCommand("select Days from Devotional order by Days", conn)
        Dim d1 As SqlDataReader = cmd0.ExecuteReader()
        While d1.Read
            ComboBox1.Items.Add(d1(0).ToString)

        End While

        TextBox11.Text = Format(Today(), "dd/MM/yyyy")
    End Sub

    Private Sub Butsave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butsave.Click
        saveRecord()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If Not Regex.Match(TextBox2.Text, "^[A-z]*$", RegexOptions.None).Success Then
            MsgBox("PLEASE ENTER THE ALPHABETICAL CHARACERS ONLY!")
            TextBox2.Focus()
            TextBox2.Clear()

        End If

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        If Not Regex.Match(TextBox4.Text, "^[0-9]*$", RegexOptions.None).Success Then
            MsgBox("PLEASE ENTER THE DIGITS ONLY!")
            TextBox2.Focus()
            TextBox2.Clear()

        End If
    End Sub

    Private Sub TextBox13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox13.TextChanged

    End Sub
    'Dim xpos As Integer, ypos As Integer
    'Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
    '    ypos = 50
    '    Dim MyFont As New Font("impact", 20)
    '    xpos = 10
    '    e.Graphics.DrawString("NAME", MyFont, Brushes.Blue, xpos, ypos)
    '    xpos = xpos + 230
    '    e.Graphics.DrawString("GENDER", MyFont, Brushes.Blue, xpos, ypos)
    '    xpos = xpos + 100
    '    e.Graphics.DrawString("CONTACT", MyFont, Brushes.Blue, xpos, ypos)
    '    xpos = xpos + 100
    '    e.Graphics.DrawString("EMAIL ID", MyFont, Brushes.Blue, xpos, ypos)
    '    xpos = xpos + 100
    '    xpos = 10
    '    ypos += 40

    '    If conn.State = ConnectionState.Open Then conn.Close()
    '    conn.Open()
    '    Dim cmd0 As New SqlCommand("Select Name,Gender,Contact,EmailID from Booking ", conn)
    '    Dim D2 As SqlDataReader = cmd0.ExecuteReader()
    '    While D2.Read
    '        xpos = 10
    '        e.Graphics.DrawString(D2(0).ToString, MyFont, Brushes.Black, xpos, ypos)
    '        xpos = xpos + 120
    '        e.Graphics.DrawString(D2(1).ToString, MyFont, Brushes.Black, xpos, ypos)
    '        xpos = xpos + 230
    '        e.Graphics.DrawString(D2(2).ToString, MyFont, Brushes.Black, xpos, ypos)
    '        xpos = xpos + 130
    '        e.Graphics.DrawString(D2(3).ToString, MyFont, Brushes.Black, xpos, ypos)
    '        xpos = xpos + 190
    '        e.Graphics.DrawString(D2(4).ToString, MyFont, Brushes.Black, xpos, ypos)
    '        xpos = xpos + 150
    '        ypos += 25



    '    End While


    'End Sub

    'Private Sub PP1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PP1.Load
    '    PP1.Show()

    'End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        TextBox3.Text = "MALE"
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        TextBox3.Text = "FEMALE"
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        TextBox3.Text = "OTHERS"
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim xpos As Integer, ypos As Integer
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

    Private Sub ButPRINT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButPRINT.Click
        PP1.Show()
    End Sub
End Class