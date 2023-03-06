using System;
using OOPGame;

namespace RPG
{
    public class Knight : Unit
    {
        public override int Damage { get; set; } = 15;
        public override int HP { get; set; } = 100;
        public override void Attack()
        {
            Console.WriteLine($"Knight attack and applies damage:-{Damage}, HP: {HP}");
        }
    }
}