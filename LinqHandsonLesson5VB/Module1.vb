Module Module1

    Sub Main()
        ' データを生成
        Dim records = DataGenerator.GenerateRecords()


        ' 国語の点数の男子上位3人の名前
        Dim results = records _
            .Where(Function(r) r.Subject = Record.教科.国語) _
            .Where(Function(r) r.Sex = Record.性別.男) _
            .OrderByDescending(Function(r) r.Score) _
            .Take(3) _
            .Select(Function(r) r.Name)


        ' 結果表示
        For Each result In results
            Console.WriteLine(result)
        Next
        Console.ReadKey()
    End Sub

End Module
