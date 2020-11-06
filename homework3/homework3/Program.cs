using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace homework3
{
    class Program
    {
        public static List<Order> allOrders = new List<Order>(); //所有订单
        static void Main(string[] args)
        {
            bool ifNotExit = true;
            while (ifNotExit)
            {
                if (File.Exists("order.xml"))
                {
                    OrderServices od = new OrderServices();
                    allOrders = od.Import();
                }
                Console.WriteLine("请输入操作序号：");
                Console.WriteLine("1：增加订单，2：删除订单，3：查询订单，4：显示所有订单,5：退出");
                string choose1 = Console.ReadLine();
                switch (choose1)
                {
                    case "1":
                        int orderId = allOrders.Count() + 1;  //分配id
                        Console.WriteLine("请输入用户名：");
                        string customerName = Console.ReadLine();
                        OrderServices od = new OrderServices();
                        allOrders.Add(od.addOrder(orderId, customerName));
                        od.Export(allOrders);  //保存
                        break;

                    case "2":
                        Console.WriteLine("输入要删除的订单号：");
                        int id = Convert.ToInt32(Console.ReadLine());
                        OrderServices od1 = new OrderServices();
                        allOrders = od1.removeOrder(allOrders, id);
                        od1.Export(allOrders);  //保存
                        break;
                    case "3": 
                        Console.WriteLine("1:根据金额范围查询，2：根据用户名查询"); 
                        int i = Convert.ToInt32(Console.ReadLine());
                        OrderServices od2 = new OrderServices();
                        if (i == 1)
                        {
                            Console.WriteLine("输入金额上限：");
                            int maxinum = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("输入金额下限：");
                            int mininum = Convert.ToInt32(Console.ReadLine());
                            od2.searchOrderByMoney(mininum, maxinum, allOrders);
                        }
                        else if (i == 2)
                        {
                            Console.WriteLine("输入用户名：");
                            string name = Console.ReadLine();
                            od2.searchOrderByName(name, allOrders);
                        } 
                        break;
                    case "4":
                        OrderServices od3 = new OrderServices();
                        od3.ShowOrder(allOrders);
                        break;
                    case "5":
                        System.Environment.Exit(0);
                        break;
                    default: Console.WriteLine("输入错误"); break;
                }
            }
        }
    }
}
