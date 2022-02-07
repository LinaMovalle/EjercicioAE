Imports System

Module Program
    Sub Main(args As String())
        Dim opcion As Integer
        Console.WriteLine("Seleccione la opción que desea:")
        opcion = Console.ReadLine

        Select Case opcion
            Case 1
                PrimerPunto()
            Case 2
                SegundoPunto()
            Case 3
                tercerPunto()
            Case 4
                cuartoPunto()
            Case 5
                QuintoPunto()
            Case 6
                SextoPunto()
            Case 7
                SeptimoPunto()
            Case 8
                OctavoPunto()
            Case 9
                NovenoPunto()
            Case 10
                DecimoPunto()
        End Select
    End Sub
    Sub PrimerPunto()

        Console.WriteLine("1.Generar  y  rellenar  un arreglo  unidimensional,  pedir  la  longitud  del  arreglo  al  usuario  y debe contener valores pares partiendo desde el 2")

        'Declarar variables
        Dim tam As Integer 'tamaño del arreglo
        Dim num As Integer = 2
        Do
            Console.WriteLine("Ingrese el tamaño del arreglo:")
            tam = Console.ReadLine
            Console.WriteLine("---------------------------------------------------------------")

        Loop While (tam <= 2)

        Dim myArray(tam) As Double
        Dim r1 As Integer = myArray.GetUpperBound(0)

        For i = 0 To myArray.GetUpperBound(0) - 1
            myArray(i) = num
            num += 2
        Next

        For i = 0 To myArray.GetUpperBound(0) - 1
            Console.WriteLine(myArray(i))
        Next
    End Sub
    Sub SegundoPunto()

        Console.WriteLine("2.Generar y rellenar un arreglo unidimensional, los valores a llenar será el resultado de la tabla de multiplicar del que desee el usuario")

        'Declarar variables
        Dim tam As Integer 'tamaño del arreglo
        Dim numero As Integer
        Dim Aux As Integer

        Console.WriteLine("Ingrese el número del que quiere generar la tabla de multiplicar:")
        numero = Console.ReadLine

        Do
            Console.WriteLine("Ingrese el tamaño del arreglo:")
            tam = Console.ReadLine
            Console.WriteLine("----------------------------------------------------")

        Loop While (tam <= 2)

        Dim myArray(tam) As Double
        Dim r1 As Integer = myArray.GetUpperBound(0)

        For i = 0 To myArray.GetUpperBound(0) - 1
            myArray(i) = numero * Aux
            Aux += 1
        Next

        For i = 0 To myArray.GetUpperBound(0) - 1
            Console.WriteLine(myArray(i))
        Next
    End Sub
    Sub tercerPunto()
        Console.WriteLine("3.Generar  y  rellenar  una  matriz  cuadrada  de  dimensión  o  longitud  dada  por  el  usuario, llenarla con número impares")

        'Declarar variables
        Dim tam As Integer 'tamaño del arreglo
        Dim num As Integer = 1


        Console.WriteLine("Ingrese el tamaño de la matriz cuadrada arreglo:")
        tam = Console.ReadLine
        Console.WriteLine("----------------------------------------------------")

        Dim matriz(tam, tam) As Integer

        For i = 0 To tam - 1
            For j = 0 To tam - 1
                matriz(i, j) = num
                num += 2

            Next
        Next

        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                Console.Write(matriz(i, j) & " ")
            Next
            Console.WriteLine()
        Next

    End Sub
    Sub cuartoPunto()

        Console.WriteLine("4.Dada  una  matriz  de  dimensiones  dadas  por  el  usuario,  llenarla  con  un  valor  único  que daría el usuario y multiplicado por su posición")

        'Declarar variables
        Dim fila As Integer 'tamaño del arreglo
        Dim col As Integer 'tamaño del arreglo
        Dim num As Integer


        Console.WriteLine("Ingrese el tamaño de la fila arreglo:")
        fila = Console.ReadLine

        Console.WriteLine("Ingrese el tamaño de la Columna arreglo:")
        col = Console.ReadLine
        Console.WriteLine("----------------------------------------------------")

        Console.WriteLine("Ingrese el número del que quiere generar la multiplicación por la posición")
        num = Console.ReadLine

        Dim matriz(fila, col) As String

        For i = 0 To fila
            For j = 0 To col
                matriz(i, j) = num * i & "/" & num * j
            Next
        Next

        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                Console.Write(matriz(i, j) & " ")
            Next
            Console.WriteLine()
        Next
    End Sub
    Sub QuintoPunto()
        Console.WriteLine("5.Generar una matriz cuadrada mostrar solo la diagonal principal con elementos 0(DP)")

        'Declarar variables
        Dim tam As Integer 'tamaño del arreglo


        Console.WriteLine("Ingrese el tamaño de la matriz cuadrada arreglo:")
        tam = Console.ReadLine
        Console.WriteLine("----------------------------------------------------")

        Dim matriz(tam, tam) As String

        For i = 0 To tam
            For j = 0 To tam
                If (i = j) Then
                    matriz(i, j) = "0"
                Else
                    matriz(i, j) = "."
                End If


            Next
        Next

        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                Console.Write(matriz(i, j) & " ")
            Next
            Console.WriteLine()
        Next

    End Sub
    Sub SextoPunto()
        Console.WriteLine("6.Generar una matriz cuadrada mostrar solo la diagonal trasversa con elementos 0 (DT)")

        'Declarar variables
        Dim tam As Integer 'tamaño del arreglo


        Console.WriteLine("Ingrese el tamaño de la matriz cuadrada arreglo:")
        tam = Console.ReadLine
        Console.WriteLine("----------------------------------------------------")
        Dim matriz(tam, tam) As String

        For i = 0 To tam
            For j = 0 To tam
                If (j + i = tam - 1) Then
                    matriz(i, j) = "0"
                Else
                    matriz(i, j) = "."
                End If


            Next
        Next

        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                Console.Write(matriz(i, j) & " ")
            Next
            Console.WriteLine()
        Next

    End Sub

    Sub SeptimoPunto()
        Console.WriteLine("7.Generar una matriz cuadrada mostrar solo la diagonal principal y trasversa")

        'Declarar variables
        Dim tam As Integer 'tamaño del arreglo


        Console.WriteLine("Ingrese el tamaño de la matriz cuadrada arreglo:")
        tam = Console.ReadLine
        Console.WriteLine("----------------------------------------------------")

        Dim matriz(tam, tam) As String

        For i = 0 To tam - 1
            For j = 0 To tam - 1
                If ((j + i = tam - 1) Or (i = j)) Then
                    matriz(i, j) = "0"
                Else
                    matriz(i, j) = "."
                End If


            Next
        Next

        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                Console.Write(matriz(i, j) & " ")
            Next
            Console.WriteLine()
        Next

    End Sub

    Sub OctavoPunto()
        Console.WriteLine("8.Generar una matriz cuadrada mostrar solo las puntas de la matriz con elementos 0")

        'Declarar variables
        Dim tam As Integer 'tamaño del arreglo


        Console.WriteLine("Ingrese el tamaño de la matriz cuadrada arreglo:")
        tam = Console.ReadLine
        Console.WriteLine("----------------------------------------------------")

        Dim matriz(tam, tam) As String

        For i = 0 To tam
            For j = 0 To tam
                If ((i = 0 Or i = tam - 1) And (j = 0 Or j = tam - 1)) Then
                    matriz(i, j) = "0"
                Else
                    matriz(i, j) = "."
                End If


            Next
        Next

        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                Console.Write(matriz(i, j) & " ")
            Next
            Console.WriteLine()
        Next

    End Sub
    Sub NovenoPunto()
        Console.WriteLine("9.Generar una matriz cuadrada dibujar un cuadrado con 0")

        'Declarar variables
        Dim tam As Integer 'tamaño del arreglo


        Console.WriteLine("Ingrese el tamaño de la matriz cuadrada arreglo:")
        tam = Console.ReadLine
        Console.WriteLine("----------------------------------------------------")

        Dim matriz(tam, tam) As String

        For i = 0 To tam
            For j = 0 To tam
                If ((i = 0 Or i = tam - 1) Or (j = 0 Or j = tam - 1)) Then
                    matriz(i, j) = "0"
                Else
                    matriz(i, j) = "."
                End If


            Next
        Next

        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                Console.Write(matriz(i, j) & " ")
            Next
            Console.WriteLine()
        Next

    End Sub
    Sub DecimoPunto()
        Console.WriteLine("10.Generaruna matriz cuadrada NxN(solo valores impares y mayores a 3) y generar el sgte relleno: N=5")

        'Declarar variables
        Dim tam As Integer 'tamaño del arreglo
        Dim x As Integer

        Do
            Console.WriteLine("Ingrese el tamaño de la matriz cuadrada arreglo:")
            tam = Console.ReadLine
            Console.WriteLine("----------------------------------------------------")
            If (tam <= 3 Or tam Mod 2 = 0) Then
                Console.WriteLine("La dimensión debe ser impar y mayor a 3")
            End If
        Loop While (tam <= 3 Or tam Mod 2 = 0)
        Dim matriz(tam, tam) As Integer
        x = tam / 2 + 1
        For i = 0 To x
            For j = i + 1 To tam - 1 - (i + 1)
                matriz(i, j) = 1
                matriz(tam - i - 1, j) = 1
            Next
        Next
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                If (matriz(i, j) <> 1) Then
                    matriz(i, j) = tam - 1
                End If
                Console.Write(matriz(i, j) & " ")
            Next
            Console.WriteLine()
        Next

    End Sub
End Module
