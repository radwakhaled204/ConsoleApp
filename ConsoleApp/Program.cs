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
            var items = new List<string>();
            Console.WriteLine("Before adding to items: " +
                $"Count = {items.Count}; Capacity= {items.Capacity}");
            items.Add("red");
            items.Add("blue");
            items.Insert(0, "yellow");
            items.Add("green");
            items.Insert(2, "browen");

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Before adding to items: " +
                $"Count = {items.Count}; Capacity= {items.Capacity}");

            items.Remove("browen");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Before adding to items: " +
    $"Count = {items.Count}; Capacity= {items.Capacity}");
            items.RemoveAt(0);
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
                        Console.WriteLine("Before adding to items: " +
                $"Count = {items.Count}; Capacity= {items.Capacity}");
            // var employees = new[] {
            // new Employee("Jason", "Red", 5000M), 
            // new Employee("Ashley", "Green", 7600M), 
            // new Employee("Matthew", "Indigo", 3587.5M),
            // new Employee("James", "Indigo", 4700.77M),
            // new Employee("Luke", "Indigo", 6200M), 
            // new Employee("Jason", "Blue", 3200M), 
            // new Employee("Wendy", "Brown", 4236.4M)};

            // Console.WriteLine("Original array:"); 
            // foreach (var element in employees)
            // {
            //     Console.WriteLine(element);
            // }
            // var range = from e in employees where (e.MonthlySalary >= 4000M)&&(e.MonthlySalary <= 6000M) select e;
            // Console.WriteLine("\nEmployees earning in the range" + $"{4000:C}-{6000:C} per month:"); 
            // foreach (var element in range)
            // {
            //     Console.WriteLine(element);
            // }
            // var nameSorted =
            //         from e in employees orderby e.LastName, e.FirstName select e;
            // if (nameSorted.Any())
            //      { Console.WriteLine(nameSorted.First()); }
            //else
            // {
            //     Console.WriteLine("not found");
            // }
            //var lastname=
            // from e in employees select e.LastName;
            // foreach (var element in lastname.Distinct())
            // {
            //     Console.WriteLine(element);
            // }
            // var names =
            // from e in employees select new { e.FirstName, e.LastName };

            // Console.WriteLine("\nNames only:"); 
            // foreach (var element in names)
            // {
            //     Console.WriteLine(element);
            // }
            // Console.WriteLine();





            //int[] array = new[] { 2, 9, 5, 0, 3, 7, 1, 4, 8, 5};
            //Console.WriteLine("original array" );
            //foreach (var c in array)
            //{
            //    Console.WriteLine($"{c}");  
            //}

            //var filteredData = from arr in array where arr > 4 select arr;

            //Console.WriteLine("linqData array > 4");
            //foreach (var c in filteredData)
            //{
            //    Console.WriteLine($"{c}");
            //}
            //var sortedData = from arr in array orderby arr descending select arr;
            //Console.WriteLine("sortedData array");
            //foreach (var c in sortedData)
            //{
            //    Console.WriteLine($"{c}");
            //}
            //var sortedFilteredData = from arr in filteredData where arr > 4 orderby arr descending select arr;
            //Console.WriteLine("sortedFilteredData array > 4");
            //foreach (var c in sortedFilteredData.Distinct())
            //{
            //    Console.WriteLine($"{c}");
            //}
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


