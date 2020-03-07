Public Class ConvertNumToWords
    Public Shared Function ConvertNumEN(ByVal Input As Long) As String 'Call this function passing the number you desire to be changed  
        Dim output As String = Nothing
        If Input < 1000 Then
            output = FindNumber(Input) 'if its less than 1000 then just look it up  
        Else
            Dim nparts() As String 'used to break the number up into 3 digit parts  
            Dim n As String = Input 'string version of the number  
            Dim i As Long = Input.ToString.Length 'length of the string to help break it up  

            Do Until i - 3 <= 0
                n = n.Insert(i - 3, ",") 'insert commas to use as splitters  
                i = i - 3 'this insures that we get the correct number of parts  
            Loop
            nparts = n.Split(",") 'split the string into the array  

            i = Input.ToString.Length 'return i to initial value for reuse  
            Dim p As Integer = 0 'p for parts, used for finding correct suffix  
            For Each s As String In nparts
                Dim x As Long = CLng(s) 'x is used to compare the part value to other values  
                p = p + 1
                If p = nparts.Length Then 'if p = number of elements in the array then we need to do something different  
                    If x <> 0 Then
                        If CLng(s) < 100 Then
                            output = output & " And " & FindNumber(CLng(s)) ' look up the number, no suffix   
                        Else                                                ' required as this is the last part  
                            output = output & " " & FindNumber(CLng(s))
                        End If
                    End If
                Else 'if its not the last element in the array  
                    If x <> 0 Then
                        If output = Nothing Then 'we have to check this so we don't add a leading space  
                            output = output & FindNumber(CLng(s)) & " " & FindSuffix(i, CLng(s)) 'look up the number and suffix  
                        Else 'spaces must go in the right place  
                            output = output & " " & FindNumber(CLng(s)) & " " & FindSuffix(i, CLng(s)) 'look up the snumber and suffix  
                        End If
                    End If
                End If
                i = i - 3 'reduce the suffix counter by 3 to step down to the next suffix  
            Next
        End If
        Return output
    End Function

    Private Shared Function FindNumber(ByVal Number As Long) As String
        Dim Words As String = Nothing
        Dim Digits() As String = {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven",
      "Eight", "Nine", "Ten"}
        Dim Teens() As String = {"", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen",
       "Eighteen", "Nineteen"}

        If Number < 11 Then
            Words = Digits(Number)

        ElseIf Number < 20 Then
            Words = Teens(Number - 10)

        ElseIf Number = 20 Then
            Words = "Twenty"

        ElseIf Number < 30 Then
            Words = "Twenty " & Digits(Number - 20)

        ElseIf Number = 30 Then
            Words = "Thirty"

        ElseIf Number < 40 Then
            Words = "Thirty " & Digits(Number - 30)

        ElseIf Number = 40 Then
            Words = "Fourty"

        ElseIf Number < 50 Then
            Words = "Fourty " & Digits(Number - 40)

        ElseIf Number = 50 Then
            Words = "Fifty"

        ElseIf Number < 60 Then
            Words = "Fifty " & Digits(Number - 50)

        ElseIf Number = 60 Then
            Words = "Sixty"

        ElseIf Number < 70 Then
            Words = "Sixty " & Digits(Number - 60)

        ElseIf Number = 70 Then
            Words = "Seventy"

        ElseIf Number < 80 Then
            Words = "Seventy " & Digits(Number - 70)

        ElseIf Number = 80 Then
            Words = "Eighty"

        ElseIf Number < 90 Then
            Words = "Eighty " & Digits(Number - 80)

        ElseIf Number = 90 Then
            Words = "Ninety"

        ElseIf Number < 100 Then
            Words = "Ninety " & Digits(Number - 90)

        ElseIf Number < 1000 Then
            Words = Number.ToString
            Words = Words.Insert(1, ",")
            Dim wparts As String() = Words.Split(",")
            Words = FindNumber(wparts(0)) & " " & "Hundred"
            Dim n As String = FindNumber(wparts(1))
            If CLng(wparts(1)) <> 0 Then
                Words = Words & " And " & n
            End If
        End If

        Return Words
    End Function

    Private Shared Function FindSuffix(ByVal Length As Long, ByVal l As Long) As String
        Dim word As String

        If l <> 0 Then
            If Length > 12 Then
                word = "Trillion"
            ElseIf Length > 9 Then
                word = "Billion"
            ElseIf Length > 6 Then
                word = "Million"
            ElseIf Length > 3 Then
                word = "Thousand"
            ElseIf Length > 2 Then
                word = "Hundred"
            Else
                word = ""
            End If
        Else
            word = ""
        End If

        Return word
    End Function
    Public Shared Function ConvertNumInGR(ByVal Input As Decimal) As String
        Dim Amount As Decimal = Math.Round(Input, 2)
        Dim sAmount As String = Amount.ToString
        Dim wparts As String() = sAmount.Split(",")
        '148,80
        On Error Resume Next

        Select Case wparts(0).Length
            Case 1
                Select Case Mid(wparts(0), 1, 1)
                    Case "1" : ConvertNumInGR = ConvertNumInGR & "Ένα  " & " Ευρώ "
                    Case "2" : ConvertNumInGR = ConvertNumInGR & "Δύο " & " Ευρώ "
                    Case "3" : ConvertNumInGR = ConvertNumInGR & "Τρία " & " Ευρώ "
                    Case "4" : ConvertNumInGR = ConvertNumInGR & "Τέσσερα " & " Ευρώ "
                    Case "5" : ConvertNumInGR = ConvertNumInGR & "Πέντε " & " Ευρώ "
                    Case "6" : ConvertNumInGR = ConvertNumInGR & "Έξι " & " Ευρώ "
                    Case "7" : ConvertNumInGR = ConvertNumInGR & "Εφτά " & " Ευρώ "
                    Case "8" : ConvertNumInGR = ConvertNumInGR & "Οκτώ " & " Ευρώ "
                    Case "9" : ConvertNumInGR = ConvertNumInGR & "Εννιά " & " Ευρώ "
                End Select
            Case 2
                Select Case Mid(wparts(0), 1, 1)
                    Case "1" : ConvertNumInGR = ConvertNumInGR & "Δέκα  "
                    Case "2" : ConvertNumInGR = ConvertNumInGR & "Είκοσι "
                    Case "3" : ConvertNumInGR = ConvertNumInGR & "Τριάντα "
                    Case "4" : ConvertNumInGR = ConvertNumInGR & "Σαράντα "
                    Case "5" : ConvertNumInGR = ConvertNumInGR & "Πενήντα "
                    Case "6" : ConvertNumInGR = ConvertNumInGR & "Εξήντα "
                    Case "7" : ConvertNumInGR = ConvertNumInGR & "Εβδομήντα "
                    Case "8" : ConvertNumInGR = ConvertNumInGR & "Ογδόντα "
                    Case "9" : ConvertNumInGR = ConvertNumInGR & "Ενενήντα "
                End Select
                If wparts.Length = 1 Then Return ConvertNumInGR
                Select Case Mid(wparts(0), 2, 1)
                    Case "1" : ConvertNumInGR = ConvertNumInGR & "Ένα  " & " Ευρώ "
                    Case "2" : ConvertNumInGR = ConvertNumInGR & "Δύο " & " Ευρώ "
                    Case "3" : ConvertNumInGR = ConvertNumInGR & "Τρία " & " Ευρώ "
                    Case "4" : ConvertNumInGR = ConvertNumInGR & "Τέσσερα " & " Ευρώ "
                    Case "5" : ConvertNumInGR = ConvertNumInGR & "Πέντε " & " Ευρώ "
                    Case "6" : ConvertNumInGR = ConvertNumInGR & "Έξι " & " Ευρώ "
                    Case "7" : ConvertNumInGR = ConvertNumInGR & "Επτά " & " Ευρώ "
                    Case "8" : ConvertNumInGR = ConvertNumInGR & "Οκτώ " & " Ευρώ "
                    Case "9" : ConvertNumInGR = ConvertNumInGR & "Εννιά " & " Ευρώ "
                End Select
                Select Case Mid(wparts(1), 1, 1)
                    Case "0" : ConvertNumInGR = ConvertNumInGR & IIf(Mid(wparts(1), 2, 1) > 0, " και ", "")
                    Case "1" : ConvertNumInGR = ConvertNumInGR & " και " & "Δέκα  "
                    Case "2" : ConvertNumInGR = ConvertNumInGR & " και " & "Είκοσι "
                    Case "3" : ConvertNumInGR = ConvertNumInGR & " και " & "Τριάντα "
                    Case "4" : ConvertNumInGR = ConvertNumInGR & " και " & "Σαράντα "
                    Case "5" : ConvertNumInGR = ConvertNumInGR & " και " & "Πενήντα "
                    Case "6" : ConvertNumInGR = ConvertNumInGR & " και " & "Εξήντα "
                    Case "7" : ConvertNumInGR = ConvertNumInGR & " και " & "Εβδομήντα "
                    Case "8" : ConvertNumInGR = ConvertNumInGR & " και " & "Ογδόντα "
                    Case "9" : ConvertNumInGR = ConvertNumInGR & " και " & "Ενενήντα "
                End Select
                Select Case Mid(wparts(1), 2, 1)
                    Case "0" : ConvertNumInGR = ConvertNumInGR & IIf(Mid(wparts(1), 1, 1) > 0, " Λεπτά ", "")
                    Case "1" : ConvertNumInGR = ConvertNumInGR & "Ένα  " & " Λεπτά "
                    Case "2" : ConvertNumInGR = ConvertNumInGR & "Δύο " & " Λεπτά "
                    Case "3" : ConvertNumInGR = ConvertNumInGR & "Τρία " & " Λεπτά "
                    Case "4" : ConvertNumInGR = ConvertNumInGR & "Τέσσερα " & " Λεπτά "
                    Case "5" : ConvertNumInGR = ConvertNumInGR & "Πέντε " & " Λεπτά "
                    Case "6" : ConvertNumInGR = ConvertNumInGR & "Έξι " & " Λεπτά "
                    Case "7" : ConvertNumInGR = ConvertNumInGR & "Επτά " & " Λεπτά "
                    Case "8" : ConvertNumInGR = ConvertNumInGR & "Οκτώ " & " Λεπτά "
                    Case "9" : ConvertNumInGR = ConvertNumInGR & "Εννιά " & " Λεπτά "
                End Select
            Case 3
                Select Case Mid(wparts(0), 1, 1)
                    Case "1" : ConvertNumInGR = "Εκατόν " 
                    Case "2" : ConvertNumInGR = "Διακόσια "
                    Case "3" : ConvertNumInGR = "Τριακόσια "
                    Case "4" : ConvertNumInGR = "Τετρακόσια "
                    Case "5" : ConvertNumInGR = "Πεντακόσια "
                    Case "6" : ConvertNumInGR = "Εξακόσια "
                    Case "7" : ConvertNumInGR = "Εφτακόσια "
                    Case "8" : ConvertNumInGR = "Οχτακόσια "
                    Case "9" : ConvertNumInGR = "Εννιακόσια "
                End Select
                Select Case Mid(wparts(0), 2, 1)
                    Case "1" : ConvertNumInGR = ConvertNumInGR & "Δέκα  "
                    Case "2" : ConvertNumInGR = ConvertNumInGR & "Είκοσι "
                    Case "3" : ConvertNumInGR = ConvertNumInGR & "Τριάντα "
                    Case "4" : ConvertNumInGR = ConvertNumInGR & "Σαράντα "
                    Case "5" : ConvertNumInGR = ConvertNumInGR & "Πενήντα "
                    Case "6" : ConvertNumInGR = ConvertNumInGR & "Εξήντα "
                    Case "7" : ConvertNumInGR = ConvertNumInGR & "Εβδομήντα "
                    Case "8" : ConvertNumInGR = ConvertNumInGR & "Ογδόντα "
                    Case "9" : ConvertNumInGR = ConvertNumInGR & "Ενενήντα "
                End Select
                Select Case Mid(wparts(0), 3, 1)
                    Case "1" : ConvertNumInGR = ConvertNumInGR & "Ένα  " & " Ευρώ "
                    Case "2" : ConvertNumInGR = ConvertNumInGR & "Δύο " & " Ευρώ "
                    Case "3" : ConvertNumInGR = ConvertNumInGR & "Τρία " & " Ευρώ "
                    Case "4" : ConvertNumInGR = ConvertNumInGR & "Τέσσερα " & " Ευρώ "
                    Case "5" : ConvertNumInGR = ConvertNumInGR & "Πέντε " & " Ευρώ "
                    Case "6" : ConvertNumInGR = ConvertNumInGR & "Έξι " & " Ευρώ "
                    Case "7" : ConvertNumInGR = ConvertNumInGR & "Επτά " & " Ευρώ "
                    Case "8" : ConvertNumInGR = ConvertNumInGR & "Οκτώ " & " Ευρώ "
                    Case "9" : ConvertNumInGR = ConvertNumInGR & "Εννιά " & " Ευρώ "
                End Select
                Select Case Mid(wparts(1), 1, 1)
                    Case "0" : ConvertNumInGR = ConvertNumInGR & IIf(Mid(wparts(1), 2, 1) > 0, " και ", "")
                    Case "1" : ConvertNumInGR = ConvertNumInGR & " και " & "Δέκα  "
                    Case "2" : ConvertNumInGR = ConvertNumInGR & " και " & "Είκοσι "
                    Case "3" : ConvertNumInGR = ConvertNumInGR & " και " & "Τριάντα "
                    Case "4" : ConvertNumInGR = ConvertNumInGR & " και " & "Σαράντα "
                    Case "5" : ConvertNumInGR = ConvertNumInGR & " και " & "Πενήντα "
                    Case "6" : ConvertNumInGR = ConvertNumInGR & " και " & "Εξήντα "
                    Case "7" : ConvertNumInGR = ConvertNumInGR & " και " & "Εβδομήντα "
                    Case "8" : ConvertNumInGR = ConvertNumInGR & " και " & "Ογδόντα "
                    Case "9" : ConvertNumInGR = ConvertNumInGR & " και " & "Ενενήντα "
                End Select
                Select Case Mid(wparts(1), 2, 1)
                    Case "0" : ConvertNumInGR = ConvertNumInGR & IIf(Mid(wparts(1), 1, 1) > 0, " Λεπτά ", "")
                    Case "1" : ConvertNumInGR = ConvertNumInGR & "Ένα  " & " Λεπτά "
                    Case "2" : ConvertNumInGR = ConvertNumInGR & "Δύο " & " Λεπτά "
                    Case "3" : ConvertNumInGR = ConvertNumInGR & "Τρία " & " Λεπτά "
                    Case "4" : ConvertNumInGR = ConvertNumInGR & "Τέσσερα " & " Λεπτά "
                    Case "5" : ConvertNumInGR = ConvertNumInGR & "Πέντε " & " Λεπτά "
                    Case "6" : ConvertNumInGR = ConvertNumInGR & "Έξι " & " Λεπτά "
                    Case "7" : ConvertNumInGR = ConvertNumInGR & "Επτά " & " Λεπτά "
                    Case "8" : ConvertNumInGR = ConvertNumInGR & "Οκτώ " & " Λεπτά "
                    Case "9" : ConvertNumInGR = ConvertNumInGR & "Εννιά " & " Λεπτά "
                End Select
            Case 4
                Select Case Mid(wparts(0), 1, 1)
                    Case "1" : ConvertNumInGR = "Χίλια "
                    Case "2" : ConvertNumInGR = "Δύο Χιλιάδες "
                    Case "3" : ConvertNumInGR = "Τρείς Χιλιάδες "
                    Case "4" : ConvertNumInGR = "Τέσσερις Χιλιάδες "
                    Case "5" : ConvertNumInGR = "Πέντε Χιλιάδες "
                    Case "6" : ConvertNumInGR = "Έξι Χιλιάδες  "
                    Case "7" : ConvertNumInGR = "Εφτά Χιλιάδες  "
                    Case "8" : ConvertNumInGR = "Οχτώ Χιλιάδες  "
                    Case "9" : ConvertNumInGR = "Εννιά Χιλιάδες  "
                End Select

                Select Case Mid(wparts(0), 2, 1)
                    Case "1" : ConvertNumInGR = ConvertNumInGR & "Εκατόν "
                    Case "2" : ConvertNumInGR = ConvertNumInGR & "Διακόσια "
                    Case "3" : ConvertNumInGR = ConvertNumInGR & "Τριακόσια "
                    Case "4" : ConvertNumInGR = ConvertNumInGR & "Τετρακόσια "
                    Case "5" : ConvertNumInGR = ConvertNumInGR & "Πεντακόσια "
                    Case "6" : ConvertNumInGR = ConvertNumInGR & "Εξακόσια "
                    Case "7" : ConvertNumInGR = ConvertNumInGR & "Εφτακόσια "
                    Case "8" : ConvertNumInGR = ConvertNumInGR & "Οχτακόσια "
                    Case "9" : ConvertNumInGR = ConvertNumInGR & "Εννιακόσια "
                End Select
                Select Case Mid(wparts(0), 3, 1)
                    Case "1" : ConvertNumInGR = ConvertNumInGR & "Δέκα  "
                    Case "2" : ConvertNumInGR = ConvertNumInGR & "Είκοσι "
                    Case "3" : ConvertNumInGR = ConvertNumInGR & "Τριάντα "
                    Case "4" : ConvertNumInGR = ConvertNumInGR & "Σαράντα "
                    Case "5" : ConvertNumInGR = ConvertNumInGR & "Πενήντα "
                    Case "6" : ConvertNumInGR = ConvertNumInGR & "Εξήντα "
                    Case "7" : ConvertNumInGR = ConvertNumInGR & "Εβδομήντα "
                    Case "8" : ConvertNumInGR = ConvertNumInGR & "Ογδόντα "
                    Case "9" : ConvertNumInGR = ConvertNumInGR & "Ενενήντα "
                End Select
                Select Case Mid(wparts(0), 4, 1)
                    Case "1" : ConvertNumInGR = ConvertNumInGR & "Ένα  " & " Ευρώ "
                    Case "2" : ConvertNumInGR = ConvertNumInGR & "Δύο " & " Ευρώ "
                    Case "3" : ConvertNumInGR = ConvertNumInGR & "Τρία " & " Ευρώ "
                    Case "4" : ConvertNumInGR = ConvertNumInGR & "Τέσσερα " & " Ευρώ "
                    Case "5" : ConvertNumInGR = ConvertNumInGR & "Πέντε " & " Ευρώ "
                    Case "6" : ConvertNumInGR = ConvertNumInGR & "Έξι " & " Ευρώ "
                    Case "7" : ConvertNumInGR = ConvertNumInGR & "Επτά " & " Ευρώ "
                    Case "8" : ConvertNumInGR = ConvertNumInGR & "Οκτώ " & " Ευρώ "
                    Case "9" : ConvertNumInGR = ConvertNumInGR & "Εννιά " & " Ευρώ "
                End Select
                Select Case Mid(wparts(1), 1, 1)
                    Case "0" : ConvertNumInGR = ConvertNumInGR & IIf(Mid(wparts(1), 2, 1) > 0, " και ", "")
                    Case "1" : ConvertNumInGR = ConvertNumInGR & " και " & "Δέκα  "
                    Case "2" : ConvertNumInGR = ConvertNumInGR & " και " & "Είκοσι "
                    Case "3" : ConvertNumInGR = ConvertNumInGR & " και " & "Τριάντα "
                    Case "4" : ConvertNumInGR = ConvertNumInGR & " και " & "Σαράντα "
                    Case "5" : ConvertNumInGR = ConvertNumInGR & " και " & "Πενήντα "
                    Case "6" : ConvertNumInGR = ConvertNumInGR & " και " & "Εξήντα "
                    Case "7" : ConvertNumInGR = ConvertNumInGR & " και " & "Εβδομήντα "
                    Case "8" : ConvertNumInGR = ConvertNumInGR & " και " & "Ογδόντα "
                    Case "9" : ConvertNumInGR = ConvertNumInGR & " και " & "Ενενήντα "
                End Select
                Select Case Mid(wparts(1), 2, 1)
                    Case "0" : ConvertNumInGR = ConvertNumInGR & IIf(Mid(wparts(1), 1, 1) > 0, " Λεπτά ", "")
                    Case "1" : ConvertNumInGR = ConvertNumInGR & "Ένα  " & " Λεπτά "
                    Case "2" : ConvertNumInGR = ConvertNumInGR & "Δύο " & " Λεπτά "
                    Case "3" : ConvertNumInGR = ConvertNumInGR & "Τρία " & " Λεπτά "
                    Case "4" : ConvertNumInGR = ConvertNumInGR & "Τέσσερα " & " Λεπτά "
                    Case "5" : ConvertNumInGR = ConvertNumInGR & "Πέντε " & " Λεπτά "
                    Case "6" : ConvertNumInGR = ConvertNumInGR & "Έξι " & " Λεπτά "
                    Case "7" : ConvertNumInGR = ConvertNumInGR & "Επτά " & " Λεπτά "
                    Case "8" : ConvertNumInGR = ConvertNumInGR & "Οκτώ " & " Λεπτά "
                    Case "9" : ConvertNumInGR = ConvertNumInGR & "Εννιά " & " Λεπτά "
                End Select
            Case 5
                Select Case Mid(wparts(0), 1, 2)
                    Case "10" : ConvertNumInGR = "Δέκα Χιλιάδες "
                    Case "11" : ConvertNumInGR = "Ένδεκα Χιλιάδες "
                    Case "12" : ConvertNumInGR = "Δώδεκα Χιλιάδες "
                    Case "13" : ConvertNumInGR = "Δέκα τρείς Χιλιάδες "
                    Case "14" : ConvertNumInGR = "Δέκα τέσσερις Χιλιάδες "
                    Case "15" : ConvertNumInGR = "Δέκα πέντες Χιλιάδες "
                    Case "16" : ConvertNumInGR = "Δέκα έξι Χιλιάδες "
                    Case "17" : ConvertNumInGR = "Δέκα επτά Χιλιάδες "
                    Case "18" : ConvertNumInGR = "Δέκα οκτώ Χιλιάδες "
                    Case "19" : ConvertNumInGR = "Δέκα εννιά Χιλιάδες "
                    Case "20" : ConvertNumInGR = "Είκοσι Χιλιάδες "
                    Case "21" : ConvertNumInGR = "Είκοσι ένα Χιλιάδες "
                    Case "22" : ConvertNumInGR = "Είκοσι δύο Χιλιάδες "
                    Case "23" : ConvertNumInGR = "Είκοσι τρείς Χιλιάδες "
                    Case "24" : ConvertNumInGR = "Είκοσι τέσσερις Χιλιάδες "
                    Case "25" : ConvertNumInGR = "Είκοσι πέντε Χιλιάδες "
                    Case "26" : ConvertNumInGR = "Είκοσι έξι Χιλιάδες "
                    Case "27" : ConvertNumInGR = "Είκοσι επτά Χιλιάδες "
                    Case "28" : ConvertNumInGR = "Είκοσι οκτώ Χιλιάδες "
                    Case "29" : ConvertNumInGR = "Είκοσι εννιά Χιλιάδες "
                    Case "30" : ConvertNumInGR = "Τριάντα Χιλιάδες "
                    Case "31" : ConvertNumInGR = "Τριάντα ένα Χιλιάδες "
                    Case "32" : ConvertNumInGR = "Τριάντα δύο Χιλιάδες "
                    Case "33" : ConvertNumInGR = "Τριάντα τρία Χιλιάδες "
                    Case "34" : ConvertNumInGR = "Τριάντα τέσσερις Χιλιάδες "
                    Case "35" : ConvertNumInGR = "Τριάντα πέντε Χιλιάδες "
                    Case "36" : ConvertNumInGR = "Τριάντα έξι Χιλιάδες "
                    Case "37" : ConvertNumInGR = "Τριάντα επτά Χιλιάδες "
                    Case "38" : ConvertNumInGR = "Τριάντα οκτώ Χιλιάδες "
                    Case "39" : ConvertNumInGR = "Τριάντα εννιά Χιλιάδες "
                    Case "40" : ConvertNumInGR = "Σαράντα Χιλιάδες "
                    Case "41" : ConvertNumInGR = "Σαράντα ένα Χιλιάδες "
                    Case "42" : ConvertNumInGR = "Σαράντα δυο Χιλιάδες "
                    Case "43" : ConvertNumInGR = "Σαράντα τρείς Χιλιάδες "
                    Case "44" : ConvertNumInGR = "Σαράντα τέσσερις Χιλιάδες "
                    Case "45" : ConvertNumInGR = "Σαράντα πέντε Χιλιάδες "
                    Case "46" : ConvertNumInGR = "Σαράντα έξι Χιλιάδες "
                    Case "47" : ConvertNumInGR = "Σαράντα εφτά Χιλιάδες "
                    Case "48" : ConvertNumInGR = "Σαράντα οκτώ Χιλιάδες "
                    Case "49" : ConvertNumInGR = "Σαράντα εννιά Χιλιάδες "
                    Case "50" : ConvertNumInGR = "Πενήντα Χιλιάδες "
                    Case "51" : ConvertNumInGR = "Πενήντα ένα Χιλιάδες "
                    Case "52" : ConvertNumInGR = "Πενήντα δύο Χιλιάδες "
                    Case "53" : ConvertNumInGR = "Πενήντα τρείς Χιλιάδες "
                    Case "54" : ConvertNumInGR = "Πενήντα τέσσερις Χιλιάδες "
                    Case "55" : ConvertNumInGR = "Πενήντα πεέντε Χιλιάδες "
                    Case "56" : ConvertNumInGR = "Πενήντα έξι Χιλιάδες "
                    Case "57" : ConvertNumInGR = "Πενήντα επτά Χιλιάδες "
                    Case "58" : ConvertNumInGR = "Πενήντα οκτώ Χιλιάδες "
                    Case "59" : ConvertNumInGR = "Πενήντα εννιά Χιλιάδες "
                    Case "60" : ConvertNumInGR = "Εξήντα Χιλιάδες "
                    Case "61" : ConvertNumInGR = "Εξήντα ένα Χιλιάδες "
                    Case "62" : ConvertNumInGR = "Εξήντα δυο Χιλιάδες "
                    Case "63" : ConvertNumInGR = "Εξήντα τρείς Χιλιάδες "
                    Case "64" : ConvertNumInGR = "Εξήντα τέσσερις Χιλιάδες "
                    Case "65" : ConvertNumInGR = "Εξήντα πέντε Χιλιάδες "
                    Case "66" : ConvertNumInGR = "Εξήντα έξι Χιλιάδες "
                    Case "67" : ConvertNumInGR = "Εξήντα εφτά Χιλιάδες "
                    Case "68" : ConvertNumInGR = "Εξήντα οκτώ Χιλιάδες "
                    Case "69" : ConvertNumInGR = "Εξήντα εννιά Χιλιάδες "
                    Case "70" : ConvertNumInGR = "Εβδομήντα Χιλιάδες "
                    Case "71" : ConvertNumInGR = "Εβδομήντα ένα Χιλιάδες "
                    Case "72" : ConvertNumInGR = "Εβδομήντα δυο Χιλιάδες "
                    Case "73" : ConvertNumInGR = "Εβδομήντα τρείς Χιλιάδες "
                    Case "74" : ConvertNumInGR = "Εβδομήντα τέσσερις Χιλιάδες "
                    Case "75" : ConvertNumInGR = "Εβδομήντα πέντε Χιλιάδες "
                    Case "76" : ConvertNumInGR = "Εβδομήντα έξι Χιλιάδες "
                    Case "77" : ConvertNumInGR = "Εβδομήντα εφτά Χιλιάδες "
                    Case "78" : ConvertNumInGR = "Εβδομήντα οκτώ Χιλιάδες "
                    Case "79" : ConvertNumInGR = "Εβδομήντα εννιά Χιλιάδες "
                    Case "80" : ConvertNumInGR = "Ογδόντα Χιλιάδες "
                    Case "81" : ConvertNumInGR = "Ογδόντα ένα Χιλιάδες "
                    Case "82" : ConvertNumInGR = "Ογδόντα δυο Χιλιάδες "
                    Case "83" : ConvertNumInGR = "Ογδόντα τρείς Χιλιάδες "
                    Case "84" : ConvertNumInGR = "Ογδόντα τέσσερις Χιλιάδες "
                    Case "85" : ConvertNumInGR = "Ογδόντα πέντε Χιλιάδες "
                    Case "86" : ConvertNumInGR = "Ογδόντα έξι Χιλιάδες "
                    Case "87" : ConvertNumInGR = "Ογδόντα εφτά Χιλιάδες "
                    Case "88" : ConvertNumInGR = "Ογδόντα οκτώ Χιλιάδες "
                    Case "89" : ConvertNumInGR = "Ογδόντα εννιά Χιλιάδες "
                    Case "90" : ConvertNumInGR = "Ενενήντα Χιλιάδες "
                    Case "91" : ConvertNumInGR = "Ενενήντα ένα Χιλιάδες "
                    Case "92" : ConvertNumInGR = "Ενενήντα δυο Χιλιάδες "
                    Case "93" : ConvertNumInGR = "Ενενήντα τρείς Χιλιάδες "
                    Case "94" : ConvertNumInGR = "Ενενήντα τέσσερις Χιλιάδες "
                    Case "95" : ConvertNumInGR = "Ενενήντα πέντε Χιλιάδες "
                    Case "96" : ConvertNumInGR = "Ενενήντα έξι Χιλιάδες "
                    Case "97" : ConvertNumInGR = "Ενενήντα εφτά Χιλιάδες "
                    Case "98" : ConvertNumInGR = "Ενενήντα οκτώ Χιλιάδες "
                    Case "99" : ConvertNumInGR = "Ενενήντα εννιά Χιλιάδες "
                    Case "100" : ConvertNumInGR = "Εκατό Χιλιάδες "
                End Select

                Select Case Mid(wparts(0), 3, 1)
                    Case "1" : ConvertNumInGR = ConvertNumInGR & "Εκατόν "
                    Case "2" : ConvertNumInGR = ConvertNumInGR & "Διακόσια "
                    Case "3" : ConvertNumInGR = ConvertNumInGR & "Τριακόσια "
                    Case "4" : ConvertNumInGR = ConvertNumInGR & "Τετρακόσια "
                    Case "5" : ConvertNumInGR = ConvertNumInGR & "Πεντακόσια "
                    Case "6" : ConvertNumInGR = ConvertNumInGR & "Εξακόσια "
                    Case "7" : ConvertNumInGR = ConvertNumInGR & "Εφτακόσια "
                    Case "8" : ConvertNumInGR = ConvertNumInGR & "Οχτακόσια "
                    Case "9" : ConvertNumInGR = ConvertNumInGR & "Εννιακόσια "
                End Select
                Select Case Mid(wparts(0), 4, 1)
                    Case "1" : ConvertNumInGR = ConvertNumInGR & "Δέκα  "
                    Case "2" : ConvertNumInGR = ConvertNumInGR & "Είκοσι "
                    Case "3" : ConvertNumInGR = ConvertNumInGR & "Τριάντα "
                    Case "4" : ConvertNumInGR = ConvertNumInGR & "Σαράντα "
                    Case "5" : ConvertNumInGR = ConvertNumInGR & "Πενήντα "
                    Case "6" : ConvertNumInGR = ConvertNumInGR & "Εξήντα "
                    Case "7" : ConvertNumInGR = ConvertNumInGR & "Εβδομήντα "
                    Case "8" : ConvertNumInGR = ConvertNumInGR & "Ογδόντα "
                    Case "9" : ConvertNumInGR = ConvertNumInGR & "Ενενήντα "
                End Select
                Select Case Mid(wparts(0), 5, 1)
                    Case "1" : ConvertNumInGR = ConvertNumInGR & "Ένα  " & " Ευρώ "
                    Case "2" : ConvertNumInGR = ConvertNumInGR & "Δύο " & " Ευρώ "
                    Case "3" : ConvertNumInGR = ConvertNumInGR & "Τρία " & " Ευρώ "
                    Case "4" : ConvertNumInGR = ConvertNumInGR & "Τέσσερα " & " Ευρώ "
                    Case "5" : ConvertNumInGR = ConvertNumInGR & "Πέντε " & " Ευρώ "
                    Case "6" : ConvertNumInGR = ConvertNumInGR & "Έξι " & " Ευρώ "
                    Case "7" : ConvertNumInGR = ConvertNumInGR & "Επτά " & " Ευρώ "
                    Case "8" : ConvertNumInGR = ConvertNumInGR & "Οκτώ " & " Ευρώ "
                    Case "9" : ConvertNumInGR = ConvertNumInGR & "Εννιά " & " Ευρώ "
                End Select
                Select Case Mid(wparts(1), 1, 1)
                    Case "0" : ConvertNumInGR = ConvertNumInGR & IIf(Mid(wparts(1), 2, 1) > 0, " και ", "")
                    Case "1" : ConvertNumInGR = ConvertNumInGR & " και " & "Δέκα  "
                    Case "2" : ConvertNumInGR = ConvertNumInGR & " και " & "Είκοσι "
                    Case "3" : ConvertNumInGR = ConvertNumInGR & " και " & "Τριάντα "
                    Case "4" : ConvertNumInGR = ConvertNumInGR & " και " & "Σαράντα "
                    Case "5" : ConvertNumInGR = ConvertNumInGR & " και " & "Πενήντα "
                    Case "6" : ConvertNumInGR = ConvertNumInGR & " και " & "Εξήντα "
                    Case "7" : ConvertNumInGR = ConvertNumInGR & " και " & "Εβδομήντα "
                    Case "8" : ConvertNumInGR = ConvertNumInGR & " και " & "Ογδόντα "
                    Case "9" : ConvertNumInGR = ConvertNumInGR & " και " & "Ενενήντα "
                End Select
                Select Case Mid(wparts(1), 2, 1)
                    Case "0" : ConvertNumInGR = ConvertNumInGR & IIf(Mid(wparts(1), 1, 1) > 0, " Λεπτά ", "")
                    Case "1" : ConvertNumInGR = ConvertNumInGR & "Ένα  " & " Λεπτά "
                    Case "2" : ConvertNumInGR = ConvertNumInGR & "Δύο " & " Λεπτά "
                    Case "3" : ConvertNumInGR = ConvertNumInGR & "Τρία " & " Λεπτά "
                    Case "4" : ConvertNumInGR = ConvertNumInGR & "Τέσσερα " & " Λεπτά "
                    Case "5" : ConvertNumInGR = ConvertNumInGR & "Πέντε " & " Λεπτά "
                    Case "6" : ConvertNumInGR = ConvertNumInGR & "Έξι " & " Λεπτά "
                    Case "7" : ConvertNumInGR = ConvertNumInGR & "Επτά " & " Λεπτά "
                    Case "8" : ConvertNumInGR = ConvertNumInGR & "Οκτώ " & " Λεπτά "
                    Case "9" : ConvertNumInGR = ConvertNumInGR & "Εννιά " & " Λεπτά "
                End Select

        End Select
    End Function
End Class
