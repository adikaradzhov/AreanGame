using ArenaGame;
using ArenaGame.Heroes;
using ArenaGame.Weapons;
using System.Threading;

namespace ConsoleArenaGame
{
    /*
    class Program
    {
        static void ConsoleNotification(GameEngine.NotificationArgs args)
        {
            Console.WriteLine($"{args.Attacker.Name} attacked {args.Defender.Name} with {Math.Round(args.Attack,2)} and caused {Math.Round(args.Damage,2)} damage.");
            Console.WriteLine($"Attacker: {args.Attacker}");
            Console.WriteLine($"Defender: {args.Defender}");
        }
        static void Main(string[] args)
        {
            GameEngine gameEngine = new GameEngine()
            {
                HeroA = new Knight("Knight", 10, 20, new Sword("Sword")),
                HeroB = new Assassin("Assassin", 10, 5, new Dagger("Dagger")),
                NotificationsCallBack = ConsoleNotification
                //NotificationsCallBack = args => Console.WriteLine($"{args.Attacker.Name} attacked {args.Defender.Name} with {args.Attack} and caused {args.Damage} damage.")
            };

            gameEngine.Fight();

            Console.WriteLine();
            Console.WriteLine($"And the winner is {gameEngine.Winner}");
        }
    }*/
    class Program
    {
        static void ConsoleNotification(GameEngine.NotificationArgs args)
        {
            Console.WriteLine($"{args.Attacker.Name} attacked {args.Defender.Name} with {Math.Round(args.Attack, 2)} and caused {Math.Round(args.Damage, 2)} damage.");
            Console.WriteLine($"Attacker: {args.Attacker}");
            Console.WriteLine($"Defender: {args.Defender}");
        }

        static void Main(string[] args)
        {
            // Initialize new weapons with special capabilities
            var enhancedSword = new ArenaGame.Sword("Enhanced Sword");
            enhancedSword.SpecialAttack();  // Demonstrating special attack enhancement

            var poisonDagger = new ArenaGame.Dagger("Poison Dagger");
            poisonDagger.SpecialAttack();  // Applying special poison effect

            // Adding new hero classes
            var wizard = new Wizard("Gandalf", 8, 25, new MagicWand("Magic Wand"));
            var warrior = new Warrior("Conan", 15, 30, enhancedSword);

            GameEngine gameEngine = new GameEngine()
            {
                HeroA = warrior,  // Using the newly created warrior with an enhanced sword
                HeroB = new Assassin("Assassin", 10, 5, poisonDagger),  // Assassin now uses a poison dagger
                NotificationsCallBack = ConsoleNotification
            };

            gameEngine.Fight();

            Console.WriteLine();
            Console.WriteLine($"And the winner is {gameEngine.Winner.Name} with health remaining: {gameEngine.Winner.Health}");
        }
    }

    internal class Warrior : Hero
    {
        public Warrior(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
        {
        }
    }

    internal class MagicWand : IWeapon
    {
        private string v;

        public MagicWand(string v)
        {
            this.v = v;
        }

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double AttackDamage => throw new NotImplementedException();

        public double BlockingPower => throw new NotImplementedException();

        public void SpecialAttack()
        {
            throw new NotImplementedException();
        }
    }
}