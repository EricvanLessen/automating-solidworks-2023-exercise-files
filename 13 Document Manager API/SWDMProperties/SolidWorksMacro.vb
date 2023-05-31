Imports SolidWorks.Interop.sldworks
Imports SolidWorks.Interop.swdocumentmgr
Imports System.Diagnostics

Partial Class SolidWorksMacro

  Public Sub main()

    Dim MyDM As New MyDocMan

    Dim dmDoc As SwDMDocument
    Dim FilePath As String
    FilePath = MyDM.BrowseForDoc()
    dmDoc = MyDM.OpenDoc(FilePath, False)
    If dmDoc Is Nothing Then Exit Sub

    'add/change Description
    MyDM.WriteProp(dmDoc, "Description", "MY DESCRIPTION")

    Dim props As String
    props = MyDM.ReadAllProps(dmDoc)
    Debug.Print(props)

    props = MyDM.ReadConfigProps(dmDoc)
    Debug.Print(props)
    'save the document
    dmDoc.Save()

    'close the document
    dmDoc.CloseDoc()

    Stop
  End Sub


  ''' <summary>
  ''' The SldWorks swApp variable is pre-assigned for you.
  ''' </summary>
  Public swApp As SldWorks


End Class
