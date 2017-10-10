using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Weapon : Player
    {
        public Weapon(RPSGenerator r) : base(r)
        {
            name = "rock";
            name = "paper";
            name = "scissors";
           
        }
       
        public override string GenerateRPS() //this comes from the RPS class, this will always get index 0 -- or rock
        {
            Random randomWeapon = new Random();
            int i = randomWeapon.Next(0, 3);
            return rpsList.GetByIndex(i);
        }
    }
}
