using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    public class RockPlayer : Player
    {
        public RockPlayer(string name) : base(name)
        {
            
        }

        override public string GetRoshambo()
        {
            roshambovalue= "Rock";
            return roshambovalue;
        }

    }
}
