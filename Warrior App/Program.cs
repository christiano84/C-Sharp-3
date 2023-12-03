using System;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{

    public class Program
    {

        // ------ FUNCTIONS ----------
      

        // ------ END OF FUNCTIONS ------


        static void Main(string[] args)
        {
            Warrior thor = new Warrior("Thor", 100, 26, 10);
            MagicWarrior loki = new MagicWarrior("Loki", 75, 20, 10, 50);

            Battle.StartFight(thor, loki);
    
        }   
    }
}
    