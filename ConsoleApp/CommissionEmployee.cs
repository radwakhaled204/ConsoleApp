using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class CommissionEmployee
    {
        public string FirstName { get; }
        public string LastName { get; } 
        public string SocialSecurityNumber {  get; }
        protected decimal grossSales;
        protected decimal commissionRate;
        public CommissionEmployee(string firstName , string lastName , string socialSecuirtyNumber ,
            decimal grossSales, decimal commissionRate)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecuirtyNumber;
            GrossSales = grossSales;
            CommissionRate = commissionRate;

        }
        public decimal GrossSales
        {
            get { return grossSales; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value) , 
                        value, $"{nameof(GrossSales)} must be > 0 " );
                }
                grossSales = value;
            }
        }
        public decimal CommissionRate
        {
            get { return commissionRate; }
            set
            {
                if (value <= 0 || value >= 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(CommissionRate)} must be > 0 and < 1");
                }
                commissionRate = value;

            }
        }
        //make Earnings function virtual
        public virtual decimal Earnings() => grossSales * commissionRate;
        public override string ToString() => 
            $"commission employee: {FirstName} {LastName}\n" 
            + $"social security number: {SocialSecurityNumber}\n" 
            + $"gross sales: {grossSales:C}\n" 
            +$"commission rate: {commissionRate:F2}";
    }
}
