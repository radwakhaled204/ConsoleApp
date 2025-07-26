using System;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace ConsoleApp
{
class Program
    {
        static void Main(string[] args)
        {

            //decimal principal = 1000;
            //double rate = 0.05;
            //Console.WriteLine("Year Amount on deposit");
            //for ( int year = 1; year <= 10; ++year)
            //{
            //    decimal amount = principal * ((decimal)Math.Pow(1.0 + rate, year));
            //    Console.WriteLine($"{year,4} {amount,20:C}");
            //}
            int counter = 1;
            do
            {
                Console.WriteLine($"{counter}");
                ++counter;
                
            }while (counter <=10);


            //Product userProduct = new Product();
            //Console.WriteLine("Enter number");
            //userProduct.product = int.Parse(Console.ReadLine());
            //Console.WriteLine($"your product is {userProduct.CalProduct}");


            //Student student = new Student("",0);
            //Console.WriteLine("Enter Your Name");
            //student.Name = Console.ReadLine();
            //Console.WriteLine($"Hello {student.Name}");
            //Console.WriteLine("Enter The Avarage");
            //student.Avarage = int.Parse(Console.ReadLine());
            //Console.WriteLine($"your Grade is {student.LetterGrade}");
            

            //string name = "Radwa";
            //Console.WriteLine($"Hello {name}");

            // Calculation calc = new Calculation();
            // Console.WriteLine("Enter The First Number");
            // int num1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Enter The Secound Number");
            // int num2 = int.Parse(Console.ReadLine());
            // calc.Addition(num1, num2);
            // calc.Comparisons(num1, num2);

            //Account account = new Account("radwa" , 5);

            //Console.WriteLine("Enter Your Name");
            //string userName = Console.ReadLine();
            //account.name = userName;
            //Console.WriteLine($"Hello {account.name}");
            //Console.WriteLine("Enter Your Deposite");
            //decimal userDeposite = decimal.Parse( Console.ReadLine() );
            //account.Deposite(userDeposite);
            //Console.WriteLine($"Your Deposite is {account.Balance}");




        }

    }

}


