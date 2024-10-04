<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Panel1 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        btnSales = New Button()
        btnPurchase = New Button()
        Panel3 = New Panel()
        btnMainPurchase = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Cyan
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 100)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(42, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(591, 37)
        Label1.TabIndex = 0
        Label1.Text = "WELL SPRING PHARMACY BILLING RECORDS"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        Panel2.Controls.Add(btnMainPurchase)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(btnSales)
        Panel2.Controls.Add(btnPurchase)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 100)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(200, 350)
        Panel2.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Cyan
        Button2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(14, 284)
        Button2.Name = "Button2"
        Button2.Size = New Size(172, 40)
        Button2.TabIndex = 3
        Button2.Text = "Exit"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Cyan
        Button1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(14, 202)
        Button1.Name = "Button1"
        Button1.Size = New Size(172, 37)
        Button1.TabIndex = 2
        Button1.Text = "Receipt"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnSales
        ' 
        btnSales.BackColor = Color.Cyan
        btnSales.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSales.Location = New Point(13, 95)
        btnSales.Name = "btnSales"
        btnSales.Size = New Size(173, 41)
        btnSales.TabIndex = 1
        btnSales.Text = "Sales"
        btnSales.UseVisualStyleBackColor = False
        ' 
        ' btnPurchase
        ' 
        btnPurchase.BackColor = Color.Cyan
        btnPurchase.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPurchase.ForeColor = SystemColors.ActiveCaptionText
        btnPurchase.Location = New Point(11, 40)
        btnPurchase.Name = "btnPurchase"
        btnPurchase.Size = New Size(173, 41)
        btnPurchase.TabIndex = 0
        btnPurchase.Text = "Purchase"
        btnPurchase.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(200, 100)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(600, 350)
        Panel3.TabIndex = 2
        ' 
        ' btnMainPurchase
        ' 
        btnMainPurchase.BackColor = Color.Cyan
        btnMainPurchase.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMainPurchase.Location = New Point(14, 149)
        btnMainPurchase.Name = "btnMainPurchase"
        btnMainPurchase.Size = New Size(172, 40)
        btnMainPurchase.TabIndex = 4
        btnMainPurchase.Text = "Main Purchase "
        btnMainPurchase.UseVisualStyleBackColor = False
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Main"
        Text = "Main"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSales As Button
    Friend WithEvents btnPurchase As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents btnMainPurchase As Button
End Class
