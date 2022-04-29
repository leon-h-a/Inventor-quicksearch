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
        Me.filesList = New System.Windows.Forms.ListBox()
        Me.buttonOpen = New System.Windows.Forms.Button()
        Me.buttonPlace = New System.Windows.Forms.Button()
        Me.projectsList = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 38)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(164, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(9, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "File name:"
        '
        'filesList
        '
        Me.filesList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.filesList.FormattingEnabled = True
        Me.filesList.Location = New System.Drawing.Point(12, 64)
        Me.filesList.Name = "filesList"
        Me.filesList.Size = New System.Drawing.Size(335, 537)
        Me.filesList.TabIndex = 2
        '
        'buttonOpen
        '
        Me.buttonOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.buttonOpen.Location = New System.Drawing.Point(11, 607)
        Me.buttonOpen.Name = "buttonOpen"
        Me.buttonOpen.Size = New System.Drawing.Size(165, 34)
        Me.buttonOpen.TabIndex = 3
        Me.buttonOpen.Text = "Open"
        Me.buttonOpen.UseVisualStyleBackColor = True
        '
        'buttonPlace
        '
        Me.buttonPlace.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.buttonPlace.Location = New System.Drawing.Point(182, 607)
        Me.buttonPlace.Name = "buttonPlace"
        Me.buttonPlace.Size = New System.Drawing.Size(165, 34)
        Me.buttonPlace.TabIndex = 4
        Me.buttonPlace.Text = "Place"
        Me.buttonPlace.UseVisualStyleBackColor = True
        '
        'projectsList
        '
        Me.projectsList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.projectsList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.projectsList.FormattingEnabled = True
        Me.projectsList.Location = New System.Drawing.Point(181, 37)
        Me.projectsList.Name = "projectsList"
        Me.projectsList.Size = New System.Drawing.Size(164, 21)
        Me.projectsList.TabIndex = 5
        '
        'form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 653)
        Me.Controls.Add(Me.projectsList)
        Me.Controls.Add(Me.buttonPlace)
        Me.Controls.Add(Me.buttonOpen)
        Me.Controls.Add(Me.filesList)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "form"
        Me.Text = "Quick Search"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents filesList As Windows.Forms.ListBox
    Friend WithEvents buttonOpen As Windows.Forms.Button
    Friend WithEvents buttonPlace As Windows.Forms.Button
    Friend WithEvents projectsList As Windows.Forms.ComboBox
End Class
