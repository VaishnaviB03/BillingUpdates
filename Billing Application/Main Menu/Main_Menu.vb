Imports System.Windows.Forms

Public Class Main_Menu

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub
    

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub Main_Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MiniProjectDataSet.Login_Page' table. You can move, or remove it, as needed.
        'Chart1.Show()
        'Me.Login_PageTableAdapter.Fill(Me.MiniProjectDataSet.Login_Page)
        'Panel1.Dock = Dock.Fill
        'Panel1.BackColor = Color.Brown
    End Sub

    Sub Switchpanel(ByVal panel As Form)

        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()

    End Sub
    Private Sub NewBillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewBillToolStripMenuItem.Click
        Switchpanel(NewBill)
        'NewBill.Show()
    End Sub

    Private Sub StockDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockDetailsToolStripMenuItem.Click
        Switchpanel(Inventory)
        ' Inventory.Show()
    End Sub

    Private Sub AddRemStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddRemStockToolStripMenuItem.Click
        Switchpanel(Add_Items)
        'Add_Items.Show()
    End Sub

    Private Sub SalesLedgerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesLedgerToolStripMenuItem.Click
        Switchpanel(Sales_Ledger)
        'Sales_Ledger.Show()
    End Sub

    Private Sub SalesReturnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesReturnToolStripMenuItem.Click
        Switchpanel(SalesReturnLedger)
        'SalesReturnLedger.Show()
    End Sub

    Private Sub HistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistoryToolStripMenuItem.Click
        Switchpanel(Bill_History)
        'Bill_History.Show()
    End Sub

    Private Sub PurchaseReturnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseReturnToolStripMenuItem.Click
        Switchpanel(PurchaseReturn)
        'PurchaseReturn.Show()

    End Sub

    Private Sub PurchaseLedgerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseLedgerToolStripMenuItem.Click
        'Purchase_Ledger.Show()
        Switchpanel(Purchase_Ledger)
    End Sub

    Private Sub EXITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub DebitorsListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DebitorsListToolStripMenuItem.Click
        Switchpanel(Debitors_list)
    End Sub
End Class
