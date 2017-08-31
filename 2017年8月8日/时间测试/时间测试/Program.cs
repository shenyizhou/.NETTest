using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 时间测试
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime a = Convert.ToDateTime("2017年8月9日 09:54:25");
            DateTime b = DateTime.Now;
            var c = DateTime.Compare(b, a);
            Console.WriteLine(a);
        }
    }
}
