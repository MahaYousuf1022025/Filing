Module Module1

    Sub Main()
        Dim name As String
        Dim MemberId As String
        Dim value As String
        Dim isfound As Boolean

        isfound = False

        name = ""
        MemberId = ""
        Console.WriteLine("enter member to be searched")
        value = Console.ReadLine


        FileOpen(1, "c:\filepractice\ABC.txt", OpenMode.Input)

        While Not EOF(1)
            Input(1, name)
            Input(1, MemberId)
            Console.WriteLine(name)
            Console.WriteLine(MemberId)
            If name = value Then
                isfound = True
                Console.WriteLine("member's id: " & MemberId)

            End If

        End While

        FileClose(1)
        If isfound = False Then
            Console.WriteLine("sorry your member is not found")
        End If
        Console.ReadKey()





    End Sub

End Module
