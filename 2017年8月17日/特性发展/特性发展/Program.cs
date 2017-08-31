using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 特性发展
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            bool b = a > null;
            bool c = a < null;
            var d = a.HasValue;
            var e = 1;
            List<string> s = new List<string> {null,"","2","3",null};
            s.FindAll(delegate (string aa) { return aa != null; }).ForEach(Console.WriteLine);
            bool ss = "" == null;
            var ee = 1;
        }
    }
}
