<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucChurch
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
        Me.btnNewChurch = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.tbChurchCode = New System.Windows.Forms.TextBox()
        Me.lblChurchCode = New System.Windows.Forms.Label()
        Me.tbChurchName = New System.Windows.Forms.TextBox()
        Me.lblChurchName = New System.Windows.Forms.Label()
        Me.tbArea = New System.Windows.Forms.TextBox()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.tbDistrict = New System.Windows.Forms.TextBox()
        Me.lblDistrict = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.tbCity = New System.Windows.Forms.TextBox()
        Me.dgvucChurch = New System.Windows.Forms.DataGridView()
        Me.ChurchIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChurchNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AreaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DistrictDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChurchInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HHKATDataSet = New KITHHKAT.HHKATDataSet()
        Me.ChurchInfoTableAdapter = New KITHHKAT.HHKATDataSetTableAdapters.ChurchInfoTableAdapter()
        Me.tbChurchCount = New System.Windows.Forms.TextBox()
        Me.lblChurchCount = New System.Windows.Forms.Label()
        CType(Me.dgvucChurch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChurchInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HHKATDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNewChurch
        '
        Me.btnNewChurch.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnNewChurch.Location = New System.Drawing.Point(936, 57)
        Me.btnNewChurch.Name = "btnNewChurch"
        Me.btnNewChurch.Size = New System.Drawing.Size(100, 20)
        Me.btnNewChurch.TabIndex = 75
        Me.btnNewChurch.Text = "Add New"
        Me.btnNewChurch.UseVisualStyleBackColor = True
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
        'tbChurchCode
        '
        Me.tbChurchCode.Location = New System.Drawing.Point(110, 34)
        Me.tbChurchCode.Name = "tbChurchCode"
        Me.tbChurchCode.Size = New System.Drawing.Size(121, 20)
        Me.tbChurchCode.TabIndex = 77
        '
        'lblChurchCode
        '
        Me.lblChurchCode.AutoSize = True
        Me.lblChurchCode.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblChurchCode.Location = New System.Drawing.Point(10, 37)
        Me.lblChurchCode.Name = "lblChurchCode"
        Me.lblChurchCode.Size = New System.Drawing.Size(77, 14)
        Me.lblChurchCode.TabIndex = 78
        Me.lblChurchCode.Text = "Church Code:"
        '
        'tbChurchName
        '
        Me.tbChurchName.Location = New System.Drawing.Point(326, 34)
        Me.tbChurchName.Name = "tbChurchName"
        Me.tbChurchName.Size = New System.Drawing.Size(100, 20)
        Me.tbChurchName.TabIndex = 79
        '
        'lblChurchName
        '
        Me.lblChurchName.AutoSize = True
        Me.lblChurchName.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblChurchName.Location = New System.Drawing.Point(245, 37)
        Me.lblChurchName.Name = "lblChurchName"
        Me.lblChurchName.Size = New System.Drawing.Size(81, 14)
        Me.lblChurchName.TabIndex = 80
        Me.lblChurchName.Text = "Church Name:"
        '
        'tbArea
        '
        Me.tbArea.Location = New System.Drawing.Point(557, 34)
        Me.tbArea.Name = "tbArea"
        Me.tbArea.Size = New System.Drawing.Size(100, 20)
        Me.tbArea.TabIndex = 81
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblArea.Location = New System.Drawing.Point(454, 37)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(101, 14)
        Me.lblArea.TabIndex = 82
        Me.lblArea.Text = "Area / Providence:"
        '
        'tbDistrict
        '
        Me.tbDistrict.Location = New System.Drawing.Point(789, 34)
        Me.tbDistrict.Name = "tbDistrict"
        Me.tbDistrict.Size = New System.Drawing.Size(100, 20)
        Me.tbDistrict.TabIndex = 83
        '
        'lblDistrict
        '
        Me.lblDistrict.AutoSize = True
        Me.lblDistrict.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDistrict.Location = New System.Drawing.Point(690, 37)
        Me.lblDistrict.Name = "lblDistrict"
        Me.lblDistrict.Size = New System.Drawing.Size(88, 14)
        Me.lblDistrict.TabIndex = 84
        Me.lblDistrict.Text = "Church District:"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCity.Location = New System.Drawing.Point(10, 64)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(71, 14)
        Me.lblCity.TabIndex = 86
        Me.lblCity.Text = "Church City:"
        '
        'tbCity
        '
        Me.tbCity.Location = New System.Drawing.Point(110, 61)
        Me.tbCity.Name = "tbCity"
        Me.tbCity.Size = New System.Drawing.Size(121, 20)
        Me.tbCity.TabIndex = 85
        '
        'dgvucChurch
        '
        Me.dgvucChurch.AllowUserToAddRows = False
        Me.dgvucChurch.AllowUserToDeleteRows = False
        Me.dgvucChurch.AllowUserToOrderColumns = True
        Me.dgvucChurch.AllowUserToResizeColumns = False
        Me.dgvucChurch.AllowUserToResizeRows = False
        Me.dgvucChurch.AutoGenerateColumns = False
        Me.dgvucChurch.BackgroundColor = System.Drawing.SystemColors.GrayText
        Me.dgvucChurch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvucChurch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ChurchIDDataGridViewTextBoxColumn, Me.ChurchNameDataGridViewTextBoxColumn, Me.AreaDataGridViewTextBoxColumn, Me.DistrictDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn})
        Me.dgvucChurch.DataSource = Me.ChurchInfoBindingSource
        Me.dgvucChurch.Location = New System.Drawing.Point(13, 88)
        Me.dgvucChurch.Name = "dgvucChurch"
        Me.dgvucChurch.ReadOnly = True
        Me.dgvucChurch.RowHeadersVisible = False
        Me.dgvucChurch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvucChurch.Size = New System.Drawing.Size(1033, 428)
        Me.dgvucChurch.TabIndex = 87
        '
        'ChurchIDDataGridViewTextBoxColumn
        '
        Me.ChurchIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ChurchIDDataGridViewTextBoxColumn.DataPropertyName = "ChurchID"
        Me.ChurchIDDataGridViewTextBoxColumn.HeaderText = "ChurchID"
        Me.ChurchIDDataGridViewTextBoxColumn.Name = "ChurchIDDataGridViewTextBoxColumn"
        Me.ChurchIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ChurchNameDataGridViewTextBoxColumn
        '
        Me.ChurchNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ChurchNameDataGridViewTextBoxColumn.DataPropertyName = "ChurchName"
        Me.ChurchNameDataGridViewTextBoxColumn.HeaderText = "Church Name"
        Me.ChurchNameDataGridViewTextBoxColumn.Name = "ChurchNameDataGridViewTextBoxColumn"
        Me.ChurchNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AreaDataGridViewTextBoxColumn
        '
        Me.AreaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AreaDataGridViewTextBoxColumn.DataPropertyName = "Area"
        Me.AreaDataGridViewTextBoxColumn.HeaderText = "Area / Providence"
        Me.AreaDataGridViewTextBoxColumn.Name = "AreaDataGridViewTextBoxColumn"
        Me.AreaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DistrictDataGridViewTextBoxColumn
        '
        Me.DistrictDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DistrictDataGridViewTextBoxColumn.DataPropertyName = "District"
        Me.DistrictDataGridViewTextBoxColumn.HeaderText = "Church District"
        Me.DistrictDataGridViewTextBoxColumn.Name = "DistrictDataGridViewTextBoxColumn"
        Me.DistrictDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "Church City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        Me.CityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ChurchInfoBindingSource
        '
        Me.ChurchInfoBindingSource.DataMember = "ChurchInfo"
        Me.ChurchInfoBindingSource.DataSource = Me.HHKATDataSet
        '
        'HHKATDataSet
        '
        Me.HHKATDataSet.DataSetName = "HHKATDataSet"
        Me.HHKATDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ChurchInfoTableAdapter
        '
        Me.ChurchInfoTableAdapter.ClearBeforeFill = True
        '
        'tbChurchCount
        '
        Me.tbChurchCount.Location = New System.Drawing.Point(88, 522)
        Me.tbChurchCount.Name = "tbChurchCount"
        Me.tbChurchCount.ReadOnly = True
        Me.tbChurchCount.Size = New System.Drawing.Size(100, 20)
        Me.tbChurchCount.TabIndex = 103
        '
        'lblChurchCount
        '
        Me.lblChurchCount.AutoSize = True
        Me.lblChurchCount.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblChurchCount.Location = New System.Drawing.Point(10, 525)
        Me.lblChurchCount.Name = "lblChurchCount"
        Me.lblChurchCount.Size = New System.Drawing.Size(61, 14)
        Me.lblChurchCount.TabIndex = 102
        Me.lblChurchCount.Text = "Churches: "
        '
        'ucChurch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbChurchCount)
        Me.Controls.Add(Me.lblChurchCount)
        Me.Controls.Add(Me.dgvucChurch)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.tbCity)
        Me.Controls.Add(Me.tbDistrict)
        Me.Controls.Add(Me.lblDistrict)
        Me.Controls.Add(Me.tbArea)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.tbChurchName)
        Me.Controls.Add(Me.lblChurchName)
        Me.Controls.Add(Me.tbChurchCode)
        Me.Controls.Add(Me.lblChurchCode)
        Me.Controls.Add(Me.btnNewChurch)
        Me.Controls.Add(Me.btnSearch)
        Me.Name = "ucChurch"
        Me.Size = New System.Drawing.Size(1049, 579)
        CType(Me.dgvucChurch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChurchInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HHKATDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNewChurch As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents tbChurchCode As System.Windows.Forms.TextBox
    Friend WithEvents lblChurchCode As System.Windows.Forms.Label
    Friend WithEvents tbChurchName As System.Windows.Forms.TextBox
    Friend WithEvents lblChurchName As System.Windows.Forms.Label
    Friend WithEvents tbArea As System.Windows.Forms.TextBox
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents tbDistrict As System.Windows.Forms.TextBox
    Friend WithEvents lblDistrict As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents tbCity As System.Windows.Forms.TextBox
    Friend WithEvents dgvucChurch As System.Windows.Forms.DataGridView
    Friend WithEvents DateCreatedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserCreatedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChurchInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HHKATDataSet As KITHHKAT.HHKATDataSet
    Friend WithEvents ChurchInfoTableAdapter As KITHHKAT.HHKATDataSetTableAdapters.ChurchInfoTableAdapter
    Friend WithEvents ChurchIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChurchNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AreaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DistrictDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tbChurchCount As System.Windows.Forms.TextBox
    Friend WithEvents lblChurchCount As System.Windows.Forms.Label

End Class
