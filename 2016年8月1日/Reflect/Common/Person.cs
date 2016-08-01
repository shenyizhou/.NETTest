using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Common
{
    public class Person
    {
        public void Write()
        {
            File.WriteAllText("1.txt","啦啦啦啦啦");
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public int Age { get; set; }

        public string Name { get; set; }

        public void SayHello()
        {
            Console.WriteLine("我是Person类中的函数");
        }
    }

    internal class Student
    {
        public void Write()
        {
            File.WriteAllText("1.txt", "啦啦啦啦啦");
        }

        public int Age { get; set; }

        public string Name { get; set; }

        public void SayHello()
        {
            Console.WriteLine("我是Person类中的函数");
        }
    }
}
