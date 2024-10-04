Public Class BillinForm

    Private billingRecords As New List(Of String)


    Private Sub btnAddRecord_Click(sender As Object, e As EventArgs) Handles btnAddRecord.Click
        ' Get the values from the text boxes

        Dim medicineName As String = txtMedicineName.Text

        Dim amount As String = txtAmount.Text


        ' Validate input

        If String.IsNullOrWhiteSpace(medicineName) Or String.IsNullOrWhiteSpace(amount) Then

            MessageBox.Show("Please enter both Medicine Name and Amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        ' Create a new record

        Dim record As String = $"Medicine: {medicineName}, Amount: {amount}"

        ' Add the record to the list
        billingRecords.Add(record)
        lstMedicines.Items.Add(record)

        billingRecords.Add(record)

        'Show success message
        MessageBox.Show("Record added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Clear the input fields

        txtMedicineName.Clear()

        txtAmount.Clear()

    End Sub

    Private Sub btnOpenMainPurchase_Click(sender As Object, e As EventArgs) Handles btnOpenMainPurchase.Click

        Dim mainForm As New MainPurchaseForm(billingRecords)

        mainForm.Show() ' Show the MainPurchaseForm

    End Sub

    Private Sub Medicines_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMedicines.SelectedIndexChanged

    End Sub
End Class