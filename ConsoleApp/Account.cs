using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp
{
     class Account
     {
        public string name;
        private decimal balance;
        public Account(string accName , decimal accBalance) 
        {
            name = accName;
            balance = accBalance;
        }    
        


        //Auto-Implement
        //public string Name { get; set; }

        //public string Name
        //{
        //   get { return name; }
        //   set
        //   { 
        //       if (!string.IsNullOrEmpty(name))
        //       {
        //           name = value;
        //       }
        //   }
        //}
        //public void SetName(string accountName)
        //{
        //    name = accountName;
        //}
        //public string GetName()
        //{
        //    return name;

        //}

    }
}
