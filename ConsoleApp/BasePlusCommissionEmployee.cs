using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class BasePlusCommissionEmployee
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string SocialSecurityNumber { get; }
        private decimal grossSales;
        private decimal commissionRate;
        private decimal baseSalary;
        public BasePlusCommissionEmployee(string firstName, string lastName, string socialSecuirtyNumber,
            decimal grossSales, decimal commissionRate , decimal baseSalary)
        {
                    
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecuirtyNumber;
            GrossSales = grossSales;
            CommissionRate = commissionRate;
            BaseSalary = baseSalary;

        }

        public decimal GrossSales { get; set; }
        public decimal CommissionRate { get; set; }
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

        public decimal Earnings() => baseSalary + (commissionRate * grossSales);

        public override string ToString() =>
            $"base-salaried commission employee: {FirstName} {LastName}\n" +
            $"social security number: {SocialSecurityNumber}\n" +
            $"gross sales: {grossSales:C}\n" +
            $"commission rate: {commissionRate:F2}\n" +
            $"base salary: {baseSalary:C}";
    }
}
