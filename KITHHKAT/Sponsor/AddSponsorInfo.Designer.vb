<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddSponsorInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddSponsorInfo))
        Me.cbState = New System.Windows.Forms.ComboBox()
        Me.StateRefBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HHKATDataSet = New KITHHKAT.HHKATDataSet()
        Me.lbl_State = New System.Windows.Forms.Label()
        Me.lbl_City = New System.Windows.Forms.Label()
        Me.btnEnterSponInfo = New System.Windows.Forms.Button()
        Me.lblInsertSponsorInfoInfo = New System.Windows.Forms.Label()
        Me.tbCity = New System.Windows.Forms.TextBox()
        Me.tbSponsorLN = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblAltFirst = New System.Windows.Forms.Label()
        Me.lblSponsorName = New System.Windows.Forms.Label()
        Me.lblSponsorID = New System.Windows.Forms.Label()
        Me.tbPhoneNum = New System.Windows.Forms.TextBox()
        Me.tbAddress = New System.Windows.Forms.TextBox()
        Me.tbSponsorEmail = New System.Windows.Forms.TextBox()
        Me.tbSponsorAFN = New System.Windows.Forms.TextBox()
        Me.tbSponsorFN = New System.Windows.Forms.TextBox()
        Me.tbSponsorID = New System.Windows.Forms.TextBox()
        Me.StateRefTableAdapter = New KITHHKAT.HHKATDataSetTableAdapters.StateRefTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbPrimaryLanguage = New System.Windows.Forms.ComboBox()
        Me.PrimaryLanguageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrimaryLanguageTableAdapter = New KITHHKAT.HHKATDataSetTableAdapters.PrimaryLanguageTableAdapter()
        CType(Me.StateRefBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HHKATDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrimaryLanguageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbState
        '
        Me.cbState.DataSource = Me.StateRefBindingSource
        Me.cbState.DisplayMember = "StateRef"
        Me.cbState.FormattingEnabled = True
        Me.cbState.Location = New System.Drawing.Point(149, 308)
        Me.cbState.Name = "cbState"
        Me.cbState.Size = New System.Drawing.Size(100, 22)
        Me.cbState.TabIndex = 47
        Me.cbState.ValueMember = "StateRef"
        '
        'StateRefBindingSource
        '
        Me.StateRefBindingSource.DataMember = "StateRef"
        Me.StateRefBindingSource.DataSource = Me.HHKATDataSet
        '
        'HHKATDataSet
        '
        Me.HHKATDataSet.DataSetName = "HHKATDataSet"
        Me.HHKATDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lbl_State
        '
        Me.lbl_State.AutoSize = True
        Me.lbl_State.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_State.Location = New System.Drawing.Point(25, 311)
        Me.lbl_State.Name = "lbl_State"
        Me.lbl_State.Size = New System.Drawing.Size(40, 14)
        Me.lbl_State.TabIndex = 55
        Me.lbl_State.Text = "State:"
        '
        'lbl_City
        '
        Me.lbl_City.AutoSize = True
        Me.lbl_City.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_City.Location = New System.Drawing.Point(25, 267)
        Me.lbl_City.Name = "lbl_City"
        Me.lbl_City.Size = New System.Drawing.Size(32, 14)
        Me.lbl_City.TabIndex = 54
        Me.lbl_City.Text = "City:"
        '
        'btnEnterSponInfo
        '
        Me.btnEnterSponInfo.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnEnterSponInfo.Location = New System.Drawing.Point(255, 428)
        Me.btnEnterSponInfo.Name = "btnEnterSponInfo"
        Me.btnEnterSponInfo.Size = New System.Drawing.Size(113, 20)
        Me.btnEnterSponInfo.TabIndex = 50
        Me.btnEnterSponInfo.Text = "Enter Sponsor "
        Me.btnEnterSponInfo.UseVisualStyleBackColor = True
        '
        'lblInsertSponsorInfoInfo
        '
        Me.lblInsertSponsorInfoInfo.AutoSize = True
        Me.lblInsertSponsorInfoInfo.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsertSponsorInfoInfo.Location = New System.Drawing.Point(12, 9)
        Me.lblInsertSponsorInfoInfo.Name = "lblInsertSponsorInfoInfo"
        Me.lblInsertSponsorInfoInfo.Size = New System.Drawing.Size(375, 23)
        Me.lblInsertSponsorInfoInfo.TabIndex = 53
        Me.lblInsertSponsorInfoInfo.Text = "Enter Sponsor's Information in fields below:"
        '
        'tbCity
        '
        Me.tbCity.Location = New System.Drawing.Point(149, 264)
        Me.tbCity.Name = "tbCity"
        Me.tbCity.Size = New System.Drawing.Size(100, 22)
        Me.tbCity.TabIndex = 44
        '
        'tbSponsorLN
        '
        Me.tbSponsorLN.Location = New System.Drawing.Point(255, 87)
        Me.tbSponsorLN.Name = "tbSponsorLN"
        Me.tbSponsorLN.Size = New System.Drawing.Size(100, 22)
        Me.tbSponsorLN.TabIndex = 39
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPhone.Location = New System.Drawing.Point(25, 403)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(90, 14)
        Me.lblPhone.TabIndex = 52
        Me.lblPhone.Text = "Phone Number:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblAddress.Location = New System.Drawing.Point(25, 223)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(53, 14)
        Me.lblAddress.TabIndex = 51
        Me.lblAddress.Text = "Address:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblEmail.Location = New System.Drawing.Point(25, 176)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(83, 14)
        Me.lblEmail.TabIndex = 49
        Me.lblEmail.Text = "Email Address:"
        '
        'lblAltFirst
        '
        Me.lblAltFirst.AutoSize = True
        Me.lblAltFirst.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblAltFirst.Location = New System.Drawing.Point(25, 133)
        Me.lblAltFirst.Name = "lblAltFirst"
        Me.lblAltFirst.Size = New System.Drawing.Size(119, 14)
        Me.lblAltFirst.TabIndex = 46
        Me.lblAltFirst.Text = "Alternate First Name:"
        '
        'lblSponsorName
        '
        Me.lblSponsorName.AutoSize = True
        Me.lblSponsorName.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSponsorName.Location = New System.Drawing.Point(25, 90)
        Me.lblSponsorName.Name = "lblSponsorName"
        Me.lblSponsorName.Size = New System.Drawing.Size(109, 14)
        Me.lblSponsorName.TabIndex = 45
        Me.lblSponsorName.Text = "Sponsor Full Name:"
        '
        'lblSponsorID
        '
        Me.lblSponsorID.AutoSize = True
        Me.lblSponsorID.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSponsorID.Location = New System.Drawing.Point(25, 48)
        Me.lblSponsorID.Name = "lblSponsorID"
        Me.lblSponsorID.Size = New System.Drawing.Size(68, 14)
        Me.lblSponsorID.TabIndex = 43
        Me.lblSponsorID.Text = "Sponsor ID:"
        '
        'tbPhoneNum
        '
        Me.tbPhoneNum.Location = New System.Drawing.Point(149, 400)
        Me.tbPhoneNum.Name = "tbPhoneNum"
        Me.tbPhoneNum.Size = New System.Drawing.Size(219, 22)
        Me.tbPhoneNum.TabIndex = 48
        '
        'tbAddress
        '
        Me.tbAddress.Location = New System.Drawing.Point(149, 220)
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.Size = New System.Drawing.Size(219, 22)
        Me.tbAddress.TabIndex = 42
        '
        'tbSponsorEmail
        '
        Me.tbSponsorEmail.Location = New System.Drawing.Point(149, 173)
        Me.tbSponsorEmail.Name = "tbSponsorEmail"
        Me.tbSponsorEmail.Size = New System.Drawing.Size(219, 22)
        Me.tbSponsorEmail.TabIndex = 41
        '
        'tbSponsorAFN
        '
        Me.tbSponsorAFN.Location = New System.Drawing.Point(149, 130)
        Me.tbSponsorAFN.Name = "tbSponsorAFN"
        Me.tbSponsorAFN.Size = New System.Drawing.Size(100, 22)
        Me.tbSponsorAFN.TabIndex = 40
        '
        'tbSponsorFN
        '
        Me.tbSponsorFN.Location = New System.Drawing.Point(149, 87)
        Me.tbSponsorFN.Name = "tbSponsorFN"
        Me.tbSponsorFN.Size = New System.Drawing.Size(100, 22)
        Me.tbSponsorFN.TabIndex = 38
        '
        'tbSponsorID
        '
        Me.tbSponsorID.Location = New System.Drawing.Point(149, 45)
        Me.tbSponsorID.Name = "tbSponsorID"
        Me.tbSponsorID.Size = New System.Drawing.Size(118, 22)
        Me.tbSponsorID.TabIndex = 37
        '
        'StateRefTableAdapter
        '
        Me.StateRefTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(25, 358)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 14)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Primary Language:"
        '
        'cbPrimaryLanguage
        '
        Me.cbPrimaryLanguage.DataSource = Me.PrimaryLanguageBindingSource
        Me.cbPrimaryLanguage.DisplayMember = "PrimaryLanguage"
        Me.cbPrimaryLanguage.FormattingEnabled = True
        Me.cbPrimaryLanguage.Location = New System.Drawing.Point(149, 355)
        Me.cbPrimaryLanguage.Name = "cbPrimaryLanguage"
        Me.cbPrimaryLanguage.Size = New System.Drawing.Size(121, 22)
        Me.cbPrimaryLanguage.TabIndex = 57
        Me.cbPrimaryLanguage.ValueMember = "PrimaryLanguage"
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
        'AddSponsorInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(394, 463)
        Me.Controls.Add(Me.cbPrimaryLanguage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbState)
        Me.Controls.Add(Me.lbl_State)
        Me.Controls.Add(Me.lbl_City)
        Me.Controls.Add(Me.btnEnterSponInfo)
        Me.Controls.Add(Me.lblInsertSponsorInfoInfo)
        Me.Controls.Add(Me.tbCity)
        Me.Controls.Add(Me.tbSponsorLN)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblAltFirst)
        Me.Controls.Add(Me.lblSponsorName)
        Me.Controls.Add(Me.lblSponsorID)
        Me.Controls.Add(Me.tbPhoneNum)
        Me.Controls.Add(Me.tbAddress)
        Me.Controls.Add(Me.tbSponsorEmail)
        Me.Controls.Add(Me.tbSponsorAFN)
        Me.Controls.Add(Me.tbSponsorFN)
        Me.Controls.Add(Me.tbSponsorID)
        Me.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddSponsorInfo"
        Me.Text = "Add Sponsor Information"
        CType(Me.StateRefBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HHKATDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrimaryLanguageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbState As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_State As System.Windows.Forms.Label
    Friend WithEvents lbl_City As System.Windows.Forms.Label
    Friend WithEvents btnEnterSponInfo As System.Windows.Forms.Button
    Friend WithEvents lblInsertSponsorInfoInfo As System.Windows.Forms.Label
    Friend WithEvents tbCity As System.Windows.Forms.TextBox
    Friend WithEvents tbSponsorLN As System.Windows.Forms.TextBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblAltFirst As System.Windows.Forms.Label
    Friend WithEvents lblSponsorName As System.Windows.Forms.Label
    Friend WithEvents lblSponsorID As System.Windows.Forms.Label
    Friend WithEvents tbPhoneNum As System.Windows.Forms.TextBox
    Friend WithEvents tbAddress As System.Windows.Forms.TextBox
    Friend WithEvents tbSponsorEmail As System.Windows.Forms.TextBox
    Friend WithEvents tbSponsorAFN As System.Windows.Forms.TextBox
    Friend WithEvents tbSponsorFN As System.Windows.Forms.TextBox
    Friend WithEvents tbSponsorID As System.Windows.Forms.TextBox
    Friend WithEvents HHKATDataSet As KITHHKAT.HHKATDataSet
    Friend WithEvents StateRefBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StateRefTableAdapter As KITHHKAT.HHKATDataSetTableAdapters.StateRefTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbPrimaryLanguage As System.Windows.Forms.ComboBox
    Friend WithEvents PrimaryLanguageBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrimaryLanguageTableAdapter As KITHHKAT.HHKATDataSetTableAdapters.PrimaryLanguageTableAdapter
End Class
