using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_2
{
    class Program
    { 

        static void Main(string[] args)
        {
            int[] randArray = new int[10];
            int sum = 0;
            float avg;
            int max=0, min=99;
            Random rnd = new Random();
            Console.Write("随机数组为： ");
            for(int i=0;i<randArray.Length;i++)     //生成随机数组,并计算
            {
                randArray[i] = rnd.Next(20);
                Console.Write(" " + randArray[i]);
                sum = sum + randArray[i];
                max = randArray[i] > max ? randArray[i] : max;
                min = randArray[i] < min ? randArray[i] : min;
            }
            avg = sum / randArray.Length;
            Console.WriteLine("\n平均值：" + avg + ",总和：" + sum + "，最大值：" + max + "，最小值：" + min);
            Console.ReadLine();
        }
    }
}
