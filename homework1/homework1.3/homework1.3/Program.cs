using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1._3
{
    class Program
    {
        static List<int> list1 = new List<int>();
        
        static void Main(string[] args)
        {
            for(int i = 2; i < 101; i++)
            {
                list1.Add(i);
            }
            for(int i = 2; i < 101; i++)
            {
                for(int j = 0; j < list1.Count(); j++)
                { 
                    if((list1[j] % i == 0)&&(list1[j] != i))
                    {
                        list1.Remove(list1[j]);
                    }
                }
            }
            for(int i = 0; i < list1.Count(); i++)
            {
                Console.Write(list1[i] + "\t");
            }
            Console.ReadKey(); 
        }
    }
}
