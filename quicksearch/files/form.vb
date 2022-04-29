Imports System.Text.RegularExpressions

Public Class form
    Dim definedProjects As New Collection()
    Private Sub form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Get all project file names and append to drowdown select menu (preselected project is the currently active project)
        For Each project In g_inventorApplication.DesignProjectManager.DesignProjects
            definedProjects.Add(project)
            Me.projectsList.Items.Add(project.Name)
        Next
        Me.projectsList.Text = definedProjects(1).Name
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'Get full path of the project file selected from the dropdown
        Dim selectedProjectIndex As Integer
        Dim projectPath As String
        selectedProjectIndex = Me.projectsList.SelectedIndex
        'If selectedProjectIndex = -1 Then MsgBox("Select correct project name") Else filesList.Items.Add(definedProjects(selectedProjectIndex + 1).FullFileName)
        If selectedProjectIndex = -1 Then MsgBox("Select correct project name") Else projectPath = definedProjects(selectedProjectIndex + 1).FullFileName

        'Regex remove everything after (and including) the last backslash
        Dim rgx As Regex = New Regex(".[^\\]+$")
        Dim cleanPath As String = rgx.Replace(projectPath, "")

        'Get all subdirectories below the master folder object
        Dim mainDir = New oFolder()
        GetDirectories(cleanPath)
    End Sub

    Sub GetDirectories(path As String)
        For Each directory As String In IO.Directory.GetDirectories(path)

            ' Todo: instantiate folder and file objects and add them to the master folder object created above

            'Dim rgx As Regex = New Regex("[^\\]+$")
            filesList.Items.Add(directory)
            MsgBox(directory)
            GetDirectories(directory)
        Next
    End Sub
End Class