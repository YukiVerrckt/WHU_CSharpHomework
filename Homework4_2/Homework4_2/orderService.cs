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
        public order addOrder(uint id,cilent customer )
        {
            foreach(order orderI in orderList)
            {

                if (orderI.Id == id)
                    throw new MyException("order has exsited");
            }

            order newOrder = new order(id, customer);
            orderList.Add(newOrder);
                Console.WriteLine("新增订单成功，编号为" + id);
            return newOrder;
        }

        public void deleteOrder(uint id)
        {
                foreach (order orderI in orderList)
                    if (orderI.Id == id)
                    {
                        orderList.Remove(orderI);
                        Console.WriteLine("删除成功");
                        return;
                    }
                throw new MyException("order does not exsit");
            
        }

        public void printOrder()
        {
            orderList.Sort();

            Console.Write("订单排序后：");
            foreach (var f in orderList)
            {
                Console.WriteLine(f.ToString() );
            }
        }

        public void searchOrder(string keyword)
        {

            foreach (order orderI in orderList)
            {
                if(orderI.Id.ToString()==keyword||orderI.Client.cilentId.ToString()== keyword || orderI.Client.cilentName == keyword)
                    Console.WriteLine(orderI.ToString());
                foreach (var detailI in orderI.detailList)
                {
                    if (detailI.productKind.productName == keyword)
                        Console.WriteLine(orderI.ToString());
                }
            }
            
        }
        public void priceSort()
        {
            orderList.Sort((a, b) =>(int)(a.calculate() - b.calculate()));
            foreach (var f in orderList)
            {
                Console.WriteLine(f.ToString()+"总价"+f.calculate().ToString());
            }
        }

    }
}
