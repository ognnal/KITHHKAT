﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditHHKContributions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditHHKContributions))
        Me.cbCorrectionReason = New System.Windows.Forms.ComboBox()
        Me.EditContribReasonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HHKATDataSet = New KITHHKAT.HHKATDataSet()
        Me.lblCorrectionReason = New System.Windows.Forms.Label()
        Me.lblContributionDate = New System.Windows.Forms.Label()
        Me.ctpTransactionDate = New System.Windows.Forms.DateTimePicker()
        Me.tbContributionID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbSponsorID = New System.Windows.Forms.TextBox()
        Me.btnDonation = New System.Windows.Forms.Button()
        Me.tbAmount = New System.Windows.Forms.TextBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblRelationshipID = New System.Windows.Forms.Label()
        Me.EditContribReasonTableAdapter = New KITHHKAT.HHKATDataSetTableAdapters.EditContribReasonTableAdapter()
        CType(Me.EditContribReasonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HHKATDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbCorrectionReason
        '
        Me.cbCorrectionReason.DataSource = Me.EditContribReasonBindingSource
        Me.cbCorrectionReason.DisplayMember = "EditContribReason"
        Me.cbCorrectionReason.FormattingEnabled = True
        Me.cbCorrectionReason.Location = New System.Drawing.Point(121, 139)
        Me.cbCorrectionReason.Name = "cbCorrectionReason"
        Me.cbCorrectionReason.Size = New System.Drawing.Size(167, 21)
        Me.cbCorrectionReason.TabIndex = 28
        Me.cbCorrectionReason.ValueMember = "EditContribReason"
        '
        'EditContribReasonBindingSource
        '
        Me.EditContribReasonBindingSource.DataMember = "EditContribReason"
        Me.EditContribReasonBindingSource.DataSource = Me.HHKATDataSet
        '
        'HHKATDataSet
        '
        Me.HHKATDataSet.DataSetName = "HHKATDataSet"
        Me.HHKATDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblCorrectionReason
        '
        Me.lblCorrectionReason.AutoSize = True
        Me.lblCorrectionReason.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCorrectionReason.Location = New System.Drawing.Point(13, 142)
        Me.lblCorrectionReason.Name = "lblCorrectionReason"
        Me.lblCorrectionReason.Size = New System.Drawing.Size(107, 14)
        Me.lblCorrectionReason.TabIndex = 27
        Me.lblCorrectionReason.Text = "Correction Reason:"
        '
        'lblContributionDate
        '
        Me.lblContributionDate.AutoSize = True
        Me.lblContributionDate.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblContributionDate.Location = New System.Drawing.Point(13, 113)
        Me.lblContributionDate.Name = "lblContributionDate"
        Me.lblContributionDate.Size = New System.Drawing.Size(107, 14)
        Me.lblContributionDate.TabIndex = 26
        Me.lblContributionDate.Text = "Contribution Date:"
        '
        'ctpTransactionDate
        '
        Me.ctpTransactionDate.Location = New System.Drawing.Point(121, 107)
        Me.ctpTransactionDate.Name = "ctpTransactionDate"
        Me.ctpTransactionDate.Size = New System.Drawing.Size(167, 20)
        Me.ctpTransactionDate.TabIndex = 25
        '
        'tbContributionID
        '
        Me.tbContributionID.Location = New System.Drawing.Point(121, 43)
        Me.tbContributionID.Name = "tbContributionID"
        Me.tbContributionID.ReadOnly = True
        Me.tbContributionID.Size = New System.Drawing.Size(121, 20)
        Me.tbContributionID.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(13, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 14)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "ContributionID:"
        '
        'tbSponsorID
        '
        Me.tbSponsorID.Location = New System.Drawing.Point(121, 11)
        Me.tbSponsorID.Name = "tbSponsorID"
        Me.tbSponsorID.ReadOnly = True
        Me.tbSponsorID.Size = New System.Drawing.Size(121, 20)
        Me.tbSponsorID.TabIndex = 22
        '
        'btnDonation
        '
        Me.btnDonation.Location = New System.Drawing.Point(188, 176)
        Me.btnDonation.Name = "btnDonation"
        Me.btnDonation.Size = New System.Drawing.Size(100, 20)
        Me.btnDonation.TabIndex = 21
        Me.btnDonation.Text = "Enter Donation"
        Me.btnDonation.UseVisualStyleBackColor = True
        '
        'tbAmount
        '
        Me.tbAmount.Location = New System.Drawing.Point(121, 75)
        Me.tbAmount.Name = "tbAmount"
        Me.tbAmount.Size = New System.Drawing.Size(100, 20)
        Me.tbAmount.TabIndex = 20
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblAmount.Location = New System.Drawing.Point(13, 78)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(55, 14)
        Me.lblAmount.TabIndex = 19
        Me.lblAmount.Text = "Amount:"
        '
        'lblRelationshipID
        '
        Me.lblRelationshipID.AutoSize = True
        Me.lblRelationshipID.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblRelationshipID.Location = New System.Drawing.Point(13, 14)
        Me.lblRelationshipID.Name = "lblRelationshipID"
        Me.lblRelationshipID.Size = New System.Drawing.Size(66, 14)
        Me.lblRelationshipID.TabIndex = 18
        Me.lblRelationshipID.Text = "SponsorID:"
        '
        'EditContribReasonTableAdapter
        '
        Me.EditContribReasonTableAdapter.ClearBeforeFill = True
        '
        'EditHHKContributions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 208)
        Me.Controls.Add(Me.cbCorrectionReason)
        Me.Controls.Add(Me.lblCorrectionReason)
        Me.Controls.Add(Me.lblContributionDate)
        Me.Controls.Add(Me.ctpTransactionDate)
        Me.Controls.Add(Me.tbContributionID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbSponsorID)
        Me.Controls.Add(Me.btnDonation)
        Me.Controls.Add(Me.tbAmount)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblRelationshipID)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditHHKContributions"
        Me.Text = "Edit HHK Contributions"
        CType(Me.EditContribReasonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HHKATDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbCorrectionReason As System.Windows.Forms.ComboBox
    Friend WithEvents lblCorrectionReason As System.Windows.Forms.Label
    Friend WithEvents lblContributionDate As System.Windows.Forms.Label
    Friend WithEvents ctpTransactionDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbContributionID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbSponsorID As System.Windows.Forms.TextBox
    Friend WithEvents btnDonation As System.Windows.Forms.Button
    Friend WithEvents tbAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents lblRelationshipID As System.Windows.Forms.Label
    Friend WithEvents HHKATDataSet As KITHHKAT.HHKATDataSet
    Friend WithEvents EditContribReasonBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EditContribReasonTableAdapter As KITHHKAT.HHKATDataSetTableAdapters.EditContribReasonTableAdapter
End Class
