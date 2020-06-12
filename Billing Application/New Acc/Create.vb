Imports System.Data.OleDb
Public Class Create

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Enter Details", MsgBoxStyle.Critical)
        ElseIf TextBox2.Text = TextBox3.Text Then
            
            MsgBox("User Created Successfully")

        Else
            MsgBox("Password Does Not Match", MsgBoxStyle.Critical)
            TextBox2.Text = Nothing
            TextBox3.Text = Nothing
            TextBox2.Focus()

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class