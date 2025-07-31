using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public abstract class Employee
    {
            public string FirstName { get; }
            public string LastName { get; }
            public string SocialSecurityNumber { get; }


            public Employee(string firstName, string lastName,
                string socialSecurityNumber)
            {
                FirstName = firstName;
                LastName = lastName;
                SocialSecurityNumber = socialSecurityNumber;
            }

           
            public override string ToString() => $"{FirstName} {LastName}\n" +
                $"social security number: {SocialSecurityNumber}";

          
            public abstract decimal Earnings(); 
        }

        //        public string FirstName {  get;}
        //        public string LastName { get;}
        //        private decimal monthlySalary;

        //        public Employee(string firstName , string lastName , decimal monthlySalary)
        //        {
        //            FirstName = firstName;
        //            LastName = lastName;
        //            MonthlySalary = monthlySalary;
        //        }

        //        public decimal MonthlySalary
        //        {
        //            get
        //            {
        //                return monthlySalary;
        //            }
        //            set
        //            {
        //                if (value >= 0M)
        //                {
        //                    monthlySalary = value;
        //                }
        //            }
        //        }
        //        public override string ToString() =>
        //$"{FirstName,-10} {LastName,-10} {MonthlySalary,10:C}";
    
}
