using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Crossbow : Weapon
    {

        private const int BoltBarrageChance = 10; //chance of special attack

        public Crossbow() : base("Crossbow", 90) { }

        public override (int damage, bool isSpecial) CalculateDamage()
        {
            int damage = BaseDamage;
            bool isSpecial = false;
            if (Random.Shared.Next(100) < BoltBarrageChance)
            {
                damage = damage * 200 / 100; //double dmg
                isSpecial = true;
            }
            return (damage, isSpecial);
        }
    }
}
