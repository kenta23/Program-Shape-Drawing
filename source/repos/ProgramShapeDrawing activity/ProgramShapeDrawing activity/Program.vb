Imports System

Module Program
    Dim num As Integer
    Dim line As String = "*"
    Dim stripe As String = "_"
    Sub Main(args As String())

        Display()

    End Sub

    Sub Display()
        Console.WriteLine()
        Console.WriteLine("SHAPE DRAWING")

        Console.WriteLine("[1] Draw Line")
        Console.WriteLine("[2] Draw StripeLine")
        Console.WriteLine("[3] Draw Square")
        Console.WriteLine("[4] Draw Parallelogram")
        Console.WriteLine("[5] Draw Triangle")
        Console.WriteLine("[6] Draw Reverse Triangle")
        Console.WriteLine("[0] Exit")

        Console.Write("Enter your Choice to Draw: ")
        num = Convert.ToInt32(Console.ReadLine())

        Select Case num
            Case 1
                DrawLine()
            Case 2
                DrawStripeLine()
            Case 3
                DrawSquare()
            Case 4
                DrawParallelogram()
            Case 5
                DrawTriangle()
            Case 6
                DrawReverse()
            Case 0
                End
        End Select

    End Sub


    Sub DrawLine()
        While (num <= 3 Or num Mod 2 = 0)
            Console.Write("Enter the size of the shape. [Odd numbers only and above 3]: ")
            num = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine()

        End While

        For i = 1 To num
            Console.Write(line)
        Next

        Console.WriteLine()
        Display()


    End Sub

    Sub DrawStripeLine()
        While (num <= 3 Or num Mod 2 = 0)
            Console.Write("Enter the size of the shape. [Odd numbers only and above 3]: ")
            num = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine()

        End While


        For i = 1 To num
            If (i Mod 2 = 0) Then
                Console.Write(line)
            Else
                Console.Write(stripe)
            End If
        Next

        Console.WriteLine()
        Display()

    End Sub

    Sub DrawSquare()
        While (num <= 3 Or num Mod 2 = 0)
            Console.Write("Enter the size of the shape. [Odd numbers only and above 3]: ")
            num = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine()

        End While


        For i = 1 To num
            For j = 1 To num
                Console.Write(line)
            Next
            Console.WriteLine("")
        Next

        Console.WriteLine()
        Display()

    End Sub

    Sub DrawParallelogram()
        While (num <= 3 Or num Mod 2 = 0)
            Console.Write("Enter the size of the shape. [Odd numbers only and above 3]: ")
            num = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine()

        End While

        For i = num To 1 Step -1
            For j = i To 1 Step -1
                Console.Write(stripe)
            Next
            For k = 1 To num
                Console.Write(line)
            Next
            For l = i To num Step +1
                Console.Write(stripe)
            Next
            Console.WriteLine("")
        Next

        Console.WriteLine(" ")
        Display()
    End Sub

    Sub DrawTriangle()
        While (num <= 3 Or num Mod 2 = 0)
            Console.Write("Enter the size of the shape. [Odd numbers only and above 3]: ")
            num = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine()

        End While


        For i = num To 1 Step -1
            For j = i To num - 1 Step +1
                Console.Write(stripe)
            Next
            For k = i To 1 Step -1
                Console.Write(line)
            Next
            Console.WriteLine("")
        Next

        Console.WriteLine(" ")
        Display()
    End Sub

    Sub DrawReverse()
        While (num <= 3 Or num Mod 2 = 0)
            Console.Write("Enter the size of the shape. [Odd numbers only and above 3]: ")
            num = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine()

        End While

        For i = num To 1 Step -1
            For j = i To num - 1 Step +1
                Console.Write(line)
            Next
            For k = i To 1 Step -1
                Console.Write(stripe)
            Next
            Console.WriteLine("")
        Next

        Console.WriteLine(" ")
        Display()
    End Sub

End Module
