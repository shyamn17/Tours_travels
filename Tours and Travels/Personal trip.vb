Imports System.Data.SqlClient

Public Class personal_trip
    Dim pkvar As String
    Sub saveRecord()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        q1var = "Insert into PersonalTab("
        q2var = "values("
        q1var = q1var & "Customerid" & ","
        q2var = q2var & "" & Val(TextBox1.Text) & ","
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
        q2var = q2var & "'" & TextBox7.Text & "',"
        q1var = q1var & "Email" & ","
        q2var = q2var & "'" & TextBox8.Text & "',"
        q1var = q1var & "Date" & ","
        q2var = q2var & "'" & TextBox9.Text & "',"
        q1var = q1var & "Totalkm" & ","
        q2var = q2var & "" & Val(TextBox10.Text) & ","
        q1var = q1var & "Driverfees" & ","
        q2var = q2var & "" & Val(TextBox11.Text) & ","
        q1var = q1var & "Amount" & ")"
        q2var = q2var & "" & Val(TextBox12.Text) & ")"
        MsgBox("Data has been save successfully")
        Dim cmd1 As New SqlCommand(q1var & q2var, conn)
        cmd1.ExecuteNonQuery()
        If conn.State = ConnectionState.Open Then conn.Close()
        disRecords()
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
        Dim adp As New SqlDataAdapter("select Customerid,Name,Add1,Add2,Add3,Add4,Contact,Email,Date,Totalkm,Driverfees,Amount from PersonalTab", conn)
        adp.Fill(DS1)
        DG1.DataSource = DS1.Tables(0)
        If conn.State = ConnectionState.Open Then conn.Close()

    End Sub


    

    Private Sub Butsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butsave.Click
        saveRecord()
        Butnew.Enabled = True
        Butsave.Enabled = True
        Butmodify.Enabled = True
        Butdelete.Enabled = True
    End Sub



    Private Sub Butmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butmodify.Click
        If vbNo = MsgBox("ARE YOU SURE YOU WANT TO MODIFY THIS RECORD", MsgBoxStyle.YesNo, "Modify Record") Then Exit Sub
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd1 As New SqlCommand("Delete from PersonalTab where Customerid =" & Val(TextBox1.Text) & "", conn)
        cmd1.ExecuteNonQuery()
        If conn.State = ConnectionState.Open Then conn.Close()
        saveRecord()
        Butnew.Enabled = True
        Butsave.Enabled = False
        Butmodify.Enabled = False
        Butdelete.Enabled = False
    End Sub
    Private Sub Butnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butnew.Click
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
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd0 As New SqlCommand("Select max(Customerid) from PersonalTab", conn)
        Dim d1 As SqlDataReader = cmd0.ExecuteReader()
        If d1.HasRows Then
            d1.Read()
            TextBox1.Text = IIf(IsDBNull(d1(0)), 1000, d1(0)) + 1
        Else
            TextBox1.Text = "1001"
        End If
        TextBox1.Enabled = False
        Butnew.Enabled = False
        Butsave.Enabled = True
        Butmodify.Enabled = True
        Butdelete.Enabled = True

    End Sub
    Private Sub ButDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butdelete.Click
        If vbNo = MsgBox("ARE YOU SURE YOU WANT TO MODIFY THIS RECORD", MsgBoxStyle.YesNo, " Delete") Then Exit Sub
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd1 As New SqlCommand("Delete from PersonalTab where Customerid =" & Val(TextBox1.Text) & "", conn)
        cmd1.ExecuteNonQuery()
        If conn.State = ConnectionState.Open Then conn.Close()
        disRecords()
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
        ButNew.Enabled = True
        Butsave.Enabled = True
        Butmodify.Enabled = True
        Butdelete.Enabled = True
    End Sub

    Private Sub DG1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG1.CellContentClick
        pkvar = DG1.CurrentRow.Cells(0).Value
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd0 As New SqlCommand("select Customerid,Name,Add1,Add2,Add3,Add4,Contact,Email,Date,Totalkm,Driverfees,Amount from PersonalTab where Customerid='" & pkvar & "'", conn)
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
            ButNew.Enabled = True
            ButSave.Enabled = False
        End If
    End Sub

    Private Sub personal_trip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        disrecords()
    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged
      


    End Sub

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox10.TextChanged
       

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TextBox12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox12.TextChanged

    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged
    End Sub

    Private Sub Butview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butview.Click

    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class