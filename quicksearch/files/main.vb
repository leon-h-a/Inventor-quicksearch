Imports System.Runtime.InteropServices
Imports Inventor
Imports Microsoft.Win32

Module main
    Sub showForm()
        Dim shapecreatorform As New form()
        shapecreatorform.Show(New WindowWrapper(CType(g_inventorApplication.MainFrameHWND, IntPtr)))
    End Sub

End Module
