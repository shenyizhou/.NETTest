using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Delegate
{
    //public delegate void DelSayHi(string name);//参数与返回值与函数对应
    
    //public delegate string DelPro(string name);

    //public delegate void Del1();

    //public delegate void Del1(string s);

    //public delegate int Del1(string s);

    class Program
    {
        static void Main(string[] args)
        {
            //Thread th = new Thread(Method);//委托类型
            //把一个函数当作参数传递
            
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
            //list.RemoveAll(number => number > 2);
            //foreach (var number in list)
            //{
            //    Console.WriteLine(number);
            //}
            
            //DelSayHi del = new DelSayHi(SayHiChinese);
            //del("张三");//吃了吗张三

            //函数可以直接赋值给一个委托对象，委托的签名必须跟函数的签名一致
            //DelSayHi del = SayHiChinese;
            //del("张三");

            //SayHi("张三", SayHiChinese);

            //SayHi("张三", delegate(string name) 
            //{ 
            //    Console.WriteLine("Ohayo" + name); 
            //});

            //SayHi("张三", name => { Console.WriteLine("Ohayo" + name); });

            //string[] names = { "asDasDs", "dgreEFs", "dsdeDDf" };
            ////将所有元素转换为大写、小写或者元素两边加上双引号
            //ProString(names, name => name.ToLower());
            //foreach (string item in names)
            //{
            //    Console.WriteLine(item);
            //}

            //Del1 del1 = Test1;
            //Del1 del1 = delegate() { }; 
            // => goes to:去执行
            //Del1 del1 = () => { };

            //Del1 del1 = Test1;
            //Del1 del1 = delegate(string arg) { };
            //Del1 del1 = (arg) => { };

            //Del1 del1 = Test1;
            //Del1 del1 = delegate(string arg){return 10};
            //Del1 del1 = (arg) => { return 10; };

            //object[] pers = { new Person() { Name = "张三", Age = 18 }, new Person() { Age = 22, Name = "李四" } };


            Console.ReadKey();
        }

        //static void Method()
        //{
            
        //}

        //static void SayHi(string name, DelSayHi del)
        //{
        //    del(name);
        //}

        //static void SayHiChinese(string name)
        //{
        //    Console.WriteLine("吃了么？" + name);
        //}

        //static void SayHiEnglish(string name)
        //{
        //    Console.WriteLine("Ohayo" + name);
        //}

        //static void ProString(string[] names, DelPro del) 
        //{
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        names[i] = del(names[i]);
        //    }
        //}

        //static int Test1(string name)
        //{
        //    return 10;
        //}

        public class Person
        {
            public int Age { get; set; }
            public string Name { get; set; }
        }
    }
}
