Imports System.Text.RegularExpressions

Public Class form
    Dim definedProjects As New Collection()
    Dim folders As New Collection()
    Dim rgx As New Regex("[^\\]+$")
    Dim topLevelFiles As New Collection()

    Private Sub form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Not g_inventorApplication.ActiveDocumentType = 12291 Then
            buttonPlace.Enabled = False
        End If

        ' todo: implement multiple projects
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
        showRecurs(folders, " ")
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
            FileInstance.ParentFolder = ""
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
                FolderInstance.Name = Regex.Match(directory, "[^\\]+$").Value
                FolderInstance.Increment = indentation

                For Each file In IO.Directory.GetFiles(directory)
                    If Not file.Contains("FNO") And Not file.Contains("LOG") And Not file.Contains("OUT") And Not file.Contains("RSF") And Not file.Contains("nas") Then
                        Dim FileInstance As New oFile()
                        FileInstance.Path = file
                        FileInstance.Name = file
                        FileInstance.ParentFolder = FolderInstance.Name
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
                filesListView.Items.Add(file.Name, file.Path).SubItems.Add(file.ParentFolder)
            End If
        Next

        For Each folder In folderObject
            For Each file In folder.GetFiles()
                If file.Name.Contains(matchingString) Then
                    Dim item As Windows.Forms.ListViewItem = filesListView.Items.Add(file.Name)
                    item.SubItems.Add(file.parentFolder)
                    item.SubItems.Add(file.Path)
                End If
            Next
        Next
        Return 0
    End Function

    Private Sub buttonOpen_Click(sender As Object, e As EventArgs) Handles buttonOpen.Click

        Dim selectedItems As Windows.Forms.ListView.SelectedListViewItemCollection
        selectedItems = filesListView.SelectedItems()

        For Each item In selectedItems
            If item.subitems(2).Text.Contains(".ipt") Or item.subitems(2).Text.Contains(".iam") Or item.subitems(2).Text.Contains(".ipn") Or item.subitems(2).Text.Contains(".dwg") Then
                g_inventorApplication.Documents.Open(item.subitems(2).Text)
            Else
                Process.Start(item.subitems(2).Text)
            End If
        Next

        Me.Close()
    End Sub

    Private Sub buttonPlace_Click(sender As Object, e As EventArgs) Handles buttonPlace.Click
        ' Set a reference to the assembly component definition.
        ' This assumes an assembly document is open.
        Dim oAsmCompDef As Inventor.AssemblyComponentDefinition
        oAsmCompDef = g_inventorApplication.ActiveDocument.ComponentDefinition

        ' Set a reference to the transient geometry object.
        Dim oTG As Inventor.TransientGeometry
        oTG = g_inventorApplication.TransientGeometry

        ' Create the matrix. A new matrix is ​​initialized with an identity matrix.
        Dim oMatrix As Inventor.Matrix
        oMatrix = oTG.CreateMatrix

        ' Set the rotation of the matrix to a 45 degree rotation about the Z axis.
        'Call oMatrix.SetToRotation(3.14159265358979 / 4,
        '                    oTG.CreateVector(0, 1, 0), oTG.CreatePoint(0, 0, 0))

        ' Set the translation portion of the matrix so the part will be positioned
        Call oMatrix.SetTranslation(oTG.CreateVector(0, -100, 0))

        ' Add the occurrence.
        Dim oOcc As Inventor.ComponentOccurrence

        Dim selectedItems As Windows.Forms.ListView.SelectedListViewItemCollection
        selectedItems = filesListView.SelectedItems()
        For Each item In selectedItems
            oOcc = oAsmCompDef.Occurrences.Add(item.subitems(2).Text, oMatrix)
        Next

        Me.Close()
    End Sub

    Private Sub filesListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filesListView.SelectedIndexChanged
        'if one selected and contains '.ipt'
        'thumbnail=image
        'else
        'thumbnail=not available


        'Dim oApprentice As New Inventor.ApprenticeServerComponent()

        'If filesListView.SelectedItems.Count() = 1 Then
        'Dim oApprenticeDoc As Inventor.ApprenticeServerDocument = oApprentice.Open(filesListView.SelectedItems(1).SubItems(2).Text)
        'Dim oThumbnail As stdole.IPictureDisp = oApprenticeDoc.Thumbnail
        'Dim img As Inventor.Image = Inventor.IPictureDispConverter.PictureDispToImage(oThumbnail)



        'doc = apprentice.Open(filesListView.SelectedItems(1).SubItems(2).Text)
        'summaryInfo = doc.PropertySets.Item("Inventor Summary Information")
        'thumbProp = summaryInfo.Item("Thumbnail")
        'thumbnail = thumbProp.Value
        'Dim img As Image = VB6.IPictureDispToImage(thumbnail)

        'Microsoft.VisualBasic.vb
        'End If
    End Sub
End Class