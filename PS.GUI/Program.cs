using System;
using PS.Domain;
namespace PS.GUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.Name = "Pomme de terre";
            Console.WriteLine(p.Name.ToString());

            // initialiseur d'objet : 
            Product p2 = new Product
            {
                Name = "fraise",
                Price = 1.5,
                Description = " mal à l'aise",
            };
            Console.WriteLine(p2.ToString());

            Provider provider = new Provider
            {
                //invalid password will be given  (Length not between 5 and 20 )
                //Password = "abd",
                //and now the valid password 
                Password = "1234569",
            };
        }
    }
}
