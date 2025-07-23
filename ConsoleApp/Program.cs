using System;

namespace ConsoleApp
{
class Program
    {
        //static void Main(string[] args)
        //{
        //    string name = "Radwa";
        //    Console.WriteLine($"Hello {name}");
        //}
        static void Main()
        {
            int num1 , num2 , sum;
            
            Console.WriteLine("Enter The First Number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Secound Number");
            num2 = int.Parse(Console.ReadLine());
            sum = num1 + num2;
            Console.WriteLine($"Result={sum}");

        }
    }

}


