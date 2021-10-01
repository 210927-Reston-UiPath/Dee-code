Class Feline
    Property Name As string
    Property PhoneNumber As Integer
    Public Sub New(ByVal name as string, ByVal number as Integer)
        Me.Name = name
        Me.favFood = favoriteFood
        Me.Age = number
    End Sub


    Overrides Function ToString() As string
        return $"Name: {Me.Name} Age: {Me.Age}"+ "yrs old"
    End Function
    
End Class