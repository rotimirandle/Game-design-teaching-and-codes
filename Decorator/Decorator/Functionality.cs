namespace Decorator
{
    public abstract class Functionality : Character
    {


        protected Character c;
    }

    public class Fighting : Functionality
    {
        private int hp, atk, def;

        public Fighting(Character c, int hp, int atk, int def)
        {
            this.c = c;
            this.hp = hp;
            this.atk = atk;
            this.def = def;
        }

        public void TakeDamage(int damage)
        {
            hp -= damage - def;
        }

        public string DisplayStats()
        {
            return "HP: " + hp + "\n" + "ATK: " + atk + "\n" + "DEF: " + def;
        }

        public override string ToString()
        {
            return c.ToString() + "\n" +  DisplayStats();
        }
    }

    public class Talking : Functionality
    {
        private string[] barks;

        public Talking(Character c, string[] barks)
        {
            this.c = c;
            this.barks = barks;
        }

        public string SayBark()
        {
            System.Random r = new System.Random();

            return barks[r.Next(0, barks.Length)];

        }

        public override string ToString()
        {
            return c.ToString() + "\n" + SayBark();
        }
    }
}
