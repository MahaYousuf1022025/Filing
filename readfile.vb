Module Module1

    Sub Main()
        Dim name As String
        Dim MemberId As String


        name = ""
        MemberId = ""

        FileOpen(1, "c:\filepractice\ABC.txt", OpenMode.Input)

        While Not EOF(1)
            Input(1, name)
            Input(1, MemberId)
            Console.WriteLine(name)
            Console.WriteLine(MemberId)

        End While



        FileClose(1)
        Console.ReadKey()





    End Sub

End Module
