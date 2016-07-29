using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test001
{
    class AviFileClass:BaseFileClass
    {
        //子类会去调用父类的无参构造函数
        public AviFileClass(string filePath, string fileName) : base(filePath, fileName) { }
    }
}
