Class MainMenu
    Implements IMenu
    Sub Initial() Implements IMenu.Start
        Console.WriteLine("Hello World!")
        dim repeat as Boolean = true
        Do While repeat
            Console.WriteLine("What would you like to do?")
            Console.WriteLine("[0] Say hello.")
            Console.WriteLine("[0] Add a cat")
            Console.WriteLine("[x] Exit")
            Dim input as string = Console.ReadLine()
            Select Case input
                Case "0"
                    Console.WriteLine("Hello.")
                    AddCat()
                Case "x"
                    Console.WriteLine("Goodbye.")
                    repeat = false
            End Select
        Loop 
    End Sub
    Sub AddCat()
        Console.WriteLine("Name: ")
        dim name as string = Console.ReadLine()
        Console.WriteLine("Favorite Food: ")
        dim favFood as string = Console.ReadLine()
        Console.WriteLine("Age: ")
        dim number as string = Console.ReadLine()
        dim newFeline as Feline = new Feline(name, favFood, Int32.Parse(number))
    End Sub

End Class