Class Contact 
    Property Name As string
    Property PhoneNumber As Integer
    Public Sub New(ByVal name as string, ByVal number as Integer)
        Me.Name = name
        Me.PhoneNumber = number
    End Sub


    Overrides Function ToString() As string
        return $"Name: {Me.Name} Number: {Me.PhoneNumber}"
    End Function
    
End Class