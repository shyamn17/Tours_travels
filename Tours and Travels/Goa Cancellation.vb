Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Goa_Cancellation

    





        Dim pkvar As String
        Sub saveRecord()
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            q1var = "Insert into PackageBooking("
            q2var = "values("
            q1var = q1var & "Customerid" & ","
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
            q2var = q2var & "'" & TextBox9.Text & "',"
            q1var = q1var & "Days" & ","
            q2var = q2var & "'" & ComboBox3.Text & "',"
            q1var = q1var & "Total" & ","
            q2var = q2var & "'" & TextBox10.Text & "',"
            q1var = q1var & "Places" & ")"
            q2var = q2var & "'" & TextBox11.Text & "')"
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
            TextBox9.Text = ""

            ComboBox3.Text = ""
            TextBox10.Text = ""
            TextBox11.Text = ""
            TextBox1.Focus()
        End Sub
        Sub disrecords()
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            Dim DS1 As New DataSet
            Dim adp As New SqlDataAdapter("select Customerid,Name,Add1,Add2,Add3,Add4,Contact,Emil,Date,Days,Total,Places from PackageBooking", conn)
            adp.Fill(DS1)
            DG1.DataSource = DS1.Tables(0)
            If conn.State = ConnectionState.Open Then conn.Close()

        End Sub





        Private Sub Butmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            If vbNo = MsgBox("ARE YOU SURE YOU WANT TO MODIFY THIS RECORD", MsgBoxStyle.YesNo, "Modify Record") Then Exit Sub
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            Dim cmd1 As New SqlCommand("Delete from PackageBooking where Customerid =" & Val(TextBox1.Text) & "", conn)
            cmd1.ExecuteNonQuery()
            If conn.State = ConnectionState.Open Then conn.Close()
            saveRecord()


        End Sub


        Private Sub Butdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            If vbNo = MsgBox("ARE YOU SURE YOU WANT TO MODIFY THIS RECORD", MsgBoxStyle.YesNo, " Delete") Then Exit Sub
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            Dim cmd1 As New SqlCommand("Delete from PackageBooking where Customerid =" & Val(TextBox1.Text) & "", conn)
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
            ComboBox3.Text = ""
            TextBox10.Text = ""
            TextBox11.Text = ""

            TextBox1.Focus()
        End Sub












        Private Sub DG1_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG1.CellContentClick
            pkvar = DG1.CurrentRow.Cells(0).Value
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            Dim cmd0 As New SqlCommand("select * from PackageBooking where Customerid='" & pkvar & "'", conn)
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
                TextBox11.Text = d1(11).ToString
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

                ComboBox3.Text = ""
                TextBox10.Text = ""
                TextBox11.Text = ""


            End If
        End Sub

        Private Sub Butsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            saveRecord()
        End Sub


        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub Butexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            End
        End Sub

        Private Sub ModifyGOA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            disrecords()
        End Sub

        Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

        End Sub

        Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged

            TextBox11.Text = Val(TextBox10.Text) * 3 / 4
        End Sub


    Private Sub Butcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If vbNo = MsgBox("ARE YOU SURE YOU WANT TO CANCEL YOUR TICKET", MsgBoxStyle.YesNo, " Delete") Then Exit Sub
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd1 As New SqlCommand("Delete from PackageBooking where Customerid =" & Val(TextBox1.Text) & "", conn)
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
        ComboBox3.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox1.Focus()
    End Sub



    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class