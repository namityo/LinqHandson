Module Module1

    Sub Main()
        ' データを生成
        Dim records = DataGenerator.GenerateRecords()


        ' 国語の点数の男子上位3人の名前
        Dim results = records


        ' 結果表示
        For Each result In results
            Console.WriteLine(result)
        Next
        Console.ReadKey()
    End Sub

End Module
