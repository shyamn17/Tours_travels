Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class SearchForm


    Dim pkvar As String
    Sub disRecords()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim DS1 As New DataSet
        Dim adp As New SqlDataAdapter("select * from Booking where PassengerID='" & pkvar & "'", conn)
        adp.Fill(DS1)
        'DG1.DataSource = DS1.Tables(0)
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub










    Private Sub Searchsi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd0 As New SqlCommand("select PassengerID from Booking order by PassengerID", conn)
        Dim d1 As SqlDataReader = cmd0.ExecuteReader
        While d1.Read
            ComboBox1.Items.Add(d1(0).ToString)

        End While
        disRecords()
    End Sub
    'Private Sub DG1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    '    pkvar = DG1.CurrentRow.Cells(0).Value
    '    If conn.State = ConnectionState.Open Then conn.Close()
    '    conn.Open()
    '    Dim cmd0 As New SqlCommand("select * from PackageBooking where Customerid='" & pkvar & "'", conn)
    '    Dim d1 As SqlDataReader = cmd0.ExecuteReader()
    '    If d1.HasRows Then
    '        d1.Read()
    '        TextBox1.Text = d1(0).ToString
    '        TextBox2.Text = d1(1).ToString
    '        TextBox3.Text = d1(2).ToString
    '        TextBox4.Text = d1(3).ToString
    '        TextBox5.Text = d1(4).ToString
    '        TextBox6.Text = d1(5).ToString
    '        TextBox7.Text = d1(6).ToString
    '        TextBox8.Text = d1(7).ToString
    '        TextBox9.Text = d1(8).ToString

    '        ComboBox3.Text = d1(9).ToString
    '        TextBox10.Text = d1(10).ToString

    '    Else

    '        TextBox1.Text = ""
    '        TextBox2.Text = ""
    '        TextBox3.Text = ""
    '        TextBox4.Text = ""
    '        TextBox5.Text = ""
    '        TextBox6.Text = ""
    '        TextBox7.Text = ""
    '        TextBox8.Text = ""
    '        TextBox9.Text = ""

    '        ComboBox3.Text = ""
    '        TextBox10.Text = ""


    '    End If
    'End Sub



    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd0 As New SqlCommand("select * from Booking where PassengerID='" & ComboBox1.Text & "'", conn)
        Dim d1 As SqlDataReader = cmd0.ExecuteReader()
        If d1.HasRows Then
            d1.Read()
            ComboBox1.Text = d1(0).ToString
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
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

 