using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_2
{
    class orderDetail
    {
        public uint orderDetailId;
        public uint productNum=0;
        public product productKind;
        
        public orderDetail(uint id, product Goods, uint num)
        {
            this.orderDetailId = id;
            this.productKind = Goods;
            this.productNum = num;
            Console.WriteLine("商品条目添加成功");
        }
    }
}
