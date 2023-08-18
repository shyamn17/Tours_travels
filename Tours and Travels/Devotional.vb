Imports System.Data.SqlClient
Public Class Devotional
    Dim pkvar As String
    Sub saveRecord()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        q1var = "Insert into Devotional("
        q2var = "values("
        q1var = q1var & "Packageid" & ","
        q2var = q2var & "" & Val(TextBox1.Text) & ","
        q1var = q1var & "Packagename" & ","
        q2var = q2var & "'" & UCase(TextBox2.Text) & "',"
        q1var = q1var & "Days" & ","
        q2var = q2var & "" & Val(TextBox3.Text) & ","
        q1var = q1var & "Nights" & ","
        q2var = q2var & "" & Val(TextBox4.Text) & ","
        q1var = q1var & "Foodtype" & ","
        q2var = q2var & "'" & Val(TextBox5.Text) & "',"
        q1var = q1var & "Accomodation" & ","
        q2var = q2var & "'" & Val(TextBox6.Text) & "',"
        q1var = q1var & "Foodcharge" & ","
        q2var = q2var & "" & Val(TextBox7.Text) & ","
        q1var = q1var & "Accomomodationcharge" & ","
        q2var = q2var & "" & Val(TextBox8.Text) & ","
        q1var = q1var & "Travellingcharge," & ""
        q2var = q2var & "" & Val(TextBox9.Text) & ","
        q1var = q1var & "Miscellaneous" & ","
        q2var = q2var & "" & Val(TextBox10.Text) & ","
        q1var = q1var & "Total" & ","
        q2var = q2var & "" & Val(TextBox11.Text) & ","
        q1var = q1var & "Places" & ")"
        q2var = q2var & "'" & TextBox12.Text & "')"
        MsgBox(q1var & q2var)
        Dim cmd1 As New SqlCommand(q1var & q2var, conn)
        cmd1.ExecuteNonQuery()
        MsgBox("Data has been save successfully")
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
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox1.Focus()
    End Sub
        Sub disrecords()
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            Dim DS1 As New DataSet
        Dim adp As New SqlDataAdapter("select * from Devotional", conn)
            adp.Fill(DS1)
            DG1.DataSource = DS1.Tables(0)
            If conn.State = ConnectionState.Open Then conn.Close()

        End Sub
    Private Sub Butmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If vbNo = MsgBox("ARE YOU SURE YOU WANT TO MODIFY THIS RECORD", MsgBoxStyle.YesNo, "Modify Record") Then Exit Sub
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd1 As New SqlCommand("Delete from Southindia where Packageid =" & Val(TextBox1.Text) & "", conn)
        cmd1.ExecuteNonQuery()
        If conn.State = ConnectionState.Open Then conn.Close()
        saveRecord()
    End Sub

    Private Sub Butdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butdelete.Click
        If vbNo = MsgBox("ARE YOU SURE YOU WANT TO MODIFY THIS RECORD", MsgBoxStyle.YesNo, " Delete") Then Exit Sub
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd1 As New SqlCommand("Delete from Devotional where Packageid =" & Val(TextBox1.Text) & "", conn)
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
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub DG1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG1.CellContentClick
        pkvar = DG1.CurrentRow.Cells(0).Value
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd0 As New SqlCommand("select Packageid,Packagename,Days,Nights,Foodtype,Accomodation,Foodcharge,Accomomodationcharge,Travellingcharge,Miscellaneous,Total,Places from Devotional where Packageid ='" & pkvar & "'", conn)
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
            TextBox10.Text = d1(9).ToString
            TextBox11.Text = d1(10).ToString
            TextBox12.Text = d1(11).ToString
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
            TextBox10.Text = ""
            TextBox11.Text = ""
            TextBox12.Text = ""
        End If
    End Sub

    Private Sub Devotional_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        disrecords()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Butexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butexit.Click
        Me.Close()

    End Sub
End Class
