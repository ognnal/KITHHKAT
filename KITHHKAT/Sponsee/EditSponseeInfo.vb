Imports System
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports Microsoft.SqlServer.Server

Public Class EditSponseeInfo
    Private sponseeid As String
    Private FirstName As String
    Private LastName As String
    Private DOB As Date
    Private Gender As String
    Private Grade As String
    Private ShoeSize As Integer
    Private ShirtSize As Integer
    Private PantsSize As Integer
    Private DateJoinCOJ As Date
    Private Photo As String
    Private AppPath As String
    Private ChurchID As String

    Public Property Thesponseeid() As String
        Get
            Return sponseeid
        End Get
        Set(ByVal value As String)
            sponseeid = value
        End Set
    End Property
    Public Property TheFirstName() As String
        Get
            Return FirstName
        End Get
        Set(ByVal value As String)
            FirstName = value
        End Set
    End Property
    Public Property TheLastName() As String
        Get
            Return LastName
        End Get
        Set(ByVal value As String)
            LastName = value
        End Set
    End Property
    Public Property TheDOB() As Date
        Get
            Return DOB
        End Get
        Set(ByVal value As Date)
            DOB = value
        End Set
    End Property
    Public Property TheGender() As String
        Get
            Return Gender
        End Get
        Set(ByVal value As String)
            Gender = value
        End Set
    End Property
    Public Property TheGrade() As String
        Get
            Return Grade
        End Get
        Set(ByVal value As String)
            Grade = value
        End Set
    End Property
    Public Property TheShoeSize() As Integer
        Get
            Return ShoeSize
        End Get
        Set(ByVal value As Integer)
            ShoeSize = value
        End Set
    End Property
    Public Property TheShirtSize() As Integer
        Get
            Return ShirtSize
        End Get
        Set(ByVal value As Integer)
            ShirtSize = value
        End Set
    End Property
    Public Property ThePantsSize() As Integer
        Get
            Return PantsSize
        End Get
        Set(ByVal value As Integer)
            PantsSize = value
        End Set
    End Property
    Public Property TheDateJoinCOJ() As Date
        Get
            Return DateJoinCOJ
        End Get
        Set(ByVal value As Date)
            DateJoinCOJ = value
        End Set
    End Property
    Public Property ThePhoto() As String
        Get
            Return Photo
        End Get
        Set(ByVal value As String)
            Photo = value
        End Set
    End Property
    Public Property TheAppPath() As String
        Get
            Return AppPath
        End Get
        Set(ByVal value As String)
            AppPath = value
        End Set
    End Property
    Public Property TheChurchID() As String
        Get
            Return ChurchID
        End Get
        Set(ByVal value As String)
            ChurchID = value
        End Set
    End Property

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

            tbSponseeID.Text = sponseeid
            tbFirstName.Text = FirstName
            tbLastName.Text = LastName
            dtpDOB.Value = DOB
            If Gender = "F" Then
                rbFemale.Select()
            ElseIf Gender = "M" Then
                rbMale.Select()
            Else

            End If
            'GenderfromRB = Gender
            cbGrade.SelectedValue() = Grade
            cbShoe.SelectedValue() = ShoeSize
            cbShirt.SelectedValue() = ShirtSize
            cbPants.SelectedValue() = PantsSize
            dtpJoinCOJ.Value = DateJoinCOJ
            cbChurchName.SelectedValue = ChurchID
            tbPhoto.Text = Photo
            tbAppPath.Text = AppPath
            pbSponsee.SizeMode = PictureBoxSizeMode.Zoom
            pbSponsee.ImageLocation() = Photo.ToString()
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
                command.CommandText = "spUpdateSponseeInfo"
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

    Private Sub btnDeleteSponsee_Click(sender As Object, e As EventArgs) Handles btnDeleteSponsee.Click
        Dim resultMsg As DialogResult = MessageBox.Show("Are you sure to DELETE Sponsee: " + sponseeid.ToString() + "?" + _
                                                         vbCrLf + vbCrLf + "Sponsee Name: " + FirstName + " " + LastName + vbCrLf, _
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
                command.CommandText = "spDeleteSponseeInfo"
                command.Parameters.AddWithValue("@Sponseeid", sponseeid.ToString())
                command.Parameters.AddWithValue("@UserModified", Environment.UserDomainName.ToString() + "\" + Environment.UserName.ToString())

                adapter = New SqlDataAdapter(command)
                adapter.Fill(ds)
                connection.Close()

                Me.Close()

                MessageBox.Show("Sponsee: " + sponseeid.ToString() + " has been removed.")
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

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            Process.Start(tbAppPath.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class