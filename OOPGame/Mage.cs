using System;
using OOPGame;

namespace RPG
{
    public class Mage : Unit
    {
        public override int Damage { get; set; } = 20;
        public override int HP { get; set; } = 80;
        public override void Attack()
        {
            Console.WriteLine($"Mage using fireball and applies damage:-{Damage}, HP: {HP}");
        }
    }
}