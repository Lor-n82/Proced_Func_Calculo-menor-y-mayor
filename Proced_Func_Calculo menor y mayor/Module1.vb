Module Module1

    Sub Main()
        '1. Implementar un procedimiento que calcule el menor y el mayor de los números recibidos por parámetro
        '2. Implementar una función que calcule el menor de los número recibidos por parámetro
        '3. Implementar una función que calcule el mayor de los número recibidos por parámetro
        '4. Realizar llamadas diferentes llamadas desde el main pasando la siguiente lista de argumentos:

        Dim opcion As Integer
        Dim sw As Boolean = False

        Do
            Console.Write(vbNewLine & "Menu" & vbNewLine &
                          "" & vbNewLine &
                          "1. Menor y mayor" & vbNewLine &
                          "2. Menor" & vbNewLine &
                          "3. Mayor" & vbNewLine &
                          "4. Salir" & vbNewLine &
                          "" & vbNewLine &
                          "Elije la opcion: ")
            Try
                opcion = Console.ReadLine()
            Catch

            End Try

            If opcion < 1 Or opcion > 4 Then
                Console.WriteLine("Opcion incorrecta")
                sw = True

                End If
                Select Case opcion
                    Case 1
                        calcularMayorMenor(1, 2)
                    Case 2
                        Console.WriteLine(vbNewLine & "El numero menor es: " & calcularMenor(5, 1, 3, 4))
                    Case 3
                        Console.WriteLine(vbNewLine & "El numero mayor es: " & calcularMayor(1, 2, 3, 4, 5, 6, 7, 8, 9))
                    Case 4
                        Console.WriteLine("Fin del programa")
                End Select

            Loop While opcion <> 4






            Console.ReadLine()



    End Sub

    Sub calcularMayorMenor(x As Integer, y As Integer)

        Dim mayor, menor As Integer

        If x > y Then
            mayor = x
            menor = y
        ElseIf y > x Then
            mayor = y
            menor = x
        End If

        If x <> y Then
            Console.WriteLine(vbNewLine & "El numero menor es " & menor & " y el numero mayor es " & mayor)
        Else
            Console.WriteLine(x & " y " & y & " son iguales")
        End If

    End Sub

    Function calcularMenor(v As Integer, x As Integer, y As Integer, z As Integer) As Integer

        Dim argumentos = New Integer() {v, y, x, z}
        Dim menor As Integer

        menor = argumentos(0)

        For i = 1 To argumentos.Length - 1

            If argumentos(i) < menor Then
                menor = argumentos(i)
            End If

        Next

        Return menor

    End Function

    Function calcularMayor(h As Integer, i As Integer, j As Integer, k As Integer, n As Integer, o As Integer, p As Integer, q As Integer, r As Integer) As Integer

        Dim argumentos = New Integer() {h, i, j, k, n, o, p, q, r}
        Dim mayor As Integer

        mayor = argumentos(0)

        For i = 1 To argumentos.Length - 1

            If argumentos(i) > mayor Then
                mayor = argumentos(i)
            End If

        Next

        Return mayor

    End Function
End Module
