using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 流程控制
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入银行的简称:");
            string str2 = Console.ReadLine();
            switch (str2)
            {
                case "ICBC":Console.WriteLine("中国工商银行");
                    break;
                case "CBC":Console.WriteLine("中国建设银行");
                    break;
                case "ABC":Console.WriteLine("中国农业银行");
                    break;
                default:Console.WriteLine("输入的银行简称错误");
                    break;
            }
            Console.ReadKey();
            #region if...else...语句
            Console.WriteLine("请输入一个整数：");
            int iNum = Convert.ToInt32(Console.ReadLine());
            if (iNum % 2 == 0)
            {
                Console.WriteLine("输入值为整数");
            }
            else
            {
                Console.WriteLine("输入值为奇数");
            }
            Console.ReadKey();
            #endregion

            #region 三元表达式
            Console.WriteLine("请输入一个整数:");
            int iNum1 = Convert.ToInt32(Console.ReadLine());
            string str1 = iNum1 % 2 == 0 ? "是偶数" : "是奇数";
            Console.WriteLine(str1);
            Console.ReadKey();
            #endregion
        }
    }
}
