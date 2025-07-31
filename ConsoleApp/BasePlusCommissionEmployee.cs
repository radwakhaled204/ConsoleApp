using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class BasePlusCommissionEmployee : CommissionEmployee
    {
        //public string FirstName { get; }
        //public string LastName { get; }
        //public string SocialSecurityNumber { get; }
        //private decimal grossSales;
        //private decimal commissionRate;
        private decimal baseSalary;
        public BasePlusCommissionEmployee(string firstName, string lastName, string socialSecuirtyNumber,
            decimal grossSales, decimal commissionRate , decimal baseSalary) :base ( firstName,  lastName,  socialSecuirtyNumber,
             grossSales,  commissionRate)
        {
                    
            //FirstName = firstName;
            //LastName = lastName;
            //SocialSecurityNumber = socialSecuirtyNumber;
            //GrossSales = grossSales;
            //CommissionRate = commissionRate;
            BaseSalary = baseSalary;

        }

        //public decimal GrossSales { get; set; }
        //public decimal CommissionRate { get; set; }
        public decimal BaseSalary
        {
            get { return baseSalary; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(BaseSalary)} must be >= 0");
                baseSalary = value;
            }
        }

        public override decimal Earnings() => BaseSalary + base.Earnings();

        public override string ToString() =>
                $"base-salaried {base.ToString()}\nbase salary: {BaseSalary:C}";
    }
}
