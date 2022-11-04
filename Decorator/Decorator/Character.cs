namespace Decorator
{

    public abstract class Spawner
    {
        private static int charTypes = 2;

        public static int CharTypes { get => charTypes;}

        public abstract Character spawnCharacter();
    }

    public class NPCSpawner : Spawner
    {
        private string[] names = { "Kyle", "Stan", "Eric", "Kenny" };
        private System.Random r = new System.Random();

        public override Character spawnCharacter()
        {
            return new NPC(names[r.Next(0, names.Length)]);
        }
    }

    public class BossSpawner : Spawner
    {
        private string[] names = { "John Romero", "Hideo Kojima", "Peter Molyneux" };
        private System.Random r = new System.Random();

        public override Character spawnCharacter()
        {
            return new Boss(names[r.Next(0, names.Length)]);
        }
    }

    public abstract class Character
    {
        protected string name;

        public Character(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            string[] myType = this.GetType().ToString().Split('.');
            string type = myType[myType.Length - 1];

            return "I am " + name + ". I am a " + type + ".";
        }
    }

    public class Hero : Character
    {
        public Hero(string name) : base(name)
        {
        }
    }

    public class NPC : Character
    {

        public NPC(string name) : base(name)
        {
        }

    }

    public class PartyMember : Character
    {
        public PartyMember(string name) : base(name)
        {
        }

    }

    public class Boss : Character
    {
        public Boss(string name) : base(name)
        {

        }

    }

}
