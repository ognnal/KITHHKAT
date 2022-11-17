Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports Microsoft.SqlServer.Server

Public Class EditSponsorInfo
    Private edithhkcontributions As EditHHKContributions
    Private sponsorid As String
    Private firstname As String
    Private lastname As String
    Private alternatename As String
    Private email As String
    Private address As String
    Private city As String
    Private state As String
    Private phonenumber As String
    Private primarylanguage As String

    'Private SponsorID As Integer
    Private ContributionID As Integer
    Private Amount As Decimal
    Private TransactionDate As Date



    Public Property Thesponsorid() As String
        Get
            Return sponsorid
        End Get
        Set(ByVal value As String)
            sponsorid = value
        End Set
    End Property
    Public Property Thefirstname() As String
        Get
            Return firstname
        End Get
        Set(ByVal value As String)
            firstname = value
        End Set
    End Property
    Public Property Thelastname() As String
        Get
            Return lastname
        End Get
        Set(ByVal value As String)
            lastname = value
        End Set
    End Property
    Public Property Thealternatename() As String
        Get
            Return alternatename
        End Get
        Set(ByVal value As String)
            alternatename = value
        End Set
    End Property
    Public Property Theemail() As String
        Get
            Return email
        End Get
        Set(ByVal value As String)
            email = value
        End Set
    End Property
    Public Property Theaddress() As String
        Get
            Return address
        End Get
        Set(ByVal value As String)
            address = value
        End Set
    End Property
    Public Property Thecity() As String
        Get
            Return city
        End Get
        Set(ByVal value As String)
            city = value
        End Set
    End Property
    Public Property Thestate() As String
        Get
            Return state
        End Get
        Set(ByVal value As String)
            state = value
        End Set
    End Property
    Public Property Thephonenumber() As String
        Get
            Return phonenumber
        End Get
        Set(ByVal value As String)
            phonenumber = value
        End Set
    End Property
    Public Property Theprimarylanguage() As String
        Get
            Return primarylanguage
        End Get
        Set(ByVal value As String)
            primarylanguage = value
        End Set
    End Property

    ''Private Property SponsorInfoTableAdapter As Object

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
                command.CommandText = "spUpdateSponsorInfo"
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
            command.CommandText = "spGetHHKContributions"
            command.Parameters.AddWithValue("@SponsorID", sponsorid)

            adapter = New SqlDataAdapter(command)
            adapter.Fill(ds)
            dgvHHKContributionsInfo.DataSource = ds
            connection.Close()

            Me.PrimaryLanguageTableAdapter.Fill(Me.HHKATDataSet.PrimaryLanguage)
            'TODO: This line of code loads data into the 'HHKATDataSet.StateRef' table. You can move, or remove it, as needed.
            Me.StateRefTableAdapter.Fill(Me.HHKATDataSet.StateRef)


            tbSponsorID.Text() = sponsorid
            tbSponsorFN.Text = firstname
            tbSponsorLN.Text() = lastname
            tbSponsorAFN.Text() = alternatename
            tbSponsorEmail.Text() = email
            tbAddress.Text = address
            tbCity.Text() = city
            cbState.SelectedValue() = state
            tbPhoneNum.Text() = phonenumber
            cbPrimaryLanguage.SelectedValue() = primarylanguage

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnDeleteSponsor_Click(sender As Object, e As EventArgs) Handles btnDeleteSponsor.Click
        Dim resultMsg As DialogResult = MessageBox.Show("Are you sure to DELETE Sponsee: " + sponsorid.ToString() + "?" + _
                                                         vbCrLf + vbCrLf + "Sponsor Name: " + firstname + " " + lastname + vbCrLf + vbCrLf + _
                                                         "Note: All HHK Contributions will also be DELETED.", "Important Question", MessageBoxButtons.YesNo)
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
                command.CommandText = "spDeleteSponsorInfo"
                command.Parameters.AddWithValue("@Sponsorid", sponsorid.ToString())
                command.Parameters.AddWithValue("@UserModified", Environment.UserDomainName.ToString() + "\" + Environment.UserName.ToString())

                adapter = New SqlDataAdapter(command)
                adapter.Fill(ds)
                connection.Close()

                Me.Close()

                MessageBox.Show("Sponsor: " + sponsorid.ToString() + " has been removed.")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
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
            command.CommandText = "spInsertHHKContribution"
            command.Parameters.AddWithValue("@SponsorID", sponsorid)
            command.Parameters.AddWithValue("@TransactionAmount", tbAmount.Text.ToString())
            command.Parameters.AddWithValue("@UserModified", Environment.UserDomainName.ToString() + "\" + Environment.UserName.ToString())

            adapter = New SqlDataAdapter(command)
            adapter.Fill(ds)
            connection.Close()

            tbAmount.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

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
            command.CommandText = "spGetHHKContributions"
            command.Parameters.AddWithValue("@SponsorID", sponsorid)

            adapter = New SqlDataAdapter(command)
            adapter.Fill(ds)
            dgvHHKContributionsInfo.DataSource = ds
            connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvHHKContributionsInfo_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvHHKContributionsInfo.CellMouseDoubleClick
        Try
            edithhkcontributions = New EditHHKContributions

            ContributionID = dgvHHKContributionsInfo.Rows(dgvHHKContributionsInfo.CurrentCell.RowIndex).Cells(0).Value.ToString
            sponsorid = dgvHHKContributionsInfo.Rows(dgvHHKContributionsInfo.CurrentCell.RowIndex).Cells(1).Value.ToString
            TransactionDate = dgvHHKContributionsInfo.Rows(dgvHHKContributionsInfo.CurrentCell.RowIndex).Cells(2).Value.ToString
            Amount = dgvHHKContributionsInfo.Rows(dgvHHKContributionsInfo.CurrentCell.RowIndex).Cells(4).Value.ToString

            edithhkcontributions.Thecontributionid() = Me.ContributionID
            edithhkcontributions.TheSponsorID() = Me.sponsorid
            edithhkcontributions.TheTransactionDate() = Me.TransactionDate
            edithhkcontributions.TheAmount() = Me.Amount

            edithhkcontributions.ShowDialog(Me)
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
                command.CommandText = "spGetHHKContributions"
                command.Parameters.AddWithValue("@SponsorID", sponsorid)

                adapter = New SqlDataAdapter(command)
                adapter.Fill(ds)
                dgvHHKContributionsInfo.DataSource = ds
                connection.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



End Class