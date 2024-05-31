using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public abstract class Weapon
    {
        public string Name { get; private set; }
        public int BaseDamage { get; private set; }

        public Weapon(string name, int baseDamage)
        {
            Name = name;
            BaseDamage = baseDamage;
        }

        public abstract (int damage, bool isSpecial) CalculateDamage();
    }
}
