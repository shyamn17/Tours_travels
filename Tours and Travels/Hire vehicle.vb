Imports System.Data.SqlClient
Public Class Hire_Vehicle


    Dim pkvar As String
    Sub saveRecord()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        q1var = "Insert into HireVehicle("
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
        Dim adp As New SqlDataAdapter("select * from HireVehicle", conn)
        adp.Fill(DS1)

        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub




    'Private Sub Butsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    saveRecord()
    '    Butnew.Enabled = True
    '    Butsave.Enabled = True
    '    'Butmodify.Enabled = True
    '    'Butdelete.Enabled = True
    'End Sub




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
        Dim cmd0 As New SqlCommand("Select max(PassengerID) from HireVehicle", conn)
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
        If (ComboBox1.Text) = "ZEST" Then
            TextBox11.Text = 8.5 * TextBox9.Text

        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class