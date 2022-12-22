using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UC_6_PasswordRule2
{
    public class Pattern
    {
        public static string REGEX_CODE = "^[a-zA-Z]{8}$";
        public bool Validate_Password(string password)
        {
            return Regex.IsMatch(password, REGEX_CODE);
        }
    }
}