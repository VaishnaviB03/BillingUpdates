Imports System.Data
Imports System.Data.OleDb
Public Class NewBill

    Private Sub Button1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Button1.ForeColor = Color.Red
    End Sub


    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Label35.Location = New Point(107, 492)
        'TextBox10.Location = New Point(238, 492)
        Panel9.Visible = False
        Panel10.Visible = False
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
            
            Panel9.Visible = False
            Label35.Visible = True
            TextBox10.Visible = True
            Label36.Visible = True
            Panel10.Visible = True
            
        ElseIf ComboBox2.Text = "Paytm" Or ComboBox2.Text = "Gpay" Or ComboBox2.Text = "PhonePay" Then
            Label35.Visible = False
            TextBox10.Visible = False
            Panel9.Visible = False
            
            Label36.Visible = False
        ElseIf ComboBox2.SelectedItem = "Cheque" Then
            
            Panel9.Visible = True
            Panel10.Visible = False
            Label36.Visible = False

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
                amt = dr.GetValue(7)
                dis = dr.GetValue(8)
                Label17.Text = dr.GetValue(7)
                Label2.Text = dr.GetValue(5)
                Label39.Text = dr.GetValue(4)
                str1 = dr.GetValue(4)
                stock = dr.GetValue(4)
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox("error", ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub
    Public Sub data()
        conn.Close()
        conn.Open()
        cmd = New OleDbCommand(str, conn)
        cmd.CommandText = "Select * from Products Where ProductName=ComboBox1.Text"
        cmd.Prepare()
        cmd.Parameters.AddWithValue("ComboBox1.Text", ComboBox1.Text)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        Try
            If dr.Read() Then
                Label39.Text = dr.GetValue(4)
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

    Private Sub TextBox12_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Label36.Text = "Change  " & Conversion.Val(TextBox10.Text) - Conversion.Val(TextBox1.Text)
        'Label36.Text = TextBox10.Text - TextBox1.Text
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
            pcs = Conversion.Int(TextBox2.Text)
            Dim temp As Integer = Conversion.Val(Label17.Text)
            Dim sum As Double = Conversion.Val(TextBox1.Text)   '->20
            Dim sum1 As Integer
            Dim sum2 As Integer
            Dim sum3 As Integer
            sum = (pcs * (amt * ((100 - dis) / 100)))   '---------------------- ->26
            sum1 = sum1 + temp
            sum2 = pcs * amt
            sum3 = sum2
            sum3 = sum3 + temp
            TextBox1.Text = Conversion.Val(TextBox1.Text) + sum ' ->20+26

            ListBox1.Items.Add(pnm)
            ListBox2.Items.Add("          " & pcs)
            ListBox3.Items.Add("          " & amt)
            ListBox4.Items.Add("          " & dis)
            ListBox5.Items.Add("          " & sum)

            Receipt.ListBox1.Items.Add(pnm)
            Receipt.ListBox2.Items.Add(pcs)
            Receipt.ListBox3.Items.Add(amt)
            Receipt.ListBox4.Items.Add(dis)
            Receipt.ListBox5.Items.Add(sum)

            Label36.Text = count
            Label17.Text = sum1
            add()
            quantity2 = Label39.Text
            Label42.Text = sum

            Try
                conn.Open()
                Dim conv As String = str1 - Conversion.Val(TextBox2.Text)
                cmd = New OleDbCommand("UPDATE Products SET [Quantity]='" + conv + "' WHERE ProductName='" + ComboBox1.Text + "'", conn)
                'cmd.Connection = conn
                cmd.ExecuteReader()
                conn.Close()
            Catch ex As Exception
                MsgBox("Error", ex.Message)
            End Try
            data()
            TextBox2.Text = Nothing
            ComboBox1.Text = Nothing


        End If
    End Sub
    Public Sub add()
        conn.Close()
        conn.Open()
        cmd = New OleDbCommand(str, conn)
        cmd.CommandText = " Select * from Products where ProductName = ComboBox1.Text"
        cmd.Prepare()
        cmd.Parameters.AddWithValue("ComboBox1.Text", ComboBox1.Text)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        Try
            If dr.Read() Then
                quantity = dr.GetValue(4)
                dis = dr.GetValue(8)
                dr.Close()

            End If

        Catch ex As Exception
            MsgBox("Error", ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Receipt.Show()
        AddReceipt()
        If ListBox1.Items.Count = 0 Then
            MsgBox("Enter Items To Cart To Proceed!")
        Else
            conn.Close()
            conn.Open()
            cmd = New OleDbCommand("Insert into Bill(BillNo,Date,Customer_Name,ContactNo,Total_Amt,Mode_of_payment,Discount_allowed) values('" + Label2.Text + "','" + DateTimePicker1.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox1.Text + "','" + ComboBox2.Text + "')", conn)
            Dim i As Integer = cmd.ExecuteNonQuery()
            If (i > 0) Then
                conn.Close()
                Main_Menu.Show()
                Me.Close()
            Else
                MsgBox("Bill Cannot Be Generated", MsgBoxStyle.Exclamation)
                conn.Close()

            End If
        End If
    End Sub

    Private Sub TextBox10_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox10.TextChanged
        Label36.Text = Conversion.Val(TextBox10.Text) - Conversion.Val(TextBox1.Text)

    End Sub

    Private Sub Label17_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label17.TextChanged
        'TextBox1.Text = Conversion.Val(Label17.Text) * 0.025
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ListBox1.SelectedItem = Nothing Or ListBox2.SelectedItem = Nothing Or ListBox3.SelectedItem = Nothing Or ListBox4.SelectedItem = Nothing Or ListBox5.SelectedItem = Nothing Then
            MsgBox("select item to remove", MsgBoxStyle.Exclamation)
        Else
            Try
                conn.Close()
                conn.Open()
                Dim y As String
                y = Conversion.Val(quantity2) - Conversion.Val(ListBox2.SelectedItem)
                Conversion.Val(y)
                Dim upd As String = "Update Products set Quantity='" + y + "' where ProductName= '" + ListBox1.SelectedItem + "'"
                cmd = New OleDbCommand(upd)
                cmd.Connection = conn
                cmd.ExecuteNonQuery()
                conn.Close()


            Catch ex As Exception
                MsgBox("Error", ex.Message)
            Finally
                conn.Close()


            End Try
            conn.Close()
            count = 0
            count = count + 1
            a = 0
            TextBox10.Text = Nothing
            Dim l1 As String = ListBox1.SelectedItem
            Dim l2 As Integer = Conversion.Val(ListBox2.SelectedItem)
            Dim l3 As Integer = Conversion.Val(ListBox3.SelectedItem)
            Dim l4 As Integer = Conversion.Val(ListBox4.SelectedItem)
            Dim l5 As Integer = Conversion.Val(ListBox5.SelectedItem)
            Receipt.ListBox1.Items.Remove(l1)
            Receipt.ListBox2.Items.Remove(l2)
            Receipt.ListBox3.Items.Remove(l3)
            Receipt.ListBox4.Items.Remove(l4)
            Receipt.ListBox5.Items.Remove(l5)

            ListBox1.Items.Remove(ListBox1.SelectedItem)
            ListBox2.Items.Remove(ListBox2.SelectedItem)
            ListBox3.Items.Remove(ListBox3.SelectedItem)
            ListBox4.Items.Remove(ListBox4.SelectedItem)
            ListBox5.Items.Remove(ListBox5.SelectedItem)

            Label39.Text = Conversion.Val(Label39.Text) - Conversion.Val(ListBox2.SelectedItem)
            Label17.Text = Conversion.Val(Label17.Text) - Conversion.Val(Label42.Text)
            items = Label39.Text
            TextBox1.Text = Nothing


        End If
    End Sub
    Private Sub AddReceipt()
        billno = Label2.Text
        cn = Label4.Text
        ad = Label6.Text
        phone = Label10.Text
        remark = Label11.Text
        mode = Label17.Text
        amt = Label42.Text
        'dnt = DateTimePicker1.Text
        ta = TextBox1.Text
        Receipt.Label12.Text = billno
        Receipt.Label14.Text = cn
        Receipt.Label16.Text = phone
        Receipt.Label15.Text = ad
        Receipt.Label13.Text = dnt
        Receipt.Label17.Text = mode
        Receipt.Label29.Text = ta
        Receipt.Label28.Text = amt

    End Sub

  
    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.Click

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If Conversion.Val(TextBox2.Text) > stock Then
            MsgBox("Not Enough Stock", MsgBoxStyle.Critical)
            TextBox2.Text = Nothing
        End If
    End Sub
End Class






