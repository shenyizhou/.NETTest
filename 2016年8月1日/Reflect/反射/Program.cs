using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;

namespace 反射
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Common.dll");
            Assembly ass = Assembly.LoadFile(path);
            Console.WriteLine("加载程序集成功！！");

            #region 获得程序集数据的三个函数
            //获得公开的数据(public
            //Type[] types = ass.GetExportedTypes();

            //获得所有的数据
            //Type[] types = ass.GetTypes();
            
            //foreach (Type item in types)
            //{
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine(item.FullName);
            //    Console.WriteLine(item.Namespace);
            //}

            //获得一个
            //Type type = ass.GetType("Common.Person");
            //Console.WriteLine(type.Name);
            #endregion

            //调用Person类中无参的构造函数
            //object o = ass.CreateInstance("Common.Person");
            //Console.WriteLine(o.GetType());

            //Console.WriteLine(typeof(Person));

            Type t = ass.GetType("Common.Person");
            object o = Activator.CreateInstance(t, "张三", 18);

            PropertyInfo[] props = o.GetType().GetProperties();
            foreach (PropertyInfo item in props)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            MethodInfo[] methods = o.GetType().GetMethods();
            foreach (MethodInfo item in methods)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }

    class Person
    { }
}
