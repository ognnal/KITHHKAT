<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSponsor
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
        Me.tbLastName = New System.Windows.Forms.TextBox()
        Me.tbFirstName = New System.Windows.Forms.TextBox()
        Me.tbSponsorID = New System.Windows.Forms.TextBox()
        Me.lblSponseeLN = New System.Windows.Forms.Label()
        Me.lblSponseeFN = New System.Windows.Forms.Label()
        Me.lblSponsorID = New System.Windows.Forms.Label()
        Me.dgvucSponsor = New System.Windows.Forms.DataGridView()
        Me.SponsorIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlternateNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimaryLanguage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SponsorInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HHKATDataSet = New KITHHKAT.HHKATDataSet()
        Me.btnNewSponsee = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.SponsorInfoTableAdapter = New KITHHKAT.HHKATDataSetTableAdapters.SponsorInfoTableAdapter()
        Me.cbPrimaryLanguage = New System.Windows.Forms.ComboBox()
        Me.PrimaryLanguageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblPrimaryLanaguage = New System.Windows.Forms.Label()
        Me.cbState = New System.Windows.Forms.ComboBox()
        Me.StateRefBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbl_State = New System.Windows.Forms.Label()
        Me.lbl_City = New System.Windows.Forms.Label()
        Me.tbCity = New System.Windows.Forms.TextBox()
        Me.StateRefTableAdapter = New KITHHKAT.HHKATDataSetTableAdapters.StateRefTableAdapter()
        Me.PrimaryLanguageTableAdapter = New KITHHKAT.HHKATDataSetTableAdapters.PrimaryLanguageTableAdapter()
        Me.tbSponsorCount = New System.Windows.Forms.TextBox()
        Me.lblSponsorCount = New System.Windows.Forms.Label()
        Me.lnkGenerateReceipt = New System.Windows.Forms.LinkLabel()
        Me.dtpYearMonthlyReceipt = New System.Windows.Forms.DateTimePicker()
        Me.BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        CType(Me.dgvucSponsor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SponsorInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HHKATDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrimaryLanguageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StateRefBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbLastName
        '
        Me.tbLastName.Location = New System.Drawing.Point(557, 34)
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.Size = New System.Drawing.Size(100, 20)
        Me.tbLastName.TabIndex = 85
        '
        'tbFirstName
        '
        Me.tbFirstName.Location = New System.Drawing.Point(326, 34)
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.Size = New System.Drawing.Size(100, 20)
        Me.tbFirstName.TabIndex = 84
        '
        'tbSponsorID
        '
        Me.tbSponsorID.Location = New System.Drawing.Point(110, 34)
        Me.tbSponsorID.Name = "tbSponsorID"
        Me.tbSponsorID.Size = New System.Drawing.Size(121, 20)
        Me.tbSponsorID.TabIndex = 83
        '
        'lblSponseeLN
        '
        Me.lblSponseeLN.AutoSize = True
        Me.lblSponseeLN.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSponseeLN.Location = New System.Drawing.Point(454, 37)
        Me.lblSponseeLN.Name = "lblSponseeLN"
        Me.lblSponseeLN.Size = New System.Drawing.Size(66, 14)
        Me.lblSponseeLN.TabIndex = 79
        Me.lblSponseeLN.Text = "Last Name:"
        '
        'lblSponseeFN
        '
        Me.lblSponseeFN.AutoSize = True
        Me.lblSponseeFN.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSponseeFN.Location = New System.Drawing.Point(245, 37)
        Me.lblSponseeFN.Name = "lblSponseeFN"
        Me.lblSponseeFN.Size = New System.Drawing.Size(67, 14)
        Me.lblSponseeFN.TabIndex = 78
        Me.lblSponseeFN.Text = "First Name:"
        '
        'lblSponsorID
        '
        Me.lblSponsorID.AutoSize = True
        Me.lblSponsorID.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSponsorID.Location = New System.Drawing.Point(11, 34)
        Me.lblSponsorID.Name = "lblSponsorID"
        Me.lblSponsorID.Size = New System.Drawing.Size(68, 14)
        Me.lblSponsorID.TabIndex = 77
        Me.lblSponsorID.Text = "Sponsor ID:"
        '
        'dgvucSponsor
        '
        Me.dgvucSponsor.AllowUserToAddRows = False
        Me.dgvucSponsor.AllowUserToDeleteRows = False
        Me.dgvucSponsor.AllowUserToOrderColumns = True
        Me.dgvucSponsor.AllowUserToResizeColumns = False
        Me.dgvucSponsor.AllowUserToResizeRows = False
        Me.dgvucSponsor.AutoGenerateColumns = False
        Me.dgvucSponsor.BackgroundColor = System.Drawing.SystemColors.GrayText
        Me.dgvucSponsor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvucSponsor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SponsorIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.AlternateNameDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn, Me.PhoneNumDataGridViewTextBoxColumn, Me.PrimaryLanguage})
        Me.dgvucSponsor.DataSource = Me.SponsorInfoBindingSource
        Me.dgvucSponsor.Location = New System.Drawing.Point(13, 87)
        Me.dgvucSponsor.Name = "dgvucSponsor"
        Me.dgvucSponsor.ReadOnly = True
        Me.dgvucSponsor.RowHeadersVisible = False
        Me.dgvucSponsor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvucSponsor.Size = New System.Drawing.Size(1033, 428)
        Me.dgvucSponsor.TabIndex = 76
        '
        'SponsorIDDataGridViewTextBoxColumn
        '
        Me.SponsorIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SponsorIDDataGridViewTextBoxColumn.DataPropertyName = "SponsorID"
        Me.SponsorIDDataGridViewTextBoxColumn.HeaderText = "SponsorID"
        Me.SponsorIDDataGridViewTextBoxColumn.Name = "SponsorIDDataGridViewTextBoxColumn"
        Me.SponsorIDDataGridViewTextBoxColumn.ReadOnly = True
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
        'AlternateNameDataGridViewTextBoxColumn
        '
        Me.AlternateNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AlternateNameDataGridViewTextBoxColumn.DataPropertyName = "AlternateName"
        Me.AlternateNameDataGridViewTextBoxColumn.HeaderText = "Alternate Name"
        Me.AlternateNameDataGridViewTextBoxColumn.Name = "AlternateNameDataGridViewTextBoxColumn"
        Me.AlternateNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        Me.CityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "State"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "State"
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        Me.StateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PhoneNumDataGridViewTextBoxColumn
        '
        Me.PhoneNumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PhoneNumDataGridViewTextBoxColumn.DataPropertyName = "PhoneNum"
        Me.PhoneNumDataGridViewTextBoxColumn.HeaderText = "Phone Number"
        Me.PhoneNumDataGridViewTextBoxColumn.Name = "PhoneNumDataGridViewTextBoxColumn"
        Me.PhoneNumDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrimaryLanguage
        '
        Me.PrimaryLanguage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PrimaryLanguage.DataPropertyName = "PrimaryLanguage"
        Me.PrimaryLanguage.HeaderText = "Primary Language"
        Me.PrimaryLanguage.Name = "PrimaryLanguage"
        Me.PrimaryLanguage.ReadOnly = True
        '
        'SponsorInfoBindingSource
        '
        Me.SponsorInfoBindingSource.DataMember = "SponsorInfo"
        Me.SponsorInfoBindingSource.DataSource = Me.HHKATDataSet
        '
        'HHKATDataSet
        '
        Me.HHKATDataSet.DataSetName = "HHKATDataSet"
        Me.HHKATDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnNewSponsee
        '
        Me.btnNewSponsee.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnNewSponsee.Location = New System.Drawing.Point(936, 57)
        Me.btnNewSponsee.Name = "btnNewSponsee"
        Me.btnNewSponsee.Size = New System.Drawing.Size(100, 20)
        Me.btnNewSponsee.TabIndex = 75
        Me.btnNewSponsee.Text = "Add New"
        Me.btnNewSponsee.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.Location = New System.Drawing.Point(936, 34)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 20)
        Me.btnSearch.TabIndex = 74
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'SponsorInfoTableAdapter
        '
        Me.SponsorInfoTableAdapter.ClearBeforeFill = True
        '
        'cbPrimaryLanguage
        '
        Me.cbPrimaryLanguage.DataSource = Me.PrimaryLanguageBindingSource
        Me.cbPrimaryLanguage.DisplayMember = "PrimaryLanguage"
        Me.cbPrimaryLanguage.FormattingEnabled = True
        Me.cbPrimaryLanguage.Location = New System.Drawing.Point(789, 34)
        Me.cbPrimaryLanguage.Name = "cbPrimaryLanguage"
        Me.cbPrimaryLanguage.Size = New System.Drawing.Size(100, 21)
        Me.cbPrimaryLanguage.TabIndex = 95
        Me.cbPrimaryLanguage.ValueMember = "PrimaryLanguage"
        '
        'PrimaryLanguageBindingSource
        '
        Me.PrimaryLanguageBindingSource.DataMember = "PrimaryLanguage"
        Me.PrimaryLanguageBindingSource.DataSource = Me.HHKATDataSet
        '
        'lblPrimaryLanaguage
        '
        Me.lblPrimaryLanaguage.AutoSize = True
        Me.lblPrimaryLanaguage.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPrimaryLanaguage.Location = New System.Drawing.Point(676, 37)
        Me.lblPrimaryLanaguage.Name = "lblPrimaryLanaguage"
        Me.lblPrimaryLanaguage.Size = New System.Drawing.Size(105, 14)
        Me.lblPrimaryLanaguage.TabIndex = 94
        Me.lblPrimaryLanaguage.Text = "Primary Language:"
        '
        'cbState
        '
        Me.cbState.DataSource = Me.StateRefBindingSource
        Me.cbState.DisplayMember = "StateRef"
        Me.cbState.FormattingEnabled = True
        Me.cbState.Location = New System.Drawing.Point(110, 61)
        Me.cbState.Name = "cbState"
        Me.cbState.Size = New System.Drawing.Size(121, 21)
        Me.cbState.TabIndex = 91
        Me.cbState.ValueMember = "StateRef"
        '
        'StateRefBindingSource
        '
        Me.StateRefBindingSource.DataMember = "StateRef"
        Me.StateRefBindingSource.DataSource = Me.HHKATDataSet
        '
        'lbl_State
        '
        Me.lbl_State.AutoSize = True
        Me.lbl_State.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_State.Location = New System.Drawing.Point(11, 61)
        Me.lbl_State.Name = "lbl_State"
        Me.lbl_State.Size = New System.Drawing.Size(40, 14)
        Me.lbl_State.TabIndex = 93
        Me.lbl_State.Text = "State:"
        '
        'lbl_City
        '
        Me.lbl_City.AutoSize = True
        Me.lbl_City.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_City.Location = New System.Drawing.Point(245, 64)
        Me.lbl_City.Name = "lbl_City"
        Me.lbl_City.Size = New System.Drawing.Size(32, 14)
        Me.lbl_City.TabIndex = 92
        Me.lbl_City.Text = "City:"
        '
        'tbCity
        '
        Me.tbCity.Location = New System.Drawing.Point(325, 61)
        Me.tbCity.Name = "tbCity"
        Me.tbCity.Size = New System.Drawing.Size(100, 20)
        Me.tbCity.TabIndex = 90
        '
        'StateRefTableAdapter
        '
        Me.StateRefTableAdapter.ClearBeforeFill = True
        '
        'PrimaryLanguageTableAdapter
        '
        Me.PrimaryLanguageTableAdapter.ClearBeforeFill = True
        '
        'tbSponsorCount
        '
        Me.tbSponsorCount.Location = New System.Drawing.Point(88, 522)
        Me.tbSponsorCount.Name = "tbSponsorCount"
        Me.tbSponsorCount.ReadOnly = True
        Me.tbSponsorCount.Size = New System.Drawing.Size(100, 20)
        Me.tbSponsorCount.TabIndex = 105
        '
        'lblSponsorCount
        '
        Me.lblSponsorCount.AutoSize = True
        Me.lblSponsorCount.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSponsorCount.Location = New System.Drawing.Point(11, 524)
        Me.lblSponsorCount.Name = "lblSponsorCount"
        Me.lblSponsorCount.Size = New System.Drawing.Size(60, 14)
        Me.lblSponsorCount.TabIndex = 104
        Me.lblSponsorCount.Text = "Sponsors:"
        '
        'lnkGenerateReceipt
        '
        Me.lnkGenerateReceipt.AutoSize = True
        Me.lnkGenerateReceipt.Location = New System.Drawing.Point(877, 521)
        Me.lnkGenerateReceipt.Name = "lnkGenerateReceipt"
        Me.lnkGenerateReceipt.Size = New System.Drawing.Size(91, 13)
        Me.lnkGenerateReceipt.TabIndex = 106
        Me.lnkGenerateReceipt.TabStop = True
        Me.lnkGenerateReceipt.Text = "Generate Receipt"
        Me.lnkGenerateReceipt.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'dtpYearMonthlyReceipt
        '
        Me.dtpYearMonthlyReceipt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYearMonthlyReceipt.Location = New System.Drawing.Point(974, 518)
        Me.dtpYearMonthlyReceipt.Name = "dtpYearMonthlyReceipt"
        Me.dtpYearMonthlyReceipt.Size = New System.Drawing.Size(72, 20)
        Me.dtpYearMonthlyReceipt.TabIndex = 107
        '
        'BackgroundWorker
        '
        '
        'ucSponsor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.dtpYearMonthlyReceipt)
        Me.Controls.Add(Me.lnkGenerateReceipt)
        Me.Controls.Add(Me.tbSponsorCount)
        Me.Controls.Add(Me.lblSponsorCount)
        Me.Controls.Add(Me.cbPrimaryLanguage)
        Me.Controls.Add(Me.lblPrimaryLanaguage)
        Me.Controls.Add(Me.cbState)
        Me.Controls.Add(Me.lbl_State)
        Me.Controls.Add(Me.lbl_City)
        Me.Controls.Add(Me.tbCity)
        Me.Controls.Add(Me.tbLastName)
        Me.Controls.Add(Me.tbFirstName)
        Me.Controls.Add(Me.tbSponsorID)
        Me.Controls.Add(Me.lblSponseeLN)
        Me.Controls.Add(Me.lblSponseeFN)
        Me.Controls.Add(Me.lblSponsorID)
        Me.Controls.Add(Me.dgvucSponsor)
        Me.Controls.Add(Me.btnNewSponsee)
        Me.Controls.Add(Me.btnSearch)
        Me.Name = "ucSponsor"
        Me.Size = New System.Drawing.Size(1049, 579)
        CType(Me.dgvucSponsor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SponsorInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HHKATDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrimaryLanguageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StateRefBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbLastName As System.Windows.Forms.TextBox
    Friend WithEvents tbFirstName As System.Windows.Forms.TextBox
    Friend WithEvents tbSponsorID As System.Windows.Forms.TextBox
    Friend WithEvents lblSponseeLN As System.Windows.Forms.Label
    Friend WithEvents lblSponseeFN As System.Windows.Forms.Label
    Friend WithEvents lblSponsorID As System.Windows.Forms.Label
    Friend WithEvents dgvucSponsor As System.Windows.Forms.DataGridView
    Friend WithEvents btnNewSponsee As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents SponsorInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HHKATDataSet As KITHHKAT.HHKATDataSet
    Friend WithEvents SponsorInfoTableAdapter As KITHHKAT.HHKATDataSetTableAdapters.SponsorInfoTableAdapter
    Friend WithEvents cbPrimaryLanguage As System.Windows.Forms.ComboBox
    Friend WithEvents lblPrimaryLanaguage As System.Windows.Forms.Label
    Friend WithEvents cbState As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_State As System.Windows.Forms.Label
    Friend WithEvents lbl_City As System.Windows.Forms.Label
    Friend WithEvents tbCity As System.Windows.Forms.TextBox
    Friend WithEvents PrimaryLanguageBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StateRefBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StateRefTableAdapter As KITHHKAT.HHKATDataSetTableAdapters.StateRefTableAdapter
    Friend WithEvents PrimaryLanguageTableAdapter As KITHHKAT.HHKATDataSetTableAdapters.PrimaryLanguageTableAdapter
    Friend WithEvents SponsorIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlternateNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrimaryLanguage As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tbSponsorCount As System.Windows.Forms.TextBox
    Friend WithEvents lblSponsorCount As System.Windows.Forms.Label
    Friend WithEvents lnkGenerateReceipt As System.Windows.Forms.LinkLabel
    Friend WithEvents dtpYearMonthlyReceipt As System.Windows.Forms.DateTimePicker
    Friend WithEvents BackgroundWorker As System.ComponentModel.BackgroundWorker

End Class
