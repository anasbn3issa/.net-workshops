using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
   public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public DateTime DateProd { get; set; }

        public string  Description { get; set; }

        public int Quantity { get; set; }


    }
}
