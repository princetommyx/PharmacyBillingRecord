Public Class MainPurchaseForm
    Private billingRecords As List(Of String)

    ' Constructor to receive the billing records
    Public Sub New(records As List(Of String))

        InitializeComponent()

        billingRecords = records


        LoadRecords()
    End Sub

    Private Sub LoadRecords()

        ' Clear the ListBox and add all records

        lstRecords.Items.Clear()

        For Each record In billingRecords

            lstRecords.Items.Add(record)

        Next

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        ' Close the MainPurchaseForm

        Me.Close()

    End Sub
End Class