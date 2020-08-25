﻿using System;
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
            // 入力の配列のうち、事前に10以上は除く
            // 5より大きい値のうち、2の倍数は2倍する
            // return 0;

            var list = new List<int>();
            foreach (var v in values)
            {
                if (v >= 10)
                {
                    continue;
                }

                if (v > 5)
                {
                    if (v % 2 == 0)
                    {
                        list.Add(v * 2);
                    }
                    else
                    {
                        list.Add(v);
                    }
                }

                if (list.Count >= 5)
                {
                    var result = 0;
                    foreach (var v2 in list)
                    {
                        result = result + v2;
                    }
                    return result;
                }
            }

            return 0;
        }
    }
}