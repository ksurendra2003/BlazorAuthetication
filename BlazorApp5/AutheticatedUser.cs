using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp5
{
    public class AutheticatedUser
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }

        public string FullName => string.Concat(First_Name," ", Last_Name);
    }
}
