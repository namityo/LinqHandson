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
            var result = Hoge(DataGenerator.GenerateIntValues());
            Console.WriteLine($"値は{result}です");
            Console.ReadKey();
        }
        
        public static int Hoge(int[] values)
        {
            // TODO 問題
            // 入力の配列のうち、5より大きい値の、最初の5個を掛け算した値を返す
            return 0;
        }
    }
}
