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
            string menuKey;                       //功能选择
            List<cilent> cilentList = new List<cilent>();
            cilent customer1 = new cilent(1, "Customer1");
            cilent customer2 = new cilent(2, "Customer2");
            cilentList.Add(customer1); cilentList.Add(customer2);  //客户列表

            product milk = new product(69.9, 1, "Milk");
            product eggs = new product(4.99, 2, "eggs");
            product apple = new product(5.99, 3, "apple");
   

            orderDetail orderDetails1 = new orderDetail(1, apple, 8);
            orderDetail orderDetails2 = new orderDetail(2, eggs, 2);
            orderDetail orderDetails3 = new orderDetail(3, milk, 1);
            List<orderDetail> detailList = new List<orderDetail>();
            detailList.Add(orderDetails1);detailList.Add(orderDetails2);detailList.Add(orderDetails3);      //订单详细列表（简化输入）

            try
            {
                do
                {
                    Console.WriteLine("请输入功能选择：1.添加订单2.删除订单3.排列订单 4.查询订单 5.价格排序订单 0.退出");//功能选择
                    menuKey = Console.ReadLine();
                    switch (menuKey)
                    {
                        case "1":       
                            Console.WriteLine("请输入订单编号");                               //新建订单
                            uint id = uint.Parse(Console.ReadLine());
                            Console.WriteLine("请输入客户ID(1 or 2)");
                            int cilentId = int.Parse(Console.ReadLine());
                            if (cilentId > cilentList.Count)
                                throw new MyException("cilent does no exsit");
                            order editNow = new order();
                            editNow = orderManage.addOrder(id, cilentList[cilentId - 1]);       
                            Console.WriteLine("请输入订单详细ID(1 or 2 or 3)");                //添加订单详细内容
                            int detailId = int.Parse(Console.ReadLine());
                            if (detailId > detailList.Count)
                                throw new MyException("detail does no exsit");
                            editNow.addDetail(detailList[detailId-1]);
                            break;
                        case "2":
                            Console.WriteLine("请输入删除的订单编号");                        //删除订单
                            uint id2 = uint.Parse(Console.ReadLine());
                            orderManage.deleteOrder(id2);
                            break;
                        case "3":                                                           //输出显示订单
                            orderManage.printOrder();
                            break;
                        case "4":                                                           //查询订单
                            Console.WriteLine("请输入查询关键字");
                            orderManage.searchOrder(Console.ReadLine());
                            break;
                        case "5":                                                           //Lambda价格排序
                            orderManage.priceSort();
                            break;
                        default: break;
                    }
                } while (menuKey != "0");
            }
            catch(MyException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(System.FormatException)
            {
                Console.WriteLine("格式错误");
            }
            catch (System.IO.IOException)
            {
                Console.WriteLine("输入错误");
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
