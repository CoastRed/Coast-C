//using 关键字用于在程序中包含命名空间。一个程序可以包含多个 using 语句。
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基本语法
{
    //class 关键字用于声明一个类。
    class Rectangle
    {
        //注释是用于解释代码。编译器会忽略注释的条目。在 C# 程序中，多行注释以 /* 开始，并以字符 */ 终止，单行注释是用 '//' 符号表示。
        //成员变量
        //变量是类的属性或数据成员，用于存储数据。在下面的程序中，Rectangle 类有两个成员变量，名为 length 和 width。
        double length;
        double width;

        //成员函数
        //函数是一系列执行指定任务的语句。类的成员函数是在类内声明的。
        public void Acceptdetails()
        {
            length = 4.5;
            width = 3.5;
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }

    //在下面的程序中，类 ExecuteRectangle 是一个包含 Main() 方法和实例化 Rectangle 类的类。
    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            //实例化一个类
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();
        }
    }
}