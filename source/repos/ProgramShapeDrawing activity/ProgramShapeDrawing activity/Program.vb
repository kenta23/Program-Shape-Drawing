Imports System

Module Program
    Dim num As Integer
    Dim line As String = "*"
    Dim stripe As String = "_"
    Sub Main(args As String())

        Console.WriteLine("Hello World!" + "goodbye")

        Display()

    End Sub

    Sub Display()

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

        If (num = 1) Then
            DrawLine()
        ElseIf (num = 2) Then
            DrawStripeLine()
        ElseIf (num = 3) Then
            DrawSquare()
        ElseIf (num = 4) Then
            DrawParallelogram()
        ElseIf (num = 5) Then
            DrawTriangle()
        End If

    End Sub


    Sub DrawLine()
        While (num <= 3 Or num Mod 2 = 0)
            Console.Write("Enter the size of the shape. [Odd numbers only and above 3]: ")
            num = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine()

        End While

        If (num Mod 2 <> 0 And num > 3) Then
            For i = 1 To num
                Console.Write(line)
            Next

            Console.WriteLine()
            Display()

        End If

    End Sub

    Sub DrawStripeLine()
        While (num <= 3 Or num Mod 2 = 0)
            Console.Write("Enter the size of the shape. [Odd numbers only and above 3]: ")
            num = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine()

        End While

        If (num Mod 2 <> 0 And num > 3) Then
            For i = 1 To num
                If (i Mod 2 = 0) Then
                    Console.Write(line)
                Else
                    Console.Write(stripe)
                End If
            Next

            Console.WriteLine()
            Display()

        End If
    End Sub

    Sub DrawSquare()
        While (num <= 3 Or num Mod 2 = 0)
            Console.Write("Enter the size of the shape. [Odd numbers only and above 3]: ")
            num = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine()

        End While

        If (num Mod 2 <> 0 And num > 3) Then
            For i = 1 To num
                For j = 1 To num
                    Console.Write(line)
                Next
                Console.WriteLine("")
            Next

            Console.WriteLine()
            Display()

        End If
    End Sub

    Sub DrawParallelogram()

    End Sub

    Sub DrawTriangle()
        While (num <= 3 Or num Mod 2 = 0)
            Console.Write("Enter the size of the shape. [Odd numbers only and above 3]: ")
            num = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine()

        End While

        If (num Mod 2 <> 0 And num > 3) Then

            For i = num To 1
                i -= 1
                For j = 1 To num
                    Console.Write(line)
                Next
                Console.WriteLine("")

            Next

            Console.WriteLine()
            Display()
       
        End If
    End Sub
End Module
