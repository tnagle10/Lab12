using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class RoshamboApp
    {
        static void Main(string[] args)
        {

            
            List<Player> computerPlayerList = new List<Player>();
            List<Player> humanPlayerList = new List<Player>();

            // Add a rock player named Tom
            computerPlayerList.Add(new RockPlayer("Tom"));
            // Add a random player named Landon
            computerPlayerList.Add(new RandomPlayer("Landon"));

            Console.WriteLine("Welcome to the roshambo game.  You will need to enter a name to play.");
            Console.WriteLine("You will then need to choose a player to play against.");
            Console.Write("Please enter your name: ");
            string humanPlayerName = Console.ReadLine();
            
            Console.WriteLine("Please choose one of the following player to plays against");
            foreach  (Player player in computerPlayerList)
            {
                Console.WriteLine(player.Name);
            }
            string computerPlayer = Console.ReadLine();
            Console.WriteLine(computerPlayer);

            
            // plist[0].GetRoshambo();
            //plist[1].GetRoshambo();
            //plist[2].GetRoshambo();
            

            foreach (Player player in computerPlayerList)
            {
                
                Console.WriteLine(player.Name + player.Roshambovalue);
            }
        }
    }
}
