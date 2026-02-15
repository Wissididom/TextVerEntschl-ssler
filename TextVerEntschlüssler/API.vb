Public Class API

    Public Shared Function GetTimesOfOccuration(ByVal array As String(), ByVal SearchString As String, ByVal IgnoreCase As Boolean) As Integer
        Dim times As Integer = 0
        For i As Integer = 0 To array.Length - 1
            If IgnoreCase Then
                If array(i).ToUpper() = SearchString.ToUpper() Then
                    times += 1
                End If
            Else
                If array(i) = SearchString Then
                    times += 1
                End If
            End If
        Next
        Return times
    End Function

    Public Shared Function Encrypt(ByVal order As String, ByVal decrypted As String) As String
        Dim result As String = decrypted
        Dim base64times As Integer = 0
        Dim rot13times As Integer = 0
        Dim blowfishtimes As Integer = 0
        Dim morsetimes As Integer = 0
        Dim keyboardtimes As Integer = 0
        Dim caesartimes As Integer = 0
        Dim splitted As String() = order.Split(","c)
        For i As Integer = 0 To splitted.Length - 1
            If splitted(i).ToUpper() = "Base64".ToUpper() Then
                result = EncryptBase64(result)
                base64times += 1
            End If
            If splitted(i).ToUpper() = "Rot13".ToUpper() Then
                result = EnDecryptRot13(result)
                rot13times += 1
            End If
            If splitted(i).ToUpper() = "Blowfish".ToUpper() Then
                Dim key As String = ""
                If GetTimesOfOccuration(order.Split(","c), "Blowfish", True) > 1 Then
                    key = InputBox("Geben Sie den Schlüssel für die " & blowfishtimes + 1 & ". Blowfish-Verschlüsselung ein.", "Schlüssel eingeben")
                Else
                    key = InputBox("Geben Sie den Schlüssel für die Blowfish-Verschlüsselung ein.", "Schlüssel eingeben")
                End If
                result = EncryptBlowfish(result, key)
                blowfishtimes += 1
            End If
            If splitted(i).ToUpper() = "Morse".ToUpper() Then
                result = EncryptMorse(result)
                morsetimes += 1
            End If
            If splitted(i).ToUpper() = "Tastatur".ToUpper() Then
                Dim settings As String = ""
                If GetTimesOfOccuration(order.Split(","c), "Tastatur", True) > 1 Then
                    settings = InputBox("Geben Sie den Typ der Tastaturverschlüsselung " & keyboardtimes + 1 & " ein. ""l"" für links, ""r"" für rechts, dann die Zahl um wie viel die Tasten verschoben werden sollen.", "Schlüssel eingeben")
                Else
                    settings = InputBox("Geben Sie den Typ der Tastaturverschlüsselung ein. ""l"" für links, ""r"" für rechts, dann die Zahl um wie viel die Tasten verschoben werden sollen.", "Schlüssel eingeben")
                End If
                result = ""
                For Each c As Char In settings
                    If Not Char.IsLetter(c) Then
                        If result = "" Then
                            result = c.ToString()
                        Else
                            result &= c.ToString()
                        End If
                    End If
                Next
                result = EncryptKeyboard(result, If(settings.Substring(0, 1) = "l", True, False), Integer.Parse(result))
                keyboardtimes += 1
            End If
            If splitted(i).ToUpper() = "Cäsar".ToUpper() Then
                Dim key As String = ""
                If GetTimesOfOccuration(order.Split(","c), "Blowfish", True) > 1 Then
                    key = InputBox("Geben Sie den Schlüssel für die " & caesartimes + 1 & ". Cäsar-Verschlüsselung ein.", "Schlüssel eingeben")
                Else
                    key = InputBox("Geben Sie den Schlüssel für die Cäsar-Verschlüsselung ein.", "Schlüssel eingeben")
                End If
                result = EncryptCaesar(result, key)
                caesartimes += 1
            End If
        Next
        Return result
    End Function

    Public Shared Function Decrypt(ByVal order As String, ByVal encrypted As String)
        Dim result As String = encrypted
        Dim base64times As Integer = 0
        Dim rot13times As Integer = 0
        Dim blowfishtimes As Integer = 0
        Dim morsetimes As Integer = 0
        Dim keyboardtimes As Integer = 0
        Dim caesartimes As Integer = 0
        Dim splitted As String() = order.Split(","c)
        For i As Integer = splitted.Length - 1 To 0 Step -1
            If splitted(i).ToUpper() = "Base64".ToUpper() Then
                result = DecryptBase64(result)
                base64times += 1
            End If
            If splitted(i).ToUpper() = "Rot13".ToUpper() Then
                result = EnDecryptRot13(result)
                rot13times += 1
            End If
            If splitted(i).ToUpper() = "Blowfish".ToUpper() Then
                Dim key As String = ""
                If GetTimesOfOccuration(order.Split(","c), "Blowfish", True) > 1 Then
                    key = InputBox("Geben Sie den Schlüssel für die " & blowfishtimes + 1 & ". Blowfish-Verschlüsselung ein.", "Schlüssel eingeben")
                Else
                    key = InputBox("Geben Sie den Schlüssel für die Blowfish-Verschlüsselung ein.", "Schlüssel eingeben")
                End If
                result = DecryptBlowfish(result, key)
                blowfishtimes += 1
            End If
            If splitted(i).ToUpper() = "Morse".ToUpper() Then
                result = DecryptMorse(result)
                morsetimes += 1
            End If
            If splitted(i).ToUpper() = "Tastatur".ToUpper() Then
                Dim settings As String = ""
                If GetTimesOfOccuration(order.Split(","c), "Tastatur", True) > 1 Then
                    settings = InputBox("Geben Sie den Typ der Tastaturverschlüsselung " & keyboardtimes + 1 & " ein. ""l"" für links, ""r"" für rechts, dann die Zahl um wie viel die Tasten verschoben werden sollen.", "Schlüssel eingeben")
                Else
                    settings = InputBox("Geben Sie den Typ der Tastaturverschlüsselung ein. ""l"" für links, ""r"" für rechts, dann die Zahl um wie viel die Tasten verschoben werden sollen.", "Schlüssel eingeben")
                End If
                result = ""
                For Each c As Char In settings
                    If Not Char.IsLetter(c) Then
                        If result = "" Then
                            result = c.ToString()
                        Else
                            result &= c.ToString()
                        End If
                    End If
                Next
                result = DecryptKeyboard(result, If(settings.Substring(0, 1) = "l", True, False), Integer.Parse(result))
                keyboardtimes += 1
            End If
            If splitted(i).ToUpper() = "Cäsar".ToUpper() Then
                Dim key As String = ""
                If GetTimesOfOccuration(order.Split(","c), "Blowfish", True) > 1 Then
                    key = InputBox("Geben Sie den Schlüssel für die " & caesartimes + 1 & ". Cäsar-Verschlüsselung ein.", "Schlüssel eingeben")
                Else
                    key = InputBox("Geben Sie den Schlüssel für die Cäsar-Verschlüsselung ein.", "Schlüssel eingeben")
                End If
                result = EncryptCaesar(result, key)
                caesartimes += 1
            End If
        Next
        Return result
    End Function

    Public Shared Function EncryptBase64(ByVal decrypted As String) As String
        Return Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(decrypted))
    End Function

    Public Shared Function DecryptBase64(ByVal encrypted As String) As String
        Return System.Text.Encoding.Default.GetString(Convert.FromBase64String(encrypted))
    End Function

    Public Shared Function EnDecryptRot13(ByVal encrypted As String) As String
        Dim Letter() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}
        Dim Letter2() As String = {"N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m"}
        Dim result As String = ""
        For i As Integer = 0 To encrypted.Length - 1
            For j As Integer = 0 To 51
                If encrypted(i) = Letter(j) Then
                    result &= Letter2(j)
                    GoTo Line1
                End If
            Next
            result &= encrypted(i)
