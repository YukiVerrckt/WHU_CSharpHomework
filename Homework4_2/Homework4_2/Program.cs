using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_2
{

    class Program
    {
        static void Main(string[] args)
        {
            orderService orderManage = new orderService();
            string menuKey;
            List<cilent> cilentList = new List<cilent>();
            cilent customer1 = new cilent(1, "Customer1");
            cilent customer2 = new cilent(2, "Customer2");
            cilentList.Add(customer1); cilentList.Add(customer2);

            product milk = new product(69.9, 1, "Milk");
            product eggs = new product(4.99, 2, "eggs");
            product apple = new product(5.99, 3, "apple");

            orderDetail orderDetails1 = new orderDetail(1, apple, 8);
            orderDetail orderDetails2 = new orderDetail(2, eggs, 2);
            orderDetail orderDetails3 = new orderDetail(3, milk, 1);
            try
            {
                do
                {
                    Console.WriteLine("请输入功能选择：1.添加订单2.删除订单3.编辑订单 4.查询订单 0.退出");
                    menuKey = Console.ReadLine();
                    switch (menuKey)
                    {
                        case "1":
                            Console.WriteLine("请输入订单编号");
                            uint id = uint.Parse(Console.ReadLine());
                            Console.WriteLine("请输入客户ID");
                            int cilentId = int.Parse(Console.ReadLine());
                            if (cilentId > cilentList.Count)
                                throw new MyException("cilent does no exsit");
                            orderManage.addOrder(id, cilentList[cilentId]);
                            break;
                        case "2":
                            Console.WriteLine("请输入删除的订单编号");
                            uint id2 = uint.Parse(Console.ReadLine());
                            orderManage.deleteOrder(id2);
                            break;
                        case "3":
                            //orderManage.editOrder();
                            break;
                        case "4":
                            //orderManage.searchOrder();
                            break;
                        default: break;
                    }
                } while (menuKey != "0");
            }
            catch(MyException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
    class MyException : ApplicationException
    {
        //public MyException(){}
        public MyException(string message) : base(message) { }

        public override string Message
        {
            get
            {
                return base.Message;
            }
        }
    }


}
