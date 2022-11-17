Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration


Public Class ucSponsee
    Private editsponseesinfo As EditSponseeInfo
    Private loading As Loading
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


    Private primarylanguage As String
    Private languagereceipttext As String
    Private FontSize As Integer = 10
    Private medFontSize As Integer = 8
    Private smallFontSize As Integer = 6
    Private FontBoldWeight As Single = 0.5
    Private footerHeight As Integer = 80
    Private leftBorder As Integer = 55



    Private Sub Sponsee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dgvucSponsee.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(155, 215, 213)
            dgvucSponsee.RowsDefaultCellStyle.SelectionForeColor = Color.Black

            Me.SponseeInfoTableAdapter.Fill(Me.HHKATDataSet.SponseeInfo)
            Me.GradeTableAdapter.Fill(Me.HHKATDataSet.Grade)
            Me.ChurchInfoTableAdapter.Fill(Me.HHKATDataSet.ChurchInfo)

            Dim dbadp5 As New SqlDataAdapter("spGetSponseeCount", "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@")
            dbadp5.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim dt5 As New DataTable
            dbadp5.Fill(dt5)
            tbSponseeCount.Text = dt5.Rows(0).Item(0).ToString()
            dbadp5.Dispose()


            dtpDOB.Value = "01/01/1900"
            dtpJoinCOJ.Value = "01/01/1900"
            cbChurchName.SelectedIndex = -1
            cbGrade.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnNewSponsee_Click(sender As Object, e As EventArgs) Handles btnNewSponsee.Click
        AddSponseeInfo.ShowDialog()

        Dim dbadp5 As New SqlDataAdapter("spGetSponseeCount", "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@")
        dbadp5.SelectCommand.CommandType = CommandType.StoredProcedure
        Dim dt5 As New DataTable
        dbadp5.Fill(dt5)
        tbSponseeCount.Text = dt5.Rows(0).Item(0).ToString()
        dbadp5.Dispose()

        Me.SponseeInfoTableAdapter.Fill(Me.HHKATDataSet.SponseeInfo)
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
            command.CommandText = "spSearchSponsee"
            command.Parameters.AddWithValue("@ChurchID", cbChurchName.Text.ToString())
            command.Parameters.AddWithValue("@SponseeID", tbSponseeID.Text.ToString())
            command.Parameters.AddWithValue("@FirstName", tbFirstName.Text.ToString())
            command.Parameters.AddWithValue("@LastName", tbLastName.Text.ToString())
            command.Parameters.AddWithValue("@DOB", dtpDOB.Value.ToString())
            command.Parameters.AddWithValue("@Grade", cbGrade.Text.ToString())
            command.Parameters.AddWithValue("@DateJoinCOJ", dtpJoinCOJ.Value.ToString())
            adapter = New SqlDataAdapter(command)
            adapter.Fill(dt)
            adapter.Dispose()
            dgvucSponsee.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvucSponsee_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvucSponsee.CellMouseDoubleClick
        Try
            editsponseesinfo = New EditSponseeInfo

            'ChurchID = dgvucSponsee.Rows(dgvucSponsee.CurrentCell.RowIndex).Cells(10).Value.ToString
            'sponseeid = dgvucSponsee.Rows(dgvucSponsee.CurrentCell.RowIndex).Cells(0).Value.ToString
            'FirstName = dgvucSponsee.Rows(dgvucSponsee.CurrentCell.RowIndex).Cells(1).Value.ToString
            'LastName = dgvucSponsee.Rows(dgvucSponsee.CurrentCell.RowIndex).Cells(2).Value.ToString
            'DOB = dgvucSponsee.Rows(dgvucSponsee.CurrentCell.RowIndex).Cells(3).Value.ToString
            'Gender = dgvucSponsee.Rows(dgvucSponsee.CurrentCell.RowIndex).Cells(4).Value.ToString
            'Grade = dgvucSponsee.Rows(dgvucSponsee.CurrentCell.RowIndex).Cells(5).Value.ToString
            'ShoeSize = dgvucSponsee.Rows(dgvucSponsee.CurrentCell.RowIndex).Cells(6).Value.ToString
            'ShirtSize = dgvucSponsee.Rows(dgvucSponsee.CurrentCell.RowIndex).Cells(7).Value.ToString
            'PantsSize = dgvucSponsee.Rows(dgvucSponsee.CurrentCell.RowIndex).Cells(8).Value.ToString
            'DateJoinCOJ = dgvucSponsee.Rows(dgvucSponsee.CurrentCell.RowIndex).Cells(9).Value.ToString
            'Photo = dgvucSponsee.Rows(dgvucSponsee.CurrentCell.RowIndex).Cells(11).Value.ToString

            ChurchID = dgvucSponsee.Rows(dgvucSponsee.CurrentCell.RowIndex).Cells(0).Value.ToString
            sponseeid = dgvucSponsee.Rows(dgvucSponsee.CurrentCell.RowIndex).Cells(1).Value.ToString
            FirstName = dgvucSponsee.Rows(dgvucSponsee.CurrentCell.RowIndex).Cells(2).Value.ToString
            LastName = dgvucSponsee.Rows(dgvucSponsee.CurrentCell.RowIndex).Cells(3).Value.ToString
            DOB = dgvucSponsee.Rows(dgvucSponsee.CurrentCell.RowIndex).Cells(4).Value.ToString
            Gender = dgvucSponsee.Rows(dgvucSponsee.CurrentCell.RowIndex).Cells(5).Value.ToString
            Grade = dgvucSponsee.Rows(dgvucSponsee.CurrentCell.RowIndex).Cells(6).Value.ToString
            ShoeSize = dgvucSponsee.Rows(dgvucSponsee.CurrentCell.RowIndex).Cells(7).Value.ToString
            ShirtSize = dgvucSponsee.Rows(dgvucSponsee.CurrentCell.RowIndex).Cells(8).Value.ToString
            PantsSize = dgvucSponsee.Rows(dgvucSponsee.CurrentCell.RowIndex).Cells(9).Value.ToString
            DateJoinCOJ = dgvucSponsee.Rows(dgvucSponsee.CurrentCell.RowIndex).Cells(10).Value.ToString
            Photo = dgvucSponsee.Rows(dgvucSponsee.CurrentCell.RowIndex).Cells(11).Value.ToString
            AppPath = dgvucSponsee.Rows(dgvucSponsee.CurrentCell.RowIndex).Cells(12).Value.ToString

            editsponseesinfo.Thesponseeid() = Me.sponseeid
            editsponseesinfo.TheFirstName() = Me.FirstName
            editsponseesinfo.TheLastName() = Me.LastName
            editsponseesinfo.TheDOB() = Me.DOB
            editsponseesinfo.TheGender() = Me.Gender
            editsponseesinfo.TheGrade() = Me.Grade
            editsponseesinfo.TheShoeSize() = Me.ShoeSize
            editsponseesinfo.TheShirtSize() = Me.ShirtSize
            editsponseesinfo.ThePantsSize() = Me.PantsSize
            editsponseesinfo.TheDateJoinCOJ() = Me.DateJoinCOJ
            editsponseesinfo.ThePhoto() = Me.Photo
            editsponseesinfo.TheAppPath() = Me.AppPath
            editsponseesinfo.TheChurchID() = Me.ChurchID

            editsponseesinfo.ShowDialog(Me)

            Dim dbadp5 As New SqlDataAdapter("spGetSponseeCount", "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@")
            dbadp5.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim dt5 As New DataTable
            dbadp5.Fill(dt5)
            tbSponseeCount.Text = dt5.Rows(0).Item(0).ToString()
            dbadp5.Dispose()

            'SponseeInfoTableAdapter.Fill(Me.HHKATDataSet.SponseeInfo)

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
                command.Parameters.AddWithValue("@ChurchID", cbChurchName.Text.ToString())
                command.Parameters.AddWithValue("@SponseeID", tbSponseeID.Text.ToString())
                command.Parameters.AddWithValue("@FirstName", tbFirstName.Text.ToString())
                command.Parameters.AddWithValue("@LastName", tbLastName.Text.ToString())
                command.Parameters.AddWithValue("@DOB", dtpDOB.Value.ToString())
                command.Parameters.AddWithValue("@Grade", cbGrade.Text.ToString())
                command.Parameters.AddWithValue("@DateJoinCOJ", dtpJoinCOJ.Value.ToString())
                adapter = New SqlDataAdapter(command)
                adapter.Fill(dt)
                adapter.Dispose()
                dgvucSponsee.DataSource = dt
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub btnGenerateProfile(cbSponseeProfile As String)
        Try
            Dim pdfDoc As New Document(PageSize.A4.Rotate())

            Dim connectionString As String
            Dim connection As SqlConnection
            Dim rdr As SqlDataReader
            Dim command As New SqlCommand

            connectionString = "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@;"
            connection = New SqlConnection(connectionString)

            Dim FileName As String = "C:\Users\Public\Documents\COJ\Profiles\" + cbSponseeProfile.ToString() + "_" + DateTime.Now.ToString("yyyyMMdd") + "_" + DateTime.Now.ToString("HHmmss") + ".pdf"
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(FileName, FileMode.Create))
            pdfDoc.Open()


            Dim contentByte As PdfContentByte = pdfWrite.DirectContent
            Dim fontpath As String = "C:\Users\Public\Documents\COJ\Fonts\arial.ttf"
            Dim bFont As BaseFont = BaseFont.CreateFont(fontpath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED)
            Dim times As Font = New Font(bFont, medFontSize)

            pdfDoc.Open()
            'pdfDoc.Add(New Paragraph("Testing Paragraph \n", times))


            contentByte.MoveTo(pdfDoc.PageSize.Width / 2, 0)
            contentByte.LineTo(pdfDoc.PageSize.Width / 2, pdfDoc.PageSize.Height)
            contentByte.Stroke()


            Dim backgroundColor As BaseColor = New BaseColor(0, 191, 255)
            Dim photoBackgroundColor As BaseColor = New BaseColor(245, 245, 245)
            Dim textBackgroundColor As BaseColor = New BaseColor(173, 255, 47)

            contentByte.Rectangle(26, 26, 368, 543)
            contentByte.Stroke()
            contentByte.Rectangle(28, 28, 364, 539)
            contentByte.Stroke()

            contentByte.Rectangle(30, 30, 360, 535)
            contentByte.SaveState()
            contentByte.SetColorFill(backgroundColor)
            contentByte.FillStroke()
            contentByte.RestoreState()


            contentByte.Rectangle(50, 50, 320, 130)
            contentByte.SaveState()
            contentByte.SetColorFill(textBackgroundColor)
            contentByte.FillStroke()
            contentByte.RestoreState()

            contentByte.Rectangle(74, 204, 272, 332)
            contentByte.SaveState()
            contentByte.SetColorFill(photoBackgroundColor)
            contentByte.FillStroke()
            contentByte.RestoreState()

            contentByte.Rectangle(72, 202, 276, 336)
            contentByte.Stroke()
            contentByte.Rectangle(70, 200, 280, 340)
            contentByte.Stroke()


            command.Connection = connection
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "report.spGetSponseeInfo"
            command.Parameters.AddWithValue("@SponseeID", cbSponseeProfile.ToString())
            connection.Open()

            rdr = command.ExecuteReader()

            While rdr.Read()

                contentByte.BeginText()
                contentByte.SetFontAndSize(bFont, 14)
                contentByte.SetTextMatrix(65, 150)
                contentByte.ShowText("Child Number: " + rdr(0).ToString())
                contentByte.EndText()

                contentByte.BeginText()
                contentByte.SetFontAndSize(bFont, 14)
                contentByte.SetTextMatrix(65, 125)
                contentByte.ShowText("Child Name: " + rdr(2).ToString() + ", " + rdr(1).ToString())
                contentByte.EndText()

                contentByte.BeginText()
                contentByte.SetFontAndSize(bFont, 14)
                contentByte.SetTextMatrix(65, 100)
                contentByte.ShowText("Sponsor Number: " + rdr(3).ToString())
                contentByte.EndText()

                contentByte.BeginText()
                contentByte.SetFontAndSize(bFont, 14)
                contentByte.SetTextMatrix(65, 75)
                contentByte.ShowText("Sponsor Name: " + rdr(5).ToString() + ", " + rdr(4).ToString())
                contentByte.EndText()

                Try
                    Dim gif As Image = Image.GetInstance(rdr(6).ToString())
                    gif.ScaleToFit(250.0F, 250.0F)
                    gif.SetAbsolutePosition(115, 245)
                    contentByte.AddImage(gif)
                Catch
                End Try
            End While

            connection.Close()

            pdfDoc.Close()

            'Dim resultMsg As DialogResult = MessageBox.Show("Your Report is created at: " + FileName + ".", "Report Creation", MessageBoxButtons.OK)
            'Process.Start(FileName)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub lnkGenerateProfiles_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkGenerateProfiles.LinkClicked
        BackgroundWorker = New System.ComponentModel.BackgroundWorker
        BackgroundWorker.RunWorkerAsync()
        loading = New Loading
        loading.ShowDialog()


          End Sub


    Private Sub BackgroundWorker_DoWork(ByVal sender As Object, _
           ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker.DoWork

        For Each row As DataGridViewRow In dgvucSponsee.Rows

            sponseeid = row.Cells(1).Value.ToString
            'MessageBox.Show(sponseeid.ToString(), "Report Creation", MessageBoxButtons.OK)
            btnGenerateProfile(sponseeid)

        Next

        Dim resultMsg As DialogResult = MessageBox.Show("Your Report is created at: " + "C:\Users\Public\Documents\COJ\Profiles\", "Report Creation", MessageBoxButtons.OK)
        Process.Start("C:\Users\Public\Documents\COJ\Profiles\")
    End Sub

    Private Sub BackgroundWorker_RunWorkerCompleted(ByVal sender As Object, _
            ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) _
            Handles BackgroundWorker.RunWorkerCompleted
        loading.Close()
    End Sub

End Class
