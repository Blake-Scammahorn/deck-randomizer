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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDeckName = New System.Windows.Forms.Label()
        Me.DecksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CardsDataSet = New OnYourOwn12.CardsDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblOwner = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblColors = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.linkDecklist = New System.Windows.Forms.LinkLabel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblCmdr = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radMichael = New System.Windows.Forms.RadioButton()
        Me.radNepsWife = New System.Windows.Forms.RadioButton()
        Me.radNate = New System.Windows.Forms.RadioButton()
        Me.radTim = New System.Windows.Forms.RadioButton()
        Me.radBlake = New System.Windows.Forms.RadioButton()
        Me.btnRand = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.DecksTableAdapter = New OnYourOwn12.CardsDataSetTableAdapters.decksTableAdapter()
        Me.TableAdapterManager = New OnYourOwn12.CardsDataSetTableAdapters.TableAdapterManager()
        CType(Me.DecksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Deck Name:"
        '
        'lblDeckName
        '
        Me.lblDeckName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDeckName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DecksBindingSource, "Deckname", True))
        Me.lblDeckName.Location = New System.Drawing.Point(134, 33)
        Me.lblDeckName.Name = "lblDeckName"
        Me.lblDeckName.Size = New System.Drawing.Size(411, 22)
        Me.lblDeckName.TabIndex = 1
        '
        'DecksBindingSource
        '
        Me.DecksBindingSource.DataMember = "decks"
        Me.DecksBindingSource.DataSource = Me.CardsDataSet
        '
        'CardsDataSet
        '
        Me.CardsDataSet.DataSetName = "CardsDataSet"
        Me.CardsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Owner:"
        '
        'lblOwner
        '
        Me.lblOwner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOwner.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DecksBindingSource, "owner", True))
        Me.lblOwner.Location = New System.Drawing.Point(134, 67)
        Me.lblOwner.Name = "lblOwner"
        Me.lblOwner.Size = New System.Drawing.Size(411, 22)
        Me.lblOwner.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Colors:"
        '
        'lblColors
        '
        Me.lblColors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblColors.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DecksBindingSource, "Colors", True))
        Me.lblColors.Location = New System.Drawing.Point(134, 98)
        Me.lblColors.Name = "lblColors"
        Me.lblColors.Size = New System.Drawing.Size(411, 22)
        Me.lblColors.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.linkDecklist)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lblCmdr)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblDeckName)
        Me.GroupBox1.Controls.Add(Me.lblColors)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblOwner)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 155)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(569, 216)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Result"
        '
        'linkDecklist
        '
        Me.linkDecklist.AutoSize = True
        Me.linkDecklist.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DecksBindingSource, "Link", True))
        Me.linkDecklist.Location = New System.Drawing.Point(130, 170)
        Me.linkDecklist.Name = "linkDecklist"
        Me.linkDecklist.Size = New System.Drawing.Size(90, 20)
        Me.linkDecklist.TabIndex = 9
        Me.linkDecklist.TabStop = True
        Me.linkDecklist.Text = "Link to Deck"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 170)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Link to Decklist:"
        '
        'lblCmdr
        '
        Me.lblCmdr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCmdr.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DecksBindingSource, "Commanders", True))
        Me.lblCmdr.Location = New System.Drawing.Point(134, 132)
        Me.lblCmdr.Name = "lblCmdr"
        Me.lblCmdr.Size = New System.Drawing.Size(411, 22)
        Me.lblCmdr.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Commander(s):"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radMichael)
        Me.GroupBox2.Controls.Add(Me.radNepsWife)
        Me.GroupBox2.Controls.Add(Me.radNate)
        Me.GroupBox2.Controls.Add(Me.radTim)
        Me.GroupBox2.Controls.Add(Me.radBlake)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(387, 126)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Current User"
        '
        'radMichael
        '
        Me.radMichael.AutoSize = True
        Me.radMichael.Location = New System.Drawing.Point(134, 57)
        Me.radMichael.Name = "radMichael"
        Me.radMichael.Size = New System.Drawing.Size(82, 24)
        Me.radMichael.TabIndex = 3
        Me.radMichael.Text = "&Michael"
        Me.radMichael.UseVisualStyleBackColor = True
        '
        'radNepsWife
        '
        Me.radNepsWife.AutoSize = True
        Me.radNepsWife.Location = New System.Drawing.Point(134, 27)
        Me.radNepsWife.Name = "radNepsWife"
        Me.radNepsWife.Size = New System.Drawing.Size(54, 24)
        Me.radNepsWife.TabIndex = 1
        Me.radNepsWife.Text = "&Nat"
        Me.radNepsWife.UseVisualStyleBackColor = True
        '
        'radNate
        '
        Me.radNate.AutoSize = True
        Me.radNate.Location = New System.Drawing.Point(7, 89)
        Me.radNate.Name = "radNate"
        Me.radNate.Size = New System.Drawing.Size(62, 24)
        Me.radNate.TabIndex = 4
        Me.radNate.Text = "Nat&e"
        Me.radNate.UseVisualStyleBackColor = True
        '
        'radTim
        '
        Me.radTim.AutoSize = True
        Me.radTim.Location = New System.Drawing.Point(7, 58)
        Me.radTim.Name = "radTim"
        Me.radTim.Size = New System.Drawing.Size(55, 24)
        Me.radTim.TabIndex = 2
        Me.radTim.Text = "&Tim"
        Me.radTim.UseVisualStyleBackColor = True
        '
        'radBlake
        '
        Me.radBlake.AutoSize = True
        Me.radBlake.Checked = True
        Me.radBlake.Location = New System.Drawing.Point(7, 27)
        Me.radBlake.Name = "radBlake"
        Me.radBlake.Size = New System.Drawing.Size(66, 24)
        Me.radBlake.TabIndex = 0
        Me.radBlake.TabStop = True
        Me.radBlake.Text = "&Blake"
        Me.radBlake.UseVisualStyleBackColor = True
        '
        'btnRand
        '
        Me.btnRand.Location = New System.Drawing.Point(435, 38)
        Me.btnRand.Name = "btnRand"
        Me.btnRand.Size = New System.Drawing.Size(108, 27)
        Me.btnRand.TabIndex = 10
        Me.btnRand.Text = "&Randomize"
        Me.btnRand.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(435, 76)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(108, 27)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'DecksTableAdapter
        '
        Me.DecksTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.decksTableAdapter = Me.DecksTableAdapter
        Me.TableAdapterManager.UpdateOrder = OnYourOwn12.CardsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 383)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRand)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.Text = "Deck Randomizer"
        CType(Me.DecksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblDeckName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblOwner As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblColors As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radMichael As RadioButton
    Friend WithEvents radNepsWife As RadioButton
    Friend WithEvents radNate As RadioButton
    Friend WithEvents radTim As RadioButton
    Friend WithEvents radBlake As RadioButton
    Friend WithEvents linkDecklist As LinkLabel
    Friend WithEvents Label9 As Label
    Friend WithEvents lblCmdr As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnRand As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents CardsDataSet As CardsDataSet
    Friend WithEvents DecksBindingSource As BindingSource
    Friend WithEvents DecksTableAdapter As CardsDataSetTableAdapters.decksTableAdapter
    Friend WithEvents TableAdapterManager As CardsDataSetTableAdapters.TableAdapterManager
End Class
