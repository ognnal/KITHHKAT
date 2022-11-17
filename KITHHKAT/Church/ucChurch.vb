Imports System.Data.SqlClient

Public Class ucChurch
    Dim editchurch As EditChurch
    Dim ChurchID As String
    Dim ChurchName As String
    Dim Area As String
    Dim District As String
    Dim City As String
    Dim UserModified As String
    Dim DateModified As Date

    Private Sub ucChurch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'HHKATDataSet.SponsorInfo' table. You can move, or remove it, as needed.
            Me.ChurchInfoTableAdapter.Fill(Me.HHKATDataSet.ChurchInfo)

            Dim dbadp4 As New SqlDataAdapter("spGetChurchCount", "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@")
            dbadp4.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim dt4 As New DataTable
            dbadp4.Fill(dt4)
            tbChurchCount.Text = dt4.Rows(0).Item(0).ToString()
            dbadp4.Dispose()

            dgvucChurch.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(155, 215, 213)
            dgvucChurch.RowsDefaultCellStyle.SelectionForeColor = Color.Black
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub btnNewChurch_Click(sender As Object, e As EventArgs) Handles btnNewChurch.Click
        AddChurch.ShowDialog()

        Dim dbadp4 As New SqlDataAdapter("spGetChurchCount", "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@")
        dbadp4.SelectCommand.CommandType = CommandType.StoredProcedure
        Dim dt4 As New DataTable
        dbadp4.Fill(dt4)
        tbChurchCount.Text = dt4.Rows(0).Item(0).ToString()
        dbadp4.Dispose()

        Me.ChurchInfoTableAdapter.Fill(Me.HHKATDataSet.ChurchInfo)
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
            command.CommandText = "spSearchChurch"
            command.Parameters.AddWithValue("@ChurchID", tbChurchCode.Text.ToString())
            command.Parameters.AddWithValue("@ChurchName", tbChurchName.Text.ToString())
            command.Parameters.AddWithValue("@Area", tbArea.Text.ToString())
            command.Parameters.AddWithValue("@City", tbCity.Text.ToString())
            command.Parameters.AddWithValue("@District", tbDistrict.Text.ToString())
            adapter = New SqlDataAdapter(command)
            adapter.Fill(dt)
            adapter.Dispose()
            dgvucChurch.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvucChurch_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvucChurch.CellMouseDoubleClick
        Try
            editchurch = New EditChurch

            ChurchID = dgvucChurch.Rows(dgvucChurch.CurrentCell.RowIndex).Cells(0).Value.ToString
            ChurchName = dgvucChurch.Rows(dgvucChurch.CurrentCell.RowIndex).Cells(1).Value.ToString
            Area = dgvucChurch.Rows(dgvucChurch.CurrentCell.RowIndex).Cells(2).Value.ToString
            District = dgvucChurch.Rows(dgvucChurch.CurrentCell.RowIndex).Cells(3).Value.ToString
            City = dgvucChurch.Rows(dgvucChurch.CurrentCell.RowIndex).Cells(4).Value.ToString


            editchurch.Thechurchid() = Me.ChurchID
            editchurch.Thechurchname() = Me.ChurchName
            editchurch.Thearea() = Me.Area
            editchurch.Thecity() = Me.City
            editchurch.Thedistrict() = Me.District


            editchurch.ShowDialog(Me)

            Dim dbadp4 As New SqlDataAdapter("spGetChurchCount", "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@")
            dbadp4.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim dt4 As New DataTable
            dbadp4.Fill(dt4)
            tbChurchCount.Text = dt4.Rows(0).Item(0).ToString()
            dbadp4.Dispose()


            'Me.ChurchInfoTableAdapter.Fill(Me.HHKATDataSet.ChurchInfo)

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
                command.CommandText = "spSearchChurch"
                command.Parameters.AddWithValue("@ChurchID", tbChurchCode.Text.ToString())
                command.Parameters.AddWithValue("@ChurchName", tbChurchName.Text.ToString())
                command.Parameters.AddWithValue("@Area", tbArea.Text.ToString())
                command.Parameters.AddWithValue("@City", tbCity.Text.ToString())
                command.Parameters.AddWithValue("@District", tbDistrict.Text.ToString())
                adapter = New SqlDataAdapter(command)
                adapter.Fill(dt)
                adapter.Dispose()
                dgvucChurch.DataSource = dt
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
