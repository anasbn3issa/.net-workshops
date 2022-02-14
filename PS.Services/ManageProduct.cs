using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PS.Services
{
    public class ManageProduct
    {
        public List<Product> lsProduct { get; set; }
        public Func<char,List<Product>> FindProduct;
        public Action<Category> ScanProduct;

        public List<Product> Methode1(char c)
        {
            var req = from p in lsProduct
                      where p.Name.StartsWith(c)
                      select p;
            return req.ToList();
        }
        public ManageProduct()
        {
            //we can affect a method to FindProduct like this : 
            FindProduct = Methode1;
            // AND LIKE THIS :
            FindProduct = c =>
            {
                var req = from p in lsProduct
                          where p.Name.StartsWith(c)
                          select p;
                return req.ToList();
            };

            ScanProduct = car =>
            {
                var req = from p in lsProduct
                          where p.Category.CategoryId == car.CategoryId
                          select p;
                foreach (Product p in req)
                {
                    Console.WriteLine(p);
                }
            };
        }
    }
}
