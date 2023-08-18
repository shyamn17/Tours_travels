Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class SearchNI
    Dim pkvar As String
    Sub disRecords()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim DS1 As New DataSet
        Dim adp As New SqlDataAdapter("select Customerid,Name,Add1,Add2,Add3,Add4,Contact,Emil,Date,Days,Total,Places from PackageBooking where Customerid='" & pkvar & "'", conn)
        adp.Fill(DS1)
        'DG1.DataSource = DS1.Tables(0)
        If conn.State = ConnectionState.Open Then conn.Close()
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

    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SearchNI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd0 As New SqlCommand("select Customerid from PackageBooking order by Customerid", conn)
        Dim d1 As SqlDataReader = cmd0.ExecuteReader
        While d1.Read
            ComboBox1.Items.Add(d1(0).ToString)

        End While
        disRecords()
    End Sub

  
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd0 As New SqlCommand("select * from PackageBooking where Customerid='" & ComboBox1.Text & "'", conn)
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
            TextBox9.Text = d1(8).ToString

            ComboBox3.Text = d1(9).ToString
            TextBox10.Text = d1(10).ToString
        End If
    End Sub

End Class
