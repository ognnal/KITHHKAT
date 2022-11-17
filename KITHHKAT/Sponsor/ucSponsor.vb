Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class ucSponsor
    Private editsponsorinfo As EditSponsorInfo
    Private loading As Loading
    Private sponsorid As String
    Private firstname As String
    Private lastname As String
    Private alternatename As String
    Private email As String
    Private address As String
    Private city As String
    Private state As String
    Private phonenumber As String
    Private primarylanguage1 As String

    Private languagereceipttext As String
    Private FontSize As Integer = 10
    Private medFontSize As Integer = 8
    Private smallFontSize As Integer = 6
    Private FontBoldWeight As Single = 0.5
    Private footerHeight As Integer = 50
    Private leftBorder As Integer = 55

    Private Sub btnNewSponsee_Click(sender As Object, e As EventArgs) Handles btnNewSponsee.Click
        AddSponsorInfo.ShowDialog()

        Dim dbadp6 As New SqlDataAdapter("spGetSponsorCount", "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@")
        dbadp6.SelectCommand.CommandType = CommandType.StoredProcedure
        Dim dt6 As New DataTable
        dbadp6.Fill(dt6)
        tbSponsorCount.Text = dt6.Rows(0).Item(0).ToString()
        dbadp6.Dispose()


        Me.SponsorInfoTableAdapter.Fill(HHKATDataSet.SponsorInfo)
    End Sub

    Private Sub ucSponsor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dtpYearMonthlyReceipt.CustomFormat = "yyyy"
            dgvucSponsor.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(155, 215, 213)
            dgvucSponsor.RowsDefaultCellStyle.SelectionForeColor = Color.Black

            Me.SponsorInfoTableAdapter.Fill(Me.HHKATDataSet.SponsorInfo)
            Me.StateRefTableAdapter.Fill(Me.HHKATDataSet.StateRef)
            Me.PrimaryLanguageTableAdapter.Fill(Me.HHKATDataSet.PrimaryLanguage)

            Dim dbadp6 As New SqlDataAdapter("spGetSponsorCount", "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@")
            dbadp6.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim dt6 As New DataTable
            dbadp6.Fill(dt6)
            tbSponsorCount.Text = dt6.Rows(0).Item(0).ToString()
            dbadp6.Dispose()

            cbState.SelectedIndex = -1
            cbPrimaryLanguage.SelectedIndex = -1
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
            command.CommandText = "spSearchSponsor"
            command.Parameters.AddWithValue("@SponsorID", tbSponsorID.Text.ToString())
            command.Parameters.AddWithValue("@FirstName", tbFirstName.Text.ToString())
            command.Parameters.AddWithValue("@LastName", tbLastName.Text.ToString())
            command.Parameters.AddWithValue("@City", tbCity.Text.ToString())
            command.Parameters.AddWithValue("@State", cbState.Text.ToString())
            command.Parameters.AddWithValue("@PrimaryLanguage", cbPrimaryLanguage.Text.ToString())
            adapter = New SqlDataAdapter(command)
            adapter.Fill(dt)
            adapter.Dispose()
            dgvucSponsor.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvucSponsor_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvucSponsor.CellMouseDoubleClick
        Try
            editsponsorinfo = New EditSponsorInfo

            sponsorid = dgvucSponsor.Rows(dgvucSponsor.CurrentCell.RowIndex).Cells(0).Value.ToString
            firstname = dgvucSponsor.Rows(dgvucSponsor.CurrentCell.RowIndex).Cells(1).Value.ToString
            lastname = dgvucSponsor.Rows(dgvucSponsor.CurrentCell.RowIndex).Cells(2).Value.ToString
            alternatename = dgvucSponsor.Rows(dgvucSponsor.CurrentCell.RowIndex).Cells(3).Value.ToString
            email = dgvucSponsor.Rows(dgvucSponsor.CurrentCell.RowIndex).Cells(4).Value.ToString
            address = dgvucSponsor.Rows(dgvucSponsor.CurrentCell.RowIndex).Cells(5).Value.ToString
            city = dgvucSponsor.Rows(dgvucSponsor.CurrentCell.RowIndex).Cells(6).Value.ToString
            state = dgvucSponsor.Rows(dgvucSponsor.CurrentCell.RowIndex).Cells(7).Value.ToString
            phonenumber = dgvucSponsor.Rows(dgvucSponsor.CurrentCell.RowIndex).Cells(8).Value.ToString
            primarylanguage1 = dgvucSponsor.Rows(dgvucSponsor.CurrentCell.RowIndex).Cells(9).Value.ToString



            editsponsorinfo.Thesponsorid() = Me.sponsorid
            editsponsorinfo.Thefirstname() = Me.firstname
            editsponsorinfo.Thelastname() = Me.lastname
            editsponsorinfo.Thealternatename() = Me.alternatename
            editsponsorinfo.Theemail() = Me.email
            editsponsorinfo.Theaddress() = Me.address
            editsponsorinfo.Thecity() = Me.city
            editsponsorinfo.Thestate() = Me.state
            editsponsorinfo.Thephonenumber() = Me.phonenumber
            editsponsorinfo.Theprimarylanguage() = Me.primarylanguage1


            editsponsorinfo.ShowDialog(Me)

            Dim dbadp6 As New SqlDataAdapter("spGetSponsorCount", "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@")
            dbadp6.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim dt6 As New DataTable
            dbadp6.Fill(dt6)
            tbSponsorCount.Text = dt6.Rows(0).Item(0).ToString()
            dbadp6.Dispose()


            'Me.SponsorInfoTableAdapter.Fill(Me.HHKATDataSet.SponsorInfo)

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
                command.Parameters.AddWithValue("@SponsorID", tbSponsorID.Text.ToString())
                command.Parameters.AddWithValue("@FirstName", tbFirstName.Text.ToString())
                command.Parameters.AddWithValue("@LastName", tbLastName.Text.ToString())
                command.Parameters.AddWithValue("@City", tbCity.Text.ToString())
                command.Parameters.AddWithValue("@State", cbState.Text.ToString())
                command.Parameters.AddWithValue("@PrimaryLanguage", cbPrimaryLanguage.Text.ToString())
                adapter = New SqlDataAdapter(command)
                adapter.Fill(dt)
                adapter.Dispose()
                dgvucSponsor.DataSource = dt
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub MonthlyRepceipt(cbRelationshipMonthlyReceipt As String, YearMonthlyReceiptValue As String)
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
            Dim FileName As String = "C:\Users\Public\Documents\COJ\Receipts\" + cbRelationshipMonthlyReceipt + "_" + YearMonthlyReceiptValue.ToString() + "_" + DateTime.Now.ToString("yyyyMMdd") + "_" + DateTime.Now.ToString("HHmmss") + ".pdf"
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
            command.Parameters.AddWithValue("@SponsorID", cbRelationshipMonthlyReceipt)
            connection.Open()

            rdr = command.ExecuteReader()

            While rdr.Read()

                table7.AddCell(New Phrase(rdr(0).ToString() + " " + rdr(1).ToString(), times))
                table7.AddCell(New Phrase(rdr(4).ToString(), times))
                table7.AddCell(New Phrase(rdr(5).ToString() + ", " + rdr(6).ToString(), times))
                table7.AddCell(New Phrase(" ", times))
            End While

            table7.WriteSelectedRows(0, -1, leftBorder, 790, contentByte)

            connection.Close()

            contentByte.BeginText()
            contentByte.SetFontAndSize(bFont, medFontSize)
            contentByte.SetTextMatrix(leftBorder, 730)
            contentByte.ShowText("Sponsor #:                         " + cbRelationshipMonthlyReceipt)
            contentByte.EndText()

            contentByte.BeginText()
            contentByte.SetFontAndSize(bFont, medFontSize)
            contentByte.SetTextMatrix(leftBorder, 710)
            contentByte.ShowText("Sponsored Child ID #:")
            contentByte.EndText()


            command2.Connection = connection
            command2.CommandType = CommandType.StoredProcedure
            command2.CommandText = "report.spMonthlyReceiptSponseeList"
            command2.Parameters.AddWithValue("@SponsorID", cbRelationshipMonthlyReceipt)
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
            command8.Parameters.AddWithValue("@SponsorID", cbRelationshipMonthlyReceipt)
            command8.Parameters.AddWithValue("@year", YearMonthlyReceiptValue.ToString())
            connection.Open()

            rdr8 = command8.ExecuteReader()


            If rdr8.Read() Then
                Try
                    yearlyTotal = Convert.ToDecimal(rdr8(0)).ToString("C")
                Catch
                End Try
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
            table2.AddCell(New Phrase(YearMonthlyReceiptValue.ToString() + " Total Contribution", medtimes))
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
            command4.Parameters.AddWithValue("@SponsorID", cbRelationshipMonthlyReceipt)
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
            command3.Parameters.AddWithValue("@SponsorID", cbRelationshipMonthlyReceipt)
            command3.Parameters.AddWithValue("@year", YearMonthlyReceiptValue.ToString())
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
            contentByte.SetTextMatrix(30, 270)
            contentByte.ShowText("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||")
            contentByte.EndText()
            contentByte.BeginText()
            contentByte.SetFontAndSize(bFont, 8)
            contentByte.SetTextMatrix(leftBorder, 250)
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
            contentByte.Rectangle(32, 70, 525, 175)
            contentByte.FillStroke()
            contentByte.RestoreState()

            contentByte.SaveState()
            contentByte.SetColorFill(BaseColor.LIGHT_GRAY)
            contentByte.SetColorStroke(BaseColor.LIGHT_GRAY)
            contentByte.Rectangle(32, 45, 525, 25)
            contentByte.FillStroke()
            contentByte.RestoreState()

            contentByte.SaveState()
            contentByte.SetColorFill(BaseColor.GRAY)
            contentByte.SetColorStroke(BaseColor.GRAY)
            contentByte.Rectangle(32, 40, 525, 5)
            contentByte.FillStroke()
            contentByte.RestoreState()

            contentByte.BeginText()
            contentByte.SetFontAndSize(bFont, 8)
            contentByte.SetTextMatrix(400, 210)
            contentByte.ShowText("Date:            /             / " + YearMonthlyReceiptValue.ToString())
            contentByte.EndText()



            table7.WriteSelectedRows(0, -1, leftBorder, 220, contentByte)

            contentByte.BeginText()
            contentByte.SetFontAndSize(bFont, medFontSize)
            contentByte.SetTextMatrix(leftBorder, 160)
            contentByte.ShowText("Sponsor #:                         " + cbRelationshipMonthlyReceipt)
            contentByte.EndText()

            table6.WriteSelectedRows(0, -1, leftBorder, 150, contentByte)


            Dim table1 As PdfPTable = Nothing
            contentByte.BeginText()
            contentByte.SetFontAndSize(bFont, 9)
            contentByte.SetTextMatrix(332, 182)
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
            table1.WriteSelectedRows(0, -1, 330, 180, contentByte)




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




            'Dim resultMsg As DialogResult = MessageBox.Show("Your Report is created at: " + FileName + ".", "Report Creation", MessageBoxButtons.OK)
            'Process.Start(FileName)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub lnkGenerateReceipt_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkGenerateReceipt.LinkClicked
        BackgroundWorker = New System.ComponentModel.BackgroundWorker
        BackgroundWorker.RunWorkerAsync()
        loading = New Loading
        loading.ShowDialog()


    End Sub


    Private Sub BackgroundWorker_DoWork(ByVal sender As Object, _
           ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker.DoWork

        For Each row As DataGridViewRow In dgvucSponsor.Rows

            sponsorid = row.Cells(0).Value.ToString
            'MessageBox.Show(sponsorid.ToString(), "Report Creation", MessageBoxButtons.OK)
            MonthlyRepceipt(sponsorid, dtpYearMonthlyReceipt.Value.Year.ToString())

        Next
        Dim resultMsg As DialogResult = MessageBox.Show("Your Report is created at: " + "C:\Users\Public\Documents\COJ\Receipts\", "Report Creation", MessageBoxButtons.OK)
        Process.Start("C:\Users\Public\Documents\COJ\Receipts\")
    End Sub

    Private Sub BackgroundWorker_RunWorkerCompleted(ByVal sender As Object, _
            ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) _
            Handles BackgroundWorker.RunWorkerCompleted
        loading.Close()
    End Sub

End Class
