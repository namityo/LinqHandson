using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHandson
{
    public class Record
    {
        public string Name { get; set; }
        public 性別 Sex { get; set; }
        public 教科 Subject { get; set; }
        public int Score { get; set; }

        public enum 性別
        {
            男,
            女,
            他
        }

        public enum 教科
        {
            国語,
            英語,
            算数,
            社会,
            理科
        }
    }
}
