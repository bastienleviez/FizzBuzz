using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzChecker
    {
        static public string PlayFizzBuzz(int entree)
        {
            if (entree <= 0)
            {
                throw new ArgumentException();

            } 
            else
            {
                if (entree % 3 == 0)
                {
                    return "Fizz";
                }

                return "";
            }
        }
    }
}
