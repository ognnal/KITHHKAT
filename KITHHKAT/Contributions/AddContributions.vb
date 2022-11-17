Imports System.Data.SqlClient
Public Class AddContributions

    Private editcontributions As EditContributions
    Private relationshipid As String
    Private sponsorfirstname As String
    Private sponsorlastname As String
    Private sponseefirstname As String
    Private sponseelastname As String
    Private letterCount As Integer

    Private ContributionID As Integer
    Private Amount As Decimal
    Private TransactionDate As Date


    Public Property Therelationshipid() As String
        Get
            Return relationshipid
        End Get
        Set(ByVal value As String)
            relationshipid = value
        End Set
    End Property
    Public Property TheletterCount() As String
        Get
            Return letterCount
        End Get
        Set(ByVal value As String)
            letterCount = value
        End Set
    End Property
    Public Property Thesponsorfirstname() As String
        Get
            Return sponsorfirstname
        End Get
        Set(ByVal value As String)
            sponsorfirstname = value
        End Set
    End Property
    Public Property Thesponsorlastname() As String
        Get
            Return sponsorlastname
        End Get
        Set(ByVal value As String)
            sponsorlastname = value
        End Set
    End Property
    Public Property Thesponseefirstname() As String
        Get
            Return sponseefirstname
        End Get
        Set(ByVal value As String)
            sponseefirstname = value
        End Set
    End Property
    Public Property Thesponseelastname() As String
        Get
            Return sponseelastname
        End Get
        Set(ByVal value As String)
            sponseelastname = value
        End Set
    End Property


    Private Sub AddContributions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvContributions.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(155, 215, 213)
        dgvContributions.RowsDefaultCellStyle.SelectionForeColor = Color.Black

        tbRelationshipID.Text = relationshipid
        tbSponseeName.Text = sponseefirstname + " " + sponseelastname
        tbSponsorName.Text = sponsorfirstname + " " + sponsorlastname
        tbLetter.Text = letterCount

        Try
            Dim connectionString As String
            Dim connection As SqlConnection
            Dim adapter As SqlDataAdapter
            Dim command As New SqlCommand
            Dim ds As New DataTable

            connectionString = "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@"
            connection = New SqlConnection(connectionString)

            connection.Open()
            command.Connection = connection
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "spGetRelationshipContributions"
            command.Parameters.AddWithValue("@relationshipid", relationshipid)

            adapter = New SqlDataAdapter(command)
            adapter.Fill(ds)
            dgvContributions.DataSource = ds
            dgvContributions.Columns(2).Width = 180
            dgvContributions.Columns(3).Width = 120
            dgvContributions.Columns(4).Width = 180
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDonation_Click(sender As Object, e As EventArgs) Handles btnDonation.Click
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
            command.CommandText = "spInsertContribution"
            command.Parameters.AddWithValue("@RelationshipID", relationshipid)
            command.Parameters.AddWithValue("@TransactionAmount", tbAmount.Text.ToString())
            command.Parameters.AddWithValue("@UserModified", Environment.UserDomainName.ToString() + "\" + Environment.UserName.ToString())

            adapter = New SqlDataAdapter(command)
            adapter.Fill(ds)
            connection.Close()

            tbAmount.Clear()

            Dim connectionString2 As String
            Dim connection2 As SqlConnection
            Dim adapter2 As SqlDataAdapter
            Dim command2 As New SqlCommand
            Dim ds2 As New DataTable

            connectionString2 = "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@"
            connection2 = New SqlConnection(connectionString2)

            connection2.Open()
            command2.Connection = connection2
            command2.CommandType = CommandType.StoredProcedure
            command2.CommandText = "spGetRelationshipContributions"
            command2.Parameters.AddWithValue("@relationshipid", relationshipid)

            adapter2 = New SqlDataAdapter(command2)
            adapter2.Fill(ds2)
            dgvContributions.DataSource = ds2
            connection2.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnUpdateLetter_Click(sender As Object, e As EventArgs) Handles btnUpdateLetter.Click
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
            command.CommandText = "spUpdateLetter"
            command.Parameters.AddWithValue("@RelationshipID", relationshipid)
            command.Parameters.AddWithValue("@Letter", tbLetter.Text.ToString())
            command.Parameters.AddWithValue("@UserModified", Environment.UserDomainName.ToString() + "\" + Environment.UserName.ToString())

            adapter = New SqlDataAdapter(command)
            adapter.Fill(ds)
            connection.Close()

            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnUnmatchRelationship_Click(sender As Object, e As EventArgs) Handles btnUnmatchRelationship.Click

        Dim resultMsg As DialogResult = MessageBox.Show("Are you sure to UNMATCH RelationshipID: " + relationshipid.ToString() + "?" + _
                                                        vbCrLf + vbCrLf + "Sponsee: " + sponseefirstname.ToString() + " " + _
                                                        sponseelastname.ToString() + vbCrLf + "Sponsor: " + sponsorfirstname.ToString() + _
                                                        " " + sponsorlastname.ToString() + vbCrLf + vbCrLf + "Sponsee and Sponsor's Relationship AND Contributions will be removed.",
                                                       "Important Question", MessageBoxButtons.YesNo)
        If resultMsg = System.Windows.Forms.DialogResult.Yes Then
            Try
                Dim connectionString As String
                Dim connection As SqlConnection
                Dim adapter As SqlDataAdapter
                Dim command As New SqlCommand
                Dim ds As New DataSet

                connectionString = "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@"
                connection = New SqlConnection(connectionString)

                connection.Open()
                command.Connection = connection
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "spDeleteRelationshipInfo"
                command.Parameters.AddWithValue("@RelationshipID", relationshipid)
                command.Parameters.AddWithValue("@UserModified", Environment.UserDomainName.ToString() + "\" + Environment.UserName.ToString())

                adapter = New SqlDataAdapter(command)
                adapter.Fill(ds)
                connection.Close()

                Me.Close()

                MessageBox.Show("Relationship: " + relationshipid + " has been removed.")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If

    End Sub


    Private Sub dgvContributions_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvContributions.CellMouseDoubleClick
        Try
            editcontributions = New EditContributions

            ContributionID = dgvContributions.Rows(dgvContributions.CurrentCell.RowIndex).Cells(0).Value.ToString
            relationshipid = dgvContributions.Rows(dgvContributions.CurrentCell.RowIndex).Cells(1).Value.ToString
            TransactionDate = dgvContributions.Rows(dgvContributions.CurrentCell.RowIndex).Cells(2).Value.ToString
            Amount = dgvContributions.Rows(dgvContributions.CurrentCell.RowIndex).Cells(4).Value.ToString

            editcontributions.Thecontributionid() = Me.ContributionID
            editcontributions.TheRelationshipID() = Me.relationshipid
            editcontributions.TheTransactionDate() = Me.TransactionDate
            editcontributions.TheAmount() = Me.Amount

            editcontributions.ShowDialog(Me)
            'Me.SponsorInfoTableAdapter.Fill(Me.HHKATDataSet.SponsorInfo)
            Try
                Dim connectionString As String
                Dim connection As SqlConnection
                Dim adapter As SqlDataAdapter
                Dim command As New SqlCommand
                Dim ds As New DataTable

                connectionString = "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@"
                connection = New SqlConnection(connectionString)

                connection.Open()
                command.Connection = connection
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = "spGetRelationshipContributions"
                command.Parameters.AddWithValue("@relationshipid", relationshipid)

                adapter = New SqlDataAdapter(command)
                adapter.Fill(ds)
                dgvContributions.DataSource = ds
                dgvContributions.Columns(2).Width = 180
                dgvContributions.Columns(3).Width = 120
                dgvContributions.Columns(4).Width = 180
                connection.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class