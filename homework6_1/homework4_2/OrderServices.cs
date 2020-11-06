using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace homework4_2
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

        public List<Order> removeOrder(List<Order> order, int id)           //删除订单
        {
            for(int i = 0; i < order.Count(); i++)
            {
                if (order[i].id == id)
                {
                    order.RemoveAt(i);
                }
            }          
            return order;
        }

        public List<Order> searchOrderByMoney(int minNum, int maxNum, List<Order> orders)  //查询订单
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
                return requiredOrderList;
        }

        public List<Order> searchOrderByName(string customerName, List<Order> orders)
        {
            var query2 = from s2 in orders
                         where s2.customerName == customerName
                         orderby s2.totalPrice
                         select s2;
            List<Order> requiredOrderList = query2.ToList();
            return requiredOrderList;
        }
    }
}
