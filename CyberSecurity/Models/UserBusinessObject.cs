using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CyberSecurity.Models
{
    public class UserBusinessObject
    {
        public int userID { get; set; }
        public string userName { get; set; }
        public string userSurname { get; set; }

        public string userEmailAddress { get; set; }

        public char userPassword { get; set; }

    }
}