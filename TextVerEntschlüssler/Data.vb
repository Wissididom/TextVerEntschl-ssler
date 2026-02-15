Public Class Data

    Public Shared Sub SetData(ByVal data As String)
        _this_data = data
    End Sub

    Public Shared Function GetData() As String
        Return _this_data
    End Function

    Public Shared Sub ClearData()
        _this_data = ""
    End Sub

    Private Shared _this_data As String = ""
End Class
