Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class North_India_Packages

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
            TextBox1.Text = IIf(IsDBNull(d1(0)), 100, d1(0)) + 1
        Else
            TextBox1.Text = "101"
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
            TextBox1.Text = Val(IIf(IsDBNull(d1(0)), 100, d1(0))) + 1
        Else
            TextBox1.Text = "101"
        End If
        TextBox1.Enabled = False
        Butnew.Enabled = False
        Butsave.Enabled = True

        If TextBox1.Text = "101" Then
            TextBox13.Text = "24"
        ElseIf TextBox1.Text = "102" Then
            TextBox13.Text = "23"
        ElseIf TextBox1.Text = "103" Then
            TextBox13.Text = "22"
        ElseIf TextBox1.Text = "104" Then
            TextBox13.Text = "21"
        ElseIf TextBox1.Text = "105" Then
            TextBox13.Text = "20"
        ElseIf TextBox1.Text = "106" Then
            TextBox13.Text = "19"
        ElseIf TextBox1.Text = "107" Then
            TextBox13.Text = "18"
        ElseIf TextBox1.Text = "108" Then
            TextBox13.Text = "17"
        ElseIf TextBox1.Text = "109" Then
            TextBox13.Text = "16"
        ElseIf TextBox1.Text = "110" Then
            TextBox13.Text = "15"
        ElseIf TextBox1.Text = "111" Then
            TextBox13.Text = "14"
        ElseIf TextBox1.Text = "112" Then
            TextBox13.Text = "13"
        ElseIf TextBox1.Text = "113" Then
            TextBox13.Text = "12"
        ElseIf TextBox1.Text = "114" Then
            TextBox13.Text = "11"
        ElseIf TextBox1.Text = "115" Then
            TextBox13.Text = "10"
        ElseIf TextBox1.Text = "116" Then
            TextBox13.Text = "09"
        ElseIf TextBox1.Text = "117" Then
            TextBox13.Text = "08"
        ElseIf TextBox1.Text = "118" Then
            TextBox13.Text = "07"
        ElseIf TextBox1.Text = "119" Then
            TextBox13.Text = "06"
        ElseIf TextBox1.Text = "120" Then
            TextBox13.Text = "05"
        ElseIf TextBox1.Text = "121" Then
            TextBox13.Text = "04"
        ElseIf TextBox1.Text = "122" Then
            TextBox13.Text = "03"
        ElseIf TextBox1.Text = "123" Then
            TextBox13.Text = "02"
        ElseIf TextBox1.Text = "124" Then
            TextBox13.Text = "01"
        ElseIf (TextBox1.Text > "125") Then
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
        Dim cmd0 As New SqlCommand("select Total,Places from  Northindia where Days='" & ComboBox1.Text & "'", conn)
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
        Dim cmd0 As New SqlCommand("select Days from Northindia order by Days", conn)
        Dim d1 As SqlDataReader = cmd0.ExecuteReader()
        While d1.Read
            ComboBox1.Items.Add(d1(0).ToString)

        End While
      
        TextBox11.Text = Format(Today(), "dd/MM/yyyy")
    End Sub

    Private Sub Butsave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butsave.Click
        saveRecord()
    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox10.TextChanged

    End Sub

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub














































    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox13.TextChanged

       
    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click

    End Sub

    Private Sub TextBox12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox12.TextChanged

    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        TextBox3.Text = "MALE"
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        TextBox3.Text = "FEMALE"
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        TextBox3.Text = "OTHERS"
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        TextBox3.Enabled = False
    End Sub

   

    Private Sub Butexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butexit.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label15_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox11_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged
        TextBox11.Text = Format(Today(), "dd/MM/yyyy")
    End Sub

    Private Sub TextBox7_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged

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
End Class

