using System;

namespace Tuples
{
    class Program
    {
        private static Random rnd;

        /*
        private static object[] GetStuff1() 
        {
            // Create array of type objects with 3 "houses"
            object[] objs = new object[3];
            objs[0] = rnd.Next();
            objs[1] = rnd.NextDouble(); // Retorna um valor entre 0 e 1;
            objs[2] = rnd.NextDouble() < 0.5;

            return objs;
        }*/

        /*
    private static Stuff GetStuff() 
    {
        return new Stuff(rnd.Next(), rnd.NextDouble(), rnd.NextDouble() < 0.5);
    }*/
        /*
        /// <summary>
        /// Method to return random numbers with keyword out
        /// </summary>
        /// <param name="a"> Receive int</param>
        /// <param name="b"> Receive double</param>
        /// <param name="c"> Receive bool</param>
        private static void GetStuff(out int a, out double b, out bool c) 
        {
            a = rnd.Next();
            b = rnd.NextDouble();
            c = rnd.NextDouble() < 0.5;
        }*/

        private static Tuple<int, double, bool> GetStuff() 
        {
            Tuple<int, double, bool> stuff = new Tuple<int, double, bool>
                (rnd.Next(), rnd.NextDouble(), rnd.NextDouble() < 0.5);
            return stuff;
        }


        static void Main(string[] args)
        {
            rnd = new Random();

            Tuple<int, double, bool> t = GetStuff();

            Console.WriteLine("In= "+ t.Item1 + " do= "+ t.Item2 + " Bo= "+ t.Item3);

            Console.WriteLine();
        }
    }
}
