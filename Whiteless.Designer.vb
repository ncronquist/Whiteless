<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Whitless
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
        Me.btnRemoveWhitespace = New System.Windows.Forms.Button()
        Me.tbFileName = New System.Windows.Forms.TextBox()
        Me.btnChooseFile = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cbOverwriteFile = New System.Windows.Forms.CheckBox()
        Me.cbRemoveAllWS = New System.Windows.Forms.CheckBox()
        Me.cbRemoveLineWS = New System.Windows.Forms.CheckBox()
        Me.cbRemoveBlankLines = New System.Windows.Forms.CheckBox()
        Me.cbRemoveWordWS = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnRemoveWhitespace
        '
        Me.btnRemoveWhitespace.Location = New System.Drawing.Point(153, 216)
        Me.btnRemoveWhitespace.Name = "btnRemoveWhitespace"
        Me.btnRemoveWhitespace.Size = New System.Drawing.Size(115, 23)
        Me.btnRemoveWhitespace.TabIndex = 0
        Me.btnRemoveWhitespace.Text = "Remove Whitespace"
        Me.btnRemoveWhitespace.UseVisualStyleBackColor = True
        '
        'tbFileName
        '
        Me.tbFileName.Location = New System.Drawing.Point(108, 43)
        Me.tbFileName.Name = "tbFileName"
        Me.tbFileName.Size = New System.Drawing.Size(179, 20)
        Me.tbFileName.TabIndex = 1
        '
        'btnChooseFile
        '
        Me.btnChooseFile.Location = New System.Drawing.Point(27, 40)
        Me.btnChooseFile.Name = "btnChooseFile"
        Me.btnChooseFile.Size = New System.Drawing.Size(75, 23)
        Me.btnChooseFile.TabIndex = 2
        Me.btnChooseFile.Text = "Choose File"
        Me.btnChooseFile.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'cbOverwriteFile
        '
        Me.cbOverwriteFile.AutoSize = True
        Me.cbOverwriteFile.Location = New System.Drawing.Point(41, 222)
        Me.cbOverwriteFile.Name = "cbOverwriteFile"
        Me.cbOverwriteFile.Size = New System.Drawing.Size(90, 17)
        Me.cbOverwriteFile.TabIndex = 7
        Me.cbOverwriteFile.Text = "Overwrite File"
        Me.ToolTip1.SetToolTip(Me.cbOverwriteFile, "Not currently working.")
        Me.cbOverwriteFile.UseVisualStyleBackColor = True
        Me.cbOverwriteFile.Visible = False
        '
        'cbRemoveAllWS
        '
        Me.cbRemoveAllWS.AutoSize = True
        Me.cbRemoveAllWS.Location = New System.Drawing.Point(27, 97)
        Me.cbRemoveAllWS.Name = "cbRemoveAllWS"
        Me.cbRemoveAllWS.Size = New System.Drawing.Size(140, 17)
        Me.cbRemoveAllWS.TabIndex = 8
        Me.cbRemoveAllWS.Text = "Remove All Whitespace"
        Me.ToolTip1.SetToolTip(Me.cbRemoveAllWS, "Removes spaces and line breaks to create a single line of unspaced characters")
        Me.cbRemoveAllWS.UseVisualStyleBackColor = True
        '
        'cbRemoveLineWS
        '
        Me.cbRemoveLineWS.AutoSize = True
        Me.cbRemoveLineWS.Location = New System.Drawing.Point(27, 121)
        Me.cbRemoveLineWS.Name = "cbRemoveLineWS"
        Me.cbRemoveLineWS.Size = New System.Drawing.Size(149, 17)
        Me.cbRemoveLineWS.TabIndex = 9
        Me.cbRemoveLineWS.Text = "Remove Line Whitespace"
        Me.ToolTip1.SetToolTip(Me.cbRemoveLineWS, "Removes spaces before and after each line")
        Me.cbRemoveLineWS.UseVisualStyleBackColor = True
        '
        'cbRemoveBlankLines
        '
        Me.cbRemoveBlankLines.AutoSize = True
        Me.cbRemoveBlankLines.Location = New System.Drawing.Point(27, 145)
        Me.cbRemoveBlankLines.Name = "cbRemoveBlankLines"
        Me.cbRemoveBlankLines.Size = New System.Drawing.Size(124, 17)
        Me.cbRemoveBlankLines.TabIndex = 10
        Me.cbRemoveBlankLines.Text = "Remove Blank Lines"
        Me.ToolTip1.SetToolTip(Me.cbRemoveBlankLines, "Removes blank lines")
        Me.cbRemoveBlankLines.UseVisualStyleBackColor = True
        '
        'cbRemoveWordWS
        '
        Me.cbRemoveWordWS.AutoSize = True
        Me.cbRemoveWordWS.Location = New System.Drawing.Point(27, 169)
        Me.cbRemoveWordWS.Name = "cbRemoveWordWS"
        Me.cbRemoveWordWS.Size = New System.Drawing.Size(155, 17)
        Me.cbRemoveWordWS.TabIndex = 11
        Me.cbRemoveWordWS.Text = "Remove Word Whitespace"
        Me.ToolTip1.SetToolTip(Me.cbRemoveWordWS, "Removes spaces between words on the same line")
        Me.cbRemoveWordWS.UseVisualStyleBackColor = True
        '
        'Whitless
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 261)
        Me.Controls.Add(Me.cbRemoveWordWS)
        Me.Controls.Add(Me.cbRemoveBlankLines)
        Me.Controls.Add(Me.cbRemoveLineWS)
        Me.Controls.Add(Me.cbRemoveAllWS)
        Me.Controls.Add(Me.cbOverwriteFile)
        Me.Controls.Add(Me.btnChooseFile)
        Me.Controls.Add(Me.tbFileName)
        Me.Controls.Add(Me.btnRemoveWhitespace)
        Me.Name = "Whitless"
        Me.Text = "Whiteless"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRemoveWhitespace As System.Windows.Forms.Button
    Friend WithEvents tbFileName As System.Windows.Forms.TextBox
    Friend WithEvents btnChooseFile As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cbOverwriteFile As System.Windows.Forms.CheckBox
    Friend WithEvents cbRemoveAllWS As System.Windows.Forms.CheckBox
    Friend WithEvents cbRemoveLineWS As System.Windows.Forms.CheckBox
    Friend WithEvents cbRemoveBlankLines As System.Windows.Forms.CheckBox
    Friend WithEvents cbRemoveWordWS As System.Windows.Forms.CheckBox

End Class
