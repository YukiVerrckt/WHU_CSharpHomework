using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    public class orderService
    {
       public  List<order> orderList = new List<order>();
        public orderService() { }
     
        public order addOrder(int id,cilent customer )
        {
           foreach(order orderI in orderList)
            {

                if (orderI.Id == id)
                    throw new Exception("order has exsited");
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
                throw new Exception("order does not exsit");
            
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

        public List<order> searchOrder(string keyword)
        {
            List<order> output=new List<order>();
            var result = from n in orderList
                         where (n.Id.ToString() == keyword || n.Client.cilentId.ToString() == keyword || n.Client.cilentName == keyword||n.include(keyword))
                         select n;
            output=result.ToList();
            foreach(order I in result)
            {
                Console.WriteLine(I.ToString());
            }
            /* foreach (order orderI in orderList)
             {
                 if(orderI.Id.ToString()==keyword||orderI.Client.cilentId.ToString()== keyword || orderI.Client.cilentName == keyword)
                     Console.WriteLine(orderI.ToString());
                 foreach (var detailI in orderI.detailList)
                 {
                     if (detailI.productKind.productName == keyword)
                         Console.WriteLine(orderI.ToString());
                 }
             }*/
            return output;

        }
        public void priceSort()
        {
            orderList.Sort((a, b) =>(int)(a.calculate() - b.calculate()));
            foreach (var f in orderList)
            {
                Console.WriteLine(f.ToString()+"总价"+f.calculate().ToString());
            }
        }

        public void CreateXmlFile()
        {

            XmlDocument xmlDoc = new XmlDocument();
            XmlDeclaration xmldecl = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null);
            XmlElement root = xmlDoc.DocumentElement;
            xmlDoc.InsertBefore(xmldecl, root);

            XmlElement ele = xmlDoc.CreateElement("Table");
            xmlDoc.AppendChild(ele);

 
            foreach(order I in orderList)
            {
                XmlElement row = xmlDoc.CreateElement("row");

                row.SetAttribute("Version", "2.0");
                row.SetAttribute("AppId", "111");


                XmlElement orderID = xmlDoc.CreateElement("ID");
                orderID.InnerText = I.Id.ToString();
                row.AppendChild(orderID);

                XmlElement cilentID = xmlDoc.CreateElement("客户ID");
                cilentID.InnerText = I.Client.cilentId.ToString();
                row.AppendChild(cilentID);

                XmlElement cilentName = xmlDoc.CreateElement("客户Name");
                cilentName.InnerText = I.Client.cilentName.ToString();
                row.AppendChild(cilentName);

                XmlElement detailID = xmlDoc.CreateElement("DetailID");
                detailID.InnerText = I.detailList[0].orderDetailId.ToString();
                row.AppendChild(detailID);

                ele.AppendChild(row);
            }
                    xmlDoc.Save("d://data.xml");         
        }


      /*  public void ReadXml(List<order> orderlist)
        {
            //将XML文件加载进来
            XmlDocument document=new XmlDocument();
            document.Load("d://data.xml");
            //获取到XML的根元素进行操作
            XmlNodeList list = document.SelectNodes("/Table/row");
            
            cilent NewCilent=new cilent();
            foreach (XmlNode item in list)
            {
                NewCilent = new cilent(uint.Parse(item["客户ID"].InnerText), item["客户Name"].InnerText);
                order tmp = new order();
                tmp =this.addOrder(uint.Parse(item["ID"].InnerText), NewCilent);
                tmp.addDetail(Program.detailList[int.Parse(item["DetailID"].InnerText)-1]);
                
            }
            
        }
        */
    }
}
