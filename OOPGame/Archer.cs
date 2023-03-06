using System;
using OOPGame;

namespace RPG
{
    public class Archer : Unit
    {
        public override int Damage { get; set; } = 30;
        public override int HP { get; set; } = 50;
        public override void Attack()
        {
            Console.WriteLine($"Archer shoots a bow and applies damage:-{Damage}, HP: {HP}");
        }
    }
}