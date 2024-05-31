using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Archer : Hero
    {
        private const int CriticalHitChance = 15;
        private const int EvasionChance = 20;

        public Archer(string name, Weapon weapon) : base(name, weapon)
        {

        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(CriticalHitChance))
            {
                attack = attack * 200 / 100; //double dmg with crit
                Console.WriteLine();
                Console.WriteLine($"{Name} lands a critical hit with precision!");
            }
            return attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(EvasionChance))
            {
                incomingDamage = 0;
                Console.WriteLine();
                Console.WriteLine($"{Name} evades the attack!");
            }
            base.TakeDamage(incomingDamage);
        }
    }
}
