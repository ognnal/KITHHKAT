<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.SponsorInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HHKATDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HHKATDataSet = New KITHHKAT.HHKATDataSet()
        Me.SponseeInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SponseeInfoTableAdapter = New KITHHKAT.HHKATDataSetTableAdapters.SponseeInfoTableAdapter()
        Me.SponsorInfoTableAdapter = New KITHHKAT.HHKATDataSetTableAdapters.SponsorInfoTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HOMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RELATIONSHIPSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CHURCHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SPONSEEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SPONSORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.userName = New System.Windows.Forms.Label()
        CType(Me.SponsorInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HHKATDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HHKATDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SponseeInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SponsorInfoBindingSource
        '
        Me.SponsorInfoBindingSource.DataMember = "SponsorInfo"
        Me.SponsorInfoBindingSource.DataSource = Me.HHKATDataSetBindingSource
        '
        'HHKATDataSetBindingSource
        '
        Me.HHKATDataSetBindingSource.DataSource = Me.HHKATDataSet
        Me.HHKATDataSetBindingSource.Position = 0
        '
        'HHKATDataSet
        '
        Me.HHKATDataSet.DataSetName = "HHKATDataSet"
        Me.HHKATDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SponseeInfoBindingSource
        '
        Me.SponseeInfoBindingSource.DataMember = "SponseeInfo"
        Me.SponseeInfoBindingSource.DataSource = Me.HHKATDataSetBindingSource
        '
        'SponseeInfoTableAdapter
        '
        Me.SponseeInfoTableAdapter.ClearBeforeFill = True
        '
        'SponsorInfoTableAdapter
        '
        Me.SponsorInfoTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MenuStrip1.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HOMEToolStripMenuItem, Me.RELATIONSHIPSToolStripMenuItem, Me.CHURCHToolStripMenuItem, Me.SPONSEEToolStripMenuItem, Me.SPONSORToolStripMenuItem, Me.REPORTSToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.MenuStrip1.Size = New System.Drawing.Size(1234, 24)
        Me.MenuStrip1.TabIndex = 32
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HOMEToolStripMenuItem
        '
        Me.HOMEToolStripMenuItem.Name = "HOMEToolStripMenuItem"
        Me.HOMEToolStripMenuItem.Padding = New System.Windows.Forms.Padding(15, 0, 15, 0)
        Me.HOMEToolStripMenuItem.Size = New System.Drawing.Size(79, 24)
        Me.HOMEToolStripMenuItem.Text = "HOME"
        '
        'RELATIONSHIPSToolStripMenuItem
        '
        Me.RELATIONSHIPSToolStripMenuItem.Name = "RELATIONSHIPSToolStripMenuItem"
        Me.RELATIONSHIPSToolStripMenuItem.Padding = New System.Windows.Forms.Padding(15, 0, 15, 0)
        Me.RELATIONSHIPSToolStripMenuItem.Size = New System.Drawing.Size(131, 24)
        Me.RELATIONSHIPSToolStripMenuItem.Text = "RELATIONSHIPS"
        '
        'CHURCHToolStripMenuItem
        '
        Me.CHURCHToolStripMenuItem.Name = "CHURCHToolStripMenuItem"
        Me.CHURCHToolStripMenuItem.Padding = New System.Windows.Forms.Padding(15, 0, 15, 0)
        Me.CHURCHToolStripMenuItem.Size = New System.Drawing.Size(91, 24)
        Me.CHURCHToolStripMenuItem.Text = "CHURCH"
        '
        'SPONSEEToolStripMenuItem
        '
        Me.SPONSEEToolStripMenuItem.Name = "SPONSEEToolStripMenuItem"
        Me.SPONSEEToolStripMenuItem.Padding = New System.Windows.Forms.Padding(15, 0, 15, 0)
        Me.SPONSEEToolStripMenuItem.Size = New System.Drawing.Size(93, 24)
        Me.SPONSEEToolStripMenuItem.Text = "SPONSEE"
        '
        'SPONSORToolStripMenuItem
        '
        Me.SPONSORToolStripMenuItem.Name = "SPONSORToolStripMenuItem"
        Me.SPONSORToolStripMenuItem.Padding = New System.Windows.Forms.Padding(15, 0, 15, 0)
        Me.SPONSORToolStripMenuItem.Size = New System.Drawing.Size(96, 24)
        Me.SPONSORToolStripMenuItem.Text = "SPONSOR"
        '
        'REPORTSToolStripMenuItem
        '
        Me.REPORTSToolStripMenuItem.Name = "REPORTSToolStripMenuItem"
        Me.REPORTSToolStripMenuItem.Padding = New System.Windows.Forms.Padding(15, 0, 15, 0)
        Me.REPORTSToolStripMenuItem.Size = New System.Drawing.Size(84, 24)
        Me.REPORTSToolStripMenuItem.Text = "ADMIN"
        '
        'userName
        '
        Me.userName.AutoSize = True
        Me.userName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.userName.Location = New System.Drawing.Point(1101, 7)
        Me.userName.Name = "userName"
        Me.userName.Size = New System.Drawing.Size(68, 17)
        Me.userName.TabIndex = 33
        Me.userName.Text = "Username"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1234, 641)
        Me.Controls.Add(Me.userName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KIT HHK-Audit Tool"
        CType(Me.SponsorInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HHKATDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HHKATDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SponseeInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HHKATDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HHKATDataSet As KITHHKAT.HHKATDataSet
    Friend WithEvents SponseeInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SponseeInfoTableAdapter As KITHHKAT.HHKATDataSetTableAdapters.SponseeInfoTableAdapter
    Friend WithEvents UserCreatedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateCreatedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SponsorInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SponsorInfoTableAdapter As KITHHKAT.HHKATDataSetTableAdapters.SponsorInfoTableAdapter
    Friend WithEvents DateCreatedDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserCreatedDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HOMEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CHURCHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SPONSEEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SPONSORToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REPORTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RELATIONSHIPSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents userName As System.Windows.Forms.Label

End Class
