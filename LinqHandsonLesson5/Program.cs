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
                .Where(r => r.Subject == Record.教科.国語)
                .Where(r => r.Sex == Record.性別.男)
                .OrderByDescending(r => r.Score)
                .Take(3)
                .Select(r => r.Name);


            // 結果表示
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }
    }
}
