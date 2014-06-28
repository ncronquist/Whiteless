Public Class Whitless

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveWhitespace.Click

        Dim FileName As String
        Dim WhitelessFile As String
        Dim StringReader As String
        Dim FileReader As System.IO.StreamReader
        Dim FileWriter As System.IO.StreamWriter

        FileName = tbFileName.Text
        'FileReader = My.Computer.FileSystem.OpenTextFileReader(FileName)

        If cbOverwriteFile.Checked Then
            WhitelessFile = FileName
        Else
            WhitelessFile = FileName.Substring(0, InStrRev(FileName, ".") - 1) + " - Whiteless" + FileName.Substring(InStrRev(FileName, ".") - 1, FileName.Length - InStrRev(FileName, ".") + 1)
        End If

        FileWriter = New System.IO.StreamWriter(WhitelessFile, False)

        ' Create a file reader to open the text file
        FileReader = My.Computer.FileSystem.OpenTextFileReader(FileName)

        Do While Not FileReader.EndOfStream
            StringReader = FileReader.ReadLine()
            If cbRemoveWordWS.Checked Then StringReader = StringReader.Replace(" ", "") ' Remove word whitespace
            If cbRemoveLineWS.Checked Then StringReader = StringReader.Trim() ' Remove line whitespace

            If cbRemoveAllWS.Checked Then
                FileWriter.Write(StringReader) ' Remove all whitespace; Word whitespace has already removed all whitespace on lines; this removes all returns
            Else
                If cbRemoveBlankLines.Checked Then
                    If StringReader.Trim.Length > 0 Then 'Checks for blank lines and doesn't write them
                        FileWriter.WriteLine(StringReader)
                    End If
                Else
                    FileWriter.WriteLine(StringReader)
                End If
            End If
        Loop

        '*** Close the file reader/writers
        FileReader.Close()
        FileWriter.Close()

        MessageBox.Show("File Whitelessed!", "Whiteless")

    End Sub

    Private Sub btnChooseFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChooseFile.Click

        'Open the file search dialog and set the initial search directory
        OpenFileDialog1.Title = "Please Select a File"
        OpenFileDialog1.InitialDirectory = "C:temp"
        OpenFileDialog1.ShowDialog()

    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

        Dim s As System.IO.Stream

        s = OpenFileDialog1.OpenFile()
        tbFileName.Text = OpenFileDialog1.FileName.ToString()
        s.Close()

    End Sub

    Private Sub cbRemoveAllWS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbRemoveAllWS.CheckedChanged
        If cbRemoveAllWS.Checked Then

            cbRemoveBlankLines.Enabled = False
            cbRemoveBlankLines.Checked = True

            cbRemoveLineWS.Enabled = False
            cbRemoveLineWS.Checked = True

            cbRemoveWordWS.Enabled = False
            cbRemoveWordWS.Checked = True

        ElseIf Not cbRemoveAllWS.Checked Then

            cbRemoveBlankLines.Enabled = True
            cbRemoveBlankLines.Checked = False

            cbRemoveLineWS.Enabled = True
            cbRemoveLineWS.Checked = False

            cbRemoveWordWS.Enabled = True
            cbRemoveWordWS.Checked = False

        End If
    End Sub

    Private Sub cbRemoveLineWS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbRemoveLineWS.CheckedChanged
        If cbRemoveBlankLines.Checked AndAlso cbRemoveLineWS.Checked AndAlso cbRemoveWordWS.Checked Then
            cbRemoveAllWS.Checked = True
        End If
    End Sub

    Private Sub cbRemoveBlankLines_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbRemoveBlankLines.CheckedChanged
        If cbRemoveBlankLines.Checked AndAlso cbRemoveLineWS.Checked AndAlso cbRemoveWordWS.Checked Then
            cbRemoveAllWS.Checked = True
        End If
    End Sub

    Private Sub cbRemoveWordWS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbRemoveWordWS.CheckedChanged
        If cbRemoveBlankLines.Checked AndAlso cbRemoveLineWS.Checked AndAlso cbRemoveWordWS.Checked Then
            cbRemoveAllWS.Checked = True
        End If
    End Sub

End Class
