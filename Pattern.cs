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
    {  //regex(regular expression) as we need.
        public static string name = "^[91]{2,2}[\\s][1-9]{10,10}";

        public static bool validate(string word)
        {

            return Regex.IsMatch(word, name);

        }
    }
}
