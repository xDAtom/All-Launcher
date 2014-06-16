Imports System.IO

Public Class Form1
    Dim itemcount As Integer = -1
    Dim itemExes() As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Computer.Screen.Bounds.Width < 800 Or My.Computer.Screen.Bounds.Height < 600 Then
            MsgBox("Your system does not meet the requirements to run this program:" & vbCrLf & _
                   "Screen resolution must be 800x600 or higher", MsgBoxStyle.Critical, "FATAL ERROR")
            End
        End If
        Me.Location = New Point(0, 0)
        Me.Size = New Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        WindowContent.Size = New Size(Me.Width - 24, Me.Height - 60)
        ItemBox.Location = New Point((WindowContent.Width - ItemBox.Width) / 2, (WindowContent.Height - 437) / 2)
        EditItemsButton.Location = New Point(ItemBox.Location.X + ItemBox.Width - EditItemsButton.Width, ItemBox.Location.Y + 43)
        Launch.Location = New Point((WindowContent.Width - Launch.Width) / 2, EditItemsButton.Location.Y + 143)
        ItemBox.Items.Clear()
        Dim current_directory As New IO.DirectoryInfo(Directory.GetCurrentDirectory())
        Dim files_in_directory As IO.FileInfo() = current_directory.GetFiles()
        For Each file As IO.FileInfo In files_in_directory
            If file.Name.Contains("item_") And file.Name.Contains(".item") Then
                Try
                    Dim ItemReader As StreamReader = New StreamReader(file.Name)
                    itemcount += 1
                    ReDim itemExes(itemcount)
                    ItemBox.Items.Insert(0, ItemReader.ReadLine())
                    itemExes(itemcount) = ItemReader.ReadLine()
                    ItemReader.Close()
                Catch : End Try
            End If
        Next file
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                End
            Catch
                End
            Finally
                End
            End Try
        End If
    End Sub

    Private Sub MinimizeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinimizeButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub EditItemsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditItemsButton.Click
        EditItemsPanel.Visible = True
        EditItemsPanel.Location = New Point(ItemBox.Location.X - 4, (WindowContent.Height - EditItemsPanel.Height) / 2)
        NameTextBox.Enabled = False : NameTextBox.Text = ""
        ExeTextBox.Enabled = False : ExeTextBox.Text = ""
        PopupBrowseButton.Enabled = False : Apply.Enabled = False
        PopupItemsList.Items.Clear()
        For k = 0 To itemcount
            PopupItemsList.Items.Add(ItemBox.Items.Item(k))
        Next k
    End Sub

    Private Sub PopupCloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PopupCloseButton.Click
        EditItemsPanel.Visible = False
        ItemBox.Items.Clear()
        For k = 0 To itemcount
            ItemBox.Items.Add(PopupItemsList.Items.Item(k))
        Next k
    End Sub

    Private Sub PopupBrowseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PopupBrowseButton.Click
        Dim SelectFileDialog As New OpenFileDialog
        SelectFileDialog.CheckFileExists = True
        SelectFileDialog.Filter = "Executable Files|*.exe|All Files|*.*"
        If SelectFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            ExeTextBox.Text = SelectFileDialog.FileName
        End If
    End Sub

    Private Sub CreateNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateNew.Click
        NameTextBox.Enabled = True : NameTextBox.Text = ""
        ExeTextBox.Enabled = True: ExeTextBox.Text = ""
        PopupBrowseButton.Enabled = True : Apply.Enabled = True
    End Sub

    Private Sub Apply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Apply.Click
        Dim ItemWriter As StreamWriter = New StreamWriter("item_" & LCase(NameTextBox.Text) & ".item")
        ItemWriter.WriteLine(NameTextBox.Text)
        ItemWriter.Write(ExeTextBox.Text)
        ItemWriter.Close()
        PopupItemsList.Items.Clear() : ItemBox.Items.Clear() : itemcount = -1
        Dim current_directory As New IO.DirectoryInfo(Directory.GetCurrentDirectory())
        Dim files_in_directory As IO.FileInfo() = current_directory.GetFiles()
        For Each file As IO.FileInfo In files_in_directory
            If file.Name.Contains("item_") And file.Name.Contains(".item") Then
                Try
                    Dim ItemReader As StreamReader = New StreamReader(file.Name)
                    itemcount += 1
                    ReDim itemExes(itemcount)
                    PopupItemsList.Items.Insert(0, ItemReader.ReadLine())
                    itemExes(itemcount) = ItemReader.ReadLine()
                    ItemReader.Close()
                Catch : End Try
            End If
        Next file
    End Sub

    Private Sub RawEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RawEdit.Click
        Process.Start("explorer.exe", Directory.GetCurrentDirectory)
    End Sub

    Private Sub Launch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Launch.Click
        Try
            Process.Start(itemExes(ItemBox.SelectedIndex))
            Try
                End
            Catch
                End
            Finally
                End
            End Try
        Catch : End Try
    End Sub

    Private Sub RemoveSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveSelect.Click
        Dim deletion As String = PopupItemsList.SelectedItem()
        If MsgBox("Are you sure you want to delete " & deletion & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            File.Delete("item_" & LCase(deletion) & ".item")
            PopupItemsList.Items.Remove(deletion)
            itemcount -= 1
        End If
    End Sub
End Class
