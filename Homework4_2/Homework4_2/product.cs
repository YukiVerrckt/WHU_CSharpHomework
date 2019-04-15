using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_2
{
    public class product
    {
        private double price;
        public uint productId { get; set; }
        public string productName { get; set; }

        public product(double price,uint id,string name)        //商品初始化函数
        {
            this.price = price;
            this.productId = id;
            this.productName = name;
        }

        public double Price
        {
            get { return price; }
            set {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("value must >= 0!");
                price = value;
            }
        }
        public override string ToString()
        {
            return $"商品ID:{productId}, 商品名:{productName}, 商品价格:{Price}";
        }
    }
}
