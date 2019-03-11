using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            string s;
            Console.Write("输入一个自然数：");
            s = Console.ReadLine();
            num = int.Parse(s);         //获取输入
            for(int i=2;i<=num;)
            {
                if (num % i == 0)
                {
                    Console.Write(" "+i);       //输出因子
                    num = num / i;
                }
                else i++;
            }
            Console.ReadLine();
        }
    }
}
