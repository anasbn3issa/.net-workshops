using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
  public  class Provider
    {
        public String Email { get; set; }

        public int ProviderId { get; set; }

        public Boolean IsApproved { get; set; }

        /**
         * password.Length has to be between 5 and 20 , therefore 
         * we will work with the following syntax for the 
         * attribute // setters // getters
         */
        private String password;
        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length < 20 && value.Length > 5)
                    password = value;
                else
                    Console.WriteLine("invalid password !");
            }
        }


        private String confirmPassword;
        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set
            {
                if (value== password)
                    confirmPassword = value;
                else
                    Console.WriteLine("password and confirmPassword must be identical !");
            }
        }

        public String Username { get; set; }

        public DateTime DateCreated { get; set; }

        public List<Product> Products { get; set; }



        public static void SetIsApproved(Provider p)
        {
            /* if (p.password == p.confirmPassword)
                 p.IsApproved = true;
             else
                 p.IsApproved = false;*/

            p.IsApproved = (p.password == p.confirmPassword);
        }

        public static void SetIsApproved(string password, string confirmPassword, bool isApproved)
        {
            isApproved = (password == confirmPassword);
        }

    }
}
