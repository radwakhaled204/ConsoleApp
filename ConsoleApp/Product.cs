using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Product
    {

        public int product;
        public int num { get; set; }

        public bool IsPositive => num > 0;
        public int Square(int x) => num * num;
        public int CalProduct()
        {
            while(product <= 100 )
            {
                product = 3 * product;
            }
            return product;
        }

    }
}
