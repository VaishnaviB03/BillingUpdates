Imports System.Data
Imports System.Data.OleDb
''Hello
Public Class NewBill

    Private Sub Button1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Button1.ForeColor = Color.Red
    End Sub


    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Label35.Location = New Point(107, 492)
        'TextBox10.Location = New Point(238, 492)
        Panel9.Visible = False
        Label37.Visible = False
        TextBox12.Visible = False
        Label35.Visible = False
        TextBox10.Visible = False
        Label36.Visible = False

        Sitem()
    End Sub



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Receipt.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Main_Menu.Show()
        Me.Close()
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Label4.Text = TextBox3.Text
    End Sub
    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        Label10.Text = TextBox4.Text
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        Label6.Text = TextBox5.Text
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        Label11.Text = TextBox6.Text
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Label16.Text = ComboBox2.Text
        'ComboBox2.Items.Add("Cash")
        'ComboBox2.Items.Add("Paytm")
        'ComboBox2.Items.Add("Gpay")
        'ComboBox2.Items.Add("PhonePay")
        'ComboBox2.Items.Add("Cheque")
        If ComboBox2.Text = "Cash" Then
            Label37.Visible = False
            TextBox12.Visible = False
            Panel9.Visible = False
            Label35.Visible = True
            TextBox10.Visible = True
            Label36.Visible = True

            'Label35.Location = New Point(107, 492)
            'TextBox10.Location = New Point(238, 492)
        ElseIf ComboBox2.Text = "Paytm" Or ComboBox2.Text = "Gpay" Or ComboBox2.Text = "PhonePay" Then
            Label35.Visible = False
            TextBox10.Visible = False
            Panel9.Visible = False
            Label37.Visible = True
            TextBox12.Visible = True
            Label36.Visible = False
        ElseIf ComboBox2.SelectedItem = "Cheque" Then
            Label37.Visible = False
            TextBox12.Visible = False
            Panel9.Visible = True
            Label35.Visible = False
            TextBox10.Visible = False
            Label36.Visible = False
            Panel9.Location = New Point(69, 472)

        End If


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        conn.Close()
        conn.Open()
        cmd = New OleDbCommand(str, conn)
        cmd.CommandText = "Select * from Products Where ProductName=ComboBox1.Text"
        cmd.Prepare()
        cmd.Parameters.AddWithValue("ComboBox1.Text", ComboBox1.Text)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        Try
            If dr.Read() Then
                pnm = dr.GetValue(1)
                'amt = dr.GetValue(7)
                Label17.Text = dr.GetValue(7)
                Label2.Text = dr.GetValue(5)
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox("error", ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub
    Private Sub Sitem()
        conn.Close()
        conn.Open()
        ds.Clear()
        str = "Select ProductName from Products"
        cmd = New OleDbCommand(str, conn)
        da.SelectCommand = cmd

        da.Fill(ds, "Products")
        Dim a As Integer = ds.Tables("Products").Rows.Count - 1
        For i As Integer = 0 To a
            ComboBox1.Items.Add(ds.Tables("Products").Rows(i)(0).ToString())
        Next
    End Sub

    Private Sub Panel9_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel9.Paint

    End Sub

    Private Sub Panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub TextBox12_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox12.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True

            End If
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True

            End If
        End If
    End Sub

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox10.TextChanged
        Label36.Text = "Change  " & Conversion.Val(TextBox10.Text) - Conversion.Val(TextBox1.Text)
        'Label36.Text = TextBox10.Text - TextBox1.Text
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Clear()
    End Sub
    Public Sub Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox12.Clear()
        ComboBox1.Text = Nothing
        ComboBox2.Text = Nothing
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        Label17.Text = Nothing
        Label2.Text = Nothing



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        itemadd = 0
        If count = -1 Then
            count = 0
        End If
        If ComboBox1.Text = Nothing And TextBox2.Text = Nothing Then
            MsgBox("Enter Details", MsgBoxStyle.Information)
        Else
            count = count + 1
            Label39.Text = Conversion.Int(TextBox2.Text)
            Dim temp As Integer = Conversion.Val(Label17.Text)
            Dim sum As Integer
            Dim sum1 As Integer
            Dim sum2 As Integer

        End If
    End Sub
End Class






