using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_2
{
    class orderService
    {
        List<order> orderList = new List<order>();
        public orderService() { }
        public void addOrder(uint id,cilent customer )
        {
            foreach(order orderI in orderList)
            {
                if (orderI.Id == id)
                    throw new Exception("order has exsited");
            }

            order newOrder = new order(id, customer);
            orderList.Add(newOrder);
                Console.WriteLine("新增订单成功，编号为" + id);
        }

        public void deleteOrder(uint id)
        {
                foreach (order orderI in orderList)
                    if (orderI.Id == id)
                    {
                        orderList.Remove(orderI);
                        Console.WriteLine("删除成功");
                        break;
                    }
                throw new Exception("order does not exsit");
            
        }
        

    }
}
