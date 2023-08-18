Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Modifygoa
    Dim pkvar As String

    Sub saveRecord()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        q1var = "Insert into Booking("
        q2var = "values("
        q1var = q1var & "PassengerID" & ","
        q2var = q2var & "" & TextBox1.Text & ","
        q1var = q1var & "Name" & ","
        q2var = q2var & "'" & UCase(TextBox2.Text) & "',"
        q1var = q1var & "Add1" & ","
        q2var = q2var & "'" & TextBox3.Text & "',"
        q1var = q1var & "Add2" & ","
        q2var = q2var & "'" & TextBox4.Text & "',"
        q1var = q1var & "Add3" & ","
        q2var = q2var & "'" & TextBox5.Text & "',"
        q1var = q1var & "Add4" & ","
        q2var = q2var & "'" & TextBox6.Text & "',"
        q1var = q1var & "Contact" & ","
        q2var = q2var & "" & Val(TextBox7.Text) & ","
        q1var = q1var & "Emil" & ","
        q2var = q2var & "'" & TextBox8.Text & "',"
        q1var = q1var & "Date" & ","
        q2var = q2var & "'" & DateTimePicker2.Text & "',"
        q1var = q1var & "Days" & ","
        q2var = q2var & "'" & ComboBox2.Text & "',"
        q1var = q1var & "Total" & ","
        q2var = q2var & "'" & TextBox9.Text & "',"
        q1var = q1var & "Places" & ")"
        q2var = q2var & "'" & TextBox10.Text & "')"
        MsgBox("Data has been save successfully")
        MsgBox(q1var & q2var)
        Dim cmd1 As New SqlCommand(q1var & q2var, conn)
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
        DateTimePicker2.Text = ""
        TextBox9.Text = ""

        ComboBox2.Text = ""
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





    Private Sub Butmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If vbNo = MsgBox("ARE YOU SURE YOU WANT TO MODIFY THIS RECORD", MsgBoxStyle.YesNo, "Modify Record") Then Exit Sub
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd1 As New SqlCommand("Delete from Booking where PassengerID=" & Val(TextBox1.Text) & "", conn)
        cmd1.ExecuteNonQuery()
        If conn.State = ConnectionState.Open Then conn.Close()
        saveRecord()


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

        ComboBox2.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        DateTimePicker2.Text = ""
        TextBox1.Focus()
    End Sub









    'Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
    '    If conn.State = ConnectionState.Open Then conn.Close()
    '    conn.Open()
    '    Dim cmd0 As New SqlCommand("select Total,Places from  PackageBooking where Days='" & ComboBox3.Text & "'", conn)
    '    Dim d1 As SqlDataReader = cmd0.ExecuteReader()
    '    If d1.HasRows Then
    '        d1.Read()
    '        TextBox10.Text = d1(0).ToString
    '        TextBox11.Text = d1(1).ToString
    '    End If
    'End Sub

    'Private Sub North_India_Packages_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    If conn.State = ConnectionState.Open Then conn.Close()
    '    conn.Open()
    '    Dim cmd0 As New SqlCommand("select Days from Northindia order by Days", conn)
    '    Dim d1 As SqlDataReader = cmd0.ExecuteReader()
    '    While d1.Read
    '        ComboBox3.Items.Add(d1(0).ToString)
    '    End While
    'End Sub



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
            ComboBox2.Text = d1(9).ToString
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
            ComboBox2.Text = ""
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








End Class





