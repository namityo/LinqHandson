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
            Console.WriteLine(string.Format("値は{0}です", result));
            Console.ReadKey();
        }

        public static int Hoge(int[] values)
        {
            // TODO 問題
            // 入力の配列のうち、5より大きい値の、最初の5個を掛け算した値を返す
            // 入力の配列のうち、事前に10以上は除く
            // 5より大きい値のうち、2の倍数は2倍する
            return 0;
        }
    }
}
