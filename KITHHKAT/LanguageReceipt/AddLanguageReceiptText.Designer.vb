<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddLanguageReceiptText
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
        Me.rtbReceiptText = New System.Windows.Forms.RichTextBox()
        Me.tbPrimaryLanguage = New System.Windows.Forms.TextBox()
        Me.lblReceiptText = New System.Windows.Forms.Label()
        Me.lblPrimaryLanguage = New System.Windows.Forms.Label()
        Me.btnUpdateLanguageReceiptText = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rtbReceiptText
        '
        Me.rtbReceiptText.Location = New System.Drawing.Point(16, 64)
        Me.rtbReceiptText.Name = "rtbReceiptText"
        Me.rtbReceiptText.Size = New System.Drawing.Size(406, 237)
        Me.rtbReceiptText.TabIndex = 10
        Me.rtbReceiptText.Text = ""
        '
        'tbPrimaryLanguage
        '
        Me.tbPrimaryLanguage.Location = New System.Drawing.Point(77, 12)
        Me.tbPrimaryLanguage.Name = "tbPrimaryLanguage"
        Me.tbPrimaryLanguage.Size = New System.Drawing.Size(100, 20)
        Me.tbPrimaryLanguage.TabIndex = 9
        '
        'lblReceiptText
        '
        Me.lblReceiptText.AutoSize = True
        Me.lblReceiptText.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblReceiptText.Location = New System.Drawing.Point(13, 48)
        Me.lblReceiptText.Name = "lblReceiptText"
        Me.lblReceiptText.Size = New System.Drawing.Size(75, 14)
        Me.lblReceiptText.TabIndex = 8
        Me.lblReceiptText.Text = "Receipt Text:"
        '
        'lblPrimaryLanguage
        '
        Me.lblPrimaryLanguage.AutoSize = True
        Me.lblPrimaryLanguage.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPrimaryLanguage.Location = New System.Drawing.Point(13, 12)
        Me.lblPrimaryLanguage.Name = "lblPrimaryLanguage"
        Me.lblPrimaryLanguage.Size = New System.Drawing.Size(63, 14)
        Me.lblPrimaryLanguage.TabIndex = 7
        Me.lblPrimaryLanguage.Text = "Language:"
        '
        'btnUpdateLanguageReceiptText
        '
        Me.btnUpdateLanguageReceiptText.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnUpdateLanguageReceiptText.Location = New System.Drawing.Point(331, 307)
        Me.btnUpdateLanguageReceiptText.Name = "btnUpdateLanguageReceiptText"
        Me.btnUpdateLanguageReceiptText.Size = New System.Drawing.Size(91, 23)
        Me.btnUpdateLanguageReceiptText.TabIndex = 6
        Me.btnUpdateLanguageReceiptText.Text = "Add Language"
        Me.btnUpdateLanguageReceiptText.UseVisualStyleBackColor = True
        '
        'AddLanguageReceiptText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 342)
        Me.Controls.Add(Me.rtbReceiptText)
        Me.Controls.Add(Me.tbPrimaryLanguage)
        Me.Controls.Add(Me.lblReceiptText)
        Me.Controls.Add(Me.lblPrimaryLanguage)
        Me.Controls.Add(Me.btnUpdateLanguageReceiptText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AddLanguageReceiptText"
        Me.Text = "Add Language Receipt Text"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rtbReceiptText As System.Windows.Forms.RichTextBox
    Friend WithEvents tbPrimaryLanguage As System.Windows.Forms.TextBox
    Friend WithEvents lblReceiptText As System.Windows.Forms.Label
    Friend WithEvents lblPrimaryLanguage As System.Windows.Forms.Label
    Friend WithEvents btnUpdateLanguageReceiptText As System.Windows.Forms.Button
End Class
