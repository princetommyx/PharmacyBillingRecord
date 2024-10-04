Public Class Pharmacy_Billing_Record
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PurchaseData()
    End Sub

    Private Sub PurchaseData()
        DataGridView1.Columns.Add("PID", "PID")
        DataGridView1.Columns.Add("Product", "Product")
        DataGridView1.Columns.Add("Quantity", "Quantity")
        DataGridView1.Columns.Add("Price", "Price")
        DataGridView1.Columns.Add("Purchase_Date", "Purchase_Date")

        DataGridView1.Rows.Add("1", "Aspirin", "10", "100", "9/1/2024")
        DataGridView1.Rows.Add("2", "Aspirin", "10", "100", "9/1/2024")
        DataGridView1.Rows.Add("3", "Aspirin", "10", "100", "9/1/2024")
        DataGridView1.Rows.Add("4", "Aspirin", "10", "100", "9/1/2024")
        DataGridView1.Rows.Add("5", "Aspirin", "10", "100", "9/1/2024")
        DataGridView1.Rows.Add("6", "Aspirin", "10", "100", "9/1/2024")
        DataGridView1.Rows.Add("7", "Lays", "2", "20", "9/1/2024")
        DataGridView1.Rows.Add("8", "Nutella", "1", "12", "9/1/2024")
        DataGridView1.Rows.Add("9", "Para", "2", "30", "9/1/2024")

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchTerm As String = TextBox1.Text
        SearchData(searchTerm)
    End Sub

    Private Sub SearchData(ByVal searchTerm As String)
        Dim found As Boolean = False
        For Each row As DataGridViewRow In DataGridView1.Rows
            For Each cell As DataGridViewCell In row.Cells
                If cell.Value IsNot Nothing AndAlso cell.Value.ToString().ToLower().Contains(searchTerm.ToLower()) Then
                    row.Selected = True
                    found = True

                    Exit For
                Else
                    row.Selected = False
                End If



            Next

            If found Then
                Exit For
            End If

        Next

        If Not found Then
            MessageBox.Show("Record Not Found")
        End If
    End Sub
End Class