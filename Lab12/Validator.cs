using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    public class Validator
    {
        public bool validate(string rosh)
        {
            string lower = rosh.ToLower();
            if ((rosh == "rock") || (rosh == "paper") || (rosh == "scissors"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
