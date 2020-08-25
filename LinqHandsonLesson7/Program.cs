using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHandson
{
    class Program
    {
        static void Main(string[] args)
        {
            // データを生成
            var records = DataGenerator.GenerateRecords();


            // 国語の点数の男子上位3人の名前
            var results = records
                .Where(r => r.Score <= 30)
                .OrderBy(r => r.Score)
                .Select(r => r.Name)
                .Distinct()
                .Select((n, i) => string.Format("{0}位 {1}", i + 1, n));


            // 結果表示
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }
    }
}
