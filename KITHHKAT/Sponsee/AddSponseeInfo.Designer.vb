<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddSponseeInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddSponseeInfo))
        Me.cbChurchName = New System.Windows.Forms.ComboBox()
        Me.ChurchInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HHKATDataSet = New KITHHKAT.HHKATDataSet()
        Me.btnEnterSponsee = New System.Windows.Forms.Button()
        Me.dtpJoinCOJ = New System.Windows.Forms.DateTimePicker()
        Me.cbPants = New System.Windows.Forms.ComboBox()
        Me.PantsSizeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbShirt = New System.Windows.Forms.ComboBox()
        Me.ShirtSizeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbShoe = New System.Windows.Forms.ComboBox()
        Me.ShoeSizeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbGrade = New System.Windows.Forms.ComboBox()
        Me.GradeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rbMale = New System.Windows.Forms.RadioButton()
        Me.rbFemale = New System.Windows.Forms.RadioButton()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.tbLastName = New System.Windows.Forms.TextBox()
        Me.tbFirstName = New System.Windows.Forms.TextBox()
        Me.tbSponseeID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblChurchName = New System.Windows.Forms.Label()
        Me.lblSponseeCOJDate = New System.Windows.Forms.Label()
        Me.lblSponseePants = New System.Windows.Forms.Label()
        Me.lblSponseeShirt = New System.Windows.Forms.Label()
        Me.lblSponseeShoe = New System.Windows.Forms.Label()
        Me.lblSponseeGrade = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblSponseeDOB = New System.Windows.Forms.Label()
        Me.lblSponseeLN = New System.Windows.Forms.Label()
        Me.lblSponseeFN = New System.Windows.Forms.Label()
        Me.lblSponseeID = New System.Windows.Forms.Label()
        Me.ChurchInfoTableAdapter = New KITHHKAT.HHKATDataSetTableAdapters.ChurchInfoTableAdapter()
        Me.GradeTableAdapter = New KITHHKAT.HHKATDataSetTableAdapters.GradeTableAdapter()
        Me.ShoeSizeTableAdapter = New KITHHKAT.HHKATDataSetTableAdapters.ShoeSizeTableAdapter()
        Me.ShirtSizeTableAdapter = New KITHHKAT.HHKATDataSetTableAdapters.ShirtSizeTableAdapter()
        Me.PantsSizeTableAdapter = New KITHHKAT.HHKATDataSetTableAdapters.PantsSizeTableAdapter()
        Me.tbPhoto = New System.Windows.Forms.TextBox()
        Me.lblPhoto = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnBrowse2 = New System.Windows.Forms.Button()
        Me.lblAppLoc = New System.Windows.Forms.Label()
        Me.tbAppPath = New System.Windows.Forms.TextBox()
        CType(Me.ChurchInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HHKATDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PantsSizeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShirtSizeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShoeSizeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbChurchName
        '
        Me.cbChurchName.DataSource = Me.ChurchInfoBindingSource
        Me.cbChurchName.DisplayMember = "ChurchName"
        Me.cbChurchName.FormattingEnabled = True
        Me.cbChurchName.Location = New System.Drawing.Point(156, 49)
        Me.cbChurchName.Name = "cbChurchName"
        Me.cbChurchName.Size = New System.Drawing.Size(140, 22)
        Me.cbChurchName.TabIndex = 50
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
        'btnEnterSponsee
        '
        Me.btnEnterSponsee.Location = New System.Drawing.Point(347, 549)
        Me.btnEnterSponsee.Name = "btnEnterSponsee"
        Me.btnEnterSponsee.Size = New System.Drawing.Size(110, 23)
        Me.btnEnterSponsee.TabIndex = 49
        Me.btnEnterSponsee.Text = "Enter Sponsee"
        Me.btnEnterSponsee.UseVisualStyleBackColor = True
        '
        'dtpJoinCOJ
        '
        Me.dtpJoinCOJ.Location = New System.Drawing.Point(156, 446)
        Me.dtpJoinCOJ.Name = "dtpJoinCOJ"
        Me.dtpJoinCOJ.Size = New System.Drawing.Size(233, 22)
        Me.dtpJoinCOJ.TabIndex = 48
        '
        'cbPants
        '
        Me.cbPants.DataSource = Me.PantsSizeBindingSource
        Me.cbPants.DisplayMember = "PantsSize"
        Me.cbPants.FormattingEnabled = True
        Me.cbPants.Location = New System.Drawing.Point(156, 402)
        Me.cbPants.Name = "cbPants"
        Me.cbPants.Size = New System.Drawing.Size(140, 22)
        Me.cbPants.TabIndex = 47
        Me.cbPants.ValueMember = "PantsSize"
        '
        'PantsSizeBindingSource
        '
        Me.PantsSizeBindingSource.DataMember = "PantsSize"
        Me.PantsSizeBindingSource.DataSource = Me.HHKATDataSet
        '
        'cbShirt
        '
        Me.cbShirt.DataSource = Me.ShirtSizeBindingSource
        Me.cbShirt.DisplayMember = "ShirtSize"
        Me.cbShirt.FormattingEnabled = True
        Me.cbShirt.Location = New System.Drawing.Point(156, 363)
        Me.cbShirt.Name = "cbShirt"
        Me.cbShirt.Size = New System.Drawing.Size(140, 22)
        Me.cbShirt.TabIndex = 46
        Me.cbShirt.ValueMember = "ShirtSize"
        '
        'ShirtSizeBindingSource
        '
        Me.ShirtSizeBindingSource.DataMember = "ShirtSize"
        Me.ShirtSizeBindingSource.DataSource = Me.HHKATDataSet
        '
        'cbShoe
        '
        Me.cbShoe.DataSource = Me.ShoeSizeBindingSource
        Me.cbShoe.DisplayMember = "ShoeSize"
        Me.cbShoe.FormattingEnabled = True
        Me.cbShoe.Location = New System.Drawing.Point(156, 321)
        Me.cbShoe.Name = "cbShoe"
        Me.cbShoe.Size = New System.Drawing.Size(140, 22)
        Me.cbShoe.TabIndex = 45
        Me.cbShoe.ValueMember = "ShoeSize"
        '
        'ShoeSizeBindingSource
        '
        Me.ShoeSizeBindingSource.DataMember = "ShoeSize"
        Me.ShoeSizeBindingSource.DataSource = Me.HHKATDataSet
        '
        'cbGrade
        '
        Me.cbGrade.DataSource = Me.GradeBindingSource
        Me.cbGrade.DisplayMember = "Grade"
        Me.cbGrade.FormattingEnabled = True
        Me.cbGrade.Location = New System.Drawing.Point(156, 279)
        Me.cbGrade.Name = "cbGrade"
        Me.cbGrade.Size = New System.Drawing.Size(140, 22)
        Me.cbGrade.TabIndex = 44
        Me.cbGrade.ValueMember = "Grade"
        '
        'GradeBindingSource
        '
        Me.GradeBindingSource.DataMember = "Grade"
        Me.GradeBindingSource.DataSource = Me.HHKATDataSet
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.Location = New System.Drawing.Point(246, 244)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(50, 18)
        Me.rbMale.TabIndex = 43
        Me.rbMale.TabStop = True
        Me.rbMale.Text = "Male"
        Me.rbMale.UseVisualStyleBackColor = True
        '
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.Location = New System.Drawing.Point(156, 244)
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Size = New System.Drawing.Size(62, 18)
        Me.rbFemale.TabIndex = 42
        Me.rbFemale.TabStop = True
        Me.rbFemale.Text = "Female"
        Me.rbFemale.UseVisualStyleBackColor = True
        '
        'dtpDOB
        '
        Me.dtpDOB.Location = New System.Drawing.Point(156, 208)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(233, 22)
        Me.dtpDOB.TabIndex = 41
        '
        'tbLastName
        '
        Me.tbLastName.Location = New System.Drawing.Point(156, 169)
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.Size = New System.Drawing.Size(116, 22)
        Me.tbLastName.TabIndex = 40
        '
        'tbFirstName
        '
        Me.tbFirstName.Location = New System.Drawing.Point(156, 129)
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.Size = New System.Drawing.Size(116, 22)
        Me.tbFirstName.TabIndex = 39
        '
        'tbSponseeID
        '
        Me.tbSponseeID.Location = New System.Drawing.Point(156, 90)
        Me.tbSponseeID.Name = "tbSponseeID"
        Me.tbSponseeID.Size = New System.Drawing.Size(116, 22)
        Me.tbSponseeID.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(371, 23)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Enter Sponsee's Information in fields below"
        '
        'lblChurchName
        '
        Me.lblChurchName.AutoSize = True
        Me.lblChurchName.Location = New System.Drawing.Point(26, 52)
        Me.lblChurchName.Name = "lblChurchName"
        Me.lblChurchName.Size = New System.Drawing.Size(81, 14)
        Me.lblChurchName.TabIndex = 36
        Me.lblChurchName.Text = "Church Name:"
        '
        'lblSponseeCOJDate
        '
        Me.lblSponseeCOJDate.AutoSize = True
        Me.lblSponseeCOJDate.Location = New System.Drawing.Point(26, 452)
        Me.lblSponseeCOJDate.Name = "lblSponseeCOJDate"
        Me.lblSponseeCOJDate.Size = New System.Drawing.Size(96, 14)
        Me.lblSponseeCOJDate.TabIndex = 35
        Me.lblSponseeCOJDate.Text = "Date Joined COJ:"
        '
        'lblSponseePants
        '
        Me.lblSponseePants.AutoSize = True
        Me.lblSponseePants.Location = New System.Drawing.Point(26, 405)
        Me.lblSponseePants.Name = "lblSponseePants"
        Me.lblSponseePants.Size = New System.Drawing.Size(65, 14)
        Me.lblSponseePants.TabIndex = 34
        Me.lblSponseePants.Text = "Pants Size:"
        '
        'lblSponseeShirt
        '
        Me.lblSponseeShirt.AutoSize = True
        Me.lblSponseeShirt.Location = New System.Drawing.Point(26, 366)
        Me.lblSponseeShirt.Name = "lblSponseeShirt"
        Me.lblSponseeShirt.Size = New System.Drawing.Size(61, 14)
        Me.lblSponseeShirt.TabIndex = 33
        Me.lblSponseeShirt.Text = "Shirt Size:"
        '
        'lblSponseeShoe
        '
        Me.lblSponseeShoe.AutoSize = True
        Me.lblSponseeShoe.Location = New System.Drawing.Point(26, 324)
        Me.lblSponseeShoe.Name = "lblSponseeShoe"
        Me.lblSponseeShoe.Size = New System.Drawing.Size(62, 14)
        Me.lblSponseeShoe.TabIndex = 32
        Me.lblSponseeShoe.Text = "Shoe Size:"
        '
        'lblSponseeGrade
        '
        Me.lblSponseeGrade.AutoSize = True
        Me.lblSponseeGrade.Location = New System.Drawing.Point(26, 282)
        Me.lblSponseeGrade.Name = "lblSponseeGrade"
        Me.lblSponseeGrade.Size = New System.Drawing.Size(42, 14)
        Me.lblSponseeGrade.TabIndex = 31
        Me.lblSponseeGrade.Text = "Grade:"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(26, 246)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(49, 14)
        Me.lblGender.TabIndex = 30
        Me.lblGender.Text = "Gender:"
        '
        'lblSponseeDOB
        '
        Me.lblSponseeDOB.AutoSize = True
        Me.lblSponseeDOB.Location = New System.Drawing.Point(26, 214)
        Me.lblSponseeDOB.Name = "lblSponseeDOB"
        Me.lblSponseeDOB.Size = New System.Drawing.Size(77, 14)
        Me.lblSponseeDOB.TabIndex = 29
        Me.lblSponseeDOB.Text = "Date of Birth:"
        '
        'lblSponseeLN
        '
        Me.lblSponseeLN.AutoSize = True
        Me.lblSponseeLN.Location = New System.Drawing.Point(26, 172)
        Me.lblSponseeLN.Name = "lblSponseeLN"
        Me.lblSponseeLN.Size = New System.Drawing.Size(66, 14)
        Me.lblSponseeLN.TabIndex = 28
        Me.lblSponseeLN.Text = "Last Name:"
        '
        'lblSponseeFN
        '
        Me.lblSponseeFN.AutoSize = True
        Me.lblSponseeFN.Location = New System.Drawing.Point(26, 129)
        Me.lblSponseeFN.Name = "lblSponseeFN"
        Me.lblSponseeFN.Size = New System.Drawing.Size(67, 14)
        Me.lblSponseeFN.TabIndex = 27
        Me.lblSponseeFN.Text = "First Name:"
        '
        'lblSponseeID
        '
        Me.lblSponseeID.AutoSize = True
        Me.lblSponseeID.Location = New System.Drawing.Point(26, 90)
        Me.lblSponseeID.Name = "lblSponseeID"
        Me.lblSponseeID.Size = New System.Drawing.Size(69, 14)
        Me.lblSponseeID.TabIndex = 26
        Me.lblSponseeID.Text = "Sponsee ID:"
        '
        'ChurchInfoTableAdapter
        '
        Me.ChurchInfoTableAdapter.ClearBeforeFill = True
        '
        'GradeTableAdapter
        '
        Me.GradeTableAdapter.ClearBeforeFill = True
        '
        'ShoeSizeTableAdapter
        '
        Me.ShoeSizeTableAdapter.ClearBeforeFill = True
        '
        'ShirtSizeTableAdapter
        '
        Me.ShirtSizeTableAdapter.ClearBeforeFill = True
        '
        'PantsSizeTableAdapter
        '
        Me.PantsSizeTableAdapter.ClearBeforeFill = True
        '
        'tbPhoto
        '
        Me.tbPhoto.Location = New System.Drawing.Point(156, 486)
        Me.tbPhoto.Name = "tbPhoto"
        Me.tbPhoto.Size = New System.Drawing.Size(233, 22)
        Me.tbPhoto.TabIndex = 52
        '
        'lblPhoto
        '
        Me.lblPhoto.AutoSize = True
        Me.lblPhoto.Location = New System.Drawing.Point(27, 489)
        Me.lblPhoto.Name = "lblPhoto"
        Me.lblPhoto.Size = New System.Drawing.Size(92, 14)
        Me.lblPhoto.TabIndex = 53
        Me.lblPhoto.Text = "Photo Location:"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(392, 486)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(65, 23)
        Me.btnBrowse.TabIndex = 54
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnBrowse2
        '
        Me.btnBrowse2.Location = New System.Drawing.Point(392, 520)
        Me.btnBrowse2.Name = "btnBrowse2"
        Me.btnBrowse2.Size = New System.Drawing.Size(65, 23)
        Me.btnBrowse2.TabIndex = 57
        Me.btnBrowse2.Text = "Browse"
        Me.btnBrowse2.UseVisualStyleBackColor = True
        '
        'lblAppLoc
        '
        Me.lblAppLoc.AutoSize = True
        Me.lblAppLoc.Location = New System.Drawing.Point(27, 523)
        Me.lblAppLoc.Name = "lblAppLoc"
        Me.lblAppLoc.Size = New System.Drawing.Size(99, 14)
        Me.lblAppLoc.TabIndex = 56
        Me.lblAppLoc.Text = "Application Path:"
        '
        'tbAppPath
        '
        Me.tbAppPath.Location = New System.Drawing.Point(156, 520)
        Me.tbAppPath.Name = "tbAppPath"
        Me.tbAppPath.Size = New System.Drawing.Size(233, 22)
        Me.tbAppPath.TabIndex = 55
        '
        'AddSponseeInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(477, 584)
        Me.Controls.Add(Me.btnBrowse2)
        Me.Controls.Add(Me.lblAppLoc)
        Me.Controls.Add(Me.tbAppPath)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.lblPhoto)
        Me.Controls.Add(Me.tbPhoto)
        Me.Controls.Add(Me.cbChurchName)
        Me.Controls.Add(Me.btnEnterSponsee)
        Me.Controls.Add(Me.dtpJoinCOJ)
        Me.Controls.Add(Me.cbPants)
        Me.Controls.Add(Me.cbShirt)
        Me.Controls.Add(Me.cbShoe)
        Me.Controls.Add(Me.cbGrade)
        Me.Controls.Add(Me.rbMale)
        Me.Controls.Add(Me.rbFemale)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.tbLastName)
        Me.Controls.Add(Me.tbFirstName)
        Me.Controls.Add(Me.tbSponseeID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblChurchName)
        Me.Controls.Add(Me.lblSponseeCOJDate)
        Me.Controls.Add(Me.lblSponseePants)
        Me.Controls.Add(Me.lblSponseeShirt)
        Me.Controls.Add(Me.lblSponseeShoe)
        Me.Controls.Add(Me.lblSponseeGrade)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblSponseeDOB)
        Me.Controls.Add(Me.lblSponseeLN)
        Me.Controls.Add(Me.lblSponseeFN)
        Me.Controls.Add(Me.lblSponseeID)
        Me.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddSponseeInfo"
        Me.Text = "Add Sponsee Information"
        CType(Me.ChurchInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HHKATDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PantsSizeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShirtSizeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShoeSizeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbChurchName As System.Windows.Forms.ComboBox
    Friend WithEvents btnEnterSponsee As System.Windows.Forms.Button
    Friend WithEvents dtpJoinCOJ As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbPants As System.Windows.Forms.ComboBox
    Friend WithEvents cbShirt As System.Windows.Forms.ComboBox
    Friend WithEvents cbShoe As System.Windows.Forms.ComboBox
    Friend WithEvents cbGrade As System.Windows.Forms.ComboBox
    Friend WithEvents rbMale As System.Windows.Forms.RadioButton
    Friend WithEvents rbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbLastName As System.Windows.Forms.TextBox
    Friend WithEvents tbFirstName As System.Windows.Forms.TextBox
    Friend WithEvents tbSponseeID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblChurchName As System.Windows.Forms.Label
    Friend WithEvents lblSponseeCOJDate As System.Windows.Forms.Label
    Friend WithEvents lblSponseePants As System.Windows.Forms.Label
    Friend WithEvents lblSponseeShirt As System.Windows.Forms.Label
    Friend WithEvents lblSponseeShoe As System.Windows.Forms.Label
    Friend WithEvents lblSponseeGrade As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblSponseeDOB As System.Windows.Forms.Label
    Friend WithEvents lblSponseeLN As System.Windows.Forms.Label
    Friend WithEvents lblSponseeFN As System.Windows.Forms.Label
    Friend WithEvents lblSponseeID As System.Windows.Forms.Label
    Friend WithEvents HHKATDataSet As KITHHKAT.HHKATDataSet
    Friend WithEvents ChurchInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ChurchInfoTableAdapter As KITHHKAT.HHKATDataSetTableAdapters.ChurchInfoTableAdapter
    Friend WithEvents GradeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GradeTableAdapter As KITHHKAT.HHKATDataSetTableAdapters.GradeTableAdapter
    Friend WithEvents ShoeSizeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ShoeSizeTableAdapter As KITHHKAT.HHKATDataSetTableAdapters.ShoeSizeTableAdapter
    Friend WithEvents ShirtSizeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ShirtSizeTableAdapter As KITHHKAT.HHKATDataSetTableAdapters.ShirtSizeTableAdapter
    Friend WithEvents PantsSizeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PantsSizeTableAdapter As KITHHKAT.HHKATDataSetTableAdapters.PantsSizeTableAdapter
    Friend WithEvents tbPhoto As System.Windows.Forms.TextBox
    Friend WithEvents lblPhoto As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnBrowse2 As System.Windows.Forms.Button
    Friend WithEvents lblAppLoc As System.Windows.Forms.Label
    Friend WithEvents tbAppPath As System.Windows.Forms.TextBox
End Class
