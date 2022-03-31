﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regexassignment
{
    internal class Validitation
    {
        public Regex FirstnameRegex = new Regex (@"^[A-Z][A-Z a-z]{2,}$");
        public void ValidFirstName(string firstname)
        {
            Console.WriteLine("\nFirst Name:" +firstname);
            if (FirstnameRegex.IsMatch (firstname))
            {
                Console.WriteLine("First name is valid");
            }
            else
            {
                Console.WriteLine("Firstname is invalid");
             }
        }
    }
}

    
