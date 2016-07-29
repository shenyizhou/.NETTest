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
            //Process[] pro = Process.GetProcesses();
            //foreach (var item in pro)
            //{
            //    //item.Kill();
            //    Console.WriteLine(item.ProcessName);
            //}

            //Process.Start("notepad");

            //ProcessStartInfo封装要打开的文件，但是不打开这个文件
            //ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\lang\Desktop\1.avi");
            //Process pro = new Process();
            //pro.StartInfo = psi;
            //pro.Start();

            //Console.WriteLine("Input the file path:");
            //string filePath = Console.ReadLine();
            //Console.WriteLine("Input the file name");
            //string fileName = Console.ReadLine();
            //ProcessStartInfo psi = new ProcessStartInfo(filePath + "\\" + fileName);
            //Process pro = new Process();
            //pro.StartInfo = psi;
            //pro.Start();

            Console.WriteLine("Input the file path:");
            string filePath = Console.ReadLine();
            Console.WriteLine("Input the file name");
            string fileName = Console.ReadLine();
            BaseFileClass bf = BaseFileClass.GetFile(filePath,fileName);
            if (bf != null)
            {
                bf.OpenFile();
            }
            Console.ReadKey();
        }
    }
}
