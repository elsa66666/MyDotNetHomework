using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1._1
{
    class Program
    {
        static List<int> list1 = new List<int>();
        public static void getFactors(int x)
        {
            for (int factor = 2; factor * factor <= x; factor++)
            {
                while (x % factor == 0)
                {
                    if (!list1.Contains(factor)) //去重
                    {
                        list1.Add(factor);
                    }
                    x = x / factor;
                }
            }

            if (x != 1)  //元素本身为质数
            {
                list1.Add(x);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数字：");
            string str = Console.ReadLine();
            try
            {
                int x = Convert.ToInt32(str);
                if (x > 1)
                {
                    list1.Clear();
                    getFactors(x);
                    for (int i = 0; i < list1.Count; i++)
                    {
                        Console.Write(list1[i] + "\t");
                    }
                }
                else
                {
                    Console.WriteLine("该数没有质因子！");
                }
            }
            catch
            {
                Console.WriteLine("请输入正整数！");
            }
            Console.ReadKey();
        }
    }
}
