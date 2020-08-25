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

            var result = values
                .Where(v => v < 10)
                .Where(v => v > 5)
                .Select(v => v % 2 == 0 ? v * 2 : v)
                .Take(5)
                .Sum();

            return result;
        }
    }
}
