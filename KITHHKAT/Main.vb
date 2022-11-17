Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports Microsoft.SqlServer.Server

Public Class frmMain
    Public uschurch As New ucChurch
    Public usmatch As New ucMatch
    Public ucsponsee As New ucSponsee
    Public ucsponsor As New ucSponsor
    Public ucrelationship As New ucRelationship
    Public ucreport As New ucReports



    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the 'HHKATDataSet.SponsorInfo' table. You can move, or remove it, as needed.
        'Me.SponsorInfoTableAdapter.Fill(Me.HHKATDataSet.SponsorInfo)
        ''TODO: This line of code loads data into the 'HHKATDataSet.SponseeInfo' table. You can move, or remove it, as needed.
        'Me.SponseeInfoTableAdapter.Fill(Me.HHKATDataSet.SponseeInfo)

        userName.Text = "User: " + Environment.UserDomainName.ToString() + "\" + Environment.UserName.ToString()
        Me.Controls.Add(usmatch)

        Me.Controls.Add(uschurch)
        Me.Controls.Add(ucsponsee)
        Me.Controls.Add(ucsponsor)
        Me.Controls.Add(ucrelationship)
        Me.Controls.Add(ucreport)

        Me.Controls.Remove(uschurch)
        Me.Controls.Remove(ucsponsee)
        Me.Controls.Remove(ucsponsor)
        Me.Controls.Remove(ucrelationship)
        Me.Controls.Remove(ucreport)
      
        HOMEToolStripMenuItem.BackColor = Color.FromArgb(155, 215, 213)

    End Sub

    Private Sub HOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click
        Me.Controls.Add(usmatch)
        Me.Controls.Remove(uschurch)
        Me.Controls.Remove(ucsponsee)
        Me.Controls.Remove(ucsponsor)
        Me.Controls.Remove(ucrelationship)
        Me.Controls.Remove(ucreport)



        HOMEToolStripMenuItem.BackColor = Color.FromArgb(155, 215, 213)
        CHURCHToolStripMenuItem.BackColor = Color.WhiteSmoke
        SPONSEEToolStripMenuItem.BackColor = Color.WhiteSmoke
        SPONSORToolStripMenuItem.BackColor = Color.WhiteSmoke
        RELATIONSHIPSToolStripMenuItem.BackColor = Color.WhiteSmoke
        REPORTSToolStripMenuItem.BackColor = Color.WhiteSmoke

        Dim dbadp1 As New SqlDataAdapter("spGetUnmatchedSponsees", "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@")
        dbadp1.SelectCommand.CommandType = CommandType.StoredProcedure
        Dim dt1 As New DataTable
        dbadp1.Fill(dt1)
        dbadp1.Dispose()
        usmatch.dgvSponsee.DataSource = dt1


        usmatch.SponsorInfoTableAdapter.Fill(usmatch.HHKATDataSet.SponsorInfo)

    End Sub

    Private Sub CHURCHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CHURCHToolStripMenuItem.Click
        Me.Controls.Add(uschurch)
        Me.Controls.Remove(usmatch)
        Me.Controls.Remove(ucsponsee)
        Me.Controls.Remove(ucsponsor)
        Me.Controls.Remove(ucrelationship)
        Me.Controls.Remove(ucreport)


        HOMEToolStripMenuItem.BackColor = Color.WhiteSmoke
        CHURCHToolStripMenuItem.BackColor = Color.FromArgb(155, 215, 213)
        SPONSEEToolStripMenuItem.BackColor = Color.WhiteSmoke
        SPONSORToolStripMenuItem.BackColor = Color.WhiteSmoke
        RELATIONSHIPSToolStripMenuItem.BackColor = Color.WhiteSmoke
        REPORTSToolStripMenuItem.BackColor = Color.WhiteSmoke


    End Sub

    Private Sub SPONSEEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SPONSEEToolStripMenuItem.Click
        Me.Controls.Add(ucsponsee)
        Me.Controls.Remove(usmatch)
        Me.Controls.Remove(uschurch)
        Me.Controls.Remove(ucsponsor)
        Me.Controls.Remove(ucrelationship)
        Me.Controls.Remove(ucreport)


        HOMEToolStripMenuItem.BackColor = Color.WhiteSmoke
        CHURCHToolStripMenuItem.BackColor = Color.WhiteSmoke
        SPONSEEToolStripMenuItem.BackColor = Color.FromArgb(155, 215, 213)
        SPONSORToolStripMenuItem.BackColor = Color.WhiteSmoke
        RELATIONSHIPSToolStripMenuItem.BackColor = Color.WhiteSmoke
        REPORTSToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub SPONSORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SPONSORToolStripMenuItem.Click
        Me.Controls.Add(ucsponsor)
        Me.Controls.Remove(usmatch)
        Me.Controls.Remove(uschurch)
        Me.Controls.Remove(ucsponsee)
        Me.Controls.Remove(ucrelationship)
        Me.Controls.Remove(ucreport)


        HOMEToolStripMenuItem.BackColor = Color.WhiteSmoke
        CHURCHToolStripMenuItem.BackColor = Color.WhiteSmoke
        SPONSEEToolStripMenuItem.BackColor = Color.WhiteSmoke
        SPONSORToolStripMenuItem.BackColor = Color.FromArgb(155, 215, 213)
        RELATIONSHIPSToolStripMenuItem.BackColor = Color.WhiteSmoke
        REPORTSToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub RELATIONSHIPSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RELATIONSHIPSToolStripMenuItem.Click
        Me.Controls.Add(ucrelationship)
        Me.Controls.Remove(uschurch)
        Me.Controls.Remove(ucsponsee)
        Me.Controls.Remove(ucsponsor)
        Me.Controls.Remove(usmatch)
        Me.Controls.Remove(ucreport)


        HOMEToolStripMenuItem.BackColor = Color.WhiteSmoke
        CHURCHToolStripMenuItem.BackColor = Color.WhiteSmoke
        SPONSEEToolStripMenuItem.BackColor = Color.WhiteSmoke
        SPONSORToolStripMenuItem.BackColor = Color.WhiteSmoke
        RELATIONSHIPSToolStripMenuItem.BackColor = Color.FromArgb(155, 215, 213)
        REPORTSToolStripMenuItem.BackColor = Color.WhiteSmoke


        Dim dbadp2 As New SqlDataAdapter("spSearchRelationship", "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@")
        dbadp2.SelectCommand.CommandType = CommandType.StoredProcedure
        Dim dt2 As New DataTable
        dbadp2.Fill(dt2)
        dbadp2.Dispose()
        ucrelationship.dgvRelationship.DataSource = dt2
        ucrelationship.dgvRelationship.Columns(1).Width = 130
        ucrelationship.dgvRelationship.Columns(2).Width = 170
        ucrelationship.dgvRelationship.Columns(3).Width = 170
        ucrelationship.dgvRelationship.Columns(4).Width = 110
        ucrelationship.dgvRelationship.Columns(5).Width = 150
        ucrelationship.dgvRelationship.Columns(6).Width = 150
        ucrelationship.dgvRelationship.Columns(7).Width = 154
        ucrelationship.dgvRelationship.Columns(8).Width = 50

        Dim dbadp3 As New SqlDataAdapter("spGetRelationshipCount", "Data Source=NN-PC;Initial Catalog=HHKAT;User ID=@@@@@@@;Password=@@@@@@@")
        dbadp3.SelectCommand.CommandType = CommandType.StoredProcedure
        Dim dt3 As New DataTable
        dbadp3.Fill(dt3)
        ucrelationship.tbRelationshipCount.Text = dt3.Rows(0).Item(0).ToString()
        dbadp3.Dispose()

    End Sub

    Private Sub REPORTSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REPORTSToolStripMenuItem.Click
        Me.Controls.Add(ucreport)
        Me.Controls.Remove(uschurch)
        Me.Controls.Remove(ucsponsee)
        Me.Controls.Remove(ucsponsor)
        Me.Controls.Remove(ucrelationship)
        Me.Controls.Remove(usmatch)


        HOMEToolStripMenuItem.BackColor = Color.WhiteSmoke
        CHURCHToolStripMenuItem.BackColor = Color.WhiteSmoke
        SPONSEEToolStripMenuItem.BackColor = Color.WhiteSmoke
        SPONSORToolStripMenuItem.BackColor = Color.WhiteSmoke
        RELATIONSHIPSToolStripMenuItem.BackColor = Color.WhiteSmoke
        REPORTSToolStripMenuItem.BackColor = Color.FromArgb(155, 215, 213)
    End Sub
End Class
