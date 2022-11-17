Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports Microsoft.SqlServer.Server

Public Class AddSponseeInfo
 
    Dim GenderfromRB As String

    Private Sub rbFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rbFemale.CheckedChanged
        GenderfromRB = "F"
    End Sub
    Private Sub rbMale_CheckedChanged(sender As Object, e As EventArgs) Handles rbMale.CheckedChanged
        GenderfromRB = "M"
    End Sub

    Private Sub AddSponseeInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbPhoto.AllowDrop = True
        tbAppPath.AllowDrop = True
        Try
            'TODO: This line of code loads data into the 'HHKATDataSet.PantsSize' table. You can move, or remove it, as needed.
            Me.PantsSizeTableAdapter.Fill(Me.HHKATDataSet.PantsSize)
            'TODO: This line of code loads data into the 'HHKATDataSet.ShirtSize' table. You can move, or remove it, as needed.
            Me.ShirtSizeTableAdapter.Fill(Me.HHKATDataSet.ShirtSize)
            'TODO: This line of code loads data into the 'HHKATDataSet.ShoeSize' table. You can move, or remove it, as needed.
            Me.ShoeSizeTableAdapter.Fill(Me.HHKATDataSet.ShoeSize)
            'TODO: This line of code loads data into the 'HHKATDataSet.Grade' table. You can move, or remove it, as needed.
            Me.GradeTableAdapter.Fill(Me.HHKATDataSet.Grade)
            'TODO: This line of code loads data into the 'HHKATDataSet.ChurchInfo' table. You can move, or remove it, as needed.
            Me.ChurchInfoTableAdapter.Fill(Me.HHKATDataSet.ChurchInfo)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub btnEnterSponsee_Click(sender As Object, e As EventArgs) Handles btnEnterSponsee.Click
        Dim emptyTextBoxes =
            From txt In Me.Controls.OfType(Of TextBox)()
            Where txt.Text.Length = 0 And txt.Name <> "tbPhoto" And txt.Name <> "tbAppPath"
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
                command.CommandText = "spInsertSponseeInfo"
                command.Parameters.AddWithValue("@SponseeID", tbSponseeID.Text.ToString())
                command.Parameters.AddWithValue("@FirstName", tbFirstName.Text.ToString())
                command.Parameters.AddWithValue("@LastName", tbLastName.Text.ToString())
                command.Parameters.AddWithValue("@DOB", dtpDOB.Value.ToString())
                command.Parameters.AddWithValue("@Gender", GenderfromRB)
                command.Parameters.AddWithValue("@Grade", cbGrade.SelectedValue.ToString())
                command.Parameters.AddWithValue("@ShoeSize", cbShoe.SelectedValue.ToString())
                command.Parameters.AddWithValue("@ShirtSize", cbShirt.SelectedValue.ToString())
                command.Parameters.AddWithValue("@PantsSize", cbPants.SelectedValue.ToString())
                command.Parameters.AddWithValue("@DateJoinCOJ", dtpJoinCOJ.Value.ToString())
                command.Parameters.AddWithValue("@ChurchID", cbChurchName.SelectedValue.ToString())
                command.Parameters.AddWithValue("@Photo", tbPhoto.Text.ToString())
                command.Parameters.AddWithValue("@AppPath", tbAppPath.Text.ToString())
                command.Parameters.AddWithValue("@UserModified", Environment.UserDomainName.ToString() + "\" + Environment.UserName.ToString())

                adapter = New SqlDataAdapter(command)
                adapter.Fill(ds)
                connection.Close()

                tbSponseeID.Clear()
                tbFirstName.Clear()
                tbLastName.Clear()

                frmMain.SponseeInfoTableAdapter.Fill(frmMain.HHKATDataSet.SponseeInfo)

                Me.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub



    Private Sub tbPhoto_DragDrop(sender As Object, e As DragEventArgs) Handles tbPhoto.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            tbPhoto.Text = path
        Next
    End Sub


    Private Sub tbPhoto_DragEnter(sender As Object, e As DragEventArgs) Handles tbPhoto.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub tbAppPath_DragDrop(sender As Object, e As DragEventArgs) Handles tbAppPath.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            tbAppPath.Text = path
        Next
    End Sub


    Private Sub tbAppPath_DragEnter(sender As Object, e As DragEventArgs) Handles tbAppPath.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub



    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String = Nothing

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
        End If
        tbPhoto.Text = strFileName
    End Sub

    Private Sub btnBrowse2_Click(sender As Object, e As EventArgs) Handles btnBrowse2.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String = Nothing

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
        End If
        tbAppPath.Text = strFileName
    End Sub
End Class