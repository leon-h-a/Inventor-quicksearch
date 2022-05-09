<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.buttonOpen = New System.Windows.Forms.Button()
        Me.buttonPlace = New System.Windows.Forms.Button()
        Me.projectsList = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.filesListView = New System.Windows.Forms.ListView()
        Me.fileName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.parentFolder = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(173, 155)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(244, 26)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(171, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Project:"
        '
        'buttonOpen
        '
        Me.buttonOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonOpen.Location = New System.Drawing.Point(573, 1069)
        Me.buttonOpen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.buttonOpen.Name = "buttonOpen"
        Me.buttonOpen.Size = New System.Drawing.Size(248, 52)
        Me.buttonOpen.TabIndex = 3
        Me.buttonOpen.Text = "Open"
        Me.buttonOpen.UseVisualStyleBackColor = True
        '
        'buttonPlace
        '
        Me.buttonPlace.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonPlace.Location = New System.Drawing.Point(317, 1069)
        Me.buttonPlace.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.buttonPlace.Name = "buttonPlace"
        Me.buttonPlace.Size = New System.Drawing.Size(248, 52)
        Me.buttonPlace.TabIndex = 4
        Me.buttonPlace.Text = "Place"
        Me.buttonPlace.UseVisualStyleBackColor = True
        '
        'projectsList
        '
        Me.projectsList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.projectsList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.projectsList.Enabled = False
        Me.projectsList.FormattingEnabled = True
        Me.projectsList.Location = New System.Drawing.Point(173, 64)
        Me.projectsList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.projectsList.Name = "projectsList"
        Me.projectsList.Size = New System.Drawing.Size(244, 28)
        Me.projectsList.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(169, 130)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Partial name:"
        '
        'filesListView
        '
        Me.filesListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.filesListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.fileName, Me.parentFolder})
        Me.filesListView.HideSelection = False
        Me.filesListView.Location = New System.Drawing.Point(18, 237)
        Me.filesListView.Name = "filesListView"
        Me.filesListView.Size = New System.Drawing.Size(803, 824)
        Me.filesListView.TabIndex = 7
        Me.filesListView.UseCompatibleStateImageBehavior = False
        Me.filesListView.View = System.Windows.Forms.View.Details
        '
        'fileName
        '
        Me.fileName.Text = "File Name"
        Me.fileName.Width = 500
        '
        'parentFolder
        '
        Me.parentFolder.Text = "Parent Folder"
        Me.parentFolder.Width = 295
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(455, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(836, 1140)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.filesListView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.projectsList)
        Me.Controls.Add(Me.buttonPlace)
        Me.Controls.Add(Me.buttonOpen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "form"
        Me.Text = "Quick Search"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents buttonOpen As Windows.Forms.Button
    Friend WithEvents buttonPlace As Windows.Forms.Button
    Friend WithEvents projectsList As Windows.Forms.ComboBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents filesListView As Windows.Forms.ListView
    Friend WithEvents fileName As Windows.Forms.ColumnHeader
    Friend WithEvents parentFolder As Windows.Forms.ColumnHeader
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
End Class
