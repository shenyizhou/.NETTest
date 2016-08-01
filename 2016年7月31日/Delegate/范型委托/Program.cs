using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 范型委托
{
    public delegate int DelCompare<T>(T arg,T max);

    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = {12,4,5,65678,6,796756,123};
            //int max = getMax<int>(nums, (arg, amax) => { return arg - amax; });
            //Console.WriteLine("max:" + max);

            //List<int> list = new List<int>() { 1, 2, 3, 5, 6, 7, 7, 8, 934, 53 };
            //foreach (var item in list)
            //{
            //    Console.Write(item +" ");
            //}
            //Console.WriteLine();

            //IEnumerable<int> ienumerable = list.Where<int>(n => { return n > 5; });
            //foreach (var item in ienumerable)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            //IEnumerable<int> ienumerable = list.Where(n => { return n > 5; });
            //foreach (var item in ienumerable)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            Console.ReadKey();
        }

        static T getMax<T>(T[] args,DelCompare<T> del)
        {
            T max = args[0];
            for(int i=0;i<args.Length;i++)
            {
                if (del(args[i], max) > 0)
                {
                    max = args[i];
                }
            }
            return max;
        }
    }
}
