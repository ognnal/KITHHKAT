Imports System.Data.SqlClient

Public Class ucMatch

    Public Sub ucMatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ''TODO: This line of code loads data into the 'HHKATDataSet.SponsorInfo' table. You can move, or remove it, as needed.
            'Me.SponsorInfoTableAdapter.Fill(Me.HHKATDataSet.SponsorInfo)
            ''TODO: This line of code loads data into the 'HHKATDataSet.SponseeInfo' table. You can move, or remove it, as needed.
            'Me.SponseeInfoTableAdapter.Fill(Me.HHKATDataSet.SponseeInfo)

            Dim dbadp1 As New SqlDataAdapter("spGetUnmatchedSponsees", "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@")
            dbadp1.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim dt1 As New DataTable
            dbadp1.Fill(dt1)
            dbadp1.Dispose()
            dgvSponsee.DataSource = dt1
            dgvSponsee.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(155, 215, 213)
            dgvSponsee.RowsDefaultCellStyle.SelectionForeColor = Color.Black

            Dim dbadp2 As New SqlDataAdapter("spGetUnmatchedSponseesCount", "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@")
            dbadp2.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim dt2 As New DataTable
            dbadp2.Fill(dt2)
            tbUnsponsoredCount.Text = dt2.Rows(0).Item(0).ToString()
            dbadp2.Dispose()

            Me.SponsorInfoTableAdapter.Fill(HHKATDataSet.SponsorInfo)

            'Dim dbadp2 As New SqlDataAdapter("spGetUnmatchedSponsors", "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@")
            'dbadp2.SelectCommand.CommandType = CommandType.StoredProcedure
            'Dim dt2 As New DataTable
            'dbadp2.Fill(dt2)
            'dbadp2.Dispose()
            'dgvSponsor.DataSource = dt2
            dgvSponsor.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(155, 215, 213)
            dgvSponsor.RowsDefaultCellStyle.SelectionForeColor = Color.Black
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnMatch_Click(sender As Object, e As EventArgs) Handles btnMatch.Click
        Try
            Dim resultMsg As DialogResult = MessageBox.Show("Are you sure to match" + vbCrLf + "Sponsee: " + _
                                                           dgvSponsee.Rows(dgvSponsee.CurrentCell.RowIndex).Cells(2).Value + " " + _
                                                           dgvSponsee.Rows(dgvSponsee.CurrentCell.RowIndex).Cells(3).Value + vbCrLf + "with " + vbCrLf + "Sponsor: " + _
                                                           dgvSponsor.Rows(dgvSponsor.CurrentCell.RowIndex).Cells(1).Value + " " + _
                                                           dgvSponsor.Rows(dgvSponsor.CurrentCell.RowIndex).Cells(2).Value + "?", _
                                                           "Important Question", MessageBoxButtons.YesNo)
            If resultMsg = System.Windows.Forms.DialogResult.Yes Then
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
                command.CommandText = "spInsertRelationship"
                command.Parameters.AddWithValue("@SponsorID", dgvSponsor.Rows(dgvSponsor.CurrentCell.RowIndex).Cells(0).Value)
                command.Parameters.AddWithValue("@SponseeID", dgvSponsee.Rows(dgvSponsee.CurrentCell.RowIndex).Cells(1).Value)
                command.Parameters.AddWithValue("@UserModified", Environment.UserDomainName.ToString() + "\" + Environment.UserName.ToString())

                adapter = New SqlDataAdapter(command)
                adapter.Fill(ds)
                connection.Close()
            End If

            Dim dbadp1 As New SqlDataAdapter("spGetUnmatchedSponsees", "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@")
            dbadp1.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim dt1 As New DataTable
            dbadp1.Fill(dt1)
            dbadp1.Dispose()
            dgvSponsee.DataSource = dt1

            Dim dbadp2 As New SqlDataAdapter("spGetUnmatchedSponseesCount", "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@")
            dbadp2.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim dt2 As New DataTable
            dbadp2.Fill(dt2)
            tbUnsponsoredCount.Text = dt2.Rows(0).Item(0).ToString()
            dbadp2.Dispose()


            Me.SponsorInfoTableAdapter.Fill(HHKATDataSet.SponsorInfo)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnNameSearch_Click(sender As Object, e As EventArgs) Handles btnNameSearch.Click
        Try
            Dim connectionString As String
            Dim connection As SqlConnection
            Dim adapter As SqlDataAdapter
            Dim command As New SqlCommand
            Dim dt As New DataTable

            connectionString = "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@;"
            connection = New SqlConnection(connectionString)

            connection.Open()
            command.Connection = connection
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "spSearchSponsor"
            command.Parameters.AddWithValue("@SponsorID", DBNull.Value)
            command.Parameters.AddWithValue("@FirstName", tbNameSearch.Text.ToString())
            command.Parameters.AddWithValue("@LastName", DBNull.Value)
            command.Parameters.AddWithValue("@City", DBNull.Value)
            command.Parameters.AddWithValue("@State", DBNull.Value)
            command.Parameters.AddWithValue("@PrimaryLanguage", DBNull.Value)
            adapter = New SqlDataAdapter(command)
            adapter.Fill(dt)
            adapter.Dispose()
            dgvSponsor.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnChurchSearch_Click(sender As Object, e As EventArgs) Handles btnChurchSearch.Click
        Try
            Dim connectionString As String
            Dim connection As SqlConnection
            Dim adapter As SqlDataAdapter
            Dim command As New SqlCommand
            Dim dt As New DataTable

            connectionString = "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@;"
            connection = New SqlConnection(connectionString)

            connection.Open()
            command.Connection = connection
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "spSearchSponsee"
            command.Parameters.AddWithValue("@ChurchID", tbChurchSearch.Text.ToString())
            command.Parameters.AddWithValue("@SponseeID", DBNull.Value)
            command.Parameters.AddWithValue("@FirstName", DBNull.Value)
            command.Parameters.AddWithValue("@LastName", DBNull.Value)
            command.Parameters.AddWithValue("@DOB", DBNull.Value)
            command.Parameters.AddWithValue("@Grade", DBNull.Value)
            command.Parameters.AddWithValue("@DateJoinCOJ", DBNull.Value)
            adapter = New SqlDataAdapter(command)
            adapter.Fill(dt)
            adapter.Dispose()
            dgvSponsee.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tbChurchSearch_MouseClick(sender As Object, e As MouseEventArgs) Handles tbChurchSearch.MouseClick
        tbChurchSearch.Text = ""
    End Sub

    Private Sub tbNameSearch_MouseClick(sender As Object, e As MouseEventArgs) Handles tbNameSearch.MouseClick
        tbNameSearch.Text = ""
    End Sub

End Class
