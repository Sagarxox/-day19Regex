using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;

namespace regex
{
    public class UserRegistration
    {
        //regex(regular expression) to check word
        public static string name = "^[A-Z][A-za-z]{2,}";

        public static bool validate(string word)
        {
            return Regex.IsMatch(word, name);

        }
    }
}
