Module Module1
    Public Sub BinaryTriangle(n As Int16)
        Console.WriteLine("Binary Triangle")

        For i As Integer = 0 To n - 1
            For j As Integer = 0 To i
                If (i + j) Mod 2 = 0 Then
                    Console.Write("1 ")
                Else
                    Console.Write("0 ")
                End If
            Next
            Console.WriteLine()
        Next
    End Sub
    Public Sub NumberPattern(n As Integer)
        Console.WriteLine("NUMBER PATTERN")

        For i As Integer = 0 To n - 1
            For k As Integer = 0 To n - i - 2
                Console.Write(" ")
            Next
            For j As Integer = 0 To i
                Console.Write(i + 1 & " ")
            Next
            Console.WriteLine()
        Next
    End Sub

    Public Sub NumberInc(n As Integer)
        Console.WriteLine("NUMBER INCREASING")

        For i As Integer = 0 To n - 1
            For j As Integer = 0 To i
                Console.Write(j + 1 & " ")
            Next
            Console.WriteLine()
        Next
    End Sub


    Public Sub NumberDec(n As Integer)
        Console.WriteLine("NUMBER DECREASING")

        For i As Integer = 0 To n - 1
            For j As Integer = 0 To n - i - 1
                Console.Write(j + 1 & " ")
            Next
            Console.WriteLine()
        Next
    End Sub

    Public Sub CounterPyramid(n As Integer)
        Console.WriteLine("COUNTER PYRAMID")

        Dim count As Integer = 1

        For i As Integer = 0 To n - 1
            For j As Integer = 0 To i
                If count < 10 Then
                    Console.Write(count & "  ")
                Else
                    Console.Write(count & " ")
                End If
                count += 1
            Next
            Console.WriteLine()
        Next
    End Sub

    Public Sub Diamond(n As Integer)
        Console.WriteLine("DIAMOND")
        For i As Integer = 0 To n - 1
            For k As Integer = n - 1 - i To 1 Step -1
                Console.Write(" ")
            Next
            For j As Integer = 0 To (i * 2) + 1 - 1
                Console.Write("*")
            Next
            Console.Write(vbLf)
        Next
        For i As Integer = 1 To n - 1
            For k As Integer = 0 To i - 1
                Console.Write(" ")
            Next
            For j As Integer = i * 2 To (n * 2) - i - 1
                Console.Write("*")
            Next
            Console.WriteLine()
        Next
    End Sub

    Public Sub Rohmbus(n As Integer)
        Console.WriteLine("ROHMBUS")
        For i As Integer = 0 To n - 1
            For k As Integer = 0 To n - i - 2
                Console.Write(" ")
            Next
            For j As Integer = 0 To n - 1
                Console.Write("*")
            Next
            Console.WriteLine()
        Next
    End Sub

    Public Sub MirrorImage(n As Integer)
        Console.WriteLine("MIRROR IMAGE")
        For i As Integer = 1 To n - 1
            For k As Integer = 0 To i - 1
                Console.Write(" ")
            Next
            For j As Integer = i To n - 1
                Console.Write(j & " ")
            Next
            Console.WriteLine()
        Next
        For i As Integer = 0 To n - 3
            For k As Integer = n - 2 - i To 1 Step -1
                Console.Write(" ")
            Next
            For j As Integer = n - i - 2 To n - 1
                Console.Write(j & " ")
            Next
            Console.WriteLine()
        Next
    End Sub

    Public Sub PascalTriangle(n As Integer)
        Console.WriteLine("PASCAL TRIANGLE")
        For i As Integer = 1 To n
            Dim B As Integer = 1
            For k As Integer = 0 To n - i - 1
                Console.Write(" ")
            Next
            For j As Integer = 1 To i
                Console.Write(B & " ")
                B = B * (i - j) \ j
            Next
            Console.WriteLine()
        Next
    End Sub

    Public Sub PalindromeTriangle(n As Integer)
        Console.WriteLine("PALINDROME TRIANGLE")
        For i As Integer = 0 To n - 1
            For k As Integer = 0 To n - i - 1
                Console.Write("  ")
            Next
            For j As Integer = i To 0 Step -1
                Console.Write(j + 1 & " ")
            Next
            For l As Integer = 1 To i
                Console.Write(l + 1 & " ")
            Next
            Console.WriteLine()
        Next
    End Sub

    Public Sub SquareHollowPattern(n As Integer)
        Console.WriteLine("HOLLOW SQUARE")

        For i As Integer = 1 To n
            For j As Integer = 1 To n
                If i = 1 OrElse i = n OrElse j = 1 OrElse j = n Then
                    Console.Write("* ")
                Else
                    Console.Write("  ")
                End If
            Next
            Console.WriteLine()
        Next
    End Sub

    Public Sub HollowTrianglePattern(n As Integer)
        Console.WriteLine("HOLLOW TRIANGLE")

        For i As Integer = 1 To n
            For j As Integer = 1 To n - i
                Console.Write(" ")
            Next
            For k As Integer = 1 To 2 * i - 1
                If k = 1 OrElse k = 2 * i - 1 OrElse i = n Then
                    Console.Write("*")
                Else
                    Console.Write(" ")
                End If
            Next
            Console.WriteLine()
        Next
    End Sub

    Public Sub HollowReverseTrianglePattern(n As Integer)
        Console.WriteLine("HOLLOW REVERSE TRIANGLE")

        For i As Integer = n To 1 Step -1
            For j As Integer = 1 To n - i
                Console.Write(" ")
            Next
            For k As Integer = 1 To 2 * i - 1
                If k = 1 OrElse k = 2 * i - 1 OrElse i = n Then
                    Console.Write("*")
                Else
                    Console.Write(" ")
                End If
            Next
            Console.WriteLine()
        Next
    End Sub

    Public Sub HollowDiamondPyramid(n As Integer)
        Console.WriteLine("HOLLOW DIAMOND")

        For i As Integer = 1 To n
            For j As Integer = 1 To n - i
                Console.Write(" ")
            Next
            For k As Integer = 1 To 2 * i - 1
                If k = 1 OrElse k = 2 * i - 1 Then
                    Console.Write("*")
                Else
                    Console.Write(" ")
                End If
            Next
            Console.WriteLine()
        Next
        For i As Integer = n - 1 To 1 Step -1
            For j As Integer = 1 To n - i
                Console.Write(" ")
            Next
            For k As Integer = 1 To 2 * i - 1
                If k = 1 OrElse k = 2 * i - 1 Then
                    Console.Write("*")
                Else
                    Console.Write(" ")
                End If
            Next
            Console.WriteLine()
        Next
    End Sub

    Public Sub HollowHourglassPattern(n As Integer)
        Console.WriteLine("HOLLOW HOUR GLASS")
        For i As Integer = 0 To n - 1
            For j As Integer = 0 To i - 1
                Console.Write(" ")
            Next
            For j As Integer = 0 To n - i - 1
                If i = 0 OrElse i = n - 1 OrElse j = 0 OrElse j = n - i - 1 Then
                    Console.Write("* ")
                Else
                    Console.Write("  ")
                End If
            Next
            Console.WriteLine()
        Next

        For i As Integer = n - 2 To 0 Step -1
            For j As Integer = 0 To i - 1
                Console.Write(" ")
            Next
            For j As Integer = 0 To n - i - 1
                If i = 0 OrElse i = n - 1 OrElse j = 0 OrElse j = n - i - 1 Then
                    Console.Write("* ")
                Else
                    Console.Write("  ")
                End If
            Next
            Console.WriteLine()
        Next
    End Sub



    Sub Main()
        Dim val As Int32

        Console.WriteLine("Pattern Programs VB.NET")

        Console.WriteLine("Enter the value:")
        val = Convert.ToInt32(Console.ReadLine())

        If val < 10 Then

            BinaryTriangle(val)
            Console.WriteLine("----------------------------------------------")
            NumberPattern(val)
            Console.WriteLine("----------------------------------------------")
            NumberInc(val)
            Console.WriteLine("----------------------------------------------")
            NumberDec(val)
            Console.WriteLine("----------------------------------------------")
            CounterPyramid(val)
            Console.WriteLine("----------------------------------------------")
            Diamond(val)
            Console.WriteLine("----------------------------------------------")
            Rohmbus(val)
            Console.WriteLine("----------------------------------------------")
            MirrorImage(val)
            Console.WriteLine("----------------------------------------------")
            PascalTriangle(val)
            Console.WriteLine("----------------------------------------------")
            PalindromeTriangle(val)
            Console.WriteLine("----------------------------------------------")
            HollowTrianglePattern(val)
            Console.WriteLine("----------------------------------------------")
            HollowReverseTrianglePattern(val)
            Console.WriteLine("----------------------------------------------")
            HollowDiamondPyramid(val)
            Console.WriteLine("----------------------------------------------")
            HollowHourglassPattern(val)
            Console.WriteLine("----------------------------------------------")
            SquareHollowPattern(val)
            Console.WriteLine("----------------------------------------------")
        Else
            Console.WriteLine("enter value less than 10")

        End If



        Console.ReadLine()
    End Sub

End Module

