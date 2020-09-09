Imports System.Data
Imports System.Data.OleDb
Public Class Bill_History
    Dim index As Integer
    Dim remove As Integer

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow
        selectedrow = DataGridView1.Rows(index)
        TextBox1.Text = selectedrow.Cells(1).Value.ToString
    End Sub
    Public Sub datagridshow()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter("Select * from Bill", conn)
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        conn.Close()
    End Sub

    Private Sub Bill_History_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn.Close()
        conn.Open()
        datagridshow()
        conn.Close()
    End Sub

    Private Sub SearchBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchBtn.Click
        conn.Close()
        conn.Open()
        cmd = New OleDbCommand("Select * from Products where Customer_Name ='" + TextBox1.Text + "'", conn)
        cmd.Parameters.AddWithValue("TextBox1.Text", TextBox1.Text.Trim())
        Dim dt As New DataTable
        Using da As New OleDbDataAdapter
            da.Fill(dt)
            DataGridView1.DataSource = dt
        End Using
    End Sub

    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        If TextBox1.Text = Nothing Then
            MsgBox("Enter Customer Name", MsgBoxStyle.Information)
        Else
            Dim del As Integer = MsgBox("Do You Want To Delete From History?", MsgBoxStyle.YesNo)
            If del = DialogResult.Yes Then
                Try
                    conn.Close()
                    conn.Open()
                    DataGridView1.Rows.RemoveAt(index)
                    remove = "Delete from Bill where Customer_Name = TextBox1.Text"
                    cmd = New OleDbCommand(remove, conn)
                    cmd.Parameters.AddWithValue("TextBox1.Text", TextBox1.Text)
                    cmd.ExecuteNonQuery()
                    MsgBox("Record Deleted", MsgBoxStyle.OkOnly)
                    TextBox1.Text = Nothing
                Catch ex As Exception
                    MsgBox("Error! Try Again", MsgBoxStyle.Exclamation)
                End Try
            End If

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Main_Menu.Show()
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        data()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        data()
    End Sub
    Public Sub data()
        conn.Close()
        conn.Open()
        Using cmd As New OleDbCommand
            cmd.CommandText = "Select * from Bill"
            cmd.Connection = conn
            Dim dt As New DataTable
            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
                DataGridView1.DataSource = dt
                conn.Close()
            End Using
        End Using
    End Sub
End Class