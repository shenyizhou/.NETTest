using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace Test001
{
    class BaseFileClass
    {
        //字段、属性、构造函数、函数、索引器
        //private string _filePath;
        //public string FilePath
        //{
        //    get
        //    {
        //        return this._filePath;
        //    }
        //    set
        //    {
        //        this._filePath = value;
        //    }
        //}
        
        private string _filePath;
        //可以对属性的读写进行限定或者扩展的操作，但变量不行
        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        //自动属性
        public string FileName { get; set; }

        //public BaseFileClass() { }

        public BaseFileClass(string filePath, string fileName)
        {
            this.FilePath = filePath;
            this.FileName = fileName;
        }

        public void OpenFile()
        {
            ProcessStartInfo psi = new ProcessStartInfo(FilePath + "\\" + FileName);
            Process pro = new Process();
            pro.StartInfo = psi;
            pro.Start();
        }

        //工厂模式
        public static BaseFileClass GetFile(string filePath,string fileName)
        {
            BaseFileClass bf = null;
            string strExtension = Path.GetExtension(fileName);
            switch (strExtension)
            {
                case ".avi":
                    bf = new AviFileClass(filePath,fileName);
                    break;
                case ".txt":
                    bf = new TxtFileClass(filePath, fileName);
                    break;
            }
            return bf;
        }
    }
}
