Imports sub_functions
Public Class Form2
    Public FilesPath As String = Application.StartupPath & "\eXtra"

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fetch_files( FilesPath, ListBox1)
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        selfilename.Text = ListBox1.SelectedItem
        open_file(FilesPath & "\" & ListBox1.SelectedItem, RichTextBox1, ListBox1)
    End Sub

    Private Sub sFile_Click(sender As Object, e As EventArgs) Handles sFile.Click
        Dim pathOfFile = FilesPath
        Dim nameOfFile = selfilename.Text.ToString()
        Dim textOnRich = RichTextBox1.Text.ToString()
        save_file(nameOfFile, pathOfFile, textOnRich)
        fetch_files(FilesPath, ListBox1)
    End Sub

    Private Sub dFile_Click(sender As Object, e As EventArgs) Handles dFile.Click
        selfilename.Text = Nothing
        RichTextBox1.Text = Nothing
        DeleteFileToRecycleBin(FilesPath & "\" & ListBox1.SelectedItem, ListBox1)
        fetch_files(FilesPath, ListBox1)
    End Sub

    Private Sub ListBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseClick
        ToolTip1.SetToolTip(ListBox1, ListBox1.SelectedItem)
    End Sub
End Class