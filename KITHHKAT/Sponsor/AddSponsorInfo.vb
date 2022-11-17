Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports Microsoft.SqlServer.Server

Public Class AddSponsorInfo

    Private Sub btnEnterSponInfo_Click(sender As Object, e As EventArgs) Handles btnEnterSponInfo.Click
        Dim emptyTextBoxes =
            From txt In Me.Controls.OfType(Of TextBox)()
            Where txt.Text.Length = 0 And txt.Name <> "tbAmount" And txt.Name <> "tbSponsorAFN" And txt.Name <> "tbSponsorEmail"
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
                command.CommandText = "spInsertSponsorInfo"
                command.Parameters.AddWithValue("@SponsorID", tbSponsorID.Text.ToString())
                command.Parameters.AddWithValue("@FirstName", tbSponsorFN.Text.ToString())
                command.Parameters.AddWithValue("@LastName", tbSponsorLN.Text.ToString())
                command.Parameters.AddWithValue("@AlternateName", tbSponsorAFN.Text.ToString())
                command.Parameters.AddWithValue("@Email", tbSponsorEmail.Text.ToString())
                command.Parameters.AddWithValue("@Address", tbAddress.Text.ToString())
                command.Parameters.AddWithValue("@City", tbCity.Text.ToString())
                command.Parameters.AddWithValue("@State", cbState.SelectedValue.ToString())
                command.Parameters.AddWithValue("@PhoneNum", tbPhoneNum.Text.ToString())
                command.Parameters.AddWithValue("@PrimaryLanguage", cbPrimaryLanguage.SelectedValue.ToString())
                command.Parameters.AddWithValue("@UserModified", Environment.UserDomainName.ToString() + "\" + Environment.UserName.ToString())
                adapter = New SqlDataAdapter(command)
                adapter.Fill(ds)
                connection.Close()

                tbSponsorID.Clear()
                tbSponsorFN.Clear()
                tbSponsorLN.Clear()
                tbSponsorAFN.Clear()
                tbSponsorEmail.Clear()
                tbAddress.Clear()
                tbCity.Clear()
                tbPhoneNum.Clear()

                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub AddSponsorInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'HHKATDataSet.PrimaryLanguage' table. You can move, or remove it, as needed.
            Me.PrimaryLanguageTableAdapter.Fill(Me.HHKATDataSet.PrimaryLanguage)
            'TODO: This line of code loads data into the 'HHKATDataSet.StateRef' table. You can move, or remove it, as needed.
            Me.StateRefTableAdapter.Fill(Me.HHKATDataSet.StateRef)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class