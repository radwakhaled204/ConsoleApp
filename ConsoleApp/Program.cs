using System;

namespace ConsoleApp
{
class Program
    {
        static void Main(string[] args)
        {
            //string name = "Radwa";
            //Console.WriteLine($"Hello {name}");

           // Calculation calc = new Calculation();
           // Console.WriteLine("Enter The First Number");
           // int num1 = int.Parse(Console.ReadLine());
           // Console.WriteLine("Enter The Secound Number");
           // int num2 = int.Parse(Console.ReadLine());
           // calc.Addition(num1, num2);
           // calc.Comparisons(num1, num2);

            Account account = new Account();
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            account.SetName(name);           
            Console.WriteLine($"Hello {account.GetName()}");
            

        }

    }

}


