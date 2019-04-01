using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_2
{
   class order:IEquatable<order>,IComparable
    {
        public uint Id { get; set;}     //订单编号
        private double price;           //订单总价
        public cilent Client { get; set; }      //客户

        public List<orderDetail> detailList = new List<orderDetail>();      //订单细节列表

        public order(){ }
        public order(uint order_no, cilent Client) { this.Id = order_no; this.Client = Client; }        //创建订单

        public double calculate()           //计算订单总价函数
        {
            price = 0.0;
            foreach (var detailI in detailList)
            {
               
                this.price += detailI.productNum * detailI.productKind.Price;
            }
            return this.price;
        }
        public void addDetail(orderDetail details)      //添加细节
        {
            foreach (orderDetail detailI in detailList)
            {
                if (details.Equals(detailI))            //判断细节是否重复
                {
                    Console.WriteLine("订单重复！");
                    return;
                }
                if (detailI.productKind == details.productKind)     //同样商品进行合并
                {
                    detailI.productNum += details.productNum;
                    Console.WriteLine("商品数量添加成功");
                    return;
                }
            }
            detailList.Add(details);

        }
        public void deleteDetail(uint Id)           //删除细节
        {
            foreach (orderDetail detailI in detailList)
            {
                if (detailI.orderDetailId == Id)
                {
                    detailList.Remove(detailI);
                    return;
                }
            }
            Console.WriteLine("detail not exsit");
        }


        public int CompareTo(object obj)            //重写CompareTo
        {
            if (obj == null) return 1;
            order otherOrder = obj as order;
            if (this.Id > otherOrder.Id)
                return 1; 
            else
                return -1;      
        }

        public bool Equals(order other)             
        {
            //this非空，obj如果为空，则返回false
            if (ReferenceEquals(null, other)) return false;

            //如果为同一对象，必然相等
            if (ReferenceEquals(this, other)) return true;

            //对比各个字段值
            if (this.Id==other.Id)
                return true;
            return true;
        }

        public override bool Equals(object obj)
        {
            //this非空，obj如果为空，则返回false
            if (ReferenceEquals(null, obj)) return false;

            //如果为同一对象，必然相等
            if (ReferenceEquals(this, obj)) return true;

            //如果类型不同，则必然不相等
            if (obj.GetType() != this.GetType()) return false;

            return Equals((order)obj);
        }
        public bool include(string keyword)
        {
            foreach(orderDetail I in detailList)
            {
                if (I.productKind.productName == keyword)
                    return true;
            }
            return  false;
        }
        public override int GetHashCode()       //重写HashCode
        {
            return this.Id.GetHashCode();
        }

        public override string ToString()          //重写ToString
        {
            return $"订单号:{Id}, 客户ID:{this.Client.cilentId}, 客户名:{this.Client.cilentName},细节列表:{this.detailList[0].ToString()}";
        }

    }

}
