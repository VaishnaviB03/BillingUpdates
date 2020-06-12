Imports System.Data.OleDb
Public Class Add_Items

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If TextBox1.Text <> Nothing And TextBox2.Text <> Nothing And TextBox3.Text <> Nothing And TextBox4.Text <> Nothing And TextBox5.Text <> Nothing And TextBox6.Text <> Nothing And TextBox7.Text <> Nothing And ComboBox1.Text <> Nothing Then
        'Try
        '    conn.Close()
        '    conn.Open()

        '    cmd = New OleDbCommand("INSERT INTO Products(ProductName,ProductType,Company,Quantity,BatchNo,CostPrice,SellingPrice,Discount,MfgDate,ExpDate) VALUES('" + TextBox1.Text + "','" + ComboBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + DateTimePicker1.Text + "','" + DateTimePicker2.Text + "')", conn)
        '    Dim i As Integer = cmd.ExecuteNonQuery

        '    If (i > 0) Then
        '        conn.Close()
        '        MsgBox("Items Added", MsgBoxStyle.OkOnly)
        '        clear()
        '        'conn.Close()
        '    Else
        '        MsgBox("Items Can not be added", MsgBoxStyle.Exclamation)
        '    End If
        'Catch ex As Exception
        '    MsgBox("Error", ex.Message)
        'Finally
        '    conn.Close()
        'End Try
        'End If
    End Sub
    Public Sub clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        ComboBox1.Text = Nothing
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Main_Menu.Show()
        Me.Close()
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Cosmetic")
        ComboBox1.Items.Add("Sanitory")
        ComboBox1.Items.Add("Stationary")
        ComboBox1.Items.Add("Edible")
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            conn.Close()
            conn.Open()

            cmd = New OleDbCommand("INSERT INTO Products(ProductName,ProductType,Company,Quantity,BatchNo,CostPrice,SellingPrice,Discount,MfgDate,ExpDate) VALUES('" + TextBox1.Text + "','" + ComboBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + DateTimePicker1.Text + "','" + DateTimePicker2.Text + "')", conn)
            Dim i As Integer = cmd.ExecuteNonQuery

            If (i > 0) Then
                conn.Close()
                MsgBox("Items Added", MsgBoxStyle.OkOnly)
                clear()
                'conn.Close()
            Else
                MsgBox("Items Can not be added", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox("Error", ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Main_Menu.Show()
        Me.Close()
    End Sub
End Class