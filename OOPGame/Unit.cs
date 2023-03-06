namespace OOPGame
{
    public abstract class Unit
    {
        public abstract void Attack();
        public abstract int Damage { get; set; }
        public abstract int HP { get; set; }
    }
}