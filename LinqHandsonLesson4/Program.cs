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
            return 0;
        }
    }
}
