Imports System.Data.SqlClient

Public Class ucRelationship
    Private addcontribution As AddContributions
    Private relationshipid As Integer
    Private sponsorfirstname As String
    Private sponseefirstname As String
    Private sponsorlastname As String
    Private sponseelastname As String
    Private letterCount As Integer

    Private Sub ucRelationship_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dgvRelationship.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(155, 215, 213)
            dgvRelationship.RowsDefaultCellStyle.SelectionForeColor = Color.Black

            Dim dbadp3 As New SqlDataAdapter("spGetRelationshipCount", "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@")
            dbadp3.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim dt3 As New DataTable
            dbadp3.Fill(dt3)
            tbRelationshipCount.Text = dt3.Rows(0).Item(0).ToString()
            dbadp3.Dispose()


            Me.ChurchInfoTableAdapter.Fill(Me.HHKATDataSet.ChurchInfo)
            cbChurchName.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub dgvRelationship_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvRelationship.CellMouseDoubleClick
        Try
            addcontribution = New AddContributions
            relationshipid = dgvRelationship.Rows(dgvRelationship.CurrentCell.RowIndex).Cells(0).Value.ToString
            sponseefirstname = dgvRelationship.Rows(dgvRelationship.CurrentCell.RowIndex).Cells(2).Value.ToString
            sponseelastname = dgvRelationship.Rows(dgvRelationship.CurrentCell.RowIndex).Cells(3).Value.ToString
            sponsorfirstname = dgvRelationship.Rows(dgvRelationship.CurrentCell.RowIndex).Cells(5).Value.ToString
            sponsorlastname = dgvRelationship.Rows(dgvRelationship.CurrentCell.RowIndex).Cells(6).Value.ToString
            letterCount = dgvRelationship.Rows(dgvRelationship.CurrentCell.RowIndex).Cells(8).Value.ToString
            addcontribution.Therelationshipid() = Me.relationshipid
            addcontribution.Thesponseefirstname() = Me.sponseefirstname
            addcontribution.Thesponseelastname() = Me.sponseelastname
            addcontribution.Thesponsorfirstname() = Me.sponsorfirstname
            addcontribution.Thesponsorlastname() = Me.sponsorlastname
            addcontribution.TheletterCount() = Me.letterCount
            addcontribution.ShowDialog(Me)

            Dim dbadp2 As New SqlDataAdapter("spSearchRelationship", "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@")
            dbadp2.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim dt2 As New DataTable
            dbadp2.Fill(dt2)
            dbadp2.Dispose()
            dgvRelationship.DataSource = dt2

            Dim dbadp3 As New SqlDataAdapter("spGetRelationshipCount", "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@")
            dbadp3.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim dt3 As New DataTable
            dbadp3.Fill(dt3)
            tbRelationshipCount.Text = dt3.Rows(0).Item(0).ToString()
            dbadp3.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
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
            command.CommandText = "spSearchRelationship"
            command.Parameters.AddWithValue("@RelationshipID", tbRelationshipID.Text.ToString())
            command.Parameters.AddWithValue("@SponsorID", tbSponsorID.Text.ToString())
            command.Parameters.AddWithValue("@SponseeID", tbSponseeID.Text.ToString())
            command.Parameters.AddWithValue("@SponseeFirstName", tbSponseeFirstName.Text.ToString())
            command.Parameters.AddWithValue("@SponseeLastName", tbSponseeLastName.Text.ToString())
            command.Parameters.AddWithValue("@ChurchName", cbChurchName.Text.ToString())
            command.Parameters.AddWithValue("@SponsorFirstName", tbSponsorFirstName.Text.ToString())
            command.Parameters.AddWithValue("@SponsorLastName", tbSponsorLastName.Text.ToString())
            adapter = New SqlDataAdapter(command)
            adapter.Fill(dt)
            adapter.Dispose()

            dgvRelationship.DataSource = dt
            dgvRelationship.Columns(1).Width = 130
            dgvRelationship.Columns(2).Width = 170
            dgvRelationship.Columns(3).Width = 170
            dgvRelationship.Columns(4).Width = 110
            dgvRelationship.Columns(5).Width = 150
            dgvRelationship.Columns(6).Width = 150
            dgvRelationship.Columns(7).Width = 154
            dgvRelationship.Columns(8).Width = 50

            dgvRelationship.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
