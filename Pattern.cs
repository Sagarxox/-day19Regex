using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UC_5_PasswordRule1
{
    public class Pattern
    {
        public static string REGEX_CODE = "^[a-z]{8}$";
        public bool Validate_Password(string password)
        {
            return Regex.IsMatch(password, REGEX_CODE);
        }
    }
}