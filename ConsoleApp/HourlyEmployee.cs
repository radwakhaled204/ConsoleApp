﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class HourlyEmployee: Employee
    {

        private decimal wage;  
        private decimal hours; 

        
        public HourlyEmployee(string firstName, string lastName,
            string socialSecurityNumber, decimal hourlyWage, decimal hoursWorked)
            : base(firstName, lastName, socialSecurityNumber)
        {
            Wage = hourlyWage;   
            Hours = hoursWorked; 
        }

        public decimal Wage
        {
            get => wage;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Wage)} must be >= 0");
                wage = value;
            }
        }

        public decimal Hours
        {
            get => hours;
            set
            {
                if (value < 0 || value > 168) 
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Hours)} must be >= 0 and <= 168");
                hours = value;
            }
        }

        public override decimal Earnings()
        {
            if (Hours <= 40)
                return Wage * Hours;
            else
                return (40 * Wage) + ((Hours - 40) * Wage * 1.5M);
        }

        public override string ToString() =>
            $"hourly employee: {base.ToString()}\n" +
            $"hourly wage: {Wage:C}; hours worked: {Hours:F2}";
    }
}
