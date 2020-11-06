using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace homework4_2
{
        //商品名， 购买数量， 单价
        [Serializable]
        public class OrderDetails
        {
            private int orderID;
            public int OrderID
            {
                get { return orderID; }
                set { orderID = value; }
            }
            private int itemID;
            public int ItemID
            {
                get { return itemID; }
                set { itemID = value; }
            }
        private string itemName;
            public string ItemName
            {
                get
                {
                    return itemName;
                }
                set
                {
                    if (value != null)
                    {
                        itemName = value;
                    }
                    else Console.WriteLine("商品名不能为空！");

                }
            }
            private int amountBought;
            public int AmountBought
            {
                get
                {
                    return amountBought;
                }
                set
                {
                    if (value >= 0)
                    {
                        amountBought = value;
                    }
                    else Console.WriteLine("购买数量应大于0.");
                }
            }
            private double perPrice;
            public double PerPrice
            {
                get
                {
                    return perPrice;
                }
                set
                {
                    perPrice = value;
                }
            }
            public OrderDetails()//无参构造函数
            {
                this.itemName = string.Empty;
                this.amountBought = 0;
                this.perPrice = 0;
            }
            public OrderDetails(int orderID, int itemID,string name, int number, double price)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          
            {
                this.orderID = orderID;
                this.itemID = itemID;
                this.itemName = name;
                this.amountBought = number;
                this.perPrice = price;
            }

            public double getTotalPriceOftheItem()
            {
                return this.amountBought * this.perPrice;
            }
        }

}
