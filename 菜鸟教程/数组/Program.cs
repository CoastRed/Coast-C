using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 数组初始化
            int[] a = new int[3];
            a[0] = 1;
            a[1] = 2;
            a[2] = 3;

            int[] b = new int[] { 1, 2, 3 };

            int[] c = { 1, 2, 3 };
            #endregion

            #region 二维数组的创建
            int[,] d = new int[2, 4];

            int[][] e = new int[2][];
            e[0] = new int[2];
            e[1] = new int[3];
            #endregion

            #region 二维数组的初始化
            int[,] f = new int[2, 2];
            f[0, 0] = 1;
            f[0, 1] = 2;
            f[1, 0] = 3;
            f[1, 1] = 4;

            int[][] g = new int [2][];
            g[0] = new int[] { 0, 1 };
            g[1] = new int[] { 2, 3 ,4 };

            int[,] h = new int[2, 2] { { 0, 1 }, { 2, 3 } };
            int[,] l = new int[,] { { 0, 1 }, { 2, 3, } };
            int[,] m = { { 0, 1 }, { 2, 3 } };
            #endregion

            int[,] k = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(k[i,j] + " ");
                }
                Console.WriteLine();
            }
            int tmp;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    tmp = k[i, j];
                    k[i, j] = k[j, i];
                    k[j, i] = tmp;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(k[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
