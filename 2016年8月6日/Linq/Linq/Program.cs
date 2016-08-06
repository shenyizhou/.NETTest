using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] words = { "hello", "wonderful", "linq", "beautiful", "world" };
            //var shortWords = from word in words where word.Length <= 5 select word;
            //foreach (var word in shortWords)
            //{
            //    Console.WriteLine(word);
            //}

            string[] words = { "hello", "wonderful", "linq", "beautiful", "world" };

            var groups = 
                from word in words 
                orderby word ascending 
                group word by word.Length into lengthGroups 
                orderby lengthGroups.Key descending 
                select new { Length = lengthGroups.Key, words = lengthGroups };

            foreach (var group in groups)
            {
                Console.WriteLine("Words of length " + group.Length);
                foreach (string word in group.words)
                {
                    Console.WriteLine(" " + word);
                }
            }

            Console.ReadKey();
        }
    }
}
