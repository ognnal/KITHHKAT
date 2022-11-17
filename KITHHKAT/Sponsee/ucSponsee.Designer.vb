<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSponsee
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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnNewSponsee = New System.Windows.Forms.Button()
        Me.dgvucSponsee = New System.Windows.Forms.DataGridView()
        Me.ChurchIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SponseeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShoeSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShirtSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PantsSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateJoinCOJDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhotoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SponseeInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HHKATDataSet = New KITHHKAT.HHKATDataSet()
        Me.cbChurchName = New System.Windows.Forms.ComboBox()
        Me.ChurchInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtpJoinCOJ = New System.Windows.Forms.DateTimePicker()
        Me.tbLastName = New System.Windows.Forms.TextBox()
        Me.tbFirstName = New System.Windows.Forms.TextBox()
        Me.tbSponseeID = New System.Windows.Forms.TextBox()
        Me.lblChurchName = New System.Windows.Forms.Label()
        Me.lblSponseeCOJDate = New System.Windows.Forms.Label()
        Me.lblSponseeLN = New System.Windows.Forms.Label()
        Me.lblSponseeFN = New System.Windows.Forms.Label()
        Me.lblSponseeID = New System.Windows.Forms.Label()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.cbGrade = New System.Windows.Forms.ComboBox()
        Me.GradeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblSponseeGrade = New System.Windows.Forms.Label()
        Me.GradeTableAdapter = New KITHHKAT.HHKATDataSetTableAdapters.GradeTableAdapter()
        Me.ChurchInfoTableAdapter = New KITHHKAT.HHKATDataSetTableAdapters.ChurchInfoTableAdapter()
        Me.SponseeInfoTableAdapter = New KITHHKAT.HHKATDataSetTableAdapters.SponseeInfoTableAdapter()
        Me.tbSponseeCount = New System.Windows.Forms.TextBox()
        Me.lblSponseeCount = New System.Windows.Forms.Label()
        Me.lnkGenerateProfiles = New System.Windows.Forms.LinkLabel()
        Me.BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        CType(Me.dgvucSponsee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SponseeInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HHKATDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChurchInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.Location = New System.Drawing.Point(936, 34)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 20)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnNewSponsee
        '
        Me.btnNewSponsee.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnNewSponsee.Location = New System.Drawing.Point(936, 57)
        Me.btnNewSponsee.Name = "btnNewSponsee"
        Me.btnNewSponsee.Size = New System.Drawing.Size(100, 20)
        Me.btnNewSponsee.TabIndex = 3
        Me.btnNewSponsee.Text = "Add New"
        Me.btnNewSponsee.UseVisualStyleBackColor = True
        '
        'dgvucSponsee
        '
        Me.dgvucSponsee.AllowUserToAddRows = False
        Me.dgvucSponsee.AllowUserToDeleteRows = False
        Me.dgvucSponsee.AllowUserToOrderColumns = True
        Me.dgvucSponsee.AllowUserToResizeColumns = False
        Me.dgvucSponsee.AllowUserToResizeRows = False
        Me.dgvucSponsee.AutoGenerateColumns = False
        Me.dgvucSponsee.BackgroundColor = System.Drawing.SystemColors.GrayText
        Me.dgvucSponsee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvucSponsee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ChurchIDDataGridViewTextBoxColumn, Me.SponseeIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.GradeDataGridViewTextBoxColumn, Me.ShoeSizeDataGridViewTextBoxColumn, Me.ShirtSizeDataGridViewTextBoxColumn, Me.PantsSizeDataGridViewTextBoxColumn, Me.DateJoinCOJDataGridViewTextBoxColumn, Me.PhotoDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1})
        Me.dgvucSponsee.DataSource = Me.SponseeInfoBindingSource
        Me.dgvucSponsee.Location = New System.Drawing.Point(13, 87)
        Me.dgvucSponsee.Name = "dgvucSponsee"
        Me.dgvucSponsee.ReadOnly = True
        Me.dgvucSponsee.RowHeadersVisible = False
        Me.dgvucSponsee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvucSponsee.Size = New System.Drawing.Size(1032, 428)
        Me.dgvucSponsee.TabIndex = 4
        '
        'ChurchIDDataGridViewTextBoxColumn
        '
        Me.ChurchIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ChurchIDDataGridViewTextBoxColumn.DataPropertyName = "ChurchID"
        Me.ChurchIDDataGridViewTextBoxColumn.HeaderText = "ChurchID"
        Me.ChurchIDDataGridViewTextBoxColumn.Name = "ChurchIDDataGridViewTextBoxColumn"
        Me.ChurchIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ChurchIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'SponseeIDDataGridViewTextBoxColumn
        '
        Me.SponseeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SponseeIDDataGridViewTextBoxColumn.DataPropertyName = "SponseeID"
        Me.SponseeIDDataGridViewTextBoxColumn.HeaderText = "SponseeID"
        Me.SponseeIDDataGridViewTextBoxColumn.Name = "SponseeIDDataGridViewTextBoxColumn"
        Me.SponseeIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.SponseeIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FirstNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.LastNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "Birth Date"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        Me.DOBDataGridViewTextBoxColumn.ReadOnly = True
        Me.DOBDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.ReadOnly = True
        Me.GenderDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'GradeDataGridViewTextBoxColumn
        '
        Me.GradeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GradeDataGridViewTextBoxColumn.DataPropertyName = "Grade"
        Me.GradeDataGridViewTextBoxColumn.HeaderText = "Grade"
        Me.GradeDataGridViewTextBoxColumn.Name = "GradeDataGridViewTextBoxColumn"
        Me.GradeDataGridViewTextBoxColumn.ReadOnly = True
        Me.GradeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ShoeSizeDataGridViewTextBoxColumn
        '
        Me.ShoeSizeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ShoeSizeDataGridViewTextBoxColumn.DataPropertyName = "ShoeSize"
        Me.ShoeSizeDataGridViewTextBoxColumn.HeaderText = "Shoes"
        Me.ShoeSizeDataGridViewTextBoxColumn.Name = "ShoeSizeDataGridViewTextBoxColumn"
        Me.ShoeSizeDataGridViewTextBoxColumn.ReadOnly = True
        Me.ShoeSizeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ShirtSizeDataGridViewTextBoxColumn
        '
        Me.ShirtSizeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ShirtSizeDataGridViewTextBoxColumn.DataPropertyName = "ShirtSize"
        Me.ShirtSizeDataGridViewTextBoxColumn.HeaderText = "Shirt"
        Me.ShirtSizeDataGridViewTextBoxColumn.Name = "ShirtSizeDataGridViewTextBoxColumn"
        Me.ShirtSizeDataGridViewTextBoxColumn.ReadOnly = True
        Me.ShirtSizeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'PantsSizeDataGridViewTextBoxColumn
        '
        Me.PantsSizeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PantsSizeDataGridViewTextBoxColumn.DataPropertyName = "PantsSize"
        Me.PantsSizeDataGridViewTextBoxColumn.HeaderText = "Pants"
        Me.PantsSizeDataGridViewTextBoxColumn.Name = "PantsSizeDataGridViewTextBoxColumn"
        Me.PantsSizeDataGridViewTextBoxColumn.ReadOnly = True
        Me.PantsSizeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DateJoinCOJDataGridViewTextBoxColumn
        '
        Me.DateJoinCOJDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DateJoinCOJDataGridViewTextBoxColumn.DataPropertyName = "DateJoinCOJ"
        Me.DateJoinCOJDataGridViewTextBoxColumn.HeaderText = "Joined COJ"
        Me.DateJoinCOJDataGridViewTextBoxColumn.Name = "DateJoinCOJDataGridViewTextBoxColumn"
        Me.DateJoinCOJDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateJoinCOJDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'PhotoDataGridViewTextBoxColumn
        '
        Me.PhotoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PhotoDataGridViewTextBoxColumn.DataPropertyName = "Photo"
        Me.PhotoDataGridViewTextBoxColumn.HeaderText = "Photo"
        Me.PhotoDataGridViewTextBoxColumn.Name = "PhotoDataGridViewTextBoxColumn"
        Me.PhotoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PhotoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PhotoDataGridViewTextBoxColumn.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "AppPath"
        Me.DataGridViewTextBoxColumn1.HeaderText = "AppPath"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.Visible = False
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
        'cbChurchName
        '
        Me.cbChurchName.DataSource = Me.ChurchInfoBindingSource
        Me.cbChurchName.DisplayMember = "ChurchID"
        Me.cbChurchName.FormattingEnabled = True
        Me.cbChurchName.Location = New System.Drawing.Point(110, 34)
        Me.cbChurchName.Name = "cbChurchName"
        Me.cbChurchName.Size = New System.Drawing.Size(121, 21)
        Me.cbChurchName.TabIndex = 71
        Me.cbChurchName.ValueMember = "ChurchID"
        '
        'ChurchInfoBindingSource
        '
        Me.ChurchInfoBindingSource.DataMember = "ChurchInfo"
        Me.ChurchInfoBindingSource.DataSource = Me.HHKATDataSet
        '
        'dtpJoinCOJ
        '
        Me.dtpJoinCOJ.Location = New System.Drawing.Point(502, 34)
        Me.dtpJoinCOJ.Name = "dtpJoinCOJ"
        Me.dtpJoinCOJ.Size = New System.Drawing.Size(200, 20)
        Me.dtpJoinCOJ.TabIndex = 70
        '
        'tbLastName
        '
        Me.tbLastName.Location = New System.Drawing.Point(325, 61)
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.Size = New System.Drawing.Size(100, 20)
        Me.tbLastName.TabIndex = 63
        '
        'tbFirstName
        '
        Me.tbFirstName.Location = New System.Drawing.Point(110, 61)
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.Size = New System.Drawing.Size(121, 20)
        Me.tbFirstName.TabIndex = 62
        '
        'tbSponseeID
        '
        Me.tbSponseeID.Location = New System.Drawing.Point(326, 34)
        Me.tbSponseeID.Name = "tbSponseeID"
        Me.tbSponseeID.Size = New System.Drawing.Size(100, 20)
        Me.tbSponseeID.TabIndex = 61
        '
        'lblChurchName
        '
        Me.lblChurchName.AutoSize = True
        Me.lblChurchName.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblChurchName.Location = New System.Drawing.Point(10, 37)
        Me.lblChurchName.Name = "lblChurchName"
        Me.lblChurchName.Size = New System.Drawing.Size(81, 14)
        Me.lblChurchName.TabIndex = 60
        Me.lblChurchName.Text = "Church Name:"
        '
        'lblSponseeCOJDate
        '
        Me.lblSponseeCOJDate.AutoSize = True
        Me.lblSponseeCOJDate.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSponseeCOJDate.Location = New System.Drawing.Point(432, 38)
        Me.lblSponseeCOJDate.Name = "lblSponseeCOJDate"
        Me.lblSponseeCOJDate.Size = New System.Drawing.Size(69, 14)
        Me.lblSponseeCOJDate.TabIndex = 59
        Me.lblSponseeCOJDate.Text = "Joined COJ:"
        '
        'lblSponseeLN
        '
        Me.lblSponseeLN.AutoSize = True
        Me.lblSponseeLN.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSponseeLN.Location = New System.Drawing.Point(245, 64)
        Me.lblSponseeLN.Name = "lblSponseeLN"
        Me.lblSponseeLN.Size = New System.Drawing.Size(66, 14)
        Me.lblSponseeLN.TabIndex = 53
        Me.lblSponseeLN.Text = "Last Name:"
        '
        'lblSponseeFN
        '
        Me.lblSponseeFN.AutoSize = True
        Me.lblSponseeFN.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSponseeFN.Location = New System.Drawing.Point(10, 64)
        Me.lblSponseeFN.Name = "lblSponseeFN"
        Me.lblSponseeFN.Size = New System.Drawing.Size(67, 14)
        Me.lblSponseeFN.TabIndex = 52
        Me.lblSponseeFN.Text = "First Name:"
        '
        'lblSponseeID
        '
        Me.lblSponseeID.AutoSize = True
        Me.lblSponseeID.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSponseeID.Location = New System.Drawing.Point(245, 37)
        Me.lblSponseeID.Name = "lblSponseeID"
        Me.lblSponseeID.Size = New System.Drawing.Size(69, 14)
        Me.lblSponseeID.TabIndex = 51
        Me.lblSponseeID.Text = "Sponsee ID:"
        '
        'dtpDOB
        '
        Me.dtpDOB.Location = New System.Drawing.Point(502, 61)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(200, 20)
        Me.dtpDOB.TabIndex = 73
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDOB.Location = New System.Drawing.Point(432, 64)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(64, 14)
        Me.lblDOB.TabIndex = 72
        Me.lblDOB.Text = "Birth Date:"
        '
        'cbGrade
        '
        Me.cbGrade.DataSource = Me.GradeBindingSource
        Me.cbGrade.DisplayMember = "Grade"
        Me.cbGrade.FormattingEnabled = True
        Me.cbGrade.Location = New System.Drawing.Point(789, 34)
        Me.cbGrade.Name = "cbGrade"
        Me.cbGrade.Size = New System.Drawing.Size(100, 21)
        Me.cbGrade.TabIndex = 75
        Me.cbGrade.ValueMember = "Grade"
        '
        'GradeBindingSource
        '
        Me.GradeBindingSource.DataMember = "Grade"
        Me.GradeBindingSource.DataSource = Me.HHKATDataSet
        '
        'lblSponseeGrade
        '
        Me.lblSponseeGrade.AutoSize = True
        Me.lblSponseeGrade.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSponseeGrade.Location = New System.Drawing.Point(735, 38)
        Me.lblSponseeGrade.Name = "lblSponseeGrade"
        Me.lblSponseeGrade.Size = New System.Drawing.Size(42, 14)
        Me.lblSponseeGrade.TabIndex = 74
        Me.lblSponseeGrade.Text = "Grade:"
        '
        'GradeTableAdapter
        '
        Me.GradeTableAdapter.ClearBeforeFill = True
        '
        'ChurchInfoTableAdapter
        '
        Me.ChurchInfoTableAdapter.ClearBeforeFill = True
        '
        'SponseeInfoTableAdapter
        '
        Me.SponseeInfoTableAdapter.ClearBeforeFill = True
        '
        'tbSponseeCount
        '
        Me.tbSponseeCount.Location = New System.Drawing.Point(88, 522)
        Me.tbSponseeCount.Name = "tbSponseeCount"
        Me.tbSponseeCount.ReadOnly = True
        Me.tbSponseeCount.Size = New System.Drawing.Size(100, 20)
        Me.tbSponseeCount.TabIndex = 105
        '
        'lblSponseeCount
        '
        Me.lblSponseeCount.AutoSize = True
        Me.lblSponseeCount.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSponseeCount.Location = New System.Drawing.Point(10, 525)
        Me.lblSponseeCount.Name = "lblSponseeCount"
        Me.lblSponseeCount.Size = New System.Drawing.Size(61, 14)
        Me.lblSponseeCount.TabIndex = 104
        Me.lblSponseeCount.Text = "Sponsees:"
        '
        'lnkGenerateProfiles
        '
        Me.lnkGenerateProfiles.AutoSize = True
        Me.lnkGenerateProfiles.Location = New System.Drawing.Point(948, 521)
        Me.lnkGenerateProfiles.Name = "lnkGenerateProfiles"
        Me.lnkGenerateProfiles.Size = New System.Drawing.Size(88, 13)
        Me.lnkGenerateProfiles.TabIndex = 106
        Me.lnkGenerateProfiles.TabStop = True
        Me.lnkGenerateProfiles.Text = "Generate Profiles"
        Me.lnkGenerateProfiles.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'BackgroundWorker
        '
        '
        'ucSponsee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.lnkGenerateProfiles)
        Me.Controls.Add(Me.tbSponseeCount)
        Me.Controls.Add(Me.lblSponseeCount)
        Me.Controls.Add(Me.cbGrade)
        Me.Controls.Add(Me.lblSponseeGrade)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.cbChurchName)
        Me.Controls.Add(Me.dtpJoinCOJ)
        Me.Controls.Add(Me.tbLastName)
        Me.Controls.Add(Me.tbFirstName)
        Me.Controls.Add(Me.tbSponseeID)
        Me.Controls.Add(Me.lblChurchName)
        Me.Controls.Add(Me.lblSponseeCOJDate)
        Me.Controls.Add(Me.lblSponseeLN)
        Me.Controls.Add(Me.lblSponseeFN)
        Me.Controls.Add(Me.lblSponseeID)
        Me.Controls.Add(Me.dgvucSponsee)
        Me.Controls.Add(Me.btnNewSponsee)
        Me.Controls.Add(Me.btnSearch)
        Me.Name = "ucSponsee"
        Me.Size = New System.Drawing.Size(1045, 579)
        CType(Me.dgvucSponsee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SponseeInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HHKATDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChurchInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnNewSponsee As System.Windows.Forms.Button
    Friend WithEvents dgvucSponsee As System.Windows.Forms.DataGridView
    Friend WithEvents HHKATDataSet As KITHHKAT.HHKATDataSet
    Friend WithEvents cbChurchName As System.Windows.Forms.ComboBox
    Friend WithEvents dtpJoinCOJ As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbLastName As System.Windows.Forms.TextBox
    Friend WithEvents tbFirstName As System.Windows.Forms.TextBox
    Friend WithEvents tbSponseeID As System.Windows.Forms.TextBox
    Friend WithEvents lblChurchName As System.Windows.Forms.Label
    Friend WithEvents lblSponseeCOJDate As System.Windows.Forms.Label
    Friend WithEvents lblSponseeLN As System.Windows.Forms.Label
    Friend WithEvents lblSponseeFN As System.Windows.Forms.Label
    Friend WithEvents lblSponseeID As System.Windows.Forms.Label
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDOB As System.Windows.Forms.Label
    Friend WithEvents cbGrade As System.Windows.Forms.ComboBox
    Friend WithEvents lblSponseeGrade As System.Windows.Forms.Label
    Friend WithEvents GradeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GradeTableAdapter As KITHHKAT.HHKATDataSetTableAdapters.GradeTableAdapter
    Friend WithEvents ChurchInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ChurchInfoTableAdapter As KITHHKAT.HHKATDataSetTableAdapters.ChurchInfoTableAdapter
    Friend WithEvents SponseeInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SponseeInfoTableAdapter As KITHHKAT.HHKATDataSetTableAdapters.SponseeInfoTableAdapter
    Friend WithEvents tbSponseeCount As System.Windows.Forms.TextBox
    Friend WithEvents lblSponseeCount As System.Windows.Forms.Label
    Friend WithEvents lnkGenerateProfiles As System.Windows.Forms.LinkLabel
    Friend WithEvents BackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents ChurchIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SponseeIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GradeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShoeSizeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShirtSizeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PantsSizeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateJoinCOJDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhotoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
