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
                ConfirmPassword = "1234569"
            };

            Console.WriteLine("provider.isApproved = "+ provider.IsApproved);
            Provider.SetIsApproved(provider);
            Console.WriteLine("provider.isApproved = " + provider.IsApproved);

            /*
            int i = 3;
            int j = 2;
            int k = 69;
            p2.Calculer(i, j,ref k);
            Console.WriteLine(k); // it will show 69 no matter what happens in "Calculer" . 
            */
        }
    }
}