Line1:
        Next
        Return result
    End Function

    Public Shared Function EncryptBlowfish(ByVal decrypted As String, ByVal Key As String) As String
        Dim BF As New Blowfish(Key)
        AddHandler BF.Terminated, Sub(pError As String)
                                      'do nothing
                                  End Sub
        AddHandler BF.Progress, Sub(Percent As Integer)
                                    'do nothing
                                    BF.Tag = Percent
                                End Sub
        AddHandler BF.Complete, Sub()
                                    'do nothing
                                End Sub
        'BF.Key = System.Text.Encoding.UTF8.GetBytes("YOUR_KEY")
        Dim encrypted As String = System.Text.Encoding.UTF8.GetString(BF.EncodeBytes(System.Text.Encoding.UTF8.GetBytes(decrypted)))
        Do Until BF.Tag = 100
            Application.DoEvents()
        Loop
        Return encrypted
    End Function

    Public Shared Function DecryptBlowfish(ByVal encrypted As String, ByVal Key As String) As String
        Dim BF As New Blowfish(Key)
        AddHandler BF.Terminated, Sub(pError As String)
                                      'do nothing
                                  End Sub
        AddHandler BF.Progress, Sub(Percent As Integer)
                                    'do nothing
                                    BF.Tag = Percent
                                End Sub
        AddHandler BF.Complete, Sub()
                                    'do nothing
                                End Sub
        'BF.Key = System.Text.Encoding.UTF8.GetBytes("YOUR_KEY")
        Dim decrypted As String = System.Text.Encoding.UTF8.GetString(BF.DecodeBytes(System.Text.Encoding.UTF8.GetBytes(encrypted)))
        Do Until BF.Tag = 100
            Application.DoEvents()
        Loop
        Return decrypted
    End Function

    Public Shared Function EncryptMorse(ByVal decrypted As String) As String
        Dim replacements As String(,) = {{"CH", "g----"}, {"A", "g.-"}, {"Ä", "g.-.-"}, {"B", "g-..."}, {"C", "g-.-."}, {"D", "g-.."},
            {"E", "g."}, {"F", "g..-."}, {"G", "g--."}, {"H", "g...."}, {"I", "g.."}, {"J", "g.---"}, {"K", "g-.-"}, {"L", "g.-.."},
            {"M", "g--"}, {"N", "g-."}, {"O", "g---"}, {"Ö", "g---."}, {"P", "g.--."}, {"Q", "g--.-"}, {"R", "g.-."}, {"S", "g..."},
            {"T", "g-"}, {"U", "g..-"}, {"Ü", "g..--"}, {"V", "g...-"}, {"W", "g.--"}, {"X", "g-..-"}, {"Y", "g-.--"}, {"Z", "g--.."},
            {"1", ".----"}, {"2", "..---"}, {"3", "...--"}, {"4", "....-"}, {"5", "....."}, {"6", "-...."}, {"7", "--..."},
            {"8", "---.."}, {"9", "----."}, {"0", "-----"}, {"ch", "l----"}, {"a", "l.-"}, {"ä", "l.-.-"}, {"b", "l-..."}, {"c", "l-.-."},
            {"d", "l-.."}, {"e", "l."}, {"f", "l..-."}, {"g", "l--."}, {"h", "l...."}, {"i", "l.."}, {"j", "l.---"}, {"k", "l-.-"},
            {"l", "l.-.."}, {"m", "l--"}, {"n", "l-."}, {"o", "l---"}, {"ö", "l---."}, {"p", "l.--."}, {"q", "l--.-"}, {"r", "l.-."},
            {"s", "l..."}, {"t", "l-"}, {"u", "l..-"}, {"ü", "l..--"}, {"v", "l...-"}, {"w", "l.--"}, {"x", "l-..-"}, {"y", "l-.--"},
            {"z", "l--.."}}
        Dim encrypted As String = ""
        Dim IsCharHandled As Boolean = False
        For Each c As Char In decrypted
            IsCharHandled = False
            For i As Integer = 0 To (replacements.Length / 2) - 1
                If c = replacements(i, 0) Then
                    If encrypted = "" Then
                        encrypted = replacements(i, 1)
                    Else
                        encrypted &= "|" & replacements(i, 1)
                    End If
                    IsCharHandled = True
                End If
            Next
            If Not IsCharHandled Then
                If encrypted = "" Then
                    encrypted = c
                Else
                    encrypted &= "|" & c
                End If
                IsCharHandled = True
            End If
        Next
        Return encrypted
    End Function

    Public Shared Function DecryptMorse(ByVal encrypted As String) As String
        Dim replacements As String(,) = {{"CH", "g----"}, {"A", "g.-"}, {"Ä", "g.-.-"}, {"B", "g-..."}, {"C", "g-.-."}, {"D", "g-.."},
            {"E", "g."}, {"F", "g..-."}, {"G", "g--."}, {"H", "g...."}, {"I", "g.."}, {"J", "g.---"}, {"K", "g-.-"}, {"L", "g.-.."},
            {"M", "g--"}, {"N", "g-."}, {"O", "g---"}, {"Ö", "g---."}, {"P", "g.--."}, {"Q", "g--.-"}, {"R", "g.-."}, {"S", "g..."},
            {"T", "g-"}, {"U", "g..-"}, {"Ü", "g..--"}, {"V", "g...-"}, {"W", "g.--"}, {"X", "g-..-"}, {"Y", "g-.--"}, {"Z", "g--.."},
            {"1", ".----"}, {"2", "..---"}, {"3", "...--"}, {"4", "....-"}, {"5", "....."}, {"6", "-...."}, {"7", "--..."},
            {"8", "---.."}, {"9", "----."}, {"0", "-----"}, {"ch", "l----"}, {"a", "l.-"}, {"ä", "l.-.-"}, {"b", "l-..."}, {"c", "l-.-."},
            {"d", "l-.."}, {"e", "l."}, {"f", "l..-."}, {"g", "l--."}, {"h", "l...."}, {"i", "l.."}, {"j", "l.---"}, {"k", "l-.-"},
            {"l", "l.-.."}, {"m", "l--"}, {"n", "l-."}, {"o", "l---"}, {"ö", "l---."}, {"p", "l.--."}, {"q", "l--.-"}, {"r", "l.-."},
            {"s", "l..."}, {"t", "l-"}, {"u", "l..-"}, {"ü", "l..--"}, {"v", "l...-"}, {"w", "l.--"}, {"x", "l-..-"}, {"y", "l-.--"},
            {"z", "l--.."}}
        Dim decrypted As String = ""
        Dim IsCharHandled As Boolean = False
        For Each replacement As String In encrypted.Split("|"c)
            IsCharHandled = False
            For i As Integer = 0 To (replacements.Length / 2) - 1
                If replacement = replacements(i, 1) Then
                    If decrypted = "" Then
                        decrypted = replacements(i, 0)
                    Else
                        decrypted &= replacements(i, 0)
                    End If
                    IsCharHandled = True
                End If
            Next
            If Not IsCharHandled Then
                If decrypted = "" Then
                    decrypted = replacement
                Else
                    decrypted &= replacement
                End If
            End If
        Next
        Return decrypted
    End Function

    Public Shared Function EncryptKeyboard(ByVal decrypted As String, ByVal left As Boolean, ByVal times As Integer) As String
        Throw New NotImplementedException()
        Dim replacements As String(,) = {{}}
        Dim encrypted As String = ""
        Dim IsCharHandled As Boolean = False
        For Each replacement As String In decrypted.Split("|"c)
            IsCharHandled = False
            For i As Integer = 0 To (replacements.Length / 2) - 1
                If replacement = replacements(i, 1) Then
                    If encrypted = "" Then
                        encrypted = replacements(i, 0)
                    Else
                        encrypted &= replacements(i, 0)
                    End If
                    IsCharHandled = True
                End If
            Next
            If Not IsCharHandled Then
                If encrypted = "" Then
                    encrypted = replacement
                Else
                    encrypted &= replacement
                End If
            End If
        Next
        Return encrypted
    End Function

    Public Shared Function DecryptKeyboard(ByVal encrypted As String, ByVal left As Boolean, ByVal times As Integer) As String
        Throw New NotImplementedException()
        Dim replacements As String(,) = {{}}
        Dim decrypted As String = ""
        Dim IsCharHandled As Boolean = False
        For Each replacement As String In encrypted.Split("|"c)
            IsCharHandled = False
            For i As Integer = 0 To (replacements.Length / 2) - 1
                If replacement = replacements(i, 1) Then
                    If decrypted = "" Then
                        decrypted = replacements(i, 0)
                    Else
                        decrypted &= replacements(i, 0)
                    End If
                    IsCharHandled = True
                End If
            Next
            If Not IsCharHandled Then
                If decrypted = "" Then
                    decrypted = replacement
                Else
                    decrypted &= replacement
                End If
            End If
        Next
        Return decrypted
    End Function

    Public Shared Function EncryptCaesar(ByVal decrypted As String, ByVal key As String)
        Return decrypted
    End Function

    Public Shared Function DecryptCaesar(ByVal encrypted As String, ByVal key As String)
        Return encrypted
    End Function
End Class
