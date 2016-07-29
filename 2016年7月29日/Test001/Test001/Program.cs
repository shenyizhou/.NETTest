using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Test001
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] pro = Process.GetProcesses();
            foreach(var item in pro)
            {
                Console.WriteLine(item.ProcessName);
            }
            Console.ReadKey();
        }
    }
}
