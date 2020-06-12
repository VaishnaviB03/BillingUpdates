<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.BILLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewBillToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddRemStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ACCOUNTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesLedgerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseLedgerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesReturnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseReturnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DebitorsListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.LoginPageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MiniProjectDataSet = New WindowsApplication1.MiniProjectDataSet()
        Me.Login_PageTableAdapter = New WindowsApplication1.MiniProjectDataSetTableAdapters.Login_PageTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip.SuspendLayout()
        CType(Me.LoginPageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiniProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BILLToolStripMenuItem, Me.VIEWToolStripMenuItem, Me.ACCOUNTSToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(1924, 28)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'BILLToolStripMenuItem
        '
        Me.BILLToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewBillToolStripMenuItem, Me.HistoryToolStripMenuItem})
        Me.BILLToolStripMenuItem.Name = "BILLToolStripMenuItem"
        Me.BILLToolStripMenuItem.Size = New System.Drawing.Size(48, 24)
        Me.BILLToolStripMenuItem.Text = "BILL"
        '
        'NewBillToolStripMenuItem
        '
        Me.NewBillToolStripMenuItem.Name = "NewBillToolStripMenuItem"
        Me.NewBillToolStripMenuItem.Size = New System.Drawing.Size(150, 24)
        Me.NewBillToolStripMenuItem.Text = "New Bill"
        '
        'HistoryToolStripMenuItem
        '
        Me.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem"
        Me.HistoryToolStripMenuItem.Size = New System.Drawing.Size(150, 24)
        Me.HistoryToolStripMenuItem.Text = "Bill History"
        '
        'VIEWToolStripMenuItem
        '
        Me.VIEWToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InventoryToolStripMenuItem})
        Me.VIEWToolStripMenuItem.Name = "VIEWToolStripMenuItem"
        Me.VIEWToolStripMenuItem.Size = New System.Drawing.Size(56, 24)
        Me.VIEWToolStripMenuItem.Text = "VIEW"
        '
        'InventoryToolStripMenuItem
        '
        Me.InventoryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StockDetailsToolStripMenuItem, Me.AddRemStockToolStripMenuItem})
        Me.InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
        Me.InventoryToolStripMenuItem.Size = New System.Drawing.Size(139, 24)
        Me.InventoryToolStripMenuItem.Text = "Inventory"
        '
        'StockDetailsToolStripMenuItem
        '
        Me.StockDetailsToolStripMenuItem.Name = "StockDetailsToolStripMenuItem"
        Me.StockDetailsToolStripMenuItem.Size = New System.Drawing.Size(182, 24)
        Me.StockDetailsToolStripMenuItem.Text = "Stock Details"
        '
        'AddRemStockToolStripMenuItem
        '
        Me.AddRemStockToolStripMenuItem.Name = "AddRemStockToolStripMenuItem"
        Me.AddRemStockToolStripMenuItem.Size = New System.Drawing.Size(182, 24)
        Me.AddRemStockToolStripMenuItem.Text = "Add/Rem Stock"
        '
        'ACCOUNTSToolStripMenuItem
        '
        Me.ACCOUNTSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesLedgerToolStripMenuItem, Me.PurchaseLedgerToolStripMenuItem, Me.SalesReturnToolStripMenuItem, Me.PurchaseReturnToolStripMenuItem, Me.DebitorsListToolStripMenuItem})
        Me.ACCOUNTSToolStripMenuItem.Name = "ACCOUNTSToolStripMenuItem"
        Me.ACCOUNTSToolStripMenuItem.Size = New System.Drawing.Size(97, 24)
        Me.ACCOUNTSToolStripMenuItem.Text = "ACCOUNTS"
        '
        'SalesLedgerToolStripMenuItem
        '
        Me.SalesLedgerToolStripMenuItem.Name = "SalesLedgerToolStripMenuItem"
        Me.SalesLedgerToolStripMenuItem.Size = New System.Drawing.Size(186, 24)
        Me.SalesLedgerToolStripMenuItem.Text = "Sales Ledger"
        '
        'PurchaseLedgerToolStripMenuItem
        '
        Me.PurchaseLedgerToolStripMenuItem.Name = "PurchaseLedgerToolStripMenuItem"
        Me.PurchaseLedgerToolStripMenuItem.Size = New System.Drawing.Size(186, 24)
        Me.PurchaseLedgerToolStripMenuItem.Text = "Purchase Ledger"
        '
        'SalesReturnToolStripMenuItem
        '
        Me.SalesReturnToolStripMenuItem.Name = "SalesReturnToolStripMenuItem"
        Me.SalesReturnToolStripMenuItem.Size = New System.Drawing.Size(186, 24)
        Me.SalesReturnToolStripMenuItem.Text = "Sales Return"
        '
        'PurchaseReturnToolStripMenuItem
        '
        Me.PurchaseReturnToolStripMenuItem.Name = "PurchaseReturnToolStripMenuItem"
        Me.PurchaseReturnToolStripMenuItem.Size = New System.Drawing.Size(186, 24)
        Me.PurchaseReturnToolStripMenuItem.Text = "Purchase Return"
        '
        'DebitorsListToolStripMenuItem
        '
        Me.DebitorsListToolStripMenuItem.Name = "DebitorsListToolStripMenuItem"
        Me.DebitorsListToolStripMenuItem.Size = New System.Drawing.Size(186, 24)
        Me.DebitorsListToolStripMenuItem.Text = "Debitors List"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(50, 24)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'LoginPageBindingSource
        '
        Me.LoginPageBindingSource.DataMember = "Login_Page"
        Me.LoginPageBindingSource.DataSource = Me.MiniProjectDataSet
        '
        'MiniProjectDataSet
        '
        Me.MiniProjectDataSet.DataSetName = "MiniProjectDataSet"
        Me.MiniProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Login_PageTableAdapter
        '
        Me.Login_PageTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1924, 1027)
        Me.Panel1.TabIndex = 11
        '
        'Main_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Main_Menu"
        Me.Text = "Main_Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.LoginPageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiniProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MiniProjectDataSet As WindowsApplication1.MiniProjectDataSet
    Friend WithEvents LoginPageBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Login_PageTableAdapter As WindowsApplication1.MiniProjectDataSetTableAdapters.Login_PageTableAdapter
    Friend WithEvents BILLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewBillToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VIEWToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddRemStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ACCOUNTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesLedgerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseLedgerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesReturnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseReturnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DebitorsListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
