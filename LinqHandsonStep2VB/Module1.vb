Module Module1

    Sub Main()
        Dim result = Hoge(DataGenerator.GenerateIntValues())
        Console.WriteLine(String.Format("値は{0}です", result))
        Console.ReadKey()
    End Sub

    Function Hoge(values As Integer()) As Integer
        ' TODO 問題
        ' 入力の配列のうち、5より大きい値の、最初の5個を掛け算した値を返す
        ' 入力の配列のうち、事前に10以上は除く
        ' 5より大きい値のうち、2の倍数は2倍する
        ' Return 0

        Dim list = New List(Of Integer)()
        For Each v In values
            If v >= 10 Then
                Continue For
            End If

            If v > 5 Then
                If v Mod 2 = 0 Then
                    list.Add(v * 2)
                Else
                    list.Add(v)
                End If
            End If

            If list.Count >= 5 Then
                Dim result = 0
                For Each v2 In list
                    result = result + v2
                Next
                Return result
            End If
        Next

        Return 0

    End Function

End Module