using ArenaGame;

namespace ConsoleGame
{
    internal class Program
    {

        static Random random = new Random();
        static void Main(string[] args)
        {
            Console.Write("Enter number of battles:");
            int rounds = Int32.Parse(Console.ReadLine());
            int oneWins = 0, twoWins = 0;

            for (int i = 0; i < rounds; i++)
            {
                //creating(assigning) the weapons
                Weapon weaponOne = GetRandomWeapon();
                Weapon weaponTwo = GetRandomWeapon();

                //giving weapons to the heros

                //old hero classes
                //Hero one = new Knight("Sir Lancelot", weaponOne);
                //Hero two = new Rogue("Robin Hood", weaponTwo);

                //new hero classes and their assigned weapons
                Hero one = new Druid("Shrek", weaponOne);
                Hero two = new Archer("Lord Farquaad", weaponTwo);

                Console.WriteLine();
                Console.WriteLine($"Arena fight between: {one.Name} with {one.Weapon.Name} and {two.Name} with {two.Weapon.Name}"); //names of herod and their weapons
                Console.WriteLine($"{one.Name} health: {one.Health}, {two.Name} health: {two.Health}"); //heros starting health
                Arena arena = new Arena(one, two);
                Hero winner = arena.Battle(); //using updated battle method 
                Console.WriteLine($"Winner is: {winner.Name}");
                if (winner == one) oneWins++; else twoWins++;
            }
            Console.WriteLine();
            Console.WriteLine($"One has {oneWins} wins.");
            Console.WriteLine($"Two has {twoWins} wins.");

            Console.ReadLine();
        }

        //random weapon selection
        static Weapon GetRandomWeapon()
        {
            switch (random.Next(4))
            {
                case 0: return new Sword();
                case 1: return new Spear();
                case 2: return new Bow();
                case 3: return new Crossbow();
                default: throw new InvalidOperationException("Invalid weapon selection.");
            }
        }
    }
}
