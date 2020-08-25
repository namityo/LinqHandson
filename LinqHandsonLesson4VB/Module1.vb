Module Module1

    Sub Main()
        Dim result = Hoge(DataGenerator.GenerateIntValues())
        Console.WriteLine(String.Format("値は{0}です", result))
        Console.ReadKey()
    End Sub

    Function Hoge(values As Integer()) As Integer

        Dim result = values _
            .Where(Function(v) v < 10) _
            .Where(Function(v) v > 5) _
            .Select(Function(v) If(v Mod 2 = 0, v * 2, v)) _
            .Take(5) _
            .Sum()

        Return result

    End Function

End Module