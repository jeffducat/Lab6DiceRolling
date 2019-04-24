using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6DiceRolling
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run;

            Console.WriteLine("Welcome to the Grand Circus Casino! "); 
            run = DiceRollerApp.Continue("Roll the pair of dice? (y / n)", "y", "n");

            while(run)
            {
                int userSides = DiceRollerApp.GetUserSides("How many sides are on your pair of dice?");
                Random r = new Random();
                int die1 = r.Next(1, userSides + 1);
                int die2 = r.Next(1, userSides + 1);
                Console.WriteLine("your first dice roll results are " + die1);
                Console.WriteLine("your second dice roll results are " + die2);
                run = DiceRollerApp.Continue("Roll Again? (y / n)", "y", "n");
            }
            Console.WriteLine("Thanks for playing!");
            Console.ReadKey();
        }
   }
}
