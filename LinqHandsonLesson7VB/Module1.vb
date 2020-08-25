Module Module1

    Sub Main()
        ' データを生成
        Dim records = DataGenerator.GenerateRecords()


        ' 国語の点数の男子上位3人の名前
        Dim results = records _
            .Where(Function(r) r.Score <= 30) _
            .OrderBy(Function(r) r.Score) _
            .Select(Function(r) r.Name) _
            .Distinct() _
            .Select(Function(n, i) String.Format("{0}位 {1}", i + 1, n))


        ' 結果表示
        For Each result In results
            Console.WriteLine(result)
        Next
        Console.ReadKey()
    End Sub

End Module
