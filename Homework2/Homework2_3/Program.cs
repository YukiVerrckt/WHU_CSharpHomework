using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("素数：" + 2);
            for(int i=2;i<=100;i++)
                for (int j = 2; j < i;j++)
                {
                    if (i % j == 0 && i != j)
                        break;
                    else if (j == i - 1)
                        Console.Write(" " + i);
                }
            Console.ReadLine();
        }
    }
}
