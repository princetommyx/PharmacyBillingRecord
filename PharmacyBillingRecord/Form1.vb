Imports System.Data.SqlClient
Imports Windows.Win32.System
Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim connection As New SqlConnection("Data Source=DESKTOP-E5EC930\SQLEXPRESS;Initial Catalog=loginform;Integrated Security=True;TrustServerCertificate=True")
        Dim query As String = "SELECT COUNT (*) FROM loginform WHERE username=@username AND password=@password"
        Dim cmd As New SqlCommand(query, connection)
        connection.Open()
        cmd.Parameters.AddWithValue("@username", txtUser.Text)
        cmd.Parameters.AddWithValue("@password", txtPass.Text)
        Dim count As Integer = Convert.ToInt64(cmd.ExecuteScalar)
        If count > 0 Then
            MessageBox.Show("login successful", "info", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("Login Error")
        End If
        Main.Show()
        connection.Close()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        txtPass.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim path As New Drawing2D.GraphicsPath()

        path.AddEllipse(0, 0, PictureBox1.Width, PictureBox1.Height)

        PictureBox1.Region = New Region(path)
    End Sub
End Class
