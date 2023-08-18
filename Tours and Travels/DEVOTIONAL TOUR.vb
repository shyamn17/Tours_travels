Imports System.Data.SqlClient
Public Class DEVOTIONAL_TOUR
   

        Sub disrecords()
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            Dim DS1 As New DataSet
        Dim adp As New SqlDataAdapter("select * from Booking", conn)
            adp.Fill(DS1)
            DG1.DataSource = DS1.Tables(0)
            If conn.State = ConnectionState.Open Then conn.Close()

        End Sub
        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
            Me.Close()
        End Sub





    Private Sub DEVOTIONAL_TOUR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        disrecords()
    End Sub
End Class