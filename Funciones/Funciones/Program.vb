Imports System

Module Program
    Sub Main()
        procedimiento1()
        proSuma(2, 6)
        Console.WriteLine(proResta(4, 5))

    End Sub
    Sub procedimiento1()
        Console.Write("Primer procedimiento")

    End Sub
    Sub proSuma(num1 As Double, num2 As Double)
        Dim suma As Double
        suma = num1 + num2
        Console.WriteLine("La suma es:{0}", suma)
    End Sub

    Function proResta(num1 As Double, num2 As Double) As Double
        Return num1 - num2
    End Function

End Module
