Imports System.Data.SqlClient
Public Class EditLanguageReceiptText

    Private primarylanguage As String
    Private languagereceipttext As String

    Public Property Theprimarylanguage() As String
        Get
            Return primarylanguage
        End Get
        Set(ByVal value As String)
            primarylanguage = value
        End Set
    End Property
    Public Property Thelanguagereceipttext() As String
        Get
            Return languagereceipttext
        End Get
        Set(ByVal value As String)
            languagereceipttext = value
        End Set
    End Property

    Private Sub EditLanguageReceiptText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbPrimaryLanguage.Text() = primarylanguage
        rtbReceiptText.Text() = languagereceipttext
    End Sub

    Private Sub btnUpdateLanguageReceiptText_Click(sender As Object, e As EventArgs) Handles btnUpdateLanguageReceiptText.Click
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
                command.CommandText = "spUpdatePrimaryLanguage"
                command.Parameters.AddWithValue("@PrimaryLanguage", tbPrimaryLanguage.Text.ToString())
                command.Parameters.AddWithValue("@LanguageReceiptText", rtbReceiptText.Text.ToString())

                adapter = New SqlDataAdapter(command)
                adapter.Fill(ds)
                connection.Close()

                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnDeleteLanguage_Click(sender As Object, e As EventArgs) Handles btnDeleteLanguage.Click
        Dim resultMsg As DialogResult = MessageBox.Show("Are you sure to DELETE Language: " + tbPrimaryLanguage.Text.ToString() + "?",
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
                command.CommandText = "spDeletePrimaryLanguage"
                command.Parameters.AddWithValue("@PrimaryLanguage", tbPrimaryLanguage.Text.ToString())
                
                adapter = New SqlDataAdapter(command)
                adapter.Fill(ds)
                connection.Close()

                Me.Close()

                MessageBox.Show("Language: " + tbPrimaryLanguage.Text.ToString() + " has been removed.")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub
End Class