using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
  public  class Provider
    {
        public String ConfirmPassword { get; set; }

        public String Email { get; set; }

        public int ProviderId { get; set; }

        public Boolean IsApproved { get; set; }

        public String Password { get; set; }

        public String Username { get; set; }

        public DateTime DateCreated { get; set; }

    }
}
