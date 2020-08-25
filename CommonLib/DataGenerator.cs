using System;
using System.Collections.Generic;
using System.Linq;
using LinqHandson.Extensions;

namespace LinqHandson
{
    public class DataGenerator
    {
        public static int[] GenerateIntValues()
        {
            var A = 3;
            var B = 9;
            var M = 20;

            return Enumerable
                .Range(0, 1000)
                .SelectNm1((v, nm1) => (A * nm1 + B) % M)
                .ToArray();
        }

        public static int[] GenerateIntValues2()
        {
            return Enumerable.Range(0, 100).ToArray();
        }

        public static Record[] GenerateRecords()
        {
            return new Record[] {
                new Record { Name = "本田 武夫", Sex =  Record.性別.男, Subject = Record.教科.国語, Score = 50 },
                new Record { Name = "本田 武夫", Sex =  Record.性別.男, Subject = Record.教科.理科, Score = 35 },
                new Record { Name = "本田 武夫", Sex =  Record.性別.男, Subject = Record.教科.社会, Score = 100 },
                new Record { Name = "本田 武夫", Sex =  Record.性別.男, Subject = Record.教科.算数, Score = 15 },
                new Record { Name = "本田 武夫", Sex =  Record.性別.男, Subject = Record.教科.英語, Score = 45 },
                new Record { Name = "宮本 絵里", Sex =  Record.性別.女, Subject = Record.教科.国語, Score = 100 },
                new Record { Name = "宮本 絵里", Sex =  Record.性別.女, Subject = Record.教科.理科, Score = 10 },
                new Record { Name = "宮本 絵里", Sex =  Record.性別.女, Subject = Record.教科.社会, Score = 45 },
                new Record { Name = "宮本 絵里", Sex =  Record.性別.女, Subject = Record.教科.算数, Score = 35 },
                new Record { Name = "宮本 絵里", Sex =  Record.性別.女, Subject = Record.教科.英語, Score = 10 },
                new Record { Name = "阿部 博司", Sex =  Record.性別.男, Subject = Record.教科.国語, Score = 20 },
                new Record { Name = "阿部 博司", Sex =  Record.性別.男, Subject = Record.教科.理科, Score = 90 },
                new Record { Name = "阿部 博司", Sex =  Record.性別.男, Subject = Record.教科.社会, Score = 0 },
                new Record { Name = "阿部 博司", Sex =  Record.性別.男, Subject = Record.教科.算数, Score = 90 },
                new Record { Name = "阿部 博司", Sex =  Record.性別.男, Subject = Record.教科.英語, Score = 30 },
                new Record { Name = "柿沢 真美", Sex =  Record.性別.女, Subject = Record.教科.国語, Score = 60 },
                new Record { Name = "柿沢 真美", Sex =  Record.性別.女, Subject = Record.教科.理科, Score = 90 },
                new Record { Name = "柿沢 真美", Sex =  Record.性別.女, Subject = Record.教科.社会, Score = 50 },
                new Record { Name = "柿沢 真美", Sex =  Record.性別.女, Subject = Record.教科.算数, Score = 90 },
                new Record { Name = "柿沢 真美", Sex =  Record.性別.女, Subject = Record.教科.英語, Score = 90 },
                new Record { Name = "森林 次郎", Sex =  Record.性別.男, Subject = Record.教科.国語, Score = 70 },
                new Record { Name = "森林 次郎", Sex =  Record.性別.男, Subject = Record.教科.理科, Score = 60 },
                new Record { Name = "森林 次郎", Sex =  Record.性別.男, Subject = Record.教科.社会, Score = 40 },
                new Record { Name = "森林 次郎", Sex =  Record.性別.男, Subject = Record.教科.算数, Score = 80 },
                new Record { Name = "森林 次郎", Sex =  Record.性別.男, Subject = Record.教科.英語, Score = 65 },
                new Record { Name = "霧島 尚子", Sex =  Record.性別.女, Subject = Record.教科.国語, Score = 90 },
                new Record { Name = "霧島 尚子", Sex =  Record.性別.女, Subject = Record.教科.理科, Score = 95 },
                new Record { Name = "霧島 尚子", Sex =  Record.性別.女, Subject = Record.教科.社会, Score = 80 },
                new Record { Name = "霧島 尚子", Sex =  Record.性別.女, Subject = Record.教科.算数, Score = 100 },
                new Record { Name = "霧島 尚子", Sex =  Record.性別.女, Subject = Record.教科.英語, Score = 90 },
                new Record { Name = "斉藤 慎吾", Sex =  Record.性別.男, Subject = Record.教科.国語, Score = 100 },
                new Record { Name = "斉藤 慎吾", Sex =  Record.性別.男, Subject = Record.教科.理科, Score = 100 },
                new Record { Name = "斉藤 慎吾", Sex =  Record.性別.男, Subject = Record.教科.社会, Score = 100 },
                new Record { Name = "斉藤 慎吾", Sex =  Record.性別.男, Subject = Record.教科.算数, Score = 100 },
                new Record { Name = "斉藤 慎吾", Sex =  Record.性別.男, Subject = Record.教科.英語, Score = 100 },
            };
        }
    }
}
