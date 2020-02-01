Module Module1

    Sub Main()

        Dim name As String
        Dim MemberId As String
        Dim counter As Integer



        name = ""
        MemberId = ""
        Console.WriteLine("Enter the number of members for which data is to be recorded")
        counter = Console.ReadLine


        FileOpen(1, "c:\filepractice\ABC.txt", OpenMode.Output)
        For count = 1 To counter
            Console.WriteLine("enter your members names")
            name = Console.ReadLine
            Console.WriteLine("enter members id")
            MemberId = Console.ReadLine

            WriteLine(1, name)
            WriteLine(1, MemberId)
        Next

        FileClose(1)
        Console.ReadKey()
    End Sub

End Module
