using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
   public class Product
    {
        //public Product(int productId, string name, double price, DateTime dateProd, string description, int quantity, List<Provider> providers)
        //{
        //    ProductId = productId;
        //    Name = name;
        //    Price = price;
        //    DateProd = dateProd;
        //    Description = description;
        //    Quantity = quantity;
        //    Providers = providers;
        //}

        public int ProductId { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public DateTime DateProd { get; set; }

        public string  Description { get; set; }

        public int Quantity { get; set; }

        public List<Provider> Providers { get; set; }

        public override string ToString()
        {
            return "name : " + Name + " description : " + Description + " Quantity : " + Quantity;
        }

    }
}
