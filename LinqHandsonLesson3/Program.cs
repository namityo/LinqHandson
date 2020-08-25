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
            var data = DataGenerator.GenerateIntValues2();



            // ここに書く
            var results = data.OrderByDescending(v => v);



            // 結果表示
            foreach (var result in results)
            {
                Console.WriteLine($"値は{result}です");
            }
            Console.ReadKey();
        }
    }
}
