Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports Microsoft.SqlServer.Server

Public Class EditContributions

    Private RelationshipID As Integer
    Private ContributionID As Integer
    Private Amount As Decimal
    Private TransactionDate As Date

    Public Property TheRelationshipID() As String
        Get
            Return RelationshipID
        End Get
        Set(ByVal value As String)
            RelationshipID = value
        End Set
    End Property

    Public Property Thecontributionid() As String
        Get
            Return ContributionID
        End Get
        Set(ByVal value As String)
            ContributionID = value
        End Set
    End Property

    Public Property TheAmount() As String
        Get
            Return Amount
        End Get
        Set(ByVal value As String)
            Amount = value
        End Set
    End Property

    Public Property TheTransactionDate() As String
        Get
            Return TransactionDate
        End Get
        Set(ByVal value As String)
            TransactionDate = value
        End Set
    End Property

    Private Sub EditContributions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tbRelationshipID.Text() = RelationshipID
        tbContributionID.Text = ContributionID
        tbAmount.Text() = Amount
        ctpTransactionDate.Text() = TransactionDate

        'TODO: This line of code loads data into the 'HHKATDataSet.EditContribReason' table. You can move, or remove it, as needed.
        Me.EditContribReasonTableAdapter.Fill(Me.HHKATDataSet.EditContribReason)

    End Sub


    Private Sub btnDonation_Click(sender As Object, e As EventArgs) Handles btnDonation.Click
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
                command.CommandText = "spUpdateContribution"
                command.Parameters.AddWithValue("@ContributionID", tbContributionID.Text.ToString())
                command.Parameters.AddWithValue("@RelationshipID", tbRelationshipID.Text.ToString())
                command.Parameters.AddWithValue("@TransactionDate", ctpTransactionDate.Value.ToString())
                command.Parameters.AddWithValue("@TransactionAmount", tbAmount.Text.ToString())
                command.Parameters.AddWithValue("@UserModified", Environment.UserDomainName.ToString() + "\" + Environment.UserName.ToString())
                command.Parameters.AddWithValue("@EditContribReason", cbCorrectionReason.Text.ToString())

                adapter = New SqlDataAdapter(command)
                adapter.Fill(ds)
                connection.Close()

                Me.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class