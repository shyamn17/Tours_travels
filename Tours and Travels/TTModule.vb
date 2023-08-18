Imports System.Data.SqlClient
Module TTModule
    Public conn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\TTDB.mdf;Integrated Security=true; User Instance=True")
    Public sqlstr As String, q1var As String, q2var As String
End Module
