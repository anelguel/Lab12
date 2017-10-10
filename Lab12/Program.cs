using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program 
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true)

            {
                RPSGenerator rps = new RPSGenerator();
                Rock r = new Rock(rps);
                Weapon w = new Weapon(rps);



                Console.WriteLine("Enter your name");
                string inputName = Console.ReadLine();
                Console.WriteLine("Would you like to play against TheJets or the TheSharks? (j/s)");
                string inputPlayer = Console.ReadLine();
                inputPlayer = rps.JetsSharks(inputPlayer);
                Console.WriteLine("Rock, paper, or scissors? r/p/s");
                string inputWeapon = rps.GetByString(Console.ReadLine());
                string randomWeapon = w.GenerateRPS();
                


                if (inputPlayer == "TheJets") //if user input is the JETS
                {
                    Console.WriteLine(inputName + ":" + inputWeapon + "\n" + inputPlayer + ":" + r.GenerateRPS());
                }
                else if (inputPlayer == "TheSharks")//if user input is the SHARKS
                {
                    Console.WriteLine(inputName + ":" + inputWeapon + "\n" + inputPlayer + ":" + randomWeapon);
                }


                run = Continue();
            }
        }

        public static bool Continue()//Continue Loop
        {
            Console.WriteLine("Do you wish to Continue? y/n");
            string input = Console.ReadLine();
            input = input.ToLower();
            bool goOn;
            if (input == "y")
            {
                goOn = true;
            }
            else if (input == "n")
            {
                goOn = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, let's try again");
                goOn = Continue();
            }

            return goOn;
        }
    }
}
