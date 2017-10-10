using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Rock : Player //this is a class inherited by the player class
    {
       
        public Rock(RPSGenerator r) : base (r) //this class will always spit out Rock??
        {
            name = "rock";
            
        }

        public override string GenerateRPS() //this comes from the RPS class, this will always get index 0 -- or rock
        {
            return rpsList.GetByIndex(0);
        }
    }
}
