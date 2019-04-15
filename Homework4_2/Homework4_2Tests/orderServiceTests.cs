using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework4_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_2.Tests
{
    [TestClass()]
    public class orderServiceTests
    {
        orderService test = new orderService();
        cilent testCustomer = new cilent(1, "Customer1");
        [TestMethod()]
        public void addOrderTest()
        {
            order real=test.addOrder(10, testCustomer);
            order expect = new order(10, testCustomer);
            Assert.AreEqual(real, expect);
           // Assert.Fail();
        }
        [TestMethod()]
        public void deleteOrderTest()
        {
            order order1= new order(10, testCustomer);
            test.orderList.Add(order1);
            test.deleteOrder(10);
            Assert.AreEqual(test.orderList.Contains(order1), false);
        }

        [TestMethod()]
        public void searchOrderTest()
        {
            order order1 = new order(10, testCustomer);
            test.orderList.Add(order1);
            List<order> res =test.searchOrder("10");
            Assert.AreEqual(res.Contains(order1),true);
        }
    }
}