<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        btnLogin = New Button()
        CheckBox1 = New CheckBox()
        Label1 = New Label()
        Label2 = New Label()
        txtUser = New TextBox()
        txtPass = New TextBox()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(656, 292)
        Button1.Name = "Button1"
        Button1.Size = New Size(85, 34)
        Button1.TabIndex = 0
        Button1.Text = "Cancel"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.DarkGreen
        btnLogin.ForeColor = SystemColors.ButtonHighlight
        btnLogin.Location = New Point(542, 293)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(84, 34)
        btnLogin.TabIndex = 1
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Arial Rounded MT Bold", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckBox1.Location = New Point(626, 236)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(120, 18)
        CheckBox1.TabIndex = 2
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Broadway", 14.25F)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(420, 126)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 21)
        Label1.TabIndex = 3
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Broadway", 14.25F)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(420, 183)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 21)
        Label2.TabIndex = 4
        Label2.Text = "Password"
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(542, 126)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(199, 23)
        txtUser.TabIndex = 5
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(542, 183)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(199, 23)
        txtPass.TabIndex = 6
        txtPass.UseSystemPasswordChar = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(123, 95)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(274, 203)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(263, 1)
        Label3.Name = "Label3"
        Label3.Size = New Size(319, 26)
        Label3.TabIndex = 8
        Label3.Text = "WELCOME TO WELLSPRING PHARMACY"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        Controls.Add(txtPass)
        Controls.Add(txtUser)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(CheckBox1)
        Controls.Add(btnLogin)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Login Form"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label

End Class
