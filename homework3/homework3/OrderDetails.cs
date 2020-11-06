using System;

namespace homework3
{
    //商品名， 购买数量， 单价
    [Serializable]
    public class OrderDetails
    {

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
                if (perPrice > 0)
                {
                    perPrice = value;
                }
                else  Console.WriteLine("单价应大于0."); 
            }
        }
        public OrderDetails()//无参构造函数
        {
            this.itemName = string.Empty;
            this.amountBought = 0;
            this.perPrice = 0;
        }
        public OrderDetails(string name, int number, double price)
        {
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
