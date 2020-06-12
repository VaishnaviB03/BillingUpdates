Public Class Form1
    Dim flag As Integer
    Dim Admin As Char
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Then
            MsgBox("Either username or password is missing", MsgBoxStyle.Critical)
        Else
            Login()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Or flag = 0 Then
            TextBox2.PasswordChar = Nothing
            flag = 1
        Else
            TextBox2.PasswordChar = "*"
            flag = 0
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Activation.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Me.Close()
    End Sub

    Private Sub Button1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        Button1.ForeColor = Color.Red
    End Sub
End Class


