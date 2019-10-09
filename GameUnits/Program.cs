using System;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int movement = rnd.Next();

            Unit u1 = new MilitaryUnit(movement);
            Unit u2 = new SettlerUnit(movement);

            u1.Move();
            Console.WriteLine("Health = " + u1.Health + " Value = " + u1.Value);
            Console.WriteLine();
            u2.Move();
            Console.WriteLine("Health = " + u2.Health + " Value = " + u2.Value);
        }
    }
}
