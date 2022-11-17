<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddChurch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddChurch))
        Me.btnAddChurch = New System.Windows.Forms.Button()
        Me.tbDistrict = New System.Windows.Forms.TextBox()
        Me.tbArea = New System.Windows.Forms.TextBox()
        Me.tbChurchName = New System.Windows.Forms.TextBox()
        Me.tbChurchCode = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblDistrict = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.lblChurchName = New System.Windows.Forms.Label()
        Me.lblChurchCode = New System.Windows.Forms.Label()
        Me.lblAddChurch = New System.Windows.Forms.Label()
        Me.tbCity = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAddChurch
        '
        Me.btnAddChurch.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddChurch.Location = New System.Drawing.Point(111, 255)
        Me.btnAddChurch.Name = "btnAddChurch"
        Me.btnAddChurch.Size = New System.Drawing.Size(100, 20)
        Me.btnAddChurch.TabIndex = 32
        Me.btnAddChurch.Text = "Add Church"
        Me.btnAddChurch.UseVisualStyleBackColor = True
        '
        'tbDistrict
        '
        Me.tbDistrict.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDistrict.Location = New System.Drawing.Point(111, 178)
        Me.tbDistrict.Name = "tbDistrict"
        Me.tbDistrict.Size = New System.Drawing.Size(100, 22)
        Me.tbDistrict.TabIndex = 28
        '
        'tbArea
        '
        Me.tbArea.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbArea.Location = New System.Drawing.Point(111, 136)
        Me.tbArea.Name = "tbArea"
        Me.tbArea.Size = New System.Drawing.Size(100, 22)
        Me.tbArea.TabIndex = 26
        '
        'tbChurchName
        '
        Me.tbChurchName.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbChurchName.Location = New System.Drawing.Point(111, 94)
        Me.tbChurchName.Name = "tbChurchName"
        Me.tbChurchName.Size = New System.Drawing.Size(100, 22)
        Me.tbChurchName.TabIndex = 24
        '
        'tbChurchCode
        '
        Me.tbChurchCode.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbChurchCode.Location = New System.Drawing.Point(111, 53)
        Me.tbChurchCode.Name = "tbChurchCode"
        Me.tbChurchCode.Size = New System.Drawing.Size(100, 22)
        Me.tbChurchCode.TabIndex = 22
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCity.Location = New System.Drawing.Point(21, 221)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(32, 14)
        Me.lblCity.TabIndex = 31
        Me.lblCity.Text = "City:"
        '
        'lblDistrict
        '
        Me.lblDistrict.AutoSize = True
        Me.lblDistrict.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDistrict.Location = New System.Drawing.Point(21, 181)
        Me.lblDistrict.Name = "lblDistrict"
        Me.lblDistrict.Size = New System.Drawing.Size(49, 14)
        Me.lblDistrict.TabIndex = 29
        Me.lblDistrict.Text = "District:"
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblArea.Location = New System.Drawing.Point(21, 139)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(35, 14)
        Me.lblArea.TabIndex = 27
        Me.lblArea.Text = "Area:"
        '
        'lblChurchName
        '
        Me.lblChurchName.AutoSize = True
        Me.lblChurchName.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblChurchName.Location = New System.Drawing.Point(21, 97)
        Me.lblChurchName.Name = "lblChurchName"
        Me.lblChurchName.Size = New System.Drawing.Size(81, 14)
        Me.lblChurchName.TabIndex = 25
        Me.lblChurchName.Text = "Church Name:"
        '
        'lblChurchCode
        '
        Me.lblChurchCode.AutoSize = True
        Me.lblChurchCode.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblChurchCode.Location = New System.Drawing.Point(21, 56)
        Me.lblChurchCode.Name = "lblChurchCode"
        Me.lblChurchCode.Size = New System.Drawing.Size(77, 14)
        Me.lblChurchCode.TabIndex = 23
        Me.lblChurchCode.Text = "Church Code:"
        '
        'lblAddChurch
        '
        Me.lblAddChurch.AutoSize = True
        Me.lblAddChurch.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddChurch.Location = New System.Drawing.Point(12, 9)
        Me.lblAddChurch.Name = "lblAddChurch"
        Me.lblAddChurch.Size = New System.Drawing.Size(209, 23)
        Me.lblAddChurch.TabIndex = 21
        Me.lblAddChurch.Text = "Add Church to Directory"
        '
        'tbCity
        '
        Me.tbCity.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCity.Location = New System.Drawing.Point(111, 218)
        Me.tbCity.Name = "tbCity"
        Me.tbCity.Size = New System.Drawing.Size(100, 22)
        Me.tbCity.TabIndex = 30
        '
        'AddChurch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(230, 296)
        Me.Controls.Add(Me.btnAddChurch)
        Me.Controls.Add(Me.tbDistrict)
        Me.Controls.Add(Me.tbArea)
        Me.Controls.Add(Me.tbChurchName)
        Me.Controls.Add(Me.tbChurchCode)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblDistrict)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.lblChurchName)
        Me.Controls.Add(Me.lblChurchCode)
        Me.Controls.Add(Me.lblAddChurch)
        Me.Controls.Add(Me.tbCity)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddChurch"
        Me.Text = "Add Church"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddChurch As System.Windows.Forms.Button
    Friend WithEvents tbDistrict As System.Windows.Forms.TextBox
    Friend WithEvents tbArea As System.Windows.Forms.TextBox
    Friend WithEvents tbChurchName As System.Windows.Forms.TextBox
    Friend WithEvents tbChurchCode As System.Windows.Forms.TextBox
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblDistrict As System.Windows.Forms.Label
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents lblChurchName As System.Windows.Forms.Label
    Friend WithEvents lblChurchCode As System.Windows.Forms.Label
    Friend WithEvents lblAddChurch As System.Windows.Forms.Label
    Friend WithEvents tbCity As System.Windows.Forms.TextBox
End Class
