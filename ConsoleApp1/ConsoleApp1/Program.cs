using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Unit
    {
        protected int x;

        public Unit(int x)
        {
            this.x = x;
        }
    }

    class Melee : Unit
    {
        public int X { get => base.x; set => base.x = value; }
        public Melee(int x) : base(x)
        {

        }
    }
    class Ranged : Unit
    {
        public int X { get => base.x; set => base.x = value; }
        public Ranged(int x) : base(x)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Random r = new Random();
            Unit[] units = new Unit[5];
            for (int i = 0; i < units.Length; i++)
            {
                int type = r.Next(0, 2);
                switch (type)
                {
                    case 0:
                        units[i] = new Melee(r.Next(0, 20));
                        break;
                    case 1:
                        units[i] = new Ranged(r.Next(0, 20));
                        break;
                }
            }

            foreach (Unit temp in units)
            {
                printX(temp);
            }
        }

        static void printX(Unit u)
        {
            string unitType = u.GetType().ToString();
            string[] arr = unitType.Split('.');
            unitType = arr[arr.Length - 1];

            if (unitType == "Melee")
            {
                Melee temp = (Melee)u;
                Console.WriteLine("I am a Melee my x is " + temp.X);
            }
            else
            {
                    Ranged temp = (Ranged)u;
                    Console.WriteLine("I am a Ranged my x is " + temp.X);
            }
            


           
        }
    }
}
