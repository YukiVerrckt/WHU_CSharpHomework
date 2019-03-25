using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_2
{
   class order
    {
        public uint Id { get; set;}
        public cilent Client { get; set; }

        private List<orderDetail> detailList = new List<orderDetail>();

        public order(uint order_no, cilent Client) { this.Id = order_no; this.Client = Client; }

        public void addDetail(orderDetail details)
        {
            foreach (orderDetail detailI in detailList)
            {
                if (detailI.productKind == details.productKind)
                {
                    detailI.productNum += details.productNum;
                    Console.WriteLine("商品数量添加成功");
                    return;
                }
            }
            detailList.Add(details);

        }
        public void deleteDetail(uint Id)
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
    }

}
