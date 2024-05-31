using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Spear : Weapon
    {
        private const int PiercingStrikeChance = 10; //chance of special attack

        public Spear() : base("Spear", 110) { }

        public override (int damage, bool isSpecial) CalculateDamage()
        {
            int damage = BaseDamage;
            bool isSpecial = false;
            if (Random.Shared.Next(100) < PiercingStrikeChance)
            {
                damage = damage * 175 / 100; //75% extra dmg
                isSpecial = true;
            }
            return (damage, isSpecial);
        }
    }
}
