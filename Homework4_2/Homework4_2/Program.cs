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
            do
            {
                Console.WriteLine("请输入功能选择：1.添加订单2.删除订单3.编辑订单 4.查询订单 0.退出");
                menuKey = Console.ReadLine();
                switch (menuKey)
                {
                    case "1":
                        orderManage.addOrder();
                        break;
                    case "2":
                        orderManage.deleteOrder();
                        break;
                    case "3":
                        orderManage.editOrder();
                        break;
                    case "4":
                        orderManage.searchOrder();
                        break;
                    default: break;
                }
            } while (menuKey != "0");
        }
    }

    class order
    {
        public int id;
        public string client;
        public List<orderDetail> productList = new List<orderDetail>();
        public order() { }
        public order(int order_no) { this.id = order_no; }
        public order(int order_no,string client_name) { this.id = order_no;this.client = client_name; }

        public void addDetail()
        {
            try
            {
                string product_name;
                int product_num;
                Console.WriteLine("请输入商品名称 ");
                product_name = Console.ReadLine();
                Console.WriteLine("请输入商品数量:");
                product_num =Int32.Parse(Console.ReadLine());
                orderDetail newDetail = new orderDetail(product_name, product_num);
                productList.Add(newDetail);
                Console.WriteLine("修改成功！ ");
            }
            catch
            {
                Console.WriteLine("请输入正确的信息！");
                addDetail();
            }
        }
        public void deleteDetail()
        {
            try
            {
                Console.WriteLine(" 请输入要删除的商品编号： ");
                int i = Int32.Parse(Console.ReadLine());
                productList.RemoveAt(i-1);
            }
            catch
            {
                Console.WriteLine("请输入正确的编号！");
               deleteDetail();
            }
        }
    }

    class orderDetail
    {
        public string product_name;
        public int product_num;
        public orderDetail() { }
        public orderDetail(string name,int num){ this.product_name = name;this.product_num = num; }
    }

    class orderService
    {
        List<order> orderList = new List<order>();
        public orderService() { }
       public  void addOrder()
        {
            try
            {
                order newOrder;
                int no = orderList.Count+1;
                Console.WriteLine("输入客户名：");
                string client_name = Console.ReadLine();

                if (client_name == "") throw new Exception("空输入");
                newOrder = new order(no, client_name);
                orderList.Add(newOrder);
                Console.WriteLine("新增订单成功，编号为" + no);
            }
            catch
            {
                Console.WriteLine("请输入正确的客户名！ ");
                addOrder();
            }
        }

        public void deleteOrder()
        {
            try
            {
                Console.WriteLine("输入订单号：");
                int order_no = Int32.Parse(Console.ReadLine());
          
                foreach(order orderI in orderList)
                    if (orderI.id == order_no)
                    {
                        orderList.Remove(orderI);
                        Console.WriteLine("删除成功");
                        break;
                    }
            }
            catch
            {
                Console.WriteLine("请输入正确的订单号！ ");
                deleteOrder();
            }
        }
        public void editOrder()
        {
            try
            {
                Console.WriteLine("输入订单号：");
                int order_no = Int32.Parse(Console.ReadLine());

                foreach (order orderI in orderList)
                {
                    if (orderI.id == order_no)
                    {
                        Console.WriteLine("" + "商品编号\t商品名称\t商品数量");
                        if (orderI.productList.Count == 0)
                            Console.WriteLine("空");
                        else
                        {
                            foreach (orderDetail productI in orderI.productList)
                            {
                                Console.WriteLine("" + (orderI.productList.IndexOf(productI) + 1) + "\t\t" + productI.product_name + "\t\t" + productI.product_num);
                            }
                        }
                        Console.WriteLine("请选择商品编辑功能：1.添加商品条目2.删除商品条目");
                        string menuKey = Console.ReadLine();
                        switch (menuKey)
                        {
                            case "1":
                                orderI.addDetail();
                                break;
                            case "2":
                                orderI.deleteDetail();
                                break;
                            default: break;
                        }
                        break;

                    }
                    Console.WriteLine("不存在相关订单信息！ ");
                }


            }
            catch
            {
                Console.WriteLine("请输入正确的订单号！ ");
                editOrder();
            }
        }

        public void searchOrder()
        {
            string menuKey;
            do
            {
                Console.WriteLine("请输入查询方式：1.按订单编号查询 2.按客户名查询 3.按商品名称查询 其他.退出");
                menuKey = Console.ReadLine();
                switch (menuKey)
                {
                    case "1":
                        Console.WriteLine("请输入订单号：");
                        int orderId =Int32.Parse(Console.ReadLine());
                        foreach (order orderI in orderList)
                        {
                            if (orderI.id == orderId)
                            {
                                foreach (orderDetail productI in orderI.productList)
                                {
                                    Console.WriteLine("" + (orderI.productList.IndexOf(productI) + 1) + "\t\t" + productI.product_name + "\t\t" + productI.product_num);
                                }
                                break;
                            }                          
                        }
                        Console.WriteLine("查询完毕");
                        break;
                    case "2":
                        Console.WriteLine("请输入客户名：");
                        string clientName=Console.ReadLine();
                        foreach (order orderI in orderList)
                        { 
                            if (orderI.client == clientName)
                                foreach (orderDetail productI in orderI.productList)
                                {
                                    Console.WriteLine("" + (orderI.productList.IndexOf(productI) + 1) + "\t\t" + productI.product_name + "\t\t" + productI.product_num);
                                }
                            break;
                        }
                        Console.WriteLine("查询完毕");
                        break;
                    case "3":
                        Console.WriteLine("请输入商品名：");
                        string productName = Console.ReadLine();
                        foreach (order orderI in orderList)
                            foreach (orderDetail productK in orderI.productList)
                                if (productK.product_name == productName)
                                {
                                    Console.WriteLine("查询到匹配订单！");
                                    foreach (orderDetail productI in orderI.productList)
                                    {
                                        Console.WriteLine("" + (orderI.productList.IndexOf(productI) + 1) + "\t\t" + productI.product_name + "\t\t" + productI.product_num);
                                    }
                                }
                        break;
                    default: break;
                }
            } while (menuKey != "0");
        }

    }
}
