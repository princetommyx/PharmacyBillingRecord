<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillinForm
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
        txtMedicineName = New TextBox()
        txtAmount = New TextBox()
        btnAddRecord = New Button()
        Panel1 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        lstMedicines = New ListBox()
        Label3 = New Label()
        btnOpenMainPurchase = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtMedicineName
        ' 
        txtMedicineName.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        txtMedicineName.Location = New Point(149, 137)
        txtMedicineName.Name = "txtMedicineName"
        txtMedicineName.Size = New Size(198, 33)
        txtMedicineName.TabIndex = 0
        ' 
        ' txtAmount
        ' 
        txtAmount.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        txtAmount.Location = New Point(367, 138)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(198, 33)
        txtAmount.TabIndex = 1
        ' 
        ' btnAddRecord
        ' 
        btnAddRecord.BackColor = Color.Red
        btnAddRecord.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddRecord.ForeColor = SystemColors.ButtonHighlight
        btnAddRecord.Location = New Point(575, 138)
        btnAddRecord.Name = "btnAddRecord"
        btnAddRecord.Size = New Size(128, 33)
        btnAddRecord.TabIndex = 2
        btnAddRecord.Text = "Add Record"
        btnAddRecord.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Green
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(968, 100)
        Panel1.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Turquoise
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(185, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(480, 32)
        Label1.TabIndex = 0
        Label1.Text = "WELLSPRING PHARMACY BILLING FORM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.ForestGreen
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(0, 140)
        Label2.Name = "Label2"
        Label2.Size = New Size(140, 25)
        Label2.TabIndex = 4
        Label2.Text = "Medicine Type"
        ' 
        ' lstMedicines
        ' 
        lstMedicines.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lstMedicines.FormattingEnabled = True
        lstMedicines.ItemHeight = 25
        lstMedicines.Location = New Point(12, 193)
        lstMedicines.Name = "lstMedicines"
        lstMedicines.Size = New Size(956, 204)
        lstMedicines.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(438, 103)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 25)
        Label3.TabIndex = 6
        Label3.Text = "Amount"
        ' 
        ' btnOpenMainPurchase
        ' 
        btnOpenMainPurchase.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnOpenMainPurchase.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnOpenMainPurchase.ForeColor = SystemColors.ButtonHighlight
        btnOpenMainPurchase.Location = New Point(709, 137)
        btnOpenMainPurchase.Name = "btnOpenMainPurchase"
        btnOpenMainPurchase.Size = New Size(259, 36)
        btnOpenMainPurchase.TabIndex = 7
        btnOpenMainPurchase.Text = "Open Main Purchase Form"
        btnOpenMainPurchase.UseVisualStyleBackColor = False
        ' 
        ' BillinForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(968, 450)
        Controls.Add(btnOpenMainPurchase)
        Controls.Add(Label3)
        Controls.Add(lstMedicines)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Controls.Add(btnAddRecord)
        Controls.Add(txtAmount)
        Controls.Add(txtMedicineName)
        Name = "BillinForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BillinForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtMedicineName As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnAddRecord As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lstMedicines As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnOpenMainPurchase As Button
End Class
