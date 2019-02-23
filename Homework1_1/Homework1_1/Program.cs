using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0,b=0,product=0;
            string s = "";
            Console.WriteLine("请输入两个整数：");
            Console.Write("a=");
            s = Console.ReadLine();
            a = Int32.Parse(s);
            Console.Write("b=");
            s = Console.ReadLine();
            b = Int32.Parse(s);
            product = a * b;
            Console.WriteLine("a*b=" + product);
        }
    }
}
