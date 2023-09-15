Imports System.IO
Imports Microsoft.Management.Infrastructure
Imports System.Management
Imports System.Net
Imports System.Linq
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Net.NetworkInformation
Imports Microsoft.VisualBasic.FileIO

Public Module sub_functions

    Public Function fetch_files(ByVal path_str As String, ByVal list_name As ListBox)
        ' Specify the folder path you want to fetch files from
        list_name.Items.Clear()
        Dim folderPath As String = path_str
        ' Check if the folder exists
        If Directory.Exists(folderPath) Then
            ' Get all files in the folder
            Dim files() As String = Directory.GetFiles(folderPath)
            ' Add each file to the ListBox
            For Each file As String In files
                list_name.Items.Add(Path.GetFileName(file))

            Next
        Else
            MessageBox.Show("Folder does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Function

    Public Function open_file(ByVal NoFile As String, ByVal txtRich As RichTextBox, ByVal SiList As ListBox)
        ' التحقق مما إذا كان هناك عنصر محدد في ListBox
        If SiList.SelectedItem IsNot Nothing Then
            Dim selectedFileName As String = SiList.SelectedItem.ToString()

            ' قراءة محتوى الملف المختار
            Dim filePath As String = IO.Path.Combine(NoFile, selectedFileName)
            If IO.File.Exists(NoFile) Then
                Try
                    ' اقرأ محتوى الملف وعرضه في RichTextBox
                    Dim fileContent As String = IO.File.ReadAllText(NoFile)
                    txtRich.Text = fileContent
                Catch ex As Exception
                    ' إدارة الأخطاء إذا لم يتمكن من قراءة الملف
                    MessageBox.Show("Wrong Way To Read File 🤔")
                End Try
            End If
        End If
    End Function

    Public Function save_file(ByVal NoFile As String, ByVal PoFile As String, ByVal txtRich As String)
        Dim saveFileDialog As New SaveFileDialog()
        ' تعيين تصفية الملفات المتاحة (في هذه الحالة ستكون نصية)
        saveFileDialog.Filter = "Text File (*.txt)|*.txt|BAT File (*.bat)|*.bat|CMD File (*.cmd)|*.cmd|All Files (*.*)|*.*"
        saveFileDialog.InitialDirectory = PoFile
        saveFileDialog.FileName = NoFile
        ' عرض مربع حوار الحفظ وانتظر اختيار المستخدم
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                ' فتح الملف للكتابة وحفظ محتوى RichTextBox فيه
                Using writer As New System.IO.StreamWriter(PoFile & "\" & NoFile)
                    writer.Write(txtRich)
                End Using

                ' إشعار المستخدم بنجاح الحفظ
                MessageBox.Show("File Saved Successfully.", "Done 👍", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                ' إدارة الأخطاء إذا حدث خطأ أثناء الحفظ
                MessageBox.Show("File Not Saved , You Shoud Recheck File Content Again", "Failed 👎", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Function

    Public Function DeleteFileToRecycleBin(ByVal PNoFile As String, ByVal ListItems As ListBox)
        Try
            ' تأكد من أن الملف موجود قبل حذفه
            If File.Exists(PNoFile) Then
                ' استخدم دالة FileSystem.DeleteFile لحذف الملف ونقله إلى سلة المحذوفات
                FileSystem.DeleteFile(PNoFile, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin)
                ' أخيرًا، قم بإزالة العنصر المحدد من ListBox
                ListItems.Items.Remove(PNoFile)
            Else
                ' إذا لم يكن الملف موجودًا، قم بإشعار المستخدم بذلك
                MessageBox.Show("الملف غير موجود.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            ' إدارة الأخطاء إذا حدث خطأ أثناء الحذف
            MessageBox.Show("حدث خطأ أثناء محاولة حذف الملف.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        'Try
        '    ' التأكد من أن الملف موجود قبل حذفه
        '    If File.Exists(filePath) Then
        '        ' إذا كنت تستخدم FileStream لفتح الملف، قم بإغلاقه أولاً
        '        Using fs As FileStream = File.Open(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None)
        '            ' هنا يمكنك القيام بالعمليات اللازمة على الملف إذا كان مفتوحًا
        '            ' في هذا المثال، نقوم بإغلاق الملف فقط
        '        End Using

        '        ' بعد ذلك، قم بحذف الملف ونقله إلى سلة المحذوفات
        '        FileSystem.DeleteFile(filePath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin)
        '        ' أخيرًا، قم بإزالة العنصر المحدد من ListBox
        '        ListBox1.Items.Remove(filePath)
        '    Else
        '        ' إذا لم يكن الملف موجودًا، قم بإشعار المستخدم بذلك
        '        MessageBox.Show("الملف غير موجود.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End If
        'Catch ex As Exception
        '    ' إدارة الأخطاء إذا حدث خطأ أثناء الحذف أو الإغلاق
        '    MessageBox.Show("حدث خطأ أثناء محاولة حذف الملف أو إغلاقه.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

    End Function





End Module
