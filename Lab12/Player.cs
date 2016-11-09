using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    public abstract class Player
    {
        private string name;
        protected string roshambovalue;

        public Player(string name)
        {
            Name = name;
            
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Roshambovalue
        {
            get
            {
                return roshambovalue;
            }

           
        }

        abstract public string GetRoshambo();
        


    }
}
