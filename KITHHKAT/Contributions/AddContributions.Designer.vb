<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddContributions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddContributions))
        Me.lblRelationshipID = New System.Windows.Forms.Label()
        Me.lblSponsorName = New System.Windows.Forms.Label()
        Me.lblSponseeName = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.tbAmount = New System.Windows.Forms.TextBox()
        Me.btnDonation = New System.Windows.Forms.Button()
        Me.tbRelationshipID = New System.Windows.Forms.TextBox()
        Me.tbSponsorName = New System.Windows.Forms.TextBox()
        Me.tbSponseeName = New System.Windows.Forms.TextBox()
        Me.dgvContributions = New System.Windows.Forms.DataGridView()
        Me.btnUpdateLetter = New System.Windows.Forms.Button()
        Me.tbLetter = New System.Windows.Forms.TextBox()
        Me.btnUnmatchRelationship = New System.Windows.Forms.Button()
        Me.lblLetterCount = New System.Windows.Forms.Label()
        CType(Me.dgvContributions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRelationshipID
        '
        Me.lblRelationshipID.AutoSize = True
        Me.lblRelationshipID.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblRelationshipID.Location = New System.Drawing.Point(16, 28)
        Me.lblRelationshipID.Name = "lblRelationshipID"
        Me.lblRelationshipID.Size = New System.Drawing.Size(89, 14)
        Me.lblRelationshipID.TabIndex = 0
        Me.lblRelationshipID.Text = "RelationshipID:"
        '
        'lblSponsorName
        '
        Me.lblSponsorName.AutoSize = True
        Me.lblSponsorName.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSponsorName.Location = New System.Drawing.Point(16, 54)
        Me.lblSponsorName.Name = "lblSponsorName"
        Me.lblSponsorName.Size = New System.Drawing.Size(88, 14)
        Me.lblSponsorName.TabIndex = 1
        Me.lblSponsorName.Text = "Sponsor Name:"
        '
        'lblSponseeName
        '
        Me.lblSponseeName.AutoSize = True
        Me.lblSponseeName.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSponseeName.Location = New System.Drawing.Point(16, 80)
        Me.lblSponseeName.Name = "lblSponseeName"
        Me.lblSponseeName.Size = New System.Drawing.Size(89, 14)
        Me.lblSponseeName.TabIndex = 2
        Me.lblSponseeName.Text = "Sponsee Name:"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblAmount.Location = New System.Drawing.Point(535, 28)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(55, 14)
        Me.lblAmount.TabIndex = 3
        Me.lblAmount.Text = "Amount:"
        '
        'tbAmount
        '
        Me.tbAmount.Location = New System.Drawing.Point(596, 25)
        Me.tbAmount.Name = "tbAmount"
        Me.tbAmount.Size = New System.Drawing.Size(100, 20)
        Me.tbAmount.TabIndex = 4
        '
        'btnDonation
        '
        Me.btnDonation.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnDonation.Location = New System.Drawing.Point(596, 54)
        Me.btnDonation.Name = "btnDonation"
        Me.btnDonation.Size = New System.Drawing.Size(100, 20)
        Me.btnDonation.TabIndex = 5
        Me.btnDonation.Text = "Enter Donation"
        Me.btnDonation.UseVisualStyleBackColor = True
        '
        'tbRelationshipID
        '
        Me.tbRelationshipID.Location = New System.Drawing.Point(111, 25)
        Me.tbRelationshipID.Name = "tbRelationshipID"
        Me.tbRelationshipID.ReadOnly = True
        Me.tbRelationshipID.Size = New System.Drawing.Size(121, 20)
        Me.tbRelationshipID.TabIndex = 6
        '
        'tbSponsorName
        '
        Me.tbSponsorName.Location = New System.Drawing.Point(111, 51)
        Me.tbSponsorName.Name = "tbSponsorName"
        Me.tbSponsorName.ReadOnly = True
        Me.tbSponsorName.Size = New System.Drawing.Size(121, 20)
        Me.tbSponsorName.TabIndex = 7
        '
        'tbSponseeName
        '
        Me.tbSponseeName.Location = New System.Drawing.Point(111, 77)
        Me.tbSponseeName.Name = "tbSponseeName"
        Me.tbSponseeName.ReadOnly = True
        Me.tbSponseeName.Size = New System.Drawing.Size(121, 20)
        Me.tbSponseeName.TabIndex = 8
        '
        'dgvContributions
        '
        Me.dgvContributions.AllowUserToAddRows = False
        Me.dgvContributions.AllowUserToDeleteRows = False
        Me.dgvContributions.AllowUserToOrderColumns = True
        Me.dgvContributions.AllowUserToResizeColumns = False
        Me.dgvContributions.AllowUserToResizeRows = False
        Me.dgvContributions.BackgroundColor = System.Drawing.SystemColors.GrayText
        Me.dgvContributions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContributions.Location = New System.Drawing.Point(12, 109)
        Me.dgvContributions.Name = "dgvContributions"
        Me.dgvContributions.ReadOnly = True
        Me.dgvContributions.RowHeadersVisible = False
        Me.dgvContributions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvContributions.Size = New System.Drawing.Size(684, 399)
        Me.dgvContributions.TabIndex = 9
        '
        'btnUpdateLetter
        '
        Me.btnUpdateLetter.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnUpdateLetter.Location = New System.Drawing.Point(339, 51)
        Me.btnUpdateLetter.Name = "btnUpdateLetter"
        Me.btnUpdateLetter.Size = New System.Drawing.Size(100, 20)
        Me.btnUpdateLetter.TabIndex = 10
        Me.btnUpdateLetter.Text = "Update Letter"
        Me.btnUpdateLetter.UseVisualStyleBackColor = True
        '
        'tbLetter
        '
        Me.tbLetter.Location = New System.Drawing.Point(396, 25)
        Me.tbLetter.Name = "tbLetter"
        Me.tbLetter.Size = New System.Drawing.Size(43, 20)
        Me.tbLetter.TabIndex = 11
        '
        'btnUnmatchRelationship
        '
        Me.btnUnmatchRelationship.BackColor = System.Drawing.Color.LightSalmon
        Me.btnUnmatchRelationship.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUnmatchRelationship.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnmatchRelationship.Location = New System.Drawing.Point(12, 511)
        Me.btnUnmatchRelationship.Name = "btnUnmatchRelationship"
        Me.btnUnmatchRelationship.Size = New System.Drawing.Size(107, 19)
        Me.btnUnmatchRelationship.TabIndex = 12
        Me.btnUnmatchRelationship.Text = "Unmatch Relationship"
        Me.btnUnmatchRelationship.UseVisualStyleBackColor = False
        '
        'lblLetterCount
        '
        Me.lblLetterCount.AutoSize = True
        Me.lblLetterCount.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblLetterCount.Location = New System.Drawing.Point(312, 28)
        Me.lblLetterCount.Name = "lblLetterCount"
        Me.lblLetterCount.Size = New System.Drawing.Size(78, 14)
        Me.lblLetterCount.TabIndex = 13
        Me.lblLetterCount.Text = "Letter Count:"
        '
        'AddContributions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(708, 542)
        Me.Controls.Add(Me.lblLetterCount)
        Me.Controls.Add(Me.btnUnmatchRelationship)
        Me.Controls.Add(Me.tbLetter)
        Me.Controls.Add(Me.btnUpdateLetter)
        Me.Controls.Add(Me.dgvContributions)
        Me.Controls.Add(Me.tbSponseeName)
        Me.Controls.Add(Me.tbSponsorName)
        Me.Controls.Add(Me.tbRelationshipID)
        Me.Controls.Add(Me.btnDonation)
        Me.Controls.Add(Me.tbAmount)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblSponseeName)
        Me.Controls.Add(Me.lblSponsorName)
        Me.Controls.Add(Me.lblRelationshipID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddContributions"
        Me.Text = "Contributions"
        CType(Me.dgvContributions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRelationshipID As System.Windows.Forms.Label
    Friend WithEvents lblSponsorName As System.Windows.Forms.Label
    Friend WithEvents lblSponseeName As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents tbAmount As System.Windows.Forms.TextBox
    Friend WithEvents btnDonation As System.Windows.Forms.Button
    Friend WithEvents tbRelationshipID As System.Windows.Forms.TextBox
    Friend WithEvents tbSponsorName As System.Windows.Forms.TextBox
    Friend WithEvents tbSponseeName As System.Windows.Forms.TextBox
    Friend WithEvents dgvContributions As System.Windows.Forms.DataGridView
    Friend WithEvents btnUpdateLetter As System.Windows.Forms.Button
    Friend WithEvents tbLetter As System.Windows.Forms.TextBox
    Friend WithEvents btnUnmatchRelationship As System.Windows.Forms.Button
    Friend WithEvents lblLetterCount As System.Windows.Forms.Label
End Class
