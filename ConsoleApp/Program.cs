using System;
using System.Xml.Linq;

namespace ConsoleApp
{
class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("",0);
            student.Name = Console.ReadLine();
            Console.WriteLine($"Hello {student.Name}");
            Console.WriteLine("Enter The Avarage");
            student.Avarage = int.Parse(Console.ReadLine());
            Console.WriteLine("your Grade is Avarage");


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


