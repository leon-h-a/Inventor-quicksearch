Imports System.Text.RegularExpressions

Public Class form
    Dim definedProjects As New Collection()
    Dim folders As New Collection()

    Private Sub form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Get all project file names and append to drowdown select menu (preselected project is the currently active project)
        For Each project In g_inventorApplication.DesignProjectManager.DesignProjects
            definedProjects.Add(project)
            Me.projectsList.Items.Add(project.Name)
        Next
        Me.projectsList.Text = definedProjects(1).Name
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        filesList.Items.Clear()

        'Get full path of the project file selected from the dropdown
        Dim selectedProjectIndex As Integer
        Dim projectPath As String
        selectedProjectIndex = Me.projectsList.SelectedIndex
        Dim rgx As New Regex("[^\\]+$")
        If selectedProjectIndex = -1 Then MsgBox("Select correct project name") Else projectPath = rgx.Replace(definedProjects(selectedProjectIndex + 1).FullFileName, "")

        Dim topLevelFiles As New Collection()

        For Each file In IO.Directory.GetFiles(projectPath)
            Dim FileInstance As New oFile()
            FileInstance.Path = file
            FileInstance.Name = file
            FileInstance.Increment = 0
            topLevelFiles.Add(FileInstance)
        Next
        searchRecurs(projectPath, 0)

        For Each file In topLevelFiles
            filesList.Items.Add(Strings.StrDup(file.Increment, vbTab) & file.Name)
            'Console.WriteLine(Strings.StrDup(file.Increment, " ") & file.Name & vbNewLine)
        Next
        showRecurs(folders)
    End Sub

    Public Function searchRecurs(path As String, indentation As Integer)
        For Each directory In IO.Directory.GetDirectories(path)
            Dim FolderInstance As New oFolder()
            FolderInstance.Path = directory
            FolderInstance.Name = directory
            FolderInstance.Increment = indentation

            For Each file In IO.Directory.GetFiles(directory)
                Dim FileInstance As New oFile()
                FileInstance.Path = file
                FileInstance.Name = file
                FileInstance.Increment = indentation + 1
                FolderInstance.AddFile(FileInstance)
            Next

            folders.Add(FolderInstance)
            searchRecurs(FolderInstance.Path, FolderInstance.Increment + 1)
        Next
        Return 0
    End Function

    Public Function showRecurs(folderObject As Collection)
        Dim folderName As String
        Dim fileName As String

        For Each folder In folderObject
            folderName = Strings.StrDup(folder.Increment, vbTab) & folder.Name
            filesList.Items.Add(folderName)
            'Console.WriteLine(Strings.StrDup(folder.Increment, " ") & folder.Name)
            For Each file In folder.GetFiles()
                fileName = Strings.StrDup(file.Increment, vbTab) & file.Name
                filesList.Items.Add(fileName)
                'Console.WriteLine(Strings.StrDup(file.Increment, " ") & file.Name)
            Next
            'Console.WriteLine()
        Next
        Return 0
    End Function

End Class