Module Module1

    Sub Main()
        ' データを生成
        Dim data = DataGenerator.GenerateIntValues2()


        ' ここに書く
        Dim results = data



        ' 結果表示
        For Each result In results
            Console.WriteLine(String.Format("値は{0}です", result))
        Next
        Console.ReadKey()
    End Sub

End Module
