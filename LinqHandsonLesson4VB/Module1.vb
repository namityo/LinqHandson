Module Module1

    Sub Main()
        Dim result = Hoge(DataGenerator.GenerateIntValues())
        Console.WriteLine(String.Format("値は{0}です", result))
        Console.ReadKey()
    End Sub

    Function Hoge(values As Integer()) As Integer

        Return 0

    End Function

End Module