Imports System.Text.RegularExpressions

Public Class form
    Dim definedProjects As New Collection()
    Dim folders As New Collection()
    Dim rgx As New Regex("[^\\]+$")
    Dim topLevelFiles As New Collection()

    Private Sub form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' TODO: implement multiple projects
        'Get all project file names and append to drowdown select menu (preselected project is the currently active project)
        'For Each project In g_inventorApplication.DesignProjectManager.DesignProjects
        '    MsgBox(project.Name)
        '    definedProjects.Add(project)
        '    Me.projectsList.Items.Add(project.Name)
        'Next
        'Me.projectsList.Text = definedProjects(1).Name
        'Get full path of the project file selected from the dropdown
        'Dim selectedProjectIndex As Integer
        'Dim projectPath = "none"
        'selectedProjectIndex = Me.projectsList.SelectedIndex
        'If selectedProjectIndex = -1 Then MsgBox("Select correct project name") Else projectPath = rgx.Replace(definedProjects(selectedProjectIndex + 1).FullFileName, "")
        Me.projectsList.Text = Regex.Match(g_inventorApplication.FileLocations.FileLocationsFile, "[^\\]+$").Value
        getProjectItems(rgx.Replace(g_inventorApplication.FileLocations.FileLocationsFile, ""))
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        filesListView.Items.Clear()
        showRecurs(folders, TextBox1.Text)
    End Sub

    Public Function getProjectItems(projectPath As String) As Integer
        For Each file In IO.Directory.GetFiles(projectPath)
            Dim FileInstance As New oFile()
            FileInstance.Path = file
            FileInstance.Name = file
            FileInstance.Increment = 0
            topLevelFiles.Add(FileInstance)
        Next
        searchRecurs(projectPath, 0)
    End Function

    Public Function searchRecurs(path As String, indentation As Integer) As Integer
        For Each directory In IO.Directory.GetDirectories(path)
            If Not directory.Contains("OldVersion") Then
                Dim FolderInstance As New oFolder()
                FolderInstance.Path = directory
                FolderInstance.Name = directory
                FolderInstance.Increment = indentation

                For Each file In IO.Directory.GetFiles(directory)
                    If Not directory.Contains("FNO") Or Not directory.Contains("LOG") Or Not directory.Contains("OUT") Then
                        Dim FileInstance As New oFile()
                        FileInstance.Path = file
                        FileInstance.Name = file
                        FileInstance.Increment = indentation + 1
                        FolderInstance.AddFile(FileInstance)
                    End If
                Next

                folders.Add(FolderInstance)
                searchRecurs(FolderInstance.Path, FolderInstance.Increment + 1)
            End If
        Next
        Return 0
    End Function

    Public Function showRecurs(folderObject As Collection, matchingString As String) As Integer
        For Each file In topLevelFiles
            If file.Name.Contains(matchingString) Then
                filesListView.Items.Add(file.Name, file.Path)
            End If
        Next

        For Each folder In folderObject
            'filesListView.Items.Add(folder.Name).SubItems.add(folder.Path)

            For Each file In folder.GetFiles()
                If file.Name.Contains(matchingString) Then
                    filesListView.Items.Add(file.Name).subitems.add(file.Path)
                End If
            Next
        Next
        Return 0
    End Function

    Private Sub buttonOpen_Click(sender As Object, e As EventArgs) Handles buttonOpen.Click
        'Dim selectedFiles = New Collection()

        'For Each item In filesList.SelectedItems
        '    selectedFiles.Add(item)
        'Next

        'For Each item In selectedFiles
        '    MsgBox(item.Name)
        'Next
    End Sub

    Private Sub buttonPlace_Click(sender As Object, e As EventArgs) Handles buttonPlace.Click

    End Sub
End Class