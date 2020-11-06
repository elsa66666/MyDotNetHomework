using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Linq;

namespace homework3
{
    [Serializable]
    public class OrderServices
    {
        public void Export(List<Order> order) //object -> xml
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream theXmlFileToCreate = new FileStream("order.xml", FileMode.Create))
            {
                serializer.Serialize(theXmlFileToCreate, order);
            }
        }

        public List<Order> Import()  //xml -> object
        {
            
            XmlSerializer serializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream theXmlFile = new FileStream("order.xml", FileMode.Open))
            {
                List<Order> deserializedObjects = (List<Order>)serializer.Deserialize(theXmlFile);
                return deserializedObjects;
            }
        }

        public void ShowOrder(List<Order> order)
        {
            Console.WriteLine("订单号 客户 总金额");
            Console.WriteLine("--------------------------------");
            foreach (Order anOrderToShow in order)
            {
                Console.WriteLine("{0}      {1}   :{2}", anOrderToShow.id, anOrderToShow.customerName, anOrderToShow.totalPrice);
                Console.WriteLine("\n");
                anOrderToShow.showOrderItem();
                Console.WriteLine("\n");
            }
        }
        
        public Order addOrder(int id, string customerName)          //增加订单
        {    
            Order anOrderToAdd = new Order(id, customerName);
            Console.WriteLine("输入订单项：");
            bool judge = true;

            while (judge)
            {
                Console.WriteLine("请输入物品名称：");
                string name = Console.ReadLine();
                Console.WriteLine("请输入购买数量：");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入单价：");
                double price = Convert.ToDouble(Console.ReadLine());
                anOrderToAdd.addItemToOrder(name, number, price);
                Console.WriteLine("是否继续添加订单项：");
                string x = Console.ReadLine();
                if (x == "否") judge = false;
                else if (x == "是") continue;
                else if (x != "否" && x != "是")
                {
                    Exception e = new Exception();
                    throw e;
                }
            }
            anOrderToAdd.getAllPrice();
            Console.WriteLine("添加成功"); 
            
            return anOrderToAdd;           
        }

        public List<Order> removeOrder(List<Order> order, int id)           //删除订单
        {
  
            int index = 0;
            foreach (Order anOrderToRemove in order)
            {
                if (anOrderToRemove.id == id) index = order.IndexOf(anOrderToRemove);
            }
            Console.WriteLine("输入1删除订单，输入2继续删除订单明细");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1: 
                    order.RemoveAt(index); 
                    Console.WriteLine("删除成功"); 
                    break;
                case 2: 
                    order[index].showOrderItem(); 
                    order[index].RemoveItemFromOrder(id); 
                    break;
                default: Console.WriteLine("输入错误"); break;
            }
            return order;
        }

        public void searchOrderByMoney(int minNum, int maxNum, List<Order> orders)  //查询订单
        {
            try
            {
                var query1 = from s1 in orders
                             where maxNum > s1.totalPrice
                             orderby s1.totalPrice
                             select s1;

                var query3 = from s3 in query1
                             where s3.totalPrice > minNum
                             orderby s3.totalPrice
                             select s3;

                List<Order> requiredOrderList = query3.ToList();
                Console.WriteLine("订单号 客户 总金额");
                Console.WriteLine("--------------------------------");
                foreach (Order requiredOrder in requiredOrderList)
                {                    
                    Console.WriteLine("{0}      {1}   :{2}", requiredOrder.id, requiredOrder.customerName, requiredOrder.totalPrice);
                    requiredOrder.showOrderItem();
                    Console.WriteLine("\n");
                }
            }
            catch
            {
                Console.WriteLine("输入错误");
            }
        }

        public void searchOrderByName(string customerName, List<Order> orders)
        {
            var query2 = from s2 in orders
                         where s2.customerName == customerName
                         orderby s2.totalPrice
                         select s2;
            List<Order> requiredOrderList = query2.ToList();
            if (requiredOrderList.Count() == 0)
            {
                Console.WriteLine("查无此用户");
            }
            Console.WriteLine("订单号 客户 总金额");
            Console.WriteLine("--------------------------------");
            foreach (Order requiredOrder in requiredOrderList)
            {
                Console.WriteLine("{0}      {1}   :{2}", requiredOrder.id, requiredOrder.customerName, requiredOrder.totalPrice);
                requiredOrder.showOrderItem();
                Console.WriteLine("\n");
            }
        }
    }
}
