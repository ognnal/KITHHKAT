<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMatch
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbSponsee = New System.Windows.Forms.GroupBox()
        Me.tbChurchSearch = New System.Windows.Forms.TextBox()
        Me.btnChurchSearch = New System.Windows.Forms.Button()
        Me.lblNumNonSpon = New System.Windows.Forms.Label()
        Me.dgvSponsee = New System.Windows.Forms.DataGridView()
        Me.ChurchIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SponseeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SponseeInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HHKATDataSet = New KITHHKAT.HHKATDataSet()
        Me.gbSponsor = New System.Windows.Forms.GroupBox()
        Me.tbNameSearch = New System.Windows.Forms.TextBox()
        Me.btnNameSearch = New System.Windows.Forms.Button()
        Me.dgvSponsor = New System.Windows.Forms.DataGridView()
        Me.SponsorIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlternateNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SponsorInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnMatch = New System.Windows.Forms.Button()
        Me.lblUnsponsored = New System.Windows.Forms.Label()
        Me.tbUnsponsoredCount = New System.Windows.Forms.TextBox()
        Me.SponseeInfoTableAdapter = New KITHHKAT.HHKATDataSetTableAdapters.SponseeInfoTableAdapter()
        Me.SponsorInfoTableAdapter = New KITHHKAT.HHKATDataSetTableAdapters.SponsorInfoTableAdapter()
        Me.gbSponsee.SuspendLayout()
        CType(Me.dgvSponsee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SponseeInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HHKATDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSponsor.SuspendLayout()
        CType(Me.dgvSponsor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SponsorInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbSponsee
        '
        Me.gbSponsee.Controls.Add(Me.tbChurchSearch)
        Me.gbSponsee.Controls.Add(Me.btnChurchSearch)
        Me.gbSponsee.Controls.Add(Me.lblNumNonSpon)
        Me.gbSponsee.Controls.Add(Me.dgvSponsee)
        Me.gbSponsee.Location = New System.Drawing.Point(15, 24)
        Me.gbSponsee.Name = "gbSponsee"
        Me.gbSponsee.Size = New System.Drawing.Size(515, 488)
        Me.gbSponsee.TabIndex = 32
        Me.gbSponsee.TabStop = False
        Me.gbSponsee.Text = "Sponsee"
        '
        'tbChurchSearch
        '
        Me.tbChurchSearch.Location = New System.Drawing.Point(309, 14)
        Me.tbChurchSearch.Name = "tbChurchSearch"
        Me.tbChurchSearch.Size = New System.Drawing.Size(100, 20)
        Me.tbChurchSearch.TabIndex = 89
        Me.tbChurchSearch.Text = " Church Name"
        '
        'btnChurchSearch
        '
        Me.btnChurchSearch.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnChurchSearch.Location = New System.Drawing.Point(415, 14)
        Me.btnChurchSearch.Name = "btnChurchSearch"
        Me.btnChurchSearch.Size = New System.Drawing.Size(91, 20)
        Me.btnChurchSearch.TabIndex = 88
        Me.btnChurchSearch.Text = "Church Search"
        Me.btnChurchSearch.UseVisualStyleBackColor = True
        '
        'lblNumNonSpon
        '
        Me.lblNumNonSpon.AutoSize = True
        Me.lblNumNonSpon.Location = New System.Drawing.Point(149, 448)
        Me.lblNumNonSpon.Name = "lblNumNonSpon"
        Me.lblNumNonSpon.Size = New System.Drawing.Size(0, 13)
        Me.lblNumNonSpon.TabIndex = 14
        '
        'dgvSponsee
        '
        Me.dgvSponsee.AllowUserToAddRows = False
        Me.dgvSponsee.AllowUserToDeleteRows = False
        Me.dgvSponsee.AllowUserToOrderColumns = True
        Me.dgvSponsee.AllowUserToResizeColumns = False
        Me.dgvSponsee.AllowUserToResizeRows = False
        Me.dgvSponsee.AutoGenerateColumns = False
        Me.dgvSponsee.BackgroundColor = System.Drawing.SystemColors.GrayText
        Me.dgvSponsee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSponsee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ChurchIDDataGridViewTextBoxColumn, Me.SponseeIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn})
        Me.dgvSponsee.DataSource = Me.SponseeInfoBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSponsee.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSponsee.Location = New System.Drawing.Point(6, 40)
        Me.dgvSponsee.MultiSelect = False
        Me.dgvSponsee.Name = "dgvSponsee"
        Me.dgvSponsee.ReadOnly = True
        Me.dgvSponsee.RowHeadersVisible = False
        Me.dgvSponsee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSponsee.Size = New System.Drawing.Size(500, 442)
        Me.dgvSponsee.TabIndex = 12
        '
        'ChurchIDDataGridViewTextBoxColumn
        '
        Me.ChurchIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ChurchIDDataGridViewTextBoxColumn.DataPropertyName = "ChurchID"
        Me.ChurchIDDataGridViewTextBoxColumn.HeaderText = "ChurchID"
        Me.ChurchIDDataGridViewTextBoxColumn.Name = "ChurchIDDataGridViewTextBoxColumn"
        Me.ChurchIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SponseeIDDataGridViewTextBoxColumn
        '
        Me.SponseeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SponseeIDDataGridViewTextBoxColumn.DataPropertyName = "SponseeID"
        Me.SponseeIDDataGridViewTextBoxColumn.HeaderText = "SponseeID"
        Me.SponseeIDDataGridViewTextBoxColumn.Name = "SponseeIDDataGridViewTextBoxColumn"
        Me.SponseeIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        Me.DOBDataGridViewTextBoxColumn.ReadOnly = True
        Me.DOBDataGridViewTextBoxColumn.Visible = False
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SponseeInfoBindingSource
        '
        Me.SponseeInfoBindingSource.DataMember = "SponseeInfo"
        Me.SponseeInfoBindingSource.DataSource = Me.HHKATDataSet
        '
        'HHKATDataSet
        '
        Me.HHKATDataSet.DataSetName = "HHKATDataSet"
        Me.HHKATDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gbSponsor
        '
        Me.gbSponsor.Controls.Add(Me.tbNameSearch)
        Me.gbSponsor.Controls.Add(Me.btnNameSearch)
        Me.gbSponsor.Controls.Add(Me.dgvSponsor)
        Me.gbSponsor.Location = New System.Drawing.Point(527, 24)
        Me.gbSponsor.Name = "gbSponsor"
        Me.gbSponsor.Size = New System.Drawing.Size(515, 488)
        Me.gbSponsor.TabIndex = 33
        Me.gbSponsor.TabStop = False
        Me.gbSponsor.Text = "Sponsor"
        '
        'tbNameSearch
        '
        Me.tbNameSearch.Location = New System.Drawing.Point(309, 14)
        Me.tbNameSearch.Name = "tbNameSearch"
        Me.tbNameSearch.Size = New System.Drawing.Size(100, 20)
        Me.tbNameSearch.TabIndex = 87
        Me.tbNameSearch.Text = " First Name"
        '
        'btnNameSearch
        '
        Me.btnNameSearch.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnNameSearch.Location = New System.Drawing.Point(415, 13)
        Me.btnNameSearch.Name = "btnNameSearch"
        Me.btnNameSearch.Size = New System.Drawing.Size(94, 20)
        Me.btnNameSearch.TabIndex = 86
        Me.btnNameSearch.Text = "Name Search"
        Me.btnNameSearch.UseVisualStyleBackColor = True
        '
        'dgvSponsor
        '
        Me.dgvSponsor.AllowUserToAddRows = False
        Me.dgvSponsor.AllowUserToDeleteRows = False
        Me.dgvSponsor.AllowUserToOrderColumns = True
        Me.dgvSponsor.AllowUserToResizeColumns = False
        Me.dgvSponsor.AllowUserToResizeRows = False
        Me.dgvSponsor.AutoGenerateColumns = False
        Me.dgvSponsor.BackgroundColor = System.Drawing.SystemColors.GrayText
        Me.dgvSponsor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSponsor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SponsorIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn1, Me.LastNameDataGridViewTextBoxColumn1, Me.AlternateNameDataGridViewTextBoxColumn, Me.PhoneNumDataGridViewTextBoxColumn})
        Me.dgvSponsor.DataSource = Me.SponsorInfoBindingSource
        Me.dgvSponsor.Location = New System.Drawing.Point(9, 40)
        Me.dgvSponsor.MultiSelect = False
        Me.dgvSponsor.Name = "dgvSponsor"
        Me.dgvSponsor.ReadOnly = True
        Me.dgvSponsor.RowHeadersVisible = False
        Me.dgvSponsor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSponsor.Size = New System.Drawing.Size(500, 442)
        Me.dgvSponsor.TabIndex = 14
        '
        'SponsorIDDataGridViewTextBoxColumn
        '
        Me.SponsorIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SponsorIDDataGridViewTextBoxColumn.DataPropertyName = "SponsorID"
        Me.SponsorIDDataGridViewTextBoxColumn.HeaderText = "SponsorID"
        Me.SponsorIDDataGridViewTextBoxColumn.Name = "SponsorIDDataGridViewTextBoxColumn"
        Me.SponsorIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn1
        '
        Me.FirstNameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FirstNameDataGridViewTextBoxColumn1.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn1.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn1.Name = "FirstNameDataGridViewTextBoxColumn1"
        Me.FirstNameDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn1
        '
        Me.LastNameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LastNameDataGridViewTextBoxColumn1.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn1.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn1.Name = "LastNameDataGridViewTextBoxColumn1"
        Me.LastNameDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'AlternateNameDataGridViewTextBoxColumn
        '
        Me.AlternateNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AlternateNameDataGridViewTextBoxColumn.DataPropertyName = "AlternateName"
        Me.AlternateNameDataGridViewTextBoxColumn.HeaderText = "AlternateName"
        Me.AlternateNameDataGridViewTextBoxColumn.Name = "AlternateNameDataGridViewTextBoxColumn"
        Me.AlternateNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PhoneNumDataGridViewTextBoxColumn
        '
        Me.PhoneNumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PhoneNumDataGridViewTextBoxColumn.DataPropertyName = "PhoneNum"
        Me.PhoneNumDataGridViewTextBoxColumn.HeaderText = "PhoneNum"
        Me.PhoneNumDataGridViewTextBoxColumn.Name = "PhoneNumDataGridViewTextBoxColumn"
        Me.PhoneNumDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SponsorInfoBindingSource
        '
        Me.SponsorInfoBindingSource.DataMember = "SponsorInfo"
        Me.SponsorInfoBindingSource.DataSource = Me.HHKATDataSet
        '
        'btnMatch
        '
        Me.btnMatch.BackColor = System.Drawing.Color.Silver
        Me.btnMatch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMatch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMatch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMatch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMatch.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMatch.Location = New System.Drawing.Point(495, 518)
        Me.btnMatch.Name = "btnMatch"
        Me.btnMatch.Size = New System.Drawing.Size(68, 23)
        Me.btnMatch.TabIndex = 34
        Me.btnMatch.Text = "Match"
        Me.btnMatch.UseVisualStyleBackColor = False
        '
        'lblUnsponsored
        '
        Me.lblUnsponsored.AutoSize = True
        Me.lblUnsponsored.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblUnsponsored.Location = New System.Drawing.Point(10, 525)
        Me.lblUnsponsored.Name = "lblUnsponsored"
        Me.lblUnsponsored.Size = New System.Drawing.Size(83, 14)
        Me.lblUnsponsored.TabIndex = 35
        Me.lblUnsponsored.Text = "Unsponsored: "
        '
        'tbUnsponsoredCount
        '
        Me.tbUnsponsoredCount.Location = New System.Drawing.Point(88, 522)
        Me.tbUnsponsoredCount.Name = "tbUnsponsoredCount"
        Me.tbUnsponsoredCount.ReadOnly = True
        Me.tbUnsponsoredCount.Size = New System.Drawing.Size(100, 20)
        Me.tbUnsponsoredCount.TabIndex = 36
        '
        'SponseeInfoTableAdapter
        '
        Me.SponseeInfoTableAdapter.ClearBeforeFill = True
        '
        'SponsorInfoTableAdapter
        '
        Me.SponsorInfoTableAdapter.ClearBeforeFill = True
        '
        'ucMatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.tbUnsponsoredCount)
        Me.Controls.Add(Me.lblUnsponsored)
        Me.Controls.Add(Me.gbSponsee)
        Me.Controls.Add(Me.gbSponsor)
        Me.Controls.Add(Me.btnMatch)
        Me.Name = "ucMatch"
        Me.Size = New System.Drawing.Size(1049, 579)
        Me.gbSponsee.ResumeLayout(False)
        Me.gbSponsee.PerformLayout()
        CType(Me.dgvSponsee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SponseeInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HHKATDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSponsor.ResumeLayout(False)
        Me.gbSponsor.PerformLayout()
        CType(Me.dgvSponsor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SponsorInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbSponsee As System.Windows.Forms.GroupBox
    Friend WithEvents lblNumNonSpon As System.Windows.Forms.Label
    Friend WithEvents dgvSponsee As System.Windows.Forms.DataGridView
    Friend WithEvents gbSponsor As System.Windows.Forms.GroupBox
    Friend WithEvents dgvSponsor As System.Windows.Forms.DataGridView
    Friend WithEvents btnMatch As System.Windows.Forms.Button
    Friend WithEvents SponseeInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HHKATDataSet As KITHHKAT.HHKATDataSet
    Friend WithEvents SponsorInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SponseeInfoTableAdapter As KITHHKAT.HHKATDataSetTableAdapters.SponseeInfoTableAdapter
    Friend WithEvents SponsorInfoTableAdapter As KITHHKAT.HHKATDataSetTableAdapters.SponsorInfoTableAdapter
    Friend WithEvents SponsorIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlternateNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChurchIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SponseeIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblUnsponsored As System.Windows.Forms.Label
    Friend WithEvents tbUnsponsoredCount As System.Windows.Forms.TextBox
    Friend WithEvents tbNameSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnNameSearch As System.Windows.Forms.Button
    Friend WithEvents tbChurchSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnChurchSearch As System.Windows.Forms.Button

End Class
