using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1._2
{
    class Program
    {
        static int[] num = { 2, 3, 5, 7, 3, 5, 7, 83, 2, 5 };
        static int[] cal = { 0, 0, 0, 0};
        public static void Calculate(int[] num)
        {
            int max = num[0];
            int min = num[0];
            double average = 0;
            int sum = 0;
            for (int i = 0; i < num.Count(); i++)
            {
                if (max < num[i])
                {
                    max = num[i];
                }
                if(min > num[i])
                {
                    min = num[i];
                }
                sum += num[i];
            }
            average = Convert.ToDouble(sum) / Convert.ToDouble(num.Count());
            cal[0] = max;
            cal[1] = min;
            cal[2] = Convert.ToInt32(average * 100);
            cal[3] = sum;
        }


        static void Main(string[] args)
        {
            Calculate(num);
            Console.WriteLine("max:{0}, min:{1}, average:{2}, sum:{3}", cal[0], cal[1], Convert.ToDouble(cal[2])/Convert.ToDouble(100), cal[3]);
            Console.ReadKey();
        }
    }
}
