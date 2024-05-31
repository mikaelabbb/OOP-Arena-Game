namespace ArenaGame
{
    public class Arena
    {
        public Hero HeroA { get; private set; }
        public Hero HeroB { get; private set; }

        public Arena(Hero a, Hero b)
        {
            HeroA = a;
            HeroB = b;
        }

        public Hero Battle()
        {
            Hero attacker, defender;
            if (Random.Shared.Next(2) == 0)
            {
                attacker = HeroA;
                defender = HeroB;
            }
            else
            {
                attacker = HeroB;
                defender = HeroA;
            }
            while (true)
            {
                int damage = attacker.Attack();
                Console.WriteLine();
                Console.WriteLine($"{attacker.Name} attacks {defender.Name} dealing {damage} damage."); //added damage dealt
                defender.TakeDamage(damage);
                Console.WriteLine($"{defender.Name} remaining health: {Math.Max(defender.Health, 0)}"); //displays remaining health, but if it reaches negative num it still shows up as 0
                if (defender.IsDead)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{defender.Name} is dead.");
                    return attacker;
                }

                // Swap the heroes
                Hero tmp = attacker;
                attacker = defender;
                defender = tmp;
            }
        }
    }
}
