using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab12;
using System.Collections;
using System.Collections.Generic;



namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<Player> plist = new List<Player>();
            plist.Add(new RockPlayer("Tom"));
            plist.Add(new RandomPlayer("Landon"));

            RockPlayer p1 = new RockPlayer("Tom");
            string rvalue = p1.GetRoshambo();
            Assert.AreEqual("Rock", rvalue);
            RandomPlayer r1 = new RandomPlayer("Landon");
            rvalue = r1.GetRoshambo();
            bool good = testRandom(rvalue);
            Assert.AreEqual(true,good);

            foreach (var Player in plist)
            {
                Console.WriteLine(Player.Name + Player.Roshambovalue);
            }
        }

        public bool testRandom(string rosh)
        {
            if ((rosh == "Rock") || (rosh == "Paper") || (rosh == "Scissors"))
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



