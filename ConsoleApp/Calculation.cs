using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
     class Calculation
     {
        public void Addition(int num1 , int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine("Result = " + sum);
        }
        public void Comparisons(int x, int y) 
        {
            if (x > y)
            {
                Console.WriteLine($"{x} is greater than {y}");
            }
            if (x < y)
            {
                Console.WriteLine($"{x} is less than {y}");
            }
            if (x >= y)
            {
                Console.WriteLine($"{x} is greater than or equal to {y}");
            }
            if (x <= y)
            {
                Console.WriteLine($"{x} is less than or equal to {y}");
            }
            if (x == y)
            {
                Console.WriteLine($"{x} is equal to {y}");
            }
            if (x != y)
            {
                Console.WriteLine($"{x} is not equal to {y}");
            }
        }

     }
}
