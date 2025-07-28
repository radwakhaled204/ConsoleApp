using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Xml.Linq;
using System.Linq;
namespace ConsoleApp
{
class Program
    {
        static void Main(string[] args)
        {


            int[] array = new[] { 2, 9, 5, 0, 3, 7, 1, 4, 8, 5};
            Console.WriteLine("original array" );
            foreach (var i in array)
            {
                Console.WriteLine($"{i}");  
            }

            var linqData = from arr in array where arr > 4 select arr;

            Console.WriteLine("linqData array");
            foreach (var c in linqData)
            {
                Console.WriteLine($"{c}");
            }

            //int[,] a = { { 1, 2 }, { 3, 4 } };
            //Console.WriteLine(a.Length);

            //int[,] c = new int[2, 3]
            //{
            //    { 1,2,3} , {2,8,9}
            //};
            //for (int row = 0; row < c.GetLength(0); row++) 
            //{
            //    for (int col = 0; col < c.GetLength(1); col++) 
            //    {
            //        Console.Write(c[row, col] + "\t"); 
            //    }
            //    Console.WriteLine(); 
            //}

            //int[] responses = { 1, 2, 5, 4, 3, 5, 2, 1, 3, 3, 1, 4, 3, 3, 3, 2, 3, 3, 2, 14 };
            // var frequency = new int[6];
            //foreach(var answer in responses)
            //{
            //    try
            //    {
            //        ++frequency[responses[answer]];
            //    }
            //    catch (IndexOutOfRangeException ex)
            //    { 
            //        Console.WriteLine(ex.Message);
            //        Console.WriteLine($"responses[{answer}] = {responses[answer]}\n");

            //    }

            //}

            //Console.WriteLine($"{"Rating"}{"Frequency",10}");
            //for (var rating = 1; rating < frequency.Length; ++rating)
            //{
            //    Console.WriteLine($"{rating,6}{frequency[rating],10}");
            //}




            //int[] r = new int[10];
            //int[] c = { 1, 8, 6, 5, 7, 2, 8, 7, 3, 4, };

            //int total = 0;
            //for (int i = 0; i < c.Length; i++)
            //{
            //    total += c[i];
            //}
            //Console.WriteLine($"{total}");

            //foreach (int num in c)
            //{
            //    total += num;
            //}
            //Console.WriteLine($"{total}");

            //Array.Resize(ref r , 12);
            //Console.WriteLine($"{r.Length}");
            //int sum = c[5] + c[1];
            //Console.WriteLine($"{sum}");
            //Calculation calc = new Calculation();
            //Console.WriteLine("Enter The Number");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{calc.Factorial(num1)}");


            //Random randomNumbers = new Random();
            //for (int i = 0; i < 7; i++)
            //{
            //    int value = randomNumbers.Next(1, 7);
            //    Console.WriteLine(value);
            //}



            //decimal principal = 1000;
            //double rate = 0.05;
            //Console.WriteLine("Year Amount on deposit");
            //for ( int year = 1; year <= 10; ++year)
            //{
            //    decimal amount = principal * ((decimal)Math.Pow(1.0 + rate, year));
            //    Console.WriteLine($"{year,4} {amount,20:C}");
            //}
            //int counter = 1;
            //do
            //{
            //    Console.WriteLine($"{counter}");
            //    ++counter;

            //}while (counter <=10);


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


