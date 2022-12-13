using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class Program
    {
        static void main(string[]args)
        {
            int num1, num2, sum;
            Console.WriteLine("calculating the sum of the numbers:");
            Console.WriteLine("enter the num1 value:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the num2 value:");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;
            Console.WriteLine("sum of the two numbers is:" + sum);
            Console.ReadKey();
        }
    }
}
