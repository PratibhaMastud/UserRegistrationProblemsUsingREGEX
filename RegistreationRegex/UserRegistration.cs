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
            String namePattern = "^([a-z]{3,})([.]{0,1}[a-z]*)@([a-z]{2}).([a-z]{2})([.]{1}[a-z]{2}){0,1}$";
            Regex obj = new Regex(namePattern);
            return obj.IsMatch(last_name);
        }
    }
}
