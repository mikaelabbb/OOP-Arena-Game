using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Bow : Weapon
    {
        private const int DistanceHitChance = 5;
        private const int InstantKillDamage = 500; //the dmg the special does

        public Bow() : base("Bow", 100) { }

        public override (int damage, bool isSpecial) CalculateDamage()
        {
            int damage = BaseDamage;
            bool isSpecial = false;
            if (Random.Shared.Next(100) < DistanceHitChance)
            {
                //check for insta kill
                if (Random.Shared.Next(100) < DistanceHitChance)
                {
                    isSpecial = true;
                    return (InstantKillDamage, isSpecial); //does 500 dmg
                }

                //if no insta kill it does dbl dmg
                damage = damage * 200 / 100;
                isSpecial = true;
            }
            return (damage, isSpecial);
        }
    }
}

