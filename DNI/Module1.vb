Module Module1
    ''' <summary>
    ''' Array de caracteres con las posibles letras del DNI
    ''' </summary>
    Public letras As Char() = New Char() {"t"c, "r"c, "w"c, "a"c, "g"c, "m"c, "y"c, "f"c, "p"c, "d"c, "x"c, "b"c, "n"c, "j"c, "z"c, "s"c, "q"c, "v"c, "h"c, "l"c, "c"c, "k"c, "e"c}

    ''' <summary>
    ''' Genera un DNI aleatorio
    ''' </summary>
    ''' <returns>DNI generado</returns>
    Public Function GenerarDniAleatorio() As Integer
        Dim aleatorio As New Random

        Return aleatorio.Next(10000000, 99999999)

    End Function

    ''' <summary>
    ''' Genera un DNI válido para una letra dada
    ''' </summary>
    ''' <param name="letra">Letra del DNI</param>
    ''' <returns>DNI generado</returns>
    Public Function GenerarDniLetra(ByVal letra As String) As Integer
        Dim numero As Integer

        Do
            numero = GenerarDniAleatorio()
        Loop Until CalcularLetra(numero) = letra

        Return numero

    End Function

    ''' <summary>
    ''' Calcula la letra de un número de DNI
    ''' </summary>
    ''' <param name="numero">Número de DNI</param>
    ''' <returns></returns>
    Public Function CalcularLetra(ByVal numero As Integer) As String
        Dim resto As Integer

        resto = numero Mod 23
        Return letras(resto).ToString().ToUpper()
    End Function

End Module
