using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    public class RandomPlayer:Player
    {
        public RandomPlayer(string name) : base(name)
        {
        }

        override public string GetRoshambo()
        {
            
            Random rnd = new Random();
            int rvalue = rnd.Next(1, 4);
            
            if (rvalue == 1)
                { roshambovalue = "Rock"; }
            else if (rvalue == 2)
                { roshambovalue = "Paper"; }
            else if (rvalue == 3)
                { roshambovalue = "Scissors"; }

            
            return roshambovalue;
        }
            
        
    }
}
