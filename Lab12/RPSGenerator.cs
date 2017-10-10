using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class RPSGenerator
    {
        List<string> rps = new List<string>(); //created a list with rock, paper and scissors

        public RPSGenerator()
        {
            rps.Add("rock");
            rps.Add("paper");
            rps.Add("scissors");
        }

        public string GetByString(string input) //this is what the user input will be (r, p, or s)
        {
            if (input == "r")
            {
                return rps[0];
            }
            else if (input == "p")
            {
                return rps[1];
            }
            else if (input == "s")
            {
                return rps[2];
            }
            return "-1";
        }

        public string GetByIndex(int i) // will catch errors if user input for r/p/s is not "r" or "p" or "s"
        {
            string output;
            try
            {
                output = rps[i];
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("that was not a valid index no");
                output = "-1";
            }
            return output;
        }

        public string JetsSharks(string input)
        {
            if (input == "j")
            {
                return "TheJets";
            }
            else if (input == "s")
            {
                return "TheSharks";
            }
            else
            {
                return "I don't understand";
            }
        }

        
        
    }
}


