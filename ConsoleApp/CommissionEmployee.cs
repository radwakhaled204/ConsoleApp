using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class CommissionEmployee: Employee
    {
        private decimal grossSales;     // gross weekly sales
        private decimal commissionRate; // commission percentage

        // five-parameter constructor
        public CommissionEmployee(string firstName, string lastName,
            string socialSecurityNumber, decimal grossSales, decimal commissionRate)
            : base(firstName, lastName, socialSecurityNumber)
        {
            GrossSales = grossSales;
            CommissionRate = commissionRate;
        }

        public decimal GrossSales
        {
            get => grossSales;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(GrossSales)} must be >= 0");
                grossSales = value;
            }
        }

        public decimal CommissionRate
        {
            get => commissionRate;
            set
            {
                if (value <= 0 || value >= 1)
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(CommissionRate)} must be > 0 and < 1");
                commissionRate = value;
            }
        }

        public override decimal Earnings() => CommissionRate * GrossSales;

        public override string ToString() =>
            $"commission employee: {base.ToString()}\n" +
            $"gross sales: {GrossSales:C}; commission rate: {CommissionRate:F2}";
        //public string FirstName { get; }
        //public string LastName { get; } 
        //public string SocialSecurityNumber {  get; }
        //protected decimal grossSales;
        //protected decimal commissionRate;
        //public CommissionEmployee(string firstName , string lastName , string socialSecuirtyNumber ,
        //    decimal grossSales, decimal commissionRate)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //    SocialSecurityNumber = socialSecuirtyNumber;
        //    GrossSales = grossSales;
        //    CommissionRate = commissionRate;

        //}
        //public decimal GrossSales
        //{
        //    get { return grossSales; }
        //    set
        //    {
        //        if (value < 0)
        //        {
        //            throw new ArgumentOutOfRangeException(nameof(value) , 
        //                value, $"{nameof(GrossSales)} must be > 0 " );
        //        }
        //        grossSales = value;
        //    }
        //}
        //public decimal CommissionRate
        //{
        //    get { return commissionRate; }
        //    set
        //    {
        //        if (value <= 0 || value >= 1)
        //        {
        //            throw new ArgumentOutOfRangeException(nameof(value),
        //                value, $"{nameof(CommissionRate)} must be > 0 and < 1");
        //        }
        //        commissionRate = value;

        //    }
        //}
        ////make Earnings function virtual
        //public virtual decimal Earnings() => grossSales * commissionRate;
        //public override string ToString() => 
        //    $"commission employee: {FirstName} {LastName}\n" 
        //    + $"social security number: {SocialSecurityNumber}\n" 
        //    + $"gross sales: {grossSales:C}\n" 
        //    +$"commission rate: {commissionRate:F2}";
    }
}
