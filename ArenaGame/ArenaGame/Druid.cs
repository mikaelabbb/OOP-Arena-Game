using ArenaGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public class Druid : Hero
    {
        private const int NatureHealChance = 15;
        private const int ShapeShiftChance = 10;

        public Druid(string name, Weapon weapon) : base(name, weapon)
        {

        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(ShapeShiftChance))
            {
                attack = attack * 150 / 100; //extra dmg when shapeshifting
                Console.WriteLine();
                Console.WriteLine($"{Name} just shapeshifted!");
            }
            return attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(NatureHealChance))
            {
                Heal(StartingHealth * 20 / 100);
                Console.WriteLine();
                Console.WriteLine($"{Name} used nature's healing power to restore health!");
            }
            base.TakeDamage(incomingDamage);
        }
    }
}
