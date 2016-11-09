using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab12
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name)
        {
        }

        override public string GetRoshambo()
        {
            string rosh = "";
            Validator test = new Validator();
            rosh = "";
            while  ((rosh != null) && (!(test.validate(rosh))))
            {
                Console.Write("Please choose rock, paper, or scissors: ");
                rosh = Console.ReadLine();
                if (!(test.validate(rosh))) { Console.WriteLine("Your choice was invalid"); }

                
            }

            return roshambovalue = rosh;

        }

    }

}
