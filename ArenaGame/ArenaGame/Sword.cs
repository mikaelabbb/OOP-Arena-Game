using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Sword : Weapon
    {
        private const int ExtraDamageChance = 15; //chance od special attack

        public Sword() : base("Sword", 100) { }

        public override (int damage, bool isSpecial) CalculateDamage()
        {
            int damage = BaseDamage;
            bool isSpecial = false;
            if (Random.Shared.Next(100) < ExtraDamageChance)
            {
                damage = damage * 150 / 100; //+ 50% dmg
                isSpecial = true;
            }
            return (damage, isSpecial);
        }
    }
}
