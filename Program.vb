Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")

        Dim saber As String
        '''este es un cometario 
        '''
        '''
        Datos()

    End Sub

    Public Sub Datos()
        ''mnbBDBCbbjCBJHHJCHBJHJCJHJHJHDCHJJHGDGJHGFDGJJGJK
        ''mnbBDBCbbjCBJHHJCHBJHJCJHJHJHDCHJJHGDGJHGFDGJJGJK jjl

        Dim numero1, numero2, resultado As Integer

        Console.Write("Digite el numero 1: ")
        numero1 = Console.ReadLine

        Console.Write("Digite el numero 2: ")
        numero2 = Console.ReadLine

        resultado = numero1 + numero2

        Console.WriteLine("El resultado es: " & resultado)
        Console.ReadKey()
    End Sub

End Module
