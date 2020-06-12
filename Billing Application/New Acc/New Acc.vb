Imports System.Data
Imports System.Data.OleDb
Public Class Form3
    Private Sub Create_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Create_btn.Click
        If TextBox2.Text = TextBox3.Text Then
            UserCreation()
        Else
            MsgBox("Password Do Not Match", MsgBoxStyle.Critical)
        End If
        conn.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class