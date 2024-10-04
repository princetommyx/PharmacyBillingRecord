Public Class Sales
    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SaleData()
    End Sub

    Private Sub SaleData()
        DataGridView1.Columns.Add("SID", "SID")
        DataGridView1.Columns.Add("Product", "Product")
        DataGridView1.Columns.Add("Quantity", "Quantity")
        DataGridView1.Columns.Add("Total", "Total")

        DataGridView1.Rows.Add("1", "Aspirin", "60", "600")
        DataGridView1.Rows.Add("2", "Lays", "2", "20")
        DataGridView1.Rows.Add("3", "Nutella", "1", "12")
        DataGridView1.Rows.Add("4", "Para", "2", "30")


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