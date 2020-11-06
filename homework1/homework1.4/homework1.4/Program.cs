using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1._4
{
    class Program
    {
        public static bool judge(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i, j] != matrix[(i + 1), (j + 1)])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[,] x = { { 1, 2, 3, 4 }, { 5, 1, 2, 3 }, { 9, 5, 1, 2 } };
            if (judge(x) == true)
            {
                Console.WriteLine("该矩阵是托普利茨矩阵");
            }
            else
            {
                Console.WriteLine("该矩阵不是托普利茨矩阵");
            }
            Console.ReadKey();
        }
    }
}
