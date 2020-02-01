Module Module1

    Sub Main()

        Dim name As String
        Dim MemberId As String
        Dim telephonenum As String
        Dim membership As String


        name = ""
        MemberId = ""

        FileOpen(1, "c:\filepractice\ABC.txt", OpenMode.Input)
        FileOpen(2, "c:\filepractice\ABC2.txt", OpenMode.Output)

        While Not EOF(1)
            Input(1, name)
            Input(1, MemberId)
            Console.WriteLine(name)
            Console.WriteLine(MemberId)
            Console.WriteLine("enter your telephone number")
            telephonenum = Console.ReadLine
            Console.WriteLine("enter membership start date")
            membership = Console.ReadLine

            WriteLine(2, name)
            WriteLine(2, MemberId)
            WriteLine(2, telephonenum)
            WriteLine(2, membership)



        End While
        FileClose(2)

        FileClose(1)
        Console.ReadKey()
    End Sub

End Module
