using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
   public  class orderDetail
    {
        public int orderDetailId { get; set; }
        public int productNum { get; set; }
        public product productKind { get; set; }

        public orderDetail(int id, product Goods, int num)
        {
            this.orderDetailId = id;
            this.productKind = Goods;
            this.productNum = num;
            Console.WriteLine("商品条目添加成功");
        }

        public bool Equals(orderDetail other)
        {
            //this非空，obj如果为空，则返回false
            if (ReferenceEquals(null, other)) return false;

            //如果为同一对象，必然相等
            if (ReferenceEquals(this, other)) return true;

            //对比各个字段值
            if (this.orderDetailId == other.orderDetailId)
                return true;
            return true;
        }


        public override int GetHashCode()
        {
            return this.orderDetailId.GetHashCode();
        }
        public override string ToString()
        {
            return this.productKind.ToString();
        }

    }
}
