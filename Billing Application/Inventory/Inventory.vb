Imports System.Data
Imports System.Data.OleDb
Public Class Inventory
    Dim index As Integer
    
    Public Sub datagridshow()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter("Select * from Products", conn)
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        conn.Close()


    End Sub

    Private Sub Inventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn.Close()
        conn.Open()
        datagridshow()
        conn.Close()
    End Sub

   

    Private Sub Delete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        If TextBox1.Text = Nothing Then
            MsgBox("Enter Product Name", MsgBoxStyle.Exclamation)
        Else
            Dim msg As Integer = MsgBox("Do You want to delete item from Inventory?", MsgBoxStyle.YesNo)
            If msg = DialogResult.Yes Then
                Try
                    'DataGridView1.Rows.RemoveAt(index)
                    'conn.Open()
                    'Dim cmd As New OleDbCommand("Delete from Products where ProductName= '" + TextBox1.Text + "'", conn)
                    'MsgBox("Item Removed", MsgBoxStyle.Information)
                    'TextBox1.Text = Nothing



                    conn.Open()
                    DataGridView1.Rows.RemoveAt(index)
                    str = " Delete from Products where ProductName=TextBox1.Text"
                    cmd = New OleDbCommand(str, conn)
                    cmd.Parameters.AddWithValue("TextBox1.Text", TextBox1.Text)
                    cmd.ExecuteNonQuery()
                    MsgBox("Record Deleted", MsgBoxStyle.OkOnly)
                    TextBox1.Text = Nothing

                Catch ex As Exception
                    MsgBox("Error! Please try again", MsgBoxStyle.Exclamation)
                Finally
                    conn.Close()
                End Try

            End If
        End If
        getdata()
        'DataGridView1.Rows.RemoveAt(index)
        'conn.Open()
        'Dim cmd As New OleDbCommand("Delete from Products where ProductName= '" + TextBox1.Text + "'", conn)
        'TextBox1.Text = Nothing
        'MsgBox("Item Removed", MsgBoxStyle.Information)
        'conn.Close()
    End Sub


    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow
        selectedrow = DataGridView1.Rows(index)
        TextBox1.Text = selectedrow.Cells(1).Value.ToString
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'getdata()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Main_Menu.Show()
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        getdata()
    End Sub
    Public Sub getdata()
        conn.Close()
        conn.Open()
        Using cmd As New OleDbCommand
            cmd.CommandText = "Select * from Products where ProductName =TextBox1.Text"
            cmd.Connection = conn
            ' cmd = New OleDbCommand(str, conn)
            cmd.Parameters.AddWithValue("TextBox1.Text", TextBox1.Text.Trim())
            Dim dt As New DataTable
            Using da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
                DataGridView1.DataSource = dt

            End Using
        End Using
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        getdata()
    End Sub
End Class