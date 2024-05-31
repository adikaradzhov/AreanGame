using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public interface IWeapon
    {
        string Name { get; set; }
        double AttackDamage { get; } 
        double BlockingPower { get; }
        void SpecialAttack(); // Нов метод за специална атака
    }

    public class Dagger : IWeapon
    {
        public string Name { get; set; }
        public double AttackDamage { get; private set; }
        public double BlockingPower { get; private set; }

        public Dagger(string name)
        {
            Name = name;
            AttackDamage = 30;
            BlockingPower = 1;
        }

        public void SpecialAttack()
        {
            Console.WriteLine($"{Name} performs a quick stab, doubling the damage!");
            AttackDamage *= 2;
        }
    }

    public class Sword : IWeapon
    {
        public string Name { get; set; }
        public double AttackDamage { get; private set; }
        public double BlockingPower { get; private set; }

        public Sword(string name)
        {
            Name = name;
            AttackDamage = 20;
            BlockingPower = 10;
        }

        public void SpecialAttack()
        {
            Console.WriteLine($"{Name} swings for a mighty blow, adding 50% to the attack damage!");
            AttackDamage *= 1.5;
        }
    }
}
