Imports System.Data.SqlClient

Public Class EditChurch

    Dim ChurchID As String
    Dim ChurchName As String
    Dim Area As String
    Dim District As String
    Dim City As String

    Public Property Thechurchid() As String
        Get
            Return ChurchID
        End Get
        Set(ByVal value As String)
            ChurchID = value
        End Set
    End Property
    Public Property Thechurchname() As String
        Get
            Return ChurchName
        End Get
        Set(ByVal value As String)
            ChurchName = value
        End Set
    End Property
    Public Property Thearea() As String
        Get
            Return Area
        End Get
        Set(ByVal value As String)
            Area = value
        End Set
    End Property
    Public Property Thecity() As String
        Get
            Return City
        End Get
        Set(ByVal value As String)
            City = value
        End Set
    End Property
    Public Property Thedistrict() As String
        Get
            Return District
        End Get
        Set(ByVal value As String)
            District = value
        End Set
    End Property

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
                command.CommandText = "spUpdateChurchInfo"
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

    Private Sub EditChurch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbChurchCode.Text() = ChurchID
        tbChurchName.Text() = ChurchName
        tbArea.Text() = Area
        tbDistrict.Text() = District
        tbCity.Text() = City
    End Sub

    Private Sub btnDeleteChurch_Click(sender As Object, e As EventArgs) Handles btnDeleteChurch.Click
        Dim resultMsg As DialogResult = MessageBox.Show("Are you sure to DELETE ChurchID:  " + ChurchID.ToString() + "?" + _
                                                        vbCrLf + vbCrLf + "Church Name: " + ChurchName + vbCrLf + vbCrLf + _
                                                        vbCrLf + "Note: There must not be any dependent sponsees.",
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
                command.CommandText = "spDeleteChurchInfo"
                command.Parameters.AddWithValue("@ChurchID", ChurchID.ToString())
                command.Parameters.AddWithValue("@UserModified", Environment.UserDomainName.ToString() + "\" + Environment.UserName.ToString())

                adapter = New SqlDataAdapter(command)
                adapter.Fill(ds)
                connection.Close()

                Me.Close()

                MessageBox.Show("Church: " + ChurchID.ToString() + " has been removed.")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If

    End Sub
End Class