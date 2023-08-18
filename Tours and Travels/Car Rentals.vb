Imports System.Data.SqlClient
Public Class Car_Rentals
   
        Dim pkvar As String
        Sub saveRecord()
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            q1var = "Insert into CarRentals("
            q2var = "values("
            q1var = q1var & "PassengerID" & ","
            q2var = q2var & "" & Val(TextBox1.Text) & ","
            q1var = q1var & "Name" & ","
            q2var = q2var & "'" & UCase(TextBox2.Text) & "',"
            q1var = q1var & "Gender" & ","
            q2var = q2var & "'" & TextBox3.Text & "',"
            q1var = q1var & "Contact" & ","
            q2var = q2var & "'" & TextBox4.Text & "',"
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
            q1var = q1var & "Vehicle" & ","
            q2var = q2var & "'" & ComboBox1.Text & "',"
            q1var = q1var & "Totalkm" & ","
            q2var = q2var & "" & Val(TextBox9.Text) & ","
            q1var = q1var & "Driverfees" & ","
            q2var = q2var & "" & Val(TextBox10.Text) & ","
            q1var = q1var & "Amount" & ")"
            q2var = q2var & "" & Val(TextBox11.Text) & ")"
            MsgBox("Data has been save successfully")
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
            ComboBox1.Text = ""
            TextBox9.Text = ""
            TextBox10.Text = ""
            TextBox11.Text = ""

            TextBox1.Focus()
        End Sub
        Sub disrecords()
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            Dim DS1 As New DataSet
            Dim adp As New SqlDataAdapter("select * from CarRentals", conn)
            adp.Fill(DS1)

            If conn.State = ConnectionState.Open Then conn.Close()
        End Sub




        Private Sub Butsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            saveRecord()
            Butnew.Enabled = True
            Butsave.Enabled = True
            'Butmodify.Enabled = True
            'Butdelete.Enabled = True
        End Sub




        Private Sub Butnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub





        Private Sub Short_Trip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        disrecords()

      

    End Sub

        Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

        End Sub

        Private Sub Butsave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butsave.Click

            saveRecord()
            Butnew.Enabled = True
            Butsave.Enabled = True
        End Sub

        Private Sub Butnew_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butnew.Click
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            DateTimePicker2.Text = ""
            ComboBox1.Text = ""
            TextBox9.Text = ""
            TextBox10.Text = ""
            TextBox11.Text = ""

            TextBox1.Focus()
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            Dim cmd0 As New SqlCommand("Select max(PassengerID) from CarRentals", conn)
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


        End Sub

        Private Sub Butexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butexit.Click
            Me.Close()
        End Sub

        Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

        End Sub

        Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

        End Sub

        Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged
       
        End Sub

       
    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged
        If Val(TextBox9.Text) <= 100 Then
            TextBox10.Text = 200
        ElseIf Val(TextBox9.Text) > 100 And Val(TextBox9.Text) <= 300 Then
            TextBox10.Text = 300
        ElseIf Val(TextBox9.Text) > 300 And Val(TextBox9.Text) <= 500 Then
            TextBox10.Text = 500
        ElseIf Val(TextBox9.Text) > 500 And Val(TextBox9.Text) <= 1000 Then
            TextBox10.Text = 1000
        ElseIf Val(TextBox9.Text) > 1000 Then
            TextBox10.Text = 2000
        End If
      


    End Sub

        Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox10.TextChanged
       

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

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        TextBox3.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If ComboBox1.Text = "OMINI" Then
            TextBox11.Text = 8 * Val(TextBox9.Text)
        ElseIf ComboBox1.Text = "SWIFT DZIRE" Then
            TextBox11.Text = 9 * Val(TextBox9.Text)
        ElseIf ComboBox1.Text = "ETIOS" Then
            TextBox11.Text = 11 * Val(TextBox9.Text)
        ElseIf ComboBox1.Text = "INNOVA" Then
            TextBox11.Text = 14 * Val(TextBox9.Text)
        ElseIf ComboBox1.Text = "ERTIGA" Then
            TextBox11.Text = 11 * Val(TextBox9.Text)
            TextBox11.Show()
        End If
    End Sub
End Class
