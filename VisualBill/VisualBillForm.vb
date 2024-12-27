Imports System.Data.SqlClient
Imports System.Configuration

Public Class VisualBillForm
    Private Sub VisualBillForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateInvoiceDataGrid()
    End Sub
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim ClientId As String = ClientIdTxt.Text
        Dim ClientName As String = ClientNameTxt.Text
        Dim Phone As String = PhoneTxt.Text
        Dim Email As String = EmailTxt.Text
        Dim Product As String = ProductTxt.Text
        Dim Due As String = DueTxt.Text
        Dim Total As Integer = TotalTxt.Text
        Dim Description As String = DescriptionTxt.Text

        InsertInvoice(ClientId, ClientName, Phone, Email, Product, Due, Total, Description)
        UpdateInvoiceDataGrid()
    End Sub

    Private Shared Sub InsertInvoice(ClientId As String, ClientName As String, Phone As String, Email As String, Product As String, Due As String, Total As Integer, Description As String)
        Dim checkQuery As String = "SELECT COUNT(*) FROM InvoiceTab WHERE client_id = @client_id"
        Dim insertQuery As String = "INSERT INTO InvoiceTab VALUES(@client_id, @client_name, @phone, @email, @product, @due, @total, @description);"
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("VisualBillDB").ConnectionString

        Using con As SqlConnection = New SqlConnection(connectionString)
            con.Open()

            ' Check if ClientId exists
            Using checkCmd As SqlCommand = New SqlCommand(checkQuery, con)
                checkCmd.Parameters.AddWithValue("@client_id", ClientId)
                Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show($"Client ID {ClientId} already exists!", "Error: Duplicate Client ID")
                    Return
                End If
            End Using

            ' Insert new invoice
            Using insertCmd As SqlCommand = New SqlCommand(insertQuery, con)
                insertCmd.Parameters.AddWithValue("@client_id", ClientId)
                insertCmd.Parameters.AddWithValue("@client_name", ClientName)
                insertCmd.Parameters.AddWithValue("@phone", Phone)
                insertCmd.Parameters.AddWithValue("@email", Email)
                insertCmd.Parameters.AddWithValue("@product", Product)
                insertCmd.Parameters.AddWithValue("@due", Due)
                insertCmd.Parameters.AddWithValue("@total", Total)
                insertCmd.Parameters.AddWithValue("@description", Description)

                insertCmd.ExecuteNonQuery()
            End Using

            con.Close()
            MessageBox.Show("Invoice Inserted!", "Add Invoice Confirmation")
        End Using
    End Sub


    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        UpdateInvoiceDataGrid()
    End Sub

    Private Sub UpdateInvoiceDataGrid()
        Dim query As String = "SELECT client_id AS 'Client ID', client_name AS 'Client Name', phone AS 'Phone', email AS 'E-mail', product AS 'Product', due AS 'Due', total AS 'Total', description AS 'Description' FROM InvoiceTab"
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("VisualBillDB").ConnectionString

        Using con As SqlConnection = New SqlConnection(connectionString)
            Using cnn As SqlCommand = New SqlCommand(query, con)
                Using da As New SqlDataAdapter(cnn)
                    Using de As New DataTable()
                        da.Fill(de)
                        InvoiceDataGrid.DataSource = de
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub InvoiceDataGrid_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles InvoiceDataGrid.UserDeletingRow
        If e.Row.Index >= 0 Then
            Dim ClientId As String = e.Row.Cells("Client ID").Value

            DeleteInvoice(ClientId)

            MessageBox.Show($"Client ID {ClientId}'s data was deleted!", "Delete Confirmation")
        End If
    End Sub

    Private Sub DeleteInvoice(ClientId As String)
        Dim query As String = "DELETE FROM InvoiceTab WHERE client_id=@client_id;"
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("VisualBillDB").ConnectionString

        Using con As SqlConnection = New SqlConnection(connectionString)
            con.Open()

            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@client_id", ClientId)
                cmd.ExecuteNonQuery()
            End Using

            con.Close()
        End Using
    End Sub

    Private Sub InvoiceDataGrid_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles InvoiceDataGrid.CellValueChanged
        If e.ColumnIndex = 0 Then
            MessageBox.Show($"Client ID cannot be changed. Please delete and recreate.", "Error: Attempted to update Client ID")
            UpdateInvoiceDataGrid()
        ElseIf e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = InvoiceDataGrid.Rows(e.RowIndex)
            Dim ClientId As String = selectedRow.Cells("Client ID").Value
            Dim ClientName As String = selectedRow.Cells("Client Name").Value
            Dim Phone As String = selectedRow.Cells("Phone").Value
            Dim Email As String = selectedRow.Cells("E-mail").Value
            Dim Product As String = selectedRow.Cells("Product").Value
            Dim Due As String = selectedRow.Cells("Due").Value
            Dim Total As Integer = selectedRow.Cells("Total").Value
            Dim Description As String = selectedRow.Cells("Description").Value

            ' Update database
            UpdateInvoice(ClientId, ClientName, Phone, Email, Product, Due, Total, Description)

            MessageBox.Show($"Client ID {ClientId}'s data was updated!", "Update Confirmation")
        End If
    End Sub

    Private Sub UpdateInvoice(clientId As String, clientName As String, phone As String, email As String, product As String, due As String, total As Integer, description As String)
        Dim query As String = "UPDATE InvoiceTab SET client_name=@client_name, phone=@phone, email=@Email, product=@Product,due=@Due, total=@Total, description=@Description WHERE client_id=@client_id;"
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("VisualBillDB").ConnectionString

        Using con As SqlConnection = New SqlConnection(connectionString)
            con.Open()
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@client_id", clientId)
                cmd.Parameters.AddWithValue("@client_name", clientName)
                cmd.Parameters.AddWithValue("@phone", phone)
                cmd.Parameters.AddWithValue("@email", email)
                cmd.Parameters.AddWithValue("@product", product)
                cmd.Parameters.AddWithValue("@due", due)
                cmd.Parameters.AddWithValue("@total", total)
                cmd.Parameters.AddWithValue("@description", description)
                cmd.ExecuteNonQuery()
            End Using

            con.Close()
        End Using

    End Sub
End Class
