using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;



namespace RegistreationRegex
{
    class UserRegistration
    {
        public static bool regexFirstName(string last_name)
        {
            String namePattern = "^[A-Z]{1}[a-z]{2,}";
            Regex obj = new Regex(namePattern);
            return obj.IsMatch(last_name);
        }
    }
}
