using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 多播委托
{
    public delegate void DelTest();

    class Program
    {
        static void Main(string[] args)
        {
            DelTest del = Test1;
            del -= Test2; 
            del += Test2;
            
            del();

            Console.ReadKey();
        }

        static void Test1()
        {
            Console.WriteLine("我是Test1");
        }

        static void Test2()
        {
            Console.WriteLine("我是Test2");
        }
    }
}
