<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucRelationship
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
        Me.tbSponseeLastName = New System.Windows.Forms.TextBox()
        Me.tbSponseeFirstName = New System.Windows.Forms.TextBox()
        Me.lblChurchName = New System.Windows.Forms.Label()
        Me.lblSponseeLN = New System.Windows.Forms.Label()
        Me.cbChurchName = New System.Windows.Forms.ComboBox()
        Me.ChurchInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HHKATDataSet = New KITHHKAT.HHKATDataSet()
        Me.lblSponseeFN = New System.Windows.Forms.Label()
        Me.dgvRelationship = New System.Windows.Forms.DataGridView()
        Me.RelationshipInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.RelationshipInfoTableAdapter = New KITHHKAT.HHKATDataSetTableAdapters.RelationshipInfoTableAdapter()
        Me.tbSponsorLastName = New System.Windows.Forms.TextBox()
        Me.tbSponsorFirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChurchInfoTableAdapter = New KITHHKAT.HHKATDataSetTableAdapters.ChurchInfoTableAdapter()
        Me.lblRelationshipID = New System.Windows.Forms.Label()
        Me.tbRelationshipID = New System.Windows.Forms.TextBox()
        Me.tbSponseeID = New System.Windows.Forms.TextBox()
        Me.lblSponseeID = New System.Windows.Forms.Label()
        Me.tbSponsorID = New System.Windows.Forms.TextBox()
        Me.lblSponsorID = New System.Windows.Forms.Label()
        Me.lblRelationshipCount = New System.Windows.Forms.Label()
        Me.tbRelationshipCount = New System.Windows.Forms.TextBox()
        CType(Me.ChurchInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HHKATDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRelationship, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RelationshipInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbSponseeLastName
        '
        Me.tbSponseeLastName.Location = New System.Drawing.Point(788, 34)
        Me.tbSponseeLastName.Name = "tbSponseeLastName"
        Me.tbSponseeLastName.Size = New System.Drawing.Size(100, 20)
        Me.tbSponseeLastName.TabIndex = 85
        '
        'tbSponseeFirstName
        '
        Me.tbSponseeFirstName.Location = New System.Drawing.Point(556, 34)
        Me.tbSponseeFirstName.Name = "tbSponseeFirstName"
        Me.tbSponseeFirstName.Size = New System.Drawing.Size(100, 20)
        Me.tbSponseeFirstName.TabIndex = 84
        '
        'lblChurchName
        '
        Me.lblChurchName.AutoSize = True
        Me.lblChurchName.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblChurchName.Location = New System.Drawing.Point(10, 64)
        Me.lblChurchName.Name = "lblChurchName"
        Me.lblChurchName.Size = New System.Drawing.Size(81, 14)
        Me.lblChurchName.TabIndex = 82
        Me.lblChurchName.Text = "Church Name:"
        '
        'lblSponseeLN
        '
        Me.lblSponseeLN.AutoSize = True
        Me.lblSponseeLN.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSponseeLN.Location = New System.Drawing.Point(676, 37)
        Me.lblSponseeLN.Name = "lblSponseeLN"
        Me.lblSponseeLN.Size = New System.Drawing.Size(113, 14)
        Me.lblSponseeLN.TabIndex = 79
        Me.lblSponseeLN.Text = "Sponsee Last Name:"
        '
        'cbChurchName
        '
        Me.cbChurchName.DataSource = Me.ChurchInfoBindingSource
        Me.cbChurchName.DisplayMember = "ChurchName"
        Me.cbChurchName.FormattingEnabled = True
        Me.cbChurchName.Location = New System.Drawing.Point(109, 61)
        Me.cbChurchName.Name = "cbChurchName"
        Me.cbChurchName.Size = New System.Drawing.Size(121, 21)
        Me.cbChurchName.TabIndex = 89
        Me.cbChurchName.ValueMember = "ChurchID"
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
        'lblSponseeFN
        '
        Me.lblSponseeFN.AutoSize = True
        Me.lblSponseeFN.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSponseeFN.Location = New System.Drawing.Point(445, 37)
        Me.lblSponseeFN.Name = "lblSponseeFN"
        Me.lblSponseeFN.Size = New System.Drawing.Size(114, 14)
        Me.lblSponseeFN.TabIndex = 78
        Me.lblSponseeFN.Text = "Sponsee First Name:"
        '
        'dgvRelationship
        '
        Me.dgvRelationship.AllowUserToAddRows = False
        Me.dgvRelationship.AllowUserToDeleteRows = False
        Me.dgvRelationship.AllowUserToOrderColumns = True
        Me.dgvRelationship.AllowUserToResizeColumns = False
        Me.dgvRelationship.AllowUserToResizeRows = False
        Me.dgvRelationship.BackgroundColor = System.Drawing.SystemColors.GrayText
        Me.dgvRelationship.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRelationship.Location = New System.Drawing.Point(13, 87)
        Me.dgvRelationship.Name = "dgvRelationship"
        Me.dgvRelationship.ReadOnly = True
        Me.dgvRelationship.RowHeadersVisible = False
        Me.dgvRelationship.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRelationship.Size = New System.Drawing.Size(1033, 428)
        Me.dgvRelationship.TabIndex = 76
        '
        'RelationshipInfoBindingSource
        '
        Me.RelationshipInfoBindingSource.DataMember = "RelationshipInfo"
        Me.RelationshipInfoBindingSource.DataSource = Me.HHKATDataSet
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
        'RelationshipInfoTableAdapter
        '
        Me.RelationshipInfoTableAdapter.ClearBeforeFill = True
        '
        'tbSponsorLastName
        '
        Me.tbSponsorLastName.Location = New System.Drawing.Point(788, 61)
        Me.tbSponsorLastName.Name = "tbSponsorLastName"
        Me.tbSponsorLastName.Size = New System.Drawing.Size(100, 20)
        Me.tbSponsorLastName.TabIndex = 93
        '
        'tbSponsorFirstName
        '
        Me.tbSponsorFirstName.Location = New System.Drawing.Point(556, 61)
        Me.tbSponsorFirstName.Name = "tbSponsorFirstName"
        Me.tbSponsorFirstName.Size = New System.Drawing.Size(100, 20)
        Me.tbSponsorFirstName.TabIndex = 92
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(676, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 14)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Sponsor Last Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(445, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 14)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Sponsor First Name:"
        '
        'ChurchInfoTableAdapter
        '
        Me.ChurchInfoTableAdapter.ClearBeforeFill = True
        '
        'lblRelationshipID
        '
        Me.lblRelationshipID.AutoSize = True
        Me.lblRelationshipID.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblRelationshipID.Location = New System.Drawing.Point(10, 37)
        Me.lblRelationshipID.Name = "lblRelationshipID"
        Me.lblRelationshipID.Size = New System.Drawing.Size(91, 14)
        Me.lblRelationshipID.TabIndex = 94
        Me.lblRelationshipID.Text = "Relationship ID:"
        '
        'tbRelationshipID
        '
        Me.tbRelationshipID.Location = New System.Drawing.Point(110, 34)
        Me.tbRelationshipID.Name = "tbRelationshipID"
        Me.tbRelationshipID.Size = New System.Drawing.Size(121, 20)
        Me.tbRelationshipID.TabIndex = 95
        '
        'tbSponseeID
        '
        Me.tbSponseeID.Location = New System.Drawing.Point(325, 34)
        Me.tbSponseeID.Name = "tbSponseeID"
        Me.tbSponseeID.Size = New System.Drawing.Size(100, 20)
        Me.tbSponseeID.TabIndex = 97
        '
        'lblSponseeID
        '
        Me.lblSponseeID.AutoSize = True
        Me.lblSponseeID.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSponseeID.Location = New System.Drawing.Point(253, 37)
        Me.lblSponseeID.Name = "lblSponseeID"
        Me.lblSponseeID.Size = New System.Drawing.Size(69, 14)
        Me.lblSponseeID.TabIndex = 96
        Me.lblSponseeID.Text = "Sponsee ID:"
        '
        'tbSponsorID
        '
        Me.tbSponsorID.Location = New System.Drawing.Point(325, 61)
        Me.tbSponsorID.Name = "tbSponsorID"
        Me.tbSponsorID.Size = New System.Drawing.Size(100, 20)
        Me.tbSponsorID.TabIndex = 99
        '
        'lblSponsorID
        '
        Me.lblSponsorID.AutoSize = True
        Me.lblSponsorID.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSponsorID.Location = New System.Drawing.Point(253, 64)
        Me.lblSponsorID.Name = "lblSponsorID"
        Me.lblSponsorID.Size = New System.Drawing.Size(68, 14)
        Me.lblSponsorID.TabIndex = 98
        Me.lblSponsorID.Text = "Sponsor ID:"
        '
        'lblRelationshipCount
        '
        Me.lblRelationshipCount.AutoSize = True
        Me.lblRelationshipCount.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblRelationshipCount.Location = New System.Drawing.Point(10, 525)
        Me.lblRelationshipCount.Name = "lblRelationshipCount"
        Me.lblRelationshipCount.Size = New System.Drawing.Size(85, 14)
        Me.lblRelationshipCount.TabIndex = 100
        Me.lblRelationshipCount.Text = "Relationships: "
        '
        'tbRelationshipCount
        '
        Me.tbRelationshipCount.Location = New System.Drawing.Point(88, 522)
        Me.tbRelationshipCount.Name = "tbRelationshipCount"
        Me.tbRelationshipCount.ReadOnly = True
        Me.tbRelationshipCount.Size = New System.Drawing.Size(100, 20)
        Me.tbRelationshipCount.TabIndex = 101
        '
        'ucRelationship
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.tbRelationshipCount)
        Me.Controls.Add(Me.lblRelationshipCount)
        Me.Controls.Add(Me.tbSponsorID)
        Me.Controls.Add(Me.lblSponsorID)
        Me.Controls.Add(Me.tbSponseeID)
        Me.Controls.Add(Me.lblSponseeID)
        Me.Controls.Add(Me.tbRelationshipID)
        Me.Controls.Add(Me.lblRelationshipID)
        Me.Controls.Add(Me.tbSponsorLastName)
        Me.Controls.Add(Me.tbSponsorFirstName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbSponseeLastName)
        Me.Controls.Add(Me.tbSponseeFirstName)
        Me.Controls.Add(Me.lblChurchName)
        Me.Controls.Add(Me.lblSponseeLN)
        Me.Controls.Add(Me.cbChurchName)
        Me.Controls.Add(Me.lblSponseeFN)
        Me.Controls.Add(Me.dgvRelationship)
        Me.Controls.Add(Me.btnSearch)
        Me.Name = "ucRelationship"
        Me.Size = New System.Drawing.Size(1045, 579)
        CType(Me.ChurchInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HHKATDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRelationship, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RelationshipInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbSponseeLastName As System.Windows.Forms.TextBox
    Friend WithEvents tbSponseeFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblChurchName As System.Windows.Forms.Label
    Friend WithEvents lblSponseeLN As System.Windows.Forms.Label
    Friend WithEvents cbChurchName As System.Windows.Forms.ComboBox
    Friend WithEvents lblSponseeFN As System.Windows.Forms.Label
    Friend WithEvents dgvRelationship As System.Windows.Forms.DataGridView
    Friend WithEvents RelationshipInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HHKATDataSet As KITHHKAT.HHKATDataSet
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents RelationshipInfoTableAdapter As KITHHKAT.HHKATDataSetTableAdapters.RelationshipInfoTableAdapter
    Friend WithEvents tbSponsorLastName As System.Windows.Forms.TextBox
    Friend WithEvents tbSponsorFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ChurchInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ChurchInfoTableAdapter As KITHHKAT.HHKATDataSetTableAdapters.ChurchInfoTableAdapter
    Friend WithEvents lblRelationshipID As System.Windows.Forms.Label
    Friend WithEvents tbRelationshipID As System.Windows.Forms.TextBox
    Friend WithEvents tbSponseeID As System.Windows.Forms.TextBox
    Friend WithEvents lblSponseeID As System.Windows.Forms.Label
    Friend WithEvents tbSponsorID As System.Windows.Forms.TextBox
    Friend WithEvents lblSponsorID As System.Windows.Forms.Label
    Friend WithEvents lblRelationshipCount As System.Windows.Forms.Label
    Friend WithEvents tbRelationshipCount As System.Windows.Forms.TextBox

End Class
