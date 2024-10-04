<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPurchaseForm
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
        lstRecords = New ListBox()
        btnClose = New Button()
        Label1 = New Label()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lstRecords
        ' 
        lstRecords.BackColor = Color.White
        lstRecords.FormattingEnabled = True
        lstRecords.ItemHeight = 15
        lstRecords.Location = New Point(26, 163)
        lstRecords.Name = "lstRecords"
        lstRecords.Size = New Size(749, 259)
        lstRecords.TabIndex = 0
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Red
        btnClose.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        btnClose.ForeColor = SystemColors.ButtonHighlight
        btnClose.Location = New Point(677, 118)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(98, 39)
        btnClose.TabIndex = 1
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.DarkTurquoise
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label1.Location = New Point(222, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(402, 25)
        Label1.TabIndex = 2
        Label1.Text = "Main Purchase Data Of Well Sring Pharmacy"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Green
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 100)
        Panel1.TabIndex = 3
        ' 
        ' MainPurchaseForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(btnClose)
        Controls.Add(lstRecords)
        Name = "MainPurchaseForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lstRecords As ListBox
    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
