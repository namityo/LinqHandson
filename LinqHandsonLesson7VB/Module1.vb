Module Module1

    Sub Main()
        ' データを生成
        Dim records = DataGenerator.GenerateRecords()


        ' ここに書く
        Dim results = records


        ' 結果表示
        For Each result In results
            Console.WriteLine(result)
        Next
        Console.ReadKey()
    End Sub

End Module
