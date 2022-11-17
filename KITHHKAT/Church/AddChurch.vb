Imports System.Data.SqlClient

Public Class AddChurch

    Private Sub btnAddChurch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddChurch.Click
        Dim emptyTextBoxes =
            From txt In Me.Controls.OfType(Of TextBox)()
            Where txt.Text.Length = 0
            Select txt.Name
        If emptyTextBoxes.Any Then
            MessageBox.Show(String.Format("Please fill following textboxes: {0}",
                            String.Join(", ", emptyTextBoxes)))

        Else
            Try
                Dim connectionString As String
                Dim connection As SqlConnection
                Dim adapter As SqlDataAdapter
                Dim command As New SqlCommand
                Dim ds As New DataSet

                connectionString = "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@;"
                connection = New SqlConnection(connectionString)

                connection.Open()
                command.Connection = connection
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "spInsertChurchInfo"
                command.Parameters.AddWithValue("@ChurchID", tbChurchCode.Text.ToString())
                command.Parameters.AddWithValue("@ChurchName", tbChurchName.Text.ToString())
                command.Parameters.AddWithValue("@Area", tbArea.Text.ToString())
                command.Parameters.AddWithValue("@District", tbDistrict.Text.ToString())
                command.Parameters.AddWithValue("@UserModified", Environment.UserDomainName.ToString() + "\" + Environment.UserName.ToString())
                command.Parameters.AddWithValue("@City", tbCity.Text.ToString())
                adapter = New SqlDataAdapter(command)
                adapter.Fill(ds)

                connection.Close()

                tbChurchCode.Clear()
                tbChurchName.Clear()
                tbArea.Clear()
                tbDistrict.Clear()
                tbCity.Clear()


                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

End Class