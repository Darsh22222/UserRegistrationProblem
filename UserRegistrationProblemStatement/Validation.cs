using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblemStatement
{
    internal class Validation
    {
        public const string FIRST_NAME_REGEX = "^[A-Z]{1}[a-zA-Z]{2}$";
        public void FirstName(string firstname)               //UC1-In FirstName the First Letter Should Capital and minimum 3 Character
        {
            Regex regex = new Regex(FIRST_NAME_REGEX);
            bool result = regex.IsMatch(firstname);
            Console.WriteLine(result);
        }
    }
}
