using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authority.Common.User
{
    public class LoginUser
    {
        public string Name { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }

        public string Mobile { get; set; }

        public string Email { get; set; }

        public long QQ { get; set; }

        public string CheckCode { get; set; }

        public bool Remember { get; set; }

    }
}
