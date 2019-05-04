using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    public class product
    {
        [Key]
        public double price { get; set; }
        public uint productId { get; set; }
        public string productName { get; set; }

        public product(double price,uint id,string name)        //商品初始化函数
        {
            this.price = price;
            this.productId = id;
            this.productName = name;
        }

        public override string ToString()
        {
            return $"商品ID:{productId}, 商品名:{productName}, 商品价格:{price}";
        }
    }
}
