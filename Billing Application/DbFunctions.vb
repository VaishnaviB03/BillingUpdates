Imports System.Data
Imports System.Data.OleDb
Module DbFunctions
    Public conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=H:\VB\Billing Application\MiniProject.accdb")
    Public cmd As New OleDbCommand
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public dt As DataTable
End Module
Module M1
    Public str As String
    Public pnm As String
    Public amt As String
    Public itemadd As Integer = 0
    Public count As Integer
End Module

Module Functions
    Public Sub UserCreation()
        Try
            conn.Open()
            cmd = New OleDbCommand("INSERT INTO Login_Page(Username1,Password1) VALUES('" & Form3.TextBox1.Text & "','" & Form3.TextBox2.Text & "')", conn)
            cmd.ExecuteNonQuery()
            MsgBox("User Created Successfully", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Error", ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub Login()
        conn.Open()
        cmd = New OleDbCommand("Select * From Login_Page where Username1='" + Form1.TextBox1.Text + "'and Password1='" + Form1.TextBox2.Text + "'", conn)
        da = New OleDbDataAdapter(cmd)  'Dataset dim da as data Adapter
        ds = New Data.DataSet       'Dataset 
        da.Fill(ds)             'FIll Method
        Dim i As Integer
        i = ds.Tables(0).Rows.Count
        If i = 0 Then
            MsgBox("Login Failed Check Your Username/Password", MsgBoxStyle.Critical)
            conn.Close()
        Else
            MsgBox("Logged In Successfully", MsgBoxStyle.Information)
            Main_Menu.Show()
            Form1.Close()
        End If
    End Sub
End Module
