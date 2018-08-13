<ComClass(ComClass1.ClassId, ComClass1.InterfaceId, ComClass1.EventsId)> _
Public Class ComClass1

#Region "COM GUIDs"
    ' These  GUIDs provide the COM identity for this class 
    ' and its COM interfaces. If you change them, existing 
    ' clients will no longer be able to access the class.
    Public Const ClassId As String = "2ed97997-9f5c-47d1-8586-a8a98fca788c"
    Public Const InterfaceId As String = "fec9da66-66e7-4157-8c21-5cae2e73fed1"
    Public Const EventsId As String = "c486aa5b-d06d-4274-b569-e79c2d0b9997"
#End Region

    ' A creatable COM class must have a Public Sub New() 
    ' with no parameters, otherwise, the class will not be 
    ' registered in the COM registry and cannot be created 
    ' via CreateObject.
    Public Sub New()
        MyBase.New()
    End Sub

End Class


