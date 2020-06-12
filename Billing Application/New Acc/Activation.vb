Public Class Activation

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'If Not TextBox1.Text = "" Then
        If TextBox1.Text = "ADMIN" Then
            Create.Show()
            Me.Close()
            'ElseIf TextBox1.Text = "Admin" Then
            '   Create.Show()
            '  Me.Hide()
        Else
            MsgBox("Authentication Failed", MsgBoxStyle.Critical)
            'End If
            ' Else
            'MsgBox("Enter Key", MsgBoxStyle.Critical)
            TextBox1.Focus()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class