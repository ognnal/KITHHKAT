Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class ucReports

    Private primarylanguage As String
    Private languagereceipttext As String
    Private FontSize As Integer = 10
    Private medFontSize As Integer = 8
    Private smallFontSize As Integer = 6
    Private FontBoldWeight As Single = 0.5
    Private footerHeight As Integer = 80
    Private leftBorder As Integer = 55

    Private Sub ucReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PrimaryLanguageTableAdapter.Fill(HHKATDataSet.PrimaryLanguage)
        Me.ActivityReportTypesTableAdapter.Fill(Me.HHKATDataSet.ActivityReportTypes)
        Me.MonthTableAdapter.Fill(HHKATDataSet.Month)
        'Me.SponseeInfoTableAdapter.Fill(HHKATDataSet.SponseeInfo)
        'Me.SponsorInfoTableAdapter.Fill(HHKATDataSet.SponsorInfo)
        cbActivityReportTypes.SelectedIndex = 3
        dtpYearMonthlyReceipt.CustomFormat = "yyyy"
    End Sub

    Private Sub dgvPrimaryLanguage_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvPrimaryLanguage.CellMouseDoubleClick
        Dim editlanguagereceipttext As New EditLanguageReceiptText

        primarylanguage = dgvPrimaryLanguage.Rows(dgvPrimaryLanguage.CurrentCell.RowIndex).Cells(0).Value.ToString
        languagereceipttext = dgvPrimaryLanguage.Rows(dgvPrimaryLanguage.CurrentCell.RowIndex).Cells(1).Value.ToString

        editlanguagereceipttext.Theprimarylanguage() = Me.primarylanguage
        editlanguagereceipttext.Thelanguagereceipttext() = Me.languagereceipttext

        editlanguagereceipttext.ShowDialog()
        Me.PrimaryLanguageTableAdapter.Fill(HHKATDataSet.PrimaryLanguage)
    End Sub


    Private Sub btnSponseeActivity_Click(sender As Object, e As EventArgs) Handles btnActivityHistory.Click
        Try
            Select Case cbActivityReportTypes.SelectedValue
                Case 1
                    ChurchActivity()
                Case 2
                    ContributionActivity()
                Case 3
                    RelationshipActivity()
                Case 4
                    SponseeActivity()
                Case 5
                    SponsorActivity()
                Case 6
                    HHKContributionActivity()

            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ChurchActivity()
        Try
            Dim pdfDoc As New Document()

            Dim connectionString As String
            Dim connection As SqlConnection
            Dim rdr As SqlDataReader
            Dim command As New SqlCommand

            Dim table As PdfPTable = Nothing
            Dim cell As PdfPCell = Nothing
            Dim bFont As BaseFont = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, False)
            Dim times As Font = New Font(bFont, 6, Font.Italic)

            Dim FileName As String = "C:\Users\Public\Documents\COJ\Activity\" + "ChurchActivity_" + DateTime.Now.ToString("yyyyMMdd") + "_" + DateTime.Now.ToString("HHmmss") + ".pdf"
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(FileName, FileMode.Create))

            connectionString = "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@;"
            connection = New SqlConnection(connectionString)

            command.Connection = connection
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "report.spWarehouseChurch"
            connection.Open()

            pdfDoc.Open()

            table = New PdfPTable(8)
            cell = New PdfPCell(New Phrase("Report of all activity on Church Information:"))
            cell.Colspan = 8

            table.AddCell(cell)

            table.AddCell(New Phrase("ChurchID", times))
            table.AddCell(New Phrase("Church Name", times))
            table.AddCell(New Phrase("Area", times))
            table.AddCell(New Phrase("District", times))
            table.AddCell(New Phrase("City", times))
            table.AddCell(New Phrase("Date Modified", times))
            table.AddCell(New Phrase("User Modified", times))
            table.AddCell(New Phrase("Action", times))

            rdr = command.ExecuteReader()

            While rdr.Read()
                table.AddCell(New Phrase(rdr(0).ToString(), times))
                table.AddCell(New Phrase(rdr(1).ToString(), times))
                table.AddCell(New Phrase(rdr(2).ToString(), times))
                table.AddCell(New Phrase(rdr(3).ToString(), times))
                table.AddCell(New Phrase(rdr(4).ToString(), times))
                table.AddCell(New Phrase(rdr(5).ToString(), times))
                table.AddCell(New Phrase(rdr(6).ToString(), times))
                table.AddCell(New Phrase(rdr(7).ToString(), times))
            End While

            pdfDoc.Add(table)

            pdfDoc.Close()

            connection.Close()

            Dim resultMsg As DialogResult = MessageBox.Show("Your Report is created at: " + FileName + ".", "Report Creation", MessageBoxButtons.OK)
            Process.Start(FileName)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ContributionActivity()
        Try
            Dim pdfDoc As New Document()

            Dim connectionString As String
            Dim connection As SqlConnection
            Dim rdr As SqlDataReader
            Dim command As New SqlCommand

            Dim table As PdfPTable = Nothing
            Dim cell As PdfPCell = Nothing
            Dim bFont As BaseFont = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, False)
            Dim times As Font = New Font(bFont, 6, Font.Italic)

            Dim FileName As String = "C:\Users\Public\Documents\COJ\Activity\" + "ContributionActivity_" + DateTime.Now.ToString("yyyyMMdd") + "_" + DateTime.Now.ToString("HHmmss") + ".pdf"
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(FileName, FileMode.Create))

            connectionString = "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@;"
            connection = New SqlConnection(connectionString)

            command.Connection = connection
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "report.spWarehouseContributions"
            connection.Open()

            pdfDoc.Open()

            table = New PdfPTable(7)
            cell = New PdfPCell(New Phrase("Report of all activity on Contributions Information:"))
            cell.Colspan = 7

            table.AddCell(cell)

            table.AddCell(New Phrase("Contribution ID", times))
            table.AddCell(New Phrase("Relationship ID", times))
            table.AddCell(New Phrase("Transaction Date", times))
            table.AddCell(New Phrase("User Modified", times))
            table.AddCell(New Phrase("Transaction Amount", times))
            table.AddCell(New Phrase("Action", times))
            table.AddCell(New Phrase("Change Reason", times))

            rdr = command.ExecuteReader()

            While rdr.Read()
                table.AddCell(New Phrase(rdr(0).ToString(), times))
                table.AddCell(New Phrase(rdr(1).ToString(), times))
                table.AddCell(New Phrase(rdr(2).ToString(), times))
                table.AddCell(New Phrase(rdr(3).ToString(), times))
                table.AddCell(New Phrase(rdr(4).ToString(), times))
                table.AddCell(New Phrase(rdr(5).ToString(), times))
                table.AddCell(New Phrase(rdr(6).ToString(), times))
            End While

            pdfDoc.Add(table)

            ''pdfDoc.Add(New Paragraph("Testing Paragraph", times))
            pdfDoc.Close()

            connection.Close()

            Dim resultMsg As DialogResult = MessageBox.Show("Your Report is created at: " + FileName + ".", "Report Creation", MessageBoxButtons.OK)
            Process.Start(FileName)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub HHKContributionActivity()
        Try
            Dim pdfDoc As New Document()

            Dim connectionString As String
            Dim connection As SqlConnection
            Dim rdr As SqlDataReader
            Dim command As New SqlCommand

            Dim table As PdfPTable = Nothing
            Dim cell As PdfPCell = Nothing
            Dim bFont As BaseFont = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, False)
            Dim times As Font = New Font(bFont, 6, Font.Italic)

            Dim FileName As String = "C:\Users\Public\Documents\COJ\Activity\" + "ContributionActivity_" + DateTime.Now.ToString("yyyyMMdd") + "_" + DateTime.Now.ToString("HHmmss") + ".pdf"
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(FileName, FileMode.Create))

            connectionString = "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@;"
            connection = New SqlConnection(connectionString)

            command.Connection = connection
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "report.spWarehouseHHKContributions"
            connection.Open()

            pdfDoc.Open()

            table = New PdfPTable(7)
            cell = New PdfPCell(New Phrase("Report of all activity on Contributions Information:"))
            cell.Colspan = 7

            table.AddCell(cell)

            table.AddCell(New Phrase("HHK Contribution ID", times))
            table.AddCell(New Phrase("SponsorID", times))
            table.AddCell(New Phrase("Transaction Date", times))
            table.AddCell(New Phrase("User Modified", times))
            table.AddCell(New Phrase("Transaction Amount", times))
            table.AddCell(New Phrase("Action", times))
            table.AddCell(New Phrase("Change Reason", times))

            rdr = command.ExecuteReader()

            While rdr.Read()
                table.AddCell(New Phrase(rdr(0).ToString(), times))
                table.AddCell(New Phrase(rdr(1).ToString(), times))
                table.AddCell(New Phrase(rdr(2).ToString(), times))
                table.AddCell(New Phrase(rdr(3).ToString(), times))
                table.AddCell(New Phrase(rdr(4).ToString(), times))
                table.AddCell(New Phrase(rdr(5).ToString(), times))
                table.AddCell(New Phrase(rdr(6).ToString(), times))
            End While

            pdfDoc.Add(table)

            ''pdfDoc.Add(New Paragraph("Testing Paragraph", times))
            pdfDoc.Close()

            connection.Close()

            Dim resultMsg As DialogResult = MessageBox.Show("Your Report is created at: " + FileName + ".", "Report Creation", MessageBoxButtons.OK)
            Process.Start(FileName)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub RelationshipActivity()
        Try
            Dim pdfDoc As New Document()

            Dim connectionString As String
            Dim connection As SqlConnection
            Dim rdr As SqlDataReader
            Dim command As New SqlCommand

            Dim table As PdfPTable = Nothing
            Dim cell As PdfPCell = Nothing
            Dim bFont As BaseFont = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, False)
            Dim times As Font = New Font(bFont, 6, Font.Italic)

            Dim FileName As String = "C:\Users\Public\Documents\COJ\Activity\" + "RelationshipActivity_" + DateTime.Now.ToString("yyyyMMdd") + "_" + DateTime.Now.ToString("HHmmss") + ".pdf"
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(FileName, FileMode.Create))

            connectionString = "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@;"
            connection = New SqlConnection(connectionString)

            command.Connection = connection
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "report.spWarehouseRelationship"
            connection.Open()

            pdfDoc.Open()

            table = New PdfPTable(9)
            cell = New PdfPCell(New Phrase("Report of all activity on Relationship Information:"))
            cell.Colspan = 9

            table.AddCell(cell)

            table.AddCell(New Phrase("Relationship ID", times))
            table.AddCell(New Phrase("Sponsor ID", times))
            table.AddCell(New Phrase("Sponsee ID", times))
            table.AddCell(New Phrase("Start Date", times))
            table.AddCell(New Phrase("End Date", times))
            table.AddCell(New Phrase("Date Modified", times))
            table.AddCell(New Phrase("User Modified", times))
            table.AddCell(New Phrase("Action", times))
            table.AddCell(New Phrase("Letter", times))

            rdr = command.ExecuteReader()

            While rdr.Read()
                table.AddCell(New Phrase(rdr(0).ToString(), times))
                table.AddCell(New Phrase(rdr(1).ToString(), times))
                table.AddCell(New Phrase(rdr(2).ToString(), times))
                table.AddCell(New Phrase(rdr(3).ToString(), times))
                table.AddCell(New Phrase(rdr(4).ToString(), times))
                table.AddCell(New Phrase(rdr(5).ToString(), times))
                table.AddCell(New Phrase(rdr(6).ToString(), times))
                table.AddCell(New Phrase(rdr(7).ToString(), times))
                table.AddCell(New Phrase(rdr(8).ToString(), times))
            End While

            pdfDoc.Add(table)

            pdfDoc.Close()

            connection.Close()

            Dim resultMsg As DialogResult = MessageBox.Show("Your Report is created at: " + FileName + ".", "Report Creation", MessageBoxButtons.OK)
            Process.Start(FileName)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SponseeActivity()
        Try
            Dim pdfDoc As New Document()

            Dim connectionString As String
            Dim connection As SqlConnection
            Dim rdr As SqlDataReader
            Dim command As New SqlCommand

            Dim table As PdfPTable = Nothing
            Dim cell As PdfPCell = Nothing
            Dim bFont As BaseFont = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, False)
            Dim times As Font = New Font(bFont, 6, Font.Italic)

            Dim FileName As String = "C:\Users\Public\Documents\COJ\Activity\" + "SponseeActivity_" + DateTime.Now.ToString("yyyyMMdd") + "_" + DateTime.Now.ToString("HHmmss") + ".pdf"
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(FileName, FileMode.Create))

            connectionString = "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@;"
            connection = New SqlConnection(connectionString)

            command.Connection = connection
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "report.spWarehouseSponsee"
            connection.Open()

            pdfDoc.Open()

            table = New PdfPTable(16)
            cell = New PdfPCell(New Phrase("Report of all activity on Sponsee Information:"))
            cell.Colspan = 16

            table.AddCell(cell)

            table.AddCell(New Phrase("Sponsee ID", times))
            table.AddCell(New Phrase("First Name", times))
            table.AddCell(New Phrase("Last Name", times))
            table.AddCell(New Phrase("DOB", times))
            table.AddCell(New Phrase("Gender", times))
            table.AddCell(New Phrase("Grade", times))
            table.AddCell(New Phrase("Shoe Size", times))
            table.AddCell(New Phrase("Shirt Size", times))
            table.AddCell(New Phrase("Pants Size", times))
            table.AddCell(New Phrase("Date Join COJ", times))
            table.AddCell(New Phrase("Church ID", times))
            table.AddCell(New Phrase("Photo", times))
            table.AddCell(New Phrase("AppPath", times))
            table.AddCell(New Phrase("User Modified", times))
            table.AddCell(New Phrase("Date Modified", times))
            table.AddCell(New Phrase("Action", times))

            rdr = command.ExecuteReader()

            While rdr.Read()
                table.AddCell(New Phrase(rdr(0).ToString(), times))
                table.AddCell(New Phrase(rdr(1).ToString(), times))
                table.AddCell(New Phrase(rdr(2).ToString(), times))
                table.AddCell(New Phrase(rdr(3).ToString(), times))
                table.AddCell(New Phrase(rdr(4).ToString(), times))
                table.AddCell(New Phrase(rdr(5).ToString(), times))
                table.AddCell(New Phrase(rdr(6).ToString(), times))
                table.AddCell(New Phrase(rdr(7).ToString(), times))
                table.AddCell(New Phrase(rdr(8).ToString(), times))
                table.AddCell(New Phrase(rdr(9).ToString(), times))
                table.AddCell(New Phrase(rdr(10).ToString(), times))
                table.AddCell(New Phrase(rdr(11).ToString(), times))
                table.AddCell(New Phrase(rdr(12).ToString(), times))
                table.AddCell(New Phrase(rdr(13).ToString(), times))
                table.AddCell(New Phrase(rdr(14).ToString(), times))
                table.AddCell(New Phrase(rdr(15).ToString(), times))
            End While

            pdfDoc.Add(table)

            pdfDoc.Close()

            connection.Close()

            Dim resultMsg As DialogResult = MessageBox.Show("Your Report is created at: " + FileName + ".", "Report Creation", MessageBoxButtons.OK)
            Process.Start(FileName)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SponsorActivity()
        Try
            Dim pdfDoc As New Document()

            Dim connectionString As String
            Dim connection As SqlConnection
            Dim rdr As SqlDataReader
            Dim command As New SqlCommand

            Dim table As PdfPTable = Nothing
            Dim cell As PdfPCell = Nothing
            Dim bFont As BaseFont = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, False)
            Dim times As Font = New Font(bFont, 6, Font.Italic)

            Dim FileName As String = "C:\Users\Public\Documents\COJ\Activity\" + "SponsorActivity_" + DateTime.Now.ToString("yyyyMMdd") + "_" + DateTime.Now.ToString("HHmmss") + ".pdf"
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(FileName, FileMode.Create))

            connectionString = "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@;"
            connection = New SqlConnection(connectionString)

            command.Connection = connection
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "report.spWarehouseSponsor"
            connection.Open()

            pdfDoc.Open()
            pdfDoc.Add(New Paragraph("Testing Paragraph \n", times))


            table = New PdfPTable(13)
            cell = New PdfPCell(New Phrase("Report of all activity on Sponsor Information:"))
            cell.Colspan = 13

            table.AddCell(cell)

            table.AddCell(New Phrase("Sponsor ID", times))
            table.AddCell(New Phrase("First Name", times))
            table.AddCell(New Phrase("Last Name", times))
            table.AddCell(New Phrase("Alternate Name", times))
            table.AddCell(New Phrase("Email", times))
            table.AddCell(New Phrase("Address", times))
            table.AddCell(New Phrase("City", times))
            table.AddCell(New Phrase("State", times))
            table.AddCell(New Phrase("Phone Number", times))
            table.AddCell(New Phrase("Date Modified", times))
            table.AddCell(New Phrase("User Modified", times))
            table.AddCell(New Phrase("Action", times))
            table.AddCell(New Phrase("Primary Language", times))

            rdr = command.ExecuteReader()

            While rdr.Read()
                table.AddCell(New Phrase(rdr(0).ToString(), times))
                table.AddCell(New Phrase(rdr(1).ToString(), times))
                table.AddCell(New Phrase(rdr(2).ToString(), times))
                table.AddCell(New Phrase(rdr(3).ToString(), times))
                table.AddCell(New Phrase(rdr(4).ToString(), times))
                table.AddCell(New Phrase(rdr(5).ToString(), times))
                table.AddCell(New Phrase(rdr(6).ToString(), times))
                table.AddCell(New Phrase(rdr(7).ToString(), times))
                table.AddCell(New Phrase(rdr(8).ToString(), times))
                table.AddCell(New Phrase(rdr(9).ToString(), times))
                table.AddCell(New Phrase(rdr(10).ToString(), times))
                table.AddCell(New Phrase(rdr(11).ToString(), times))
                table.AddCell(New Phrase(rdr(12).ToString(), times))
            End While

            pdfDoc.Add(table)

            pdfDoc.Close()

            connection.Close()

            Dim resultMsg As DialogResult = MessageBox.Show("Your Report is created at: " + FileName + ".", "Report Creation", MessageBoxButtons.OK)
            Process.Start(FileName)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnBirthdayReport_Click(sender As Object, e As EventArgs) Handles btnBirthdayReport.Click
        Try
            Dim pdfDoc As New Document()

            Dim connectionString As String
            Dim connection As SqlConnection
            Dim rdr As SqlDataReader
            Dim command As New SqlCommand

            Dim table As PdfPTable = Nothing
            Dim cell As PdfPCell = Nothing
            Dim bFont As BaseFont = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, False)
            Dim times As Font = New Font(bFont, 6, Font.Italic)

            Dim FileName As String = "C:\Users\Public\Documents\COJ\SponseeMonthlyBirthday\" + cbMonthBirthday.Text.ToString() + "_MonthSponseeBirthday_" + DateTime.Now.ToString("yyyyMMdd") + "_" + DateTime.Now.ToString("HHmmss") + ".pdf"
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(FileName, FileMode.Create))

            connectionString = "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@;"
            connection = New SqlConnection(connectionString)

            command.Connection = connection
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "report.spMonthBirthday"
            command.Parameters.AddWithValue("@month", cbMonthBirthday.SelectedValue.ToString())
            connection.Open()

            pdfDoc.Open()

            'pdfDoc.Add(New Paragraph("Report of Sponsee's Birthdays in Month: " + cbMonthBirthday.Text.ToString(), times))


            table = New PdfPTable(11)
            cell = New PdfPCell(New Phrase("Report of Sponsee's Birthdays in Month: " + cbMonthBirthday.Text.ToString()))
            cell.Colspan = 11

            table.AddCell(cell)

            table.AddCell(New Phrase("Sponsee ID", times))
            table.AddCell(New Phrase("First Name", times))
            table.AddCell(New Phrase("Last Name", times))
            table.AddCell(New Phrase("DOB", times))
            table.AddCell(New Phrase("Gender", times))
            table.AddCell(New Phrase("Grade", times))
            table.AddCell(New Phrase("Shoe Size", times))
            table.AddCell(New Phrase("Shirt Size", times))
            table.AddCell(New Phrase("Pants Size", times))
            table.AddCell(New Phrase("Date Join COJ", times))
            table.AddCell(New Phrase("Church ID", times))

            rdr = command.ExecuteReader()

            While rdr.Read()
                table.AddCell(New Phrase(rdr(0).ToString(), times))
                table.AddCell(New Phrase(rdr(1).ToString(), times))
                table.AddCell(New Phrase(rdr(2).ToString(), times))
                table.AddCell(New Phrase(rdr(3).ToString(), times))
                table.AddCell(New Phrase(rdr(4).ToString(), times))
                table.AddCell(New Phrase(rdr(5).ToString(), times))
                table.AddCell(New Phrase(rdr(6).ToString(), times))
                table.AddCell(New Phrase(rdr(7).ToString(), times))
                table.AddCell(New Phrase(rdr(8).ToString(), times))
                table.AddCell(New Phrase(rdr(9).ToString(), times))
                table.AddCell(New Phrase(rdr(10).ToString(), times))
            End While

            pdfDoc.Add(table)

            pdfDoc.Close()

            connection.Close()

            Dim resultMsg As DialogResult = MessageBox.Show("Your Report is created at: " + FileName + ".", "Report Creation", MessageBoxButtons.OK)
            Process.Start(FileName)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub btnMonthlyReceipt_Click(sender As Object, e As EventArgs) Handles btnMonthlyReceipt.Click
        Try
            Dim pdfDoc As New Document()

            Dim connectionString As String
            Dim connection As SqlConnection
            Dim rdr As SqlDataReader
            Dim command As New SqlCommand
            Dim rdr2 As SqlDataReader
            Dim command2 As New SqlCommand
            Dim rdr3 As SqlDataReader
            Dim command3 As New SqlCommand
            Dim rdr4 As SqlDataReader
            Dim command4 As New SqlCommand

            Dim rdr8 As SqlDataReader
            Dim command8 As New SqlCommand

            connectionString = "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@;"
            connection = New SqlConnection(connectionString)

            Dim table As PdfPTable = Nothing
            Dim table5 As PdfPTable = Nothing
            Dim cell As PdfPCell = Nothing
            Dim fontpath As String = "C:\Users\Public\Documents\COJ\Fonts\arial.ttf"
            Dim fontpathKorean As String = "C:\Users\Public\Documents\COJ\Fonts\HDOTUM.TTF"
            Dim bFont As BaseFont = BaseFont.CreateFont(fontpath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED)
            Dim bFontKorean As BaseFont = BaseFont.CreateFont(fontpathKorean, BaseFont.IDENTITY_H, BaseFont.EMBEDDED)
            Dim times As Font = New Font(bFont, FontSize)
            Dim timesKorean As Font = New Font(bFontKorean, medFontSize)
            Dim medtimes As Font = New Font(bFont, medFontSize)
            Dim smalltimes As Font = New Font(bFont, smallFontSize)
            Dim boldtimes As Font = New Font(bFont, FontSize, Font.Bold)
            Dim FileName As String = "C:\Users\Public\Documents\COJ\Receipts\" + cbRelationshipMonthlyReceipt.Text.ToString() + "_" + dtpYearMonthlyReceipt.Value.ToString("yyyyMMdd") + "_" + DateTime.Now.ToString("yyyyMMdd") + "_" + DateTime.Now.ToString("HHmmss") + ".pdf"
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(FileName, FileMode.Create))
            pdfDoc.Open()
            Dim contentByte As PdfContentByte = pdfWrite.DirectContent

            contentByte.BeginText()
            contentByte.SetFontAndSize(bFont, FontSize)
            contentByte.SetTextMatrix(leftBorder, 800)
            contentByte.SetLineWidth(FontBoldWeight)
            contentByte.SetTextRenderingMode(PdfContentByte.TEXT_RENDER_MODE_FILL_STROKE)
            contentByte.ShowText("CONTRIBUTION RECEIPT:")
            contentByte.SetTextRenderingMode(PdfContentByte.TEXT_RENDER_MODE_FILL)
            contentByte.EndText()

            contentByte.BeginText()
            contentByte.SetFontAndSize(bFont, FontSize)
            contentByte.SetTextMatrix(180, 800)
            contentByte.ShowText("Keep for Tax Purposes")
            contentByte.EndText()

            contentByte.BeginText()
            contentByte.SetFontAndSize(bFont, FontSize)
            contentByte.SetTextMatrix(332, 790)
            contentByte.ShowText("HanHee Kim")
            contentByte.EndText()

            contentByte.BeginText()
            contentByte.SetFontAndSize(bFont, FontSize)
            contentByte.SetTextMatrix(332, 780)
            contentByte.SetLineWidth(FontBoldWeight)
            contentByte.SetTextRenderingMode(PdfContentByte.TEXT_RENDER_MODE_FILL_STROKE)
            contentByte.ShowText("WORLD MISSION CENTER")
            contentByte.SetTextRenderingMode(PdfContentByte.TEXT_RENDER_MODE_FILL)
            contentByte.EndText()

            contentByte.BeginText()
            contentByte.SetFontAndSize(bFont, FontSize)
            contentByte.SetLineWidth(FontBoldWeight)
            contentByte.SetTextRenderingMode(PdfContentByte.TEXT_RENDER_MODE_FILL_STROKE)
            contentByte.SetTextMatrix(332, 760)
            contentByte.ShowText("Receipt Date:                  " + Date.Now.ToString("d"))
            contentByte.SetTextRenderingMode(PdfContentByte.TEXT_RENDER_MODE_FILL)
            contentByte.EndText()


            Dim table7 As PdfPTable = New PdfPTable(1)
            table7.TotalWidth = 200.0F
            table7.DefaultCell.Border = Rectangle.NO_BORDER


            command.Connection = connection
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "report.spMonthlyReceiptSponsorInfo"
            command.Parameters.AddWithValue("@SponsorID", cbRelationshipMonthlyReceipt.Text.ToString())
            connection.Open()

            rdr = command.ExecuteReader()

            While rdr.Read()

                table7.AddCell(New Phrase(rdr(0).ToString() + " " + rdr(1).ToString(), times))
                table7.AddCell(New Phrase(rdr(4).ToString(), times))
                table7.AddCell(New Phrase(rdr(5).ToString() + "," + rdr(6).ToString(), times))
                table7.AddCell(New Phrase(" ", times))
            End While

            table7.WriteSelectedRows(0, -1, leftBorder, 790, contentByte)

            connection.Close()

            contentByte.BeginText()
            contentByte.SetFontAndSize(bFont, medFontSize)
            contentByte.SetTextMatrix(leftBorder, 730)
            contentByte.ShowText("Sponsor #:                         " + cbRelationshipMonthlyReceipt.Text.ToString())
            contentByte.EndText()

            contentByte.BeginText()
            contentByte.SetFontAndSize(bFont, medFontSize)
            contentByte.SetTextMatrix(leftBorder, 710)
            contentByte.ShowText("Sponsored Child ID #:")
            contentByte.EndText()


            command2.Connection = connection
            command2.CommandType = CommandType.StoredProcedure
            command2.CommandText = "report.spMonthlyReceiptSponseeList"
            command2.Parameters.AddWithValue("@SponsorID", cbRelationshipMonthlyReceipt.Text.ToString())
            connection.Open()
            rdr2 = command2.ExecuteReader()

            Dim table6 As PdfPTable = New PdfPTable(3)
            table6.TotalWidth = 200.0F
            Dim widths1(3) As Integer
            widths1 = {30.0F, 20.0F, 20.0F}
            table6.SetWidths(widths1)
            table6.DefaultCell.Border = Rectangle.NO_BORDER

            table5 = New PdfPTable(3)
            table5.TotalWidth = 200.0F
            Dim widths5(3) As Integer
            widths5 = {30.0F, 20.0F, 20.0F}
            table5.SetWidths(widths5)
            table5.DefaultCell.Border = Rectangle.NO_BORDER

            Dim counter As Integer = 0

            While rdr2.Read()
                If counter < 5 Then
                    table6.AddCell(New Phrase(rdr2(1).ToString(), medtimes))
                    table6.AddCell(New Phrase(rdr2(2).ToString(), medtimes))
                    table6.AddCell(New Phrase(rdr2(3).ToString(), medtimes))
                Else
                    table5.AddCell(New Phrase(rdr2(1).ToString(), medtimes))
                    table5.AddCell(New Phrase(rdr2(2).ToString(), medtimes))
                    table5.AddCell(New Phrase(rdr2(3).ToString(), medtimes))
                End If
                counter = counter + 1
            End While

            table6.WriteSelectedRows(0, -1, leftBorder, 710, contentByte)

            connection.Close()

            Dim table2 As PdfPTable = Nothing
            contentByte.BeginText()
            contentByte.SetFontAndSize(bFont, 9)
            contentByte.SetTextMatrix(332, 740)
            contentByte.SetLineWidth(FontBoldWeight)
            contentByte.SetTextRenderingMode(PdfContentByte.TEXT_RENDER_MODE_FILL_STROKE)
            contentByte.ShowText("Contributions for:")
            contentByte.SetTextRenderingMode(PdfContentByte.TEXT_RENDER_MODE_FILL)
            contentByte.EndText()


            Dim yearlyTotal As String = Nothing
            command8.Connection = connection
            command8.CommandType = CommandType.StoredProcedure
            command8.CommandText = "report.spMonthlyReceiptYearlyContributionTotal"
            command8.Parameters.AddWithValue("@SponsorID", cbRelationshipMonthlyReceipt.Text.ToString())
            command8.Parameters.AddWithValue("@year", dtpYearMonthlyReceipt.Text.ToString())
            connection.Open()

            rdr8 = command8.ExecuteReader()


            If rdr8.Read() Then
                yearlyTotal = Convert.ToDecimal(rdr8(0)).ToString("C")
            End If

            connection.Close()


            table2 = New PdfPTable(2)
            table2.TotalWidth = 200.0F
            Dim widths2(2) As Integer
            widths2 = {30.0F, 20.0F}
            table2.SetWidths(widths2)
            table2.AddCell(New Phrase("HHK World Mission", medtimes))
            table2.AddCell(New Phrase("$                -    ", medtimes))
            table2.AddCell(New Phrase("Children of Jesus", medtimes))
            table2.AddCell(New Phrase("$                -    ", medtimes))
            table2.AddCell(New Phrase("Last Month Total:", medtimes))
            table2.AddCell(New Phrase("$                -    ", medtimes))
            table2.AddCell(New Phrase(dtpYearMonthlyReceipt.Text.ToString() + " Total Contribution", medtimes))
            table2.AddCell(New Phrase(yearlyTotal, medtimes))
            table2.WriteSelectedRows(0, -1, 330, 730, contentByte)



            pdfDoc.Add(New Paragraph(vbCrLf, times))

            Dim p As Phrase = New Phrase("Contributions for which tax-deductible receipts are issued are fully under control of HanheeKim World Mission Center and may be reported for income tax purposes as a contribution to the mission.", smalltimes)
            Dim ct As New ColumnText(contentByte)
            ct.SetSimpleColumn(p, 150, 640, 430, 200, 10, Element.ALIGN_LEFT)
            ct.Go()

            contentByte.BeginText()
            contentByte.SetFontAndSize(bFont, 12)
            contentByte.SetTextMatrix(40, 617)
            contentByte.ShowText("_____________________________________________________________________________")
            contentByte.EndText()


            pdfDoc.Add(New Paragraph(vbCrLf, times))


            command4.Connection = connection
            command4.CommandType = CommandType.StoredProcedure
            command4.CommandText = "report.spMonthlyReceiptSponsorLetter"
            command4.Parameters.AddWithValue("@SponsorID", cbRelationshipMonthlyReceipt.Text.ToString())
            connection.Open()

            rdr4 = command4.ExecuteReader()

            Dim p1 As Phrase = Nothing
            Dim pl As String = Nothing
            While rdr4.Read()
                pl = rdr4(0).ToString
                If pl = "Korean" Then
                    p1 = New Phrase(rdr4(1).ToString(), timesKorean)
                Else
                    p1 = New Phrase(rdr4(1).ToString(), medtimes)
                End If
            End While


            Dim ct1 As New ColumnText(contentByte)
            ct1.SetSimpleColumn(p1, leftBorder, 590, 285, 200, 10, Element.ALIGN_LEFT)
            ct1.Go()


            connection.Close()



            command3.Connection = connection
            command3.CommandType = CommandType.StoredProcedure
            command3.CommandText = "report.spMonthlyReceiptSponsorContributions"
            command3.Parameters.AddWithValue("@SponsorID", cbRelationshipMonthlyReceipt.Text.ToString())
            command3.Parameters.AddWithValue("@year", dtpYearMonthlyReceipt.Text.ToString())
            connection.Open()
            rdr3 = command3.ExecuteReader()

            contentByte.BeginText()
            contentByte.SetFontAndSize(bFont, 9)
            contentByte.SetTextMatrix(330, 580)
            contentByte.SetLineWidth(FontBoldWeight)
            contentByte.SetTextRenderingMode(PdfContentByte.TEXT_RENDER_MODE_FILL_STROKE)
            contentByte.ShowText("Your Monthly Contribution amount")
            contentByte.SetTextRenderingMode(PdfContentByte.TEXT_RENDER_MODE_FILL)
            contentByte.EndText()

            ''No idea how to underline in contentByte; this still works. 
            contentByte.BeginText()
            contentByte.SetFontAndSize(bFont, 12)
            contentByte.SetTextMatrix(330, 580)
            contentByte.ShowText("_____________________")
            contentByte.EndText()
            table = New PdfPTable(3)
            table.TotalWidth = 200.0F
            table.LockedWidth = True

            cell = New PdfPCell(New Phrase("Month", times))
            cell.HorizontalAlignment = Element.ALIGN_CENTER
            cell.Colspan = 1

            table.AddCell(cell)

            cell = New PdfPCell(New Phrase("COJ", times))
            cell.HorizontalAlignment = Element.ALIGN_CENTER
            cell.Colspan = 1

            table.AddCell(cell)

            cell = New PdfPCell(New Phrase("HHK", times))
            cell.HorizontalAlignment = Element.ALIGN_CENTER
            cell.Colspan = 1

            table.AddCell(cell)

            While rdr3.Read()
                cell = New PdfPCell(New Phrase(rdr3(0).ToString(), medtimes))
                cell.HorizontalAlignment = Element.ALIGN_CENTER
                table.AddCell(cell)
                cell = New PdfPCell(New Phrase(Convert.ToDecimal(rdr3(1)).ToString("C"), medtimes))
                cell.HorizontalAlignment = Element.ALIGN_RIGHT
                table.AddCell(cell)
                cell = New PdfPCell(New Phrase(Convert.ToDecimal(rdr3(2)).ToString("C"), medtimes))
                cell.HorizontalAlignment = Element.ALIGN_RIGHT
                table.AddCell(cell)
            End While
            connection.Close()

            cell = New PdfPCell(New Phrase("Total", medtimes))
            cell.HorizontalAlignment = Element.ALIGN_CENTER
            table.AddCell(cell)
            cell = New PdfPCell(New Phrase("", medtimes))
            table.AddCell(cell)
            cell = New PdfPCell(New Phrase(yearlyTotal, medtimes))
            cell.HorizontalAlignment = Element.ALIGN_RIGHT
            table.AddCell(cell)


            table.WriteSelectedRows(0, -1, 330, 560, contentByte)


            Dim p2 As Phrase = New Phrase("All of your general missions offerings are included in the HHK Column. Thank you for your financial support!", medtimes)
            contentByte.SetColorFill(BaseColor.BLUE)
            Dim ct2 As New ColumnText(contentByte)

            ct2.SetSimpleColumn(p2, 335, 390, 510, 340, 10, Element.ALIGN_LEFT)
            ct2.Go()


            contentByte.SetColorFill(BaseColor.BLACK)
            contentByte.BeginText()
            contentByte.SetFontAndSize(bFont, 24)
            contentByte.SetTextMatrix(30, 280)
            contentByte.ShowText("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||")
            contentByte.EndText()
            contentByte.BeginText()
            contentByte.SetFontAndSize(bFont, 8)
            contentByte.SetTextMatrix(leftBorder, 260)
            contentByte.SetColorFill(BaseColor.RED)
            contentByte.ShowText("Please enclose this postion when you send your next gift of love. Thank You!")
            contentByte.SetColorFill(BaseColor.BLACK)
            contentByte.EndText()

            Dim colorRGB(3) As Integer

            Dim bottomReceiptColor As BaseColor

            If pl = "Korean" Then
                bottomReceiptColor = New BaseColor(255, 255, 180)
            ElseIf pl = "English" Then
                bottomReceiptColor = New BaseColor(240, 255, 255)
            Else
                bottomReceiptColor = New BaseColor(255, 228, 225)
            End If


            contentByte.SaveState()

            contentByte.SetColorFill(bottomReceiptColor)
            contentByte.SetColorStroke(bottomReceiptColor)
            contentByte.Rectangle(32, 100, 525, 155)
            contentByte.FillStroke()
            contentByte.RestoreState()

            contentByte.SaveState()
            contentByte.SetColorFill(BaseColor.LIGHT_GRAY)
            contentByte.SetColorStroke(BaseColor.LIGHT_GRAY)
            contentByte.Rectangle(32, 75, 525, 25)
            contentByte.FillStroke()
            contentByte.RestoreState()

            contentByte.SaveState()
            contentByte.SetColorFill(BaseColor.GRAY)
            contentByte.SetColorStroke(BaseColor.GRAY)
            contentByte.Rectangle(32, 70, 525, 5)
            contentByte.FillStroke()
            contentByte.RestoreState()

            contentByte.BeginText()
            contentByte.SetFontAndSize(bFont, 8)
            contentByte.SetTextMatrix(400, 240)
            contentByte.ShowText("Date:            /             / " + dtpYearMonthlyReceipt.Text.ToString())
            contentByte.EndText()



            table7.WriteSelectedRows(0, -1, leftBorder, 250, contentByte)

            contentByte.BeginText()
            contentByte.SetFontAndSize(bFont, medFontSize)
            contentByte.SetTextMatrix(leftBorder, 190)
            contentByte.ShowText("Sponsor #:                         " + cbRelationshipMonthlyReceipt.Text.ToString())
            contentByte.EndText()

            table6.WriteSelectedRows(0, -1, leftBorder, 180, contentByte)


            Dim table1 As PdfPTable = Nothing
            contentByte.BeginText()
            contentByte.SetFontAndSize(bFont, 9)
            contentByte.SetTextMatrix(332, 212)
            contentByte.SetLineWidth(FontBoldWeight)
            contentByte.SetTextRenderingMode(PdfContentByte.TEXT_RENDER_MODE_FILL_STROKE)
            contentByte.ShowText("Contributions for:")
            contentByte.SetTextRenderingMode(PdfContentByte.TEXT_RENDER_MODE_FILL)
            contentByte.EndText()

            table1 = New PdfPTable(2)
            table1.TotalWidth = 200.0F
            Dim widths(2) As Integer
            widths = {30.0F, 20.0F}
            table1.SetWidths(widths)
            table1.AddCell(New Phrase("Childern of Jesus ($25/child)", medtimes))
            table1.AddCell(New Phrase("$                -    ", medtimes))
            table1.AddCell(New Phrase("Extra Gift", medtimes))
            table1.AddCell(New Phrase("$                -    ", medtimes))
            table1.AddCell(New Phrase("HHK World Mission", medtimes))
            table1.AddCell(New Phrase("$                -    ", medtimes))
            table1.AddCell(New Phrase("Total Enclosed", medtimes))
            table1.AddCell(New Phrase("$                -    ", medtimes))
            table1.WriteSelectedRows(0, -1, 330, 210, contentByte)




            contentByte.BeginText()
            contentByte.SetFontAndSize(bFont, 8)
            contentByte.SetTextMatrix(200, footerHeight + 10)
            contentByte.ShowText("THANK YOU FOR YOUR SUPPORT. GOD BLESS YOU.")
            contentByte.EndText()
            contentByte.BeginText()
            contentByte.SetFontAndSize(bFont, smallFontSize)
            contentByte.SetTextMatrix(50, footerHeight)
            contentByte.ShowText("HHK World Mission Center")
            contentByte.EndText()
            contentByte.BeginText()
            contentByte.SetFontAndSize(bFont, smallFontSize)
            contentByte.SetTextMatrix(175, footerHeight)
            contentByte.ShowText("P. O. Box 24015")
            contentByte.EndText()
            contentByte.BeginText()
            contentByte.SetFontAndSize(bFont, smallFontSize)
            contentByte.SetTextMatrix(275, footerHeight)
            contentByte.ShowText("Denver, CO. 80224-0015")
            contentByte.EndText()
            contentByte.BeginText()
            contentByte.SetFontAndSize(bFont, smallFontSize)
            contentByte.SetTextMatrix(375, footerHeight)
            contentByte.ShowText("www.coj.org")
            contentByte.EndText()
            contentByte.BeginText()
            contentByte.SetFontAndSize(bFont, smallFontSize)
            contentByte.SetTextMatrix(475, footerHeight)
            contentByte.ShowText("303.757.0777")
            contentByte.EndText()


            If counter >= 5 Then
                pdfDoc.NewPage()

                contentByte.BeginText()
                contentByte.SetFontAndSize(bFont, FontSize)
                contentByte.SetTextMatrix(leftBorder, 790)
                contentByte.ShowText("HanHee Kim")
                contentByte.EndText()

                contentByte.BeginText()
                contentByte.SetFontAndSize(bFont, FontSize)
                contentByte.SetTextMatrix(leftBorder, 780)
                contentByte.SetLineWidth(FontBoldWeight)
                contentByte.SetTextRenderingMode(PdfContentByte.TEXT_RENDER_MODE_FILL_STROKE)
                contentByte.ShowText("WORLD MISSION CENTER")
                contentByte.SetTextRenderingMode(PdfContentByte.TEXT_RENDER_MODE_FILL)
                contentByte.EndText()

                table7.WriteSelectedRows(0, -1, 339, 800, contentByte)


                contentByte.BeginText()
                contentByte.SetFontAndSize(bFont, 12)
                contentByte.SetTextMatrix(40, 750)
                contentByte.ShowText("_____________________________________________________________________________")
                contentByte.EndText()


                contentByte.BeginText()
                contentByte.SetFontAndSize(bFont, 9)
                contentByte.SetTextMatrix(leftBorder, 730)
                contentByte.SetLineWidth(FontBoldWeight)
                contentByte.SetTextRenderingMode(PdfContentByte.TEXT_RENDER_MODE_FILL_STROKE)
                contentByte.ShowText("Receipt (continued page 2)")
                contentByte.SetTextRenderingMode(PdfContentByte.TEXT_RENDER_MODE_FILL)
                contentByte.EndText()


                contentByte.BeginText()
                contentByte.SetFontAndSize(bFont, 9)
                contentByte.SetTextMatrix(leftBorder, 710)
                contentByte.ShowText("Sponsorship List:")
                contentByte.EndText()

                contentByte.BeginText()
                contentByte.SetFontAndSize(bFont, 9)
                contentByte.SetTextMatrix(leftBorder, 700)
                contentByte.SetLineWidth(FontBoldWeight)
                contentByte.SetTextRenderingMode(PdfContentByte.TEXT_RENDER_MODE_FILL_STROKE)
                contentByte.ShowText("Sponsored Child ID #	                 Child's Name")
                contentByte.SetTextRenderingMode(PdfContentByte.TEXT_RENDER_MODE_FILL)
                contentByte.EndText()


                table5.WriteSelectedRows(0, -1, leftBorder, 690, contentByte)
            End If

            pdfDoc.Close()




            Dim resultMsg As DialogResult = MessageBox.Show("Your Report is created at: " + FileName + ".", "Report Creation", MessageBoxButtons.OK)
            Process.Start(FileName)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub btnAddPrimaryLanguage_Click(sender As Object, e As EventArgs) Handles btnAddPrimaryLanguage.Click
        Try
            Dim AddLanguageReceiptText As New AddLanguageReceiptText
            AddLanguageReceiptText.ShowDialog()
            Me.PrimaryLanguageTableAdapter.Fill(HHKATDataSet.PrimaryLanguage)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnGenerateProfile_Click(sender As Object, e As EventArgs) Handles btnGenerateProfile.Click
        Try
            Dim pdfDoc As New Document(PageSize.A4.Rotate())

            Dim connectionString As String
            Dim connection As SqlConnection
            Dim rdr As SqlDataReader
            Dim command As New SqlCommand

            connectionString = "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@;"
            connection = New SqlConnection(connectionString)

            Dim FileName As String = "C:\Users\Public\Documents\COJ\Profiles\" + cbSponseeProfile.Text.ToString() + "_" + DateTime.Now.ToString("yyyyMMdd") + "_" + DateTime.Now.ToString("HHmmss") + ".pdf"
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
            command.Parameters.AddWithValue("@SponseeID", cbSponseeProfile.Text.ToString())
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

                Dim gif As Image = Image.GetInstance(rdr(6).ToString())
                gif.ScaleToFit(250.0F, 250.0F)
                gif.SetAbsolutePosition(115, 245)
                contentByte.AddImage(gif)

            End While

            connection.Close()

            pdfDoc.Close()

            Dim resultMsg As DialogResult = MessageBox.Show("Your Report is created at: " + FileName + ".", "Report Creation", MessageBoxButtons.OK)
            Process.Start(FileName)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
