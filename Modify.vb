Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
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
        Dim MyFont As New Font("ALGERIAN", 30)
        xpos = 10
        'e.Graphics.DrawString("DETAILS", MyFont, Brushes.Blue, xpos, ypos)
        'ypos += 50
        'xpos = 10
        'MyFont = New Font("arial", 14)
        'e.Graphics.DrawString("NAME", MyFont, Brushes.Blue, xpos, ypos)
        'xpos = xpos + 230
        'e.Graphics.DrawString("GENDER", MyFont, Brushes.Blue, xpos, ypos)
        'xpos = xpos + 100
        'e.Graphics.DrawString("CONTACT", MyFont, Brushes.Blue, xpos, ypos)
        'xpos = xpos + 100
        'e.Graphics.DrawString("EMAIL ID", MyFont, Brushes.Blue, xpos, ypos)
        'xpos = xpos + 100
        'xpos = 10
        'ypos += 40


        xpos = 220
        e.Graphics.DrawString("INCREDIBLE TRAVELS", MyFont, Brushes.Red, xpos, ypos)
        ypos += 50
        ypos = ypos + 100
        MyFont = New Font("Times New Roman", 14)
        xpos = 20
        e.Graphics.DrawString("PASSENGER DETAILS", MyFont, Brushes.Cyan, xpos, ypos)
        ypos += 20
        xpos = 10
        MyFont = New Font("Times New Roman", 14)
        e.Graphics.DrawString(TextBox1.Text, MyFont, Brushes.Blue, xpos, ypos)
        xpos = xpos + 230
        e.Graphics.DrawString(TextBox2.Text, MyFont, Brushes.Blue, xpos, ypos)
        xpos = xpos + 100








    End Sub
End Class


