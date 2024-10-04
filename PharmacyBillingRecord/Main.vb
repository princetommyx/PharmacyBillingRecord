Public Class Main
    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        Dim F1 As New Pharmacy_Billing_Record
        F1.Show()

    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        Dim F2 As New Sales
        F2.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btnMainPurchase_Click(sender As Object, e As EventArgs) Handles btnMainPurchase.Click
        Dim F3 As New BillinForm
        F3.Show()

    End Sub
End Class