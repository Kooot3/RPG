namespace RPG
{
    public class GameProgram
    {
        public static void Main(string[] args)
        {
            var knight = new Knight();
            knight.Attack();
            

            var mage = new Mage();
            mage.Attack();

            var archer = new Archer();
            archer.Attack();
        }
    }

}