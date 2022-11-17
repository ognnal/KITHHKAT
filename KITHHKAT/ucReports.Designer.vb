<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucReports
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
        Me.btnActivityHistory = New System.Windows.Forms.Button()
        Me.cbActivityReportTypes = New System.Windows.Forms.ComboBox()
        Me.ActivityReportTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HHKATDataSet = New KITHHKAT.HHKATDataSet()
        Me.ActivityReportTypesTableAdapter = New KITHHKAT.HHKATDataSetTableAdapters.ActivityReportTypesTableAdapter()
        Me.cbMonthBirthday = New System.Windows.Forms.ComboBox()
        Me.MonthBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MonthTableAdapter = New KITHHKAT.HHKATDataSetTableAdapters.MonthTableAdapter()
        Me.btnBirthdayReport = New System.Windows.Forms.Button()
        Me.cbRelationshipMonthlyReceipt = New System.Windows.Forms.ComboBox()
        Me.SponsorInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnMonthlyReceipt = New System.Windows.Forms.Button()
        Me.dtpYearMonthlyReceipt = New System.Windows.Forms.DateTimePicker()
        Me.dgvPrimaryLanguage = New System.Windows.Forms.DataGridView()
        Me.PrimaryLanguageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LanguageReceiptTextDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimaryLanguageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrimaryLanguageTableAdapter = New KITHHKAT.HHKATDataSetTableAdapters.PrimaryLanguageTableAdapter()
        Me.SponsorInfoTableAdapter = New KITHHKAT.HHKATDataSetTableAdapters.SponsorInfoTableAdapter()
        Me.gbReportSettings = New System.Windows.Forms.GroupBox()
        Me.btnAddPrimaryLanguage = New System.Windows.Forms.Button()
        Me.lblPrimaryLanguageSetting = New System.Windows.Forms.Label()
        Me.gbReports = New System.Windows.Forms.GroupBox()
        Me.btnGenerateProfile = New System.Windows.Forms.Button()
        Me.cbSponseeProfile = New System.Windows.Forms.ComboBox()
        Me.SponseeInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblSponseeProfile = New System.Windows.Forms.Label()
        Me.lblYearReceipt = New System.Windows.Forms.Label()
        Me.lblSponsorReceipt = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblActivityHistory = New System.Windows.Forms.Label()
        Me.SponseeInfoTableAdapter = New KITHHKAT.HHKATDataSetTableAdapters.SponseeInfoTableAdapter()
        CType(Me.ActivityReportTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HHKATDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MonthBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SponsorInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPrimaryLanguage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrimaryLanguageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbReportSettings.SuspendLayout()
        Me.gbReports.SuspendLayout()
        CType(Me.SponseeInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnActivityHistory
        '
        Me.btnActivityHistory.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnActivityHistory.Location = New System.Drawing.Point(337, 33)
        Me.btnActivityHistory.Name = "btnActivityHistory"
        Me.btnActivityHistory.Size = New System.Drawing.Size(119, 21)
        Me.btnActivityHistory.TabIndex = 0
        Me.btnActivityHistory.Text = "Generate Audit"
        Me.btnActivityHistory.UseVisualStyleBackColor = True
        '
        'cbActivityReportTypes
        '
        Me.cbActivityReportTypes.DataSource = Me.ActivityReportTypesBindingSource
        Me.cbActivityReportTypes.DisplayMember = "ActivityReportTypesName"
        Me.cbActivityReportTypes.FormattingEnabled = True
        Me.cbActivityReportTypes.Location = New System.Drawing.Point(197, 33)
        Me.cbActivityReportTypes.Name = "cbActivityReportTypes"
        Me.cbActivityReportTypes.Size = New System.Drawing.Size(121, 21)
        Me.cbActivityReportTypes.TabIndex = 3
        Me.cbActivityReportTypes.ValueMember = "ActivityReportTypesID"
        '
        'ActivityReportTypesBindingSource
        '
        Me.ActivityReportTypesBindingSource.DataMember = "ActivityReportTypes"
        Me.ActivityReportTypesBindingSource.DataSource = Me.HHKATDataSet
        '
        'HHKATDataSet
        '
        Me.HHKATDataSet.DataSetName = "HHKATDataSet"
        Me.HHKATDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ActivityReportTypesTableAdapter
        '
        Me.ActivityReportTypesTableAdapter.ClearBeforeFill = True
        '
        'cbMonthBirthday
        '
        Me.cbMonthBirthday.DataSource = Me.MonthBindingSource
        Me.cbMonthBirthday.DisplayMember = "MonthName"
        Me.cbMonthBirthday.FormattingEnabled = True
        Me.cbMonthBirthday.Location = New System.Drawing.Point(197, 72)
        Me.cbMonthBirthday.Name = "cbMonthBirthday"
        Me.cbMonthBirthday.Size = New System.Drawing.Size(121, 21)
        Me.cbMonthBirthday.TabIndex = 4
        Me.cbMonthBirthday.ValueMember = "MonthInt"
        '
        'MonthBindingSource
        '
        Me.MonthBindingSource.DataMember = "Month"
        Me.MonthBindingSource.DataSource = Me.HHKATDataSet
        '
        'MonthTableAdapter
        '
        Me.MonthTableAdapter.ClearBeforeFill = True
        '
        'btnBirthdayReport
        '
        Me.btnBirthdayReport.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnBirthdayReport.Location = New System.Drawing.Point(337, 72)
        Me.btnBirthdayReport.Name = "btnBirthdayReport"
        Me.btnBirthdayReport.Size = New System.Drawing.Size(119, 21)
        Me.btnBirthdayReport.TabIndex = 5
        Me.btnBirthdayReport.Text = "Generate Birthdays"
        Me.btnBirthdayReport.UseVisualStyleBackColor = True
        '
        'cbRelationshipMonthlyReceipt
        '
        Me.cbRelationshipMonthlyReceipt.DataSource = Me.SponsorInfoBindingSource
        Me.cbRelationshipMonthlyReceipt.DisplayMember = "SponsorID"
        Me.cbRelationshipMonthlyReceipt.FormattingEnabled = True
        Me.cbRelationshipMonthlyReceipt.Location = New System.Drawing.Point(220, 397)
        Me.cbRelationshipMonthlyReceipt.Name = "cbRelationshipMonthlyReceipt"
        Me.cbRelationshipMonthlyReceipt.Size = New System.Drawing.Size(121, 21)
        Me.cbRelationshipMonthlyReceipt.TabIndex = 6
        Me.cbRelationshipMonthlyReceipt.ValueMember = "SponsorID"
        Me.cbRelationshipMonthlyReceipt.Visible = False
        '
        'SponsorInfoBindingSource
        '
        Me.SponsorInfoBindingSource.DataMember = "SponsorInfo"
        Me.SponsorInfoBindingSource.DataSource = Me.HHKATDataSet
        '
        'btnMonthlyReceipt
        '
        Me.btnMonthlyReceipt.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnMonthlyReceipt.Location = New System.Drawing.Point(360, 396)
        Me.btnMonthlyReceipt.Name = "btnMonthlyReceipt"
        Me.btnMonthlyReceipt.Size = New System.Drawing.Size(119, 21)
        Me.btnMonthlyReceipt.TabIndex = 7
        Me.btnMonthlyReceipt.Text = "Generate Receipt"
        Me.btnMonthlyReceipt.UseVisualStyleBackColor = True
        Me.btnMonthlyReceipt.Visible = False
        '
        'dtpYearMonthlyReceipt
        '
        Me.dtpYearMonthlyReceipt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYearMonthlyReceipt.Location = New System.Drawing.Point(220, 424)
        Me.dtpYearMonthlyReceipt.Name = "dtpYearMonthlyReceipt"
        Me.dtpYearMonthlyReceipt.Size = New System.Drawing.Size(72, 20)
        Me.dtpYearMonthlyReceipt.TabIndex = 8
        Me.dtpYearMonthlyReceipt.Visible = False
        '
        'dgvPrimaryLanguage
        '
        Me.dgvPrimaryLanguage.AllowUserToAddRows = False
        Me.dgvPrimaryLanguage.AllowUserToDeleteRows = False
        Me.dgvPrimaryLanguage.AllowUserToOrderColumns = True
        Me.dgvPrimaryLanguage.AllowUserToResizeColumns = False
        Me.dgvPrimaryLanguage.AllowUserToResizeRows = False
        Me.dgvPrimaryLanguage.AutoGenerateColumns = False
        Me.dgvPrimaryLanguage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPrimaryLanguage.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PrimaryLanguageDataGridViewTextBoxColumn, Me.LanguageReceiptTextDataGridViewTextBoxColumn})
        Me.dgvPrimaryLanguage.DataSource = Me.PrimaryLanguageBindingSource
        Me.dgvPrimaryLanguage.Location = New System.Drawing.Point(9, 33)
        Me.dgvPrimaryLanguage.Name = "dgvPrimaryLanguage"
        Me.dgvPrimaryLanguage.ReadOnly = True
        Me.dgvPrimaryLanguage.RowHeadersVisible = False
        Me.dgvPrimaryLanguage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPrimaryLanguage.Size = New System.Drawing.Size(500, 175)
        Me.dgvPrimaryLanguage.TabIndex = 10
        '
        'PrimaryLanguageDataGridViewTextBoxColumn
        '
        Me.PrimaryLanguageDataGridViewTextBoxColumn.DataPropertyName = "PrimaryLanguage"
        Me.PrimaryLanguageDataGridViewTextBoxColumn.HeaderText = "Primary Language"
        Me.PrimaryLanguageDataGridViewTextBoxColumn.Name = "PrimaryLanguageDataGridViewTextBoxColumn"
        Me.PrimaryLanguageDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrimaryLanguageDataGridViewTextBoxColumn.Width = 150
        '
        'LanguageReceiptTextDataGridViewTextBoxColumn
        '
        Me.LanguageReceiptTextDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.LanguageReceiptTextDataGridViewTextBoxColumn.DataPropertyName = "LanguageReceiptText"
        Me.LanguageReceiptTextDataGridViewTextBoxColumn.HeaderText = "Receipt Language Text"
        Me.LanguageReceiptTextDataGridViewTextBoxColumn.Name = "LanguageReceiptTextDataGridViewTextBoxColumn"
        Me.LanguageReceiptTextDataGridViewTextBoxColumn.ReadOnly = True
        Me.LanguageReceiptTextDataGridViewTextBoxColumn.Width = 430
        '
        'PrimaryLanguageBindingSource
        '
        Me.PrimaryLanguageBindingSource.DataMember = "PrimaryLanguage"
        Me.PrimaryLanguageBindingSource.DataSource = Me.HHKATDataSet
        '
        'PrimaryLanguageTableAdapter
        '
        Me.PrimaryLanguageTableAdapter.ClearBeforeFill = True
        '
        'SponsorInfoTableAdapter
        '
        Me.SponsorInfoTableAdapter.ClearBeforeFill = True
        '
        'gbReportSettings
        '
        Me.gbReportSettings.Controls.Add(Me.btnAddPrimaryLanguage)
        Me.gbReportSettings.Controls.Add(Me.lblPrimaryLanguageSetting)
        Me.gbReportSettings.Controls.Add(Me.dgvPrimaryLanguage)
        Me.gbReportSettings.Location = New System.Drawing.Point(527, 24)
        Me.gbReportSettings.Name = "gbReportSettings"
        Me.gbReportSettings.Size = New System.Drawing.Size(515, 488)
        Me.gbReportSettings.TabIndex = 11
        Me.gbReportSettings.TabStop = False
        Me.gbReportSettings.Text = "Report Settings"
        '
        'btnAddPrimaryLanguage
        '
        Me.btnAddPrimaryLanguage.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddPrimaryLanguage.Location = New System.Drawing.Point(405, 214)
        Me.btnAddPrimaryLanguage.Name = "btnAddPrimaryLanguage"
        Me.btnAddPrimaryLanguage.Size = New System.Drawing.Size(104, 23)
        Me.btnAddPrimaryLanguage.TabIndex = 12
        Me.btnAddPrimaryLanguage.Text = "Add Language"
        Me.btnAddPrimaryLanguage.UseVisualStyleBackColor = True
        '
        'lblPrimaryLanguageSetting
        '
        Me.lblPrimaryLanguageSetting.AutoSize = True
        Me.lblPrimaryLanguageSetting.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPrimaryLanguageSetting.Location = New System.Drawing.Point(6, 17)
        Me.lblPrimaryLanguageSetting.Name = "lblPrimaryLanguageSetting"
        Me.lblPrimaryLanguageSetting.Size = New System.Drawing.Size(149, 14)
        Me.lblPrimaryLanguageSetting.TabIndex = 11
        Me.lblPrimaryLanguageSetting.Text = "Set Receipt Language Text:"
        '
        'gbReports
        '
        Me.gbReports.Controls.Add(Me.btnGenerateProfile)
        Me.gbReports.Controls.Add(Me.cbSponseeProfile)
        Me.gbReports.Controls.Add(Me.lblSponseeProfile)
        Me.gbReports.Controls.Add(Me.lblYearReceipt)
        Me.gbReports.Controls.Add(Me.lblSponsorReceipt)
        Me.gbReports.Controls.Add(Me.lblMonth)
        Me.gbReports.Controls.Add(Me.lblActivityHistory)
        Me.gbReports.Controls.Add(Me.cbActivityReportTypes)
        Me.gbReports.Controls.Add(Me.btnActivityHistory)
        Me.gbReports.Controls.Add(Me.dtpYearMonthlyReceipt)
        Me.gbReports.Controls.Add(Me.cbMonthBirthday)
        Me.gbReports.Controls.Add(Me.btnMonthlyReceipt)
        Me.gbReports.Controls.Add(Me.btnBirthdayReport)
        Me.gbReports.Controls.Add(Me.cbRelationshipMonthlyReceipt)
        Me.gbReports.Location = New System.Drawing.Point(15, 24)
        Me.gbReports.Name = "gbReports"
        Me.gbReports.Size = New System.Drawing.Size(515, 488)
        Me.gbReports.TabIndex = 12
        Me.gbReports.TabStop = False
        Me.gbReports.Text = "Reports"
        '
        'btnGenerateProfile
        '
        Me.btnGenerateProfile.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnGenerateProfile.Location = New System.Drawing.Point(360, 450)
        Me.btnGenerateProfile.Name = "btnGenerateProfile"
        Me.btnGenerateProfile.Size = New System.Drawing.Size(119, 21)
        Me.btnGenerateProfile.TabIndex = 15
        Me.btnGenerateProfile.Text = "Generate Profile"
        Me.btnGenerateProfile.UseVisualStyleBackColor = True
        Me.btnGenerateProfile.Visible = False
        '
        'cbSponseeProfile
        '
        Me.cbSponseeProfile.DataSource = Me.SponseeInfoBindingSource
        Me.cbSponseeProfile.DisplayMember = "SponseeID"
        Me.cbSponseeProfile.FormattingEnabled = True
        Me.cbSponseeProfile.Location = New System.Drawing.Point(220, 450)
        Me.cbSponseeProfile.Name = "cbSponseeProfile"
        Me.cbSponseeProfile.Size = New System.Drawing.Size(121, 21)
        Me.cbSponseeProfile.TabIndex = 14
        Me.cbSponseeProfile.ValueMember = "SponseeID"
        Me.cbSponseeProfile.Visible = False
        '
        'SponseeInfoBindingSource
        '
        Me.SponseeInfoBindingSource.DataMember = "SponseeInfo"
        Me.SponseeInfoBindingSource.DataSource = Me.HHKATDataSet
        '
        'lblSponseeProfile
        '
        Me.lblSponseeProfile.AutoSize = True
        Me.lblSponseeProfile.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSponseeProfile.Location = New System.Drawing.Point(54, 450)
        Me.lblSponseeProfile.Name = "lblSponseeProfile"
        Me.lblSponseeProfile.Size = New System.Drawing.Size(92, 14)
        Me.lblSponseeProfile.TabIndex = 13
        Me.lblSponseeProfile.Text = "Sponsee Profile:"
        Me.lblSponseeProfile.Visible = False
        '
        'lblYearReceipt
        '
        Me.lblYearReceipt.AutoSize = True
        Me.lblYearReceipt.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblYearReceipt.Location = New System.Drawing.Point(51, 430)
        Me.lblYearReceipt.Name = "lblYearReceipt"
        Me.lblYearReceipt.Size = New System.Drawing.Size(89, 14)
        Me.lblYearReceipt.TabIndex = 12
        Me.lblYearReceipt.Text = "Year of Receipt:"
        Me.lblYearReceipt.Visible = False
        '
        'lblSponsorReceipt
        '
        Me.lblSponsorReceipt.AutoSize = True
        Me.lblSponsorReceipt.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSponsorReceipt.Location = New System.Drawing.Point(51, 400)
        Me.lblSponsorReceipt.Name = "lblSponsorReceipt"
        Me.lblSponsorReceipt.Size = New System.Drawing.Size(68, 14)
        Me.lblSponsorReceipt.TabIndex = 11
        Me.lblSponsorReceipt.Text = "Sponsor ID:"
        Me.lblSponsorReceipt.Visible = False
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblMonth.Location = New System.Drawing.Point(28, 76)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(94, 14)
        Me.lblMonth.TabIndex = 10
        Me.lblMonth.Text = "Birthday Month:"
        '
        'lblActivityHistory
        '
        Me.lblActivityHistory.AutoSize = True
        Me.lblActivityHistory.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblActivityHistory.Location = New System.Drawing.Point(28, 33)
        Me.lblActivityHistory.Name = "lblActivityHistory"
        Me.lblActivityHistory.Size = New System.Drawing.Size(52, 14)
        Me.lblActivityHistory.TabIndex = 9
        Me.lblActivityHistory.Text = "Activity:"
        '
        'SponseeInfoTableAdapter
        '
        Me.SponseeInfoTableAdapter.ClearBeforeFill = True
        '
        'ucReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.gbReports)
        Me.Controls.Add(Me.gbReportSettings)
        Me.Name = "ucReports"
        Me.Size = New System.Drawing.Size(1045, 579)
        CType(Me.ActivityReportTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HHKATDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MonthBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SponsorInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPrimaryLanguage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrimaryLanguageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbReportSettings.ResumeLayout(False)
        Me.gbReportSettings.PerformLayout()
        Me.gbReports.ResumeLayout(False)
        Me.gbReports.PerformLayout()
        CType(Me.SponseeInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnActivityHistory As System.Windows.Forms.Button
    Friend WithEvents cbActivityReportTypes As System.Windows.Forms.ComboBox
    Friend WithEvents ActivityReportTypesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HHKATDataSet As KITHHKAT.HHKATDataSet
    Friend WithEvents ActivityReportTypesTableAdapter As KITHHKAT.HHKATDataSetTableAdapters.ActivityReportTypesTableAdapter
    Friend WithEvents cbMonthBirthday As System.Windows.Forms.ComboBox
    Friend WithEvents MonthBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MonthTableAdapter As KITHHKAT.HHKATDataSetTableAdapters.MonthTableAdapter
    Friend WithEvents btnBirthdayReport As System.Windows.Forms.Button
    Friend WithEvents cbRelationshipMonthlyReceipt As System.Windows.Forms.ComboBox
    Friend WithEvents btnMonthlyReceipt As System.Windows.Forms.Button
    Friend WithEvents dtpYearMonthlyReceipt As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvPrimaryLanguage As System.Windows.Forms.DataGridView
    Friend WithEvents PrimaryLanguageBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrimaryLanguageTableAdapter As KITHHKAT.HHKATDataSetTableAdapters.PrimaryLanguageTableAdapter
    Friend WithEvents SponsorInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SponsorInfoTableAdapter As KITHHKAT.HHKATDataSetTableAdapters.SponsorInfoTableAdapter
    Friend WithEvents gbReportSettings As System.Windows.Forms.GroupBox
    Friend WithEvents lblPrimaryLanguageSetting As System.Windows.Forms.Label
    Friend WithEvents gbReports As System.Windows.Forms.GroupBox
    Friend WithEvents lblYearReceipt As System.Windows.Forms.Label
    Friend WithEvents lblSponsorReceipt As System.Windows.Forms.Label
    Friend WithEvents lblMonth As System.Windows.Forms.Label
    Friend WithEvents lblActivityHistory As System.Windows.Forms.Label
    Friend WithEvents PrimaryLanguageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LanguageReceiptTextDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAddPrimaryLanguage As System.Windows.Forms.Button
    Friend WithEvents cbSponseeProfile As System.Windows.Forms.ComboBox
    Friend WithEvents SponseeInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents lblSponseeProfile As System.Windows.Forms.Label
    Friend WithEvents SponseeInfoTableAdapter As KITHHKAT.HHKATDataSetTableAdapters.SponseeInfoTableAdapter
    Friend WithEvents btnGenerateProfile As System.Windows.Forms.Button

End Class
